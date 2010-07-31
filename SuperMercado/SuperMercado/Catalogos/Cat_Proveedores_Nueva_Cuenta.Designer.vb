<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cat_Proveedores_Nueva_Cuenta
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxProducto = New System.Windows.Forms.TextBox
        Me.NumericUpDownCantidad = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDownCosto = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.ButtonCancelar = New System.Windows.Forms.Button
        Me.ButtonAceptar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBoxFactura = New System.Windows.Forms.TextBox
        CType(Me.NumericUpDownCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Costo:"
        '
        'TextBoxProducto
        '
        Me.TextBoxProducto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxProducto.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProducto.Location = New System.Drawing.Point(94, 54)
        Me.TextBoxProducto.Name = "TextBoxProducto"
        Me.TextBoxProducto.Size = New System.Drawing.Size(282, 22)
        Me.TextBoxProducto.TabIndex = 1
        '
        'NumericUpDownCantidad
        '
        Me.NumericUpDownCantidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDownCantidad.DecimalPlaces = 2
        Me.NumericUpDownCantidad.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownCantidad.Location = New System.Drawing.Point(94, 110)
        Me.NumericUpDownCantidad.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUpDownCantidad.Name = "NumericUpDownCantidad"
        Me.NumericUpDownCantidad.Size = New System.Drawing.Size(120, 22)
        Me.NumericUpDownCantidad.TabIndex = 3
        '
        'NumericUpDownCosto
        '
        Me.NumericUpDownCosto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDownCosto.DecimalPlaces = 2
        Me.NumericUpDownCosto.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownCosto.Location = New System.Drawing.Point(94, 138)
        Me.NumericUpDownCosto.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.NumericUpDownCosto.Name = "NumericUpDownCosto"
        Me.NumericUpDownCosto.Size = New System.Drawing.Size(120, 22)
        Me.NumericUpDownCosto.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(364, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Escriba el nombre de un producto, la cantidad y el costo."
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelar.Image = Global.SuperMercado.My.Resources.Resources.cross
        Me.ButtonCancelar.Location = New System.Drawing.Point(128, 190)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(101, 28)
        Me.ButtonCancelar.TabIndex = 10
        Me.ButtonCancelar.Text = " Cancelar"
        Me.ButtonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAceptar.Image = Global.SuperMercado.My.Resources.Resources.tick
        Me.ButtonAceptar.Location = New System.Drawing.Point(21, 190)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(101, 28)
        Me.ButtonAceptar.TabIndex = 9
        Me.ButtonAceptar.Text = " Aceptar"
        Me.ButtonAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 14)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Factura:"
        '
        'TextBoxFactura
        '
        Me.TextBoxFactura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxFactura.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFactura.Location = New System.Drawing.Point(94, 82)
        Me.TextBoxFactura.Name = "TextBoxFactura"
        Me.TextBoxFactura.Size = New System.Drawing.Size(282, 22)
        Me.TextBoxFactura.TabIndex = 2
        '
        'Cat_Proveedores_Nueva_Cuenta
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(396, 230)
        Me.Controls.Add(Me.TextBoxFactura)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericUpDownCosto)
        Me.Controls.Add(Me.NumericUpDownCantidad)
        Me.Controls.Add(Me.TextBoxProducto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Cat_Proveedores_Nueva_Cuenta"
        Me.Text = " Nueva cuenta"
        CType(Me.NumericUpDownCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownCosto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxProducto As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDownCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownCosto As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtonCancelar As System.Windows.Forms.Button
    Friend WithEvents ButtonAceptar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxFactura As System.Windows.Forms.TextBox
End Class
