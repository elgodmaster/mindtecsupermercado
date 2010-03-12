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
        Me.PassWord2 = New System.Windows.Forms.TextBox
        Me.PassWord1 = New System.Windows.Forms.TextBox
        Me.TxTPassWord2 = New System.Windows.Forms.Label
        Me.TxTPassWord1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Version = New System.Windows.Forms.Label
        Me.CambiarPassWord = New System.Windows.Forms.CheckBox
        Me.Btn_Cancelar = New System.Windows.Forms.Button
        Me.Btn_Aceptar = New System.Windows.Forms.Button
        Me.PassWord = New System.Windows.Forms.TextBox
        Me.Usuario = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'PassWord2
        '
        Me.PassWord2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PassWord2.Location = New System.Drawing.Point(363, 255)
        Me.PassWord2.MaxLength = 20
        Me.PassWord2.Name = "PassWord2"
        Me.PassWord2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.PassWord2.Size = New System.Drawing.Size(182, 22)
        Me.PassWord2.TabIndex = 21
        Me.PassWord2.Visible = False
        '
        'PassWord1
        '
        Me.PassWord1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PassWord1.Location = New System.Drawing.Point(363, 229)
        Me.PassWord1.MaxLength = 20
        Me.PassWord1.Name = "PassWord1"
        Me.PassWord1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.PassWord1.Size = New System.Drawing.Size(182, 22)
        Me.PassWord1.TabIndex = 20
        Me.PassWord1.Visible = False
        '
        'TxTPassWord2
        '
        Me.TxTPassWord2.AutoSize = True
        Me.TxTPassWord2.BackColor = System.Drawing.Color.Transparent
        Me.TxTPassWord2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTPassWord2.Location = New System.Drawing.Point(287, 255)
        Me.TxTPassWord2.Name = "TxTPassWord2"
        Me.TxTPassWord2.Size = New System.Drawing.Size(70, 16)
        Me.TxTPassWord2.TabIndex = 25
        Me.TxTPassWord2.Text = "Confirmar"
        Me.TxTPassWord2.Visible = False
        '
        'TxTPassWord1
        '
        Me.TxTPassWord1.AutoSize = True
        Me.TxTPassWord1.BackColor = System.Drawing.Color.Transparent
        Me.TxTPassWord1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTPassWord1.Location = New System.Drawing.Point(274, 229)
        Me.TxTPassWord1.Name = "TxTPassWord1"
        Me.TxTPassWord1.Size = New System.Drawing.Size(83, 16)
        Me.TxTPassWord1.TabIndex = 24
        Me.TxTPassWord1.Text = "Contraseña"
        Me.TxTPassWord1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(325, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Teclear su Nueva Contraseña"
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Version.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New System.Drawing.Point(0, 287)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(63, 16)
        Me.Version.TabIndex = 22
        Me.Version.Text = "Version"
        '
        'CambiarPassWord
        '
        Me.CambiarPassWord.AutoSize = True
        Me.CambiarPassWord.BackColor = System.Drawing.Color.Transparent
        Me.CambiarPassWord.Location = New System.Drawing.Point(527, 142)
        Me.CambiarPassWord.Name = "CambiarPassWord"
        Me.CambiarPassWord.Size = New System.Drawing.Size(156, 18)
        Me.CambiarPassWord.TabIndex = 19
        Me.CambiarPassWord.Text = "Cambiar Contraseña"
        Me.CambiarPassWord.UseVisualStyleBackColor = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(568, 102)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(80, 20)
        Me.Btn_Cancelar.TabIndex = 18
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Aceptar
        '
        Me.Btn_Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.Btn_Aceptar.Location = New System.Drawing.Point(568, 66)
        Me.Btn_Aceptar.Name = "Btn_Aceptar"
        Me.Btn_Aceptar.Size = New System.Drawing.Size(80, 20)
        Me.Btn_Aceptar.TabIndex = 16
        Me.Btn_Aceptar.Text = "Aceptar"
        Me.Btn_Aceptar.UseVisualStyleBackColor = True
        '
        'PassWord
        '
        Me.PassWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PassWord.Location = New System.Drawing.Point(363, 102)
        Me.PassWord.MaxLength = 20
        Me.PassWord.Name = "PassWord"
        Me.PassWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.PassWord.Size = New System.Drawing.Size(182, 22)
        Me.PassWord.TabIndex = 14
        '
        'Usuario
        '
        Me.Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Usuario.Location = New System.Drawing.Point(363, 66)
        Me.Usuario.MaxLength = 20
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(182, 22)
        Me.Usuario.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(274, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Usuario"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 303)
        Me.Controls.Add(Me.PassWord2)
        Me.Controls.Add(Me.PassWord1)
        Me.Controls.Add(Me.TxTPassWord2)
        Me.Controls.Add(Me.TxTPassWord1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.CambiarPassWord)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Aceptar)
        Me.Controls.Add(Me.PassWord)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PassWord2 As System.Windows.Forms.TextBox
    Friend WithEvents PassWord1 As System.Windows.Forms.TextBox
    Friend WithEvents TxTPassWord2 As System.Windows.Forms.Label
    Friend WithEvents TxTPassWord1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents CambiarPassWord As System.Windows.Forms.CheckBox
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents PassWord As System.Windows.Forms.TextBox
    Friend WithEvents Usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
