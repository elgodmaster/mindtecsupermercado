<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Caja))
        Me.Label1 = New System.Windows.Forms.Label
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblDineroCaja = New System.Windows.Forms.Label
        Me.lblEntradaDin = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblTotalEntradas = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblTotalEntEfec = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblSalidas = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.GridDatosEntradas = New SourceGrid.DataGrid
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnHacerCorte = New System.Windows.Forms.ToolStripButton
        Me.GridDatosSalidas = New SourceGrid.DataGrid
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(42, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CORTE"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1010, 537)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 46
        Me.LineShape4.X2 = 730
        Me.LineShape4.Y1 = 229
        Me.LineShape4.Y2 = 229
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 46
        Me.LineShape2.X2 = 730
        Me.LineShape2.Y1 = 99
        Me.LineShape2.Y2 = 99
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(42, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Entradas en efectivo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dinero inical en caja:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Entrada de dinero (caja):"
        '
        'lblDineroCaja
        '
        Me.lblDineroCaja.AutoSize = True
        Me.lblDineroCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDineroCaja.ForeColor = System.Drawing.Color.Navy
        Me.lblDineroCaja.Location = New System.Drawing.Point(203, 143)
        Me.lblDineroCaja.Name = "lblDineroCaja"
        Me.lblDineroCaja.Size = New System.Drawing.Size(39, 13)
        Me.lblDineroCaja.TabIndex = 7
        Me.lblDineroCaja.Text = "$0.00"
        '
        'lblEntradaDin
        '
        Me.lblEntradaDin.AutoSize = True
        Me.lblEntradaDin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntradaDin.ForeColor = System.Drawing.Color.Navy
        Me.lblEntradaDin.Location = New System.Drawing.Point(203, 160)
        Me.lblEntradaDin.Name = "lblEntradaDin"
        Me.lblEntradaDin.Size = New System.Drawing.Size(39, 13)
        Me.lblEntradaDin.TabIndex = 8
        Me.lblEntradaDin.Text = "$0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(647, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "$0.00"
        '
        'lblTotalEntradas
        '
        Me.lblTotalEntradas.AutoSize = True
        Me.lblTotalEntradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEntradas.ForeColor = System.Drawing.Color.Teal
        Me.lblTotalEntradas.Location = New System.Drawing.Point(647, 143)
        Me.lblTotalEntradas.Name = "lblTotalEntradas"
        Me.lblTotalEntradas.Size = New System.Drawing.Size(39, 13)
        Me.lblTotalEntradas.TabIndex = 12
        Me.lblTotalEntradas.Text = "$0.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(487, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Ventas totales:    "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(487, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Entradas:"
        '
        'Label9
        '
        Me.Label9.AllowDrop = True
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(486, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 24)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Dinero en caja"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(126, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Total:"
        '
        'lblTotalEntEfec
        '
        Me.lblTotalEntEfec.AutoSize = True
        Me.lblTotalEntEfec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEntEfec.ForeColor = System.Drawing.Color.Navy
        Me.lblTotalEntEfec.Location = New System.Drawing.Point(203, 197)
        Me.lblTotalEntEfec.Name = "lblTotalEntEfec"
        Me.lblTotalEntEfec.Size = New System.Drawing.Size(39, 13)
        Me.lblTotalEntEfec.TabIndex = 15
        Me.lblTotalEntEfec.Text = "$0.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(487, 177)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Salidas:"
        '
        'lblSalidas
        '
        Me.lblSalidas.AutoSize = True
        Me.lblSalidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalidas.ForeColor = System.Drawing.Color.Teal
        Me.lblSalidas.Location = New System.Drawing.Point(647, 177)
        Me.lblSalidas.Name = "lblSalidas"
        Me.lblSalidas.Size = New System.Drawing.Size(39, 13)
        Me.lblSalidas.TabIndex = 17
        Me.lblSalidas.Text = "$0.00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Teal
        Me.Label13.Location = New System.Drawing.Point(647, 197)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "$0.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(574, 197)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Total:"
        '
        'Label15
        '
        Me.Label15.AllowDrop = True
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(42, 263)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(200, 24)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Entradas en efectivo"
        '
        'Label16
        '
        Me.Label16.AllowDrop = True
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(486, 263)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(185, 24)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Salidas en efectivo"
        '
        'Label17
        '
        Me.Label17.AllowDrop = True
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(42, 234)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 24)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Historial"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(600, 141)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 15)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "+"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(600, 158)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 15)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "+"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(601, 174)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(11, 15)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "-"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 515)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1010, 22)
        Me.StatusStrip1.TabIndex = 30
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(246, 17)
        Me.ToolStripStatusLabel1.Text = "Haga clic en ""Hacer corte"" para mostrar los datos."
        '
        'GridDatosEntradas
        '
        Me.GridDatosEntradas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDatosEntradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GridDatosEntradas.DeleteQuestionMessage = ""
        Me.GridDatosEntradas.DeleteRowsWithDeleteKey = False
        Me.GridDatosEntradas.FixedRows = 1
        Me.GridDatosEntradas.Location = New System.Drawing.Point(40, 290)
        Me.GridDatosEntradas.Name = "GridDatosEntradas"
        Me.GridDatosEntradas.SelectionMode = SourceGrid.GridSelectionMode.Row
        Me.GridDatosEntradas.Size = New System.Drawing.Size(414, 129)
        Me.GridDatosEntradas.TabIndex = 31
        Me.GridDatosEntradas.TabStop = True
        Me.GridDatosEntradas.ToolTipText = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnHacerCorte})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1010, 48)
        Me.ToolStrip1.TabIndex = 231
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnHacerCorte
        '
        Me.btnHacerCorte.AutoSize = False
        Me.btnHacerCorte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHacerCorte.Image = CType(resources.GetObject("btnHacerCorte.Image"), System.Drawing.Image)
        Me.btnHacerCorte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnHacerCorte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHacerCorte.Name = "btnHacerCorte"
        Me.btnHacerCorte.Size = New System.Drawing.Size(43, 45)
        Me.btnHacerCorte.Text = "Limpiar"
        '
        'GridDatosSalidas
        '
        Me.GridDatosSalidas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDatosSalidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GridDatosSalidas.DeleteQuestionMessage = ""
        Me.GridDatosSalidas.DeleteRowsWithDeleteKey = False
        Me.GridDatosSalidas.FixedRows = 1
        Me.GridDatosSalidas.Location = New System.Drawing.Point(490, 290)
        Me.GridDatosSalidas.Name = "GridDatosSalidas"
        Me.GridDatosSalidas.SelectionMode = SourceGrid.GridSelectionMode.Row
        Me.GridDatosSalidas.Size = New System.Drawing.Size(414, 129)
        Me.GridDatosSalidas.TabIndex = 232
        Me.GridDatosSalidas.TabStop = True
        Me.GridDatosSalidas.ToolTipText = ""
        '
        'Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 537)
        Me.Controls.Add(Me.GridDatosSalidas)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GridDatosEntradas)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblSalidas)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblTotalEntEfec)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTotalEntradas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblEntradaDin)
        Me.Controls.Add(Me.lblDineroCaja)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Caja"
        Me.Text = "Caja"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDineroCaja As System.Windows.Forms.Label
    Friend WithEvents lblEntradaDin As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotalEntradas As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblTotalEntEfec As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblSalidas As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GridDatosEntradas As SourceGrid.DataGrid
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnHacerCorte As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridDatosSalidas As SourceGrid.DataGrid
End Class
