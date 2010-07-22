Imports MindTec.Componentes

Public Class Cat_Departamentos

#Region " Variables de trabajo "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
#End Region

#Region "  Evento: Cat_Departamentos - LOAD  "
    Private Sub Cat_Departamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Grabar.Visible = False
        Me.Limpiar.Visible = False
    End Sub
#End Region

#Region " Eventos Principales"
    Private Sub Cat_Departamentos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                'Catalogo
            Case Keys.Escape
                Cerrar()
            Case Keys.F4
                Limpiar.PerformClick()
            Case Keys.F9
                Grabar.PerformClick()
        End Select
    End Sub
#End Region

#Region " Departamento "
    Private Sub CodigoDepto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoDepto.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Me.Catalogo()
            Case Keys.Enter, Keys.Down
                'Servicios
                Caja = "Consulta100" : Parametros = "V1=" & Me.CodigoDepto.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                'Estatus
                If ObjRet.bOk Then
                    'Asignar
                    Me.NombreDepto.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
                    SendKeys.Send("{TAB}")

                Else
                    'Asignar
                    Me.NombreDepto.Text = ""
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

                    'poner focus
                    Me.CodigoDepto.Focus()
                End If
                'Destruir
                ObjRet = Nothing
            Case Keys.Up
                SendKeys.Send("+{TAB}")
        End Select
    End Sub
#End Region

#Region " Aceptar "
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Caja = "Consulta100" : Parametros = "V1=" & Me.CodigoDepto.Text
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)
        If ObjRet.bOk Then
            'Deshabilitar
            Me.CodigoDepto.Enabled = False
            Me.btnAceptar.Enabled = False
            Me.Nuevo.Visible = False
            Limpiar.Visible = True
            Grabar.Visible = True

            'Asignar
            Me.TxtDescripcion.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")

            'Habilitar
            Me.Grabar.Visible = True
            Me.GroupBoxDepto.Visible = True
            'Foco
            Me.TxtDescripcion.Focus()
        Else
            'Asignar
            Me.CodigoDepto.Text = ""
            Me.NombreDepto.Text = ""
            Me.TxtDescripcion.Text = ""

            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

            'Foco
            Me.CodigoDepto.Focus()
        End If
        ObjRet = Nothing

    End Sub
#End Region

#Region " Limpiar "
    Private Sub Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        LimpiarPantalla()
    End Sub
#End Region

#Region " Rutinas "
    Sub LimpiarPantalla()
        Me.TxtDescripcion.Clear()
        Me.TxtDescripcion.Focus()

    End Sub
    Sub Cerrar()
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Deseas salir de esta pantalla?", "Supermercado Beltrán", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region

#Region " Grabar "
    Private Sub Grabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grabar.Click
        'Variable de trabajo
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Deseas Guardar los Cambios?", " SMercado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            Caja = "Grabar100" : Parametros = "V1=" & Me.CodigoDepto.Text.Trim & _
                                              "|V2=" & Me.TxtDescripcion.Text.Trim & "|"

            If lConsulta Is Nothing Then lConsulta = New ClsConsultas
            ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
            If ObjRet.bOk Then
                regresarPantalla()
            End If
        End If
    End Sub
#End Region

#Region " Nuevo "
    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        Limpiar.Visible = True
        Grabar.Enabled = True

        Caja = "Consulta100" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "3", Parametros)
        If ObjRet.bOk Then
            'Deshabilitar
            Me.Nuevo.Visible = False
            Me.CodigoDepto.Enabled = False
            Me.btnAceptar.Enabled = False
            'Asignar
            Me.NombreDepto.Text = ""
            Me.CodigoDepto.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
            'Habilitar
            Me.GroupBoxDepto.Visible = True
            Me.Grabar.Visible = True
            'Focus
            Me.TxtDescripcion.Clear()
            Me.TxtDescripcion.Focus()

        End If
    End Sub
#End Region

#Region "  Rutina: catalogo  "
    Sub Catalogo()
        Caja = "Consulta100" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            If nuevo.resultado = "" Then
                Return
            End If
            Me.CodigoDepto.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)

            consulta100()

        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If

    End Sub
#End Region

#Region "  Rutina: regresarPantalla "
    Sub regresarPantalla()
        'Habilidar
        Me.btnAceptar.Enabled = True
        Me.CodigoDepto.Enabled = True
        Me.Nuevo.Visible = True
        'Deshabilitar
        Me.GroupBoxDepto.Visible = False
        Me.Grabar.Visible = False
        Me.Limpiar.Visible = False

        'Asignar
        Me.CodigoDepto.Text = ""
        Me.NombreDepto.Text = ""
        Me.TxtDescripcion.Text = ""
        'PiePagina
        'Foco
        Me.CodigoDepto.Focus()
    End Sub
#End Region

#Region "  Botón BUSCAR  "
    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        Catalogo()
    End Sub
#End Region

#Region "  Rutina: consulta100  "
    Sub consulta100()
        Nuevo.Visible = True
        Limpiar.Visible = True
        Grabar.Visible = True
        Grabar.Enabled = True

        Caja = "Consulta100" : Parametros = "V1=" & Me.CodigoDepto.Text
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)
        If ObjRet.bOk Then
            'Deshabilitar
            Me.CodigoDepto.Enabled = False
            Me.btnAceptar.Enabled = False
            Limpiar.Visible = True
            Grabar.Visible = True

            'Asignar
            Me.TxtDescripcion.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
            If TxtDescripcion.Text = "-SIN DEPARTAMENTO-" Then
                Grabar.Enabled = False
            End If

            'Habilitar
            Me.Grabar.Visible = True
            Me.GroupBoxDepto.Visible = True
            'Foco
            Me.TxtDescripcion.SelectAll()
            Me.TxtDescripcion.Focus()
        Else
            'Asignar
            Me.CodigoDepto.Text = ""
            Me.NombreDepto.Text = ""
            Me.TxtDescripcion.Text = ""

            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

            'Foco
            Me.CodigoDepto.Focus()
        End If
        ObjRet = Nothing
    End Sub
#End Region

End Class