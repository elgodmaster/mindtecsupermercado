<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cat_Productos
    Inherits System.Windows.Forms.Form

    'Para el control de una sola instancia por formulario.
#Region "  Modificación del constructor  "
    ' En esta constructora es que cambio la propiedad Public por la propiedad Private
    Private Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Private Shared ChildInstance As Cat_Productos = Nothing

    'controla que sólo exista una instancia del formulario.

    Public Shared Function Instance() As Cat_Productos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New Cat_Productos
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
#End Region

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cat_Productos))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Limpiar = New System.Windows.Forms.ToolStripButton
        Me.Grabar = New System.Windows.Forms.ToolStripButton
        Me.Eliminar = New System.Windows.Forms.ToolStripButton
        Me.Barra = New System.Windows.Forms.PictureBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Producto = New System.Windows.Forms.Label
        Me.CodigoProducto = New System.Windows.Forms.TextBox
        Me.NombreProducto = New System.Windows.Forms.Label
        Me.GroupBoxDescripcion = New System.Windows.Forms.GroupBox
        Me.Txt_InvIni = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.NombreUnidad = New System.Windows.Forms.Label
        Me.CodigoUnidad = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtStock = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtNombre = New System.Windows.Forms.TextBox
        Me.LblNombres = New System.Windows.Forms.Label
        Me.GroupBoxdVenta = New System.Windows.Forms.GroupBox
        Me.TxtPrecio = New System.Windows.Forms.TextBox
        Me.TxtCostoVenta = New System.Windows.Forms.Label
        Me.TxtFlete = New System.Windows.Forms.TextBox
        Me.TxtCostoCompra = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtMargen = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.PiePagina = New System.Windows.Forms.StatusStrip
        Me.MensajePiePagina = New System.Windows.Forms.ToolStripStatusLabel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CodigoMarca = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CodigoCategoria = New System.Windows.Forms.TextBox
        Me.NombreMarca = New System.Windows.Forms.Label
        Me.NombreCategoria = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtDepto = New System.Windows.Forms.TextBox
        Me.Lbl_Depto = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDescripcion.SuspendLayout()
        Me.GroupBoxdVenta.SuspendLayout()
        Me.PiePagina.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Limpiar, Me.Grabar, Me.Eliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1016, 48)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Limpiar
        '
        Me.Limpiar.AutoSize = False
        Me.Limpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Limpiar.Image = CType(resources.GetObject("Limpiar.Image"), System.Drawing.Image)
        Me.Limpiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Limpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(43, 45)
        Me.Limpiar.Text = "Limpiar"
        '
        'Grabar
        '
        Me.Grabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Grabar.Image = CType(resources.GetObject("Grabar.Image"), System.Drawing.Image)
        Me.Grabar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Grabar.Name = "Grabar"
        Me.Grabar.Size = New System.Drawing.Size(36, 45)
        Me.Grabar.Text = "Grabar"
        '
        'Eliminar
        '
        Me.Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), System.Drawing.Image)
        Me.Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(36, 45)
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.Visible = False
        '
        'Barra
        '
        Me.Barra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Barra.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Barra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Barra.Location = New System.Drawing.Point(0, 210)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(1024, 4)
        Me.Barra.TabIndex = 288
        Me.Barra.TabStop = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.btnAceptar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(914, 176)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(80, 25)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'Producto
        '
        Me.Producto.AutoSize = True
        Me.Producto.BackColor = System.Drawing.Color.Transparent
        Me.Producto.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Producto.Location = New System.Drawing.Point(47, 182)
        Me.Producto.Name = "Producto"
        Me.Producto.Size = New System.Drawing.Size(63, 14)
        Me.Producto.TabIndex = 290
        Me.Producto.Text = "Producto"
        '
        'CodigoProducto
        '
        Me.CodigoProducto.BackColor = System.Drawing.SystemColors.Info
        Me.CodigoProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoProducto.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoProducto.Location = New System.Drawing.Point(115, 178)
        Me.CodigoProducto.MaxLength = 50
        Me.CodigoProducto.Name = "CodigoProducto"
        Me.CodigoProducto.Size = New System.Drawing.Size(126, 22)
        Me.CodigoProducto.TabIndex = 3
        '
        'NombreProducto
        '
        Me.NombreProducto.BackColor = System.Drawing.Color.Transparent
        Me.NombreProducto.Location = New System.Drawing.Point(250, 178)
        Me.NombreProducto.Name = "NombreProducto"
        Me.NombreProducto.Size = New System.Drawing.Size(660, 22)
        Me.NombreProducto.TabIndex = 295
        '
        'GroupBoxDescripcion
        '
        Me.GroupBoxDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxDescripcion.Controls.Add(Me.Txt_InvIni)
        Me.GroupBoxDescripcion.Controls.Add(Me.Label3)
        Me.GroupBoxDescripcion.Controls.Add(Me.NombreUnidad)
        Me.GroupBoxDescripcion.Controls.Add(Me.CodigoUnidad)
        Me.GroupBoxDescripcion.Controls.Add(Me.Label5)
        Me.GroupBoxDescripcion.Controls.Add(Me.TxtStock)
        Me.GroupBoxDescripcion.Controls.Add(Me.Label4)
        Me.GroupBoxDescripcion.Controls.Add(Me.TxtNombre)
        Me.GroupBoxDescripcion.Controls.Add(Me.LblNombres)
        Me.GroupBoxDescripcion.Location = New System.Drawing.Point(12, 236)
        Me.GroupBoxDescripcion.Name = "GroupBoxDescripcion"
        Me.GroupBoxDescripcion.Size = New System.Drawing.Size(969, 145)
        Me.GroupBoxDescripcion.TabIndex = 296
        Me.GroupBoxDescripcion.TabStop = False
        Me.GroupBoxDescripcion.Text = "Datos generales"
        Me.GroupBoxDescripcion.Visible = False
        '
        'Txt_InvIni
        '
        Me.Txt_InvIni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_InvIni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_InvIni.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_InvIni.Location = New System.Drawing.Point(113, 82)
        Me.Txt_InvIni.MaxLength = 50
        Me.Txt_InvIni.Name = "Txt_InvIni"
        Me.Txt_InvIni.Size = New System.Drawing.Size(81, 22)
        Me.Txt_InvIni.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 14)
        Me.Label3.TabIndex = 297
        Me.Label3.Text = "Inventario inicial"
        '
        'NombreUnidad
        '
        Me.NombreUnidad.Location = New System.Drawing.Point(200, 54)
        Me.NombreUnidad.Name = "NombreUnidad"
        Me.NombreUnidad.Size = New System.Drawing.Size(760, 22)
        Me.NombreUnidad.TabIndex = 295
        '
        'CodigoUnidad
        '
        Me.CodigoUnidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CodigoUnidad.BackColor = System.Drawing.SystemColors.Info
        Me.CodigoUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoUnidad.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoUnidad.Location = New System.Drawing.Point(113, 54)
        Me.CodigoUnidad.MaxLength = 9
        Me.CodigoUnidad.Name = "CodigoUnidad"
        Me.CodigoUnidad.Size = New System.Drawing.Size(81, 22)
        Me.CodigoUnidad.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 14)
        Me.Label5.TabIndex = 278
        Me.Label5.Text = "Unidad"
        '
        'TxtStock
        '
        Me.TxtStock.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStock.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStock.Location = New System.Drawing.Point(113, 110)
        Me.TxtStock.MaxLength = 50
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(81, 22)
        Me.TxtStock.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 14)
        Me.Label4.TabIndex = 277
        Me.Label4.Text = "Stock Mínimo"
        '
        'TxtNombre
        '
        Me.TxtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(113, 26)
        Me.TxtNombre.MaxLength = 50
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(847, 22)
        Me.TxtNombre.TabIndex = 0
        '
        'LblNombres
        '
        Me.LblNombres.AutoSize = True
        Me.LblNombres.BackColor = System.Drawing.Color.Transparent
        Me.LblNombres.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombres.Location = New System.Drawing.Point(31, 30)
        Me.LblNombres.Name = "LblNombres"
        Me.LblNombres.Size = New System.Drawing.Size(78, 14)
        Me.LblNombres.TabIndex = 268
        Me.LblNombres.Text = "Descripción"
        '
        'GroupBoxdVenta
        '
        Me.GroupBoxdVenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxdVenta.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxdVenta.Controls.Add(Me.TxtPrecio)
        Me.GroupBoxdVenta.Controls.Add(Me.TxtCostoVenta)
        Me.GroupBoxdVenta.Controls.Add(Me.TxtFlete)
        Me.GroupBoxdVenta.Controls.Add(Me.TxtCostoCompra)
        Me.GroupBoxdVenta.Controls.Add(Me.Label11)
        Me.GroupBoxdVenta.Controls.Add(Me.Label6)
        Me.GroupBoxdVenta.Controls.Add(Me.Label10)
        Me.GroupBoxdVenta.Controls.Add(Me.TxtMargen)
        Me.GroupBoxdVenta.Controls.Add(Me.Label7)
        Me.GroupBoxdVenta.Location = New System.Drawing.Point(11, 399)
        Me.GroupBoxdVenta.Name = "GroupBoxdVenta"
        Me.GroupBoxdVenta.Size = New System.Drawing.Size(970, 256)
        Me.GroupBoxdVenta.TabIndex = 297
        Me.GroupBoxdVenta.TabStop = False
        Me.GroupBoxdVenta.Text = "Datos de venta"
        Me.GroupBoxdVenta.Visible = False
        '
        'TxtPrecio
        '
        Me.TxtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPrecio.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio.Location = New System.Drawing.Point(133, 120)
        Me.TxtPrecio.MaxLength = 9
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(156, 22)
        Me.TxtPrecio.TabIndex = 3
        '
        'TxtCostoVenta
        '
        Me.TxtCostoVenta.BackColor = System.Drawing.Color.Transparent
        Me.TxtCostoVenta.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCostoVenta.Location = New System.Drawing.Point(295, 117)
        Me.TxtCostoVenta.Name = "TxtCostoVenta"
        Me.TxtCostoVenta.Size = New System.Drawing.Size(113, 23)
        Me.TxtCostoVenta.TabIndex = 280
        Me.TxtCostoVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtFlete
        '
        Me.TxtFlete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFlete.Location = New System.Drawing.Point(133, 64)
        Me.TxtFlete.MaxLength = 9
        Me.TxtFlete.Name = "TxtFlete"
        Me.TxtFlete.Size = New System.Drawing.Size(156, 22)
        Me.TxtFlete.TabIndex = 1
        '
        'TxtCostoCompra
        '
        Me.TxtCostoCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCostoCompra.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCostoCompra.Location = New System.Drawing.Point(133, 36)
        Me.TxtCostoCompra.MaxLength = 9
        Me.TxtCostoCompra.Name = "TxtCostoCompra"
        Me.TxtCostoCompra.Size = New System.Drawing.Size(156, 22)
        Me.TxtCostoCompra.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 14)
        Me.Label11.TabIndex = 273
        Me.Label11.Text = "Costo de compra"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 14)
        Me.Label6.TabIndex = 278
        Me.Label6.Text = "Precio de venta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(92, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 14)
        Me.Label10.TabIndex = 274
        Me.Label10.Text = "Flete"
        '
        'TxtMargen
        '
        Me.TxtMargen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMargen.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMargen.Location = New System.Drawing.Point(133, 92)
        Me.TxtMargen.MaxLength = 9
        Me.TxtMargen.Name = "TxtMargen"
        Me.TxtMargen.Size = New System.Drawing.Size(156, 22)
        Me.TxtMargen.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(76, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 14)
        Me.Label7.TabIndex = 277
        Me.Label7.Text = "Margen"
        '
        'PiePagina
        '
        Me.PiePagina.BackColor = System.Drawing.SystemColors.Info
        Me.PiePagina.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PiePagina.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MensajePiePagina})
        Me.PiePagina.Location = New System.Drawing.Point(0, 686)
        Me.PiePagina.Name = "PiePagina"
        Me.PiePagina.Size = New System.Drawing.Size(1016, 22)
        Me.PiePagina.SizingGrip = False
        Me.PiePagina.TabIndex = 298
        Me.PiePagina.Text = "StatusStrip1"
        '
        'MensajePiePagina
        '
        Me.MensajePiePagina.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MensajePiePagina.Name = "MensajePiePagina"
        Me.MensajePiePagina.Size = New System.Drawing.Size(150, 17)
        Me.MensajePiePagina.Text = "ToolStripStatusLabel1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(224, 20)
        Me.Label8.TabIndex = 299
        Me.Label8.Text = "Catálogo de Productos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 14)
        Me.Label1.TabIndex = 287
        Me.Label1.Text = "Marca"
        '
        'CodigoMarca
        '
        Me.CodigoMarca.BackColor = System.Drawing.SystemColors.Info
        Me.CodigoMarca.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoMarca.Location = New System.Drawing.Point(116, 150)
        Me.CodigoMarca.MaxLength = 9
        Me.CodigoMarca.Name = "CodigoMarca"
        Me.CodigoMarca.Size = New System.Drawing.Size(126, 22)
        Me.CodigoMarca.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 14)
        Me.Label2.TabIndex = 289
        Me.Label2.Text = "Categoría"
        '
        'CodigoCategoria
        '
        Me.CodigoCategoria.BackColor = System.Drawing.SystemColors.Info
        Me.CodigoCategoria.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoCategoria.Location = New System.Drawing.Point(115, 121)
        Me.CodigoCategoria.MaxLength = 9
        Me.CodigoCategoria.Name = "CodigoCategoria"
        Me.CodigoCategoria.Size = New System.Drawing.Size(126, 22)
        Me.CodigoCategoria.TabIndex = 1
        '
        'NombreMarca
        '
        Me.NombreMarca.BackColor = System.Drawing.Color.Transparent
        Me.NombreMarca.Location = New System.Drawing.Point(250, 150)
        Me.NombreMarca.Name = "NombreMarca"
        Me.NombreMarca.Size = New System.Drawing.Size(660, 22)
        Me.NombreMarca.TabIndex = 293
        '
        'NombreCategoria
        '
        Me.NombreCategoria.BackColor = System.Drawing.Color.Transparent
        Me.NombreCategoria.Location = New System.Drawing.Point(250, 121)
        Me.NombreCategoria.Name = "NombreCategoria"
        Me.NombreCategoria.Size = New System.Drawing.Size(660, 22)
        Me.NombreCategoria.TabIndex = 294
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 14)
        Me.Label9.TabIndex = 301
        Me.Label9.Text = "Departamento"
        '
        'TxtDepto
        '
        Me.TxtDepto.BackColor = System.Drawing.SystemColors.Info
        Me.TxtDepto.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDepto.Location = New System.Drawing.Point(115, 93)
        Me.TxtDepto.MaxLength = 9
        Me.TxtDepto.Name = "TxtDepto"
        Me.TxtDepto.Size = New System.Drawing.Size(126, 22)
        Me.TxtDepto.TabIndex = 0
        '
        'Lbl_Depto
        '
        Me.Lbl_Depto.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Depto.Location = New System.Drawing.Point(250, 93)
        Me.Lbl_Depto.Name = "Lbl_Depto"
        Me.Lbl_Depto.Size = New System.Drawing.Size(660, 22)
        Me.Lbl_Depto.TabIndex = 302
        '
        'Cat_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 708)
        Me.Controls.Add(Me.Lbl_Depto)
        Me.Controls.Add(Me.TxtDepto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PiePagina)
        Me.Controls.Add(Me.GroupBoxdVenta)
        Me.Controls.Add(Me.GroupBoxDescripcion)
        Me.Controls.Add(Me.NombreProducto)
        Me.Controls.Add(Me.NombreCategoria)
        Me.Controls.Add(Me.NombreMarca)
        Me.Controls.Add(Me.CodigoProducto)
        Me.Controls.Add(Me.CodigoCategoria)
        Me.Controls.Add(Me.Producto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.CodigoMarca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Cat_Productos"
        Me.Text = "Catálogo de Productos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDescripcion.ResumeLayout(False)
        Me.GroupBoxDescripcion.PerformLayout()
        Me.GroupBoxdVenta.ResumeLayout(False)
        Me.GroupBoxdVenta.PerformLayout()
        Me.PiePagina.ResumeLayout(False)
        Me.PiePagina.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Limpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Barra As System.Windows.Forms.PictureBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Producto As System.Windows.Forms.Label
    Friend WithEvents CodigoProducto As System.Windows.Forms.TextBox
    Friend WithEvents NombreProducto As System.Windows.Forms.Label
    Friend WithEvents GroupBoxDescripcion As System.Windows.Forms.GroupBox
    Friend WithEvents LblNombres As System.Windows.Forms.Label
    Friend WithEvents GroupBoxdVenta As System.Windows.Forms.GroupBox
    Friend WithEvents TxtFlete As System.Windows.Forms.TextBox
    Friend WithEvents TxtCostoCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtMargen As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtCostoVenta As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents PiePagina As System.Windows.Forms.StatusStrip
    Friend WithEvents MensajePiePagina As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TxtStock As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CodigoUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NombreUnidad As System.Windows.Forms.Label
    Friend WithEvents Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CodigoMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CodigoCategoria As System.Windows.Forms.TextBox
    Friend WithEvents NombreMarca As System.Windows.Forms.Label
    Friend WithEvents NombreCategoria As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtDepto As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Depto As System.Windows.Forms.Label
    Friend WithEvents Txt_InvIni As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
