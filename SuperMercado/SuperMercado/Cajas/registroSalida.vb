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
        If numRetiro.Value <= 0 Then
            MessageBox.Show("No ha especificado la cantidad a retirar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            numRetiro.Focus()
            Return
        End If
        Me.Close()
    End Sub

    Private Sub numRetiro_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numRetiro.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRazonSalida.Focus()
        End If
    End Sub

    Private Sub txtRazonSalida_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRazonSalida.KeyDown
        If e.KeyCode = Keys.Enter Then
            OK_Button.Focus()
        End If
    End Sub
End Class
