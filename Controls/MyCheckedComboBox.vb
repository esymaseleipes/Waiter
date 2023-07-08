Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports System.Reflection
Imports System.ComponentModel


Public Class MyCheckedComboBoxEdit
		Inherits CheckedComboBoxEdit
		Shared Sub New()
			RepositoryItemMyCheckedComboBoxEdit.RegisterMyCheckedComboBoxEdit()
		End Sub
		Public Sub New()
			MyBase.New()
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMyCheckedComboBoxEdit.MyCheckedComboBoxEditName
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyCheckedComboBoxEdit
			Get
				Return CType(MyBase.Properties, RepositoryItemMyCheckedComboBoxEdit)
			End Get
		End Property
		Protected Overrides Function CreatePopupCheckListControl() As PopupContainerControl
			Dim result As PopupContainerControl = MyBase.CreatePopupCheckListControl()
			Dim fi As FieldInfo = GetType(CheckedComboBoxEdit).GetField("listBox", BindingFlags.Instance Or BindingFlags.NonPublic)
			Dim control As CheckedListBoxControl = CType(fi.GetValue(Me), CheckedListBoxControl)
			control.MultiColumn = True
			Return result
		End Function
	End Class

	<UserRepositoryItem("RegisterMyCheckedComboBoxEdit")> _
	Public Class RepositoryItemMyCheckedComboBoxEdit
		Inherits RepositoryItemCheckedComboBoxEdit
		Shared Sub New()
			RegisterMyCheckedComboBoxEdit()
		End Sub
		Public Sub New()
			MyBase.New()
		End Sub
		Public Const MyCheckedComboBoxEditName As String = "MyCheckedComboBoxEdit"
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return MyCheckedComboBoxEditName
			End Get
		End Property
		Public Shared Sub RegisterMyCheckedComboBoxEdit()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(MyCheckedComboBoxEditName, GetType(MyCheckedComboBoxEdit), GetType(RepositoryItemMyCheckedComboBoxEdit), GetType(PopupContainerEditViewInfo), New ButtonEditPainter(), True))
		End Sub
	End Class
