<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Devoluciones
    Inherits System.Windows.Forms.Form

#Region "  Modificación del constructor  "
    ' En esta constructora es que cambio la propiedad Public por la propiedad Private
    Private Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Private Shared ChildInstance As Devoluciones = Nothing

    'controla que sólo exista una instancia del formulario.

    Public Shared Function Instance() As Devoluciones
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New Devoluciones
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
#End Region

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
        Me.DevolucionToolStrip = New System.Windows.Forms.ToolStrip
        Me.ButtonLimpiar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonDevolver = New System.Windows.Forms.ToolStripButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.textBoxTicket = New System.Windows.Forms.TextBox
        Me.PanelDev = New System.Windows.Forms.Panel
        Me.TextBoxTotal = New System.Windows.Forms.TextBox
        Me.GridDatosTicket = New SourceGrid.DataGrid
        Me.lblLiquidado = New System.Windows.Forms.Label
        Me.TextBoxFecha = New System.Windows.Forms.TextBox
        Me.TextBoxCajero = New System.Windows.Forms.TextBox
        Me.TextBoxNumTicket = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Barra = New System.Windows.Forms.PictureBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.DevolucionToolStrip.SuspendLayout()
        Me.PanelDev.SuspendLayout()
        Me.GridDatosTicket.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DevolucionToolStrip
        '
        Me.DevolucionToolStrip.AutoSize = False
        Me.DevolucionToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonLimpiar, Me.ToolStripButtonDevolver})
        Me.DevolucionToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.DevolucionToolStrip.Name = "DevolucionToolStrip"
        Me.DevolucionToolStrip.Size = New System.Drawing.Size(919, 48)
        Me.DevolucionToolStrip.TabIndex = 305
        Me.DevolucionToolStrip.Text = "ToolStrip1"
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.AutoSize = False
        Me.ButtonLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonLimpiar.Image = Global.SuperMercado.My.Resources.Resources.page
        Me.ButtonLimpiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ButtonLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(43, 45)
        Me.ButtonLimpiar.Text = "Limpiar"
        '
        'ToolStripButtonDevolver
        '
        Me.ToolStripButtonDevolver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonDevolver.Image = Global.SuperMercado.My.Resources.Resources.basket_remove
        Me.ToolStripButtonDevolver.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonDevolver.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDevolver.Name = "ToolStripButtonDevolver"
        Me.ToolStripButtonDevolver.Size = New System.Drawing.Size(36, 45)
        Me.ToolStripButtonDevolver.Text = "Devolver artículo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 60)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 20)
        Me.Label4.TabIndex = 306
        Me.Label4.Text = "Devoluciones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 14)
        Me.Label1.TabIndex = 308
        Me.Label1.Text = "Número del Ticket: "
        '
        'textBoxTicket
        '
        Me.textBoxTicket.BackColor = System.Drawing.SystemColors.HighlightText
        Me.textBoxTicket.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textBoxTicket.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxTicket.Location = New System.Drawing.Point(140, 95)
        Me.textBoxTicket.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.textBoxTicket.MaxLength = 50
        Me.textBoxTicket.Name = "textBoxTicket"
        Me.textBoxTicket.Size = New System.Drawing.Size(170, 22)
        Me.textBoxTicket.TabIndex = 309
        '
        'PanelDev
        '
        Me.PanelDev.Controls.Add(Me.TextBoxTotal)
        Me.PanelDev.Controls.Add(Me.GridDatosTicket)
        Me.PanelDev.Controls.Add(Me.TextBoxFecha)
        Me.PanelDev.Controls.Add(Me.TextBoxCajero)
        Me.PanelDev.Controls.Add(Me.TextBoxNumTicket)
        Me.PanelDev.Controls.Add(Me.PictureBox1)
        Me.PanelDev.Location = New System.Drawing.Point(16, 148)
        Me.PanelDev.Name = "PanelDev"
        Me.PanelDev.Size = New System.Drawing.Size(485, 515)
        Me.PanelDev.TabIndex = 336
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxTotal.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotal.Location = New System.Drawing.Point(178, 458)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(56, 12)
        Me.TextBoxTotal.TabIndex = 341
        Me.TextBoxTotal.Text = "????"
        Me.TextBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GridDatosTicket
        '
        Me.GridDatosTicket.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridDatosTicket.Controls.Add(Me.lblLiquidado)
        Me.GridDatosTicket.DeleteQuestionMessage = ""
        Me.GridDatosTicket.DeleteRowsWithDeleteKey = False
        Me.GridDatosTicket.FixedRows = 1
        Me.GridDatosTicket.Location = New System.Drawing.Point(28, 110)
        Me.GridDatosTicket.Name = "GridDatosTicket"
        Me.GridDatosTicket.SelectionMode = SourceGrid.GridSelectionMode.Row
        Me.GridDatosTicket.Size = New System.Drawing.Size(275, 299)
        Me.GridDatosTicket.TabIndex = 340
        Me.GridDatosTicket.TabStop = True
        Me.GridDatosTicket.ToolTipText = ""
        '
        'lblLiquidado
        '
        Me.lblLiquidado.AutoSize = True
        Me.lblLiquidado.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLiquidado.ForeColor = System.Drawing.Color.Red
        Me.lblLiquidado.Location = New System.Drawing.Point(16, 126)
        Me.lblLiquidado.Name = "lblLiquidado"
        Me.lblLiquidado.Size = New System.Drawing.Size(233, 29)
        Me.lblLiquidado.TabIndex = 4
        Me.lblLiquidado.Text = "VENTA LIQUIDADA"
        '
        'TextBoxFecha
        '
        Me.TextBoxFecha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxFecha.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFecha.Location = New System.Drawing.Point(31, 82)
        Me.TextBoxFecha.Name = "TextBoxFecha"
        Me.TextBoxFecha.Size = New System.Drawing.Size(255, 12)
        Me.TextBoxFecha.TabIndex = 339
        Me.TextBoxFecha.Text = "????"
        '
        'TextBoxCajero
        '
        Me.TextBoxCajero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCajero.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCajero.Location = New System.Drawing.Point(120, 57)
        Me.TextBoxCajero.Name = "TextBoxCajero"
        Me.TextBoxCajero.Size = New System.Drawing.Size(166, 12)
        Me.TextBoxCajero.TabIndex = 338
        Me.TextBoxCajero.Text = "????"
        '
        'TextBoxNumTicket
        '
        Me.TextBoxNumTicket.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxNumTicket.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNumTicket.Location = New System.Drawing.Point(94, 31)
        Me.TextBoxNumTicket.Name = "TextBoxNumTicket"
        Me.TextBoxNumTicket.Size = New System.Drawing.Size(51, 12)
        Me.TextBoxNumTicket.TabIndex = 337
        Me.TextBoxNumTicket.Text = "????"
        Me.TextBoxNumTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SuperMercado.My.Resources.Resources.tickte3
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(464, 504)
        Me.PictureBox1.TabIndex = 336
        Me.PictureBox1.TabStop = False
        '
        'Barra
        '
        Me.Barra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Barra.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Barra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Barra.Location = New System.Drawing.Point(-135, 132)
        Me.Barra.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(1454, 4)
        Me.Barra.TabIndex = 310
        Me.Barra.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 666)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(919, 22)
        Me.StatusStrip1.TabIndex = 337
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(353, 17)
        Me.ToolStripStatusLabel1.Text = "Escriba un número de Ticket y teclee 'Enter' para mostrar la información."
        '
        'Devoluciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 688)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PanelDev)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.textBoxTicket)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DevolucionToolStrip)
        Me.Name = "Devoluciones"
        Me.Text = "Devoluciones"
        Me.DevolucionToolStrip.ResumeLayout(False)
        Me.DevolucionToolStrip.PerformLayout()
        Me.PanelDev.ResumeLayout(False)
        Me.PanelDev.PerformLayout()
        Me.GridDatosTicket.ResumeLayout(False)
        Me.GridDatosTicket.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DevolucionToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ButtonLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents textBoxTicket As System.Windows.Forms.TextBox
    Friend WithEvents Barra As System.Windows.Forms.PictureBox
    Friend WithEvents PanelDev As System.Windows.Forms.Panel
    Friend WithEvents TextBoxTotal As System.Windows.Forms.TextBox
    Friend WithEvents GridDatosTicket As SourceGrid.DataGrid
    Friend WithEvents TextBoxFecha As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCajero As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNumTicket As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripButtonDevolver As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblLiquidado As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
End Class
