Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace WPFCustomValidationErrorPresenter
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			TextEdit.Focus()
		End Sub

		Private Sub textEdit_Validate(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.ValidationEventArgs)
		   If e.Value IsNot Nothing Then
				Dim parameter As Decimal = If((TypeOf e.Value Is String), (CStr(e.Value)).Length, CDec(e.Value))

				If parameter > 3 Then
					e.IsValid = False
					e.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default
					If parameter > 4 Then
						e.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Information
					End If
					If parameter > 5 Then
						e.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
					End If
					If parameter > 6 Then
						e.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
					End If
				End If
		   End If
		End Sub
	End Class
End Namespace
