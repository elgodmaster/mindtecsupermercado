Imports MindTec.Componentes

'Imports MindTec.Componentes

Public Class Cat_Categorias

#Region "  Variables de trabajo  "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
#End Region

#Region "  Eventos Principales  "
    Private Sub Cat_Categorias_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                'Me.Catalogo()
            Case Keys.Escape
                Cerrar()
            Case Keys.F4
                Limpiar.PerformClick()
            Case Keys.F9
                Grabar.PerformClick()
        End Select
    End Sub

    Private Sub Cat_Categorias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Pie de Pagina Mensaje
        MensajePiePagina.Text = "Esc=Salir Enter=Avanzar F2=Catálogo F4=Limpiar Pantalla"
        'Deshabilitar
        Me.Grabar.Visible = False
    End Sub

#End Region

#Region "  Botón Aceptar  "
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Caja = "Consulta101" : Parametros = "V1=" & Me.CodigoCategoria.Text
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)
        If ObjRet.bOk Then
            'Deshabilitar
            Me.CodigoCategoria.Enabled = False
            Me.btnAceptar.Enabled = False
            Me.Nuevo.Visible = False

            'Asignar
            Me.Descripcion.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")

            'Habilitar
            Me.Grabar.Visible = True
            Me.GroupBoxCategoria.Visible = True
            MensajePiePagina.Text = "Esc=Salir Enter=Avanzar F2=Catálogo F4=Limpiar Pantalla F9=Grabar"
            'Foco
            Me.Descripcion.Focus()
        Else
            'Asignar
            Me.CodigoCategoria.Text = ""
            Me.NombreCategoria.Text = ""
            Me.Descripcion.Text = ""

            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

            'Foco
            Me.CodigoCategoria.Focus()
        End If
        ObjRet = Nothing

    End Sub
#End Region

#Region "  Botón Grabar  "
    Private Sub Grabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grabar.Click
        'Variable de trabajo
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Deseas Guardar los Cambios?", "PVFacturacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            Caja = "Grabar101" : Parametros = "V1=" & Me.CodigoCategoria.Text & "|V2=" & Me.Descripcion.Text & "|"
            If lConsulta Is Nothing Then lConsulta = New ClsConsultas
            ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
            LimpiarPantalla()
        End If
    End Sub
#End Region

#Region "  Botón Limpiar  "
    Private Sub Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        LimpiarPantalla()
    End Sub
#End Region

#Region "  Botón Nuevo  "
    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        Caja = "Consulta101" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "3", Parametros)
        If ObjRet.bOk Then
            'Deshabilitar
            Me.Nuevo.Visible = False
            Me.CodigoCategoria.Enabled = False
            Me.btnAceptar.Enabled = False
            'Asignar
            Me.NombreCategoria.Text = ""
            Me.CodigoCategoria.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
            'Habilitar
            Me.GroupBoxCategoria.Visible = True
            Me.Grabar.Visible = True
            'Focus
            Me.Descripcion.Focus()

        End If
    End Sub
#End Region

#Region "  Categoria  "
    Private Sub CodigoCategoria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoCategoria.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Catalogo()
            Case Keys.Enter, Keys.Down
                'Servicios
                Caja = "Consulta101" : Parametros = "V1=" & Me.CodigoCategoria.Text()
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                'Estatus
                If ObjRet.bOk Then
                    'Asignar
                    Me.NombreCategoria.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
                    SendKeys.Send("{TAB}")

                Else
                    'Asignar
                    Me.NombreCategoria.Text = ""

                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

                    'poner focus
                    Me.CodigoCategoria.Focus()
                End If
                'Destruir
                ObjRet = Nothing
            Case Keys.Up
                SendKeys.Send("+{TAB}")
        End Select
    End Sub
#End Region

#Region "  Rutinas  "
    Sub LimpiarPantalla()
        'Habilidar
        Me.btnAceptar.Enabled = True
        Me.CodigoCategoria.Enabled = True
        Me.Nuevo.Visible = True
        'Deshabilitar
        Me.GroupBoxCategoria.Visible = False
        Me.Grabar.Visible = False

        'Asignar
        Me.CodigoCategoria.Text = ""
        Me.NombreCategoria.Text = ""
        Me.Descripcion.Text = ""
        'PiePagina
        MensajePiePagina.Text = "Esc=Salir Enter=Avanzar F2=Catalogo F4=Limpiar Pantalla"
        'Foco
        Me.CodigoCategoria.Focus()
    End Sub
    Sub Catalogo()
        Caja = "Consulta101" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)
            Me.CodigoCategoria.Text = nuevo.resultado

            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.CodigoCategoria_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If

    End Sub
    Sub Cerrar()
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Deseas salir de esta pantalla?", "SuperMercado Beltrán", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region

#Region "  Evento Cat_Categorías FORM_CLOSING  "
    Private Sub Cat_Categorias_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
        LimpiarPantalla()
        Me.Grabar.Visible = False
    End Sub
#End Region

    Private Sub Cat_Categorias_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        CodigoCategoria.Focus()
    End Sub
End Class