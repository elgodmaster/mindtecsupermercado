<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rep_Proveedores
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
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtCiudad = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtEstado = New System.Windows.Forms.TextBox
        Me.txt_Prov = New System.Windows.Forms.TextBox
        Me.BtnRepo = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Limpiar = New System.Windows.Forms.ToolStripButton
        Me.Rep_pdf = New System.Windows.Forms.ToolStripButton
        Me.LblCiudad = New System.Windows.Forms.Label
        Me.Lblest = New System.Windows.Forms.Label
        Me.LblNombre = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(38, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 15)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Ciudad"
        '
        'TxtCiudad
        '
        Me.TxtCiudad.Location = New System.Drawing.Point(90, 140)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.Size = New System.Drawing.Size(166, 22)
        Me.TxtCiudad.TabIndex = 52
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(38, 118)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 15)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Estado"
        '
        'TxtEstado
        '
        Me.TxtEstado.Location = New System.Drawing.Point(90, 114)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(166, 22)
        Me.TxtEstado.TabIndex = 50
        '
        'txt_Prov
        '
        Me.txt_Prov.Location = New System.Drawing.Point(90, 86)
        Me.txt_Prov.Name = "txt_Prov"
        Me.txt_Prov.Size = New System.Drawing.Size(166, 22)
        Me.txt_Prov.TabIndex = 49
        '
        'BtnRepo
        '
        Me.BtnRepo.Location = New System.Drawing.Point(813, 140)
        Me.BtnRepo.Name = "BtnRepo"
        Me.BtnRepo.Size = New System.Drawing.Size(132, 23)
        Me.BtnRepo.TabIndex = 48
        Me.BtnRepo.Text = "Reporte Proveedores"
        Me.BtnRepo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Proveedor"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Limpiar, Me.Rep_pdf})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 55)
        Me.ToolStrip1.TabIndex = 230
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Limpiar
        '
        Me.Limpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Limpiar.Image = Global.SuperMercado.My.Resources.Resources.page
        Me.Limpiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Limpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(36, 52)
        Me.Limpiar.Text = "Limpiar"
        '
        'Rep_pdf
        '
        Me.Rep_pdf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Rep_pdf.Image = Global.SuperMercado.My.Resources.Resources._1282930907_pdf
        Me.Rep_pdf.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Rep_pdf.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Rep_pdf.Name = "Rep_pdf"
        Me.Rep_pdf.Size = New System.Drawing.Size(36, 52)
        Me.Rep_pdf.Text = "Grabar"
        Me.Rep_pdf.ToolTipText = "Reporte Pdf"
        '
        'LblCiudad
        '
        Me.LblCiudad.AutoEllipsis = True
        Me.LblCiudad.BackColor = System.Drawing.Color.Transparent
        Me.LblCiudad.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCiudad.Location = New System.Drawing.Point(262, 142)
        Me.LblCiudad.Name = "LblCiudad"
        Me.LblCiudad.Size = New System.Drawing.Size(529, 22)
        Me.LblCiudad.TabIndex = 352
        Me.LblCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lblest
        '
        Me.Lblest.AutoEllipsis = True
        Me.Lblest.BackColor = System.Drawing.Color.Transparent
        Me.Lblest.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblest.Location = New System.Drawing.Point(262, 114)
        Me.Lblest.Name = "Lblest"
        Me.Lblest.Size = New System.Drawing.Size(529, 22)
        Me.Lblest.TabIndex = 351
        Me.Lblest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNombre
        '
        Me.LblNombre.AutoEllipsis = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(262, 86)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(529, 22)
        Me.LblNombre.TabIndex = 350
        Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Rep_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 702)
        Me.Controls.Add(Me.LblCiudad)
        Me.Controls.Add(Me.Lblest)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtCiudad)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtEstado)
        Me.Controls.Add(Me.txt_Prov)
        Me.Controls.Add(Me.BtnRepo)
        Me.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Rep_Proveedores"
        Me.Text = "Rep_Proveedores"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtEstado As System.Windows.Forms.TextBox
    Friend WithEvents txt_Prov As System.Windows.Forms.TextBox
    Friend WithEvents BtnRepo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Limpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Rep_pdf As System.Windows.Forms.ToolStripButton
    Friend WithEvents LblCiudad As System.Windows.Forms.Label
    Friend WithEvents Lblest As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
End Class
