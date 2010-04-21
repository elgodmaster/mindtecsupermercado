<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configuracion
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
        Me.ChBxDineroInicial = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GrBxDineroInicial = New System.Windows.Forms.GroupBox
        Me.dinIniPredeterminado = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.ChBxLimitesMaximos = New System.Windows.Forms.CheckBox
        Me.GrBxLimites = New System.Windows.Forms.GroupBox
        Me.montoMaximo = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.GrBxDineroInicial.SuspendLayout()
        CType(Me.dinIniPredeterminado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrBxLimites.SuspendLayout()
        CType(Me.montoMaximo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChBxDineroInicial
        '
        Me.ChBxDineroInicial.AutoSize = True
        Me.ChBxDineroInicial.Location = New System.Drawing.Point(24, 46)
        Me.ChBxDineroInicial.Name = "ChBxDineroInicial"
        Me.ChBxDineroInicial.Size = New System.Drawing.Size(175, 17)
        Me.ChBxDineroInicial.TabIndex = 0
        Me.ChBxDineroInicial.Text = "Activar ""recordar dinero inicial""."
        Me.ChBxDineroInicial.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Opciones"
        '
        'GrBxDineroInicial
        '
        Me.GrBxDineroInicial.Controls.Add(Me.dinIniPredeterminado)
        Me.GrBxDineroInicial.Controls.Add(Me.Label2)
        Me.GrBxDineroInicial.Enabled = False
        Me.GrBxDineroInicial.Location = New System.Drawing.Point(24, 69)
        Me.GrBxDineroInicial.Name = "GrBxDineroInicial"
        Me.GrBxDineroInicial.Size = New System.Drawing.Size(247, 58)
        Me.GrBxDineroInicial.TabIndex = 2
        Me.GrBxDineroInicial.TabStop = False
        Me.GrBxDineroInicial.Text = "Dinero inicial."
        '
        'dinIniPredeterminado
        '
        Me.dinIniPredeterminado.Location = New System.Drawing.Point(87, 24)
        Me.dinIniPredeterminado.Name = "dinIniPredeterminado"
        Me.dinIniPredeterminado.Size = New System.Drawing.Size(120, 20)
        Me.dinIniPredeterminado.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad:"
        '
        'ChBxLimitesMaximos
        '
        Me.ChBxLimitesMaximos.AutoSize = True
        Me.ChBxLimitesMaximos.Location = New System.Drawing.Point(24, 146)
        Me.ChBxLimitesMaximos.Name = "ChBxLimitesMaximos"
        Me.ChBxLimitesMaximos.Size = New System.Drawing.Size(173, 17)
        Me.ChBxLimitesMaximos.TabIndex = 3
        Me.ChBxLimitesMaximos.Text = "Activar monto máxima en caja. "
        Me.ChBxLimitesMaximos.UseVisualStyleBackColor = True
        '
        'GrBxLimites
        '
        Me.GrBxLimites.Controls.Add(Me.montoMaximo)
        Me.GrBxLimites.Controls.Add(Me.Label3)
        Me.GrBxLimites.Enabled = False
        Me.GrBxLimites.Location = New System.Drawing.Point(24, 169)
        Me.GrBxLimites.Name = "GrBxLimites"
        Me.GrBxLimites.Size = New System.Drawing.Size(247, 58)
        Me.GrBxLimites.TabIndex = 4
        Me.GrBxLimites.TabStop = False
        Me.GrBxLimites.Text = "Monto máximo."
        '
        'montoMaximo
        '
        Me.montoMaximo.Location = New System.Drawing.Point(87, 25)
        Me.montoMaximo.Name = "montoMaximo"
        Me.montoMaximo.Size = New System.Drawing.Size(120, 20)
        Me.montoMaximo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad:"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(213, 251)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(131, 251)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(76, 23)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 294)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.GrBxLimites)
        Me.Controls.Add(Me.ChBxLimitesMaximos)
        Me.Controls.Add(Me.GrBxDineroInicial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChBxDineroInicial)
        Me.Name = "configuracion"
        Me.Text = "Configuración de caja"
        Me.GrBxDineroInicial.ResumeLayout(False)
        Me.GrBxDineroInicial.PerformLayout()
        CType(Me.dinIniPredeterminado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrBxLimites.ResumeLayout(False)
        Me.GrBxLimites.PerformLayout()
        CType(Me.montoMaximo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChBxDineroInicial As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrBxDineroInicial As System.Windows.Forms.GroupBox
    Friend WithEvents dinIniPredeterminado As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChBxLimitesMaximos As System.Windows.Forms.CheckBox
    Friend WithEvents GrBxLimites As System.Windows.Forms.GroupBox
    Friend WithEvents montoMaximo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class
