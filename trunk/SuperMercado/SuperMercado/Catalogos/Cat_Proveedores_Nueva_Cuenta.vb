Public Class Cat_Proveedores_Nueva_Cuenta

#Region "  Variables de trabajo  "
    Public producto As String
    Public cantidad As Decimal
    Public costo As Decimal

    Public ok As Boolean
#End Region

#Region "  Evento: Cat_Proveedores_Nueva_Cuenta - LOAD  "
    Private Sub Cat_Proveedores_Nueva_Cuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBoxProducto.Focus()
    End Sub
#End Region

#Region "  Cambio de textBox con Enter  "
    Private Sub TextBoxProducto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxProducto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            NumericUpDownCantidad.Select(0, 10)
            NumericUpDownCantidad.Focus()
        End If
    End Sub

    Private Sub NumericUpDownCantidad_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NumericUpDownCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            NumericUpDownCosto.Select(0, 10)
            NumericUpDownCosto.Focus()
        End If
    End Sub

    Private Sub NumericUpDownCosto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NumericUpDownCosto.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonAceptar.Focus()
        End If
    End Sub
#End Region
    
#Region "  Botón ACEPTAR  "
    Private Sub ButtonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptar.Click
        If TextBoxProducto.Text = "" Then
            MessageBox.Show("No ha escrito el nombre del producto.", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBoxProducto.Focus()
            Return
        End If

        If NumericUpDownCantidad.Value < 1 Then
            MessageBox.Show("No ha especificado la cantidad.", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            NumericUpDownCantidad.Select(0, 10)
            NumericUpDownCantidad.Focus()
        End If

        If NumericUpDownCosto.Value < 1 Then
            MessageBox.Show("No ha especificado el costo del producto.", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            NumericUpDownCosto.Select(0, 10)
            NumericUpDownCosto.Focus()
        End If

        producto = TextBoxProducto.Text.Trim
        cantidad = NumericUpDownCantidad.Value
        costo = NumericUpDownCosto.Value

        ok = True

        Me.Close()
    End Sub
#End Region
    
#Region "  Botón CANCELAR  "
    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        ok = False
        Me.Close()
    End Sub
#End Region
    
End Class