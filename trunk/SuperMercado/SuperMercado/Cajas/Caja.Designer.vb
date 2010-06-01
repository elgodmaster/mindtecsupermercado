<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caja
    Inherits System.Windows.Forms.Form

    'Para el control de una sola instancia por formulario.
#Region "  Modificación del constructor  "
    ' En esta constructora es que cambio la propiedad Public por la propiedad Private
    Private Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Private Shared ChildInstance As Caja = Nothing

    'controla que sólo exista una instancia del formulario.

    Public Shared Function Instance() As Caja
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New Caja
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
#End Region


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
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblEntradaDin = New System.Windows.Forms.Label
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblGridVentaTotal = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblCanRet = New System.Windows.Forms.Label
        Me.lblRetirar = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblDineroCaja = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblTotalEntradas = New System.Windows.Forms.Label
        Me.lblVentasTotales = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblSalidas = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GridDatosVenta = New SourceGrid.DataGrid
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(574, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total:"
        '
        'lblEntradaDin
        '
        Me.lblEntradaDin.AutoSize = True
        Me.lblEntradaDin.BackColor = System.Drawing.Color.Transparent
        Me.lblEntradaDin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntradaDin.ForeColor = System.Drawing.Color.Navy
        Me.lblEntradaDin.Location = New System.Drawing.Point(673, 232)
        Me.lblEntradaDin.Name = "lblEntradaDin"
        Me.lblEntradaDin.Size = New System.Drawing.Size(53, 19)
        Me.lblEntradaDin.TabIndex = 8
        Me.lblEntradaDin.Text = "$ 0.00"
        '
        'Label15
        '
        Me.Label15.AllowDrop = True
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label15.Location = New System.Drawing.Point(343, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(165, 19)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Entradas en efectivo"
        '
        'Label16
        '
        Me.Label16.AllowDrop = True
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label16.Location = New System.Drawing.Point(343, 269)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(152, 19)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Salidas en efectivo"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 724)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(811, 22)
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
        Me.GridDatosEntradas.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GridDatosEntradas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridDatosEntradas.DeleteQuestionMessage = ""
        Me.GridDatosEntradas.DeleteRowsWithDeleteKey = False
        Me.GridDatosEntradas.FixedRows = 1
        Me.GridDatosEntradas.Location = New System.Drawing.Point(347, 100)
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
        Me.ToolStrip1.Size = New System.Drawing.Size(811, 48)
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
        Me.GridDatosSalidas.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GridDatosSalidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridDatosSalidas.DeleteQuestionMessage = ""
        Me.GridDatosSalidas.DeleteRowsWithDeleteKey = False
        Me.GridDatosSalidas.FixedRows = 1
        Me.GridDatosSalidas.Location = New System.Drawing.Point(347, 291)
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
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(574, 423)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 19)
        Me.Label6.TabIndex = 233
        Me.Label6.Text = "Total:"
        '
        'lblSalDinero
        '
        Me.lblSalDinero.AutoSize = True
        Me.lblSalDinero.BackColor = System.Drawing.Color.Transparent
        Me.lblSalDinero.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalDinero.ForeColor = System.Drawing.Color.Teal
        Me.lblSalDinero.Location = New System.Drawing.Point(673, 421)
        Me.lblSalDinero.Name = "lblSalDinero"
        Me.lblSalDinero.Size = New System.Drawing.Size(53, 19)
        Me.lblSalDinero.TabIndex = 234
        Me.lblSalDinero.Text = "$ 0.00"
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(343, 450)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 19)
        Me.Label2.TabIndex = 246
        Me.Label2.Text = "Venta del día"
        '
        'lblGridVentaTotal
        '
        Me.lblGridVentaTotal.AutoSize = True
        Me.lblGridVentaTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblGridVentaTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGridVentaTotal.ForeColor = System.Drawing.Color.Teal
        Me.lblGridVentaTotal.Location = New System.Drawing.Point(673, 602)
        Me.lblGridVentaTotal.Name = "lblGridVentaTotal"
        Me.lblGridVentaTotal.Size = New System.Drawing.Size(53, 19)
        Me.lblGridVentaTotal.TabIndex = 249
        Me.lblGridVentaTotal.Text = "$ 0.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(574, 604)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 19)
        Me.Label10.TabIndex = 248
        Me.Label10.Text = "Total:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCanRet)
        Me.GroupBox1.Controls.Add(Me.lblRetirar)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblDineroCaja)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblTotalEntradas)
        Me.GroupBox1.Controls.Add(Me.lblVentasTotales)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblSalidas)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 348)
        Me.GroupBox1.TabIndex = 263
        Me.GroupBox1.TabStop = False
        '
        'lblCanRet
        '
        Me.lblCanRet.AutoSize = True
        Me.lblCanRet.BackColor = System.Drawing.Color.Transparent
        Me.lblCanRet.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCanRet.ForeColor = System.Drawing.Color.Navy
        Me.lblCanRet.Location = New System.Drawing.Point(196, 294)
        Me.lblCanRet.Name = "lblCanRet"
        Me.lblCanRet.Size = New System.Drawing.Size(53, 19)
        Me.lblCanRet.TabIndex = 273
        Me.lblCanRet.Text = "$ 0.00"
        Me.lblCanRet.Visible = False
        '
        'lblRetirar
        '
        Me.lblRetirar.AutoSize = True
        Me.lblRetirar.BackColor = System.Drawing.Color.Transparent
        Me.lblRetirar.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetirar.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblRetirar.Location = New System.Drawing.Point(8, 294)
        Me.lblRetirar.Name = "lblRetirar"
        Me.lblRetirar.Size = New System.Drawing.Size(140, 19)
        Me.lblRetirar.TabIndex = 272
        Me.lblRetirar.Text = "Por favor retire: "
        Me.lblRetirar.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Teal
        Me.lblTotal.Location = New System.Drawing.Point(196, 212)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(53, 19)
        Me.lblTotal.TabIndex = 271
        Me.lblTotal.Text = "$ 0.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(74, 212)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 19)
        Me.Label14.TabIndex = 270
        Me.Label14.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(13, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 19)
        Me.Label3.TabIndex = 262
        Me.Label3.Text = "Dinero inicial:"
        '
        'lblDineroCaja
        '
        Me.lblDineroCaja.AutoSize = True
        Me.lblDineroCaja.BackColor = System.Drawing.Color.Transparent
        Me.lblDineroCaja.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDineroCaja.ForeColor = System.Drawing.Color.Navy
        Me.lblDineroCaja.Location = New System.Drawing.Point(196, 31)
        Me.lblDineroCaja.Name = "lblDineroCaja"
        Me.lblDineroCaja.Size = New System.Drawing.Size(53, 19)
        Me.lblDineroCaja.TabIndex = 263
        Me.lblDineroCaja.Text = "$ 0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(43, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 19)
        Me.Label8.TabIndex = 264
        Me.Label8.Text = "Entradas:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(4, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 19)
        Me.Label7.TabIndex = 265
        Me.Label7.Text = "Ventas totales:"
        '
        'lblTotalEntradas
        '
        Me.lblTotalEntradas.AutoSize = True
        Me.lblTotalEntradas.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalEntradas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEntradas.ForeColor = System.Drawing.Color.Teal
        Me.lblTotalEntradas.Location = New System.Drawing.Point(196, 74)
        Me.lblTotalEntradas.Name = "lblTotalEntradas"
        Me.lblTotalEntradas.Size = New System.Drawing.Size(53, 19)
        Me.lblTotalEntradas.TabIndex = 266
        Me.lblTotalEntradas.Text = "$ 0.00"
        '
        'lblVentasTotales
        '
        Me.lblVentasTotales.AutoSize = True
        Me.lblVentasTotales.BackColor = System.Drawing.Color.Transparent
        Me.lblVentasTotales.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentasTotales.ForeColor = System.Drawing.Color.Teal
        Me.lblVentasTotales.Location = New System.Drawing.Point(196, 103)
        Me.lblVentasTotales.Name = "lblVentasTotales"
        Me.lblVentasTotales.Size = New System.Drawing.Size(53, 19)
        Me.lblVentasTotales.TabIndex = 267
        Me.lblVentasTotales.Text = "$ 0.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(56, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 19)
        Me.Label11.TabIndex = 268
        Me.Label11.Text = "Salidas:"
        '
        'lblSalidas
        '
        Me.lblSalidas.AutoSize = True
        Me.lblSalidas.BackColor = System.Drawing.Color.Transparent
        Me.lblSalidas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalidas.ForeColor = System.Drawing.Color.Teal
        Me.lblSalidas.Location = New System.Drawing.Point(196, 153)
        Me.lblSalidas.Name = "lblSalidas"
        Me.lblSalidas.Size = New System.Drawing.Size(53, 19)
        Me.lblSalidas.TabIndex = 269
        Me.lblSalidas.Text = "$ 0.00"
        '
        'Label9
        '
        Me.Label9.AllowDrop = True
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label9.Location = New System.Drawing.Point(29, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 22)
        Me.Label9.TabIndex = 250
        Me.Label9.Text = "Dinero en caja"
        '
        'GridDatosVenta
        '
        Me.GridDatosVenta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GridDatosVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridDatosVenta.DeleteQuestionMessage = ""
        Me.GridDatosVenta.DeleteRowsWithDeleteKey = False
        Me.GridDatosVenta.FixedRows = 1
        Me.GridDatosVenta.Location = New System.Drawing.Point(347, 472)
        Me.GridDatosVenta.Name = "GridDatosVenta"
        Me.GridDatosVenta.SelectionMode = SourceGrid.GridSelectionMode.Row
        Me.GridDatosVenta.Size = New System.Drawing.Size(424, 129)
        Me.GridDatosVenta.TabIndex = 247
        Me.GridDatosVenta.TabStop = True
        Me.GridDatosVenta.ToolTipText = ""
        '
        'Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(811, 746)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblGridVentaTotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GridDatosVenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSalDinero)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GridDatosSalidas)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GridDatosEntradas)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblEntradaDin)
        Me.Controls.Add(Me.Label4)
        Me.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Name = "Caja"
        Me.Text = "Caja"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblEntradaDin As System.Windows.Forms.Label
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblGridVentaTotal As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRetirar As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDineroCaja As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTotalEntradas As System.Windows.Forms.Label
    Friend WithEvents lblVentasTotales As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblSalidas As System.Windows.Forms.Label
    Friend WithEvents lblCanRet As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GridDatosVenta As SourceGrid.DataGrid
End Class
