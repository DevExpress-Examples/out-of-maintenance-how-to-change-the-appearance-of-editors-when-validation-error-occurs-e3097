Imports System.Windows
Imports System.Windows.Controls

Namespace WPFCustomValidationErrorPresenter

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.TextEdit.Focus()
        End Sub

        Private Sub textEdit_Validate(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.ValidationEventArgs)
            If e.Value IsNot Nothing Then
                Dim parameter As Decimal = If((TypeOf e.Value Is String), (CStr(e.Value)).Length, CDec(e.Value))
                If parameter > 3 Then
                    e.IsValid = False
                    e.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default
                    If parameter > 4 Then e.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Information
                    If parameter > 5 Then e.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
                    If parameter > 6 Then e.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
                End If
            End If
        End Sub
    End Class
End Namespace
