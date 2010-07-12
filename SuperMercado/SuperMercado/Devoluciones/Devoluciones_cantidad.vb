Public Class Devoluciones_cantidad

#Region "  Variables de trabajo  "
    Public numArtDev As Decimal
    Public totArtDev As Decimal
    Public continuar As Boolean
#End Region

#Region "  Botón Aceptar  "
    Private Sub ButtonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptar.Click
        If numArt.Value > totArtDev Then
            MessageBox.Show("La cantidad a devolver excede al número de artículos comprados.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            numArt.Select(0, 10)
            numArt.Focus()
            Return
        End If

        numArtDev = numArt.Value
        Me.Close()
    End Sub
#End Region

#Region "  Botón Cancelar  "
    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub
#End Region 
 
#Region "  Evento: Devoluciones_cantidad LOAD  "
    Private Sub Devoluciones_cantidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        continuar = True

        numArt.Select(0, 10)
        numArt.Focus()
    End Sub
#End Region

#Region "  Cambiar de textBox con Enter  "
    Private Sub numArt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numArt.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonAceptar.Focus()
        End If
    End Sub
#End Region

End Class