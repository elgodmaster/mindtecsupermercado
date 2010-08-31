<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rep_Facturas
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
        Me.Fecha2 = New System.Windows.Forms.DateTimePicker
        Me.Fecha1 = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtCliente = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.BtnFacturas = New System.Windows.Forms.Button
        Me.TxtNofactura = New System.Windows.Forms.TextBox
        Me.LblCliente = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Limpiar = New System.Windows.Forms.ToolStripButton
        Me.Rep_pdf = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fecha2
        '
        Me.Fecha2.Location = New System.Drawing.Point(426, 77)
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.Size = New System.Drawing.Size(203, 22)
        Me.Fecha2.TabIndex = 41
        '
        'Fecha1
        '
        Me.Fecha1.Location = New System.Drawing.Point(143, 80)
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.Size = New System.Drawing.Size(203, 22)
        Me.Fecha1.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(365, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 15)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "a fecha2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(79, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 15)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Fecha 1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(84, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 15)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Cliente"
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(142, 145)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(100, 22)
        Me.TxtCliente.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 15)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Numero Factura"
        '
        'BtnFacturas
        '
        Me.BtnFacturas.Location = New System.Drawing.Point(859, 145)
        Me.BtnFacturas.Name = "BtnFacturas"
        Me.BtnFacturas.Size = New System.Drawing.Size(114, 23)
        Me.BtnFacturas.TabIndex = 34
        Me.BtnFacturas.Text = "Reporte Facturas"
        Me.BtnFacturas.UseVisualStyleBackColor = True
        '
        'TxtNofactura
        '
        Me.TxtNofactura.Location = New System.Drawing.Point(142, 113)
        Me.TxtNofactura.Name = "TxtNofactura"
        Me.TxtNofactura.Size = New System.Drawing.Size(100, 22)
        Me.TxtNofactura.TabIndex = 33
        '
        'LblCliente
        '
        Me.LblCliente.AutoEllipsis = True
        Me.LblCliente.BackColor = System.Drawing.Color.Transparent
        Me.LblCliente.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCliente.Location = New System.Drawing.Point(248, 145)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(529, 22)
        Me.LblCliente.TabIndex = 351
        Me.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Limpiar, Me.Rep_pdf})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 55)
        Me.ToolStrip1.TabIndex = 352
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
        'Rep_Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 708)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.LblCliente)
        Me.Controls.Add(Me.Fecha2)
        Me.Controls.Add(Me.Fecha1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtCliente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnFacturas)
        Me.Controls.Add(Me.TxtNofactura)
        Me.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Rep_Facturas"
        Me.Text = "Rep_Facturas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Fecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnFacturas As System.Windows.Forms.Button
    Friend WithEvents TxtNofactura As System.Windows.Forms.TextBox
    Friend WithEvents LblCliente As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Limpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Rep_pdf As System.Windows.Forms.ToolStripButton
End Class
