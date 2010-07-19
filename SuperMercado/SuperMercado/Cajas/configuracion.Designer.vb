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
        Me.components = New System.ComponentModel.Container
        Me.ChBxDineroInicial = New System.Windows.Forms.CheckBox
        Me.GrBxDineroInicial = New System.Windows.Forms.GroupBox
        Me.dinIniPredeterminado = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.ChBxLimitesMaximos = New System.Windows.Forms.CheckBox
        Me.GrBxLimites = New System.Windows.Forms.GroupBox
        Me.montoMaximo = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GrBxDineroInicial.SuspendLayout()
        CType(Me.dinIniPredeterminado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrBxLimites.SuspendLayout()
        CType(Me.montoMaximo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChBxDineroInicial
        '
        Me.ChBxDineroInicial.AutoSize = True
        Me.ChBxDineroInicial.Location = New System.Drawing.Point(14, 19)
        Me.ChBxDineroInicial.Name = "ChBxDineroInicial"
        Me.ChBxDineroInicial.Size = New System.Drawing.Size(164, 17)
        Me.ChBxDineroInicial.TabIndex = 0
        Me.ChBxDineroInicial.Text = "Utilizar el mismo monto inicial."
        Me.ChBxDineroInicial.UseVisualStyleBackColor = True
        '
        'GrBxDineroInicial
        '
        Me.GrBxDineroInicial.Controls.Add(Me.dinIniPredeterminado)
        Me.GrBxDineroInicial.Controls.Add(Me.Label2)
        Me.GrBxDineroInicial.Enabled = False
        Me.GrBxDineroInicial.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GrBxDineroInicial.Location = New System.Drawing.Point(14, 42)
        Me.GrBxDineroInicial.Name = "GrBxDineroInicial"
        Me.GrBxDineroInicial.Size = New System.Drawing.Size(247, 58)
        Me.GrBxDineroInicial.TabIndex = 2
        Me.GrBxDineroInicial.TabStop = False
        Me.GrBxDineroInicial.Text = " Dinero inicial "
        '
        'dinIniPredeterminado
        '
        Me.dinIniPredeterminado.DecimalPlaces = 2
        Me.dinIniPredeterminado.Location = New System.Drawing.Point(87, 24)
        Me.dinIniPredeterminado.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.dinIniPredeterminado.Name = "dinIniPredeterminado"
        Me.dinIniPredeterminado.Size = New System.Drawing.Size(120, 20)
        Me.dinIniPredeterminado.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(29, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad:"
        '
        'ChBxLimitesMaximos
        '
        Me.ChBxLimitesMaximos.AutoSize = True
        Me.ChBxLimitesMaximos.Location = New System.Drawing.Point(14, 119)
        Me.ChBxLimitesMaximos.Name = "ChBxLimitesMaximos"
        Me.ChBxLimitesMaximos.Size = New System.Drawing.Size(173, 17)
        Me.ChBxLimitesMaximos.TabIndex = 3
        Me.ChBxLimitesMaximos.Text = "Activar monto máximo en caja. "
        Me.ChBxLimitesMaximos.UseVisualStyleBackColor = True
        '
        'GrBxLimites
        '
        Me.GrBxLimites.Controls.Add(Me.montoMaximo)
        Me.GrBxLimites.Controls.Add(Me.Label3)
        Me.GrBxLimites.Enabled = False
        Me.GrBxLimites.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GrBxLimites.Location = New System.Drawing.Point(14, 142)
        Me.GrBxLimites.Name = "GrBxLimites"
        Me.GrBxLimites.Size = New System.Drawing.Size(247, 58)
        Me.GrBxLimites.TabIndex = 4
        Me.GrBxLimites.TabStop = False
        Me.GrBxLimites.Text = " Monto máximo "
        '
        'montoMaximo
        '
        Me.montoMaximo.DecimalPlaces = 2
        Me.montoMaximo.Location = New System.Drawing.Point(87, 25)
        Me.montoMaximo.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.montoMaximo.Name = "montoMaximo"
        Me.montoMaximo.Size = New System.Drawing.Size(120, 20)
        Me.montoMaximo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(29, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad:"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.SuperMercado.My.Resources.Resources.cross
        Me.BtnCancelar.Location = New System.Drawing.Point(173, 220)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(88, 23)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = Global.SuperMercado.My.Resources.Resources.tick
        Me.btnAceptar.Location = New System.Drawing.Point(79, 220)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(88, 23)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 258)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.GrBxLimites)
        Me.Controls.Add(Me.ChBxLimitesMaximos)
        Me.Controls.Add(Me.GrBxDineroInicial)
        Me.Controls.Add(Me.ChBxDineroInicial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "configuracion"
        Me.Text = " Configuración "
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
    Friend WithEvents GrBxDineroInicial As System.Windows.Forms.GroupBox
    Friend WithEvents dinIniPredeterminado As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChBxLimitesMaximos As System.Windows.Forms.CheckBox
    Friend WithEvents GrBxLimites As System.Windows.Forms.GroupBox
    Friend WithEvents montoMaximo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
