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
        Me.CantidadNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.GridDatos = New SourceGrid.DataGrid
        Me.Agregar = New System.Windows.Forms.Button
        Me.Codigo_Producto = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ChecarPrecio = New System.Windows.Forms.ToolStripButton
        Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.toolStripButton6 = New System.Windows.Forms.ToolStripButton
        Me.panel2 = New System.Windows.Forms.Panel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBoxPagos = New System.Windows.Forms.GroupBox
        Me.LblCambio = New System.Windows.Forms.Label
        Me.NumericUpDownPago = New System.Windows.Forms.NumericUpDown
        Me.Btn_Factura = New System.Windows.Forms.Button
        Me.Btn_Credito = New System.Windows.Forms.Button
        Me.Btn_Efectivo = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.LblTotal = New System.Windows.Forms.Label
        Me.LblIva = New System.Windows.Forms.Label
        Me.LblSubTotal = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.CancelarVenta = New System.Windows.Forms.Button
        Me.AceptarVenta = New System.Windows.Forms.Button
        Me.lblhora = New System.Windows.Forms.Label
        Me.lblFecha = New System.Windows.Forms.Label
        Me.label16 = New System.Windows.Forms.Label
        CType(Me.CantidadNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolStrip1.SuspendLayout()
        Me.GroupBoxPagos.SuspendLayout()
        CType(Me.NumericUpDownPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CantidadNumericUpDown
        '
        Me.CantidadNumericUpDown.DecimalPlaces = 2
        Me.CantidadNumericUpDown.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadNumericUpDown.Location = New System.Drawing.Point(421, 27)
        Me.CantidadNumericUpDown.Maximum = New Decimal(New Integer() {-1593835521, 466537709, 54210, 0})
        Me.CantidadNumericUpDown.MaximumSize = New System.Drawing.Size(96, 0)
        Me.CantidadNumericUpDown.Name = "CantidadNumericUpDown"
        Me.CantidadNumericUpDown.Size = New System.Drawing.Size(96, 31)
        Me.CantidadNumericUpDown.TabIndex = 1
        Me.CantidadNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GridDatos
        '
        Me.GridDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDatos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GridDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridDatos.DeleteQuestionMessage = ""
        Me.GridDatos.DeleteRowsWithDeleteKey = False
        Me.GridDatos.FixedRows = 1
        Me.GridDatos.Location = New System.Drawing.Point(65, 62)
        Me.GridDatos.Name = "GridDatos"
        Me.GridDatos.SelectionMode = SourceGrid.GridSelectionMode.Row
        Me.GridDatos.Size = New System.Drawing.Size(572, 583)
        Me.GridDatos.TabIndex = 5
        Me.GridDatos.TabStop = True
        Me.GridDatos.ToolTipText = ""
        '
        'Agregar
        '
        Me.Agregar.BackgroundImage = CType(resources.GetObject("Agregar.BackgroundImage"), System.Drawing.Image)
        Me.Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Agregar.Location = New System.Drawing.Point(523, 25)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Agregar.Size = New System.Drawing.Size(66, 31)
        Me.Agregar.TabIndex = 2
        Me.Agregar.Text = "F5"
        Me.Agregar.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Codigo_Producto
        '
        Me.Codigo_Producto.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo_Producto.Location = New System.Drawing.Point(150, 27)
        Me.Codigo_Producto.Name = "Codigo_Producto"
        Me.Codigo_Producto.Size = New System.Drawing.Size(272, 31)
        Me.Codigo_Producto.TabIndex = 0
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(61, 30)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(86, 23)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Código:"
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
        'panel2
        '
        Me.panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel2.BackgroundImage = CType(resources.GetObject("panel2.BackgroundImage"), System.Drawing.Image)
        Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel2.Location = New System.Drawing.Point(679, 25)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(312, 118)
        Me.panel2.TabIndex = 29
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'GroupBoxPagos
        '
        Me.GroupBoxPagos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxPagos.Controls.Add(Me.LblCambio)
        Me.GroupBoxPagos.Controls.Add(Me.NumericUpDownPago)
        Me.GroupBoxPagos.Controls.Add(Me.Btn_Factura)
        Me.GroupBoxPagos.Controls.Add(Me.Btn_Credito)
        Me.GroupBoxPagos.Controls.Add(Me.Btn_Efectivo)
        Me.GroupBoxPagos.Controls.Add(Me.Label6)
        Me.GroupBoxPagos.Controls.Add(Me.Label5)
        Me.GroupBoxPagos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPagos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBoxPagos.Location = New System.Drawing.Point(679, 520)
        Me.GroupBoxPagos.Name = "GroupBoxPagos"
        Me.GroupBoxPagos.Size = New System.Drawing.Size(312, 125)
        Me.GroupBoxPagos.TabIndex = 352
        Me.GroupBoxPagos.TabStop = False
        Me.GroupBoxPagos.Text = " Forma de pago "
        Me.GroupBoxPagos.Visible = False
        '
        'LblCambio
        '
        Me.LblCambio.AutoSize = True
        Me.LblCambio.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCambio.Location = New System.Drawing.Point(119, 78)
        Me.LblCambio.Name = "LblCambio"
        Me.LblCambio.Size = New System.Drawing.Size(53, 23)
        Me.LblCambio.TabIndex = 15
        Me.LblCambio.Text = "0.00"
        '
        'NumericUpDownPago
        '
        Me.NumericUpDownPago.DecimalPlaces = 2
        Me.NumericUpDownPago.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownPago.Location = New System.Drawing.Point(119, 33)
        Me.NumericUpDownPago.Maximum = New Decimal(New Integer() {-1304428545, 434162106, 542, 0})
        Me.NumericUpDownPago.Name = "NumericUpDownPago"
        Me.NumericUpDownPago.Size = New System.Drawing.Size(100, 31)
        Me.NumericUpDownPago.TabIndex = 354
        '
        'Btn_Factura
        '
        Me.Btn_Factura.BackgroundImage = CType(resources.GetObject("Btn_Factura.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Factura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Factura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Factura.Location = New System.Drawing.Point(237, 89)
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
        Me.Btn_Credito.Location = New System.Drawing.Point(237, 52)
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
        Me.Btn_Efectivo.Location = New System.Drawing.Point(237, 15)
        Me.Btn_Efectivo.Name = "Btn_Efectivo"
        Me.Btn_Efectivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Efectivo.Size = New System.Drawing.Size(57, 31)
        Me.Btn_Efectivo.TabIndex = 1
        Me.Btn_Efectivo.Text = "F8"
        Me.Btn_Efectivo.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Btn_Efectivo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Cambio: $"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 23)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Recibí: $"
        '
        'groupBox1
        '
        Me.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.LblTotal)
        Me.groupBox1.Controls.Add(Me.LblIva)
        Me.groupBox1.Controls.Add(Me.LblSubTotal)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.Black
        Me.groupBox1.Location = New System.Drawing.Point(679, 191)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(312, 213)
        Me.groupBox1.TabIndex = 353
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = " Detalle de importe "
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.Black
        Me.LblTotal.Location = New System.Drawing.Point(170, 150)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(72, 23)
        Me.LblTotal.TabIndex = 5
        Me.LblTotal.Text = "$ 0.00"
        '
        'LblIva
        '
        Me.LblIva.AutoSize = True
        Me.LblIva.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIva.ForeColor = System.Drawing.Color.Black
        Me.LblIva.Location = New System.Drawing.Point(170, 101)
        Me.LblIva.Name = "LblIva"
        Me.LblIva.Size = New System.Drawing.Size(72, 23)
        Me.LblIva.TabIndex = 4
        Me.LblIva.Text = "$ 0.00"
        '
        'LblSubTotal
        '
        Me.LblSubTotal.AutoSize = True
        Me.LblSubTotal.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTotal.ForeColor = System.Drawing.Color.Black
        Me.LblSubTotal.Location = New System.Drawing.Point(170, 53)
        Me.LblSubTotal.Name = "LblSubTotal"
        Me.LblSubTotal.Size = New System.Drawing.Size(72, 23)
        Me.LblSubTotal.TabIndex = 3
        Me.LblSubTotal.Text = "$ 0.00"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(71, 150)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(67, 23)
        Me.label4.TabIndex = 2
        Me.label4.Text = "Total:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(85, 101)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(53, 23)
        Me.label3.TabIndex = 1
        Me.label3.Text = "IVA:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(39, 53)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(99, 23)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Subtotal:"
        '
        'CancelarVenta
        '
        Me.CancelarVenta.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CancelarVenta.Enabled = False
        Me.CancelarVenta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelarVenta.Image = CType(resources.GetObject("CancelarVenta.Image"), System.Drawing.Image)
        Me.CancelarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelarVenta.Location = New System.Drawing.Point(904, 442)
        Me.CancelarVenta.Name = "CancelarVenta"
        Me.CancelarVenta.Size = New System.Drawing.Size(87, 51)
        Me.CancelarVenta.TabIndex = 351
        Me.CancelarVenta.Text = "F12"
        Me.CancelarVenta.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.CancelarVenta.UseVisualStyleBackColor = True
        '
        'AceptarVenta
        '
        Me.AceptarVenta.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AceptarVenta.Enabled = False
        Me.AceptarVenta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AceptarVenta.Image = CType(resources.GetObject("AceptarVenta.Image"), System.Drawing.Image)
        Me.AceptarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AceptarVenta.Location = New System.Drawing.Point(811, 442)
        Me.AceptarVenta.Name = "AceptarVenta"
        Me.AceptarVenta.Size = New System.Drawing.Size(87, 51)
        Me.AceptarVenta.TabIndex = 350
        Me.AceptarVenta.Text = "    F11"
        Me.AceptarVenta.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AceptarVenta.UseVisualStyleBackColor = True
        '
        'lblhora
        '
        Me.lblhora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblhora.AutoEllipsis = True
        Me.lblhora.BackColor = System.Drawing.Color.Transparent
        Me.lblhora.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.Location = New System.Drawing.Point(382, 675)
        Me.lblhora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(110, 24)
        Me.lblhora.TabIndex = 351
        Me.lblhora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.AutoEllipsis = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(65, 675)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(254, 24)
        Me.lblFecha.TabIndex = 350
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label16.Location = New System.Drawing.Point(431, 8)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(73, 16)
        Me.label16.TabIndex = 25
        Me.label16.Text = "Cantidad"
        '
        'ModuloVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 708)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.GroupBoxPagos)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.CancelarVenta)
        Me.Controls.Add(Me.CantidadNumericUpDown)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.AceptarVenta)
        Me.Controls.Add(Me.toolStrip1)
        Me.Controls.Add(Me.GridDatos)
        Me.Controls.Add(Me.label16)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Codigo_Producto)
        Me.Controls.Add(Me.Agregar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.KeyPreview = True
        Me.Name = "ModuloVentas"
        Me.Text = "ModuloVentas"
        CType(Me.CantidadNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.GroupBoxPagos.ResumeLayout(False)
        Me.GroupBoxPagos.PerformLayout()
        CType(Me.NumericUpDownPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Agregar As System.Windows.Forms.Button
    Private WithEvents Codigo_Producto As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents ChecarPrecio As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButton3 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButton4 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButton5 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridDatos As SourceGrid.DataGrid
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CantidadNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBoxPagos As System.Windows.Forms.GroupBox
    Private WithEvents Btn_Factura As System.Windows.Forms.Button
    Private WithEvents Btn_Credito As System.Windows.Forms.Button
    Private WithEvents Btn_Efectivo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents LblTotal As System.Windows.Forms.Label
    Private WithEvents LblIva As System.Windows.Forms.Label
    Private WithEvents LblSubTotal As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents CancelarVenta As System.Windows.Forms.Button
    Private WithEvents AceptarVenta As System.Windows.Forms.Button
    Friend WithEvents LblCambio As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents label16 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownPago As System.Windows.Forms.NumericUpDown
End Class
