Public Class configuracion

    Private Sub configuracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ChBxDineroInicial.Checked Then
            GrBxDineroInicial.Enabled = True
        Else
            GrBxDineroInicial.Enabled = False
        End If

        If ChBxLimitesMaximos.Checked Then
            GrBxLimites.Enabled = True
        Else
            GrBxLimites.Enabled = False
        End If
    End Sub

    Private Sub ChBxDineroInicial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBxDineroInicial.CheckedChanged
        If ChBxDineroInicial.Checked Then
            GrBxDineroInicial.Enabled = True
        Else
            GrBxDineroInicial.Enabled = False
        End If
    End Sub

    Private Sub ChBxLimitesMaximos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBxLimitesMaximos.CheckedChanged
        If ChBxLimitesMaximos.Checked Then
            GrBxLimites.Enabled = True
        Else
            GrBxLimites.Enabled = False
        End If
    End Sub
End Class