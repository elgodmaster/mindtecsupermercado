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
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblEntradaDin = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.GridDatosEntradas = New SourceGrid.DataGrid
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnHacerCorte = New System.Windows.Forms.ToolStripButton
        Me.GridDatosSalidas = New SourceGrid.DataGrid
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblSalDinero = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblDineroCaja = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblTotalEntradas = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblSalidas = New System.Windows.Forms.Label
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(42, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CORTE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(302, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total:"
        '
        'lblEntradaDin
        '
        Me.lblEntradaDin.AutoSize = True
        Me.lblEntradaDin.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntradaDin.ForeColor = System.Drawing.Color.Navy
        Me.lblEntradaDin.Location = New System.Drawing.Point(401, 275)
        Me.lblEntradaDin.Name = "lblEntradaDin"
        Me.lblEntradaDin.Size = New System.Drawing.Size(59, 22)
        Me.lblEntradaDin.TabIndex = 8
        Me.lblEntradaDin.Text = "$0.00"
        '
        'Label9
        '
        Me.Label9.AllowDrop = True
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(500, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 22)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Dinero en caja"
        '
        'Label15
        '
        Me.Label15.AllowDrop = True
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(41, 105)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(200, 22)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Entradas en efectivo"
        '
        'Label16
        '
        Me.Label16.AllowDrop = True
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(41, 314)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(184, 22)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Salidas en efectivo"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 527)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(797, 22)
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
        Me.GridDatosEntradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GridDatosEntradas.DeleteQuestionMessage = ""
        Me.GridDatosEntradas.DeleteRowsWithDeleteKey = False
        Me.GridDatosEntradas.FixedRows = 1
        Me.GridDatosEntradas.Location = New System.Drawing.Point(47, 144)
        Me.GridDatosEntradas.Name = "GridDatosEntradas"
        Me.GridDatosEntradas.SelectionMode = SourceGrid.GridSelectionMode.Row
        Me.GridDatosEntradas.Size = New System.Drawing.Size(424, 129)
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
        Me.ToolStrip1.Size = New System.Drawing.Size(797, 48)
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
        Me.btnHacerCorte.Text = "Corte"
        '
        'GridDatosSalidas
        '
        Me.GridDatosSalidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GridDatosSalidas.DeleteQuestionMessage = ""
        Me.GridDatosSalidas.DeleteRowsWithDeleteKey = False
        Me.GridDatosSalidas.FixedRows = 1
        Me.GridDatosSalidas.Location = New System.Drawing.Point(47, 351)
        Me.GridDatosSalidas.Name = "GridDatosSalidas"
        Me.GridDatosSalidas.SelectionMode = SourceGrid.GridSelectionMode.Row
        Me.GridDatosSalidas.Size = New System.Drawing.Size(424, 129)
        Me.GridDatosSalidas.TabIndex = 232
        Me.GridDatosSalidas.TabStop = True
        Me.GridDatosSalidas.ToolTipText = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(302, 484)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 22)
        Me.Label6.TabIndex = 233
        Me.Label6.Text = "Total:"
        '
        'lblSalDinero
        '
        Me.lblSalDinero.AutoSize = True
        Me.lblSalDinero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalDinero.ForeColor = System.Drawing.Color.Teal
        Me.lblSalDinero.Location = New System.Drawing.Point(401, 482)
        Me.lblSalDinero.Name = "lblSalDinero"
        Me.lblSalDinero.Size = New System.Drawing.Size(60, 24)
        Me.lblSalDinero.TabIndex = 234
        Me.lblSalDinero.Text = "$0.00"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Teal
        Me.lblTotal.Location = New System.Drawing.Point(725, 290)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(59, 22)
        Me.lblTotal.TabIndex = 244
        Me.lblTotal.Text = "$0.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(611, 290)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 22)
        Me.Label14.TabIndex = 243
        Me.Label14.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(500, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 19)
        Me.Label3.TabIndex = 235
        Me.Label3.Text = "Dinero inicial:"
        '
        'lblDineroCaja
        '
        Me.lblDineroCaja.AutoSize = True
        Me.lblDineroCaja.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDineroCaja.ForeColor = System.Drawing.Color.Navy
        Me.lblDineroCaja.Location = New System.Drawing.Point(725, 144)
        Me.lblDineroCaja.Name = "lblDineroCaja"
        Me.lblDineroCaja.Size = New System.Drawing.Size(59, 22)
        Me.lblDineroCaja.TabIndex = 236
        Me.lblDineroCaja.Text = "$0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(500, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 19)
        Me.Label8.TabIndex = 237
        Me.Label8.Text = "Entradas:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(500, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 19)
        Me.Label7.TabIndex = 238
        Me.Label7.Text = "Ventas totales:"
        '
        'lblTotalEntradas
        '
        Me.lblTotalEntradas.AutoSize = True
        Me.lblTotalEntradas.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEntradas.ForeColor = System.Drawing.Color.Teal
        Me.lblTotalEntradas.Location = New System.Drawing.Point(725, 173)
        Me.lblTotalEntradas.Name = "lblTotalEntradas"
        Me.lblTotalEntradas.Size = New System.Drawing.Size(59, 22)
        Me.lblTotalEntradas.TabIndex = 239
        Me.lblTotalEntradas.Text = "$0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(725, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 22)
        Me.Label5.TabIndex = 240
        Me.Label5.Text = "$0.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(500, 231)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 19)
        Me.Label11.TabIndex = 241
        Me.Label11.Text = "Salidas:"
        '
        'lblSalidas
        '
        Me.lblSalidas.AutoSize = True
        Me.lblSalidas.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalidas.ForeColor = System.Drawing.Color.Teal
        Me.lblSalidas.Location = New System.Drawing.Point(725, 231)
        Me.lblSalidas.Name = "lblSalidas"
        Me.lblSalidas.Size = New System.Drawing.Size(59, 22)
        Me.lblSalidas.TabIndex = 242
        Me.lblSalidas.Text = "$0.00"
        '
        'Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 549)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDineroCaja)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTotalEntradas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblSalidas)
        Me.Controls.Add(Me.lblSalDinero)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GridDatosSalidas)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GridDatosEntradas)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblEntradaDin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.DarkSlateGray
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblEntradaDin As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GridDatosEntradas As SourceGrid.DataGrid
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnHacerCorte As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridDatosSalidas As SourceGrid.DataGrid
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblSalDinero As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDineroCaja As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTotalEntradas As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblSalidas As System.Windows.Forms.Label
End Class
