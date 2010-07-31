<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cat_Marcas
    Inherits System.Windows.Forms.Form

    'Para el control de una sola instancia por formulario.
#Region "  Modificación del constructor  "
    ' En esta constructora es que cambio la propiedad Public por la propiedad Private
    Private Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Private Shared ChildInstance As Cat_Marcas = Nothing

    'controla que sólo exista una instancia del formulario.

    Public Shared Function Instance() As Cat_Marcas
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New Cat_Marcas
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
#End Region

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cat_Marcas))
        Me.GroupBoxMarca = New System.Windows.Forms.GroupBox
        Me.Descripcion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Barra = New System.Windows.Forms.PictureBox
        Me.CodigoMarca = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Buscar = New System.Windows.Forms.ToolStripButton
        Me.Nuevo = New System.Windows.Forms.ToolStripButton
        Me.Limpiar = New System.Windows.Forms.ToolStripButton
        Me.Grabar = New System.Windows.Forms.ToolStripButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabelClientes = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBoxMarca.SuspendLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxMarca
        '
        Me.GroupBoxMarca.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxMarca.Controls.Add(Me.Descripcion)
        Me.GroupBoxMarca.Controls.Add(Me.Label2)
        Me.GroupBoxMarca.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxMarca.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBoxMarca.Location = New System.Drawing.Point(14, 148)
        Me.GroupBoxMarca.Name = "GroupBoxMarca"
        Me.GroupBoxMarca.Size = New System.Drawing.Size(977, 520)
        Me.GroupBoxMarca.TabIndex = 222
        Me.GroupBoxMarca.TabStop = False
        Me.GroupBoxMarca.Text = " Datos de la marca "
        Me.GroupBoxMarca.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Descripcion.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.Location = New System.Drawing.Point(106, 43)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(849, 22)
        Me.Descripcion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(17, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Descripción:"
        '
        'Barra
        '
        Me.Barra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Barra.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Barra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Barra.Location = New System.Drawing.Point(0, 128)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(1024, 4)
        Me.Barra.TabIndex = 221
        Me.Barra.TabStop = False
        '
        'CodigoMarca
        '
        Me.CodigoMarca.BackColor = System.Drawing.SystemColors.Info
        Me.CodigoMarca.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoMarca.Location = New System.Drawing.Point(67, 93)
        Me.CodigoMarca.MaxLength = 9
        Me.CodigoMarca.Name = "CodigoMarca"
        Me.CodigoMarca.Size = New System.Drawing.Size(254, 22)
        Me.CodigoMarca.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 14)
        Me.Label1.TabIndex = 219
        Me.Label1.Text = "Marca:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Buscar, Me.Nuevo, Me.Limpiar, Me.Grabar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1016, 48)
        Me.ToolStrip1.TabIndex = 227
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Buscar
        '
        Me.Buscar.AutoSize = False
        Me.Buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Buscar.Image = Global.SuperMercado.My.Resources.Resources.zoom
        Me.Buscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Buscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(43, 45)
        Me.Buscar.Text = "Buscar"
        '
        'Nuevo
        '
        Me.Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Nuevo.Image = Global.SuperMercado.My.Resources.Resources.add
        Me.Nuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(36, 45)
        Me.Nuevo.Text = "Nuevo"
        '
        'Limpiar
        '
        Me.Limpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Limpiar.Image = Global.SuperMercado.My.Resources.Resources.page
        Me.Limpiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Limpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(36, 45)
        Me.Limpiar.Text = "Limpiar"
        '
        'Grabar
        '
        Me.Grabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Grabar.Image = Global.SuperMercado.My.Resources.Resources.disk
        Me.Grabar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Grabar.Name = "Grabar"
        Me.Grabar.Size = New System.Drawing.Size(36, 45)
        Me.Grabar.Text = "Grabar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 20)
        Me.Label4.TabIndex = 228
        Me.Label4.Text = "Catálogo de Marcas"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelClientes})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 686)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1016, 22)
        Me.StatusStrip1.TabIndex = 295
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelClientes
        '
        Me.ToolStripStatusLabelClientes.Name = "ToolStripStatusLabelClientes"
        Me.ToolStripStatusLabelClientes.Size = New System.Drawing.Size(538, 17)
        Me.ToolStripStatusLabelClientes.Text = "Escriba un número de identificación para mostrar los datos de una marca, o pulse " & _
            "F2 para mostrar un catálogo."
        '
        'Cat_Marcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 708)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBoxMarca)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.CodigoMarca)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Cat_Marcas"
        Me.Text = "Catálogo de marcas"
        Me.GroupBoxMarca.ResumeLayout(False)
        Me.GroupBoxMarca.PerformLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxMarca As System.Windows.Forms.GroupBox
    Friend WithEvents Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Barra As System.Windows.Forms.PictureBox
    Friend WithEvents CodigoMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Buscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabelClientes As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Limpiar As System.Windows.Forms.ToolStripButton
End Class
