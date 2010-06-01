<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cambioUsuario
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
        Me.textBoxPassword = New System.Windows.Forms.TextBox
        Me.textBoxUsuario = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ButtonAceptar = New System.Windows.Forms.Button
        Me.ButtonCancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese su nombre de usuario y contraseña para cambiar de usuario."
        '
        'textBoxPassword
        '
        Me.textBoxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textBoxPassword.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxPassword.Location = New System.Drawing.Point(108, 89)
        Me.textBoxPassword.MaxLength = 20
        Me.textBoxPassword.Name = "textBoxPassword"
        Me.textBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textBoxPassword.Size = New System.Drawing.Size(182, 22)
        Me.textBoxPassword.TabIndex = 2
        '
        'textBoxUsuario
        '
        Me.textBoxUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textBoxUsuario.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxUsuario.Location = New System.Drawing.Point(108, 55)
        Me.textBoxUsuario.MaxLength = 20
        Me.textBoxUsuario.Name = "textBoxUsuario"
        Me.textBoxUsuario.Size = New System.Drawing.Size(182, 22)
        Me.textBoxUsuario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 14)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 14)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Usuario:"
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAceptar.Location = New System.Drawing.Point(317, 50)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(103, 28)
        Me.ButtonAceptar.TabIndex = 3
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelar.Location = New System.Drawing.Point(317, 85)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(103, 27)
        Me.ButtonCancelar.TabIndex = 4
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'cambioUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 127)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.textBoxPassword)
        Me.Controls.Add(Me.textBoxUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "cambioUsuario"
        Me.Text = " Cambio de Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents textBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents textBoxUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonAceptar As System.Windows.Forms.Button
    Friend WithEvents ButtonCancelar As System.Windows.Forms.Button
End Class
