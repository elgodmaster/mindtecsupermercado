<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cat_Proveedores_DetalleVenta
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
        Me.GridDatosDetalle = New SourceGrid.DataGrid
        Me.SuspendLayout()
        '
        'GridDatosDetalle
        '
        Me.GridDatosDetalle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GridDatosDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridDatosDetalle.DeleteQuestionMessage = ""
        Me.GridDatosDetalle.DeleteRowsWithDeleteKey = False
        Me.GridDatosDetalle.FixedRows = 1
        Me.GridDatosDetalle.Location = New System.Drawing.Point(12, 12)
        Me.GridDatosDetalle.Name = "GridDatosDetalle"
        Me.GridDatosDetalle.SelectionMode = SourceGrid.GridSelectionMode.Row
        Me.GridDatosDetalle.Size = New System.Drawing.Size(480, 302)
        Me.GridDatosDetalle.TabIndex = 34
        Me.GridDatosDetalle.TabStop = True
        Me.GridDatosDetalle.ToolTipText = ""
        '
        'Cat_Proveedores_DetalleVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 343)
        Me.Controls.Add(Me.GridDatosDetalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Cat_Proveedores_DetalleVenta"
        Me.Text = "  Detalle"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridDatosDetalle As SourceGrid.DataGrid
End Class
