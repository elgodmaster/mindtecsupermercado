<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Salidas))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Impresion = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGrid1 = New SourceGrid.DataGrid
        Me.LblReg = New System.Windows.Forms.Label
        Me.LblTotal = New System.Windows.Forms.Label
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
        Me.ToolStrip1.TabIndex = 243
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 22)
        Me.Label1.TabIndex = 242
        Me.Label1.Text = "Consulta de salidas"
        '
        'DataGrid1
        '
        Me.DataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid1.BackColor = System.Drawing.Color.Transparent
        Me.DataGrid1.DeleteQuestionMessage = "Are you sure to delete all the selected rows?"
        Me.DataGrid1.FixedRows = 1
        Me.DataGrid1.Location = New System.Drawing.Point(12, 158)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.SelectionMode = SourceGrid.GridSelectionMode.Row
        Me.DataGrid1.Size = New System.Drawing.Size(984, 527)
        Me.DataGrid1.TabIndex = 241
        Me.DataGrid1.TabStop = True
        Me.DataGrid1.ToolTipText = ""
        '
        'LblReg
        '
        Me.LblReg.AutoSize = True
        Me.LblReg.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReg.Location = New System.Drawing.Point(793, 106)
        Me.LblReg.Name = "LblReg"
        Me.LblReg.Size = New System.Drawing.Size(105, 16)
        Me.LblReg.TabIndex = 244
        Me.LblReg.Text = "No.Registros:"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(797, 130)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(98, 16)
        Me.LblTotal.TabIndex = 245
        Me.LblTotal.Text = "Monto Total:"
        '
        'Salidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 702)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.LblReg)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "Salidas"
        Me.Text = "Salidas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Impresion As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As SourceGrid.DataGrid
    Friend WithEvents LblReg As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
End Class
