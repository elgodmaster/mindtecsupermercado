Imports MindTec.Componentes

Public Class Cat_Productos

#Region " Variables de trabajo "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
#End Region

#Region " Eventos Principales"
    Private Sub Cat_Productos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
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
        MensajePiePagina.Text = "Esc=Salir F2=Catálogo F4=Limpiar Pantalla"
        'Deshabilitar
        Me.Grabar.Visible = False
    End Sub
#End Region

#Region " Limpiar "
    Private Sub Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        LimpiarPantalla()
    End Sub
#End Region

#Region " Unidad "
    Private Sub CodigoUnidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoUnidad.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatalogoUnidad()
            Case Keys.Enter, Keys.Down
                'Servicios
                Caja = "Consulta104" : Parametros = "V1=" & Me.CodigoUnidad.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                'Estatus
                If ObjRet.bOk Then
                    'Asignar
                    Me.NombreUnidad.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
                    SendKeys.Send("{TAB}")
                Else
                    'Asignar
                    Me.CodigoUnidad.Text = ""
                    Me.NombreUnidad.Text = ""
                    'mensaje
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                    'poner focus
                    Me.CodigoUnidad.Focus()
                End If
                'Destruir
                ObjRet = Nothing
            Case Keys.Up
                SendKeys.Send("+{TAB}")
        End Select
    End Sub

#End Region

    '#Region " Tipo Cambio "
    '    Private Sub CodigoTcambio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '        Select Case e.KeyCode
    '            Case Keys.F2
    '                CatalogoTipoCambio()
    '            Case Keys.Enter, Keys.Down
    '                'Servicios
    '                Caja = "Consulta120" : Parametros = "V1=" & Me.CodigoTCambio.Text & "|"
    '                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
    '                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
    '                'Estatus
    '                If ObjRet.bOk Then
    '                    'Asignar
    '                    Me.TxtTCambio.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
    '                    SendKeys.Send("{TAB}")
    '                Else
    '                    'Asignar
    '                    Me.CodigoTCambio.Text = ""
    '                    Me.TxtTCambio.Text = ""
    '                    'mensaje
    '                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
    '                    'poner focus
    '                    Me.CodigoTCambio.Focus()
    '                End If
    '                'Destruir
    '                ObjRet = Nothing
    '            Case Keys.Up
    '                SendKeys.Send("+{TAB}")
    '        End Select
    '    End Sub
    '#End Region

#Region " Rutinas "

    Sub LimpiarPantalla()
        'Habilidar
        Me.btnAceptar.Enabled = True
        Me.TxtDepto.Enabled = True
        Me.CodigoMarca.Enabled = True
        Me.CodigoCategoria.Enabled = True
        Me.CodigoProducto.Enabled = True
        'Deshabilitar
        Me.Eliminar.Visible = False
        Me.GroupBoxDescripcion.Visible = False
        Me.GroupBoxdVenta.Visible = False
        Me.Grabar.Visible = False
        'Asignar
        Me.TxtDepto.Text = ""
        Me.Lbl_Depto.Text = ""
        Me.CodigoMarca.Text = ""
        Me.CodigoCategoria.Text = ""
        Me.CodigoProducto.Text = ""
        Me.NombreMarca.Text = ""
        Me.NombreCategoria.Text = ""
        Me.NombreProducto.Text = ""
        Me.TxtNombre.Text = ""
        Me.CodigoUnidad.Text = ""
        Me.NombreUnidad.Text = ""
        Me.TxtStock.Text = ""
        Me.Txt_InvIni.Text = ""
        'Me.CodigoTCambio.Text = ""
        'Me.TxtTCambio.Text = ""
        Me.TxtCostoCompra.Text = ""
        Me.TxtFlete.Text = ""
        Me.TxtMargen.Text = ""
        Me.TxtCostoVenta.Text = ""
        'PiePagina
        MensajePiePagina.Text = "Esc=Salir Enter=Avanzar F2=Catalogo F4=Limpiar Pantalla"
        'Foco
        Me.TxtDepto.Focus()
    End Sub

    Sub CatalogoProducto()
        Caja = "Consulta103" : Parametros = "V1=" & Me.TxtDepto.Text.Trim & "|V2=" & Me.CodigoCategoria.Text.Trim & "|V3=" & Me.CodigoMarca.Text.Trim & "|"
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            Me.CodigoProducto.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.CodigoProducto_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If
    End Sub
    Sub CatalogoUnidad()
        Caja = "Consulta104" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            Me.CodigoUnidad.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.CodigoUnidad_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If
    End Sub

    'Sub CatalogoTipoCambio()
    '    Caja = "Consulta120" : Parametros = ""
    '    If lConsulta Is Nothing Then lConsulta = New ClsConsultas
    '    ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
    '    If ObjRet.bOk Then
    '        Dim nuevo As Grid = New Grid(ObjRet.DS)

    '        Me.CodigoTCambio.Text = nuevo.resultado
    '        Dim e As KeyEventArgs
    '        e = New KeyEventArgs(Keys.Enter)
    '        Me.CodigoTcambio_KeyDown(DBNull.Value, e)
    '    Else
    '        MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
    '    End If
    'End Sub

    Sub CatalogoMarcas()
        Caja = "Consulta102" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            Me.CodigoMarca.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.CodigoMarca_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If
    End Sub

    Sub CatalogoCategorias()
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
    Sub CatalogoDepartamentos()
        Caja = "Consulta100" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            Me.TxtDepto.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.TxtDepto_KeyDown(DBNull.Value, e)
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
#End Region

#Region " Aceptar "
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Caja = "Consulta103" : Parametros = "V1=" & Me.TxtDepto.Text & "|V2=" & Me.CodigoCategoria.Text & "|V3=" & Me.CodigoMarca.Text & "|V4=" & Me.CodigoProducto.Text.Trim & "|"
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)
        If ObjRet.bOk Then
            'Deshabilitar
            Me.CodigoMarca.Enabled = False
            Me.CodigoCategoria.Enabled = False
            Me.CodigoProducto.Enabled = False
            Me.btnAceptar.Enabled = False

            'Asignar
            Me.TxtNombre.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
            Me.CodigoUnidad.Text = lConsulta.ObtenerValor("V2", ObjRet.sResultado, "|")
            Me.NombreUnidad.Text = lConsulta.ObtenerValor("V3", ObjRet.sResultado, "|")
            Me.TxtStock.Text = lConsulta.ObtenerValor("V4", ObjRet.sResultado, "|")
            Me.TxtCostoCompra.Text = lConsulta.ObtenerValor("V5", ObjRet.sResultado, "|")
            Me.TxtFlete.Text = lConsulta.ObtenerValor("V6", ObjRet.sResultado, "|")
            Me.TxtMargen.Text = lConsulta.ObtenerValor("V7", ObjRet.sResultado, "|")
            Me.TxtCostoVenta.Text = lConsulta.ObtenerValor("V8", ObjRet.sResultado, "|")
            Me.TxtPrecio.Text = lConsulta.ObtenerValor("V8", ObjRet.sResultado, "|")
            Me.Txt_InvIni.Text = lConsulta.ObtenerValor("V15", ObjRet.sResultado, "|", False)
            If Len(TxtNombre.Text) > 0 Then
                Me.TxtDepto.Text = lConsulta.ObtenerValor("V9", ObjRet.sResultado, "|", False)
                Me.Lbl_Depto.Text = lConsulta.ObtenerValor("V10", ObjRet.sResultado, "|", False)
                Me.CodigoMarca.Text = lConsulta.ObtenerValor("V11", ObjRet.sResultado, "|", False)
                Me.NombreMarca.Text = lConsulta.ObtenerValor("V12", ObjRet.sResultado, "|", False)
                Me.CodigoCategoria.Text = lConsulta.ObtenerValor("V13", ObjRet.sResultado, "|", False)
                Me.NombreCategoria.Text = lConsulta.ObtenerValor("V14", ObjRet.sResultado, "|", False)
            End If
            
            'Habilitar
            Me.Grabar.Visible = True
            Me.Eliminar.Visible = True
            Me.GroupBoxDescripcion.Visible = True
            Me.GroupBoxdVenta.Visible = True
            MensajePiePagina.Text = "Esc=Salir Enter=Avanzar F2=Catálogo F4=Limpiar Pantalla F9=Grabar"
            'Foco
            Me.TxtNombre.Focus()
        Else
            'Asignar
            Me.TxtDepto.Text = ""
            Me.Lbl_Depto.Text = ""
            Me.CodigoMarca.Text = ""
            Me.NombreMarca.Text = ""
            Me.CodigoCategoria.Text = ""
            Me.NombreCategoria.Text = ""
            Me.CodigoProducto.Text = ""
            Me.NombreProducto.Text = ""

            'Mensaje
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
            'Foco
            Me.TxtDepto.Focus()
        End If
        ObjRet = Nothing

    End Sub
#End Region

#Region " Producto "
    Private Sub CodigoProducto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoProducto.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatalogoProducto()
            Case Keys.Enter, Keys.Down
                'Servicios
                Caja = "Consulta103" : Parametros = "V1=" & Me.TxtDepto.Text & "|V2=" & Me.CodigoCategoria.Text & "|V3=" & Me.CodigoMarca.Text & "|V4=" & Me.CodigoProducto.Text.Trim & "|"
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                'Estatus
                If ObjRet.bOk Then
                    'Asignar
                    Me.NombreProducto.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
                    'Me.TxtDepto.Text = lConsulta.ObtenerValor("V2", ObjRet.sResultado, "|")
                    'Me.Lbl_Depto.Text = lConsulta.ObtenerValor("V3", ObjRet.sResultado, "|")
                    'Me.CodigoCategoria.Text = lConsulta.ObtenerValor("V4", ObjRet.sResultado, "|")
                    'Me.NombreCategoria.Text = lConsulta.ObtenerValor("V5", ObjRet.sResultado, "|")
                    'Me.CodigoMarca.Text = lConsulta.ObtenerValor("V6", ObjRet.sResultado, "|")
                    'Me.NombreMarca.Text = lConsulta.ObtenerValor("V7", ObjRet.sResultado, "|")
                    btnAceptar.PerformClick()
                    'SendKeys.Send("{TAB}")
                Else
                    'Asignar
                    Me.NombreProducto.Text = ""
                    Me.CodigoProducto.Text = ""
                    'mensaje
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                    'poner focus
                    Me.CodigoProducto.Focus()
                End If
                'Destruir
                ObjRet = Nothing
            Case Keys.Up
                SendKeys.Send("+{TAB}")
        End Select
    End Sub
#End Region

#Region " Marca "
    Private Sub CodigoMarca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoMarca.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatalogoMarcas()
            Case Keys.Enter, Keys.Down
                'Servicios
                Caja = "Consulta102" : Parametros = "V1=" & Me.CodigoMarca.Text.Trim & "|"
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                'Estatus
                If ObjRet.bOk Then
                    'Asignar
                    Me.NombreMarca.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
                    SendKeys.Send("{TAB}")
                Else
                    'Asignar
                    Me.NombreMarca.Text = ""
                    Me.CodigoMarca.Text = ""
                    'mensaje
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                    'poner focus
                    Me.CodigoMarca.Focus()
                End If
                'Destruir
                ObjRet = Nothing
            Case Keys.Up
                SendKeys.Send("+{TAB}")
        End Select
    End Sub
#End Region

#Region " Categorias "
    Private Sub CodigoCategoria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoCategoria.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatalogoCategorias()
            Case Keys.Enter, Keys.Down
                'Servicios
                Caja = "Consulta101" : Parametros = "V1=" & Me.CodigoCategoria.Text.Trim & "|"
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
                    Me.CodigoCategoria.Text = ""
                    'mensaje
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

#Region " Grabar "
    Private Sub Grabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grabar.Click
        'Variable de trabajo
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Deseas Guardar los Cambios?", "SuperMercado Beltrán", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            Caja = "Grabar103" : Parametros = "V1=" & Me.CodigoProducto.Text.Trim & _
                                              "|V2=" & Me.TxtDepto.Text.Trim & _
                                              "|V3=" & Me.CodigoCategoria.Text.Trim & _
                                              "|V4=" & Me.CodigoMarca.Text.Trim & _
                                              "|V5=" & Me.TxtNombre.Text.Trim & _
                                              "|V6=" & Me.TxtCostoCompra.Text.Trim & _
                                              "|V7=" & Me.TxtFlete.Text.Trim & _
                                              "|V8=" & Me.TxtMargen.Text.Trim & _
                                              "|V9=" & Me.CodigoUnidad.Text.Trim & _
                                              "|V10=" & Me.TxtStock.Text.Trim & _
                                              "|V11=" & Me.TxtPrecio.Text & _
                                              "|V12=" & Me.Txt_InvIni.Text & "|"
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

#Region "PrecioVenta"

#End Region

#Region " Margen "
    Private Sub TxtMargen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMargen.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter

                If Len(LTrim(RTrim(Me.TxtCostoCompra.Text))) <> 0 And Len(LTrim(RTrim(Me.TxtFlete.Text))) <> 0 And Len(LTrim(RTrim(Me.TxtMargen.Text))) <> 0 Then
                    Dim CostoVenta As Double = 0
                    Dim CostoCompra As Double = 0
                    Dim Flete As Double = 0
                    Dim Margen As Double = 0
                    Dim i As Integer = 0

                    CostoCompra = Double.Parse(Me.TxtCostoCompra.Text)
                    Flete = 0 + Double.Parse(Me.TxtFlete.Text)
                    Margen = 0 + Double.Parse(Me.TxtMargen.Text)
                    Flete = (Flete / 100) + 1
                    Margen = 1 - (Margen / 100)
                    CostoVenta = (CostoCompra * Flete) / Margen
                    Me.TxtCostoVenta.Text = CostoVenta
                Else
                    Me.TxtCostoVenta.Text = 0

                End If
        End Select
    End Sub
#End Region

#Region " Eliminar "
    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Deseas eliminar el producto?", "PVFacturacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            Caja = "Eliminar103" : Parametros = "V1=" & Me.CodigoProducto.Text.Trim & "|"
            '"V2=" & Me.TxtDepto.Text.Trim & _
            '"|V3=" & Me.CodigoCategoria.Text.Trim & _
            '"|V4=" & Me.CodigoMarca.Text.Trim & "|"
            If lConsulta Is Nothing Then lConsulta = New ClsConsultas
            ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
            If ObjRet.bOk Then
                MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                LimpiarPantalla()
            Else
                MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                LimpiarPantalla()
            End If
        End If

    End Sub
#End Region

#Region " Departamento "
    Private Sub TxtDepto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDepto.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatalogoDepartamentos()
            Case Keys.Enter, Keys.Down
                'Servicios
                Caja = "Consulta100" : Parametros = "V1=" & Me.TxtDepto.Text.Trim & "|"
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                'Estatus
                If ObjRet.bOk Then
                    'Asignar
                    Me.Lbl_Depto.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
                    SendKeys.Send("{TAB}")
                Else
                    'Asignar
                    Me.TxtDepto.Text = ""
                    Me.Lbl_Depto.Text = ""
                    'mensaje
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                    'poner focus
                    Me.TxtDepto.Focus()
                End If
                'Destruir
                ObjRet = Nothing
            Case Keys.Up
                SendKeys.Send("+{TAB}")
        End Select
    End Sub
#End Region
    
End Class