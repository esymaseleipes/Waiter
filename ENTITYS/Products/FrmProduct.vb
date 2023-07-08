Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.Controls
Imports WaiterModel.Cmp300
Imports WindowsApplication1
Imports WindowsApplication1.Cmp300

Public Class FrmProduct
    Public Property Product As SMAST
    Dim ses As Session

    Public Sub New()
        InitializeComponent()
        ses = ClsShareFunctions.GetNewSession
        Product = New SMAST(ses)
        InitCollections()

    End Sub
    Public Sub New(_ses As Session)
        InitializeComponent()
        ses = _ses
        '.sCode = ClsShareFunctions.RetLastSmastCode(LueOmada.EditValue, LueYpoomada.EditValue, 3)
        Product = New SMAST(ses) With {.sCode = ClsShareFunctions.RetLastSmastCode(
            LueOmada.EditValue, LueYpoomada.EditValue, 3),
            .sUsrNums1 = 0,
            .sUsrNums2 = 0}
        ChkEnabled.Checked = True
        InitCollections()

    End Sub
    Public Sub New(_obj As SMAST)
        InitializeComponent()
        Product = _obj
        ses = _obj.Session
        InitCollections()
        ShowData()
    End Sub

    Private Sub ShowData()
        TxtDescr1.Text = Product.sName
        TxtDescr2.Text = Product.sComments
        TxtBarCode.Text = Product.sFactCode
        TxtxPrice.Text = Product.sWhsalePr
        TxtlPrice.Text = Product.sRetailPr
        ChkShowOnWeb.Checked = Product.sUsrNums6
        ChkMono.Checked = Product.WaiterIndex
        LueCategory.EditValue = Product.NrgCategory
        LueOmada.EditValue = Product.NrgOmada
        LueYpoomada.EditValue = Product.NrgYpoomada
        CmbPrinter.EditValue = Product.DefPrinter
        CmbVat.EditValue = Product.TheVat
        CmbMM.EditValue = ses.FindObject(Of STOCKUNIT)(New BinaryOperator("sunCode", Product.sUnitOM))
        PictureEdit1.EditValue = Product.Photo
        CmbOrderPosition.EditValue = Product.OrderPosition
        If Product.sUsrNums1 = 0 Then
            ChkEnabled.Checked = True
        Else
            ChkEnabled.Checked = False
        End If

        ChkQnt.Checked = Product.sUsrNums2
        txtRemain.Text = Product.sUsrNums3

    End Sub

    Private Function InitParalelPrinters() As Boolean
        ChkPrinter1.Text = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer1Descr", "")
        ChkPrinter2.Text = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer2Descr", "")
        ChkPrinter3.Text = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer3Descr", "")
        ChkPrinter4.Text = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer4Descr", "")
        ChkPrinter5.Text = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer5Descr", "")
        ChkPrinter1.Checked = Product.Printer1
        ChkPrinter2.Checked = Product.Printer2
        ChkPrinter3.Checked = Product.Printer3
        ChkPrinter4.Checked = Product.Printer4
        ChkPrinter5.Checked = Product.Printer5
        If ChkPrinter1.Text = "" Then LayoutControlItem17.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        If ChkPrinter2.Text = "" Then LayoutControlItem18.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        If ChkPrinter3.Text = "" Then LayoutControlItem19.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        If ChkPrinter4.Text = "" Then LayoutControlItem20.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        If ChkPrinter5.Text = "" Then LayoutControlItem21.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Function


    Private Sub InitCollections()
        FpaCollection.Session = ses
        OmadaCollection.Session = ses
        CategoryCollection.Session = ses
        YpoomadaCollection.Session = ses
        MMCollection.Session = ses
        VatCollection.Session = ses
        CmbPrinter.Properties.DataSource = ClsShareFunctions.GetAvalablePrinters
        CmbOrderPosition.Properties.Items.AddEnum(GetType(EnOrderPosition))
        Dim retbb As Boolean = InitParalelPrinters()
    End Sub
    Private Sub LueCategory_EditValueChanged(sender As Object, e As EventArgs) Handles LueCategory.EditValueChanged
        Dim Cat As SSEAZON = LueCategory.EditValue
        If Not Cat Is Nothing Then
            LueOmada.Properties.DataSource = Cat.STORFEAT1s
            If Cat.STORFEAT1s.Count > 0 Then LueOmada.EditValue = Cat.STORFEAT1s(0)
        Else
            LueOmada.Properties.DataSource = Nothing
            LueYpoomada.Properties.DataSource = Nothing
        End If
    End Sub
    Private Sub LueOmada_EditValueChanged(sender As Object, e As EventArgs) Handles LueOmada.EditValueChanged
        Dim Omada As STORFEAT1 = LueOmada.EditValue
        If Not Omada Is Nothing Then
            LueYpoomada.Properties.DataSource = Omada.STORFEAT2s
            If Omada.STORFEAT2s.Count > 0 Then LueYpoomada.EditValue = Omada.STORFEAT2s(0)
        Else
            LueYpoomada.Properties.DataSource = Nothing
        End If

    End Sub


    Private Function CheckConditions() As Boolean
        Dim cat As SSEAZON = LueCategory.EditValue
        Dim Omada As STORFEAT1 = LueOmada.EditValue
        Dim Ypoomada As STORFEAT2 = LueYpoomada.EditValue
        Dim mm As STOCKUNIT = CmbMM.EditValue
        Dim ovat As VAT = CmbVat.EditValue

        If TxtDescr1.Text = "" Then
            MsgBox("Προσοχή η Περιγραφή το Είδους είναι κενή!!!!")
            Return False
        End If

        If cat Is Nothing Then
            MsgBox("Προσοχή η Κατηγορία είναι κενή!!!!")
            Return False
        End If

        If Omada Is Nothing Then
            MsgBox("Προσοχή η Ομάδα είναι κενή!!!!")
            Return False
        End If
        If Ypoomada Is Nothing Then
            MsgBox("Προσοχή η Υποομάδα είναι κενή!!!!")
            Return False
        End If

        If mm Is Nothing Then
            MsgBox("Προσοχή η Μονάδα Μέτρησης είναι κενή!!!!")
            Return False
        End If

        If ovat Is Nothing Then
            MsgBox("Προσοχή το  ΦΠΑ είναι κενό!!!!")
            Return False
        End If


        Return True

    End Function

    Private Sub Photo(img As Image)
        'Dim koukouformat As KoukouPhoto.CW.Core.Utils.ImgFormat = KoukouPhoto.CW.Core.Utils.Images.GetImageFormat(img)
        'Dim isnewpic As Boolean = True
        'Dim bd As Byte() = KoukouPhoto.CW.Core.Utils.Images.Refactor(img, New Size(800, 0), KoukouPhoto.CW.Core.Utils.ResizeMode.NormalIfBigger)


    End Sub


    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click


        If CheckConditions() = False Then Exit Sub
        Dim newproduct As Boolean = ses.IsNewObject(Product)
        Try
            Dim cat As SSEAZON = LueCategory.EditValue
            Dim Omada As STORFEAT1 = LueOmada.EditValue
            Dim Ypoomada As STORFEAT2 = LueYpoomada.EditValue
            Dim mm As STOCKUNIT = CmbMM.EditValue
            With Product
                If newproduct Then
                    .sCode = ClsShareFunctions.RetLastSmastCode(LueOmada.EditValue, LueYpoomada.EditValue, 3)
                    '.sCode = (.sFileId.ToString("0000"))
                    .sRelCode = .sCode
                    .Sortid = 100
                End If
                .sName = TxtDescr1.Text
                .sComments = TxtDescr2.Text
                .sFactCode = TxtBarCode.Text
                .sWhsalePr = TxtxPrice.Text
                .sRetailPr = TxtlPrice.Text
                .sUsrNums6 = ChkShowOnWeb.Checked
                .sSeason = cat.sseFileId
                .sFeature1 = Omada.sFeature1
                .sFeature2 = Ypoomada.sFeature2
                .NrgCategory = cat
                .NrgOmada = Omada
                .NrgYpoomada = Ypoomada
                .sVATCode = CType(CmbVat.EditValue, VAT).FpaCode
                .sName_srt = .sName
                .sPlace = ""
                .DefPrinter = CmbPrinter.EditValue
                .sUnitOM = mm.sunCode
                .Photo = PictureEdit1.EditValue
                .WaiterIndex = ChkMono.Checked
                .OrderPosition = CmbOrderPosition.EditValue


                If ChkEnabled.Checked = True Then
                    .sUsrNums1 = 0
                Else
                    .sUsrNums1 = 1
                End If

                .sUsrNums2 = ChkQnt.Checked
                If .sUsrNums2 = 0 Then
                    .sUsrNums3 = 0
                Else
                    .sUsrNums3 = txtRemain.Text
                End If


                .Printer1 = ChkPrinter1.Checked
                .Printer2 = ChkPrinter2.Checked
                .Printer3 = ChkPrinter3.Checked
                .Printer4 = ChkPrinter4.Checked
                .Printer5 = ChkPrinter5.Checked


            End With
            Product.Save()
            If newproduct = True Then
                If MsgBox("Η Καταχώρηση Ολοκληρώθηκε Θέλετε να συνεχίσετε με νέα Καταχώρηση?", vbYesNo) = vbYes Then
                    TxtDescr1.Text = ""
                    TxtDescr2.Text = ""
                    TxtBarCode.Text = ""
                    Product = New SMAST(ses)
                    'InitBinding()
                End If
            Else
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error:FrmProduct Error=" & ex.Message)
        End Try

    End Sub

    Private Sub BtnEsc_Click(sender As Object, e As EventArgs) Handles BtnEsc.Click
        Me.Close()
    End Sub

    Private Sub LueYpoomada_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles LueYpoomada.ButtonClick
        Dim f3 As StorFeat2Frm
        Dim omada As STORFEAT1 = LueOmada.EditValue
        Dim ypoomad As STORFEAT2 = LueYpoomada.EditValue

        If omada Is Nothing Then
            MsgBox("Δέν έχετε Επιλέξει Ομάδα!!!")
            Return
        End If

        If e.Button.Kind = ButtonPredefines.Plus Then
            f3 = New StorFeat2Frm(New STORFEAT2(ses) With {.Parent = omada})
            If f3.ShowDialog() = DialogResult.OK Then
                f3.Obj.Save()
                YpoomadaCollection.Reload()
            End If
        End If

        If e.Button.Kind = ButtonPredefines.Undo Then

            If ypoomad Is Nothing Then Return
            f3 = New StorFeat2Frm(ypoomad)
            If f3.ShowDialog() = DialogResult.OK Then
                f3.Obj.Save()
                YpoomadaCollection.Reload()
            End If
        End If

        If e.Button.Kind = ButtonPredefines.Ellipsis Then
            Dim frmcommen As FrmProductComments = New FrmProductComments(ypoomad)
            frmcommen.ShowDialog()
        End If




    End Sub
    Private Sub LueOmada_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles LueOmada.ButtonClick
        Dim f3 As StorFeat1Frm
        Dim Cat As SSEAZON = LueCategory.EditValue

        If e.Button.Kind = ButtonPredefines.Plus Then
            If Cat Is Nothing Then
                MsgBox("Δέν έχετε Επιλέξει Κατηγορία!!!")
            Else
                f3 = New StorFeat1Frm(New STORFEAT1(ses) With {.Category = Cat})
                If f3.ShowDialog() = DialogResult.OK Then
                    f3.Obj.Save()
                    OmadaCollection.Reload()
                End If
            End If
        End If


        If e.Button.Kind = ButtonPredefines.Undo Then
            Dim omad As STORFEAT1 = LueOmada.EditValue
            If omad Is Nothing Then Return
            f3 = New StorFeat1Frm(omad)
            If f3.ShowDialog() = DialogResult.OK Then
                f3.Obj.Save()
                OmadaCollection.Reload()
            End If
        End If
    End Sub
    Private Sub LueCategory_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles LueCategory.ButtonClick
        Dim f1 As FrmSeason
        If e.Button.Kind = ButtonPredefines.Plus Then
            f1 = New FrmSeason(New SSEAZON(ses))
            If f1.ShowDialog() = DialogResult.OK Then
                f1.Obj.Save()
                CategoryCollection.Reload()
            End If
        End If
        If e.Button.Kind = ButtonPredefines.Undo Then
            Dim CAT As SSEAZON = LueCategory.EditValue
            If CAT Is Nothing Then Return
            f1 = New FrmSeason(CAT)
            If f1.ShowDialog() = DialogResult.OK Then
                f1.Obj.Save()
                CategoryCollection.Reload()
            End If
        End If
    End Sub

    Private Sub CmbVat_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles CmbVat.ButtonClick
        Dim f As FrmFpa

        If e.Button.Kind = ButtonPredefines.Plus Then
            f = New FrmFpa(New VAT(ses))
            If f.ShowDialog() = DialogResult.OK Then f.fpa.Save()
            VatCollection.Reload()
        End If

        If e.Button.Kind = ButtonPredefines.Undo Then
            Dim _fpa As VAT = CmbVat.EditValue
            If _fpa Is Nothing Then
                MsgBox("Το πεδίο ΦΠΑ είναι κενό!!!")
            Else
                f = New FrmFpa(_fpa)
                If f.ShowDialog() = DialogResult.OK Then f.fpa.Save()
                VatCollection.Reload()
            End If
        End If


    End Sub


    Private Sub ChkQnt_CheckedChanged(sender As Object, e As EventArgs) Handles ChkQnt.CheckedChanged
        If ChkQnt.Checked = True Then
            LCI_Remain.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            LCI_Remain.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If
    End Sub
End Class