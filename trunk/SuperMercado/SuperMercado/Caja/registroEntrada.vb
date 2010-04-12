Imports System.Windows.Forms

Public Class registroEntrada

#Region " Variables de trabajo "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
#End Region

    ' Guarda el ingreso registrado.
#Region "Grabar"
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        'Validar que se haya tecleado un ingreso
        If numIngreso.Value <= 0 Then
            MessageBox.Show("No ha especificado el ingreso.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Me.Close()

    End Sub
#End Region

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub registroEntrada_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        numIngreso.Focus()
        numIngreso.Select(0, 4)
    End Sub
End Class

