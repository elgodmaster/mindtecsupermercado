Imports MindTec.Componentes

Public Class Movimiento_Salidas
#Region "Variables de trabajo"
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    Private modelo As DevAge.ComponentModel.BoundList(Of Detalles)
    Private lista As List(Of Detalles)
    Private dat As Detalles
    Private fila As Integer
    Class Detalles
        Private codProd As String
        Property colCodigo() As String
            Get
                Return codProd
            End Get
            Set(ByVal value As String)
                If value <> Nothing Then
                    codProd = value
                End If
            End Set
        End Property

        Private categoria As String
        Property colCategoria() As String
            Get
                Return categoria
            End Get
            Set(ByVal value As String)
                categoria = value
            End Set
        End Property

        Private producto As String
        Property colProducto() As String
            Get
                Return producto
            End Get
            Set(ByVal value As String)
                producto = value
            End Set
        End Property

        Private marca As String
        Property colMarca() As String
            Get
                Return marca
            End Get
            Set(ByVal value As String)
                marca = value
            End Set
        End Property


        Private cantidad As String
        Property colCantidad() As String
            Get
                Return cantidad
            End Get
            Set(ByVal value As String)
                If value <> Nothing Then
                    cantidad = value
                End If
            End Set
        End Property

        Public Sub New()
            Me.cantidad = "0"
            Me.categoria = ""
            Me.codProd = ""
            Me.marca = ""
            Me.producto = ""

        End Sub

    End Class
    Class KeyEvent
        Inherits SourceGrid.Cells.Controllers.ControllerBase
        Private padre As Movimiento_Salidas
        Dim Caja As String = ""
        Dim Parametros As String = ""
        Dim lConsulta As New ClsConsultas
        Dim ObjRet As CRetorno
        Public Sub New(ByVal frm As Movimiento_Salidas)
            padre = frm
        End Sub
        Public Overrides Sub OnEditStarted(ByVal sender As SourceGrid.CellContext, ByVal e As System.EventArgs)
            MyBase.OnEditStarted(sender, e)
            Dim datos As Detalles

            Dim nuevo As Grid
            Dim resultado As String
            Caja = "Consulta110" : Parametros = ""
            If lConsulta Is Nothing Then lConsulta = New ClsConsultas
            ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)


            If ObjRet.bOk Then
                nuevo = New Grid(ObjRet.DS)
                resultado = nuevo.resultado

                Caja = "Consulta110" : Parametros = "V1=" + resultado + "|"
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "3", Parametros)
                If ObjRet.bOk Then

                    sender.EndEdit(True)
                    datos = Me.padre.getDetalle(sender.Position.Row)

                    datos.colCodigo = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
                    datos.colCategoria = lConsulta.ObtenerValor("V2", ObjRet.sResultado, "|")
                    datos.colProducto = lConsulta.ObtenerValor("V3", ObjRet.sResultado, "|")
                    datos.colMarca = lConsulta.ObtenerValor("V4", ObjRet.sResultado, "|")




                End If
            End If

        End Sub
        Public Overrides Sub OnEditEnded(ByVal sender As SourceGrid.CellContext, ByVal e As System.EventArgs)
            MyBase.OnEditEnded(sender, e)
        End Sub



    End Class

#End Region

#Region " Eventos Principales"
    Private Sub frm_Salidas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Cerrar()
            Case Keys.F4
                Limpiar.PerformClick()
            Case Keys.F9
                Grabar.PerformClick()
        End Select
    End Sub

    Private Sub frm_Entradas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Pie de Pagina Mensaje
        MensajePiePagina.Text = "Esc=Salir Enter=Avanzar F2=Catálogo F4=Limpiar Pantalla"
        'Deshabilitar
        Me.Grabar.Visible = False

        Me.SalidaDetalles.Columns.Add("colCodigo", "Cod Producto", GetType(String)).Width = 187
        Me.SalidaDetalles.Columns.Add("colcategoria", "Categoria", GetType(String)).Width = 187
        Me.SalidaDetalles.Columns.Add("colProducto", "Producto", "".GetType()).Width = 186
        Me.SalidaDetalles.Columns.Add("colMarca", "Marca", GetType(String)).Width = 187
        Me.SalidaDetalles.Columns.Add("colCantidad", "Cantidad", GetType(String)).Width = 187

        Me.lista = New List(Of Detalles)()
        Me.modelo = New DevAge.ComponentModel.BoundList(Of Detalles)(lista)

        Me.SalidaDetalles.DataSource = Me.modelo
        Me.SalidaDetalles.GetCell(1, 0).AddController(New KeyEvent(Me))

        Me.SalidaDetalles.GetCell(1, 1).Editor.EditableMode = SourceGrid.EditableMode.None
        Me.SalidaDetalles.GetCell(1, 2).Editor.EditableMode = SourceGrid.EditableMode.None
        Me.SalidaDetalles.GetCell(1, 3).Editor.EditableMode = SourceGrid.EditableMode.None

        'Pie de Pagina Mensaje
        MensajePiePagina.Text = "Esc=Salir Enter=Avanzar F2=Catálogo F4=Limpiar Pantalla"
        'Deshabilitar
        Me.Grabar.Visible = False
        Me.Limpiar.PerformClick()
    End Sub

#End Region

#Region " Rutinas "
    Public Function getDetalle(ByVal row As Integer) As Detalles
        Return Me.lista.Item(row - 1)
    End Function

    Public Sub catalogo()
        Caja = "Consulta111" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            Me.FolioSalida.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.FolioSalida_KeyDown(DBNull.Value, e)
        End If
    End Sub

    Sub LimpiarPantalla()
        Me.btnAceptar.Enabled = True
        Me.FolioSalida.Enabled = True
        Me.Nuevo.Visible = True
        Me.Grabar.Visible = False

        Me.GroupBoxSalida.Visible = False
        Me.lista.Clear()
        Me.Fecha.Value = DateTime.Now
        Me.txtDescripcion.Text = ""
        Me.FolioSalida.Text = ""
        MensajePiePagina.Text = "Esc=Salir Enter=Avanzar F2=Catalogo F4=Limpiar Pantalla"
        Me.FolioSalida.Focus()

    End Sub
    Sub Cerrar()
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Deseas salir de esta pantalla?", "HidroIntel", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region

#Region " Salida "
    Private Sub FolioSalida_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FolioSalida.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                catalogo()
            Case Keys.Enter, Keys.Down
                SendKeys.Send("{TAB}")
            Case Keys.Up
                SendKeys.Send("+{TAB}")
        End Select
    End Sub
#End Region

#Region " Aceptar "
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Caja = "Consulta111" : Parametros = "V1=" & Me.FolioSalida.Text
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)
        If ObjRet.bOk Then
            Me.FolioSalida.Enabled = False
            Me.btnAceptar.Enabled = False
            Me.Nuevo.Visible = False
            Try
                Me.Fecha.Value = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
            Catch ex As Exception
                Me.Fecha.Value = DateTime.Now
            End Try
            Me.txtDescripcion.Text = lConsulta.ObtenerValor("V3", ObjRet.sResultado, "|")
            Dim reader As DataTableReader = Me.ObjRet.DS.Tables(0).CreateDataReader()
            lista.Clear()
            While reader.Read()
                Dim deta As New Detalles()
                deta.colCantidad = reader.Item("cantidad").ToString().Trim()
                deta.colCategoria = reader.Item("categoria").ToString().Trim()
                deta.colCodigo = reader.Item("codigo").ToString().Trim()
                deta.colMarca = reader.Item("marca").ToString().Trim()
                deta.colProducto = reader.Item("Producto").ToString().Trim()
                lista.Add(deta)
            End While
            Me.SalidaDetalles.Refresh()
            Me.GroupBoxSalida.Visible = True
            Me.Grabar.Visible = True
            MensajePiePagina.Text = "Esc=Salir Enter=Avanzar F2=Catálogo F4=Limpiar Pantalla F9=Grabar"
            Me.SalidaDetalles.Focus()

        End If
    End Sub
#End Region

#Region " Limpiar "
    Private Sub Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        LimpiarPantalla()
    End Sub
#End Region

#Region " Grabar "
    Private Sub Grabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grabar.Click
        'Variable de trabajo
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Deseas Guardar los Cambios?", "PVFacturacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            Caja = "Grabar111A" : Parametros = "V1=" & Me.FolioSalida.Text & _
                                              "|V2=" & Me.Fecha.Value.ToString("MM/dd/yyyy hh:mm:ss") & _
                                              "|V3=" & "1" & _
                                              "|V4=" & Me.txtDescripcion.Text.Trim() & "|"
            If lConsulta Is Nothing Then lConsulta = New ClsConsultas
            ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
            If ObjRet.bOk Then
                Caja = "Grabar111B"
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                For Each obj As Detalles In lista
                    Parametros = "V1=" & Me.FolioSalida.Text & _
                                "|V2=" & obj.colCodigo & _
                                "|V3=" & obj.colCantidad & "|"
                    ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                    If Not ObjRet.bOk Then
                        '' algo anda mal
                        MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                        Return
                    End If
                Next
            End If
            If ObjRet.bOk Then
                MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                LimpiarPantalla()
            Else
                MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
            End If
        End If
    End Sub
#End Region

#Region " Nuevo "
    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        Caja = "Consulta111" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "3", Parametros)
        If ObjRet.bOk Then
            'Deshabilitar
            Me.Nuevo.Visible = False
            Me.FolioSalida.Enabled = False
            Me.btnAceptar.Enabled = False
            'Asignar
            Me.FolioSalida.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
            'Habilitar
            Me.GroupBoxSalida.Visible = True
            Me.Grabar.Visible = True
            'Focus
            Me.txtDescripcion.Focus()

        End If
    End Sub
#End Region

End Class