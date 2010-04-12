Imports System.Windows.Forms

Public Class registroSalida


    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub registroSalida_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        numRetiro.Focus()
        numRetiro.Select(0, 4)
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'Validar que se haya tecleado un ingreso
        If numRetiro.Value <= 0 Then
            MessageBox.Show("No ha especificado la cantidad a retirar.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Me.Close()
    End Sub
End Class
