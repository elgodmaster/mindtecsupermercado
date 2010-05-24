<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.textBoxConNuevoPassword = New System.Windows.Forms.TextBox
        Me.textBoxNuevoPassword = New System.Windows.Forms.TextBox
        Me.TxTPassWord2 = New System.Windows.Forms.Label
        Me.TxTPassWord1 = New System.Windows.Forms.Label
        Me.Version = New System.Windows.Forms.Label
        Me.buttonCancelar = New System.Windows.Forms.Button
        Me.buttonAceptar = New System.Windows.Forms.Button
        Me.textBoxPassword = New System.Windows.Forms.TextBox
        Me.textBoxUsuario = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ButtonCancelarContraseña = New System.Windows.Forms.Button
        Me.ButtonGuardar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'textBoxConNuevoPassword
        '
        Me.textBoxConNuevoPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textBoxConNuevoPassword.Location = New System.Drawing.Point(179, 57)
        Me.textBoxConNuevoPassword.MaxLength = 20
        Me.textBoxConNuevoPassword.Name = "textBoxConNuevoPassword"
        Me.textBoxConNuevoPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textBoxConNuevoPassword.Size = New System.Drawing.Size(182, 22)
        Me.textBoxConNuevoPassword.TabIndex = 7
        '
        'textBoxNuevoPassword
        '
        Me.textBoxNuevoPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textBoxNuevoPassword.Location = New System.Drawing.Point(179, 29)
        Me.textBoxNuevoPassword.MaxLength = 20
        Me.textBoxNuevoPassword.Name = "textBoxNuevoPassword"
        Me.textBoxNuevoPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textBoxNuevoPassword.Size = New System.Drawing.Size(182, 22)
        Me.textBoxNuevoPassword.TabIndex = 6
        '
        'TxTPassWord2
        '
        Me.TxTPassWord2.AutoSize = True
        Me.TxTPassWord2.BackColor = System.Drawing.Color.Transparent
        Me.TxTPassWord2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTPassWord2.Location = New System.Drawing.Point(39, 31)
        Me.TxTPassWord2.Name = "TxTPassWord2"
        Me.TxTPassWord2.Size = New System.Drawing.Size(134, 16)
        Me.TxTPassWord2.TabIndex = 25
        Me.TxTPassWord2.Text = "Nueva contraseña:"
        '
        'TxTPassWord1
        '
        Me.TxTPassWord1.AutoSize = True
        Me.TxTPassWord1.BackColor = System.Drawing.Color.Transparent
        Me.TxTPassWord1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTPassWord1.Location = New System.Drawing.Point(18, 59)
        Me.TxTPassWord1.Name = "TxTPassWord1"
        Me.TxTPassWord1.Size = New System.Drawing.Size(155, 16)
        Me.TxTPassWord1.TabIndex = 24
        Me.TxTPassWord1.Text = "Confirmar contraseña:"
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Version.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New System.Drawing.Point(0, 307)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(63, 16)
        Me.Version.TabIndex = 22
        Me.Version.Text = "Version"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonCancelar.Location = New System.Drawing.Point(584, 89)
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(92, 30)
        Me.buttonCancelar.TabIndex = 4
        Me.buttonCancelar.Text = "Cancelar"
        Me.buttonCancelar.UseVisualStyleBackColor = True
        '
        'buttonAceptar
        '
        Me.buttonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.buttonAceptar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAceptar.ForeColor = System.Drawing.Color.Black
        Me.buttonAceptar.Location = New System.Drawing.Point(584, 55)
        Me.buttonAceptar.Name = "buttonAceptar"
        Me.buttonAceptar.Size = New System.Drawing.Size(92, 30)
        Me.buttonAceptar.TabIndex = 3
        Me.buttonAceptar.Text = "Aceptar"
        Me.buttonAceptar.UseVisualStyleBackColor = True
        '
        'textBoxPassword
        '
        Me.textBoxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textBoxPassword.Location = New System.Drawing.Point(379, 94)
        Me.textBoxPassword.MaxLength = 20
        Me.textBoxPassword.Name = "textBoxPassword"
        Me.textBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textBoxPassword.Size = New System.Drawing.Size(182, 22)
        Me.textBoxPassword.TabIndex = 2
        '
        'textBoxUsuario
        '
        Me.textBoxUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textBoxUsuario.Location = New System.Drawing.Point(379, 60)
        Me.textBoxUsuario.MaxLength = 20
        Me.textBoxUsuario.Name = "textBoxUsuario"
        Me.textBoxUsuario.Size = New System.Drawing.Size(182, 22)
        Me.textBoxUsuario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(311, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Usuario:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonCancelarContraseña)
        Me.GroupBox1.Controls.Add(Me.ButtonGuardar)
        Me.GroupBox1.Controls.Add(Me.TxTPassWord1)
        Me.GroupBox1.Controls.Add(Me.textBoxConNuevoPassword)
        Me.GroupBox1.Controls.Add(Me.TxTPassWord2)
        Me.GroupBox1.Controls.Add(Me.textBoxNuevoPassword)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(293, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 136)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'ButtonCancelarContraseña
        '
        Me.ButtonCancelarContraseña.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelarContraseña.Location = New System.Drawing.Point(284, 97)
        Me.ButtonCancelarContraseña.Name = "ButtonCancelarContraseña"
        Me.ButtonCancelarContraseña.Size = New System.Drawing.Size(93, 30)
        Me.ButtonCancelarContraseña.TabIndex = 9
        Me.ButtonCancelarContraseña.Text = "Cancelar"
        Me.ButtonCancelarContraseña.UseVisualStyleBackColor = True
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardar.Location = New System.Drawing.Point(185, 97)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(93, 30)
        Me.ButtonGuardar.TabIndex = 8
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(284, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(361, 14)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Por favor ingrese su usuario y contraseña para acceder."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(290, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 14)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Cambiar contraseña actual"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 323)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.buttonCancelar)
        Me.Controls.Add(Me.buttonAceptar)
        Me.Controls.Add(Me.textBoxPassword)
        Me.Controls.Add(Me.textBoxUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Login"
        Me.Text = "  SuperMercado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textBoxConNuevoPassword As System.Windows.Forms.TextBox
    Friend WithEvents textBoxNuevoPassword As System.Windows.Forms.TextBox
    Friend WithEvents TxTPassWord2 As System.Windows.Forms.Label
    Friend WithEvents TxTPassWord1 As System.Windows.Forms.Label
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents buttonCancelar As System.Windows.Forms.Button
    Friend WithEvents buttonAceptar As System.Windows.Forms.Button
    Friend WithEvents textBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents textBoxUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonCancelarContraseña As System.Windows.Forms.Button
    Friend WithEvents ButtonGuardar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
