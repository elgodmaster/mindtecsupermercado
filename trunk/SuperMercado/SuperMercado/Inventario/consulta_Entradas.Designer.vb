<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consulta_Entradas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consulta_Entradas))
        Me.DataGrid1 = New SourceGrid.DataGrid
        Me.Label4 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Barra = New System.Windows.Forms.PictureBox
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.BackColor = System.Drawing.Color.Transparent
        Me.DataGrid1.DeleteQuestionMessage = "Are you sure to delete all the selected rows?"
        Me.DataGrid1.FixedRows = 1
        Me.DataGrid1.Location = New System.Drawing.Point(65, 184)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.SelectionMode = SourceGrid.GridSelectionMode.Row
        Me.DataGrid1.Size = New System.Drawing.Size(881, 410)
        Me.DataGrid1.TabIndex = 237
        Me.DataGrid1.TabStop = True
        Me.DataGrid1.ToolTipText = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 236
        Me.Label4.Text = "Entradas"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1016, 48)
        Me.ToolStrip1.TabIndex = 235
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Barra
        '
        Me.Barra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Barra.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Barra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Barra.Location = New System.Drawing.Point(0, 147)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(1024, 4)
        Me.Barra.TabIndex = 234
        Me.Barra.TabStop = False
        '
        'consulta_Entradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 716)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Barra)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "consulta_Entradas"
        Me.Text = "Consulta de Entradas"
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGrid1 As SourceGrid.DataGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Barra As System.Windows.Forms.PictureBox
End Class
