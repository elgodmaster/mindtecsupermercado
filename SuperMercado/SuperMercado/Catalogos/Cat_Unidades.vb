Public Class Cat_Unidades

#Region " Variables de trabajo "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
#End Region

#Region " Eventos Principales"
    Private Sub Cat_Unidades_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Cerrar()
            Case Keys.F4
                Limpiar.PerformClick()
            Case Keys.F9
                Grabar.PerformClick()
        End Select
    End Sub
    Private Sub Cat_Unidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Pie de Pagina Mensaje
        MensajePiePagina.Text = "Esc=Salir Enter=Avanzar F2=Catálogo F4=Limpiar Pantalla"
        'Deshabilitar
        Me.Grabar.Visible = False
    End Sub

#End Region

#Region " Aceptar "
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Caja = "Consulta104" : Parametros = "V1=" & Me.CodigoUnidades.Text()
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)
        If ObjRet.bOk Then
            'Deshabilitar
            Me.CodigoUnidades.Enabled = False
            Me.btnAceptar.Enabled = False

            'Asignar
            Me.TxtDescripcion.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")

            'Habilitar
            Me.Grabar.Visible = True
            Me.GroupBoxDetalles.Visible = True
            MensajePiePagina.Text = "Esc=Salir Enter=Avanzar F2=Catálogo F4=Limpiar Pantalla F9=Grabar"
            'Foco
            Me.TxtDescripcion.Focus()
        Else
            'Asignar
            Me.CodigoUnidades.Text = ""
            Me.NombreUnidades.Text = ""
            Me.TxtDescripcion.Text = ""

            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))


            'Foco
            Me.CodigoUnidades.Focus()
        End If
        ObjRet = Nothing

    End Sub
#End Region

#Region " Unidad "
    Private Sub CodigoUnidades_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoUnidades.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Me.Catalogo()
            Case Keys.Enter, Keys.Down
                'Servicios
                Caja = "Consulta104" : Parametros = "V1=" & Me.CodigoUnidades.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                'Estatus
                If ObjRet.bOk Then
                    'Asignar
                    Me.NombreUnidades.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
                    SendKeys.Send("{TAB}")

                Else
                    'Asignar
                    Me.NombreUnidades.Text = ""
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

                    'poner focus

                    Me.CodigoUnidades.Focus()
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

#Region " Rutinas "
    Sub LimpiarPantalla()
        'Habilidar
        Me.btnAceptar.Enabled = True
        Me.CodigoUnidades.Enabled = True
        Me.Nuevo.Visible = True
        'Deshabilitar
        Me.GroupBoxDetalles.Visible = False
        Me.Grabar.Visible = False

        'Asignar
        Me.CodigoUnidades.Text = ""
        Me.NombreUnidades.Text = ""
        Me.TxtDescripcion.Text = ""
        'PiePagina
        MensajePiePagina.Text = "Esc=Salir Enter=Avanzar F2=Catalogo F4=Limpiar Pantalla"
        'Foco
        Me.CodigoUnidades.Focus()
    End Sub
    Sub Catalogo()
        Caja = "Consulta104" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            '' ''Dim nuevo As Grid = New Grid(ObjRet.DS)

            '' ''Me.CodigoUnidades.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.CodigoUnidades_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))


        End If

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
            Caja = "Grabar104" : Parametros = "V1=" & Me.CodigoUnidades.Text.Trim & _
                                              "|V2=" & Me.TxtDescripcion.Text.Trim & "|"

            If lConsulta Is Nothing Then lConsulta = New ClsConsultas
            ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
            LimpiarPantalla()

        End If
    End Sub
#End Region

#Region " Nuevo "
    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        Caja = "Consulta104" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "3", Parametros)
        If ObjRet.bOk Then
            'Deshabilitar
            Me.Nuevo.Visible = False
            Me.CodigoUnidades.Enabled = False
            Me.btnAceptar.Enabled = False
            'Asignar
            Me.NombreUnidades.Text = ""
            Me.CodigoUnidades.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
            'Habilitar
            Me.GroupBoxDetalles.Visible = True
            Me.Grabar.Visible = True
            'Focus
            Me.TxtDescripcion.Focus()

        End If
    End Sub
#End Region

#Region "  Evento: Cat_Unidades FORM_CLOSING  "
    Private Sub Cat_Unidades_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
        LimpiarPantalla()
        Me.Grabar.Visible = False
    End Sub
#End Region
    
End Class