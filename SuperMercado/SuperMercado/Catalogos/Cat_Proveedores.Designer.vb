<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cat_Proveedores
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

    Private Shared ChildInstance As Cat_Proveedores = Nothing

    'controla que sólo exista una instancia del formulario.

    Public Shared Function Instance() As Cat_Proveedores
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New Cat_Proveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cat_Proveedores))
        Me.PiePagina = New System.Windows.Forms.StatusStrip
        Me.MensajePiePagina = New System.Windows.Forms.ToolStripStatusLabel
        Me.CodigoProveedor = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBoxProveedor = New System.Windows.Forms.GroupBox
        Me.GroupBoxLocalizacion = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtExt2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtExt = New System.Windows.Forms.TextBox
        Me.TxtMail = New System.Windows.Forms.TextBox
        Me.TxtFax = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtCel = New System.Windows.Forms.TextBox
        Me.TxtTel = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtCel2 = New System.Windows.Forms.TextBox
        Me.TxtTel2 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBoxProveedores = New System.Windows.Forms.GroupBox
        Me.txtRfc = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Txtcp = New System.Windows.Forms.TextBox
        Me.Labelcp = New System.Windows.Forms.Label
        Me.TxtDireccion = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtColonia = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.NombreCiudad = New System.Windows.Forms.Label
        Me.TxtCiudad = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.NombreEstado = New System.Windows.Forms.Label
        Me.TxtEstado = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TxtNombre = New System.Windows.Forms.TextBox
        Me.LblNombres = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.NombreProveedor = New System.Windows.Forms.Label
        Me.Barra = New System.Windows.Forms.PictureBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.BarraMenu = New System.Windows.Forms.ToolStrip
        Me.Limpiar = New System.Windows.Forms.ToolStripButton
        Me.Grabar = New System.Windows.Forms.ToolStripButton
        Me.PiePagina.SuspendLayout()
        Me.GroupBoxProveedor.SuspendLayout()
        Me.GroupBoxLocalizacion.SuspendLayout()
        Me.GroupBoxProveedores.SuspendLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PiePagina
        '
        Me.PiePagina.BackColor = System.Drawing.SystemColors.Info
        Me.PiePagina.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PiePagina.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MensajePiePagina})
        Me.PiePagina.Location = New System.Drawing.Point(0, 686)
        Me.PiePagina.Name = "PiePagina"
        Me.PiePagina.Size = New System.Drawing.Size(1016, 22)
        Me.PiePagina.SizingGrip = False
        Me.PiePagina.TabIndex = 217
        Me.PiePagina.Text = "StatusStrip1"
        '
        'MensajePiePagina
        '
        Me.MensajePiePagina.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MensajePiePagina.Name = "MensajePiePagina"
        Me.MensajePiePagina.Size = New System.Drawing.Size(150, 17)
        Me.MensajePiePagina.Text = "ToolStripStatusLabel1"
        '
        'CodigoProveedor
        '
        Me.CodigoProveedor.BackColor = System.Drawing.SystemColors.Info
        Me.CodigoProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoProveedor.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoProveedor.Location = New System.Drawing.Point(83, 93)
        Me.CodigoProveedor.MaxLength = 50
        Me.CodigoProveedor.Name = "CodigoProveedor"
        Me.CodigoProveedor.Size = New System.Drawing.Size(115, 22)
        Me.CodigoProveedor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 14)
        Me.Label1.TabIndex = 263
        Me.Label1.Text = "Proveedor"
        '
        'GroupBoxProveedor
        '
        Me.GroupBoxProveedor.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxProveedor.Controls.Add(Me.GroupBoxLocalizacion)
        Me.GroupBoxProveedor.Controls.Add(Me.GroupBoxProveedores)
        Me.GroupBoxProveedor.Location = New System.Drawing.Point(14, 148)
        Me.GroupBoxProveedor.Name = "GroupBoxProveedor"
        Me.GroupBoxProveedor.Size = New System.Drawing.Size(970, 535)
        Me.GroupBoxProveedor.TabIndex = 266
        Me.GroupBoxProveedor.TabStop = False
        Me.GroupBoxProveedor.Text = "Datos Proveedor"
        Me.GroupBoxProveedor.Visible = False
        '
        'GroupBoxLocalizacion
        '
        Me.GroupBoxLocalizacion.Controls.Add(Me.Label3)
        Me.GroupBoxLocalizacion.Controls.Add(Me.TxtExt2)
        Me.GroupBoxLocalizacion.Controls.Add(Me.Label2)
        Me.GroupBoxLocalizacion.Controls.Add(Me.TxtExt)
        Me.GroupBoxLocalizacion.Controls.Add(Me.TxtMail)
        Me.GroupBoxLocalizacion.Controls.Add(Me.TxtFax)
        Me.GroupBoxLocalizacion.Controls.Add(Me.Label11)
        Me.GroupBoxLocalizacion.Controls.Add(Me.Label6)
        Me.GroupBoxLocalizacion.Controls.Add(Me.Label10)
        Me.GroupBoxLocalizacion.Controls.Add(Me.TxtCel)
        Me.GroupBoxLocalizacion.Controls.Add(Me.TxtTel)
        Me.GroupBoxLocalizacion.Controls.Add(Me.Label7)
        Me.GroupBoxLocalizacion.Controls.Add(Me.Label9)
        Me.GroupBoxLocalizacion.Controls.Add(Me.TxtCel2)
        Me.GroupBoxLocalizacion.Controls.Add(Me.TxtTel2)
        Me.GroupBoxLocalizacion.Controls.Add(Me.Label8)
        Me.GroupBoxLocalizacion.Location = New System.Drawing.Point(4, 296)
        Me.GroupBoxLocalizacion.Name = "GroupBoxLocalizacion"
        Me.GroupBoxLocalizacion.Size = New System.Drawing.Size(960, 186)
        Me.GroupBoxLocalizacion.TabIndex = 281
        Me.GroupBoxLocalizacion.TabStop = False
        Me.GroupBoxLocalizacion.Text = "Datos de localización"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(750, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 14)
        Me.Label3.TabIndex = 282
        Me.Label3.Text = "Ext2"
        '
        'TxtExt2
        '
        Me.TxtExt2.Location = New System.Drawing.Point(786, 49)
        Me.TxtExt2.Name = "TxtExt2"
        Me.TxtExt2.Size = New System.Drawing.Size(126, 22)
        Me.TxtExt2.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 14)
        Me.Label2.TabIndex = 280
        Me.Label2.Text = "Ext"
        '
        'TxtExt
        '
        Me.TxtExt.Location = New System.Drawing.Point(304, 49)
        Me.TxtExt.Name = "TxtExt"
        Me.TxtExt.Size = New System.Drawing.Size(126, 22)
        Me.TxtExt.TabIndex = 12
        '
        'TxtMail
        '
        Me.TxtMail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMail.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMail.Location = New System.Drawing.Point(72, 21)
        Me.TxtMail.MaxLength = 100
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(840, 22)
        Me.TxtMail.TabIndex = 10
        '
        'TxtFax
        '
        Me.TxtFax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFax.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFax.Location = New System.Drawing.Point(72, 138)
        Me.TxtFax.MaxLength = 100
        Me.TxtFax.Name = "TxtFax"
        Me.TxtFax.Size = New System.Drawing.Size(840, 22)
        Me.TxtFax.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(26, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 14)
        Me.Label11.TabIndex = 273
        Me.Label11.Text = "E-mail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 14)
        Me.Label6.TabIndex = 278
        Me.Label6.Text = "Fax"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 14)
        Me.Label10.TabIndex = 274
        Me.Label10.Text = "Teléfono"
        '
        'TxtCel
        '
        Me.TxtCel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCel.Location = New System.Drawing.Point(72, 80)
        Me.TxtCel.MaxLength = 100
        Me.TxtCel.Name = "TxtCel"
        Me.TxtCel.Size = New System.Drawing.Size(840, 22)
        Me.TxtCel.TabIndex = 15
        '
        'TxtTel
        '
        Me.TxtTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTel.Location = New System.Drawing.Point(72, 49)
        Me.TxtTel.MaxLength = 100
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(170, 22)
        Me.TxtTel.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 14)
        Me.Label7.TabIndex = 277
        Me.Label7.Text = "Celular"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(473, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 14)
        Me.Label9.TabIndex = 275
        Me.Label9.Text = "Teléfono2"
        '
        'TxtCel2
        '
        Me.TxtCel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCel2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCel2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCel2.Location = New System.Drawing.Point(72, 108)
        Me.TxtCel2.MaxLength = 100
        Me.TxtCel2.Name = "TxtCel2"
        Me.TxtCel2.Size = New System.Drawing.Size(840, 22)
        Me.TxtCel2.TabIndex = 16
        '
        'TxtTel2
        '
        Me.TxtTel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTel2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTel2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTel2.Location = New System.Drawing.Point(542, 50)
        Me.TxtTel2.MaxLength = 100
        Me.TxtTel2.Name = "TxtTel2"
        Me.TxtTel2.Size = New System.Drawing.Size(160, 22)
        Me.TxtTel2.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 14)
        Me.Label8.TabIndex = 276
        Me.Label8.Text = "Celular2"
        '
        'GroupBoxProveedores
        '
        Me.GroupBoxProveedores.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxProveedores.Controls.Add(Me.txtRfc)
        Me.GroupBoxProveedores.Controls.Add(Me.Label12)
        Me.GroupBoxProveedores.Controls.Add(Me.Txtcp)
        Me.GroupBoxProveedores.Controls.Add(Me.Labelcp)
        Me.GroupBoxProveedores.Controls.Add(Me.TxtDireccion)
        Me.GroupBoxProveedores.Controls.Add(Me.Label14)
        Me.GroupBoxProveedores.Controls.Add(Me.TxtColonia)
        Me.GroupBoxProveedores.Controls.Add(Me.Label15)
        Me.GroupBoxProveedores.Controls.Add(Me.NombreCiudad)
        Me.GroupBoxProveedores.Controls.Add(Me.TxtCiudad)
        Me.GroupBoxProveedores.Controls.Add(Me.Label17)
        Me.GroupBoxProveedores.Controls.Add(Me.NombreEstado)
        Me.GroupBoxProveedores.Controls.Add(Me.TxtEstado)
        Me.GroupBoxProveedores.Controls.Add(Me.Label19)
        Me.GroupBoxProveedores.Controls.Add(Me.TxtNombre)
        Me.GroupBoxProveedores.Controls.Add(Me.LblNombres)
        Me.GroupBoxProveedores.Location = New System.Drawing.Point(6, 29)
        Me.GroupBoxProveedores.Name = "GroupBoxProveedores"
        Me.GroupBoxProveedores.Size = New System.Drawing.Size(958, 241)
        Me.GroupBoxProveedores.TabIndex = 280
        Me.GroupBoxProveedores.TabStop = False
        Me.GroupBoxProveedores.Text = "Datos generales"
        '
        'txtRfc
        '
        Me.txtRfc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRfc.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRfc.Location = New System.Drawing.Point(72, 58)
        Me.txtRfc.MaxLength = 15
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.Size = New System.Drawing.Size(156, 22)
        Me.txtRfc.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(39, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 14)
        Me.Label12.TabIndex = 276
        Me.Label12.Text = "RFC"
        '
        'Txtcp
        '
        Me.Txtcp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtcp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtcp.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcp.Location = New System.Drawing.Point(72, 198)
        Me.Txtcp.MaxLength = 6
        Me.Txtcp.Name = "Txtcp"
        Me.Txtcp.Size = New System.Drawing.Size(91, 22)
        Me.Txtcp.TabIndex = 9
        '
        'Labelcp
        '
        Me.Labelcp.AutoSize = True
        Me.Labelcp.BackColor = System.Drawing.Color.Transparent
        Me.Labelcp.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcp.Location = New System.Drawing.Point(47, 202)
        Me.Labelcp.Name = "Labelcp"
        Me.Labelcp.Size = New System.Drawing.Size(24, 14)
        Me.Labelcp.TabIndex = 275
        Me.Labelcp.Text = "CP"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDireccion.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(72, 170)
        Me.TxtDireccion.MaxLength = 100
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(840, 22)
        Me.TxtDireccion.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 174)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 14)
        Me.Label14.TabIndex = 274
        Me.Label14.Text = "Dirección"
        '
        'TxtColonia
        '
        Me.TxtColonia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtColonia.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtColonia.Location = New System.Drawing.Point(72, 142)
        Me.TxtColonia.MaxLength = 100
        Me.TxtColonia.Name = "TxtColonia"
        Me.TxtColonia.Size = New System.Drawing.Size(840, 22)
        Me.TxtColonia.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 146)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 14)
        Me.Label15.TabIndex = 273
        Me.Label15.Text = "Colonia"
        '
        'NombreCiudad
        '
        Me.NombreCiudad.AutoEllipsis = True
        Me.NombreCiudad.BackColor = System.Drawing.Color.Transparent
        Me.NombreCiudad.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreCiudad.Location = New System.Drawing.Point(198, 115)
        Me.NombreCiudad.Name = "NombreCiudad"
        Me.NombreCiudad.Size = New System.Drawing.Size(472, 22)
        Me.NombreCiudad.TabIndex = 272
        Me.NombreCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtCiudad
        '
        Me.TxtCiudad.BackColor = System.Drawing.SystemColors.Info
        Me.TxtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCiudad.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCiudad.Location = New System.Drawing.Point(72, 115)
        Me.TxtCiudad.MaxLength = 9
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.Size = New System.Drawing.Size(80, 22)
        Me.TxtCiudad.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(18, 119)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 14)
        Me.Label17.TabIndex = 271
        Me.Label17.Text = "Ciudad"
        '
        'NombreEstado
        '
        Me.NombreEstado.AutoEllipsis = True
        Me.NombreEstado.BackColor = System.Drawing.Color.Transparent
        Me.NombreEstado.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreEstado.Location = New System.Drawing.Point(198, 86)
        Me.NombreEstado.Name = "NombreEstado"
        Me.NombreEstado.Size = New System.Drawing.Size(472, 22)
        Me.NombreEstado.TabIndex = 270
        Me.NombreEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtEstado
        '
        Me.TxtEstado.BackColor = System.Drawing.SystemColors.Info
        Me.TxtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEstado.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEstado.Location = New System.Drawing.Point(72, 86)
        Me.TxtEstado.MaxLength = 9
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(80, 22)
        Me.TxtEstado.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(18, 90)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 14)
        Me.Label19.TabIndex = 269
        Me.Label19.Text = "Estado"
        '
        'TxtNombre
        '
        Me.TxtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(72, 30)
        Me.TxtNombre.MaxLength = 100
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(840, 22)
        Me.TxtNombre.TabIndex = 3
        '
        'LblNombres
        '
        Me.LblNombres.AutoSize = True
        Me.LblNombres.BackColor = System.Drawing.Color.Transparent
        Me.LblNombres.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombres.Location = New System.Drawing.Point(13, 34)
        Me.LblNombres.Name = "LblNombres"
        Me.LblNombres.Size = New System.Drawing.Size(56, 14)
        Me.LblNombres.TabIndex = 268
        Me.LblNombres.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(246, 20)
        Me.Label4.TabIndex = 268
        Me.Label4.Text = "Catálogo de Proveedores"
        '
        'NombreProveedor
        '
        Me.NombreProveedor.AutoEllipsis = True
        Me.NombreProveedor.BackColor = System.Drawing.Color.Transparent
        Me.NombreProveedor.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreProveedor.Location = New System.Drawing.Point(204, 93)
        Me.NombreProveedor.Name = "NombreProveedor"
        Me.NombreProveedor.Size = New System.Drawing.Size(691, 22)
        Me.NombreProveedor.TabIndex = 269
        Me.NombreProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Barra
        '
        Me.Barra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Barra.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Barra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Barra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Barra.Location = New System.Drawing.Point(0, 128)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(1024, 4)
        Me.Barra.TabIndex = 271
        Me.Barra.TabStop = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.btnAceptar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnAceptar.Location = New System.Drawing.Point(904, 90)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(80, 25)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'BarraMenu
        '
        Me.BarraMenu.AutoSize = False
        Me.BarraMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Limpiar, Me.Grabar})
        Me.BarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.BarraMenu.Name = "BarraMenu"
        Me.BarraMenu.Size = New System.Drawing.Size(1016, 48)
        Me.BarraMenu.TabIndex = 273
        Me.BarraMenu.Text = "ToolStrip1"
        '
        'Limpiar
        '
        Me.Limpiar.AutoSize = False
        Me.Limpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Limpiar.Image = CType(resources.GetObject("Limpiar.Image"), System.Drawing.Image)
        Me.Limpiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Limpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(43, 45)
        Me.Limpiar.Text = "Limpiar"
        '
        'Grabar
        '
        Me.Grabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Grabar.Image = CType(resources.GetObject("Grabar.Image"), System.Drawing.Image)
        Me.Grabar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Grabar.Name = "Grabar"
        Me.Grabar.Size = New System.Drawing.Size(36, 45)
        Me.Grabar.Text = "Grabar"
        '
        'Cat_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 708)
        Me.Controls.Add(Me.BarraMenu)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.NombreProveedor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBoxProveedor)
        Me.Controls.Add(Me.CodigoProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PiePagina)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Cat_Proveedores"
        Me.Text = "Catálogo de Proveedores"
        Me.PiePagina.ResumeLayout(False)
        Me.PiePagina.PerformLayout()
        Me.GroupBoxProveedor.ResumeLayout(False)
        Me.GroupBoxLocalizacion.ResumeLayout(False)
        Me.GroupBoxLocalizacion.PerformLayout()
        Me.GroupBoxProveedores.ResumeLayout(False)
        Me.GroupBoxProveedores.PerformLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraMenu.ResumeLayout(False)
        Me.BarraMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PiePagina As System.Windows.Forms.StatusStrip
    Friend WithEvents MensajePiePagina As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CodigoProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxLocalizacion As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtExt2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtExt As System.Windows.Forms.TextBox
    Friend WithEvents TxtMail As System.Windows.Forms.TextBox
    Friend WithEvents TxtFax As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtCel As System.Windows.Forms.TextBox
    Friend WithEvents TxtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtCel2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtTel2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxProveedores As System.Windows.Forms.GroupBox
    Friend WithEvents txtRfc As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Txtcp As System.Windows.Forms.TextBox
    Friend WithEvents Labelcp As System.Windows.Forms.Label
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtColonia As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents NombreCiudad As System.Windows.Forms.Label
    Friend WithEvents TxtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents NombreEstado As System.Windows.Forms.Label
    Friend WithEvents TxtEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents LblNombres As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NombreProveedor As System.Windows.Forms.Label
    Friend WithEvents Barra As System.Windows.Forms.PictureBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents BarraMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents Limpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Grabar As System.Windows.Forms.ToolStripButton
End Class
