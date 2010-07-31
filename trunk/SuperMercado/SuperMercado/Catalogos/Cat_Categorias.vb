Imports MindTec.Componentes

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
        'Deshabilitar
        Me.Limpiar.Visible = False
        Me.Grabar.Visible = False
    End Sub

#End Region

#Region "  Botón BUSCAR  "
    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        Catalogo()
    End Sub
#End Region

#Region "  Botón Aceptar  "
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CodigoCategoria.Enabled = False

        Caja = "Consulta101" : Parametros = "V1=" & Me.CodigoCategoria.Text
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)
        If ObjRet.bOk Then
            ToolStripStatusLabelCat.Text = ""
            Me.Limpiar.Visible = True

            'Deshabilitar


            'Asignar
            Me.Descripcion.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")

            'Habilitar
            Me.Grabar.Visible = True
            Me.GroupBoxCategoria.Visible = True
            'Foco
            Me.Descripcion.Focus()
        Else
            'Asignar
            Me.CodigoCategoria.Text = ""

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
        Result = MessageBox.Show("¿Desea guardar los cambios?", " SMercado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            Caja = "Grabar101" : Parametros = "V1=" & Me.CodigoCategoria.Text & "|V2=" & Me.Descripcion.Text & "|"
            If lConsulta Is Nothing Then lConsulta = New ClsConsultas
            ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)


            If lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "OK" Then
                MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                LimpiarPantalla()
                regresaPantalla()
            Else
                MessageBox.Show("La categoría ya se encuentra registrada.", " Categorías", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            
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
        CodigoCategoria.Enabled = False
        Grabar.Enabled = True

        Me.Limpiar.Visible = True
        LimpiarPantalla()

        Caja = "Consulta101" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "3", Parametros)
        If ObjRet.bOk Then
            'Deshabilitar
            Me.Nuevo.Visible = False

            'Asignar
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

                    SendKeys.Send("{TAB}")

                Else
                    'Asignar


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
        'Asignar
        Me.Descripcion.Clear()
        Me.Descripcion.Focus()

    End Sub


    Sub Cerrar()
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Deseas salir de esta pantalla?", "SuperMercado Beltrán", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Cat_Categorias_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        CodigoCategoria.Focus()
    End Sub
#End Region

#Region "  Rutina: regresaPantalla  "
    Sub regresaPantalla()
        ToolStripStatusLabelCat.Text = "Escriba un número de identificación para mostrar los datos de una categoría, o pulse F2 mostrar un catálogo."

        CodigoCategoria.Enabled = True


        CodigoCategoria.Clear()
        CodigoCategoria.Focus()

        'Habilidar
        Me.CodigoCategoria.Enabled = True
        Me.Nuevo.Visible = True
        'Deshabilitar
        Me.GroupBoxCategoria.Visible = False
        Me.Grabar.Visible = False
        Me.Limpiar.Visible = False

    End Sub
#End Region

#Region "  Rutina: consulta101  "
    Sub consulta101()
        Grabar.Enabled = True

        Caja = "Consulta101" : Parametros = "V1=" & Me.CodigoCategoria.Text
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)
        If ObjRet.bOk Then
            ToolStripStatusLabelCat.Text = ""
            Me.Limpiar.Visible = True

            'Deshabilitar

            'Asignar
            Me.Descripcion.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
            If Descripcion.Text = "-SIN CATEGORÍA-" Then
                Grabar.Enabled = False
            End If

            'Habilitar
            Me.Grabar.Visible = True
            Me.GroupBoxCategoria.Visible = True
            'Foco
            Me.Descripcion.Focus()
        Else
            'Asignar
            Me.CodigoCategoria.Text = ""

            Me.Descripcion.Text = ""

            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

            'Foco
            Me.CodigoCategoria.Focus()
        End If

        CodigoCategoria.Enabled = False
        Nuevo.Visible = True
        Descripcion.SelectAll()
        Descripcion.Focus()
    End Sub
#End Region

#Region "  Rutina: catalogo  "
    Sub Catalogo()
        Caja = "Consulta101" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)
            Me.CodigoCategoria.Text = nuevo.resultado

            If nuevo.resultado = "" Then
                Return
            End If

            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            'Me.CodigoCategoria_KeyDown(DBNull.Value, e)
            consulta101()

        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If

    End Sub
#End Region

#Region "  Evento: codigoCategoria - KEY PRESS "
    Private Sub CodigoCategoria_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CodigoCategoria.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            CodigoCategoria.Enabled = False

            Caja = "Consulta101" : Parametros = "V1=" & Me.CodigoCategoria.Text
            If lConsulta Is Nothing Then lConsulta = New ClsConsultas
            ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)
            If ObjRet.bOk Then
                ToolStripStatusLabelCat.Text = ""
                Me.Limpiar.Visible = True

                'Deshabilitar
                'Asignar
                Me.Descripcion.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")

                'Habilitar
                Me.Grabar.Visible = True
                Me.GroupBoxCategoria.Visible = True
                'Foco
                Me.Descripcion.Focus()
            Else
                'Asignar
                Me.CodigoCategoria.Text = ""

                Me.Descripcion.Text = ""

                MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

                'Foco
                Me.CodigoCategoria.Focus()
            End If
            ObjRet = Nothing
        End If
    End Sub
#End Region


End Class