<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventarioEntradas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventarioEntradas))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Limpiar = New System.Windows.Forms.ToolStripButton
        Me.Nuevo = New System.Windows.Forms.ToolStripButton
        Me.Grabar = New System.Windows.Forms.ToolStripButton
        Me.Eliminar = New System.Windows.Forms.ToolStripButton
        Me.PiePagina = New System.Windows.Forms.StatusStrip
        Me.MensajePiePagina = New System.Windows.Forms.ToolStripStatusLabel
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.FolioEntrada = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.NombreProveedor = New System.Windows.Forms.Label
        Me.CodigoProveedor = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFactura = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Fecha = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GridDatos = New SourceGrid.DataGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Barra = New System.Windows.Forms.PictureBox
        Me.ToolStrip1.SuspendLayout()
        Me.PiePagina.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Limpiar, Me.Nuevo, Me.Grabar, Me.Eliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 48)
        Me.ToolStrip1.TabIndex = 230
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
        'Nuevo
        '
        Me.Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Nuevo.Image = CType(resources.GetObject("Nuevo.Image"), System.Drawing.Image)
        Me.Nuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(36, 45)
        Me.Nuevo.Text = "Nuevo"
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
        Me.Eliminar.Size = New System.Drawing.Size(38, 45)
        Me.Eliminar.Text = "ToolStripButton1"
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
        Me.PiePagina.TabIndex = 229
        Me.PiePagina.Text = "StatusStrip1"
        '
        'MensajePiePagina
        '
        Me.MensajePiePagina.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MensajePiePagina.Name = "MensajePiePagina"
        Me.MensajePiePagina.Size = New System.Drawing.Size(150, 17)
        Me.MensajePiePagina.Text = "ToolStripStatusLabel1"
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.btnAceptar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(900, 93)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 27)
        Me.btnAceptar.TabIndex = 236
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 57)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 235
        Me.Label4.Text = "Entradas"
        '
        'FolioEntrada
        '
        Me.FolioEntrada.BackColor = System.Drawing.SystemColors.Info
        Me.FolioEntrada.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FolioEntrada.Location = New System.Drawing.Point(74, 96)
        Me.FolioEntrada.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FolioEntrada.MaxLength = 9
        Me.FolioEntrada.Name = "FolioEntrada"
        Me.FolioEntrada.Size = New System.Drawing.Size(108, 22)
        Me.FolioEntrada.TabIndex = 234
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 99)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 14)
        Me.Label1.TabIndex = 233
        Me.Label1.Text = "Código"
        '
        'NombreProveedor
        '
        Me.NombreProveedor.AutoEllipsis = True
        Me.NombreProveedor.BackColor = System.Drawing.Color.Transparent
        Me.NombreProveedor.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreProveedor.Location = New System.Drawing.Point(181, 66)
        Me.NombreProveedor.Name = "NombreProveedor"
        Me.NombreProveedor.Size = New System.Drawing.Size(755, 22)
        Me.NombreProveedor.TabIndex = 242
        Me.NombreProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CodigoProveedor
        '
        Me.CodigoProveedor.BackColor = System.Drawing.SystemColors.Info
        Me.CodigoProveedor.Location = New System.Drawing.Point(91, 66)
        Me.CodigoProveedor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CodigoProveedor.Name = "CodigoProveedor"
        Me.CodigoProveedor.Size = New System.Drawing.Size(83, 22)
        Me.CodigoProveedor.TabIndex = 241
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 14)
        Me.Label3.TabIndex = 240
        Me.Label3.Text = "Proveedor:"
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(91, 94)
        Me.txtFactura.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(262, 22)
        Me.txtFactura.TabIndex = 239
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(24, 98)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 14)
        Me.Label5.TabIndex = 238
        Me.Label5.Text = "Factura:"
        '
        'Fecha
        '
        Me.Fecha.Location = New System.Drawing.Point(91, 38)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(262, 22)
        Me.Fecha.TabIndex = 243
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(34, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 14)
        Me.Label2.TabIndex = 244
        Me.Label2.Text = "Fecha:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.Fecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtFactura)
        Me.GroupBox1.Controls.Add(Me.NombreProveedor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CodigoProveedor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(985, 534)
        Me.GroupBox1.TabIndex = 245
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entrada inventario"
        Me.GroupBox1.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(15, 134)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(958, 394)
        Me.TabControl1.TabIndex = 245
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GridDatos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(950, 367)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Productos"
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
        Me.GridDatos.Location = New System.Drawing.Point(6, 6)
        Me.GridDatos.Name = "GridDatos"
        Me.GridDatos.SelectionMode = SourceGrid.GridSelectionMode.Row
        Me.GridDatos.Size = New System.Drawing.Size(925, 363)
        Me.GridDatos.TabIndex = 5
        Me.GridDatos.TabStop = True
        Me.GridDatos.ToolTipText = ""
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(950, 359)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Finanzas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Barra
        '
        Me.Barra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Barra.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Barra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Barra.Location = New System.Drawing.Point(0, 129)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(1028, 4)
        Me.Barra.TabIndex = 246
        Me.Barra.TabStop = False
        '
        'InventarioEntradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 708)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FolioEntrada)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PiePagina)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "InventarioEntradas"
        Me.Text = "Inventario Entradas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.PiePagina.ResumeLayout(False)
        Me.PiePagina.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Limpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PiePagina As System.Windows.Forms.StatusStrip
    Friend WithEvents MensajePiePagina As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FolioEntrada As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NombreProveedor As System.Windows.Forms.Label
    Friend WithEvents CodigoProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GridDatos As SourceGrid.DataGrid
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Barra As System.Windows.Forms.PictureBox
End Class
