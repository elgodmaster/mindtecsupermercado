<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movimiento_Entradas
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Movimiento_Entradas))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Limpiar = New System.Windows.Forms.ToolStripButton
        Me.Nuevo = New System.Windows.Forms.ToolStripButton
        Me.Grabar = New System.Windows.Forms.ToolStripButton
        Me.Barra = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.FolioEntrada = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.GroupBoxEntrada = New System.Windows.Forms.GroupBox
        Me.NombreProveedor = New System.Windows.Forms.Label
        Me.CodigoProveedor = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.EntradaDetalles = New SourceGrid.DataGrid
        Me.txtFactura = New System.Windows.Forms.TextBox
        Me.Fecha = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PiePagina = New System.Windows.Forms.StatusStrip
        Me.MensajePiePagina = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxEntrada.SuspendLayout()
        Me.PiePagina.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Limpiar, Me.Nuevo, Me.Grabar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1016, 52)
        Me.ToolStrip1.TabIndex = 2
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
        Me.Nuevo.Size = New System.Drawing.Size(36, 49)
        Me.Nuevo.Text = "Nuevo"
        '
        'Grabar
        '
        Me.Grabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Grabar.Image = CType(resources.GetObject("Grabar.Image"), System.Drawing.Image)
        Me.Grabar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Grabar.Name = "Grabar"
        Me.Grabar.Size = New System.Drawing.Size(36, 49)
        Me.Grabar.Text = "Grabar"
        '
        'Barra
        '
        Me.Barra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Barra.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Barra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Barra.Location = New System.Drawing.Point(-4, 138)
        Me.Barra.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(1096, 4)
        Me.Barra.TabIndex = 220
        Me.Barra.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 62)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 230
        Me.Label4.Text = "Entradas"
        '
        'FolioEntrada
        '
        Me.FolioEntrada.BackColor = System.Drawing.SystemColors.Info
        Me.FolioEntrada.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FolioEntrada.Location = New System.Drawing.Point(74, 101)
        Me.FolioEntrada.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FolioEntrada.MaxLength = 9
        Me.FolioEntrada.Name = "FolioEntrada"
        Me.FolioEntrada.Size = New System.Drawing.Size(108, 22)
        Me.FolioEntrada.TabIndex = 229
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 104)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 14)
        Me.Label1.TabIndex = 228
        Me.Label1.Text = "Código"
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.btnAceptar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(900, 98)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 27)
        Me.btnAceptar.TabIndex = 231
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'GroupBoxEntrada
        '
        Me.GroupBoxEntrada.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxEntrada.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxEntrada.Controls.Add(Me.NombreProveedor)
        Me.GroupBoxEntrada.Controls.Add(Me.CodigoProveedor)
        Me.GroupBoxEntrada.Controls.Add(Me.Label3)
        Me.GroupBoxEntrada.Controls.Add(Me.EntradaDetalles)
        Me.GroupBoxEntrada.Controls.Add(Me.txtFactura)
        Me.GroupBoxEntrada.Controls.Add(Me.Fecha)
        Me.GroupBoxEntrada.Controls.Add(Me.Label5)
        Me.GroupBoxEntrada.Controls.Add(Me.Label2)
        Me.GroupBoxEntrada.Location = New System.Drawing.Point(19, 159)
        Me.GroupBoxEntrada.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxEntrada.Name = "GroupBoxEntrada"
        Me.GroupBoxEntrada.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxEntrada.Size = New System.Drawing.Size(984, 530)
        Me.GroupBoxEntrada.TabIndex = 232
        Me.GroupBoxEntrada.TabStop = False
        Me.GroupBoxEntrada.Text = "Datos de Entrada"
        '
        'NombreProveedor
        '
        Me.NombreProveedor.AutoEllipsis = True
        Me.NombreProveedor.BackColor = System.Drawing.Color.Transparent
        Me.NombreProveedor.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreProveedor.Location = New System.Drawing.Point(193, 49)
        Me.NombreProveedor.Name = "NombreProveedor"
        Me.NombreProveedor.Size = New System.Drawing.Size(755, 22)
        Me.NombreProveedor.TabIndex = 226
        Me.NombreProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CodigoProveedor
        '
        Me.CodigoProveedor.BackColor = System.Drawing.SystemColors.Info
        Me.CodigoProveedor.Location = New System.Drawing.Point(103, 49)
        Me.CodigoProveedor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CodigoProveedor.Name = "CodigoProveedor"
        Me.CodigoProveedor.Size = New System.Drawing.Size(83, 22)
        Me.CodigoProveedor.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(18, 53)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Proveedor:"
        '
        'EntradaDetalles
        '
        Me.EntradaDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EntradaDetalles.DeleteQuestionMessage = "Are you sure to delete all the selected rows?"
        Me.EntradaDetalles.FixedRows = 1
        Me.EntradaDetalles.Location = New System.Drawing.Point(15, 104)
        Me.EntradaDetalles.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EntradaDetalles.Name = "EntradaDetalles"
        Me.EntradaDetalles.SelectionMode = SourceGrid.GridSelectionMode.Row
        Me.EntradaDetalles.Size = New System.Drawing.Size(951, 420)
        Me.EntradaDetalles.TabIndex = 6
        Me.EntradaDetalles.TabStop = True
        Me.EntradaDetalles.ToolTipText = ""
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(103, 77)
        Me.txtFactura.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(265, 22)
        Me.txtFactura.TabIndex = 5
        '
        'Fecha
        '
        Me.Fecha.Location = New System.Drawing.Point(103, 21)
        Me.Fecha.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(265, 22)
        Me.Fecha.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(36, 81)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Factura:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(46, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha:"
        '
        'PiePagina
        '
        Me.PiePagina.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PiePagina.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PiePagina.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MensajePiePagina})
        Me.PiePagina.Location = New System.Drawing.Point(0, 694)
        Me.PiePagina.Name = "PiePagina"
        Me.PiePagina.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.PiePagina.Size = New System.Drawing.Size(1016, 22)
        Me.PiePagina.SizingGrip = False
        Me.PiePagina.TabIndex = 233
        Me.PiePagina.Text = "StatusStrip1"
        '
        'MensajePiePagina
        '
        Me.MensajePiePagina.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MensajePiePagina.Name = "MensajePiePagina"
        Me.MensajePiePagina.Size = New System.Drawing.Size(150, 17)
        Me.MensajePiePagina.Text = "ToolStripStatusLabel1"
        '
        'Movimiento_Entradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 716)
        Me.Controls.Add(Me.PiePagina)
        Me.Controls.Add(Me.GroupBoxEntrada)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FolioEntrada)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Movimiento_Entradas"
        Me.Text = "Entradas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxEntrada.ResumeLayout(False)
        Me.GroupBoxEntrada.PerformLayout()
        Me.PiePagina.ResumeLayout(False)
        Me.PiePagina.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Limpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Barra As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FolioEntrada As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBoxEntrada As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents EntradaDetalles As SourceGrid.DataGrid
    Friend WithEvents PiePagina As System.Windows.Forms.StatusStrip
    Friend WithEvents MensajePiePagina As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents CodigoProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NombreProveedor As System.Windows.Forms.Label
End Class
