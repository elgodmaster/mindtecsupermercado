<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturacion
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturacion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Factura = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GridDatos = New SourceGrid.DataGrid
        Me.Label14 = New System.Windows.Forms.Label
        Me.Txt_Cantidad = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.LblProducto = New System.Windows.Forms.Label
        Me.Txt_CodigoProducto = New System.Windows.Forms.TextBox
        Me.TOTAL = New System.Windows.Forms.Label
        Me.IVA = New System.Windows.Forms.Label
        Me.Neto = New System.Windows.Forms.Label
        Me.LTotal = New System.Windows.Forms.Label
        Me.LIVA = New System.Windows.Forms.Label
        Me.LNETO = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.chbGenerar = New System.Windows.Forms.CheckBox
        Me.CodigoCotizacion = New System.Windows.Forms.TextBox
        Me.lblTC = New System.Windows.Forms.Label
        Me.txtDescuento = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBoxDatosCliente = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblRFCCliente = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CodigoCliente = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblCiudadCliente = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblEstadoCliente = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblDireccionCliente = New System.Windows.Forms.Label
        Me.lblNombreCliente = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LblNombres = New System.Windows.Forms.Label
        Me.Barra = New System.Windows.Forms.PictureBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Limpiar = New System.Windows.Forms.ToolStripButton
        Me.Grabar = New System.Windows.Forms.ToolStripButton
        Me.Impresion = New System.Windows.Forms.ToolStripButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNoFactura = New System.Windows.Forms.TextBox
        Me.PiePagina = New System.Windows.Forms.StatusStrip
        Me.MensajePiePagina = New System.Windows.Forms.ToolStripStatusLabel
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.Factura.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBoxDatosCliente.SuspendLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.PiePagina.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Factura)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.chbGenerar)
        Me.GroupBox1.Controls.Add(Me.CodigoCotizacion)
        Me.GroupBox1.Controls.Add(Me.lblTC)
        Me.GroupBox1.Controls.Add(Me.txtDescuento)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.GroupBoxDatosCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(972, 545)
        Me.GroupBox1.TabIndex = 327
        Me.GroupBox1.TabStop = False
        '
        'Factura
        '
        Me.Factura.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Factura.Controls.Add(Me.TabPage1)
        Me.Factura.Controls.Add(Me.TabPage2)
        Me.Factura.Location = New System.Drawing.Point(3, 194)
        Me.Factura.Name = "Factura"
        Me.Factura.SelectedIndex = 0
        Me.Factura.Size = New System.Drawing.Size(963, 340)
        Me.Factura.TabIndex = 333
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GridDatos)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Txt_Cantidad)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.LblProducto)
        Me.TabPage1.Controls.Add(Me.Txt_CodigoProducto)
        Me.TabPage1.Controls.Add(Me.TOTAL)
        Me.TabPage1.Controls.Add(Me.IVA)
        Me.TabPage1.Controls.Add(Me.Neto)
        Me.TabPage1.Controls.Add(Me.LTotal)
        Me.TabPage1.Controls.Add(Me.LIVA)
        Me.TabPage1.Controls.Add(Me.LNETO)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(955, 311)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Factura"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GridDatos
        '
        Me.GridDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GridDatos.DeleteQuestionMessage = ""
        Me.GridDatos.DeleteRowsWithDeleteKey = False
        Me.GridDatos.FixedRows = 1
        Me.GridDatos.Location = New System.Drawing.Point(11, 34)
        Me.GridDatos.Name = "GridDatos"
        Me.GridDatos.SelectionMode = SourceGrid.GridSelectionMode.Row
        Me.GridDatos.Size = New System.Drawing.Size(929, 199)
        Me.GridDatos.TabIndex = 350
        Me.GridDatos.TabStop = True
        Me.GridDatos.ToolTipText = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(754, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 16)
        Me.Label14.TabIndex = 349
        Me.Label14.Text = "Cantidad"
        '
        'Txt_Cantidad
        '
        Me.Txt_Cantidad.Location = New System.Drawing.Point(822, 5)
        Me.Txt_Cantidad.Name = "Txt_Cantidad"
        Me.Txt_Cantidad.Size = New System.Drawing.Size(128, 23)
        Me.Txt_Cantidad.TabIndex = 348
        Me.Txt_Cantidad.Text = "00000000000.00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 16)
        Me.Label15.TabIndex = 347
        Me.Label15.Text = "Producto"
        '
        'LblProducto
        '
        Me.LblProducto.AutoEllipsis = True
        Me.LblProducto.BackColor = System.Drawing.Color.Transparent
        Me.LblProducto.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProducto.Location = New System.Drawing.Point(204, 5)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(457, 22)
        Me.LblProducto.TabIndex = 346
        Me.LblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_CodigoProducto
        '
        Me.Txt_CodigoProducto.Location = New System.Drawing.Point(70, 5)
        Me.Txt_CodigoProducto.Name = "Txt_CodigoProducto"
        Me.Txt_CodigoProducto.Size = New System.Drawing.Size(128, 23)
        Me.Txt_CodigoProducto.TabIndex = 345
        Me.Txt_CodigoProducto.Text = "123456789012345"
        '
        'TOTAL
        '
        Me.TOTAL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TOTAL.AutoEllipsis = True
        Me.TOTAL.BackColor = System.Drawing.Color.Transparent
        Me.TOTAL.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTAL.Location = New System.Drawing.Point(789, 288)
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.Size = New System.Drawing.Size(160, 22)
        Me.TOTAL.TabIndex = 344
        Me.TOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IVA
        '
        Me.IVA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IVA.AutoEllipsis = True
        Me.IVA.BackColor = System.Drawing.Color.Transparent
        Me.IVA.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IVA.Location = New System.Drawing.Point(789, 258)
        Me.IVA.Name = "IVA"
        Me.IVA.Size = New System.Drawing.Size(160, 22)
        Me.IVA.TabIndex = 343
        Me.IVA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Neto
        '
        Me.Neto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Neto.AutoEllipsis = True
        Me.Neto.BackColor = System.Drawing.Color.Transparent
        Me.Neto.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Neto.Location = New System.Drawing.Point(789, 232)
        Me.Neto.Name = "Neto"
        Me.Neto.Size = New System.Drawing.Size(160, 22)
        Me.Neto.TabIndex = 342
        Me.Neto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LTotal
        '
        Me.LTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LTotal.AutoSize = True
        Me.LTotal.BackColor = System.Drawing.Color.Transparent
        Me.LTotal.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotal.Location = New System.Drawing.Point(673, 292)
        Me.LTotal.Name = "LTotal"
        Me.LTotal.Size = New System.Drawing.Size(103, 14)
        Me.LTotal.TabIndex = 341
        Me.LTotal.Text = "Total a facturar"
        '
        'LIVA
        '
        Me.LIVA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LIVA.AutoSize = True
        Me.LIVA.BackColor = System.Drawing.Color.Transparent
        Me.LIVA.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIVA.Location = New System.Drawing.Point(732, 262)
        Me.LIVA.Name = "LIVA"
        Me.LIVA.Size = New System.Drawing.Size(44, 14)
        Me.LIVA.TabIndex = 340
        Me.LIVA.Text = "I.V.A. "
        '
        'LNETO
        '
        Me.LNETO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LNETO.AutoSize = True
        Me.LNETO.BackColor = System.Drawing.Color.Transparent
        Me.LNETO.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNETO.Location = New System.Drawing.Point(716, 236)
        Me.LNETO.Name = "LNETO"
        Me.LNETO.Size = New System.Drawing.Size(60, 14)
        Me.LNETO.TabIndex = 339
        Me.LNETO.Text = "Subtotal"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(955, 311)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 17)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(95, 20)
        Me.CheckBox1.TabIndex = 332
        Me.CheckBox1.Text = "Cotizacion"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'chbGenerar
        '
        Me.chbGenerar.AutoSize = True
        Me.chbGenerar.Checked = True
        Me.chbGenerar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbGenerar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbGenerar.Location = New System.Drawing.Point(836, 18)
        Me.chbGenerar.Name = "chbGenerar"
        Me.chbGenerar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chbGenerar.Size = New System.Drawing.Size(130, 18)
        Me.chbGenerar.TabIndex = 331
        Me.chbGenerar.Text = "Generar Salidas "
        Me.chbGenerar.UseVisualStyleBackColor = True
        '
        'CodigoCotizacion
        '
        Me.CodigoCotizacion.BackColor = System.Drawing.SystemColors.Info
        Me.CodigoCotizacion.Location = New System.Drawing.Point(103, 16)
        Me.CodigoCotizacion.Name = "CodigoCotizacion"
        Me.CodigoCotizacion.Size = New System.Drawing.Size(115, 23)
        Me.CodigoCotizacion.TabIndex = 4
        Me.CodigoCotizacion.Visible = False
        '
        'lblTC
        '
        Me.lblTC.AutoSize = True
        Me.lblTC.BackColor = System.Drawing.Color.Transparent
        Me.lblTC.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTC.Location = New System.Drawing.Point(243, 46)
        Me.lblTC.Name = "lblTC"
        Me.lblTC.Size = New System.Drawing.Size(0, 14)
        Me.lblTC.TabIndex = 329
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(766, 16)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(55, 23)
        Me.txtDescuento.TabIndex = 7
        Me.txtDescuento.Text = "16"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(723, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 14)
        Me.Label10.TabIndex = 327
        Me.Label10.Text = "IVA: "
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(506, 16)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 23)
        Me.dtpFecha.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(451, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 14)
        Me.Label7.TabIndex = 323
        Me.Label7.Text = "Fecha:"
        '
        'GroupBoxDatosCliente
        '
        Me.GroupBoxDatosCliente.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label12)
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label13)
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label8)
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label11)
        Me.GroupBoxDatosCliente.Controls.Add(Me.lblRFCCliente)
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label3)
        Me.GroupBoxDatosCliente.Controls.Add(Me.CodigoCliente)
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label1)
        Me.GroupBoxDatosCliente.Controls.Add(Me.lblCiudadCliente)
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label2)
        Me.GroupBoxDatosCliente.Controls.Add(Me.lblEstadoCliente)
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label9)
        Me.GroupBoxDatosCliente.Controls.Add(Me.lblDireccionCliente)
        Me.GroupBoxDatosCliente.Controls.Add(Me.lblNombreCliente)
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label5)
        Me.GroupBoxDatosCliente.Controls.Add(Me.LblNombres)
        Me.GroupBoxDatosCliente.Location = New System.Drawing.Point(2, 42)
        Me.GroupBoxDatosCliente.Name = "GroupBoxDatosCliente"
        Me.GroupBoxDatosCliente.Size = New System.Drawing.Size(969, 146)
        Me.GroupBoxDatosCliente.TabIndex = 313
        Me.GroupBoxDatosCliente.TabStop = False
        Me.GroupBoxDatosCliente.Text = "Datos del cliente"
        '
        'Label12
        '
        Me.Label12.AutoEllipsis = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(823, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 22)
        Me.Label12.TabIndex = 296
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(790, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 14)
        Me.Label13.TabIndex = 295
        Me.Label13.Text = "CP:"
        Me.Label13.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoEllipsis = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(532, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(244, 22)
        Me.Label8.TabIndex = 294
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(460, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 14)
        Me.Label11.TabIndex = 293
        Me.Label11.Text = "Colonia:"
        Me.Label11.Visible = False
        '
        'lblRFCCliente
        '
        Me.lblRFCCliente.AutoEllipsis = True
        Me.lblRFCCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblRFCCliente.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRFCCliente.Location = New System.Drawing.Point(70, 41)
        Me.lblRFCCliente.Name = "lblRFCCliente"
        Me.lblRFCCliente.Size = New System.Drawing.Size(388, 22)
        Me.lblRFCCliente.TabIndex = 292
        Me.lblRFCCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblRFCCliente.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 14)
        Me.Label3.TabIndex = 291
        Me.Label3.Text = "RFC:"
        Me.Label3.Visible = False
        '
        'CodigoCliente
        '
        Me.CodigoCliente.BackColor = System.Drawing.SystemColors.Info
        Me.CodigoCliente.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoCliente.Location = New System.Drawing.Point(67, 19)
        Me.CodigoCliente.MaxLength = 9
        Me.CodigoCliente.Name = "CodigoCliente"
        Me.CodigoCliente.Size = New System.Drawing.Size(115, 22)
        Me.CodigoCliente.TabIndex = 289
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 14)
        Me.Label1.TabIndex = 290
        Me.Label1.Text = "Cliente"
        '
        'lblCiudadCliente
        '
        Me.lblCiudadCliente.AutoEllipsis = True
        Me.lblCiudadCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblCiudadCliente.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiudadCliente.Location = New System.Drawing.Point(520, 118)
        Me.lblCiudadCliente.Name = "lblCiudadCliente"
        Me.lblCiudadCliente.Size = New System.Drawing.Size(371, 22)
        Me.lblCiudadCliente.TabIndex = 288
        Me.lblCiudadCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCiudadCliente.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(463, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 14)
        Me.Label2.TabIndex = 287
        Me.Label2.Text = "Ciudad:"
        Me.Label2.Visible = False
        '
        'lblEstadoCliente
        '
        Me.lblEstadoCliente.AutoEllipsis = True
        Me.lblEstadoCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblEstadoCliente.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCliente.Location = New System.Drawing.Point(70, 118)
        Me.lblEstadoCliente.Name = "lblEstadoCliente"
        Me.lblEstadoCliente.Size = New System.Drawing.Size(380, 22)
        Me.lblEstadoCliente.TabIndex = 286
        Me.lblEstadoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblEstadoCliente.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 14)
        Me.Label9.TabIndex = 285
        Me.Label9.Text = "Estado:"
        Me.Label9.Visible = False
        '
        'lblDireccionCliente
        '
        Me.lblDireccionCliente.AutoEllipsis = True
        Me.lblDireccionCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblDireccionCliente.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionCliente.Location = New System.Drawing.Point(70, 91)
        Me.lblDireccionCliente.Name = "lblDireccionCliente"
        Me.lblDireccionCliente.Size = New System.Drawing.Size(371, 22)
        Me.lblDireccionCliente.TabIndex = 282
        Me.lblDireccionCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDireccionCliente.Visible = False
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoEllipsis = True
        Me.lblNombreCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCliente.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCliente.Location = New System.Drawing.Point(70, 63)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(852, 22)
        Me.lblNombreCliente.TabIndex = 281
        Me.lblNombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNombreCliente.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-2, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 14)
        Me.Label5.TabIndex = 278
        Me.Label5.Text = "Dirección:"
        Me.Label5.Visible = False
        '
        'LblNombres
        '
        Me.LblNombres.AutoSize = True
        Me.LblNombres.BackColor = System.Drawing.Color.Transparent
        Me.LblNombres.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombres.Location = New System.Drawing.Point(5, 67)
        Me.LblNombres.Name = "LblNombres"
        Me.LblNombres.Size = New System.Drawing.Size(61, 14)
        Me.LblNombres.TabIndex = 268
        Me.LblNombres.Text = "Nombre:"
        Me.LblNombres.Visible = False
        '
        'Barra
        '
        Me.Barra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Barra.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Barra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Barra.Location = New System.Drawing.Point(0, 120)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(1024, 4)
        Me.Barra.TabIndex = 326
        Me.Barra.TabStop = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.btnAceptar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnAceptar.Location = New System.Drawing.Point(899, 87)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(80, 25)
        Me.btnAceptar.TabIndex = 323
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 325
        Me.Label4.Text = "Factura"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Limpiar, Me.Grabar, Me.Impresion})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 48)
        Me.ToolStrip1.TabIndex = 324
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
        'Impresion
        '
        Me.Impresion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Impresion.Image = CType(resources.GetObject("Impresion.Image"), System.Drawing.Image)
        Me.Impresion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Impresion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Impresion.Name = "Impresion"
        Me.Impresion.Size = New System.Drawing.Size(52, 45)
        Me.Impresion.Text = "Imprimir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 14)
        Me.Label6.TabIndex = 328
        Me.Label6.Text = "Numero De Factura: "
        '
        'txtNoFactura
        '
        Me.txtNoFactura.BackColor = System.Drawing.SystemColors.Info
        Me.txtNoFactura.Location = New System.Drawing.Point(155, 88)
        Me.txtNoFactura.Name = "txtNoFactura"
        Me.txtNoFactura.Size = New System.Drawing.Size(115, 23)
        Me.txtNoFactura.TabIndex = 322
        '
        'PiePagina
        '
        Me.PiePagina.BackColor = System.Drawing.SystemColors.Info
        Me.PiePagina.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PiePagina.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MensajePiePagina})
        Me.PiePagina.Location = New System.Drawing.Point(0, 686)
        Me.PiePagina.Name = "PiePagina"
        Me.PiePagina.Size = New System.Drawing.Size(1008, 22)
        Me.PiePagina.SizingGrip = False
        Me.PiePagina.TabIndex = 329
        Me.PiePagina.Text = "StatusStrip1"
        '
        'MensajePiePagina
        '
        Me.MensajePiePagina.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MensajePiePagina.Name = "MensajePiePagina"
        Me.MensajePiePagina.Size = New System.Drawing.Size(150, 17)
        Me.MensajePiePagina.Text = "ToolStripStatusLabel1"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(225, 17)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(66, 20)
        Me.CheckBox2.TabIndex = 335
        Me.CheckBox2.Text = "Venta"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(288, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(115, 23)
        Me.TextBox1.TabIndex = 334
        Me.TextBox1.Visible = False
        '
        'Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 708)
        Me.Controls.Add(Me.PiePagina)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNoFactura)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Facturacion"
        Me.Text = "Facturacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Factura.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBoxDatosCliente.ResumeLayout(False)
        Me.GroupBoxDatosCliente.PerformLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.PiePagina.ResumeLayout(False)
        Me.PiePagina.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chbGenerar As System.Windows.Forms.CheckBox
    Friend WithEvents CodigoCotizacion As System.Windows.Forms.TextBox
    Friend WithEvents lblTC As System.Windows.Forms.Label
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxDatosCliente As System.Windows.Forms.GroupBox
    Friend WithEvents lblEstadoCliente As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblDireccionCliente As System.Windows.Forms.Label
    Friend WithEvents lblNombreCliente As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblNombres As System.Windows.Forms.Label
    Friend WithEvents Barra As System.Windows.Forms.PictureBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Impresion As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNoFactura As System.Windows.Forms.TextBox
    Friend WithEvents lblCiudadCliente As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblRFCCliente As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CodigoCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PiePagina As System.Windows.Forms.StatusStrip
    Friend WithEvents MensajePiePagina As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Limpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Factura As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Txt_Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LblProducto As System.Windows.Forms.Label
    Friend WithEvents Txt_CodigoProducto As System.Windows.Forms.TextBox
    Friend WithEvents TOTAL As System.Windows.Forms.Label
    Friend WithEvents IVA As System.Windows.Forms.Label
    Friend WithEvents Neto As System.Windows.Forms.Label
    Friend WithEvents LTotal As System.Windows.Forms.Label
    Friend WithEvents LIVA As System.Windows.Forms.Label
    Friend WithEvents LNETO As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GridDatos As SourceGrid.DataGrid
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
