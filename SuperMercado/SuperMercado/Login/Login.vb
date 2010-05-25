Public Class Login

#Region "  Variables De Trabajo  "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno

    Dim objPrincipal As Principal
#End Region

#Region "  Evento LOAD  "
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Width = 699
        Me.Height = 205
    End Sub
#End Region

#Region "  Bótón ACEPTAR  "
    Private Sub buttonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAceptar.Click
        ' <Validaciones>
        If textBoxUsuario.Text.Trim = "" Then
            MessageBox.Show("No ha escrito su nombre de usuario.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textBoxUsuario.Focus()
            Return
        End If

        If textBoxPassword.Text.Trim = "" Then
            MessageBox.Show("No ha escrito su contraseña.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textBoxPassword.Focus()
            Return
        End If
        ' <\Validaciones>

        Caja = "Consulta120" : Parametros = "V1=" & textBoxUsuario.Text.Trim & "|" & _
                                            "V2=" & textBoxPassword.Text.Trim & "|"

        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        If lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "OK" Then
            objPrincipal.Visible = True
            Me.Close()
        ElseIf lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "ERROR1" Then
            MessageBox.Show("El nombre de usuario no es válido.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textBoxUsuario.Focus()
            textBoxUsuario.SelectAll()
        ElseIf lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "ERROR2" Then
            MessageBox.Show("La contraseña está mal escrita.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textBoxPassword.Focus()
            textBoxPassword.SelectAll()
        End If
    End Sub
#End Region

#Region "  Botón CANCELAR  "
    Private Sub buttonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonCancelar.Click
        'objPrincipal.Close()
        Me.Close()
    End Sub
#End Region

#Region "  Paso de referencia Principal  "
    Friend Sub cargaRefPrincipal(ByRef principalR As Principal)
        objPrincipal = principalR
    End Sub
#End Region

#Region "  Label Cambiar Contraseña  "
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Me.Width = 699
        Me.Height = 344

        textBoxNuevoPassword.Focus()
    End Sub
#End Region

#Region "  Cambio de Textbox con ENTER  "
    Private Sub Usuario_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles textBoxUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            textBoxPassword.Focus()
        End If
    End Sub

    Private Sub textBoxPassword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles textBoxPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            buttonAceptar.Focus()
        End If
    End Sub

    Private Sub textBoxNuevoPassword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles textBoxNuevoPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            textBoxConNuevoPassword.Focus()
        End If
    End Sub

    Private Sub textBoxConNuevoPassword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles textBoxConNuevoPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonGuardar.Focus()
        End If
    End Sub
#End Region

#Region "  Botón Cancelar Contraseña  "
    Private Sub ButtonCancelarContraseña_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelarContraseña.Click
        Me.Height = 205
    End Sub
#End Region

End Class