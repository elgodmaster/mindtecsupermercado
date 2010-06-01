<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModuloVentas
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

    Private Shared ChildInstance As ModuloVentas = Nothing

    'controla que sólo exista una instancia del formulario.

    Public Shared Function Instance() As ModuloVentas
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New ModuloVentas
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
#End Region

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModuloVentas))
        Me.label16 = New System.Windows.Forms.Label
        Me.Borrar = New System.Windows.Forms.Button
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBoxPagos = New System.Windows.Forms.GroupBox
        Me.Btn_Factura = New System.Windows.Forms.Button
        Me.Btn_Credito = New System.Windows.Forms.Button
        Me.Btn_Efectivo = New System.Windows.Forms.Button
        Me.LblCambio = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Txt_Pago = New System.Windows.Forms.TextBox
        Me.LblTotal = New System.Windows.Forms.Label
        Me.LblIva = New System.Windows.Forms.Label
        Me.LblSubTotal = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.CancelarVenta = New System.Windows.Forms.Button
        Me.AceptarVenta = New System.Windows.Forms.Button
        Me.GridDatos = New SourceGrid.DataGrid
        Me.Descuento = New System.Windows.Forms.Button
        Me.Agregar = New System.Windows.Forms.Button
        Me.TxtCantidad = New System.Windows.Forms.TextBox
        Me.Codigo_Producto = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ChecarPrecio = New System.Windows.Forms.ToolStripButton
        Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.toolStripButton6 = New System.Windows.Forms.ToolStripButton
        Me.label15 = New System.Windows.Forms.Label
        Me.label14 = New System.Windows.Forms.Label
        Me.panel1 = New System.Windows.Forms.Panel
        Me.panel2 = New System.Windows.Forms.Panel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblFecha = New System.Windows.Forms.Label
        Me.lblhora = New System.Windows.Forms.Label
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.GroupBoxPagos.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label16.Location = New System.Drawing.Point(454, 14)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(57, 13)
        Me.label16.TabIndex = 25
        Me.label16.Text = "Cantidad"
        '
        'Borrar
        '
        Me.Borrar.BackgroundImage = CType(resources.GetObject("Borrar.BackgroundImage"), System.Drawing.Image)
        Me.Borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Borrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrar.Location = New System.Drawing.Point(838, 29)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(95, 31)
        Me.Borrar.TabIndex = 4
        Me.Borrar.Text = "F3"
        Me.Borrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.groupBox1)
        Me.groupBox2.Controls.Add(Me.CancelarVenta)
        Me.groupBox2.Controls.Add(Me.AceptarVenta)
        Me.groupBox2.Controls.Add(Me.GridDatos)
        Me.groupBox2.Controls.Add(Me.label16)
        Me.groupBox2.Controls.Add(Me.Borrar)
        Me.groupBox2.Controls.Add(Me.Descuento)
        Me.groupBox2.Controls.Add(Me.Agregar)
        Me.groupBox2.Controls.Add(Me.TxtCantidad)
        Me.groupBox2.Controls.Add(Me.Codigo_Producto)
        Me.groupBox2.Controls.Add(Me.label1)
        Me.groupBox2.Location = New System.Drawing.Point(58, 192)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(938, 510)
        Me.groupBox2.TabIndex = 26
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Detalle de la venta"
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.GroupBoxPagos)
        Me.groupBox1.Controls.Add(Me.LblTotal)
        Me.groupBox1.Controls.Add(Me.LblIva)
        Me.groupBox1.Controls.Add(Me.LblSubTotal)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.ForeColor = System.Drawing.Color.Black
        Me.groupBox1.Location = New System.Drawing.Point(15, 358)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(709, 127)
        Me.groupBox1.TabIndex = 31
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Detalle de importe"
        '
        'GroupBoxPagos
        '
        Me.GroupBoxPagos.Controls.Add(Me.Btn_Factura)
        Me.GroupBoxPagos.Controls.Add(Me.Btn_Credito)
        Me.GroupBoxPagos.Controls.Add(Me.Btn_Efectivo)
        Me.GroupBoxPagos.Controls.Add(Me.LblCambio)
        Me.GroupBoxPagos.Controls.Add(Me.Label6)
        Me.GroupBoxPagos.Controls.Add(Me.Label5)
        Me.GroupBoxPagos.Controls.Add(Me.Txt_Pago)
        Me.GroupBoxPagos.Location = New System.Drawing.Point(344, 5)
        Me.GroupBoxPagos.Name = "GroupBoxPagos"
        Me.GroupBoxPagos.Size = New System.Drawing.Size(357, 116)
        Me.GroupBoxPagos.TabIndex = 12
        Me.GroupBoxPagos.TabStop = False
        Me.GroupBoxPagos.Text = "Forma de pago"
        Me.GroupBoxPagos.Visible = False
        '
        'Btn_Factura
        '
        Me.Btn_Factura.BackgroundImage = CType(resources.GetObject("Btn_Factura.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Factura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Factura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Factura.Location = New System.Drawing.Point(279, 79)
        Me.Btn_Factura.Name = "Btn_Factura"
        Me.Btn_Factura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Factura.Size = New System.Drawing.Size(57, 31)
        Me.Btn_Factura.TabIndex = 3
        Me.Btn_Factura.Text = "F9"
        Me.Btn_Factura.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Btn_Factura.UseVisualStyleBackColor = True
        '
        'Btn_Credito
        '
        Me.Btn_Credito.BackgroundImage = CType(resources.GetObject("Btn_Credito.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Credito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Credito.Location = New System.Drawing.Point(279, 30)
        Me.Btn_Credito.Name = "Btn_Credito"
        Me.Btn_Credito.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Credito.Size = New System.Drawing.Size(57, 31)
        Me.Btn_Credito.TabIndex = 2
        Me.Btn_Credito.Text = "F9"
        Me.Btn_Credito.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Btn_Credito.UseVisualStyleBackColor = True
        '
        'Btn_Efectivo
        '
        Me.Btn_Efectivo.BackgroundImage = CType(resources.GetObject("Btn_Efectivo.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Efectivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Efectivo.Location = New System.Drawing.Point(216, 30)
        Me.Btn_Efectivo.Name = "Btn_Efectivo"
        Me.Btn_Efectivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Efectivo.Size = New System.Drawing.Size(57, 31)
        Me.Btn_Efectivo.TabIndex = 1
        Me.Btn_Efectivo.Text = "F8"
        Me.Btn_Efectivo.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Btn_Efectivo.UseVisualStyleBackColor = True
        '
        'LblCambio
        '
        Me.LblCambio.AutoSize = True
        Me.LblCambio.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCambio.Location = New System.Drawing.Point(118, 68)
        Me.LblCambio.Name = "LblCambio"
        Me.LblCambio.Size = New System.Drawing.Size(44, 18)
        Me.LblCambio.TabIndex = 15
        Me.LblCambio.Text = "0.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-1, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Cambio/Feria"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Recibí"
        '
        'Txt_Pago
        '
        Me.Txt_Pago.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Pago.Location = New System.Drawing.Point(113, 32)
        Me.Txt_Pago.Name = "Txt_Pago"
        Me.Txt_Pago.Size = New System.Drawing.Size(100, 27)
        Me.Txt_Pago.TabIndex = 0
        Me.Txt_Pago.Text = "0.00"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.Black
        Me.LblTotal.Location = New System.Drawing.Point(138, 96)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(60, 24)
        Me.LblTotal.TabIndex = 5
        Me.LblTotal.Text = "$0.00"
        '
        'LblIva
        '
        Me.LblIva.AutoSize = True
        Me.LblIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIva.ForeColor = System.Drawing.Color.Black
        Me.LblIva.Location = New System.Drawing.Point(155, 60)
        Me.LblIva.Name = "LblIva"
        Me.LblIva.Size = New System.Drawing.Size(39, 13)
        Me.LblIva.TabIndex = 4
        Me.LblIva.Text = "$0.00"
        '
        'LblSubTotal
        '
        Me.LblSubTotal.AutoSize = True
        Me.LblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTotal.ForeColor = System.Drawing.Color.Black
        Me.LblSubTotal.Location = New System.Drawing.Point(155, 28)
        Me.LblSubTotal.Name = "LblSubTotal"
        Me.LblSubTotal.Size = New System.Drawing.Size(39, 13)
        Me.LblSubTotal.TabIndex = 3
        Me.LblSubTotal.Text = "$0.00"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(24, 96)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(62, 24)
        Me.label4.TabIndex = 2
        Me.label4.Text = "Total:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(55, 60)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(31, 13)
        Me.label3.TabIndex = 1
        Me.label3.Text = "IVA:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(28, 28)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(58, 13)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Subtotal:"
        '
        'CancelarVenta
        '
        Me.CancelarVenta.Enabled = False
        Me.CancelarVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelarVenta.Image = CType(resources.GetObject("CancelarVenta.Image"), System.Drawing.Image)
        Me.CancelarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelarVenta.Location = New System.Drawing.Point(838, 363)
        Me.CancelarVenta.Name = "CancelarVenta"
        Me.CancelarVenta.Size = New System.Drawing.Size(87, 51)
        Me.CancelarVenta.TabIndex = 7
        Me.CancelarVenta.Text = "F12"
        Me.CancelarVenta.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.CancelarVenta.UseVisualStyleBackColor = True
        '
        'AceptarVenta
        '
        Me.AceptarVenta.Enabled = False
        Me.AceptarVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AceptarVenta.Image = CType(resources.GetObject("AceptarVenta.Image"), System.Drawing.Image)
        Me.AceptarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AceptarVenta.Location = New System.Drawing.Point(730, 363)
        Me.AceptarVenta.Name = "AceptarVenta"
        Me.AceptarVenta.Size = New System.Drawing.Size(87, 51)
        Me.AceptarVenta.TabIndex = 6
        Me.AceptarVenta.Text = "    F10"
        Me.AceptarVenta.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AceptarVenta.UseVisualStyleBackColor = True
        '
        'GridDatos
        '
        Me.GridDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GridDatos.DeleteQuestionMessage = ""
        Me.GridDatos.DeleteRowsWithDeleteKey = False
        Me.GridDatos.FixedRows = 1
        Me.GridDatos.Location = New System.Drawing.Point(7, 83)
        Me.GridDatos.Name = "GridDatos"
        Me.GridDatos.SelectionMode = SourceGrid.GridSelectionMode.Row
        Me.GridDatos.Size = New System.Drawing.Size(925, 259)
        Me.GridDatos.TabIndex = 5
        Me.GridDatos.TabStop = True
        Me.GridDatos.ToolTipText = ""
        '
        'Descuento
        '
        Me.Descuento.BackgroundImage = CType(resources.GetObject("Descuento.BackgroundImage"), System.Drawing.Image)
        Me.Descuento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descuento.Location = New System.Drawing.Point(731, 29)
        Me.Descuento.Name = "Descuento"
        Me.Descuento.Size = New System.Drawing.Size(95, 31)
        Me.Descuento.TabIndex = 3
        Me.Descuento.Text = "F7"
        Me.Descuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Descuento.UseVisualStyleBackColor = True
        '
        'Agregar
        '
        Me.Agregar.BackgroundImage = CType(resources.GetObject("Agregar.BackgroundImage"), System.Drawing.Image)
        Me.Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Agregar.Location = New System.Drawing.Point(512, 29)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Agregar.Size = New System.Drawing.Size(57, 31)
        Me.Agregar.TabIndex = 2
        Me.Agregar.Text = "F5"
        Me.Agregar.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidad.Location = New System.Drawing.Point(453, 30)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(60, 29)
        Me.TxtCantidad.TabIndex = 1
        Me.TxtCantidad.Text = "0.00"
        '
        'Codigo_Producto
        '
        Me.Codigo_Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo_Producto.Location = New System.Drawing.Point(184, 30)
        Me.Codigo_Producto.Name = "Codigo_Producto"
        Me.Codigo_Producto.Size = New System.Drawing.Size(272, 29)
        Me.Codigo_Producto.TabIndex = 0
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(12, 34)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(166, 18)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Código del producto:"
        '
        'toolStrip1
        '
        Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChecarPrecio, Me.toolStripButton3, Me.toolStripButton4, Me.toolStripButton5, Me.toolStripButton6})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(53, 708)
        Me.toolStrip1.TabIndex = 27
        Me.toolStrip1.Text = "toolStrip1"
        '
        'ChecarPrecio
        '
        Me.ChecarPrecio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ChecarPrecio.Image = CType(resources.GetObject("ChecarPrecio.Image"), System.Drawing.Image)
        Me.ChecarPrecio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ChecarPrecio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ChecarPrecio.Name = "ChecarPrecio"
        Me.ChecarPrecio.Size = New System.Drawing.Size(50, 52)
        Me.ChecarPrecio.Text = "Checador de precios"
        '
        'toolStripButton3
        '
        Me.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButton3.Image = CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image)
        Me.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton3.Name = "toolStripButton3"
        Me.toolStripButton3.Size = New System.Drawing.Size(50, 52)
        Me.toolStripButton3.Text = "Pedidos"
        '
        'toolStripButton4
        '
        Me.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButton4.Image = CType(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image)
        Me.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton4.Name = "toolStripButton4"
        Me.toolStripButton4.Size = New System.Drawing.Size(50, 52)
        Me.toolStripButton4.Text = "Corte"
        '
        'toolStripButton5
        '
        Me.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButton5.Image = CType(resources.GetObject("toolStripButton5.Image"), System.Drawing.Image)
        Me.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton5.Name = "toolStripButton5"
        Me.toolStripButton5.Size = New System.Drawing.Size(50, 36)
        Me.toolStripButton5.Text = "Cerrar sesión"
        '
        'toolStripButton6
        '
        Me.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButton6.Image = CType(resources.GetObject("toolStripButton6.Image"), System.Drawing.Image)
        Me.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton6.Name = "toolStripButton6"
        Me.toolStripButton6.Size = New System.Drawing.Size(50, 36)
        Me.toolStripButton6.Text = "Salir"
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.Location = New System.Drawing.Point(6, 151)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(292, 24)
        Me.label15.TabIndex = 25
        Me.label15.Text = "2 cafes chicos por solo $14.50"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.Location = New System.Drawing.Point(58, 9)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(207, 29)
        Me.label14.TabIndex = 24
        Me.label14.Text = "PROMOCIONES"
        '
        'panel1
        '
        Me.panel1.BackgroundImage = CType(resources.GetObject("panel1.BackgroundImage"), System.Drawing.Image)
        Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.panel1.Controls.Add(Me.label15)
        Me.panel1.Controls.Add(Me.label14)
        Me.panel1.Location = New System.Drawing.Point(692, 6)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(302, 182)
        Me.panel1.TabIndex = 28
        '
        'panel2
        '
        Me.panel2.BackgroundImage = CType(resources.GetObject("panel2.BackgroundImage"), System.Drawing.Image)
        Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel2.Location = New System.Drawing.Point(85, 33)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(429, 151)
        Me.panel2.TabIndex = 29
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblFecha
        '
        Me.lblFecha.AutoEllipsis = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(87, 6)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(254, 24)
        Me.lblFecha.TabIndex = 340
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblhora
        '
        Me.lblhora.AutoEllipsis = True
        Me.lblhora.BackColor = System.Drawing.Color.Transparent
        Me.lblhora.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.Location = New System.Drawing.Point(404, 6)
        Me.lblhora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(110, 24)
        Me.lblhora.TabIndex = 349
        Me.lblhora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ModuloVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 708)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.toolStrip1)
        Me.Controls.Add(Me.groupBox2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.KeyPreview = True
        Me.Name = "ModuloVentas"
        Me.Text = "ModuloVentas"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.GroupBoxPagos.ResumeLayout(False)
        Me.GroupBoxPagos.PerformLayout()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label16 As System.Windows.Forms.Label
    Private WithEvents Borrar As System.Windows.Forms.Button
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents Descuento As System.Windows.Forms.Button
    Private WithEvents Agregar As System.Windows.Forms.Button
    Private WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Private WithEvents Codigo_Producto As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents ChecarPrecio As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButton3 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButton4 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButton5 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButton6 As System.Windows.Forms.ToolStripButton
    Private WithEvents label15 As System.Windows.Forms.Label
    Private WithEvents label14 As System.Windows.Forms.Label
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents GridDatos As SourceGrid.DataGrid
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents LblTotal As System.Windows.Forms.Label
    Private WithEvents LblIva As System.Windows.Forms.Label
    Private WithEvents LblSubTotal As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents CancelarVenta As System.Windows.Forms.Button
    Private WithEvents AceptarVenta As System.Windows.Forms.Button
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents GroupBoxPagos As System.Windows.Forms.GroupBox
    Private WithEvents Btn_Credito As System.Windows.Forms.Button
    Private WithEvents Btn_Efectivo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txt_Pago As System.Windows.Forms.TextBox
    Private WithEvents Btn_Factura As System.Windows.Forms.Button
    Friend WithEvents LblCambio As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
