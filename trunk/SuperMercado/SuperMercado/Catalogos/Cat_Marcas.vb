Imports MindTec.Componentes

Public Class Cat_Marcas

#Region " Variables de trabajo "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
#End Region

#Region " Eventos Principales "
    Private Sub Cat_Marcas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                'Catalogo()
            Case Keys.Escape
                Cerrar()
            Case Keys.F4
                Buscar.PerformClick()
            Case Keys.F9
                Grabar.PerformClick()
        End Select
    End Sub

    Private Sub Cat_Marcas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ocultarControlesEditar()
    End Sub
#End Region

#Region " Rutinas "
    Sub LimpiarPantalla()

        'Habilidar

        Me.CodigoMarca.Enabled = True
        Me.Nuevo.Visible = True
        'Deshabilitar
        Me.GroupBoxMarca.Visible = False
        Me.Grabar.Visible = False

        'Asignar
        Me.CodigoMarca.Text = ""

        Me.Descripcion.Text = ""
        'PiePagina
        'Foco
        Me.CodigoMarca.Focus()
    End Sub

    Sub Cerrar()
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Deseas salir de esta pantalla?", "HidroIntel", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region

#Region " Marca "
    Private Sub CodigoMarca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoMarca.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Me.Catalogo()
            Case Keys.Enter, Keys.Down
                'Servicios
                Caja = "Consulta102" : Parametros = "V1=" & Me.CodigoMarca.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                'Estatus
                If ObjRet.bOk Then
                    'Asignar

                    SendKeys.Send("{TAB}")

                Else
                    'Asignar


                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

                    'poner focus
                    Me.CodigoMarca.Focus()
                End If
                'Destruir
                ObjRet = Nothing
            Case Keys.Up
                SendKeys.Send("+{TAB}")
        End Select
    End Sub
#End Region

#Region " Aceptar "
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
#End Region

#Region " Grabar "
    Private Sub Grabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grabar.Click
        'Variable de trabajo
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Deseas Guardar los Cambios?", "PVFacturacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            Caja = "Grabar102" : Parametros = "V1=" & Me.CodigoMarca.Text & "|V2=" & Me.Descripcion.Text & "|"
            If lConsulta Is Nothing Then lConsulta = New ClsConsultas
            ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)


            If lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "OK" Then
                MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False), " Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarPantalla()
                ocultarControlesEditar()
            Else
                MessageBox.Show("La marca ya se encuentra registrada.", " Marcas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub
#End Region

#Region " Nuevo "
    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        mostrarControlesEditar()
        Grabar.Enabled = True

        Caja = "Consulta102" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "3", Parametros)
        If ObjRet.bOk Then
            'Deshabilitar
            Me.Nuevo.Visible = False
            Me.CodigoMarca.Enabled = False

            'Asignar

            Me.CodigoMarca.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
            'Habilitar
            Me.GroupBoxMarca.Visible = True
            Me.Grabar.Visible = True
            'Focus
            Me.Descripcion.Clear()
            Me.Descripcion.Focus()

        End If
    End Sub
#End Region

#Region "  Rutina: mostrarControlesEditar  "
    Sub mostrarControlesEditar()
        Grabar.Visible = True
        Limpiar.Visible = True
    End Sub
#End Region

#Region "  Rutina: ocultarControlesEditar  "
    Sub ocultarControlesEditar()
        Grabar.Visible = False
        Limpiar.Visible = False
    End Sub
#End Region

#Region "  Botón BUSCAR  "
    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        Catalogo()
    End Sub
#End Region

#Region "  Botón LIMPIAR  "
    Private Sub Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        Descripcion.Clear()
    End Sub
#End Region

#Region "  Rutina: Consulta102  "
    Sub consulta102()
        Nuevo.Visible = True
        mostrarControlesEditar()
        Grabar.Enabled = True

        Caja = "Consulta102" : Parametros = "V1=" & Me.CodigoMarca.Text
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)
        If ObjRet.bOk Then
            mostrarControlesEditar()
            'Deshabilitar
            Me.CodigoMarca.Enabled = False


            'Asignar
            Me.Descripcion.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
            If Descripcion.Text = "-SIN MARCA-" Then
                Grabar.Enabled = False
            End If

            'Habilitar
            Me.Grabar.Visible = True
            Me.GroupBoxMarca.Visible = True
            'Foco
            Me.Descripcion.SelectAll()
            Me.Descripcion.Focus()
        Else
            'Asignar
            Me.CodigoMarca.Text = ""

            Me.Descripcion.Text = ""


            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

            'Foco
            Me.CodigoMarca.Focus()
        End If
        ObjRet = Nothing
    End Sub
#End Region

#Region "  Rutina: catalogo  "
    Sub Catalogo()
        Caja = "Consulta133" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            If nuevo.resultado = "" Then
                Return
            End If

            Me.CodigoMarca.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            consulta102()
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If

    End Sub
#End Region
    
#Region "  Evento: CodigoMarca - KEY PRESS  "
    Private Sub CodigoMarca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CodigoMarca.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            'Servicios
            Caja = "Consulta102" : Parametros = "V1=" & Me.CodigoMarca.Text
            If lConsulta Is Nothing Then lConsulta = New ClsConsultas
            ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)
            If ObjRet.bOk Then
                mostrarControlesEditar()
                'Deshabilitar
                Me.CodigoMarca.Enabled = False


                'Asignar
                Me.Descripcion.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")

                'Habilitar
                Me.Grabar.Visible = True
                Me.GroupBoxMarca.Visible = True
                'Foco
                Me.Descripcion.Focus()
            Else
                'Asignar
                Me.CodigoMarca.Text = ""

                Me.Descripcion.Text = ""


                MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

                'Foco
                Me.CodigoMarca.Focus()
            End If
            ObjRet = Nothing
        End If
    End Sub
#End Region

End Class