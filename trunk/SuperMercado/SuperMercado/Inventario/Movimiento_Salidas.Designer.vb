<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movimiento_Salidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Movimiento_Salidas))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Limpiar = New System.Windows.Forms.ToolStripButton
        Me.Nuevo = New System.Windows.Forms.ToolStripButton
        Me.Grabar = New System.Windows.Forms.ToolStripButton
        Me.GroupBoxSalida = New System.Windows.Forms.GroupBox
        Me.SalidaDetalles = New SourceGrid.DataGrid
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.Fecha = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.FolioSalida = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Barra = New System.Windows.Forms.PictureBox
        Me.PiePagina = New System.Windows.Forms.StatusStrip
        Me.MensajePiePagina = New System.Windows.Forms.ToolStripStatusLabel
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBoxSalida.SuspendLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PiePagina.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Limpiar, Me.Nuevo, Me.Grabar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1016, 52)
        Me.ToolStrip1.TabIndex = 3
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
        Me.Limpiar.Text = "Nuevo"
        '
        'Nuevo
        '
        Me.Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Nuevo.Image = CType(resources.GetObject("Nuevo.Image"), System.Drawing.Image)
        Me.Nuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(36, 49)
        Me.Nuevo.Text = "Nuevo"
        '
        'Grabar
        '
        Me.Grabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Grabar.Image = CType(resources.GetObject("Grabar.Image"), System.Drawing.Image)
        Me.Grabar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Grabar.Name = "Grabar"
        Me.Grabar.Size = New System.Drawing.Size(36, 49)
        Me.Grabar.Text = "Grabar"
        '
        'GroupBoxSalida
        '
        Me.GroupBoxSalida.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxSalida.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxSalida.Controls.Add(Me.SalidaDetalles)
        Me.GroupBoxSalida.Controls.Add(Me.txtDescripcion)
        Me.GroupBoxSalida.Controls.Add(Me.Fecha)
        Me.GroupBoxSalida.Controls.Add(Me.Label5)
        Me.GroupBoxSalida.Controls.Add(Me.Label2)
        Me.GroupBoxSalida.Location = New System.Drawing.Point(19, 159)
        Me.GroupBoxSalida.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxSalida.Name = "GroupBoxSalida"
        Me.GroupBoxSalida.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxSalida.Size = New System.Drawing.Size(962, 517)
        Me.GroupBoxSalida.TabIndex = 237
        Me.GroupBoxSalida.TabStop = False
        Me.GroupBoxSalida.Text = "Datos de Salida"
        '
        'SalidaDetalles
        '
        Me.SalidaDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SalidaDetalles.DeleteQuestionMessage = "Are you sure to delete all the selected rows?"
        Me.SalidaDetalles.FixedRows = 1
        Me.SalidaDetalles.Location = New System.Drawing.Point(15, 99)
        Me.SalidaDetalles.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SalidaDetalles.Name = "SalidaDetalles"
        Me.SalidaDetalles.SelectionMode = SourceGrid.GridSelectionMode.Row
        Me.SalidaDetalles.Size = New System.Drawing.Size(930, 412)
        Me.SalidaDetalles.TabIndex = 6
        Me.SalidaDetalles.TabStop = True
        Me.SalidaDetalles.ToolTipText = ""
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(82, 55)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(863, 22)
        Me.txtDescripcion.TabIndex = 5
        '
        'Fecha
        '
        Me.Fecha.Location = New System.Drawing.Point(82, 27)
        Me.Fecha.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(265, 22)
        Me.Fecha.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(1, 59)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Descripcion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(35, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 62)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 236
        Me.Label4.Text = "Salidas"
        '
        'FolioSalida
        '
        Me.FolioSalida.BackColor = System.Drawing.SystemColors.Info
        Me.FolioSalida.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FolioSalida.Location = New System.Drawing.Point(76, 103)
        Me.FolioSalida.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FolioSalida.MaxLength = 9
        Me.FolioSalida.Name = "FolioSalida"
        Me.FolioSalida.Size = New System.Drawing.Size(108, 22)
        Me.FolioSalida.TabIndex = 235
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 106)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 14)
        Me.Label1.TabIndex = 234
        Me.Label1.Text = "Código"
        '
        'Barra
        '
        Me.Barra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Barra.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Barra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Barra.Location = New System.Drawing.Point(-4, 138)
        Me.Barra.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(1096, 4)
        Me.Barra.TabIndex = 233
        Me.Barra.TabStop = False
        '
        'PiePagina
        '
        Me.PiePagina.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PiePagina.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PiePagina.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MensajePiePagina})
        Me.PiePagina.Location = New System.Drawing.Point(0, 694)
        Me.PiePagina.Name = "PiePagina"
        Me.PiePagina.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.PiePagina.Size = New System.Drawing.Size(1016, 22)
        Me.PiePagina.SizingGrip = False
        Me.PiePagina.TabIndex = 238
        Me.PiePagina.Text = "StatusStrip1"
        '
        'MensajePiePagina
        '
        Me.MensajePiePagina.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MensajePiePagina.Name = "MensajePiePagina"
        Me.MensajePiePagina.Size = New System.Drawing.Size(150, 17)
        Me.MensajePiePagina.Text = "ToolStripStatusLabel1"
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.btnAceptar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(896, 103)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 27)
        Me.btnAceptar.TabIndex = 239
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'Movimiento_Salidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 716)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.PiePagina)
        Me.Controls.Add(Me.GroupBoxSalida)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FolioSalida)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Movimiento_Salidas"
        Me.Text = "Salidas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBoxSalida.ResumeLayout(False)
        Me.GroupBoxSalida.PerformLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PiePagina.ResumeLayout(False)
        Me.PiePagina.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Limpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBoxSalida As System.Windows.Forms.GroupBox
    Friend WithEvents SalidaDetalles As SourceGrid.DataGrid
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FolioSalida As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Barra As System.Windows.Forms.PictureBox
    Friend WithEvents PiePagina As System.Windows.Forms.StatusStrip
    Friend WithEvents MensajePiePagina As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Nuevo As System.Windows.Forms.ToolStripButton
End Class
