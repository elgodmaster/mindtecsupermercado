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
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.textBoxCodigo = New System.Windows.Forms.TextBox
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox
        Me.TextBoxCP = New System.Windows.Forms.TextBox
        Me.TextBoxDireccion = New System.Windows.Forms.TextBox
        Me.TextBoxRFC = New System.Windows.Forms.TextBox
        Me.CP = New System.Windows.Forms.Label
        Me.Telefono = New System.Windows.Forms.Label
        Me.Direccion = New System.Windows.Forms.Label
        Me.RFC = New System.Windows.Forms.Label
        Me.RBVariosArticulos = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RBUnArticulo = New System.Windows.Forms.RadioButton
        Me.ComboBoxNombreCliente = New System.Windows.Forms.ComboBox
        Me.ButtonCargarVenta = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCodigo)
        Me.GroupBox1.Controls.Add(Me.textBoxCodigo)
        Me.GroupBox1.Controls.Add(Me.TextBoxTelefono)
        Me.GroupBox1.Controls.Add(Me.TextBoxCP)
        Me.GroupBox1.Controls.Add(Me.TextBoxDireccion)
        Me.GroupBox1.Controls.Add(Me.TextBoxRFC)
        Me.GroupBox1.Controls.Add(Me.CP)
        Me.GroupBox1.Controls.Add(Me.Telefono)
        Me.GroupBox1.Controls.Add(Me.Direccion)
        Me.GroupBox1.Controls.Add(Me.RFC)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(575, 183)
        Me.GroupBox1.TabIndex = 236
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Datos generales "
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(18, 30)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(56, 14)
        Me.lblCodigo.TabIndex = 247
        Me.lblCodigo.Text = "Código:"
        '
        'textBoxCodigo
        '
        Me.textBoxCodigo.Enabled = False
        Me.textBoxCodigo.Location = New System.Drawing.Point(80, 27)
        Me.textBoxCodigo.Name = "textBoxCodigo"
        Me.textBoxCodigo.Size = New System.Drawing.Size(147, 22)
        Me.textBoxCodigo.TabIndex = 246
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Enabled = False
        Me.TextBoxTelefono.Location = New System.Drawing.Point(80, 139)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(147, 22)
        Me.TextBoxTelefono.TabIndex = 245
        '
        'TextBoxCP
        '
        Me.TextBoxCP.Enabled = False
        Me.TextBoxCP.Location = New System.Drawing.Point(80, 111)
        Me.TextBoxCP.Name = "TextBoxCP"
        Me.TextBoxCP.Size = New System.Drawing.Size(147, 22)
        Me.TextBoxCP.TabIndex = 244
        '
        'TextBoxDireccion
        '
        Me.TextBoxDireccion.Enabled = False
        Me.TextBoxDireccion.Location = New System.Drawing.Point(80, 83)
        Me.TextBoxDireccion.Name = "TextBoxDireccion"
        Me.TextBoxDireccion.Size = New System.Drawing.Size(489, 22)
        Me.TextBoxDireccion.TabIndex = 243
        '
        'TextBoxRFC
        '
        Me.TextBoxRFC.Enabled = False
        Me.TextBoxRFC.Location = New System.Drawing.Point(80, 55)
        Me.TextBoxRFC.Name = "TextBoxRFC"
        Me.TextBoxRFC.Size = New System.Drawing.Size(223, 22)
        Me.TextBoxRFC.TabIndex = 242
        '
        'CP
        '
        Me.CP.AutoSize = True
        Me.CP.Location = New System.Drawing.Point(45, 114)
        Me.CP.Name = "CP"
        Me.CP.Size = New System.Drawing.Size(29, 14)
        Me.CP.TabIndex = 241
        Me.CP.Text = "CP:"
        '
        'Telefono
        '
        Me.Telefono.AutoSize = True
        Me.Telefono.Location = New System.Drawing.Point(8, 142)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(66, 14)
        Me.Telefono.TabIndex = 238
        Me.Telefono.Text = "Telefono:"
        '
        'Direccion
        '
        Me.Direccion.AutoSize = True
        Me.Direccion.Location = New System.Drawing.Point(6, 86)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(68, 14)
        Me.Direccion.TabIndex = 237
        Me.Direccion.Text = "Direccion:"
        '
        'RFC
        '
        Me.RFC.AutoSize = True
        Me.RFC.Location = New System.Drawing.Point(38, 58)
        Me.RFC.Name = "RFC"
        Me.RFC.Size = New System.Drawing.Size(36, 14)
        Me.RFC.TabIndex = 236
        Me.RFC.Text = "RFC:"
        '
        'RBVariosArticulos
        '
        Me.RBVariosArticulos.AutoSize = True
        Me.RBVariosArticulos.Checked = True
        Me.RBVariosArticulos.Location = New System.Drawing.Point(17, 25)
        Me.RBVariosArticulos.Name = "RBVariosArticulos"
        Me.RBVariosArticulos.Size = New System.Drawing.Size(251, 18)
        Me.RBVariosArticulos.TabIndex = 241
        Me.RBVariosArticulos.TabStop = True
        Me.RBVariosArticulos.Tag = "3"
        Me.RBVariosArticulos.Text = " Varios articulos en la misma cuenta"
        Me.RBVariosArticulos.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBUnArticulo)
        Me.GroupBox2.Controls.Add(Me.RBVariosArticulos)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 244)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(575, 86)
        Me.GroupBox2.TabIndex = 242
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Venta "
        '
        'RBUnArticulo
        '
        Me.RBUnArticulo.AutoSize = True
        Me.RBUnArticulo.Location = New System.Drawing.Point(17, 49)
        Me.RBUnArticulo.Name = "RBUnArticulo"
        Me.RBUnArticulo.Size = New System.Drawing.Size(126, 18)
        Me.RBUnArticulo.TabIndex = 242
        Me.RBUnArticulo.Tag = "4"
        Me.RBUnArticulo.Text = " Un solo articulo"
        Me.RBUnArticulo.UseVisualStyleBackColor = True
        '
        'ComboBoxNombreCliente
        '
        Me.ComboBoxNombreCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxNombreCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxNombreCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNombreCliente.FormattingEnabled = True
        Me.ComboBoxNombreCliente.Location = New System.Drawing.Point(92, 19)
        Me.ComboBoxNombreCliente.Name = "ComboBoxNombreCliente"
        Me.ComboBoxNombreCliente.Size = New System.Drawing.Size(280, 22)
        Me.ComboBoxNombreCliente.TabIndex = 1
        '
        'ButtonCargarVenta
        '
        Me.ButtonCargarVenta.Image = Global.SuperMercado.My.Resources.Resources.accept
        Me.ButtonCargarVenta.Location = New System.Drawing.Point(428, 348)
        Me.ButtonCargarVenta.Name = "ButtonCargarVenta"
        Me.ButtonCargarVenta.Size = New System.Drawing.Size(159, 31)
        Me.ButtonCargarVenta.TabIndex = 5
        Me.ButtonCargarVenta.Text = "  Cargar Venta"
        Me.ButtonCargarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCargarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonCargarVenta.UseVisualStyleBackColor = True
        '
        'Credito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 391)
        Me.Controls.Add(Me.ButtonCargarVenta)
        Me.Controls.Add(Me.ComboBoxNombreCliente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Credito"
        Me.Text = " Credito"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Telefono As System.Windows.Forms.Label
    Friend WithEvents Direccion As System.Windows.Forms.Label
    Friend WithEvents RFC As System.Windows.Forms.Label
    Friend WithEvents RBVariosArticulos As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RBUnArticulo As System.Windows.Forms.RadioButton
    Friend WithEvents CP As System.Windows.Forms.Label
    Friend WithEvents ComboBoxNombreCliente As System.Windows.Forms.ComboBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents textBoxCodigo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCP As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDireccion As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRFC As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCargarVenta As System.Windows.Forms.Button
End Class
