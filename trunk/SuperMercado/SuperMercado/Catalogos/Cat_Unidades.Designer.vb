<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cat_Unidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cat_Unidades))
        Me.GroupBoxDetalles = New System.Windows.Forms.GroupBox
        Me.TxtDescripcion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Barra = New System.Windows.Forms.PictureBox
        Me.CodigoUnidades = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PiePagina = New System.Windows.Forms.StatusStrip
        Me.MensajePiePagina = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Limpiar = New System.Windows.Forms.ToolStripButton
        Me.Nuevo = New System.Windows.Forms.ToolStripButton
        Me.Grabar = New System.Windows.Forms.ToolStripButton
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.NombreUnidades = New System.Windows.Forms.Label
        Me.GroupBoxDetalles.SuspendLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PiePagina.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxDetalles
        '
        Me.GroupBoxDetalles.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxDetalles.Controls.Add(Me.TxtDescripcion)
        Me.GroupBoxDetalles.Controls.Add(Me.Label2)
        Me.GroupBoxDetalles.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDetalles.Location = New System.Drawing.Point(14, 148)
        Me.GroupBoxDetalles.Name = "GroupBoxDetalles"
        Me.GroupBoxDetalles.Size = New System.Drawing.Size(973, 511)
        Me.GroupBoxDetalles.TabIndex = 231
        Me.GroupBoxDetalles.TabStop = False
        Me.GroupBoxDetalles.Text = "Datos de la unidad"
        Me.GroupBoxDetalles.Visible = False
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.Location = New System.Drawing.Point(101, 44)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(866, 22)
        Me.TxtDescripcion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 14)
        Me.Label2.TabIndex = 220
        Me.Label2.Text = "Descripción"
        '
        'Barra
        '
        Me.Barra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Barra.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Barra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Barra.Location = New System.Drawing.Point(-6, 128)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(1024, 4)
        Me.Barra.TabIndex = 230
        Me.Barra.TabStop = False
        '
        'CodigoUnidades
        '
        Me.CodigoUnidades.BackColor = System.Drawing.SystemColors.Info
        Me.CodigoUnidades.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoUnidades.Location = New System.Drawing.Point(79, 93)
        Me.CodigoUnidades.MaxLength = 9
        Me.CodigoUnidades.Name = "CodigoUnidades"
        Me.CodigoUnidades.Size = New System.Drawing.Size(82, 22)
        Me.CodigoUnidades.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 14)
        Me.Label1.TabIndex = 228
        Me.Label1.Text = "Unidad"
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
        Me.PiePagina.TabIndex = 227
        Me.PiePagina.Text = "StatusStrip1"
        '
        'MensajePiePagina
        '
        Me.MensajePiePagina.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MensajePiePagina.Name = "MensajePiePagina"
        Me.MensajePiePagina.Size = New System.Drawing.Size(150, 17)
        Me.MensajePiePagina.Text = "ToolStripStatusLabel1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Limpiar, Me.Nuevo, Me.Grabar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1016, 48)
        Me.ToolStrip1.TabIndex = 226
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
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(914, 91)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(80, 25)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 20)
        Me.Label3.TabIndex = 232
        Me.Label3.Text = "Catálogo de Unidades"
        '
        'NombreUnidades
        '
        Me.NombreUnidades.AutoEllipsis = True
        Me.NombreUnidades.BackColor = System.Drawing.Color.Transparent
        Me.NombreUnidades.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreUnidades.Location = New System.Drawing.Point(167, 93)
        Me.NombreUnidades.Name = "NombreUnidades"
        Me.NombreUnidades.Size = New System.Drawing.Size(723, 22)
        Me.NombreUnidades.TabIndex = 233
        Me.NombreUnidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cat_Unidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 708)
        Me.Controls.Add(Me.NombreUnidades)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBoxDetalles)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.CodigoUnidades)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PiePagina)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Cat_Unidades"
        Me.Text = "Catálogo de Unidades"
        Me.GroupBoxDetalles.ResumeLayout(False)
        Me.GroupBoxDetalles.PerformLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PiePagina.ResumeLayout(False)
        Me.PiePagina.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Barra As System.Windows.Forms.PictureBox
    Friend WithEvents CodigoUnidades As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PiePagina As System.Windows.Forms.StatusStrip
    Friend WithEvents MensajePiePagina As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Limpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NombreUnidades As System.Windows.Forms.Label
    Friend WithEvents Nuevo As System.Windows.Forms.ToolStripButton
End Class
