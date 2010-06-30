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
            usuario = textBoxUsuario.Text.Trim
            nombreCompleto = lConsulta.ObtenerValor("3R", ObjRet.sResultado, "|")
            idUsuario = lConsulta.ObtenerValor("4R", ObjRet.sResultado, "|")
            MacCaja()
            mostrarInicial()
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
        objPrincipal.Close()
        Me.Close()
        End
    End Sub
#End Region

#Region "  Botón Guardar Nueva Contraseña  "
    Private Sub ButtonGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardar.Click
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
            '<Validaciones para la nueva contraseña>
            If textBoxNuevoPassword.Text <> textBoxConNuevoPassword.Text Then
                MessageBox.Show("La nueva contraseña es diferente de la contraseña confirmada.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                textBoxConNuevoPassword.Focus()
                textBoxConNuevoPassword.SelectAll()
                Return
            End If

            If textBoxNuevoPassword.Text = "" Then
                MessageBox.Show("No ha escrito su nueva contraseña.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                textBoxNuevoPassword.Focus()
                Return
            End If

            If textBoxConNuevoPassword.Text = "" Then
                MessageBox.Show("No ha escrito la confirmación de su nueva contraseña.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                textBoxConNuevoPassword.Focus()
                Return
            End If

            Dim objRetTemp As CRetorno
            Caja = "GRABAR120"
            Parametros = "V1=" & textBoxConNuevoPassword.Text.Trim & _
                         "|V2=" & textBoxUsuario.Text.Trim
            objRetTemp = lConsulta.LlamarCaja(Caja, "1", Parametros)

            MessageBox.Show("Su contraseña ha sido cambiada con éxito.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Height = 205
            Me.textBoxUsuario.Clear()
            Me.textBoxPassword.Clear()
            Me.textBoxNuevoPassword.Clear()
            Me.textBoxConNuevoPassword.Clear()
            Me.textBoxUsuario.Focus()

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

#Region "  Botón Cancelar Contraseña  "
    Private Sub ButtonCancelarContraseña_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelarContraseña.Click
        Me.Height = 205
    End Sub
#End Region

#Region "  Paso de referencia Principal  "
    Friend Sub cargaRefPrincipal(ByRef principalR As Principal)
        objPrincipal = principalR
    End Sub
#End Region

#Region "  Label Cambiar Contraseña  "
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

#Region "  Rutina: mostrarInicial  "
    Private Sub mostrarInicial()
        Dim inic As New inicial
        inic.MdiParent = objPrincipal
        inic.WindowState = FormWindowState.Maximized
        inic.StartPosition = FormStartPosition.CenterScreen
        inic.Show()
    End Sub
#End Region

#Region "  Rutina: MacCaja  "
    Sub MacCaja()
        '----------   Muestra la MAC  ------------
        'MessageBox.Show("La dirección MAC de su equipo es: " & obtenMac(), "MAC", MessageBoxButtons.OK, MessageBoxIcon.Information)


        '--- Consulta110: registro con la fecha más reciente en la tabla caja ---
        ' Se verifica que la fecha más reciente en la tabla caja sea distinta a la actual.
        ' Si lo es, se procede a ingresar un nuevo registro con la fecha actual.

        Caja = "CONSULTA110" : Parametros = "V1=" & usuario & "|"

        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        Dim fecha As String
        fecha = ObjRet.DS.Tables(0).Rows(0).Item(0)

        If fecha = "" Then
            ' CONFIGURACION_CAJA
            ' Si está activado un monto inicial por defecto se inserta
            ' directamente. Para esto llamamos a la consulta112 y obtenemos
            ' la configuración.
            Caja = "Consulta112" : Parametros = ""
            If lConsulta Is Nothing Then lConsulta = New ClsConsultas
            ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

            Dim activadoMontoPorDefecto As Boolean
            Dim montoPorDefecto As Decimal
            activadoMontoPorDefecto = ObjRet.DS.Tables(0).Rows(0).Item(1)
            montoPorDefecto = ObjRet.DS.Tables(0).Rows(0).Item(2)

            ' Activado un monto inicial por defecto.
            If activadoMontoPorDefecto Then
                Caja = "GRABAR110" : Parametros = "V1=" & montoPorDefecto & "|" & _
                                                  "V2=" & idUsuario & "|"

                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

            Else ' No se encuentra activado, por lo tanto muestra la ventana
                ' DineroCaja para ingresarlo manualmente.
                Dim objDineroCaja = New dineroCaja()
                objDineroCaja.StartPosition = FormStartPosition.CenterParent
                objDineroCaja.ShowDialog()
            End If
        End If

    End Sub
#End Region

End Class