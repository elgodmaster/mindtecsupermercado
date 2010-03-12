Imports MindTec.Componentes

Public Class Cat_Clientes

#Region " Variables de trabajo "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
#End Region

#Region " Eventos Principales "
    Private Sub Cat_Clientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Cerrar()
            Case Keys.F4
                Limpiar.PerformClick()
            Case Keys.F9
                Grabar.PerformClick()
        End Select
    End Sub


    Private Sub Cat_Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Pie de Pagina Mensaje
        MensajePiePagina.Text = "Esc=Salir Enter=Avanzar F2=Catálogo F4=Limpiar Pantalla"
        'Deshabilitar
        Me.Grabar.Visible = False
    End Sub
#End Region

#Region " Aceptar "
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Caja = "Consulta105" : Parametros = "V1=" & Me.CodigoCliente.Text
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)
        If ObjRet.bOk Then
            'Deshabilitar
            Me.CodigoCliente.Enabled = False
            Me.btnAceptar.Enabled = False

            'Asignar
            Me.TxtNombre.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
            Me.txtRfc.Text = lConsulta.ObtenerValor("V2", ObjRet.sResultado, "|")
            Me.TxtColonia.Text = lConsulta.ObtenerValor("V3", ObjRet.sResultado, "|")
            Me.TxtDireccion.Text = lConsulta.ObtenerValor("V4", ObjRet.sResultado, "|")
            Me.Txtcp.Text = lConsulta.ObtenerValor("V5", ObjRet.sResultado, "|")
            Me.TxtEstado.Text = lConsulta.ObtenerValor("V6", ObjRet.sResultado, "|")
            Me.NombreEstado.Text = lConsulta.ObtenerValor("V7", ObjRet.sResultado, "|")
            Me.TxtCiudad.Text = lConsulta.ObtenerValor("V8", ObjRet.sResultado, "|")
            Me.NombreCiudad.Text = lConsulta.ObtenerValor("V9", ObjRet.sResultado, "|")
            Me.TxtTel.Text = lConsulta.ObtenerValor("V10", ObjRet.sResultado, "|")
            Me.txtext.Text = lConsulta.ObtenerValor("V11", ObjRet.sResultado, "|")
            Me.TxtTel2.Text = lConsulta.ObtenerValor("V12", ObjRet.sResultado, "|")
            Me.txtext2.Text = lConsulta.ObtenerValor("V13", ObjRet.sResultado, "|")
            Me.TxtCel.Text = lConsulta.ObtenerValor("V14", ObjRet.sResultado, "|")
            Me.TxtCel2.Text = lConsulta.ObtenerValor("V15", ObjRet.sResultado, "|")
            Me.TxtFax.Text = lConsulta.ObtenerValor("V16", ObjRet.sResultado, "|")
            Me.TxtMail.Text = lConsulta.ObtenerValor("V17", ObjRet.sResultado, "|")

            'Habilitar
            Me.Grabar.Visible = True
            Me.GroupBoxClientes.Visible = True
            Me.GroupBoxLocalizacion.Visible = True
            MensajePiePagina.Text = "Esc=Salir Enter=Avanzar F2=Catálogo F4=Limpiar Pantalla F9=Grabar"
            'Foco
            Me.TxtNombre.Focus()
        Else
            'Asignar
            Me.CodigoCliente.Text = ""
            Me.Nombrecliente.Text = ""

            'Mensaje
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
            'Foco
            Me.CodigoCliente.Focus()
        End If
        ObjRet = Nothing

    End Sub
#End Region

#Region " Cliente "
    Private Sub CodigoCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoCliente.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Catalogo()
            Case Keys.Enter, Keys.Down
                'Servicios
                Caja = "Consulta105" : Parametros = "V1=" & Me.CodigoCliente.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                'Estatus
                If ObjRet.bOk Then
                    'Asignar
                    Me.Nombrecliente.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
                    SendKeys.Send("{TAB}")
                Else
                    'Asignar
                    Me.Nombrecliente.Text = ""
                    'mensaje
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                    'poner focus
                    Me.CodigoCliente.Focus()
                End If
                'Destruir
                ObjRet = Nothing
            Case Keys.Up
                SendKeys.Send("+{TAB}")
        End Select
    End Sub
#End Region

#Region " Rutinas "

    Sub LimpiarPantalla()
        'Habilidar
        Me.btnAceptar.Enabled = True
        Me.CodigoCliente.Enabled = True
        'Deshabilitar
        Me.GroupBoxClientes.Visible = False
        Me.GroupBoxLocalizacion.Visible = False
        Me.Grabar.Visible = False
        'Asignar
        Me.CodigoCliente.Text = ""
        Me.Nombrecliente.Text = ""
        Me.TxtNombre.Text = ""
        Me.txtRfc.Text = ""
        Me.TxtEstado.Text = ""
        Me.NombreEstado.Text = ""
        Me.TxtCiudad.Text = ""
        Me.NombreCiudad.Text = ""
        Me.TxtColonia.Text = ""
        Me.TxtDireccion.Text = ""
        Me.Txtcp.Text = ""
        Me.TxtMail.Text = ""
        Me.TxtTel.Text = ""
        Me.TxtTel2.Text = ""
        Me.txtext.Text = ""
        Me.txtext2.Text = ""
        Me.TxtFax.Text = ""
        'PiePagina
        MensajePiePagina.Text = "Esc=Salir Enter=Avanzar F2=Catalogo F4=Limpiar Pantalla"
        'Foco
        Me.CodigoCliente.Focus()
    End Sub

    Sub Catalogo()
        Caja = "Consulta105" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            Me.CodigoCliente.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.CodigoCliente_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

        End If
    End Sub
    Sub CatalogoEstado()
        Caja = "Consulta107" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            Me.TxtEstado.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.TxtEstado_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

        End If
    End Sub

    Sub CatalogoCiudad()
        Caja = "Consulta108" : Parametros = "V1=" & Me.TxtEstado.Text.Trim & "|"
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            Me.TxtCiudad.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.TxtCiudad_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

        End If
    End Sub

    Sub MoverFlechas(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter, Keys.Down, Keys.Up
                If e.KeyCode = Keys.Up Then
                    SendKeys.Send("+{TAB}")
                Else
                    SendKeys.Send("{TAB}")
                End If
        End Select
    End Sub
    Sub Cerrar()
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Deseas salir de esta pantalla?", "HidroIntel", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region

#Region " Grabar "
    Private Sub Grabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grabar.Click
        'Variable de trabajo
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Deseas Guardar los Cambios?", "PVFacturacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            Caja = "Grabar105" : Parametros = "V1=" & Me.CodigoCliente.Text.Trim & _
                                              "|V2=" & Me.TxtNombre.Text.Trim & _
                                              "|V3=" & Me.txtRfc.Text.Trim & _
                                              "|V4=" & Me.TxtColonia.Text.Trim & _
                                              "|V5=" & Me.TxtDireccion.Text.Trim & _
                                              "|V6=" & Me.Txtcp.Text.Trim & _
                                              "|V7=" & Me.TxtEstado.Text.Trim & _
                                              "|V8=" & Me.TxtCiudad.Text.Trim & _
                                              "|V9=" & Me.TxtTel.Text.Trim & _
                                              "|V10=" & Me.txtext.Text.Trim & _
                                              "|V11=" & Me.TxtTel2.Text.Trim & _
                                              "|V12=" & Me.txtext2.Text.Trim & _
                                              "|V13=" & Me.TxtCel.Text.Trim & _
                                              "|V14=" & Me.TxtCel2.Text.Trim & _
                                              "|V15=" & Me.TxtFax.Text.Trim & _
                                              "|V16=" & Me.TxtMail.Text.Trim & "|"

            If lConsulta Is Nothing Then lConsulta = New ClsConsultas
            ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
            If ObjRet.bOk Then
                MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                LimpiarPantalla()
            Else
                MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
            End If
        End If
    End Sub
#End Region

#Region " Estado "
    Private Sub TxtEstado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEstado.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                'Asignar
                Me.TxtCiudad.Text = ""
                Me.NombreCiudad.Text = ""
                CatalogoEstado()
            Case Keys.Enter, Keys.Down
                'Servicios
                Caja = "Consulta107" : Parametros = "V1=" & Me.TxtEstado.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                'Estatus
                If ObjRet.bOk Then
                    'Asignar
                    Me.NombreEstado.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
                    SendKeys.Send("{TAB}")
                Else
                    'Asignar
                    Me.TxtEstado.Text = ""
                    Me.NombreEstado.Text = ""
                    'mensaje
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                    'poner focus
                    Me.TxtEstado.Focus()
                End If
                'Destruir
                ObjRet = Nothing
            Case Keys.Up
                SendKeys.Send("+{TAB}")
        End Select
    End Sub

#End Region

#Region " Ciudad "
    Private Sub TxtCiudad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCiudad.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatalogoCiudad()
            Case Keys.Enter, Keys.Down
                'Servicios
                Caja = "Consulta108" : Parametros = "V1=" & Me.TxtEstado.Text & "|V2=" & Me.TxtCiudad.Text.Trim & "|"
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                'Estatus
                If ObjRet.bOk Then
                    'Asignar
                    Me.NombreCiudad.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
                    SendKeys.Send("{TAB}")
                Else
                    'Asignar
                    Me.NombreCiudad.Text = ""
                    Me.TxtCiudad.Text = ""
                    'mensaje
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                    'poner focus
                    Me.TxtCiudad.Focus()
                End If
                'Destruir
                ObjRet = Nothing
            Case Keys.Up
                SendKeys.Send("+{TAB}")
        End Select
    End Sub
#End Region

#Region " Limpiar "
    Private Sub Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        LimpiarPantalla()
    End Sub
#End Region



End Class