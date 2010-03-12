<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cat_Marcas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cat_Marcas))
        Me.PiePagina = New System.Windows.Forms.StatusStrip
        Me.MensajePiePagina = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBoxMarca = New System.Windows.Forms.GroupBox
        Me.Descripcion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Barra = New System.Windows.Forms.PictureBox
        Me.NombreMarca = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.CodigoMarca = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Limpiar = New System.Windows.Forms.ToolStripButton
        Me.Nuevo = New System.Windows.Forms.ToolStripButton
        Me.Grabar = New System.Windows.Forms.ToolStripButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.PiePagina.SuspendLayout()
        Me.GroupBoxMarca.SuspendLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.PiePagina.TabIndex = 213
        Me.PiePagina.Text = "StatusStrip1"
        '
        'MensajePiePagina
        '
        Me.MensajePiePagina.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MensajePiePagina.Name = "MensajePiePagina"
        Me.MensajePiePagina.Size = New System.Drawing.Size(150, 17)
        Me.MensajePiePagina.Text = "ToolStripStatusLabel1"
        '
        'GroupBoxMarca
        '
        Me.GroupBoxMarca.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxMarca.Controls.Add(Me.Descripcion)
        Me.GroupBoxMarca.Controls.Add(Me.Label2)
        Me.GroupBoxMarca.Location = New System.Drawing.Point(14, 148)
        Me.GroupBoxMarca.Name = "GroupBoxMarca"
        Me.GroupBoxMarca.Size = New System.Drawing.Size(977, 520)
        Me.GroupBoxMarca.TabIndex = 222
        Me.GroupBoxMarca.TabStop = False
        Me.GroupBoxMarca.Text = "Datos de la marca"
        Me.GroupBoxMarca.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Descripcion.Location = New System.Drawing.Point(101, 43)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(870, 22)
        Me.Descripcion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Descripción"
        '
        'Barra
        '
        Me.Barra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Barra.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Barra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Barra.Location = New System.Drawing.Point(0, 128)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(1024, 4)
        Me.Barra.TabIndex = 221
        Me.Barra.TabStop = False
        '
        'NombreMarca
        '
        Me.NombreMarca.AutoEllipsis = True
        Me.NombreMarca.BackColor = System.Drawing.Color.Transparent
        Me.NombreMarca.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreMarca.Location = New System.Drawing.Point(173, 93)
        Me.NombreMarca.Name = "NombreMarca"
        Me.NombreMarca.Size = New System.Drawing.Size(728, 22)
        Me.NombreMarca.TabIndex = 220
        Me.NombreMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.btnAceptar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnAceptar.Location = New System.Drawing.Point(914, 91)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(80, 25)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'CodigoMarca
        '
        Me.CodigoMarca.BackColor = System.Drawing.SystemColors.Info
        Me.CodigoMarca.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoMarca.Location = New System.Drawing.Point(72, 93)
        Me.CodigoMarca.MaxLength = 9
        Me.CodigoMarca.Name = "CodigoMarca"
        Me.CodigoMarca.Size = New System.Drawing.Size(79, 22)
        Me.CodigoMarca.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 14)
        Me.Label1.TabIndex = 219
        Me.Label1.Text = "Marca"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Limpiar, Me.Nuevo, Me.Grabar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1016, 48)
        Me.ToolStrip1.TabIndex = 227
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 20)
        Me.Label4.TabIndex = 228
        Me.Label4.Text = "Catálogo de Marcas"
        '
        'Cat_Marcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 708)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBoxMarca)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.NombreMarca)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.CodigoMarca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PiePagina)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Cat_Marcas"
        Me.Text = "Catálogo de marcas"
        Me.PiePagina.ResumeLayout(False)
        Me.PiePagina.PerformLayout()
        Me.GroupBoxMarca.ResumeLayout(False)
        Me.GroupBoxMarca.PerformLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PiePagina As System.Windows.Forms.StatusStrip
    Friend WithEvents MensajePiePagina As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBoxMarca As System.Windows.Forms.GroupBox
    Friend WithEvents Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Barra As System.Windows.Forms.PictureBox
    Friend WithEvents NombreMarca As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents CodigoMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Limpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Nuevo As System.Windows.Forms.ToolStripButton
End Class
