Public Class inicial

#Region "  Evento: Inicial CARGA  "
    Private Sub inicial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblFecha.Text = Date.Now.ToLongDateString
        labelNomUsuario.Text = nombreCompleto
    End Sub
#End Region

#Region "  Timer1  "
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora.Text = Date.Now.ToLongTimeString
    End Sub
#End Region

End Class