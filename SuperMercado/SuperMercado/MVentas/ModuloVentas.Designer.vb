<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModuloVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModuloVentas))
        Me.label16 = New System.Windows.Forms.Label
        Me.button3 = New System.Windows.Forms.Button
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.button2 = New System.Windows.Forms.Button
        Me.button1 = New System.Windows.Forms.Button
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip
        Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.toolStripButton6 = New System.Windows.Forms.ToolStripButton
        Me.label15 = New System.Windows.Forms.Label
        Me.label14 = New System.Windows.Forms.Label
        Me.panel1 = New System.Windows.Forms.Panel
        Me.GridDatos = New SourceGrid.DataGrid
        Me.button5 = New System.Windows.Forms.Button
        Me.button4 = New System.Windows.Forms.Button
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.Txt_Total = New System.Windows.Forms.Label
        Me.label11 = New System.Windows.Forms.Label
        Me.label10 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.panel2 = New System.Windows.Forms.Panel
        Me.groupBox2.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
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
        'button3
        '
        Me.button3.BackgroundImage = CType(resources.GetObject("button3.BackgroundImage"), System.Drawing.Image)
        Me.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.button3.Location = New System.Drawing.Point(838, 29)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(95, 31)
        Me.button3.TabIndex = 25
        Me.button3.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.groupBox1)
        Me.groupBox2.Controls.Add(Me.button5)
        Me.groupBox2.Controls.Add(Me.button4)
        Me.groupBox2.Controls.Add(Me.GridDatos)
        Me.groupBox2.Controls.Add(Me.label16)
        Me.groupBox2.Controls.Add(Me.button3)
        Me.groupBox2.Controls.Add(Me.button2)
        Me.groupBox2.Controls.Add(Me.button1)
        Me.groupBox2.Controls.Add(Me.txtCantidad)
        Me.groupBox2.Controls.Add(Me.txtCodigo)
        Me.groupBox2.Controls.Add(Me.label1)
        Me.groupBox2.Location = New System.Drawing.Point(58, 192)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(938, 510)
        Me.groupBox2.TabIndex = 26
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Detalle de la venta"
        '
        'button2
        '
        Me.button2.BackgroundImage = CType(resources.GetObject("button2.BackgroundImage"), System.Drawing.Image)
        Me.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.button2.Location = New System.Drawing.Point(731, 29)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(95, 31)
        Me.button2.TabIndex = 10
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.BackgroundImage = CType(resources.GetObject("button1.BackgroundImage"), System.Drawing.Image)
        Me.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.button1.Location = New System.Drawing.Point(512, 29)
        Me.button1.Name = "button1"
        Me.button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button1.Size = New System.Drawing.Size(57, 31)
        Me.button1.TabIndex = 9
        Me.button1.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(453, 30)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(60, 29)
        Me.txtCantidad.TabIndex = 8
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(184, 30)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(272, 29)
        Me.txtCodigo.TabIndex = 7
        Me.txtCodigo.Text = "123456789101112131415"
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
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton2, Me.toolStripButton3, Me.toolStripButton4, Me.toolStripButton5, Me.toolStripButton6})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(53, 708)
        Me.toolStrip1.TabIndex = 27
        Me.toolStrip1.Text = "toolStrip1"
        '
        'toolStripButton2
        '
        Me.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButton2.Image = CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image)
        Me.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton2.Name = "toolStripButton2"
        Me.toolStripButton2.Size = New System.Drawing.Size(50, 52)
        Me.toolStripButton2.Text = "Checador de precios"
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
        'GridDatos
        '
        Me.GridDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GridDatos.DeleteQuestionMessage = ""
        Me.GridDatos.DeleteRowsWithDeleteKey = False
        Me.GridDatos.FixedRows = 1
        Me.GridDatos.Location = New System.Drawing.Point(7, 95)
        Me.GridDatos.Name = "GridDatos"
        Me.GridDatos.SelectionMode = SourceGrid.GridSelectionMode.Row
        Me.GridDatos.Size = New System.Drawing.Size(925, 259)
        Me.GridDatos.TabIndex = 26
        Me.GridDatos.TabStop = True
        Me.GridDatos.ToolTipText = ""
        '
        'button5
        '
        Me.button5.Enabled = False
        Me.button5.Image = CType(resources.GetObject("button5.Image"), System.Drawing.Image)
        Me.button5.Location = New System.Drawing.Point(838, 431)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(87, 51)
        Me.button5.TabIndex = 28
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Enabled = False
        Me.button4.Image = CType(resources.GetObject("button4.Image"), System.Drawing.Image)
        Me.button4.Location = New System.Drawing.Point(730, 431)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(87, 51)
        Me.button4.TabIndex = 27
        Me.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button4.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.Txt_Total)
        Me.groupBox1.Controls.Add(Me.label11)
        Me.groupBox1.Controls.Add(Me.label10)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Enabled = False
        Me.groupBox1.Location = New System.Drawing.Point(413, 360)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(221, 144)
        Me.groupBox1.TabIndex = 31
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Detalle de importe"
        '
        'Txt_Total
        '
        Me.Txt_Total.AutoSize = True
        Me.Txt_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Total.Location = New System.Drawing.Point(138, 96)
        Me.Txt_Total.Name = "Txt_Total"
        Me.Txt_Total.Size = New System.Drawing.Size(71, 24)
        Me.Txt_Total.TabIndex = 5
        Me.Txt_Total.Text = "$17.25"
        Me.Txt_Total.Visible = False
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(170, 60)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(39, 13)
        Me.label11.TabIndex = 4
        Me.label11.Text = "$2.25"
        Me.label11.Visible = False
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(145, 28)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(64, 20)
        Me.label10.TabIndex = 3
        Me.label10.Text = "$15.00"
        Me.label10.Visible = False
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
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(4, 28)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(82, 20)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Subtotal:"
        '
        'panel2
        '
        Me.panel2.BackgroundImage = CType(resources.GetObject("panel2.BackgroundImage"), System.Drawing.Image)
        Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel2.Location = New System.Drawing.Point(85, 12)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(429, 151)
        Me.panel2.TabIndex = 29
        '
        'ModuloVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 708)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.toolStrip1)
        Me.Controls.Add(Me.groupBox2)
        Me.Name = "ModuloVentas"
        Me.Text = "ModuloVentas"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label16 As System.Windows.Forms.Label
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents txtCantidad As System.Windows.Forms.TextBox
    Private WithEvents txtCodigo As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents toolStripButton2 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButton3 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButton4 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButton5 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButton6 As System.Windows.Forms.ToolStripButton
    Private WithEvents label15 As System.Windows.Forms.Label
    Private WithEvents label14 As System.Windows.Forms.Label
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents GridDatos As SourceGrid.DataGrid
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents Txt_Total As System.Windows.Forms.Label
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents button5 As System.Windows.Forms.Button
    Private WithEvents button4 As System.Windows.Forms.Button
    Private WithEvents panel2 As System.Windows.Forms.Panel
End Class
