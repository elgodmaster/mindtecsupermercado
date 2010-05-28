<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Permisos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Permisos))
        Me.AbonarToolStrip = New System.Windows.Forms.ToolStrip
        Me.ButtonLimpiar = New System.Windows.Forms.ToolStripButton
        Me.ButtonGrabar = New System.Windows.Forms.ToolStripButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.textBoxNombrePermiso = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Barra = New System.Windows.Forms.PictureBox
        Me.buttonAceptar = New System.Windows.Forms.Button
        Me.GroupBoxReportes = New System.Windows.Forms.GroupBox
        Me.CheckBoxRepDepEfec = New System.Windows.Forms.CheckBox
        Me.CheckBoxRepVen = New System.Windows.Forms.CheckBox
        Me.CheckBoxRepRetEfec = New System.Windows.Forms.CheckBox
        Me.CheckBoxRepFac = New System.Windows.Forms.CheckBox
        Me.CheckBoxRepProv = New System.Windows.Forms.CheckBox
        Me.CheckBoxRepProd = New System.Windows.Forms.CheckBox
        Me.CheckBoxRepSalPro = New System.Windows.Forms.CheckBox
        Me.CheckBoxRepEntPro = New System.Windows.Forms.CheckBox
        Me.CheckBoxRepClie = New System.Windows.Forms.CheckBox
        Me.GroupBoxCatalogos = New System.Windows.Forms.GroupBox
        Me.CheckBoxCatProv = New System.Windows.Forms.CheckBox
        Me.CheckBoxCatUni = New System.Windows.Forms.CheckBox
        Me.CheckBoxCatClie = New System.Windows.Forms.CheckBox
        Me.CheckBoxCatPro = New System.Windows.Forms.CheckBox
        Me.CheckBoxCatDep = New System.Windows.Forms.CheckBox
        Me.CheckBoxCatCat = New System.Windows.Forms.CheckBox
        Me.CheckBoxCatMar = New System.Windows.Forms.CheckBox
        Me.GroupBoxFacturacion = New System.Windows.Forms.GroupBox
        Me.CheckBoxFacFac = New System.Windows.Forms.CheckBox
        Me.CheckBoxFacCot = New System.Windows.Forms.CheckBox
        Me.GroupBoxInventario = New System.Windows.Forms.GroupBox
        Me.CheckBoxInvMov = New System.Windows.Forms.CheckBox
        Me.CheckBoxInvCon = New System.Windows.Forms.CheckBox
        Me.GroupBoxCaja = New System.Windows.Forms.GroupBox
        Me.CheckBoxCajaSal = New System.Windows.Forms.CheckBox
        Me.CheckBoxCajaCorte = New System.Windows.Forms.CheckBox
        Me.CheckBoxCajaEnt = New System.Windows.Forms.CheckBox
        Me.GroupBoxSeguridad = New System.Windows.Forms.GroupBox
        Me.CheckBoxSegUsu = New System.Windows.Forms.CheckBox
        Me.CheckBoxSegPer = New System.Windows.Forms.CheckBox
        Me.GroupBoxConfiguracion = New System.Windows.Forms.GroupBox
        Me.CheckBoxConTic = New System.Windows.Forms.CheckBox
        Me.CheckBoxConCaja = New System.Windows.Forms.CheckBox
        Me.CheckBoxConFac = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CheckBoxSeleccionarTodo = New System.Windows.Forms.CheckBox
        Me.labelResul = New System.Windows.Forms.Label
        Me.AbonarToolStrip.SuspendLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxReportes.SuspendLayout()
        Me.GroupBoxCatalogos.SuspendLayout()
        Me.GroupBoxFacturacion.SuspendLayout()
        Me.GroupBoxInventario.SuspendLayout()
        Me.GroupBoxCaja.SuspendLayout()
        Me.GroupBoxSeguridad.SuspendLayout()
        Me.GroupBoxConfiguracion.SuspendLayout()
        Me.SuspendLayout()
        '
        'AbonarToolStrip
        '
        Me.AbonarToolStrip.AutoSize = False
        Me.AbonarToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonLimpiar, Me.ButtonGrabar})
        Me.AbonarToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.AbonarToolStrip.Name = "AbonarToolStrip"
        Me.AbonarToolStrip.Size = New System.Drawing.Size(879, 48)
        Me.AbonarToolStrip.TabIndex = 288
        Me.AbonarToolStrip.Text = "ToolStrip1"
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.AutoSize = False
        Me.ButtonLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonLimpiar.Image = CType(resources.GetObject("ButtonLimpiar.Image"), System.Drawing.Image)
        Me.ButtonLimpiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ButtonLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(43, 45)
        Me.ButtonLimpiar.Text = "Limpiar"
        '
        'ButtonGrabar
        '
        Me.ButtonGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonGrabar.Image = CType(resources.GetObject("ButtonGrabar.Image"), System.Drawing.Image)
        Me.ButtonGrabar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ButtonGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonGrabar.Name = "ButtonGrabar"
        Me.ButtonGrabar.Size = New System.Drawing.Size(36, 45)
        Me.ButtonGrabar.Text = "Grabar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 20)
        Me.Label4.TabIndex = 289
        Me.Label4.Text = "Grupos de Permisos"
        '
        'textBoxNombrePermiso
        '
        Me.textBoxNombrePermiso.BackColor = System.Drawing.SystemColors.Info
        Me.textBoxNombrePermiso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textBoxNombrePermiso.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxNombrePermiso.Location = New System.Drawing.Point(80, 95)
        Me.textBoxNombrePermiso.MaxLength = 50
        Me.textBoxNombrePermiso.Name = "textBoxNombrePermiso"
        Me.textBoxNombrePermiso.Size = New System.Drawing.Size(151, 22)
        Me.textBoxNombrePermiso.TabIndex = 290
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 14)
        Me.Label1.TabIndex = 291
        Me.Label1.Text = "Nombre:"
        '
        'Barra
        '
        Me.Barra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Barra.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Barra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Barra.Location = New System.Drawing.Point(-135, 132)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(1150, 4)
        Me.Barra.TabIndex = 292
        Me.Barra.TabStop = False
        '
        'buttonAceptar
        '
        Me.buttonAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.buttonAceptar.BackgroundImage = CType(resources.GetObject("buttonAceptar.BackgroundImage"), System.Drawing.Image)
        Me.buttonAceptar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.buttonAceptar.Location = New System.Drawing.Point(787, 93)
        Me.buttonAceptar.Name = "buttonAceptar"
        Me.buttonAceptar.Size = New System.Drawing.Size(80, 25)
        Me.buttonAceptar.TabIndex = 293
        Me.buttonAceptar.Text = "Aceptar"
        Me.buttonAceptar.UseVisualStyleBackColor = False
        '
        'GroupBoxReportes
        '
        Me.GroupBoxReportes.Controls.Add(Me.CheckBoxRepDepEfec)
        Me.GroupBoxReportes.Controls.Add(Me.CheckBoxRepVen)
        Me.GroupBoxReportes.Controls.Add(Me.CheckBoxRepRetEfec)
        Me.GroupBoxReportes.Controls.Add(Me.CheckBoxRepFac)
        Me.GroupBoxReportes.Controls.Add(Me.CheckBoxRepProv)
        Me.GroupBoxReportes.Controls.Add(Me.CheckBoxRepProd)
        Me.GroupBoxReportes.Controls.Add(Me.CheckBoxRepSalPro)
        Me.GroupBoxReportes.Controls.Add(Me.CheckBoxRepEntPro)
        Me.GroupBoxReportes.Controls.Add(Me.CheckBoxRepClie)
        Me.GroupBoxReportes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxReportes.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBoxReportes.Location = New System.Drawing.Point(32, 186)
        Me.GroupBoxReportes.Name = "GroupBoxReportes"
        Me.GroupBoxReportes.Size = New System.Drawing.Size(199, 293)
        Me.GroupBoxReportes.TabIndex = 294
        Me.GroupBoxReportes.TabStop = False
        Me.GroupBoxReportes.Text = " Reportes "
        '
        'CheckBoxRepDepEfec
        '
        Me.CheckBoxRepDepEfec.AutoSize = True
        Me.CheckBoxRepDepEfec.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxRepDepEfec.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CheckBoxRepDepEfec.Location = New System.Drawing.Point(19, 215)
        Me.CheckBoxRepDepEfec.Name = "CheckBoxRepDepEfec"
        Me.CheckBoxRepDepEfec.Size = New System.Drawing.Size(131, 18)
        Me.CheckBoxRepDepEfec.TabIndex = 302
        Me.CheckBoxRepDepEfec.Text = "Depósitos de efectivo"
        Me.CheckBoxRepDepEfec.UseVisualStyleBackColor = True
        '
        'CheckBoxRepVen
        '
        Me.CheckBoxRepVen.AutoSize = True
        Me.CheckBoxRepVen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxRepVen.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CheckBoxRepVen.Location = New System.Drawing.Point(19, 167)
        Me.CheckBoxRepVen.Name = "CheckBoxRepVen"
        Me.CheckBoxRepVen.Size = New System.Drawing.Size(61, 18)
        Me.CheckBoxRepVen.TabIndex = 300
        Me.CheckBoxRepVen.Text = "Ventas"
        Me.CheckBoxRepVen.UseVisualStyleBackColor = True
        '
        'CheckBoxRepRetEfec
        '
        Me.CheckBoxRepRetEfec.AutoSize = True
        Me.CheckBoxRepRetEfec.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxRepRetEfec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxRepRetEfec.Location = New System.Drawing.Point(19, 191)
        Me.CheckBoxRepRetEfec.Name = "CheckBoxRepRetEfec"
        Me.CheckBoxRepRetEfec.Size = New System.Drawing.Size(117, 18)
        Me.CheckBoxRepRetEfec.TabIndex = 301
        Me.CheckBoxRepRetEfec.Text = "Retiros de efectivo"
        Me.CheckBoxRepRetEfec.UseVisualStyleBackColor = True
        '
        'CheckBoxRepFac
        '
        Me.CheckBoxRepFac.AutoSize = True
        Me.CheckBoxRepFac.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxRepFac.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxRepFac.Location = New System.Drawing.Point(19, 143)
        Me.CheckBoxRepFac.Name = "CheckBoxRepFac"
        Me.CheckBoxRepFac.Size = New System.Drawing.Size(69, 18)
        Me.CheckBoxRepFac.TabIndex = 300
        Me.CheckBoxRepFac.Text = "Facturas"
        Me.CheckBoxRepFac.UseVisualStyleBackColor = True
        '
        'CheckBoxRepProv
        '
        Me.CheckBoxRepProv.AutoSize = True
        Me.CheckBoxRepProv.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxRepProv.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CheckBoxRepProv.Location = New System.Drawing.Point(19, 119)
        Me.CheckBoxRepProv.Name = "CheckBoxRepProv"
        Me.CheckBoxRepProv.Size = New System.Drawing.Size(88, 18)
        Me.CheckBoxRepProv.TabIndex = 299
        Me.CheckBoxRepProv.Text = "Proveedores"
        Me.CheckBoxRepProv.UseVisualStyleBackColor = True
        '
        'CheckBoxRepProd
        '
        Me.CheckBoxRepProd.AutoSize = True
        Me.CheckBoxRepProd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxRepProd.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CheckBoxRepProd.Location = New System.Drawing.Point(19, 27)
        Me.CheckBoxRepProd.Name = "CheckBoxRepProd"
        Me.CheckBoxRepProd.Size = New System.Drawing.Size(75, 18)
        Me.CheckBoxRepProd.TabIndex = 297
        Me.CheckBoxRepProd.Text = "Productos"
        Me.CheckBoxRepProd.UseVisualStyleBackColor = True
        '
        'CheckBoxRepSalPro
        '
        Me.CheckBoxRepSalPro.AutoSize = True
        Me.CheckBoxRepSalPro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxRepSalPro.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CheckBoxRepSalPro.Location = New System.Drawing.Point(19, 73)
        Me.CheckBoxRepSalPro.Name = "CheckBoxRepSalPro"
        Me.CheckBoxRepSalPro.Size = New System.Drawing.Size(122, 18)
        Me.CheckBoxRepSalPro.TabIndex = 301
        Me.CheckBoxRepSalPro.Text = "Salida de productos"
        Me.CheckBoxRepSalPro.UseVisualStyleBackColor = True
        '
        'CheckBoxRepEntPro
        '
        Me.CheckBoxRepEntPro.AutoSize = True
        Me.CheckBoxRepEntPro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxRepEntPro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxRepEntPro.Location = New System.Drawing.Point(19, 50)
        Me.CheckBoxRepEntPro.Name = "CheckBoxRepEntPro"
        Me.CheckBoxRepEntPro.Size = New System.Drawing.Size(130, 18)
        Me.CheckBoxRepEntPro.TabIndex = 298
        Me.CheckBoxRepEntPro.Text = "Entrada de productos"
        Me.CheckBoxRepEntPro.UseVisualStyleBackColor = True
        '
        'CheckBoxRepClie
        '
        Me.CheckBoxRepClie.AutoSize = True
        Me.CheckBoxRepClie.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxRepClie.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxRepClie.Location = New System.Drawing.Point(19, 96)
        Me.CheckBoxRepClie.Name = "CheckBoxRepClie"
        Me.CheckBoxRepClie.Size = New System.Drawing.Size(64, 18)
        Me.CheckBoxRepClie.TabIndex = 300
        Me.CheckBoxRepClie.Text = "Clientes"
        Me.CheckBoxRepClie.UseVisualStyleBackColor = True
        '
        'GroupBoxCatalogos
        '
        Me.GroupBoxCatalogos.Controls.Add(Me.CheckBoxCatProv)
        Me.GroupBoxCatalogos.Controls.Add(Me.CheckBoxCatUni)
        Me.GroupBoxCatalogos.Controls.Add(Me.CheckBoxCatClie)
        Me.GroupBoxCatalogos.Controls.Add(Me.CheckBoxCatPro)
        Me.GroupBoxCatalogos.Controls.Add(Me.CheckBoxCatDep)
        Me.GroupBoxCatalogos.Controls.Add(Me.CheckBoxCatCat)
        Me.GroupBoxCatalogos.Controls.Add(Me.CheckBoxCatMar)
        Me.GroupBoxCatalogos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxCatalogos.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBoxCatalogos.Location = New System.Drawing.Point(237, 186)
        Me.GroupBoxCatalogos.Name = "GroupBoxCatalogos"
        Me.GroupBoxCatalogos.Size = New System.Drawing.Size(165, 195)
        Me.GroupBoxCatalogos.TabIndex = 295
        Me.GroupBoxCatalogos.TabStop = False
        Me.GroupBoxCatalogos.Text = " Catálogos "
        '
        'CheckBoxCatProv
        '
        Me.CheckBoxCatProv.AutoSize = True
        Me.CheckBoxCatProv.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxCatProv.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxCatProv.Location = New System.Drawing.Point(19, 139)
        Me.CheckBoxCatProv.Name = "CheckBoxCatProv"
        Me.CheckBoxCatProv.Size = New System.Drawing.Size(88, 18)
        Me.CheckBoxCatProv.TabIndex = 300
        Me.CheckBoxCatProv.Text = "Proveedores"
        Me.CheckBoxCatProv.UseVisualStyleBackColor = True
        '
        'CheckBoxCatUni
        '
        Me.CheckBoxCatUni.AutoSize = True
        Me.CheckBoxCatUni.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxCatUni.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CheckBoxCatUni.Location = New System.Drawing.Point(19, 163)
        Me.CheckBoxCatUni.Name = "CheckBoxCatUni"
        Me.CheckBoxCatUni.Size = New System.Drawing.Size(71, 18)
        Me.CheckBoxCatUni.TabIndex = 301
        Me.CheckBoxCatUni.Text = "Unidades"
        Me.CheckBoxCatUni.UseVisualStyleBackColor = True
        '
        'CheckBoxCatClie
        '
        Me.CheckBoxCatClie.AutoSize = True
        Me.CheckBoxCatClie.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxCatClie.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CheckBoxCatClie.Location = New System.Drawing.Point(19, 115)
        Me.CheckBoxCatClie.Name = "CheckBoxCatClie"
        Me.CheckBoxCatClie.Size = New System.Drawing.Size(64, 18)
        Me.CheckBoxCatClie.TabIndex = 300
        Me.CheckBoxCatClie.Text = "Clientes"
        Me.CheckBoxCatClie.UseVisualStyleBackColor = True
        '
        'CheckBoxCatPro
        '
        Me.CheckBoxCatPro.AutoSize = True
        Me.CheckBoxCatPro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxCatPro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxCatPro.Location = New System.Drawing.Point(19, 91)
        Me.CheckBoxCatPro.Name = "CheckBoxCatPro"
        Me.CheckBoxCatPro.Size = New System.Drawing.Size(75, 18)
        Me.CheckBoxCatPro.TabIndex = 299
        Me.CheckBoxCatPro.Text = "Productos"
        Me.CheckBoxCatPro.UseVisualStyleBackColor = True
        '
        'CheckBoxCatDep
        '
        Me.CheckBoxCatDep.AutoSize = True
        Me.CheckBoxCatDep.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxCatDep.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CheckBoxCatDep.Location = New System.Drawing.Point(19, 22)
        Me.CheckBoxCatDep.Name = "CheckBoxCatDep"
        Me.CheckBoxCatDep.Size = New System.Drawing.Size(99, 18)
        Me.CheckBoxCatDep.TabIndex = 297
        Me.CheckBoxCatDep.Text = "Departamentos"
        Me.CheckBoxCatDep.UseVisualStyleBackColor = True
        '
        'CheckBoxCatCat
        '
        Me.CheckBoxCatCat.AutoSize = True
        Me.CheckBoxCatCat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxCatCat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxCatCat.Location = New System.Drawing.Point(19, 45)
        Me.CheckBoxCatCat.Name = "CheckBoxCatCat"
        Me.CheckBoxCatCat.Size = New System.Drawing.Size(78, 18)
        Me.CheckBoxCatCat.TabIndex = 298
        Me.CheckBoxCatCat.Text = "Categorías"
        Me.CheckBoxCatCat.UseVisualStyleBackColor = True
        '
        'CheckBoxCatMar
        '
        Me.CheckBoxCatMar.AutoSize = True
        Me.CheckBoxCatMar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxCatMar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CheckBoxCatMar.Location = New System.Drawing.Point(19, 68)
        Me.CheckBoxCatMar.Name = "CheckBoxCatMar"
        Me.CheckBoxCatMar.Size = New System.Drawing.Size(62, 18)
        Me.CheckBoxCatMar.TabIndex = 300
        Me.CheckBoxCatMar.Text = "Marcas"
        Me.CheckBoxCatMar.UseVisualStyleBackColor = True
        '
        'GroupBoxFacturacion
        '
        Me.GroupBoxFacturacion.Controls.Add(Me.CheckBoxFacFac)
        Me.GroupBoxFacturacion.Controls.Add(Me.CheckBoxFacCot)
        Me.GroupBoxFacturacion.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxFacturacion.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBoxFacturacion.Location = New System.Drawing.Point(237, 394)
        Me.GroupBoxFacturacion.Name = "GroupBoxFacturacion"
        Me.GroupBoxFacturacion.Size = New System.Drawing.Size(165, 84)
        Me.GroupBoxFacturacion.TabIndex = 296
        Me.GroupBoxFacturacion.TabStop = False
        Me.GroupBoxFacturacion.Text = " Facturación "
        '
        'CheckBoxFacFac
        '
        Me.CheckBoxFacFac.AutoSize = True
        Me.CheckBoxFacFac.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFacFac.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxFacFac.Location = New System.Drawing.Point(17, 27)
        Me.CheckBoxFacFac.Name = "CheckBoxFacFac"
        Me.CheckBoxFacFac.Size = New System.Drawing.Size(63, 18)
        Me.CheckBoxFacFac.TabIndex = 297
        Me.CheckBoxFacFac.Text = "Factura"
        Me.CheckBoxFacFac.UseVisualStyleBackColor = True
        '
        'CheckBoxFacCot
        '
        Me.CheckBoxFacCot.AutoSize = True
        Me.CheckBoxFacCot.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFacCot.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CheckBoxFacCot.Location = New System.Drawing.Point(17, 50)
        Me.CheckBoxFacCot.Name = "CheckBoxFacCot"
        Me.CheckBoxFacCot.Size = New System.Drawing.Size(76, 18)
        Me.CheckBoxFacCot.TabIndex = 298
        Me.CheckBoxFacCot.Text = "Cotización"
        Me.CheckBoxFacCot.UseVisualStyleBackColor = True
        '
        'GroupBoxInventario
        '
        Me.GroupBoxInventario.Controls.Add(Me.CheckBoxInvMov)
        Me.GroupBoxInventario.Controls.Add(Me.CheckBoxInvCon)
        Me.GroupBoxInventario.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxInventario.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBoxInventario.Location = New System.Drawing.Point(408, 297)
        Me.GroupBoxInventario.Name = "GroupBoxInventario"
        Me.GroupBoxInventario.Size = New System.Drawing.Size(165, 84)
        Me.GroupBoxInventario.TabIndex = 297
        Me.GroupBoxInventario.TabStop = False
        Me.GroupBoxInventario.Text = " Inventario "
        '
        'CheckBoxInvMov
        '
        Me.CheckBoxInvMov.AutoSize = True
        Me.CheckBoxInvMov.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxInvMov.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxInvMov.Location = New System.Drawing.Point(17, 27)
        Me.CheckBoxInvMov.Name = "CheckBoxInvMov"
        Me.CheckBoxInvMov.Size = New System.Drawing.Size(85, 18)
        Me.CheckBoxInvMov.TabIndex = 297
        Me.CheckBoxInvMov.Text = "Movimientos"
        Me.CheckBoxInvMov.UseVisualStyleBackColor = True
        '
        'CheckBoxInvCon
        '
        Me.CheckBoxInvCon.AutoSize = True
        Me.CheckBoxInvCon.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxInvCon.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CheckBoxInvCon.Location = New System.Drawing.Point(17, 50)
        Me.CheckBoxInvCon.Name = "CheckBoxInvCon"
        Me.CheckBoxInvCon.Size = New System.Drawing.Size(74, 18)
        Me.CheckBoxInvCon.TabIndex = 298
        Me.CheckBoxInvCon.Text = "Consultas"
        Me.CheckBoxInvCon.UseVisualStyleBackColor = True
        '
        'GroupBoxCaja
        '
        Me.GroupBoxCaja.Controls.Add(Me.CheckBoxCajaSal)
        Me.GroupBoxCaja.Controls.Add(Me.CheckBoxCajaCorte)
        Me.GroupBoxCaja.Controls.Add(Me.CheckBoxCajaEnt)
        Me.GroupBoxCaja.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxCaja.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBoxCaja.Location = New System.Drawing.Point(408, 186)
        Me.GroupBoxCaja.Name = "GroupBoxCaja"
        Me.GroupBoxCaja.Size = New System.Drawing.Size(165, 105)
        Me.GroupBoxCaja.TabIndex = 298
        Me.GroupBoxCaja.TabStop = False
        Me.GroupBoxCaja.Text = " Caja "
        '
        'CheckBoxCajaSal
        '
        Me.CheckBoxCajaSal.AutoSize = True
        Me.CheckBoxCajaSal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxCajaSal.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CheckBoxCajaSal.Location = New System.Drawing.Point(17, 68)
        Me.CheckBoxCajaSal.Name = "CheckBoxCajaSal"
        Me.CheckBoxCajaSal.Size = New System.Drawing.Size(61, 18)
        Me.CheckBoxCajaSal.TabIndex = 299
        Me.CheckBoxCajaSal.Text = "Salidas"
        Me.CheckBoxCajaSal.UseVisualStyleBackColor = True
        '
        'CheckBoxCajaCorte
        '
        Me.CheckBoxCajaCorte.AutoSize = True
        Me.CheckBoxCajaCorte.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxCajaCorte.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CheckBoxCajaCorte.Location = New System.Drawing.Point(17, 22)
        Me.CheckBoxCajaCorte.Name = "CheckBoxCajaCorte"
        Me.CheckBoxCajaCorte.Size = New System.Drawing.Size(52, 18)
        Me.CheckBoxCajaCorte.TabIndex = 297
        Me.CheckBoxCajaCorte.Text = "Corte"
        Me.CheckBoxCajaCorte.UseVisualStyleBackColor = True
        '
        'CheckBoxCajaEnt
        '
        Me.CheckBoxCajaEnt.AutoSize = True
        Me.CheckBoxCajaEnt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxCajaEnt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxCajaEnt.Location = New System.Drawing.Point(17, 45)
        Me.CheckBoxCajaEnt.Name = "CheckBoxCajaEnt"
        Me.CheckBoxCajaEnt.Size = New System.Drawing.Size(69, 18)
        Me.CheckBoxCajaEnt.TabIndex = 298
        Me.CheckBoxCajaEnt.Text = "Entradas"
        Me.CheckBoxCajaEnt.UseVisualStyleBackColor = True
        '
        'GroupBoxSeguridad
        '
        Me.GroupBoxSeguridad.Controls.Add(Me.CheckBoxSegUsu)
        Me.GroupBoxSeguridad.Controls.Add(Me.CheckBoxSegPer)
        Me.GroupBoxSeguridad.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxSeguridad.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBoxSeguridad.Location = New System.Drawing.Point(408, 394)
        Me.GroupBoxSeguridad.Name = "GroupBoxSeguridad"
        Me.GroupBoxSeguridad.Size = New System.Drawing.Size(165, 84)
        Me.GroupBoxSeguridad.TabIndex = 299
        Me.GroupBoxSeguridad.TabStop = False
        Me.GroupBoxSeguridad.Text = " Seguridad "
        '
        'CheckBoxSegUsu
        '
        Me.CheckBoxSegUsu.AutoSize = True
        Me.CheckBoxSegUsu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSegUsu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxSegUsu.Location = New System.Drawing.Point(17, 27)
        Me.CheckBoxSegUsu.Name = "CheckBoxSegUsu"
        Me.CheckBoxSegUsu.Size = New System.Drawing.Size(69, 18)
        Me.CheckBoxSegUsu.TabIndex = 297
        Me.CheckBoxSegUsu.Text = "Usuarios"
        Me.CheckBoxSegUsu.UseVisualStyleBackColor = True
        '
        'CheckBoxSegPer
        '
        Me.CheckBoxSegPer.AutoSize = True
        Me.CheckBoxSegPer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSegPer.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CheckBoxSegPer.Location = New System.Drawing.Point(17, 50)
        Me.CheckBoxSegPer.Name = "CheckBoxSegPer"
        Me.CheckBoxSegPer.Size = New System.Drawing.Size(70, 18)
        Me.CheckBoxSegPer.TabIndex = 298
        Me.CheckBoxSegPer.Text = "Permisos"
        Me.CheckBoxSegPer.UseVisualStyleBackColor = True
        '
        'GroupBoxConfiguracion
        '
        Me.GroupBoxConfiguracion.Controls.Add(Me.CheckBoxConTic)
        Me.GroupBoxConfiguracion.Controls.Add(Me.CheckBoxConCaja)
        Me.GroupBoxConfiguracion.Controls.Add(Me.CheckBoxConFac)
        Me.GroupBoxConfiguracion.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxConfiguracion.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBoxConfiguracion.Location = New System.Drawing.Point(579, 186)
        Me.GroupBoxConfiguracion.Name = "GroupBoxConfiguracion"
        Me.GroupBoxConfiguracion.Size = New System.Drawing.Size(165, 105)
        Me.GroupBoxConfiguracion.TabIndex = 300
        Me.GroupBoxConfiguracion.TabStop = False
        Me.GroupBoxConfiguracion.Text = " Configuración "
        '
        'CheckBoxConTic
        '
        Me.CheckBoxConTic.AutoSize = True
        Me.CheckBoxConTic.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxConTic.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CheckBoxConTic.Location = New System.Drawing.Point(17, 68)
        Me.CheckBoxConTic.Name = "CheckBoxConTic"
        Me.CheckBoxConTic.Size = New System.Drawing.Size(60, 18)
        Me.CheckBoxConTic.TabIndex = 299
        Me.CheckBoxConTic.Text = "Tickets"
        Me.CheckBoxConTic.UseVisualStyleBackColor = True
        '
        'CheckBoxConCaja
        '
        Me.CheckBoxConCaja.AutoSize = True
        Me.CheckBoxConCaja.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxConCaja.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CheckBoxConCaja.Location = New System.Drawing.Point(17, 22)
        Me.CheckBoxConCaja.Name = "CheckBoxConCaja"
        Me.CheckBoxConCaja.Size = New System.Drawing.Size(47, 18)
        Me.CheckBoxConCaja.TabIndex = 297
        Me.CheckBoxConCaja.Text = "Caja"
        Me.CheckBoxConCaja.UseVisualStyleBackColor = True
        '
        'CheckBoxConFac
        '
        Me.CheckBoxConFac.AutoSize = True
        Me.CheckBoxConFac.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxConFac.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxConFac.Location = New System.Drawing.Point(17, 45)
        Me.CheckBoxConFac.Name = "CheckBoxConFac"
        Me.CheckBoxConFac.Size = New System.Drawing.Size(63, 18)
        Me.CheckBoxConFac.TabIndex = 298
        Me.CheckBoxConFac.Text = "Factura"
        Me.CheckBoxConFac.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(357, 13)
        Me.Label2.TabIndex = 301
        Me.Label2.Text = "Seleccione las permisos a los que tendrá acceso un usuario: "
        '
        'CheckBoxSeleccionarTodo
        '
        Me.CheckBoxSeleccionarTodo.AutoSize = True
        Me.CheckBoxSeleccionarTodo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSeleccionarTodo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxSeleccionarTodo.Location = New System.Drawing.Point(392, 152)
        Me.CheckBoxSeleccionarTodo.Name = "CheckBoxSeleccionarTodo"
        Me.CheckBoxSeleccionarTodo.Size = New System.Drawing.Size(120, 17)
        Me.CheckBoxSeleccionarTodo.TabIndex = 302
        Me.CheckBoxSeleccionarTodo.Text = "Seleccionar todo"
        Me.CheckBoxSeleccionarTodo.UseVisualStyleBackColor = True
        '
        'labelResul
        '
        Me.labelResul.AutoSize = True
        Me.labelResul.Location = New System.Drawing.Point(237, 99)
        Me.labelResul.Name = "labelResul"
        Me.labelResul.Size = New System.Drawing.Size(109, 13)
        Me.labelResul.TabIndex = 303
        Me.labelResul.Text = "Información del grupo"
        '
        'Permisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 548)
        Me.Controls.Add(Me.labelResul)
        Me.Controls.Add(Me.CheckBoxSeleccionarTodo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBoxConfiguracion)
        Me.Controls.Add(Me.GroupBoxSeguridad)
        Me.Controls.Add(Me.GroupBoxCaja)
        Me.Controls.Add(Me.GroupBoxInventario)
        Me.Controls.Add(Me.GroupBoxFacturacion)
        Me.Controls.Add(Me.GroupBoxCatalogos)
        Me.Controls.Add(Me.GroupBoxReportes)
        Me.Controls.Add(Me.buttonAceptar)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.textBoxNombrePermiso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AbonarToolStrip)
        Me.Name = "Permisos"
        Me.Text = "Permisos"
        Me.AbonarToolStrip.ResumeLayout(False)
        Me.AbonarToolStrip.PerformLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxReportes.ResumeLayout(False)
        Me.GroupBoxReportes.PerformLayout()
        Me.GroupBoxCatalogos.ResumeLayout(False)
        Me.GroupBoxCatalogos.PerformLayout()
        Me.GroupBoxFacturacion.ResumeLayout(False)
        Me.GroupBoxFacturacion.PerformLayout()
        Me.GroupBoxInventario.ResumeLayout(False)
        Me.GroupBoxInventario.PerformLayout()
        Me.GroupBoxCaja.ResumeLayout(False)
        Me.GroupBoxCaja.PerformLayout()
        Me.GroupBoxSeguridad.ResumeLayout(False)
        Me.GroupBoxSeguridad.PerformLayout()
        Me.GroupBoxConfiguracion.ResumeLayout(False)
        Me.GroupBoxConfiguracion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AbonarToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ButtonLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents textBoxNombrePermiso As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Barra As System.Windows.Forms.PictureBox
    Friend WithEvents buttonAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBoxReportes As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxRepProv As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxRepClie As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxRepSalPro As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxRepEntPro As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxRepProd As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxRepVen As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxRepFac As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxRepDepEfec As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxRepRetEfec As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBoxCatalogos As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxCatProv As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCatUni As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCatClie As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCatPro As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCatDep As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCatCat As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCatMar As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBoxFacturacion As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxFacFac As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFacCot As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBoxInventario As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxInvMov As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxInvCon As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBoxCaja As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxCajaSal As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCajaCorte As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCajaEnt As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBoxSeguridad As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxSegUsu As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSegPer As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBoxConfiguracion As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxConTic As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxConCaja As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxConFac As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxSeleccionarTodo As System.Windows.Forms.CheckBox
    Friend WithEvents labelResul As System.Windows.Forms.Label
End Class
