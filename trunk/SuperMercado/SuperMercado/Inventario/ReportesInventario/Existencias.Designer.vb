<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Existencias
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

    'Para el control de una sola instancia por formulario.
#Region "  Modificación del constructor  "
    ' En esta constructora es que cambio la propiedad Public por la propiedad Private
    Private Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Private Shared ChildInstance As Existencias = Nothing

    'controla que sólo exista una instancia del formulario.

    Public Shared Function Instance() As Existencias
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New Existencias
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
#End Region


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Existencias))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Impresion = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.DataGrid1 = New SourceGrid.DataGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblTotal = New System.Windows.Forms.Label
        Me.LblReg = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Impresion, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 48)
        Me.ToolStrip1.TabIndex = 245
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Impresion
        '
        Me.Impresion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Impresion.Image = CType(resources.GetObject("Impresion.Image"), System.Drawing.Image)
        Me.Impresion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Impresion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Impresion.Name = "Impresion"
        Me.Impresion.Size = New System.Drawing.Size(52, 45)
        Me.Impresion.Text = "Imprimir"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 45)
        Me.ToolStripButton1.Text = "Ayuda"
        '
        'DataGrid1
        '
        Me.DataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid1.BackColor = System.Drawing.Color.Transparent
        Me.DataGrid1.DeleteQuestionMessage = "Are you sure to delete all the selected rows?"
        Me.DataGrid1.FixedRows = 1
        Me.DataGrid1.Location = New System.Drawing.Point(12, 167)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.SelectionMode = SourceGrid.GridSelectionMode.Row
        Me.DataGrid1.Size = New System.Drawing.Size(984, 496)
        Me.DataGrid1.TabIndex = 244
        Me.DataGrid1.TabStop = True
        Me.DataGrid1.ToolTipText = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 22)
        Me.Label1.TabIndex = 246
        Me.Label1.Text = "Consulta de existencias"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(801, 131)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(98, 16)
        Me.LblTotal.TabIndex = 249
        Me.LblTotal.Text = "Monto Total:"
        '
        'LblReg
        '
        Me.LblReg.AutoSize = True
        Me.LblReg.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReg.Location = New System.Drawing.Point(794, 107)
        Me.LblReg.Name = "LblReg"
        Me.LblReg.Size = New System.Drawing.Size(105, 16)
        Me.LblReg.TabIndex = 248
        Me.LblReg.Text = "No.Registros:"
        '
        'Existencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 702)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.LblReg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "Existencias"
        Me.Text = "Existencias"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Impresion As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGrid1 As SourceGrid.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents LblReg As System.Windows.Forms.Label
End Class
