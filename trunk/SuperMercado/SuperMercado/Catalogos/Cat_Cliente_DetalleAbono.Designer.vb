﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cat_Cliente_DetalleAbono
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
        Me.GridDatosAbonos = New SourceGrid.DataGrid
        Me.SuspendLayout()
        '
        'GridDatosAbonos
        '
        Me.GridDatosAbonos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDatosAbonos.BackColor = System.Drawing.SystemColors.Control
        Me.GridDatosAbonos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridDatosAbonos.DeleteQuestionMessage = ""
        Me.GridDatosAbonos.DeleteRowsWithDeleteKey = False
        Me.GridDatosAbonos.FixedRows = 1
        Me.GridDatosAbonos.Location = New System.Drawing.Point(12, 12)
        Me.GridDatosAbonos.Name = "GridDatosAbonos"
        Me.GridDatosAbonos.SelectionMode = SourceGrid.GridSelectionMode.Row
        Me.GridDatosAbonos.Size = New System.Drawing.Size(294, 374)
        Me.GridDatosAbonos.TabIndex = 35
        Me.GridDatosAbonos.TabStop = True
        Me.GridDatosAbonos.ToolTipText = ""
        '
        'Cat_Cliente_DetalleAbono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 398)
        Me.Controls.Add(Me.GridDatosAbonos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Cat_Cliente_DetalleAbono"
        Me.Text = "  Abonos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridDatosAbonos As SourceGrid.DataGrid
End Class