Imports MindTec.Componentes

Public Class Cat_Clientes

#Region " Variables de trabajo "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    ' Grid datos para ABONOS
    Dim montoDef As Decimal

    ' Grid datos para CUENTAS
    Dim dsDatosCuentas As DataSet
    Dim dtCuentas As DataTable
    Dim viewDatosCuentas As Object
    Dim DsViewCuentas As Object

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
        'Se crea la ventana para abonos.

        ' Ocultar algunos elementos.
        ClientesTabControl.Visible = False
        ' Pie de Pagina Mensaje
        MensajePiePagina.Text = "Esc=Salir Enter=Avanzar F2=Catálogo F4=Limpiar Pantalla"
        ' Deshabilitar
        Me.Grabar.Visible = False
        ' Se cargan el comboBox de Estados
        Caja = "Consulta114a" : Parametros = ""
        ObjRet = lConsulta.LlamarCaja(Caja, 2, Parametros)
        EstadosComboBox.DataSource = ObjRet.DS.Tables(0)
        EstadosComboBox.DisplayMember = ObjRet.DS.Tables(0).Columns(0).Caption.ToString
        EstadosComboBox.Text = "Aguascalientes"

        Caja = "Consulta114b" : Parametros = "V1=" & EstadosComboBox.Text & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, 2, Parametros)

        CiudadesComboBox.DataSource = ObjRet.DS.Tables(0)
        CiudadesComboBox.DisplayMember = ObjRet.DS.Tables(0).Columns(0).Caption.ToString

        CreardsDatosCuentas()
        ConfiguraGridDatosCuentas()

    End Sub

    Private Sub AbonarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim objAbonos As New Cat_Clientes_Abonos()
        'objAbonos.StartPosition = FormStartPosition.CenterScreen
        'objAbonos.ShowDialog()
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

            If lConsulta.ObtenerValor("V16", ObjRet.sResultado, "|") = "" Then
                Me.txtLimCred.Value = 0
                lblLimiteCredito.Text = "$ 0.00"
            Else
                Me.txtLimCred.Value = lConsulta.ObtenerValor("V16", ObjRet.sResultado, "|")
                lblLimiteCredito.Text = "$ " & lConsulta.ObtenerValor("V16", ObjRet.sResultado, "|")
            End If


            ' MODIFICAR 
            If lConsulta.ObtenerValor("V17", ObjRet.sResultado, "|") = "" Then
                lblSaldoActual.Text = "$ 0.00"
            Else
                lblSaldoActual.Text = "$ " & lConsulta.ObtenerValor("V17", ObjRet.sResultado, "|")
            End If

            ' -------------------------------------------
            '| Obtienen los datos de su estado de cuenta.
            ' -------------------------------------------
            
            Caja = "Consulta117" : Parametros = "V1=" & Me.CodigoCliente.Text.Trim & "|"
            ObjRet = lConsulta.LlamarCaja(Caja, 1, Parametros)

            ' Se inserta la consulta en el Grid Cuentas.
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

            'Habilitar
            Me.Grabar.Visible = True
            Me.GroupBoxClientes.Visible = True
            Me.GroupBoxLocalizacion.Visible = True
            MensajePiePagina.Text = "Esc=Salir Enter=Avanzar F2=Catálogo F4=Limpiar Pantalla F9=Grabar"
            'Foco
            ClientesTabControl.Visible = True
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
        Me.TxtColonia.Text = ""
        Me.TxtDireccion.Text = ""
        Me.Txtcp.Text = ""
        Me.TxtMail.Text = ""
        Me.TxtTel.Text = ""
        Me.TxtTel2.Text = ""
        Me.txtext.Text = ""
        Me.txtext2.Text = ""
        Me.TxtFax.Text = ""

        lblSaldoActual.Text = "$ 0.00"
        lblLimiteCredito.Text = "$ 0.00"

        ClientesTabControl.SelectTab(0)

        'Limpia el DSdatosCuentas
        dsDatosCuentas.Tables(0).Clear()
        ClientesTabControl.Visible = False

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

    Private Sub EstadosComboBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadosComboBox.TextChanged
        Dim objRet2 As CRetorno

        Caja = "Consulta114b" : Parametros = "V1=" & EstadosComboBox.Text & "|"
        objRet2 = lConsulta.LlamarCaja(Caja, 2, Parametros)

        CiudadesComboBox.DataSource = objRet2.DS.Tables(0)
        CiudadesComboBox.DisplayMember = objRet2.DS.Tables(0).Columns(0).Caption.ToString
    End Sub

    Private Sub TxtEstado_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub ClientesTabControl_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles ClientesTabControl.Selected
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
                                              "|V7=" & Me.EstadosComboBox.Text.Trim & _
                                              "|V8=" & Me.CiudadesComboBox.Text.Trim & _
                                              "|V9=" & Me.TxtTel.Text.Trim & _
                                              "|V10=" & Me.txtext.Text.Trim & _
                                              "|V11=" & Me.TxtTel2.Text.Trim & _
                                              "|V12=" & Me.txtext2.Text.Trim & _
                                              "|V13=" & Me.TxtCel.Text.Trim & _
                                              "|V14=" & Me.TxtCel2.Text.Trim & _
                                              "|V15=" & Me.TxtFax.Text.Trim & _
                                              "|V16=" & Me.TxtMail.Text.Trim & _
                                              "|V17=" & Me.txtLimCred.Value & "|"

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

#Region " Limpiar "
    Private Sub Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        LimpiarPantalla()
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
        backheader.BackColor = cColorHeader
        backheader.Border = DevAge.Drawing.RectangleBorder.RectangleBlack1Width
        viewcolumnheader.Background = backheader
        viewcolumnheader.ForeColor = Color.Black
        viewcolumnheader.Font = New Font("Verdana", 8, FontStyle.Bold)
        viewcolumnheader.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter

        'COLUMNAS
        GridDatosCuentas.GetCell(0, 1).View = viewcolumnheader
        GridDatosCuentas.GetCell(0, 2).View = viewcolumnheader
        GridDatosCuentas.GetCell(0, 3).View = viewcolumnheader
        GridDatosCuentas.GetCell(0, 4).View = viewcolumnheader
        GridDatosCuentas.GetCell(0, 5).View = viewcolumnheader
        GridDatosCuentas.GetCell(0, 6).View = viewcolumnheader
        GridDatosCuentas.GetCell(0, 7).View = viewcolumnheader
        GridDatosCuentas.GetCell(0, 8).View = viewcolumnheader

    End Sub

    Private Sub GridDatosCrearColumnasCUENTAS(ByVal columns As SourceGrid.DataGridColumns, ByVal Bindlist As DevAge.ComponentModel.IBoundList)
        'Borders

        Dim border As DevAge.Drawing.RectangleBorder = New DevAge.Drawing.RectangleBorder(New DevAge.Drawing.BorderLine(Color.Black), New DevAge.Drawing.BorderLine(Color.Black))
        'gcolorRow esta declarada en el moduloGeneral

        'vistas
        Dim viewNormal As CellBackColorAlternate = New CellBackColorAlternate(gColorRow, Color.White)
        viewNormal.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewNormal.Border = border

        Dim myfont As New Font("Verdana", 8, FontStyle.Regular)

        Dim viewBtn As SourceGrid.Cells.Views.Button = New SourceGrid.Cells.Views.Button()
        viewBtn.BackColor = gColorRow
        viewBtn.Border = border
        viewBtn.Font = myfont
        viewBtn.ForeColor = Color.Black
        viewBtn.TextAlignment = DevAge.Drawing.ContentAlignment.BottomCenter

        'EVENTOS

        Dim gridKeydown As SourceGrid.Cells.Controllers.CustomEvents = New SourceGrid.Cells.Controllers.CustomEvents
        AddHandler gridKeydown.KeyDown, New KeyEventHandler(AddressOf Grid_KeyDown)

        Dim clickEventAbonar As SourceGrid.Cells.Controllers.CustomEvents = New SourceGrid.Cells.Controllers.CustomEvents()
        AddHandler clickEventAbonar.Click, New EventHandler(AddressOf ABONAR)

        Dim clickEventDetalle As SourceGrid.Cells.Controllers.CustomEvents = New SourceGrid.Cells.Controllers.CustomEvents()
        AddHandler clickEventDetalle.Click, New EventHandler(AddressOf DETALLE)

        Dim clickEventAbonos As SourceGrid.Cells.Controllers.CustomEvents = New SourceGrid.Cells.Controllers.CustomEvents()
        AddHandler clickEventAbonos.Click, New EventHandler(AddressOf ABONOS)


        'Definicion de la celda
        Dim EditorCustom As SourceGrid.Cells.Editors.TextBox = New SourceGrid.Cells.Editors.TextBox(GetType(String))
        EditorCustom.EditableMode = SourceGrid.EditableMode.None

        'Crear columnas
        Dim GridColumn As SourceGrid.DataGridColumn

        GridColumn = GridDatosCuentas.Columns.Add("C1", "Cuenta", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosCuentas.Columns.Add("C2", "Artículo(s)", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosCuentas.Columns.Add("C3", "Monto", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosCuentas.Columns.Add("C4", "Adeudo", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosCuentas.Columns.Add("C5", "Abonado", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridDatosCuentas.Columns(0).Visible = False

        'COLUMNAS
        'AGREGAR Abonar
        GridColumn = GridDatosCuentas.Columns.Add(Nothing, "Abonar", New SourceGrid.Cells.Button("  "))
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.AddController(clickEventAbonar)
        GridColumn.DataCell.View = viewBtn
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        'AGREGAR Detalle
        GridColumn = GridDatosCuentas.Columns.Add(Nothing, "Detalle", New SourceGrid.Cells.Button("  "))
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.AddController(clickEventDetalle)
        GridColumn.DataCell.View = viewBtn
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        'AGREGAR Abonos
        GridColumn = GridDatosCuentas.Columns.Add(Nothing, "Abonos", New SourceGrid.Cells.Button("  "))
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.AddController(clickEventAbonos)
        GridColumn.DataCell.View = viewBtn
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridDatosCuentas.Columns.SetWidth(1, 70)
        GridDatosCuentas.Columns.SetWidth(2, 151)
        GridDatosCuentas.Columns.SetWidth(3, 128)
        GridDatosCuentas.Columns.SetWidth(4, 128)
        GridDatosCuentas.Columns.SetWidth(5, 128)
        GridDatosCuentas.Columns.SetWidth(6, 60)
        GridDatosCuentas.Columns.SetWidth(7, 60)
        GridDatosCuentas.Columns.SetWidth(8, 60)

    End Sub

    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
#End Region

#Region "  Botón ABONAR  "
    Private Sub ABONAR()
        Dim pos As Integer = GridDatosCuentas.Selection.ActivePosition.Row - 1

        Dim idCuenta As String = dsDatosCuentas.Tables(0).Rows(pos).Item(0).ToString
        Dim idUsuario As String = "1"
        Dim codigo As String = Me.CodigoCliente.Text.Trim

        Dim objRegistroAbono As New Cat_Clientes_RegistroAbono()
        objRegistroAbono.StartPosition = FormStartPosition.CenterScreen
        objRegistroAbono.pasoVariables(pos, _
                                       idCuenta, _
                                       idUsuario, _
                                       codigo, _
                                       dsDatosCuentas, _
                                       DsViewCuentas, _
                                       lblSaldoActual)
        objRegistroAbono.Show()

    End Sub
#End Region

#Region "  Botón DETALLE  "
    Private Sub DETALLE()
        Dim pos As Integer = GridDatosCuentas.Selection.ActivePosition.Row - 1
        Dim idCuenta As Integer = dsDatosCuentas.Tables(0).Rows(pos).Item(0)

        Dim objDetalle As New Cat_Clientes_DetalleVenta
        objDetalle.cargaIdCuenta(idCuenta)
        objDetalle.StartPosition = FormStartPosition.CenterScreen
        objDetalle.Show()

    End Sub
#End Region

#Region "  Botón ABONOS  "
    Private Sub ABONOS()
        Dim pos As Integer = GridDatosCuentas.Selection.ActivePosition.Row - 1
        Dim idCuenta As Integer = dsDatosCuentas.Tables(0).Rows(pos).Item(0)

        Dim objAbonos As New Cat_Cliente_DetalleAbono
        objAbonos.cargaIdCuenta(idCuenta)
        objAbonos.StartPosition = FormStartPosition.CenterScreen
        objAbonos.Show()

    End Sub
#End Region

End Class