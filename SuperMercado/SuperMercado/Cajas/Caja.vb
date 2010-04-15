Public Class Caja

#Region " Variables de trabajo "
    Dim objRegistroEntrada = Nothing
    Dim objRegistroSalida = Nothing

#End Region


    Private Sub Caja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEspFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub


    Private Sub fechaCorte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fechaCorte.ValueChanged
        ' Obtenemos el formato de hora: 1994-08-18 15:30:30
        lblPrueba.Text = fechaCorte.Value.ToString("dd/MM/yyyy")
        Dim strHora = fechaCorte.Value.ToString("HH:mm:ss")

        lblPrueba.Text = lblPrueba.Text & " " & strHora
    End Sub

    Private Sub Caja_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class