<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cat_Clientes
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

    Private Shared ChildInstance As Cat_Clientes = Nothing

    'controla que sólo exista una instancia del formulario.

    Public Shared Function Instance() As Cat_Clientes
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New Cat_Clientes
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
    Public components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Public Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cat_Clientes))
        Me.textBoxCliente = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.AbonarToolStrip = New System.Windows.Forms.ToolStrip
        Me.ToolStripButtonNuevo = New System.Windows.Forms.ToolStripButton
        Me.Limpiar = New System.Windows.Forms.ToolStripButton
        Me.Grabar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButtonEliminarCuenta = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonDetalle = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonAbonos = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonAbonar = New System.Windows.Forms.ToolStripButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.AdeudosTabPage = New System.Windows.Forms.TabPage
        Me.GridDatosCuentas = New SourceGrid.DataGrid
        Me.Label22 = New System.Windows.Forms.Label
        Me.lblLimiteCredito = New System.Windows.Forms.Label
        Me.lblSaldoActual = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.DatosTabPage = New System.Windows.Forms.TabPage
        Me.GroupBoxLocalizacion = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtext2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtext = New System.Windows.Forms.TextBox
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
        Me.GroupBoxClientes = New System.Windows.Forms.GroupBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.CiudadesComboBox = New System.Windows.Forms.ComboBox
        Me.EstadosComboBox = New System.Windows.Forms.ComboBox
        Me.txtLimCred = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtRfc = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Txtcp = New System.Windows.Forms.TextBox
        Me.Labelcp = New System.Windows.Forms.Label
        Me.TxtDireccion = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtColonia = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.TxtNombre = New System.Windows.Forms.TextBox
        Me.LblNombres = New System.Windows.Forms.Label
        Me.ClientesTabControl = New System.Windows.Forms.TabControl
        Me.PanelDatos = New System.Windows.Forms.Panel
        Me.PanelGrid = New System.Windows.Forms.Panel
        Me.GridDatosCLIENTES = New SourceGrid.DataGrid
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabelClientes = New System.Windows.Forms.ToolStripStatusLabel
        Me.Barra = New System.Windows.Forms.PictureBox
        Me.AbonarToolStrip.SuspendLayout()
        Me.AdeudosTabPage.SuspendLayout()
        Me.DatosTabPage.SuspendLayout()
        Me.GroupBoxLocalizacion.SuspendLayout()
        Me.GroupBoxClientes.SuspendLayout()
        CType(Me.txtLimCred, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientesTabControl.SuspendLayout()
        Me.PanelDatos.SuspendLayout()
        Me.PanelGrid.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textBoxCliente
        '
        Me.textBoxCliente.BackColor = System.Drawing.SystemColors.Menu
        Me.textBoxCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textBoxCliente.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxCliente.Location = New System.Drawing.Point(73, 93)
        Me.textBoxCliente.MaxLength = 50
        Me.textBoxCliente.Name = "textBoxCliente"
        Me.textBoxCliente.Size = New System.Drawing.Size(309, 22)
        Me.textBoxCliente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 14)
        Me.Label1.TabIndex = 282
        Me.Label1.Text = "Cliente:"
        '
        'AbonarToolStrip
        '
        Me.AbonarToolStrip.AutoSize = False
        Me.AbonarToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonNuevo, Me.Limpiar, Me.Grabar, Me.ToolStripSeparator1, Me.ToolStripButtonEliminarCuenta, Me.ToolStripButtonDetalle, Me.ToolStripButtonAbonos, Me.ToolStripButtonAbonar})
        Me.AbonarToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.AbonarToolStrip.Name = "AbonarToolStrip"
        Me.AbonarToolStrip.Size = New System.Drawing.Size(1016, 48)
        Me.AbonarToolStrip.TabIndex = 287
        Me.AbonarToolStrip.Text = "ToolStrip1"
        '
        'ToolStripButtonNuevo
        '
        Me.ToolStripButtonNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonNuevo.Image = Global.SuperMercado.My.Resources.Resources.user_add
        Me.ToolStripButtonNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonNuevo.Name = "ToolStripButtonNuevo"
        Me.ToolStripButtonNuevo.Size = New System.Drawing.Size(36, 45)
        Me.ToolStripButtonNuevo.Text = "Nuevo"
        '
        'Limpiar
        '
        Me.Limpiar.AutoSize = False
        Me.Limpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Limpiar.Image = Global.SuperMercado.My.Resources.Resources.page
        Me.Limpiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Limpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(43, 45)
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.Visible = False
        '
        'Grabar
        '
        Me.Grabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Grabar.Image = Global.SuperMercado.My.Resources.Resources.disk
        Me.Grabar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Grabar.Name = "Grabar"
        Me.Grabar.Size = New System.Drawing.Size(36, 45)
        Me.Grabar.Text = "Guardar"
        Me.Grabar.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 48)
        Me.ToolStripSeparator1.Visible = False
        '
        'ToolStripButtonEliminarCuenta
        '
        Me.ToolStripButtonEliminarCuenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonEliminarCuenta.Image = Global.SuperMercado.My.Resources.Resources.delete
        Me.ToolStripButtonEliminarCuenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonEliminarCuenta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonEliminarCuenta.Name = "ToolStripButtonEliminarCuenta"
        Me.ToolStripButtonEliminarCuenta.Size = New System.Drawing.Size(36, 45)
        Me.ToolStripButtonEliminarCuenta.Text = "Liquidar cuenta"
        '
        'ToolStripButtonDetalle
        '
        Me.ToolStripButtonDetalle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonDetalle.Image = Global.SuperMercado.My.Resources.Resources.attributes_display
        Me.ToolStripButtonDetalle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonDetalle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDetalle.Name = "ToolStripButtonDetalle"
        Me.ToolStripButtonDetalle.Size = New System.Drawing.Size(36, 45)
        Me.ToolStripButtonDetalle.Text = "Detalle"
        '
        'ToolStripButtonAbonos
        '
        Me.ToolStripButtonAbonos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonAbonos.Image = Global.SuperMercado.My.Resources.Resources.money_bag
        Me.ToolStripButtonAbonos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonAbonos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAbonos.Name = "ToolStripButtonAbonos"
        Me.ToolStripButtonAbonos.Size = New System.Drawing.Size(36, 45)
        Me.ToolStripButtonAbonos.Text = "Abonos registrados"
        '
        'ToolStripButtonAbonar
        '
        Me.ToolStripButtonAbonar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonAbonar.Image = Global.SuperMercado.My.Resources.Resources.money_add
        Me.ToolStripButtonAbonar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonAbonar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAbonar.Name = "ToolStripButtonAbonar"
        Me.ToolStripButtonAbonar.Size = New System.Drawing.Size(36, 45)
        Me.ToolStripButtonAbonar.Text = "Abonar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 20)
        Me.Label4.TabIndex = 288
        Me.Label4.Text = "Catálogo de Clientes"
        '
        'AdeudosTabPage
        '
        Me.AdeudosTabPage.Controls.Add(Me.GridDatosCuentas)
        Me.AdeudosTabPage.Controls.Add(Me.Label22)
        Me.AdeudosTabPage.Controls.Add(Me.lblLimiteCredito)
        Me.AdeudosTabPage.Controls.Add(Me.lblSaldoActual)
        Me.AdeudosTabPage.Controls.Add(Me.Label18)
        Me.AdeudosTabPage.Controls.Add(Me.Label16)
        Me.AdeudosTabPage.Controls.Add(Me.Label13)
        Me.AdeudosTabPage.Location = New System.Drawing.Point(4, 23)
        Me.AdeudosTabPage.Name = "AdeudosTabPage"
        Me.AdeudosTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.AdeudosTabPage.Size = New System.Drawing.Size(975, 482)
        Me.AdeudosTabPage.TabIndex = 1
        Me.AdeudosTabPage.Text = " Cuentas por cobrar "
        Me.AdeudosTabPage.UseVisualStyleBackColor = True
        '
        'GridDatosCuentas
        '
        Me.GridDatosCuentas.BackColor = System.Drawing.Color.White
        Me.GridDatosCuentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridDatosCuentas.DeleteQuestionMessage = ""
        Me.GridDatosCuentas.DeleteRowsWithDeleteKey = False
        Me.GridDatosCuentas.FixedRows = 1
        Me.GridDatosCuentas.Location = New System.Drawing.Point(18, 104)
        Me.GridDatosCuentas.Name = "GridDatosCuentas"
        Me.GridDatosCuentas.SelectionMode = SourceGrid.GridSelectionMode.Row
        Me.GridDatosCuentas.Size = New System.Drawing.Size(650, 357)
        Me.GridDatosCuentas.TabIndex = 32
        Me.GridDatosCuentas.TabStop = True
        Me.GridDatosCuentas.ToolTipText = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(15, 87)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 14)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Cuentas:"
        '
        'lblLimiteCredito
        '
        Me.lblLimiteCredito.AutoSize = True
        Me.lblLimiteCredito.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimiteCredito.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblLimiteCredito.Location = New System.Drawing.Point(579, 52)
        Me.lblLimiteCredito.Name = "lblLimiteCredito"
        Me.lblLimiteCredito.Size = New System.Drawing.Size(47, 14)
        Me.lblLimiteCredito.TabIndex = 4
        Me.lblLimiteCredito.Text = "$0.00"
        '
        'lblSaldoActual
        '
        Me.lblSaldoActual.AutoSize = True
        Me.lblSaldoActual.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoActual.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblSaldoActual.Location = New System.Drawing.Point(152, 52)
        Me.lblSaldoActual.Name = "lblSaldoActual"
        Me.lblSaldoActual.Size = New System.Drawing.Size(47, 14)
        Me.lblSaldoActual.TabIndex = 3
        Me.lblSaldoActual.Text = "$0.00"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(413, 52)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(116, 14)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Límite de crédito:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 52)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 14)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Saldo actual: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label13.Location = New System.Drawing.Point(15, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 14)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "ESTADO DE CUENTA"
        '
        'DatosTabPage
        '
        Me.DatosTabPage.Controls.Add(Me.GroupBoxLocalizacion)
        Me.DatosTabPage.Controls.Add(Me.GroupBoxClientes)
        Me.DatosTabPage.Location = New System.Drawing.Point(4, 23)
        Me.DatosTabPage.Name = "DatosTabPage"
        Me.DatosTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DatosTabPage.Size = New System.Drawing.Size(975, 482)
        Me.DatosTabPage.TabIndex = 0
        Me.DatosTabPage.Text = " Datos personales"
        Me.DatosTabPage.UseVisualStyleBackColor = True
        '
        'GroupBoxLocalizacion
        '
        Me.GroupBoxLocalizacion.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxLocalizacion.Controls.Add(Me.Label3)
        Me.GroupBoxLocalizacion.Controls.Add(Me.txtext2)
        Me.GroupBoxLocalizacion.Controls.Add(Me.Label2)
        Me.GroupBoxLocalizacion.Controls.Add(Me.txtext)
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
        Me.GroupBoxLocalizacion.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxLocalizacion.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBoxLocalizacion.Location = New System.Drawing.Point(6, 292)
        Me.GroupBoxLocalizacion.Name = "GroupBoxLocalizacion"
        Me.GroupBoxLocalizacion.Size = New System.Drawing.Size(955, 181)
        Me.GroupBoxLocalizacion.TabIndex = 290
        Me.GroupBoxLocalizacion.TabStop = False
        Me.GroupBoxLocalizacion.Text = " Datos de localización "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(750, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 14)
        Me.Label3.TabIndex = 282
        Me.Label3.Text = "Ext2:"
        '
        'txtext2
        '
        Me.txtext2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtext2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtext2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtext2.Location = New System.Drawing.Point(793, 49)
        Me.txtext2.Name = "txtext2"
        Me.txtext2.Size = New System.Drawing.Size(123, 22)
        Me.txtext2.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(263, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 14)
        Me.Label2.TabIndex = 280
        Me.Label2.Text = "Ext:"
        '
        'txtext
        '
        Me.txtext.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtext.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtext.Location = New System.Drawing.Point(301, 49)
        Me.txtext.Name = "txtext"
        Me.txtext.Size = New System.Drawing.Size(138, 22)
        Me.txtext.TabIndex = 12
        '
        'TxtMail
        '
        Me.TxtMail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMail.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMail.Location = New System.Drawing.Point(80, 21)
        Me.TxtMail.MaxLength = 100
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(836, 22)
        Me.TxtMail.TabIndex = 10
        '
        'TxtFax
        '
        Me.TxtFax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFax.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFax.Location = New System.Drawing.Point(80, 138)
        Me.TxtFax.MaxLength = 100
        Me.TxtFax.Name = "TxtFax"
        Me.TxtFax.Size = New System.Drawing.Size(836, 22)
        Me.TxtFax.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(23, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 14)
        Me.Label11.TabIndex = 273
        Me.Label11.Text = "E-mail:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(40, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 14)
        Me.Label6.TabIndex = 278
        Me.Label6.Text = "Fax:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(8, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 14)
        Me.Label10.TabIndex = 274
        Me.Label10.Text = "Teléfono:"
        '
        'TxtCel
        '
        Me.TxtCel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCel.Location = New System.Drawing.Point(80, 80)
        Me.TxtCel.MaxLength = 100
        Me.TxtCel.Name = "TxtCel"
        Me.TxtCel.Size = New System.Drawing.Size(836, 22)
        Me.TxtCel.TabIndex = 14
        '
        'TxtTel
        '
        Me.TxtTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTel.Location = New System.Drawing.Point(80, 49)
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
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(19, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 14)
        Me.Label7.TabIndex = 277
        Me.Label7.Text = "Celular:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(460, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 14)
        Me.Label9.TabIndex = 275
        Me.Label9.Text = "Teléfono2:"
        '
        'TxtCel2
        '
        Me.TxtCel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCel2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCel2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCel2.Location = New System.Drawing.Point(80, 108)
        Me.TxtCel2.MaxLength = 100
        Me.TxtCel2.Name = "TxtCel2"
        Me.TxtCel2.Size = New System.Drawing.Size(836, 22)
        Me.TxtCel2.TabIndex = 15
        '
        'TxtTel2
        '
        Me.TxtTel2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTel2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTel2.Location = New System.Drawing.Point(540, 49)
        Me.TxtTel2.MaxLength = 100
        Me.TxtTel2.Name = "TxtTel2"
        Me.TxtTel2.Size = New System.Drawing.Size(170, 22)
        Me.TxtTel2.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(10, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 14)
        Me.Label8.TabIndex = 276
        Me.Label8.Text = "Celular2:"
        '
        'GroupBoxClientes
        '
        Me.GroupBoxClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxClientes.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxClientes.Controls.Add(Me.txtCodigo)
        Me.GroupBoxClientes.Controls.Add(Me.Label20)
        Me.GroupBoxClientes.Controls.Add(Me.CiudadesComboBox)
        Me.GroupBoxClientes.Controls.Add(Me.EstadosComboBox)
        Me.GroupBoxClientes.Controls.Add(Me.txtLimCred)
        Me.GroupBoxClientes.Controls.Add(Me.Label5)
        Me.GroupBoxClientes.Controls.Add(Me.txtRfc)
        Me.GroupBoxClientes.Controls.Add(Me.Label12)
        Me.GroupBoxClientes.Controls.Add(Me.Txtcp)
        Me.GroupBoxClientes.Controls.Add(Me.Labelcp)
        Me.GroupBoxClientes.Controls.Add(Me.TxtDireccion)
        Me.GroupBoxClientes.Controls.Add(Me.Label14)
        Me.GroupBoxClientes.Controls.Add(Me.TxtColonia)
        Me.GroupBoxClientes.Controls.Add(Me.Label15)
        Me.GroupBoxClientes.Controls.Add(Me.Label17)
        Me.GroupBoxClientes.Controls.Add(Me.Label19)
        Me.GroupBoxClientes.Controls.Add(Me.TxtNombre)
        Me.GroupBoxClientes.Controls.Add(Me.LblNombres)
        Me.GroupBoxClientes.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxClientes.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBoxClientes.Location = New System.Drawing.Point(6, 6)
        Me.GroupBoxClientes.Name = "GroupBoxClientes"
        Me.GroupBoxClientes.Size = New System.Drawing.Size(955, 266)
        Me.GroupBoxClientes.TabIndex = 285
        Me.GroupBoxClientes.TabStop = False
        Me.GroupBoxClientes.Text = " Datos generales "
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(80, 59)
        Me.txtCodigo.MaxLength = 15
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(242, 22)
        Me.txtCodigo.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(16, 62)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 14)
        Me.Label20.TabIndex = 278
        Me.Label20.Text = "Código:"
        '
        'CiudadesComboBox
        '
        Me.CiudadesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CiudadesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CiudadesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CiudadesComboBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiudadesComboBox.FormattingEnabled = True
        Me.CiudadesComboBox.Location = New System.Drawing.Point(80, 143)
        Me.CiudadesComboBox.Name = "CiudadesComboBox"
        Me.CiudadesComboBox.Size = New System.Drawing.Size(162, 22)
        Me.CiudadesComboBox.TabIndex = 5
        '
        'EstadosComboBox
        '
        Me.EstadosComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.EstadosComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EstadosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadosComboBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadosComboBox.FormattingEnabled = True
        Me.EstadosComboBox.ItemHeight = 14
        Me.EstadosComboBox.Location = New System.Drawing.Point(80, 115)
        Me.EstadosComboBox.Name = "EstadosComboBox"
        Me.EstadosComboBox.Size = New System.Drawing.Size(162, 22)
        Me.EstadosComboBox.TabIndex = 4
        '
        'txtLimCred
        '
        Me.txtLimCred.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimCred.Location = New System.Drawing.Point(328, 227)
        Me.txtLimCred.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.txtLimCred.Name = "txtLimCred"
        Me.txtLimCred.Size = New System.Drawing.Size(120, 22)
        Me.txtLimCred.TabIndex = 9
        Me.txtLimCred.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(206, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 14)
        Me.Label5.TabIndex = 277
        Me.Label5.Text = "Límite de crédito:"
        '
        'txtRfc
        '
        Me.txtRfc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRfc.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRfc.Location = New System.Drawing.Point(80, 87)
        Me.txtRfc.MaxLength = 15
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.Size = New System.Drawing.Size(242, 22)
        Me.txtRfc.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(36, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 14)
        Me.Label12.TabIndex = 276
        Me.Label12.Text = "RFC:"
        '
        'Txtcp
        '
        Me.Txtcp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtcp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtcp.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcp.Location = New System.Drawing.Point(80, 227)
        Me.Txtcp.MaxLength = 6
        Me.Txtcp.Name = "Txtcp"
        Me.Txtcp.Size = New System.Drawing.Size(116, 22)
        Me.Txtcp.TabIndex = 8
        '
        'Labelcp
        '
        Me.Labelcp.AutoSize = True
        Me.Labelcp.BackColor = System.Drawing.Color.Transparent
        Me.Labelcp.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Labelcp.Location = New System.Drawing.Point(43, 229)
        Me.Labelcp.Name = "Labelcp"
        Me.Labelcp.Size = New System.Drawing.Size(29, 14)
        Me.Labelcp.TabIndex = 275
        Me.Labelcp.Text = "CP:"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDireccion.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(80, 171)
        Me.TxtDireccion.MaxLength = 100
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(836, 22)
        Me.TxtDireccion.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(4, 174)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 14)
        Me.Label14.TabIndex = 274
        Me.Label14.Text = "Dirección:"
        '
        'TxtColonia
        '
        Me.TxtColonia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtColonia.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtColonia.Location = New System.Drawing.Point(80, 199)
        Me.TxtColonia.MaxLength = 100
        Me.TxtColonia.Name = "TxtColonia"
        Me.TxtColonia.Size = New System.Drawing.Size(836, 22)
        Me.TxtColonia.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(13, 202)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 14)
        Me.Label15.TabIndex = 273
        Me.Label15.Text = "Colonia:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(16, 146)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 14)
        Me.Label17.TabIndex = 271
        Me.Label17.Text = "Ciudad:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(16, 118)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 14)
        Me.Label19.TabIndex = 269
        Me.Label19.Text = "Estado:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(80, 31)
        Me.TxtNombre.MaxLength = 100
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(836, 22)
        Me.TxtNombre.TabIndex = 1
        '
        'LblNombres
        '
        Me.LblNombres.AutoSize = True
        Me.LblNombres.BackColor = System.Drawing.Color.Transparent
        Me.LblNombres.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombres.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblNombres.Location = New System.Drawing.Point(11, 34)
        Me.LblNombres.Name = "LblNombres"
        Me.LblNombres.Size = New System.Drawing.Size(61, 14)
        Me.LblNombres.TabIndex = 268
        Me.LblNombres.Text = "Nombre:"
        '
        'ClientesTabControl
        '
        Me.ClientesTabControl.Controls.Add(Me.DatosTabPage)
        Me.ClientesTabControl.Controls.Add(Me.AdeudosTabPage)
        Me.ClientesTabControl.Location = New System.Drawing.Point(5, 3)
        Me.ClientesTabControl.Name = "ClientesTabControl"
        Me.ClientesTabControl.SelectedIndex = 0
        Me.ClientesTabControl.Size = New System.Drawing.Size(983, 509)
        Me.ClientesTabControl.TabIndex = 289
        '
        'PanelDatos
        '
        Me.PanelDatos.Controls.Add(Me.ClientesTabControl)
        Me.PanelDatos.Location = New System.Drawing.Point(10, 148)
        Me.PanelDatos.Name = "PanelDatos"
        Me.PanelDatos.Size = New System.Drawing.Size(1006, 502)
        Me.PanelDatos.TabIndex = 290
        '
        'PanelGrid
        '
        Me.PanelGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelGrid.Controls.Add(Me.GridDatosCLIENTES)
        Me.PanelGrid.Location = New System.Drawing.Point(464, 59)
        Me.PanelGrid.Margin = New System.Windows.Forms.Padding(10)
        Me.PanelGrid.Name = "PanelGrid"
        Me.PanelGrid.Size = New System.Drawing.Size(51, 56)
        Me.PanelGrid.TabIndex = 291
        '
        'GridDatosCLIENTES
        '
        Me.GridDatosCLIENTES.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDatosCLIENTES.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridDatosCLIENTES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridDatosCLIENTES.DeleteQuestionMessage = ""
        Me.GridDatosCLIENTES.DeleteRowsWithDeleteKey = False
        Me.GridDatosCLIENTES.FixedRows = 1
        Me.GridDatosCLIENTES.Location = New System.Drawing.Point(17, 13)
        Me.GridDatosCLIENTES.Name = "GridDatosCLIENTES"
        Me.GridDatosCLIENTES.SelectionMode = SourceGrid.GridSelectionMode.Row
        Me.GridDatosCLIENTES.Size = New System.Drawing.Size(24, 38)
        Me.GridDatosCLIENTES.TabIndex = 341
        Me.GridDatosCLIENTES.TabStop = True
        Me.GridDatosCLIENTES.ToolTipText = ""
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelClientes})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 640)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1016, 22)
        Me.StatusStrip1.TabIndex = 292
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelClientes
        '
        Me.ToolStripStatusLabelClientes.Name = "ToolStripStatusLabelClientes"
        Me.ToolStripStatusLabelClientes.Size = New System.Drawing.Size(410, 17)
        Me.ToolStripStatusLabelClientes.Text = "Escriba el nombre o número de identificación de un cliente para filtrar los resul" & _
            "tados."
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
        Me.Barra.TabIndex = 284
        Me.Barra.TabStop = False
        '
        'Cat_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 662)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PanelGrid)
        Me.Controls.Add(Me.PanelDatos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AbonarToolStrip)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.textBoxCliente)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Cat_Clientes"
        Me.Text = "Catálogo de clientes"
        Me.AbonarToolStrip.ResumeLayout(False)
        Me.AbonarToolStrip.PerformLayout()
        Me.AdeudosTabPage.ResumeLayout(False)
        Me.AdeudosTabPage.PerformLayout()
        Me.DatosTabPage.ResumeLayout(False)
        Me.GroupBoxLocalizacion.ResumeLayout(False)
        Me.GroupBoxLocalizacion.PerformLayout()
        Me.GroupBoxClientes.ResumeLayout(False)
        Me.GroupBoxClientes.PerformLayout()
        CType(Me.txtLimCred, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientesTabControl.ResumeLayout(False)
        Me.PanelDatos.ResumeLayout(False)
        Me.PanelGrid.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Barra As System.Windows.Forms.PictureBox
    Friend WithEvents textBoxCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AbonarToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Limpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AdeudosTabPage As System.Windows.Forms.TabPage
    Friend WithEvents DatosTabPage As System.Windows.Forms.TabPage
    Friend WithEvents GroupBoxLocalizacion As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtext2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtext As System.Windows.Forms.TextBox
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
    Friend WithEvents GroupBoxClientes As System.Windows.Forms.GroupBox
    Friend WithEvents txtLimCred As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRfc As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Txtcp As System.Windows.Forms.TextBox
    Friend WithEvents Labelcp As System.Windows.Forms.Label
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtColonia As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents LblNombres As System.Windows.Forms.Label
    Friend WithEvents ClientesTabControl As System.Windows.Forms.TabControl
    Friend WithEvents CiudadesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EstadosComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents lblLimiteCredito As System.Windows.Forms.Label
    Friend WithEvents lblSaldoActual As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GridDatosCuentas As SourceGrid.DataGrid
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButtonDetalle As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonAbonos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonAbonar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PanelDatos As System.Windows.Forms.Panel
    Friend WithEvents PanelGrid As System.Windows.Forms.Panel
    Friend WithEvents GridDatosCLIENTES As SourceGrid.DataGrid
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButtonNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabelClientes As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonEliminarCuenta As System.Windows.Forms.ToolStripButton
End Class
