Imports MindTec.Componentes

Public Class Cat_Productos

#Region "  Variables de trabajo  "

    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno

    Dim copiaCodigo As String

#End Region

#Region "  Evento: Cat_Productos - LOAD  "
    Private Sub Cat_Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ocultarGroupBox()
        keyCodigo.Focus()

        loadComboBox(True, 0)

    End Sub
#End Region

#Region "  Botón NUEVO  "
    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        Nuevo.Visible = False

        limpiarPantalla()
        mostrarGroupBox()
        mostrarBotonesEditar()

        copiaCodigo = ""

        Label13.Visible = True
        existencia.Visible = True

        descripcion.Focus()

    End Sub
#End Region

#Region "  Botón BUSCAR  "
    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        catalogo()

        Nuevo.Visible = True
    End Sub
#End Region

#Region "  Botón LIMPIAR  "
    Private Sub Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        limpiarPantalla()
    End Sub
#End Region

#Region "  Botón GRABAR  "
    Private Sub Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grabar.Click
        If descripcion.Text.Trim = "" Then
            MessageBox.Show("No ha escrito la descripción del producto.", " Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            descripcion.SelectAll()
            descripcion.Focus()
            Return
        End If

        If codigo.Text.Trim = "" Then
            MessageBox.Show("No ha escrito el código del producto.", " Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            codigo.SelectAll()
            codigo.Focus()
            Return
        End If

        Dim resul As DialogResult
        resul = MessageBox.Show("¿Desea guardar los cambios realizados?", " SMercado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resul = Windows.Forms.DialogResult.Yes Then
            grabar129()

            If lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") <> "OK" Then
                MessageBox.Show("El código especificado se encuentra en uso.", " Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                codigo.SelectAll()
                codigo.Focus()
                Return
            End If

            ocultarBotonesEditar()
            ocultarGroupBox()

            keyCodigo.Clear()
            keyCodigo.Focus()

        End If

        Label13.Visible = True
        existencia.Visible = True
        Nuevo.Visible = True

    End Sub
#End Region

#Region "  Rutina: calcularPrecioVenta  "
    Sub calcularPrecioVenta()
        precioVenta.Value = ((ganancia.Value) / 100 + 1) * costoCompra.Value
    End Sub
#End Region

#Region "  Rutina: limpiarPantalla  "
    Sub limpiarPantalla()
        descripcion.Clear()
        codigo.Clear()
        unidad.Text = "-SIN UNIDAD-"
        categoria.Text = "-SIN CATEGORÍA-"
        marca.Text = "-SIN MARCA-"
        departamento.Text = "-SIN DEPARTAMENTO-"

        costoCompra.Value = 0
        precioVenta.Value = 0
        ganancia.Value = 0

        stockMinimo.Value = 0
        existencia.Value = 0

    End Sub
#End Region

#Region "  Rutina: ocultarGroupBox  "
    Sub ocultarGroupBox()
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
    End Sub
#End Region

#Region "  Rutina: mostrarGroupBox  "
    Sub mostrarGroupBox()
        GroupBox1.Visible = True
        GroupBox2.Visible = True
        GroupBox3.Visible = True
    End Sub
#End Region

#Region "  Rutina: mostrarBotonesEditar  "
    Sub mostrarBotonesEditar()
        Grabar.Visible = True
        Limpiar.Visible = True
    End Sub
#End Region

#Region "  Rutina: ocultarBotonesEditar  "
    Sub ocultarBotonesEditar()
        Grabar.Visible = False
        Limpiar.Visible = False
    End Sub
#End Region

#Region "  Rutina: catalogo  "
    Sub catalogo()
        Caja = "Consulta135" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            If nuevo.resultado = "" Then
                Return
            End If

            keyCodigo.Text = nuevo.resultado

            consulta136()
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If
    End Sub
#End Region

#Region "  Rutina: consulta136  "
    Sub consulta136()
        'Muestra los datos de un producto.


        existencia.Visible = False
        Label13.Visible = False

        Caja = "Consulta136" : Parametros = "V1=" & keyCodigo.Text.Trim
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        If ObjRet.bOk Then
            descripcion.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
            codigo.Text = lConsulta.ObtenerValor("V2", ObjRet.sResultado, "|")
            unidad.Text = lConsulta.ObtenerValor("V3", ObjRet.sResultado, "|")
            categoria.Text = lConsulta.ObtenerValor("V4", ObjRet.sResultado, "|")
            marca.Text = lConsulta.ObtenerValor("V5", ObjRet.sResultado, "|")
            departamento.Text = lConsulta.ObtenerValor("V6", ObjRet.sResultado, "|")

            costoCompra.Value = lConsulta.ObtenerValor("V7", ObjRet.sResultado, "|")
            precioVenta.Value = lConsulta.ObtenerValor("V8", ObjRet.sResultado, "|")
            ganancia.Value = 0

            stockMinimo.Value = lConsulta.ObtenerValor("V9", ObjRet.sResultado, "|")

            mostrarGroupBox()
            mostrarBotonesEditar()

            copiaCodigo = codigo.Text

        Else
            MessageBox.Show("El código no se encuentra registrado.", " Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        keyCodigo.SelectAll()
        keyCodigo.Focus()
    End Sub
#End Region

#Region "  Rutina: loadComboBox  "
    Sub loadComboBox(ByVal inputDefault As Boolean, ByVal inputChoice As Byte)
        'Carga los comboBox
        Caja = "Consulta137" : Parametros = ""
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        If inputChoice = 1 Or inputChoice = 0 Then
            unidad.DataSource = ObjRet.DS.Tables(0)
            unidad.DisplayMember = ObjRet.DS.Tables(0).Columns(0).Caption.ToString
        End If
        
        If inputChoice = 2 Or inputChoice = 0 Then
            categoria.DataSource = ObjRet.DS.Tables(1)
            categoria.DisplayMember = ObjRet.DS.Tables(1).Columns(0).Caption.ToString
        End If
        
        If inputChoice = 3 Or inputChoice = 0 Then
            marca.DataSource = ObjRet.DS.Tables(2)
            marca.DisplayMember = ObjRet.DS.Tables(2).Columns(0).Caption.ToString
        End If
        
        If inputChoice = 4 Or inputChoice = 0 Then
            departamento.DataSource = ObjRet.DS.Tables(3)
            departamento.DisplayMember = ObjRet.DS.Tables(3).Columns(0).Caption.ToString
        End If  

        If inputDefault Then
            unidad.Text = "-SIN UNIDAD-"
            categoria.Text = "-SIN CATEGORÍA-"
            marca.Text = "-SIN MARCA-"
            departamento.Text = "-SIN DEPARTAMENTO-"
        End If
    End Sub
#End Region

#Region "  Rutina: grabar129  "
    Sub grabar129()
        Caja = "GRABAR129" : Parametros = "V0=" & copiaCodigo.Trim & _
                                          "|V1=" & descripcion.Text.Trim & _
                                          "|V2=" & codigo.Text.Trim & _
                                          "|V3=" & unidad.Text.Trim & _
                                          "|V4=" & categoria.Text.Trim & _
                                          "|V5=" & marca.Text.Trim & _
                                          "|V6=" & departamento.Text.Trim & _
                                          "|V7=" & costoCompra.Value.ToString & _
                                          "|V8=" & precioVenta.Value.ToString & _
                                          "|V9=" & stockMinimo.Value.ToString & _
                                          "|V10=" & existencia.Value.ToString & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
    End Sub
#End Region

#Region "  Evento: keyCodigo - KEY PRESS  "
    Private Sub keyCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles keyCodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            consulta136()

            Nuevo.Visible = True

        End If

        If e.KeyChar = ChrW(Keys.F2) Then
            e.Handled = True

            catalogo()

        End If
    End Sub
#End Region

#Region "  Evento: ganancia - KEY UP  "
    Private Sub ganancia_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ganancia.KeyUp
        calcularPrecioVenta()
    End Sub
#End Region

#Region "  Cambio de controles con ENTER  "
    Private Sub descripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles descripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            codigo.Focus()
        End If
    End Sub

    Private Sub codigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles codigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            unidad.Focus()
        End If
    End Sub

    Private Sub unidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles unidad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            categoria.Focus()
        End If
    End Sub


    Private Sub categoria_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles categoria.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            marca.Focus()
        End If
    End Sub

    Private Sub marca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles marca.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            departamento.Focus()
        End If
    End Sub

    Private Sub departamento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles departamento.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            costoCompra.Select(0, 10)
            costoCompra.Focus()
        End If
    End Sub

    Private Sub costoCompra_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles costoCompra.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            precioVenta.Select(0, 10)
            precioVenta.Focus()
        End If
    End Sub

    Private Sub precioVenta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles precioVenta.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            stockMinimo.Select(0, 10)
            stockMinimo.Focus()
        End If
    End Sub
#End Region

    Private Sub unidad_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unidad.Enter
        loadComboBox(False, 1)
    End Sub

    Private Sub departamento_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles departamento.Enter
        loadComboBox(False, 4)
    End Sub

    Private Sub categoria_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles categoria.Enter
        loadComboBox(False, 2)
    End Sub

    Private Sub marca_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles marca.Enter
        loadComboBox(False, 3)
    End Sub
End Class