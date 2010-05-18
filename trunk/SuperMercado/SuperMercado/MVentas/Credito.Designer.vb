<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Credito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Credito))
        Me.CodigoCliente = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Nuevo = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NombreCliente = New System.Windows.Forms.Label
        Me.Email = New System.Windows.Forms.Label
        Me.Telefono = New System.Windows.Forms.Label
        Me.Direccion = New System.Windows.Forms.Label
        Me.RFC = New System.Windows.Forms.Label
        Me.BtnCargar = New System.Windows.Forms.Button
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.RBVariosArticulos = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RBUnArticulo = New System.Windows.Forms.RadioButton
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoCliente
        '
        Me.CodigoCliente.BackColor = System.Drawing.Color.LemonChiffon
        Me.CodigoCliente.Location = New System.Drawing.Point(69, 48)
        Me.CodigoCliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CodigoCliente.Name = "CodigoCliente"
        Me.CodigoCliente.Size = New System.Drawing.Size(132, 22)
        Me.CodigoCliente.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nuevo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(599, 39)
        Me.ToolStrip1.TabIndex = 231
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Nuevo
        '
        Me.Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Nuevo.Image = CType(resources.GetObject("Nuevo.Image"), System.Drawing.Image)
        Me.Nuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(36, 36)
        Me.Nuevo.Text = "Nuevo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NombreCliente)
        Me.GroupBox1.Controls.Add(Me.Email)
        Me.GroupBox1.Controls.Add(Me.Telefono)
        Me.GroupBox1.Controls.Add(Me.Direccion)
        Me.GroupBox1.Controls.Add(Me.RFC)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(575, 148)
        Me.GroupBox1.TabIndex = 236
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos generales"
        '
        'NombreCliente
        '
        Me.NombreCliente.AutoSize = True
        Me.NombreCliente.Location = New System.Drawing.Point(6, 21)
        Me.NombreCliente.Name = "NombreCliente"
        Me.NombreCliente.Size = New System.Drawing.Size(56, 14)
        Me.NombreCliente.TabIndex = 240
        Me.NombreCliente.Text = "Nombre"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Location = New System.Drawing.Point(17, 125)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(45, 14)
        Me.Email.TabIndex = 239
        Me.Email.Text = "E-mail"
        '
        'Telefono
        '
        Me.Telefono.AutoSize = True
        Me.Telefono.Location = New System.Drawing.Point(1, 99)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(61, 14)
        Me.Telefono.TabIndex = 238
        Me.Telefono.Text = "Telefono"
        '
        'Direccion
        '
        Me.Direccion.AutoSize = True
        Me.Direccion.Location = New System.Drawing.Point(-1, 73)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(63, 14)
        Me.Direccion.TabIndex = 237
        Me.Direccion.Text = "Direccion"
        '
        'RFC
        '
        Me.RFC.AutoSize = True
        Me.RFC.Location = New System.Drawing.Point(31, 47)
        Me.RFC.Name = "RFC"
        Me.RFC.Size = New System.Drawing.Size(31, 14)
        Me.RFC.TabIndex = 236
        Me.RFC.Text = "RFC"
        '
        'BtnCargar
        '
        Me.BtnCargar.Location = New System.Drawing.Point(431, 34)
        Me.BtnCargar.Name = "BtnCargar"
        Me.BtnCargar.Size = New System.Drawing.Size(138, 31)
        Me.BtnCargar.TabIndex = 240
        Me.BtnCargar.Text = "Cargar venta  (F5)"
        Me.BtnCargar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(512, 47)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 237
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'RBVariosArticulos
        '
        Me.RBVariosArticulos.AutoSize = True
        Me.RBVariosArticulos.Location = New System.Drawing.Point(9, 45)
        Me.RBVariosArticulos.Name = "RBVariosArticulos"
        Me.RBVariosArticulos.Size = New System.Drawing.Size(247, 18)
        Me.RBVariosArticulos.TabIndex = 241
        Me.RBVariosArticulos.Tag = "2"
        Me.RBVariosArticulos.Text = "Varios articulos en la misma cuenta"
        Me.RBVariosArticulos.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBUnArticulo)
        Me.GroupBox2.Controls.Add(Me.RBVariosArticulos)
        Me.GroupBox2.Controls.Add(Me.BtnCargar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 230)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(575, 71)
        Me.GroupBox2.TabIndex = 242
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Venta"
        '
        'RBUnArticulo
        '
        Me.RBUnArticulo.AutoSize = True
        Me.RBUnArticulo.Checked = True
        Me.RBUnArticulo.Location = New System.Drawing.Point(9, 21)
        Me.RBUnArticulo.Name = "RBUnArticulo"
        Me.RBUnArticulo.Size = New System.Drawing.Size(122, 18)
        Me.RBUnArticulo.TabIndex = 242
        Me.RBUnArticulo.TabStop = True
        Me.RBUnArticulo.Tag = "1"
        Me.RBUnArticulo.Text = "Un solo articulo"
        Me.RBUnArticulo.UseVisualStyleBackColor = True
        '
        'Credito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 327)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CodigoCliente)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Credito"
        Me.Text = "Credito"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CodigoCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCargar As System.Windows.Forms.Button
    Friend WithEvents Email As System.Windows.Forms.Label
    Friend WithEvents Telefono As System.Windows.Forms.Label
    Friend WithEvents Direccion As System.Windows.Forms.Label
    Friend WithEvents RFC As System.Windows.Forms.Label
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents NombreCliente As System.Windows.Forms.Label
    Friend WithEvents RBVariosArticulos As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RBUnArticulo As System.Windows.Forms.RadioButton
End Class
