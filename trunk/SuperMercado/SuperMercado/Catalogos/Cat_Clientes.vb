Imports MindTec.Componentes

Public Class Cat_Clientes

#Region " Variables de trabajo "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    ' Grid datos para ABONOS
    Dim dsDatosAbonos As DataSet
    Dim dtEntradas As DataTable
    Dim viewDatosAbonos As Object
    Dim DsViewEntradas As Object
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
        AbonarToolStripButton.Visible = False
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

        'Se crea el grid 
        CrearDsDatosABONOS()
        ConfiguraGridDatosABONOS()
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
            'Me.TxtCiudad.Text = lConsulta.ObtenerValor("V8", ObjRet.sResultado, "|")
            'Me.NombreCiudad.Text = lConsulta.ObtenerValor("V9", ObjRet.sResultado, "|")
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
            Else
                Me.txtLimCred.Value = lConsulta.ObtenerValor("V16", ObjRet.sResultado, "|")
            End If

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
        ClientesTabControl.Visible = True
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

        'Limpia el DSdatosAbonos
        dsDatosAbonos = Nothing
        AbonarToolStripButton.Visible = False
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
        AbonarToolStripButton.Visible = True
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

#Region "Grid Datos ENTRADAS"

    Sub CrearDsDatosABONOS()
        dsDatosAbonos = New DataSet("Root")
        dtEntradas = New DataTable("Table")
        dsDatosAbonos.Tables.Add(dtEntradas)

        'DsDatos.Tables("Table").Columns.Add("C0", GetType(String))
        'COLUMNAS
        dsDatosAbonos.Tables("Table").Columns.Add("C1", GetType(String))
        dsDatosAbonos.Tables("Table").Columns.Add("C2", GetType(String))

    End Sub

    Sub ConfiguraGridDatosABONOS()
        viewDatosAbonos = dsDatosAbonos.Tables("Table").DefaultView

        viewDatosAbonos.AllowEdit = False
        viewDatosAbonos.AllowNew = False
        viewDatosAbonos.AllowDelete = True

        AbonosGridDatos.FixedRows = 1
        AbonosGridDatos.FixedColumns = 1
        AbonosGridDatos.DeleteRowsWithDeleteKey = False
        AbonosGridDatos.DeleteQuestionMessage = Nothing

        ' Renglon encabezado

        AbonosGridDatos.Columns.Insert(0, SourceGrid.DataGridColumn.CreateRowHeader(AbonosGridDatos))

        Dim BindList2 As DevAge.ComponentModel.IBoundList = New DevAge.ComponentModel.BoundDataView(viewDatosAbonos)

        ' Se crean las columnas.
        GridDatosCrearColumnasABONOS(AbonosGridDatos.Columns, BindList2)

        AbonosGridDatos.DataSource = BindList2

        Dim cColorHeader As Color
        cColorHeader = Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(5, Byte), Integer))

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
        AbonosGridDatos.GetCell(0, 1).View = viewcolumnheader
        AbonosGridDatos.GetCell(0, 2).View = viewcolumnheader

    End Sub

    Private Sub GridDatosCrearColumnasABONOS(ByVal columns As SourceGrid.DataGridColumns, ByVal Bindlist As DevAge.ComponentModel.IBoundList)
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

        'Eventos

        Dim gridKeydown As SourceGrid.Cells.Controllers.CustomEvents = New SourceGrid.Cells.Controllers.CustomEvents
        AddHandler gridKeydown.KeyDown, New KeyEventHandler(AddressOf Grid_KeyDown)

        'Definicion de la celda
        Dim EditorCustom As SourceGrid.Cells.Editors.TextBox = New SourceGrid.Cells.Editors.TextBox(GetType(String))
        EditorCustom.EditableMode = SourceGrid.EditableMode.None

        'Crear columnas
        Dim GridColumn As SourceGrid.DataGridColumn

        'COLUMNAS
        GridColumn = AbonosGridDatos.Columns.Add("C1", "Monto", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = AbonosGridDatos.Columns.Add("C2", "Fecha", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        AbonosGridDatos.Columns(0).Visible = False
        AbonosGridDatos.Columns.SetWidth(1, 100)
        AbonosGridDatos.Columns.SetWidth(2, 160)

    End Sub

    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

#End Region

   
End Class