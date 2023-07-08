Imports DevExpress.Xpo
Imports ggServices
Imports WaiterModel.Cmp300

Public Class FrmCustomer
    Public Property Customer As Customers

    Dim ses As Session
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(_Customer As Customers)
        InitializeComponent()
        Customer = _Customer
        ses = Customer.Session



        inibind()
    End Sub
    Private Sub inibind()
        txtLname.DataBindings.Add(New Binding("Text", Customer, "Lname"))
        txtCity.DataBindings.Add(New Binding("Text", Customer, "City"))
        txtAddress.DataBindings.Add(New Binding("Text", Customer, "MainAddress"))
        txtComments.DataBindings.Add(New Binding("Text", Customer, "Comments"))
        txtDoy.DataBindings.Add(New Binding("Text", Customer, "Doy"))
        txtEmail.DataBindings.Add(New Binding("Text", Customer, "Email"))
        txtProphesion.DataBindings.Add(New Binding("Text", Customer, "Profesion"))
        txtThl1.DataBindings.Add(New Binding("Text", Customer, "Phone1"))
        txtThl2.DataBindings.Add(New Binding("Text", Customer, "Phone2"))
        txtVatNo.DataBindings.Add(New Binding("Text", Customer, "Afm"))


    End Sub






    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Customer.Save()
        Me.Close()
    End Sub

    Private Sub BtgEsc_Click(sender As Object, e As EventArgs) Handles BtgEsc.Click
        Me.Close()
    End Sub
End Class