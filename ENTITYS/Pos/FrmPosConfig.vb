Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraLayout
Imports WaiterModel.Cmp300
Imports WindowsApplication1.Cmp300

Public Class FrmPosConfig
    Dim ses As Session
    Dim poscnfg As PosCnfg
    Dim receiptheader As ReceiptHeaderLines
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(_Ypok As SUBSIDS)
        InitializeComponent()
        ses = _Ypok.Session
        Printers.AutoSaveOnEndEdit = True
        If _Ypok.PosCnfgs.Count = 0 Then
            PrinterControlGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            poscnfg = New PosCnfg(ses) With {.Station = _Ypok}
        Else
            poscnfg = _Ypok.PosCnfgs(0)
        End If


        receiptheader = ses.FindObject(Of ReceiptHeaderLines)(New BinaryOperator("Parent", poscnfg))
        If receiptheader Is Nothing Then
            receiptheader = New ReceiptHeaderLines(ses) With {.Parent = poscnfg}
        End If
        InitBindReceiptHeader()

        InitForm()
        SetFormData()
    End Sub

    Private Sub InitBindReceiptHeader()
        txtLogo1.DataBindings.Add(New Binding("Text", receiptheader, "TitleLine1"))
        txtLogo2.DataBindings.Add(New Binding("Text", receiptheader, "TitleLine2"))
        txtLogo3.DataBindings.Add(New Binding("Text", receiptheader, "TitleLine3"))
        txtLogo4.DataBindings.Add(New Binding("Text", receiptheader, "TitleLine4"))
        txtLogo5.DataBindings.Add(New Binding("Text", receiptheader, "FooterLine1"))

    End Sub


    Private Sub InitForm()
        Try
            CmbCashMachine.Properties.AddEnum(Of EnCashRegisterBrand)()

            Dim ProductCollection As XPCollection(Of SSEAZON) = New XPCollection(Of SSEAZON)(ses)

            CmbCashMachineBehavior.Properties.Items.AddEnum(GetType(EnCashRegisterBehavior))
            CmbReciptBehavior.Properties.Items.AddEnum(GetType(EnReceiptBehavior))
            CmbReciptPrinter.Properties.DataSource = ClsShareFunctions.GetAvalablePrinters
            CmbCloneReciptPrinter.Properties.DataSource = ClsShareFunctions.GetAvalablePrinters

            CmbCommentPrintType.Properties.Items.AddEnum(GetType(EnCommentPrintType))
            CmbPosPrintLanguage.Properties.Items.AddEnum(GetType(EnPosPrintLang))
            With CmpProductCategory.Properties
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sseFileId", "sse File Id", 71, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sseDescr", "Περιγραφή", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
                .DataSource = ProductCollection
                .DisplayMember = "sseDescr"
                .ValueMember = "This"
            End With



            With CmbProductOmada.Properties
                .DataSource = poscnfg.ProductCategory.STORFEAT1s
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sFeatureId", "Id", 71, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tsDescr1", "Περιγραφή Ομάδα", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
                .DisplayMember = "tsDescr1"
                .ValueMember = "This"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            'EnOrderStatus
        End Try
    End Sub

    Private Sub SetFormData()
        With poscnfg
            CmbCashMachine.EditValue = .CashRegisterBrand
            CmbCashMachineBehavior.EditValue = .CashRegisterBehavior
            CmbReciptBehavior.EditValue = .ReceiptBehavior
            CmbReciptPrinter.EditValue = .ReceiptPrinter
            CmbCloneReciptPrinter.EditValue = .CloneReceiptPrinter

            CmbCommentPrintType.EditValue = .CommentPrintType
            CmbPosPrintLanguage.EditValue = .PosPrintLang
            chkRoom.Checked = .RoomManager
            CmpProductCategory.EditValue = .ProductCategory

            ChkErp.Checked = .ErpConnect
            CheckAutoOrderKerasma.Checked = .AutoKerasmaOrder
            ChkShowDetailOnPrintServer.Checked = .ShowDetailOnPrintServer
            ChkShowOrderNumOnReceipt.Checked = .ShowFooterOnReceipt
            If Not .ProductCategory Is Nothing Then CmbProductOmada.EditValue = .ProductCategory.STORFEAT1s(0)
            txtPosNullLines.Text = .PosOrderNullLines

            txtTamIp.Text = .TamIp
            BtnFiscalPath.Text = .FiscalPath
        End With
    End Sub
    Private Sub GetFormData()
        With poscnfg
            .CashRegisterBrand = CmbCashMachine.EditValue
            .CashRegisterBehavior = CmbCashMachineBehavior.EditValue
            .ReceiptBehavior = CmbReciptBehavior.EditValue
            .ReceiptPrinter = CmbReciptPrinter.EditValue
            .CloneReceiptPrinter = CmbCloneReciptPrinter.EditValue

            .PosPrintLang = CmbPosPrintLanguage.EditValue
            .RoomManager = chkRoom.Checked
            .ProductCategory = CmpProductCategory.EditValue
            .ErpConnect = ChkErp.Checked
            .AutoKerasmaOrder = CheckAutoOrderKerasma.Checked
            .ShowDetailOnPrintServer = ChkShowDetailOnPrintServer.Checked
            .ShowFooterOnReceipt = ChkShowOrderNumOnReceipt.Checked
            .CommentPrintType = CmbCommentPrintType.EditValue
            .PosOrderNullLines = txtPosNullLines.Text

            .TamIp = txtTamIp.Text

            .FiscalPath = BtnFiscalPath.Text

        End With



    End Sub
    'Private Sub InitDataBinding()
    '    CmbCashMachineBehavior.DataBindings.Add(New Binding("EditValue", poscnfg, "CashRegisterBehavior", True))
    '    CmbReciptBehavior.DataBindings.Add(New Binding("EditValue", poscnfg, "ReceiptBehavior", True))
    '    CmbReciptPrinter.DataBindings.Add(New Binding("Text", poscnfg, "ReceiptPrinter", True))
    '    CmbCloneReciptPrinter.DataBindings.Add(New Binding("Text", poscnfg, "CloneReceiptPrinter", True))
    '    CmbDefaultCustomer.DataBindings.Add(New Binding("EditValue", poscnfg, "DefaultCustomer", True))
    '    CmbDefaultTrnums.DataBindings.Add(New Binding("EditValue", poscnfg, "DefaultOrderTrnums", True))
    '    chkRoom.DataBindings.Add(New Binding("EditValue", poscnfg, "RoomManager", True))
    '    CmpProductCategory.DataBindings.Add(New Binding("EditValue", poscnfg, "ProductCategory", True))
    'End Sub
    Private Sub CmbProductOmada_EditValueChanged(sender As Object, e As EventArgs) Handles CmbProductOmada.EditValueChanged

        If TabbedControlGroup1.SelectedTabPageName = "PrinterControlGroup" Then
            ShowOmadaPrinters(CmbProductOmada.EditValue)
        Else
            GridControl1.DataSource = Nothing
        End If
    End Sub
    Private Sub ShowOmadaPrinters(KefOmada As STORFEAT1)
        GridControl1.DataSource = Nothing
        CmbMainPrinter.DataSource = ClsShareFunctions.GetAvalablePrinters
        CmbClonePrinter.DataSource = ClsShareFunctions.GetAvalablePrinters
        CmbProductSubCategory.DataSource = KefOmada.STORFEAT2s 'TryCast(CmbProductOmada.EditValue, STORFEAT1).STORFEAT2s
        ' Dim myomada As STORFEAT1 = KefOmada 'TryCast(CmbProductOmada.EditValue, STORFEAT1)
        Dim CategoryPrinters As XPCollection(Of Printers) = New XPCollection(Of Printers)(ses,
                                                                                          New BinaryOperator("PosCnfg", poscnfg) And
                                                                                          New BinaryOperator("ProductCategory", KefOmada))
        GridControl1.DataSource = CategoryPrinters
    End Sub
    Private Sub TabbedControlGroup1_SelectedPageChanged(sender As Object, e As LayoutTabPageChangedEventArgs) Handles TabbedControlGroup1.SelectedPageChanged
        If e.Page.Name = "PrinterControlGroup" Then
            ShowOmadaPrinters(CmbProductOmada.EditValue)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        GetFormData()
        poscnfg.Save()
        receiptheader.Save()
        Me.Close()
    End Sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    Sub NavigatorButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles GridControl1.EmbeddedNavigator.ButtonClick
        If e.Button.ButtonType = NavigatorButtonType.Append Then
        End If

    End Sub
    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetRowCellValue(e.RowHandle, "PosCnfg!", poscnfg)
        GridView1.SetRowCellValue(e.RowHandle, "ProductCategory!", TryCast(CmbProductOmada.EditValue, STORFEAT1))
    End Sub
    Private Sub BtnPosCnfgExit_Click(sender As Object, e As EventArgs) Handles BtnPosCnfgExit.Click
        Me.Close()
    End Sub
    Private Sub BtnFiscalPath_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles BtnFiscalPath.ButtonClick
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            BtnFiscalPath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
End Class