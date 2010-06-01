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

#Region "  B�t�n ACEPTAR  "
    Private Sub buttonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAceptar.Click
        ' <Validaciones>
        If textBoxUsuario.Text.Trim = "" Then
            MessageBox.Show("No ha escrito su nombre de usuario.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textBoxUsuario.Focus()
            Return
        End If

        If textBoxPassword.Text.Trim = "" Then
            MessageBox.Show("No ha escrito su contrase�a.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textBoxPassword.Focus()
            Return
        End If
        ' <\Validaciones>

        Caja = "Consulta120" : Parametros = "V1=" & textBoxUsuario.Text.Trim & "|" & _
                                            "V2=" & textBoxPassword.Text.Trim & "|"

        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        If lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "OK" Then
            objPrincipal.Visible = True
            objPrincipal.nombreUsuario = textBoxUsuario.Text.Trim
            objPrincipal.nombreCompleto = lConsulta.ObtenerValor("3R", ObjRet.sResultado, "|")
            Me.Close()
        ElseIf lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "ERROR1" Then
            MessageBox.Show("El nombre de usuario no es v�lido.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textBoxUsuario.Focus()
            textBoxUsuario.SelectAll()
        ElseIf lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "ERROR2" Then
            MessageBox.Show("La contrase�a est� mal escrita.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textBoxPassword.Focus()
            textBoxPassword.SelectAll()
        End If
    End Sub
#End Region

#Region "  Bot�n CANCELAR  "
    Private Sub buttonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonCancelar.Click
        objPrincipal.Close()
        Me.Close()
        End
    End Sub
#End Region

#Region "  Bot�n Guardar Nueva Contrase�a  "
    Private Sub ButtonGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardar.Click
        ' <Validaciones>
        If textBoxUsuario.Text.Trim = "" Then
            MessageBox.Show("No ha escrito su nombre de usuario.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textBoxUsuario.Focus()
            Return
        End If

        If textBoxPassword.Text.Trim = "" Then
            MessageBox.Show("No ha escrito su contrase�a.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textBoxPassword.Focus()
            Return
        End If
        ' <\Validaciones>

        Caja = "Consulta120" : Parametros = "V1=" & textBoxUsuario.Text.Trim & "|" & _
                                            "V2=" & textBoxPassword.Text.Trim & "|"

        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        If lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "OK" Then
            '<Validaciones para la nueva contrase�a>
            If textBoxConNuevoPassword.Text <> textBoxConNuevoPassword.Text Then
                MessageBox.Show("La nueva contrase�a es diferente de la contrase�a confirmada.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                textBoxConNuevoPassword.Focus()
                textBoxConNuevoPassword.SelectAll()
                Return
            End If

            If textBoxNuevoPassword.Text = "" Then
                MessageBox.Show("No ha escrito su nueva contrase�a.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                textBoxNuevoPassword.Focus()
                Return
            End If

            If textBoxConNuevoPassword.Text = "" Then
                MessageBox.Show("No ha escrito la confirmaci�n de su nueva contrase�a.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                textBoxConNuevoPassword.Focus()
                Return
            End If

            Dim objRetTemp As CRetorno
            Caja = "GRABAR120"
            Parametros = "V1=" & textBoxConNuevoPassword.Text.Trim & _
                         "|V2=" & textBoxUsuario.Text.Trim
            objRetTemp = lConsulta.LlamarCaja(Caja, "1", Parametros)

            MessageBox.Show("Su contrase�a ha sido cambiada con �xito.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        ElseIf lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "ERROR1" Then
            MessageBox.Show("El nombre de usuario no es v�lido.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textBoxUsuario.Focus()
            textBoxUsuario.SelectAll()
        ElseIf lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "ERROR2" Then
            MessageBox.Show("La contrase�a est� mal escrita.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textBoxPassword.Focus()
            textBoxPassword.SelectAll()
        End If
    End Sub
#End Region

#Region "  Bot�n Cancelar Contrase�a  "
    Private Sub ButtonCancelarContrase�a_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelarContrase�a.Click
        Me.Height = 205
    End Sub
#End Region

#Region "  Paso de referencia Principal  "
    Friend Sub cargaRefPrincipal(ByRef principalR As Principal)
        objPrincipal = principalR
    End Sub
#End Region

#Region "  Label Cambiar Contrase�a  "
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        If Me.Height = 205 Then
            Me.Height = 344
        Else
            Me.Height = 205
        End If

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
    
End Class