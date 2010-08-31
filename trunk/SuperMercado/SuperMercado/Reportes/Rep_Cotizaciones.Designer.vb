<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rep_Cotizaciones
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Limpiar = New System.Windows.Forms.ToolStripButton
        Me.Rep_pdf = New System.Windows.Forms.ToolStripButton
        Me.Fecha2 = New System.Windows.Forms.DateTimePicker
        Me.Fecha1 = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtCliente = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.BtnRep = New System.Windows.Forms.Button
        Me.TxtCotizacion = New System.Windows.Forms.TextBox
        Me.LblCliente = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        'Fecha2
        '
        Me.Fecha2.Location = New System.Drawing.Point(464, 101)
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.Size = New System.Drawing.Size(245, 22)
        Me.Fecha2.TabIndex = 239
        '
        'Fecha1
        '
        Me.Fecha1.Location = New System.Drawing.Point(136, 101)
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.Size = New System.Drawing.Size(251, 22)
        Me.Fecha1.TabIndex = 238
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(400, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 15)
        Me.Label9.TabIndex = 237
        Me.Label9.Text = "hasta el"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(75, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 15)
        Me.Label10.TabIndex = 236
        Me.Label10.Text = "Desde el"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(86, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 15)
        Me.Label11.TabIndex = 235
        Me.Label11.Text = "Cliente"
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(136, 162)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(100, 22)
        Me.TxtCliente.TabIndex = 234
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 15)
        Me.Label12.TabIndex = 233
        Me.Label12.Text = "Numero Cotizacion"
        '
        'BtnRep
        '
        Me.BtnRep.Location = New System.Drawing.Point(816, 158)
        Me.BtnRep.Name = "BtnRep"
        Me.BtnRep.Size = New System.Drawing.Size(132, 23)
        Me.BtnRep.TabIndex = 232
        Me.BtnRep.Text = "Reporte Cotizaciones"
        Me.BtnRep.UseVisualStyleBackColor = True
        '
        'TxtCotizacion
        '
        Me.TxtCotizacion.Location = New System.Drawing.Point(136, 130)
        Me.TxtCotizacion.Name = "TxtCotizacion"
        Me.TxtCotizacion.Size = New System.Drawing.Size(100, 22)
        Me.TxtCotizacion.TabIndex = 231
        '
        'LblCliente
        '
        Me.LblCliente.AutoEllipsis = True
        Me.LblCliente.BackColor = System.Drawing.Color.Transparent
        Me.LblCliente.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCliente.Location = New System.Drawing.Point(242, 162)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(529, 22)
        Me.LblCliente.TabIndex = 350
        Me.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Rep_Cotizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 702)
        Me.Controls.Add(Me.LblCliente)
        Me.Controls.Add(Me.Fecha2)
        Me.Controls.Add(Me.Fecha1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtCliente)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BtnRep)
        Me.Controls.Add(Me.TxtCotizacion)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Rep_Cotizaciones"
        Me.Text = "Rep_Cotizaciones"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Limpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Rep_pdf As System.Windows.Forms.ToolStripButton
    Friend WithEvents Fecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtnRep As System.Windows.Forms.Button
    Friend WithEvents TxtCotizacion As System.Windows.Forms.TextBox
    Friend WithEvents LblCliente As System.Windows.Forms.Label
End Class
