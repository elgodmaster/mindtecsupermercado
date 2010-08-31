<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rep_Productos
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtMarca = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtCat = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtDep = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnRep = New System.Windows.Forms.Button
        Me.TxtCodigo = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Limpiar = New System.Windows.Forms.ToolStripButton
        Me.Rep_pdf = New System.Windows.Forms.ToolStripButton
        Me.LblNombre = New System.Windows.Forms.Label
        Me.LblDep = New System.Windows.Forms.Label
        Me.LblCat = New System.Windows.Forms.Label
        Me.LblMar = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 173)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Marca"
        '
        'TxtMarca
        '
        Me.TxtMarca.Location = New System.Drawing.Point(122, 169)
        Me.TxtMarca.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(116, 22)
        Me.TxtMarca.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Categoria"
        '
        'TxtCat
        '
        Me.TxtCat.Location = New System.Drawing.Point(122, 141)
        Me.TxtCat.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCat.Name = "TxtCat"
        Me.TxtCat.Size = New System.Drawing.Size(116, 22)
        Me.TxtCat.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Departamento"
        '
        'TxtDep
        '
        Me.TxtDep.Location = New System.Drawing.Point(122, 113)
        Me.TxtDep.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtDep.Name = "TxtDep"
        Me.TxtDep.Size = New System.Drawing.Size(116, 22)
        Me.TxtDep.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Codigo"
        '
        'BtnRep
        '
        Me.BtnRep.Location = New System.Drawing.Point(862, 161)
        Me.BtnRep.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnRep.Name = "BtnRep"
        Me.BtnRep.Size = New System.Drawing.Size(133, 27)
        Me.BtnRep.TabIndex = 4
        Me.BtnRep.Text = "Reporte Productos"
        Me.BtnRep.UseVisualStyleBackColor = True
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(122, 85)
        Me.TxtCodigo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(116, 22)
        Me.TxtCodigo.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Limpiar, Me.Rep_pdf})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 55)
        Me.ToolStrip1.TabIndex = 229
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
        'LblNombre
        '
        Me.LblNombre.AutoEllipsis = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(245, 84)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(529, 22)
        Me.LblNombre.TabIndex = 347
        Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDep
        '
        Me.LblDep.AutoEllipsis = True
        Me.LblDep.BackColor = System.Drawing.Color.Transparent
        Me.LblDep.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDep.Location = New System.Drawing.Point(245, 112)
        Me.LblDep.Name = "LblDep"
        Me.LblDep.Size = New System.Drawing.Size(529, 22)
        Me.LblDep.TabIndex = 348
        Me.LblDep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblCat
        '
        Me.LblCat.AutoEllipsis = True
        Me.LblCat.BackColor = System.Drawing.Color.Transparent
        Me.LblCat.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCat.Location = New System.Drawing.Point(245, 140)
        Me.LblCat.Name = "LblCat"
        Me.LblCat.Size = New System.Drawing.Size(529, 22)
        Me.LblCat.TabIndex = 349
        Me.LblCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblMar
        '
        Me.LblMar.AutoEllipsis = True
        Me.LblMar.BackColor = System.Drawing.Color.Transparent
        Me.LblMar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMar.Location = New System.Drawing.Point(245, 168)
        Me.LblMar.Name = "LblMar"
        Me.LblMar.Size = New System.Drawing.Size(529, 22)
        Me.LblMar.TabIndex = 350
        Me.LblMar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Rep_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 702)
        Me.Controls.Add(Me.LblMar)
        Me.Controls.Add(Me.LblCat)
        Me.Controls.Add(Me.LblDep)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtMarca)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtCat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDep)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRep)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Rep_Productos"
        Me.Text = "Rep_Productos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtCat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtDep As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnRep As System.Windows.Forms.Button
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Limpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Rep_pdf As System.Windows.Forms.ToolStripButton
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblDep As System.Windows.Forms.Label
    Friend WithEvents LblCat As System.Windows.Forms.Label
    Friend WithEvents LblMar As System.Windows.Forms.Label
End Class
