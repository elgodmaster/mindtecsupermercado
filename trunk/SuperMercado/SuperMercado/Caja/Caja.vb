Public Class Caja

#Region " Variables de trabajo "
    Dim objRegistroEntrada = Nothing
    Dim objRegistroSalida = Nothing

#End Region

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Caja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEspFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrada.Click
        If objRegistroEntrada Is Nothing Then
            Dim objRegistroEntrada As New registroEntrada
            registroEntrada.StartPosition = FormStartPosition.CenterScreen
            registroEntrada.Show()
        End If

    End Sub

    Private Sub btnSalida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalida.Click
        If objRegistroSalida Is Nothing Then
            Dim objRegistroSalida As New registroSalida
            registroSalida.StartPosition = FormStartPosition.CenterScreen
            registroSalida.Show()
        End If
    End Sub

    Private Sub fechaCorte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fechaCorte.ValueChanged

        ' Obtenemos el formato de hora: 18/08/0987 15:30:30
        fechaCorte.Format = DateTimePickerFormat.Custom
        lblPrueba.Text = fechaCorte.Text
        fechaCorte.Format = DateTimePickerFormat.Time
        Dim strHora = fechaCorte.Text
        lblPrueba.Text = lblPrueba.Text & " " & strHora

        fechaCorte.Format = DateTimePickerFormat.Long
    End Sub
End Class