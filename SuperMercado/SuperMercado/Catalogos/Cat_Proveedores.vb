Imports MindTec.Componentes

Public Class Cat_Proveedores

#Region "  Variables de trabajo  "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno

    ' Grid datos para PROVEEDORES
    Dim dsDatosProveedores As DataSet
    Dim dtProveedores As DataTable
    Dim viewDatosProveedores As Object
    Dim DsViewProveedores As Object

    'Grid datos para CUENTAS POR PAGAR
    Dim dsDatosCuentas As DataSet
    Dim dtCuentas As DataTable
    Dim viewDatosCuentas As Object
    Dim DsViewCuentas As Object

    Dim objNuevaCuenta As Cat_Proveedores_Nueva_Cuenta
    Dim producto As String
    Dim cantidad As String
    Dim costo As String

    Dim objAbonar As Cat_Proveedores_RegistroAbono
    Dim monto As Decimal

    Dim objAbonos As Cat_Proveedores_DetalleAbono
    Dim idCuenta As String
#End Region

#Region "  Grid Datos PROVEEDORES  "

    Sub CrearDsDatosPROVEEDORES()
        dsDatosProveedores = New DataSet("Root")
        dtProveedores = New DataTable("Table")
        dsDatosProveedores.Tables.Add(dtProveedores)

        dsDatosProveedores.Tables("Table").Columns.Add("C1", GetType(String))
        dsDatosProveedores.Tables("Table").Columns.Add("C2", GetType(String))
        dsDatosProveedores.Tables("Table").Columns.Add("C3", GetType(String))
        dsDatosProveedores.Tables("Table").Columns.Add("C4", GetType(String))
        dsDatosProveedores.Tables("Table").Columns.Add("C5", GetType(String))
        dsDatosProveedores.Tables("Table").Columns.Add("C6", GetType(String))
        dsDatosProveedores.Tables("Table").Columns.Add("C7", GetType(String))

    End Sub

    Sub ConfiguraGridDatosPROVEEDORES()
        viewDatosProveedores = dsDatosProveedores.Tables("Table").DefaultView

        GridDatosPROVEEDORES.SelectionMode = SourceGrid.GridSelectionMode.Row


        viewDatosProveedores.AllowEdit = False
        viewDatosProveedores.AllowNew = False
        viewDatosProveedores.AllowDelete = True

        GridDatosPROVEEDORES.FixedRows = 1
        GridDatosPROVEEDORES.FixedColumns = 1
        GridDatosPROVEEDORES.DeleteRowsWithDeleteKey = False
        GridDatosPROVEEDORES.DeleteQuestionMessage = Nothing
        GridDatosPROVEEDORES.SelectionMode = SourceGrid.GridSelectionMode.Row

        ' Renglon encabezado

        GridDatosPROVEEDORES.Columns.Insert(0, SourceGrid.DataGridColumn.CreateRowHeader(GridDatosPROVEEDORES))

        Dim BindList2 As DevAge.ComponentModel.IBoundList = New DevAge.ComponentModel.BoundDataView(viewDatosProveedores)

        ' Se crean las columnas.
        GridDatosCrearColumnasPROVEEDORES(GridDatosPROVEEDORES.Columns, BindList2)

        GridDatosPROVEEDORES.DataSource = BindList2

        Dim cColorHeader As Color
        cColorHeader = Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(168, Byte), Integer))

        'Vista columna encabezado

        Dim viewcolumnheader As SourceGrid.Cells.Views.ColumnHeader = New SourceGrid.Cells.Views.ColumnHeader
        Dim backheader As DevAge.Drawing.VisualElements.ColumnHeader = New DevAge.Drawing.VisualElements.ColumnHeader
        viewcolumnheader.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewcolumnheader.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleLeft

        Dim viewcolumnheader2 As SourceGrid.Cells.Views.ColumnHeader = New SourceGrid.Cells.Views.ColumnHeader
        Dim backheader2 As DevAge.Drawing.VisualElements.ColumnHeader = New DevAge.Drawing.VisualElements.ColumnHeader
        viewcolumnheader2.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewcolumnheader2.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleRight

        Dim viewcolumnheader3 As SourceGrid.Cells.Views.ColumnHeader = New SourceGrid.Cells.Views.ColumnHeader
        Dim backheader3 As DevAge.Drawing.VisualElements.ColumnHeader = New DevAge.Drawing.VisualElements.ColumnHeader
        viewcolumnheader3.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewcolumnheader3.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter


        GridDatosPROVEEDORES.GetCell(0, 1).View = viewcolumnheader3
        GridDatosPROVEEDORES.GetCell(0, 2).View = viewcolumnheader
        GridDatosPROVEEDORES.GetCell(0, 3).View = viewcolumnheader
        GridDatosPROVEEDORES.GetCell(0, 4).View = viewcolumnheader
        GridDatosPROVEEDORES.GetCell(0, 5).View = viewcolumnheader3
        GridDatosPROVEEDORES.GetCell(0, 6).View = viewcolumnheader



    End Sub

    Private Sub GridDatosCrearColumnasPROVEEDORES(ByVal columns As SourceGrid.DataGridColumns, ByVal Bindlist As DevAge.ComponentModel.IBoundList)
        'Borders

        Dim border As DevAge.Drawing.RectangleBorder = New DevAge.Drawing.RectangleBorder(New DevAge.Drawing.BorderLine(Color.White), New DevAge.Drawing.BorderLine(Color.White))
        'gcolorRow esta declarada en el moduloGeneral

        'vistas
        Dim viewCenter As CellBackColorAlternate = New CellBackColorAlternate(Color.White, Color.White)
        viewCenter.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewCenter.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter


        Dim viewIzquierda As CellBackColorAlternate = New CellBackColorAlternate(Color.White, Color.White)
        viewIzquierda.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewIzquierda.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleLeft

        Dim viewDerecha As CellBackColorAlternate = New CellBackColorAlternate(Color.White, Color.White)
        viewDerecha.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewDerecha.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleRight

        Dim myfont As New Font("Verdana", 8, FontStyle.Regular)

        'Eventos


        'Definicion de la celda
        Dim EditorCustom As SourceGrid.Cells.Editors.TextBox = New SourceGrid.Cells.Editors.TextBox(GetType(String))
        EditorCustom.EditableMode = SourceGrid.EditableMode.None

        'Crear columnas
        Dim GridColumn As SourceGrid.DataGridColumn

        GridColumn = GridDatosPROVEEDORES.Columns.Add("C1", "ID", EditorCustom)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosPROVEEDORES.Columns.Add("C2", "Nombre", EditorCustom)
        GridColumn.DataCell.View = viewIzquierda
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosPROVEEDORES.Columns.Add("C3", "Colonia", EditorCustom)
        GridColumn.DataCell.View = viewIzquierda
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosPROVEEDORES.Columns.Add("C4", "Dirección", EditorCustom)
        GridColumn.DataCell.View = viewIzquierda
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosPROVEEDORES.Columns.Add("C5", "Teléfono", EditorCustom)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosPROVEEDORES.Columns.Add("C6", "E-Mail", EditorCustom)
        GridColumn.DataCell.View = viewIzquierda
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridDatosPROVEEDORES.Columns(0).Visible = False

        GridDatosPROVEEDORES.Columns.SetWidth(1, 50)
        GridDatosPROVEEDORES.Columns.SetWidth(2, 200)
        GridDatosPROVEEDORES.Columns.SetWidth(3, 145)
        GridDatosPROVEEDORES.Columns.SetWidth(4, 300)
        GridDatosPROVEEDORES.Columns.SetWidth(5, 90)
        GridDatosPROVEEDORES.Columns.SetWidth(6, 170)


    End Sub
#End Region

#Region "  Grid Datos CUENTAS  "

    Sub CreardsDatosCuentas()

        dsDatosCuentas = New DataSet("Root")
        dtCuentas = New DataTable("Table")
        dsDatosCuentas.Tables.Add(dtCuentas)

        'DsDatos.Tables("Table").Columns.Add("C0", GetType(String))
        'COLUMNAS
        dsDatosCuentas.Tables("Table").Columns.Add("C1", GetType(String))
        dsDatosCuentas.Tables("Table").Columns.Add("C2", GetType(String))
        dsDatosCuentas.Tables("Table").Columns.Add("C3", GetType(String))
        dsDatosCuentas.Tables("Table").Columns.Add("C4", GetType(String))
        dsDatosCuentas.Tables("Table").Columns.Add("C5", GetType(String))

    End Sub

    Sub ConfiguraGridDatosCuentas()
        viewDatosCuentas = dsDatosCuentas.Tables("Table").DefaultView

        viewDatosCuentas.AllowEdit = False
        viewDatosCuentas.AllowNew = False
        viewDatosCuentas.AllowDelete = True

        GridDatosCuentas.FixedRows = 1
        GridDatosCuentas.FixedColumns = 1
        GridDatosCuentas.DeleteRowsWithDeleteKey = False
        GridDatosCuentas.DeleteQuestionMessage = Nothing
        GridDatosCuentas.Selection.EnableMultiSelection = False

        ' Renglon encabezado

        GridDatosCuentas.Columns.Insert(0, SourceGrid.DataGridColumn.CreateRowHeader(GridDatosCuentas))

        Dim BindList2 As DevAge.ComponentModel.IBoundList = New DevAge.ComponentModel.BoundDataView(viewDatosCuentas)

        ' Se crean las columnas.
        GridDatosCrearColumnasCUENTAS(GridDatosCuentas.Columns, BindList2)

        GridDatosCuentas.DataSource = BindList2

        Dim cColorHeader As Color
        cColorHeader = Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(168, Byte), Integer))

        'Vista columna encabezado
        Dim viewcolumnheader As SourceGrid.Cells.Views.ColumnHeader = New SourceGrid.Cells.Views.ColumnHeader
        Dim backheader As DevAge.Drawing.VisualElements.ColumnHeader = New DevAge.Drawing.VisualElements.ColumnHeader
        viewcolumnheader.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewcolumnheader.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleLeft

        Dim viewcolumnheader2 As SourceGrid.Cells.Views.ColumnHeader = New SourceGrid.Cells.Views.ColumnHeader
        Dim backheader2 As DevAge.Drawing.VisualElements.ColumnHeader = New DevAge.Drawing.VisualElements.ColumnHeader
        viewcolumnheader2.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewcolumnheader2.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleRight

        Dim viewcolumnheader3 As SourceGrid.Cells.Views.ColumnHeader = New SourceGrid.Cells.Views.ColumnHeader
        Dim backheader3 As DevAge.Drawing.VisualElements.ColumnHeader = New DevAge.Drawing.VisualElements.ColumnHeader
        viewcolumnheader3.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewcolumnheader3.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter

        'COLUMNAS
        GridDatosCuentas.GetCell(0, 1).View = viewcolumnheader3
        GridDatosCuentas.GetCell(0, 2).View = viewcolumnheader
        GridDatosCuentas.GetCell(0, 3).View = viewcolumnheader3
        GridDatosCuentas.GetCell(0, 4).View = viewcolumnheader3
        GridDatosCuentas.GetCell(0, 5).View = viewcolumnheader3

    End Sub

    Private Sub GridDatosCrearColumnasCUENTAS(ByVal columns As SourceGrid.DataGridColumns, ByVal Bindlist As DevAge.ComponentModel.IBoundList)
        'Borders

        Dim border As DevAge.Drawing.RectangleBorder = New DevAge.Drawing.RectangleBorder(New DevAge.Drawing.BorderLine(Color.Black), New DevAge.Drawing.BorderLine(Color.Black))
        'gcolorRow esta declarada en el moduloGeneral

        'vistas
        Dim viewCenter As CellBackColorAlternate = New CellBackColorAlternate(Color.White, Color.White)
        viewCenter.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewCenter.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter

        Dim viewIzquierda As CellBackColorAlternate = New CellBackColorAlternate(Color.White, Color.White)
        viewIzquierda.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewIzquierda.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleLeft

        Dim viewDerecha As CellBackColorAlternate = New CellBackColorAlternate(Color.White, Color.White)
        viewDerecha.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewDerecha.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleRight

        Dim myfont As New Font("Verdana", 8, FontStyle.Regular)


        'EVENTOS

        Dim gridKeydown As SourceGrid.Cells.Controllers.CustomEvents = New SourceGrid.Cells.Controllers.CustomEvents
        AddHandler gridKeydown.KeyDown, New KeyEventHandler(AddressOf Grid_KeyDown)

        'Definicion de la celda
        Dim EditorCustom As SourceGrid.Cells.Editors.TextBox = New SourceGrid.Cells.Editors.TextBox(GetType(String))
        EditorCustom.EditableMode = SourceGrid.EditableMode.None

        'Crear columnas
        Dim GridColumn As SourceGrid.DataGridColumn

        GridColumn = GridDatosCuentas.Columns.Add("C1", "Cuenta", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosCuentas.Columns.Add("C2", "Artículo(s)", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewIzquierda
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosCuentas.Columns.Add("C3", "Monto", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewDerecha
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosCuentas.Columns.Add("C4", "Adeudo", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewDerecha
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosCuentas.Columns.Add("C5", "Abonado", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewDerecha
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridDatosCuentas.Columns(0).Visible = False

        ''COLUMNAS

        GridDatosCuentas.Columns.SetWidth(1, 70)
        GridDatosCuentas.Columns.SetWidth(2, 149)
        GridDatosCuentas.Columns.SetWidth(3, 128)
        GridDatosCuentas.Columns.SetWidth(4, 128)
        GridDatosCuentas.Columns.SetWidth(5, 128)

    End Sub

    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
#End Region

#Region " Evento: Cat_Proveedores - LOAD  "
    Private Sub Cat_Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showProvGrid()

        ocultarControlesCuentas()

        ProveedoresTabControl.Visible = False
        Me.Grabar.Visible = False

        'Se cargan los comboBox de Estados y Municipios
        Caja = "Consulta114a" : Parametros = ""
        ObjRet = lConsulta.LlamarCaja(Caja, 2, Parametros)
        EstadosComboBox.DataSource = ObjRet.DS.Tables(0)
        EstadosComboBox.DisplayMember = ObjRet.DS.Tables(0).Columns(0).Caption.ToString
        EstadosComboBox.Text = "Aguascalientes"

        Caja = "Consulta114b" : Parametros = "V1=" & EstadosComboBox.Text & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, 2, Parametros)

        CiudadesComboBox.DataSource = ObjRet.DS.Tables(0)
        CiudadesComboBox.DisplayMember = ObjRet.DS.Tables(0).Columns(0).Caption.ToString

        CrearDsDatosPROVEEDORES()
        ConfiguraGridDatosPROVEEDORES()
        CreardsDatosCuentas()
        ConfiguraGridDatosCuentas()

        consulta129()
    End Sub
#End Region

#Region "  Botón NUEVO  "
    Private Sub ToolStripButtonNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonNuevo.Click
        limpiarPantalla()
        showData()
        ToolStripButtonNuevo.Visible = False
        Limpiar.Visible = True
        Grabar.Visible = True

        ProveedoresTabControl.SelectTab(0)
        TxtNombre.Focus()
    End Sub
#End Region

#Region "  Botón LIMPIAR  "
    Private Sub Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        limpiarPantalla()
    End Sub
#End Region

#Region "  Botón GRABAR  "
    Private Sub Grabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grabar.Click
        'Variable de trabajo
        Dim Result As DialogResult
        Dim resultado As String
        Result = MessageBox.Show("  ¿Desea guardar los cambios realizados?  ", " Proveedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            grabar106()
            resultado = lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False)
            If ObjRet.bOk Then
                MessageBox.Show(" " & resultado, " Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarPantalla()
            Else
                MessageBox.Show(" " & resultado, " Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            showProvGrid()
            consulta129()
            Limpiar.Visible = False
            Grabar.Visible = False
            ToolStripButtonNuevo.Visible = True
        End If

    End Sub
#End Region

#Region "  Botón NUEVA CUENTA  "
    Private Sub ToolStripButtonNuevaCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonNuevaCuenta.Click
        Dim objNuevaCuenta As New Cat_Proveedores_Nueva_Cuenta
        objNuevaCuenta.StartPosition = FormStartPosition.CenterScreen
        objNuevaCuenta.ShowDialog()

        If objNuevaCuenta.ok Then
            producto = objNuevaCuenta.producto.Trim
            cantidad = objNuevaCuenta.cantidad.ToString
            costo = objNuevaCuenta.costo.ToString

            grabar127()

            consulta106()

            consulta130()

        End If

    End Sub
#End Region

#Region "  Botón ELIMINAR CUENTA  "
    Private Sub ToolStripButtonEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonEliminar.Click
        Dim pos As Integer = posRowCuentas()
        If pos < 0 Then
            Return
        End If

        Dim resul As DialogResult
        resul = MessageBox.Show(" La cuenta será liquidada, ¿desea continuar?", " Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resul = Windows.Forms.DialogResult.Yes Then
            eliminar105()
        End If
    End Sub
#End Region

#Region "  Botón DETALLE  "
    Private Sub ToolStripButtonDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonDetalle.Click
        Dim pos As Integer = posRowCuentas()
        If pos < 0 Then
            Return
        End If

        Dim objDetalle As New Cat_Proveedores_DetalleVenta
        objDetalle.idCuenta = dsDatosCuentas.Tables(0).Rows(pos).Item(0).ToString
        objDetalle.nomCliente = Proveedor.Text.Trim
        objDetalle.refCatProv = Me

        objDetalle.StartPosition = FormStartPosition.CenterScreen
        objDetalle.ShowDialog()

    End Sub
#End Region

#Region "  Botón ABONOS REGISTRADOS  "
    Private Sub ToolStripButtonAbonos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonAbonos.Click
        If posRowCuentas() < 0 Then
            Return
        End If

        idCuenta = dsDatosCuentas.Tables(0).Rows(posRowCuentas).Item(0).ToString

        Dim objAbonos As New Cat_Proveedores_DetalleAbono
        objAbonos.idCuenta = idCuenta

        objAbonos.StartPosition = FormStartPosition.CenterScreen
        objAbonos.ShowDialog()

    End Sub
#End Region

#Region "  Botón ABONAR  "
    Private Sub ToolStripButtonAbonar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonAbonar.Click
        If posRowCuentas() < 0 Then
            Return
        End If

        Dim objAbonar As New Cat_Proveedores_RegistroAbono
        Dim adeudo As String = dsDatosCuentas.Tables(0).Rows(posRowCuentas).Item(3).ToString
        adeudo = adeudo.Remove(0, 2)

        objAbonar.adeudo = adeudo

        objAbonar.StartPosition = FormStartPosition.CenterScreen
        objAbonar.ShowDialog()

        If objAbonar.ok Then
            monto = objAbonar.monto

            grabar128()

        End If

    End Sub
#End Region

#Region "  Rutinas  "

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
        Result = MessageBox.Show("¿Deseas salir de esta pantalla?", "Supermercados Beltrán", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region

#Region "  Rutina: limpiarPantalla  "
    Sub limpiarPantalla()
        Me.Proveedor.Clear()
        Me.TxtNombre.Clear()
        Me.txtRfc.Clear()
        Me.TxtColonia.Clear()
        Me.TxtDireccion.Clear()
        Me.Txtcp.Clear()
        Me.TxtMail.Clear()
        Me.TxtTel.Clear()
        Me.TxtTel2.Clear()
        Me.TxtCel.Clear()
        Me.TxtCel2.Clear()
        Me.txtext.Clear()
        Me.txtext2.Clear()
        Me.TxtFax.Clear()
        Me.txtCodigo.Clear()

        Me.TxtNombre.Focus()

        dsDatosCuentas.Tables(0).Clear()
        LabelDeuda.Text = "$ 0.00"

    End Sub
#End Region

#Region "  Rutina: posRowProveedores  "
    Private Function posRowProveedores() As Integer
        Dim pos() As Integer = GridDatosPROVEEDORES.Selection.GetSelectionRegion.GetRowsIndex
        If pos.Length = 0 Then
            Return -1
        Else
            Return pos(0) - 1
        End If
    End Function
#End Region

#Region "  Rutina: posRowCuentas  "
    Private Function posRowCuentas() As Integer
        Dim pos() As Integer = GridDatosCuentas.Selection.GetSelectionRegion.GetRowsIndex
        If pos.Length = 0 Then
            Return -1
        Else
            Return pos(0) - 1
        End If
    End Function
#End Region

#Region "  Rutina: showProvGrid  "
    Sub showProvGrid()
        PanelGrid.Visible = True
        PanelGrid.SetBounds(11, 150, 1000, 525)

        PanelDatos.Visible = False
    End Sub
#End Region

#Region "  Rutina: showData  "
    Sub showData()
        PanelDatos.SetBounds(11, 138, 1000, 525)
        ProveedoresTabControl.Visible = True
        PanelDatos.Visible = True
        Grabar.Visible = True
        ToolStripStatusLabelProveedores.Text = ""

        PanelGrid.Visible = False
        Proveedor.Enabled = False
    End Sub
#End Region

#Region "  Rutina: consulta106  "
    Sub consulta106()
        ' Regresa los campos de un proveedor.
        Caja = "Consulta106" : Parametros = "V1=" & Me.Proveedor.Text
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)
        If ObjRet.bOk Then

            'Asignar
            Me.TxtNombre.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
            Me.txtRfc.Text = lConsulta.ObtenerValor("V2", ObjRet.sResultado, "|")
            Me.TxtColonia.Text = lConsulta.ObtenerValor("V3", ObjRet.sResultado, "|")
            Me.TxtDireccion.Text = lConsulta.ObtenerValor("V4", ObjRet.sResultado, "|")
            Me.Txtcp.Text = lConsulta.ObtenerValor("V5", ObjRet.sResultado, "|")
            Me.EstadosComboBox.Text = lConsulta.ObtenerValor("V6", ObjRet.sResultado, "|")
            Me.CiudadesComboBox.Text = lConsulta.ObtenerValor("V7", ObjRet.sResultado, "|")
            Me.TxtTel.Text = lConsulta.ObtenerValor("V8", ObjRet.sResultado, "|")
            Me.txtext.Text = lConsulta.ObtenerValor("V9", ObjRet.sResultado, "|")
            Me.TxtTel2.Text = lConsulta.ObtenerValor("V10", ObjRet.sResultado, "|")
            Me.txtext2.Text = lConsulta.ObtenerValor("V11", ObjRet.sResultado, "|")
            Me.TxtCel.Text = lConsulta.ObtenerValor("V12", ObjRet.sResultado, "|")
            Me.TxtCel2.Text = lConsulta.ObtenerValor("V13", ObjRet.sResultado, "|")
            Me.TxtFax.Text = lConsulta.ObtenerValor("V14", ObjRet.sResultado, "|")
            Me.TxtMail.Text = lConsulta.ObtenerValor("V15", ObjRet.sResultado, "|")
            Me.LabelDeuda.Text = FormatCurrency(lConsulta.ObtenerValor("V16", ObjRet.sResultado, "|"))
            Me.txtCodigo.Text = lConsulta.ObtenerValor("V17", ObjRet.sResultado, "|")

        End If
    End Sub
#End Region

#Region "  Rutina: consulta130  "
    Sub consulta130()
        'Actualiza las cuentas por pagar a un proveedor.

        dsDatosCuentas.Tables(0).Clear()

        Caja = "consulta130" : Parametros = "V1=" & TxtNombre.Text.Trim & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        If Not ObjRet.DS Is DBNull.Value Then
            If Not ObjRet.DS.Tables Is DBNull.Value Then
                If ObjRet.DS.Tables.Count > 0 Then
                    For i As Integer = 0 To ObjRet.DS.Tables(0).Rows.Count - 1
                        dsDatosCuentas.Tables(0).ImportRow(ObjRet.DS.Tables(0).Rows(i))
                    Next
                    dsDatosCuentas.Tables(0).AcceptChanges()
                    DsViewCuentas = dsDatosCuentas.Tables(0).DefaultView
                    'Else
                    '   FilaVacia()

                End If
            End If
        End If

    End Sub
#End Region

#Region "  Rutina: consulta129  "
    Sub consulta129()
        'Actualiza el grid de todos los proveedores según el valor de Proveedor.
        dsDatosProveedores.Tables(0).Clear()

        Caja = "Consulta129" : Parametros = "V1=" & Proveedor.Text.Trim & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        If Not ObjRet.DS Is DBNull.Value Then
            If Not ObjRet.DS.Tables Is DBNull.Value Then
                If ObjRet.DS.Tables.Count > 0 Then
                    Dim rows As Integer
                    rows = ObjRet.DS.Tables(0).Rows.Count - 1
                    For i As Integer = 0 To ObjRet.DS.Tables(0).Rows.Count - 1
                        dsDatosProveedores.Tables(0).ImportRow(ObjRet.DS.Tables(0).Rows(i))
                    Next
                    dsDatosProveedores.Tables(0).AcceptChanges()
                    DsViewProveedores = dsDatosProveedores.Tables(0).DefaultView
                    'Else
                    '   FilaVacia()

                End If
            End If
        End If

    End Sub
#End Region

#Region "  Rutina: GRABAR106  "
    Sub grabar106()
        'Graba un nuevo PROVEEDOR
        Caja = "Grabar106" : Parametros = "V1=" & Me.txtCodigo.Text.Trim & _
                                              "|V2=" & Me.TxtNombre.Text.Trim & _
                                              "|V3=" & Me.txtRfc.Text.Trim & _
                                              "|V4=" & Me.TxtColonia.Text.Trim & _
                                              "|V5=" & Me.TxtDireccion.Text.Trim & _
                                              "|V6=" & Me.Txtcp.Text.Trim & _
                                              "|V7=" & Me.EstadosComboBox.Text.Trim & _
                                              "|V8=" & Me.CiudadesComboBox.Text.Trim & _
                                              "|V9=" & Me.TxtTel.Text.Trim & _
                                              "|V10=" & Me.txtext.Text.Trim & _
                                              "|V11=" & Me.TxtTel2.Text.Trim & _
                                              "|V12=" & Me.txtext2.Text.Trim & _
                                              "|V13=" & Me.TxtCel.Text.Trim & _
                                              "|V14=" & Me.TxtCel2.Text.Trim & _
                                              "|V15=" & Me.TxtMail.Text.Trim & _
                                              "|V16=" & Me.TxtFax.Text.Trim & "|"

        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
    End Sub
#End Region

#Region "  Rutina: GRABAR127  "
    Sub grabar127()
        ' Graba una nueva CUENTA
        Caja = "grabar127"
        Parametros = "V1=" & producto.Trim & _
                     "|V2=" & cantidad.Trim & _
                     "|V3=" & costo.Trim & _
                     "|V4=" & TxtNombre.Text.Trim & _
                     "|V5=" & idUsuario
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        consulta130()

    End Sub
#End Region

#Region "  Rutina: GRABAR128  "
    Sub grabar128()
        Dim idCuenta As String = dsDatosCuentas.Tables(0).Rows(posRowCuentas).Item(0).ToString

        Caja = "GRABAR128" : Parametros = "V1=" & idCuenta.Trim & _
                                          "|V2=" & monto & _
                                          "|V3=" & idUsuario & _
                                          "|V4=" & Proveedor.Text.Trim & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)

        consulta106()

        consulta130()

    End Sub
#End Region

#Region "  Rutina: eliminar105  "
    Sub eliminar105()
        Dim idCuenta As String
        Dim adeudo As String

        idCuenta = dsDatosCuentas.Tables(0).Rows(posRowCuentas).Item(0).ToString
        adeudo = dsDatosCuentas.Tables(0).Rows(posRowCuentas).Item(3).ToString
        adeudo = adeudo.Remove(0, 2)

        Caja = "eliminar105" : Parametros = "V1=" & idCuenta.Trim & _
                                            "|V2=" & adeudo.Trim & _
                                            "|V3=" & TxtNombre.Text.Trim
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        consulta106()

        consulta130()

    End Sub
#End Region

#Region "  Rutina: mostrarControles  "
    Sub mostrarControles()
        ToolStripSeparator1.Visible = True
        ToolStripSeparator2.Visible = True

        ToolStripButtonNuevaCuenta.Visible = True
        ToolStripButtonEliminar.Visible = True

        ToolStripButtonAbonos.Visible = True
        ToolStripButtonDetalle.Visible = True
        ToolStripButtonAbonar.Visible = True
    End Sub
#End Region

#Region "  Rutina: ocultarControles  "
    Sub ocultarControlesCuentas()
        ToolStripSeparator1.Visible = False
        ToolStripSeparator2.Visible = False

        ToolStripButtonNuevaCuenta.Visible = False
        ToolStripButtonEliminar.Visible = False

        ToolStripButtonAbonos.Visible = False
        ToolStripButtonDetalle.Visible = False
        ToolStripButtonAbonar.Visible = False
    End Sub
#End Region

#Region "  Evento: Proveedor - TEXT CHANGED  "
    Private Sub Proveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Proveedor.TextChanged
        consulta129()
    End Sub
#End Region

#Region "  Evento: EstadosComboBox - SELECTED VALUE CHANGED  "
    Private Sub EstadosComboBox_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadosComboBox.SelectedValueChanged
        Dim objRet2 As CRetorno

        Caja = "Consulta114b" : Parametros = "V1=" & EstadosComboBox.Text & "|"
        objRet2 = lConsulta.LlamarCaja(Caja, 2, Parametros)

        CiudadesComboBox.DataSource = objRet2.DS.Tables(0)
        CiudadesComboBox.DisplayMember = objRet2.DS.Tables(0).Columns(0).Caption.ToString
    End Sub
#End Region

#Region "  Evento: GridDatosPROVEEDORES - DOUBLE CLICK  "
    Private Sub GridDatosPROVEEDORES_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridDatosPROVEEDORES.DoubleClick
        Dim nombreProveedor As String
        nombreProveedor = dsDatosProveedores.Tables(0).Rows(posRowProveedores).Item(1).ToString
        Proveedor.Text = nombreProveedor

        showData()

        consulta106()

        consulta130()

        ProveedoresTabControl.SelectedIndex = 0
    End Sub
#End Region

#Region "  Rutinas: cambio de textBox con Enter  "
    Private Sub TxtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtCodigo.Focus()
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtRfc.Focus()
        End If
    End Sub

    Private Sub txtRfc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRfc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            EstadosComboBox.Focus()
        End If
    End Sub

    Private Sub EstadosComboBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EstadosComboBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            CiudadesComboBox.Focus()
        End If
    End Sub

    Private Sub CiudadesComboBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CiudadesComboBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TxtDireccion.Focus()
        End If
    End Sub

    Private Sub TxtDireccion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDireccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TxtColonia.Focus()
        End If
    End Sub

    Private Sub TxtColonia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtColonia.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Txtcp.Focus()
        End If
    End Sub

    Private Sub Txtcp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtcp.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TxtMail.Focus()
        End If
    End Sub

    Private Sub TxtMail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMail.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TxtTel.Focus()
        End If
    End Sub

    Private Sub TxtTel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTel.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtext.Focus()
        End If
    End Sub

    Private Sub txtext_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtext.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TxtTel2.Focus()
        End If
    End Sub

    Private Sub TxtTel2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTel2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtext2.Focus()
        End If
    End Sub

    Private Sub txtext2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtext2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TxtCel.Focus()
        End If
    End Sub

    Private Sub TxtCel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCel.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TxtCel2.Focus()
        End If
    End Sub

    Private Sub TxtCel2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCel2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TxtFax.Focus()
        End If
    End Sub

    Private Sub TxtFax_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFax.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Grabar.Select()
        End If
    End Sub
#End Region

#Region "  Evento: adedudosTabPage - ENTER/LEAVE  "
    Private Sub AdeudosTabPage_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdeudosTabPage.Enter
        mostrarControles()
    End Sub

    Private Sub AdeudosTabPage_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdeudosTabPage.Leave
        ocultarControlesCuentas()
    End Sub
#End Region

#Region "  Botón BUSCAR  "
    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        ocultarControlesCuentas()
        Proveedor.Enabled = True

        showProvGrid()
        Proveedor.Clear()
        Proveedor.Focus()
        Limpiar.Visible = False
        Grabar.Visible = False
        ToolStripButtonNuevo.Visible = True

        ToolStripStatusLabelProveedores.Text = "Escriba el nombre o número de identificación de un proveedor para filtrar los resultados."

        consulta129()

    End Sub
#End Region

End Class