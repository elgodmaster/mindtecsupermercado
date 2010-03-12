Public Class Login

#Region "Variables De Trabajo"
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
#End Region

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Inicializar Variable
        Me.Usuario.Text = ""
        Me.PassWord.Text = ""
        Me.CambiarPassWord.Checked = False
        Me.PassWord1.Text = ""
        Me.PassWord2.Text = ""
        Me.Tag = ""
        Me.Size = New Size(701, 236)
        Me.Usuario.Focus()
    End Sub


    Private Sub Btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Aceptar.Click
        If Len(Trim(Me.Usuario.Text)) = 0 Then
            MessageBox.Show("El Usuario esta vacio")
            Me.Usuario.Focus()
            Exit Sub
        End If

        If Len(Trim(Me.PassWord.Text)) = 0 Then
            MessageBox.Show("La Contraseña esta vacia")
            Me.PassWord.Focus()
            Exit Sub
        End If

        Entrar()

        'Caja = "Consulta1" : Parametros = "V1=" & Me.PassWord.Text & "|V2=" & Me.Usuario.Text & "|"
        'If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        'ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
        'If ObjRet.bOk Then
        '    Entrar()
        'End If

        'Cambio de Password
        If Me.CambiarPassWord.Checked Then
            If Len(Trim(Me.PassWord1.Text)) = 0 Then
                MessageBox.Show("La Contraseña esta vacia")
                Me.PassWord1.Focus()
                Exit Sub
            End If
            If Len(Trim(Me.PassWord2.Text)) = 0 Then
                MessageBox.Show("La Contraseña esta vacia")
                Me.PassWord2.Focus()
                Exit Sub
            End If
            'Validar la Nueva Contraseña
            If Me.PassWord1.Text = Me.PassWord2.Text Then
                Dim NewPass As String = Me.PassWord1.Text

            Else
                MessageBox.Show("Las Contraseña no son iguales ")
                Me.PassWord1.Focus()
                Exit Sub
            End If

            'Caja = "Consulta1" : Parametros = "V1=" & Me.PassWord.Text & "|V2=" & Me.Usuario.Text & "|V3=" & Me.TxTPassWord1.Text & "|"
            'If lConsulta Is Nothing Then lConsulta = New ClsConsultas
            'ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)
            'If ObjRet.bOk Then
            '    Entrar()
            'End If
        End If

        ''asignar valores  pass user

    End Sub

    Private Sub Usuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Usuario.KeyDown
        Select Case e.KeyCode
            Case Keys.Down, Keys.Up, Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub PassWord_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PassWord.KeyDown
        Select Case e.KeyCode
            Case Keys.Up, Keys.Down
                SendKeys.Send("+{TAB}")
            Case Keys.Enter
                Btn_Aceptar_Click(Btn_Aceptar, e)
        End Select
    End Sub

    Sub Entrar()
        Dim prin As new Principal()
        prin.Show()
        Me.Dispose()
    End Sub


    Private Sub CambiarPassWord_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CambiarPassWord.CheckedChanged
        If CambiarPassWord.Checked Then
            'Habilitar
            Me.TxTPassWord1.Visible = True
            Me.TxTPassWord2.Visible = True
            Me.PassWord1.Visible = True
            Me.PassWord2.Visible = True
            'Asignar
            Me.PassWord1.Text = ""
            Me.PassWord2.Text = ""
            'Tamaño del Formulario
            Me.Size = New Size(701, 236)
            'Poner Focus
            Me.PassWord1.Focus()
        Else
            'Deshabilitar
            Me.TxTPassWord1.Visible = False
            Me.PassWord1.Visible = False
            Me.TxTPassWord2.Visible = False
            Me.PassWord2.Visible = False
            'Asignar
            Me.PassWord1.Text = ""
            Me.PassWord2.Text = ""
            'Tamaño del Formulario
            Me.Size = New Size(701, 333)
            'Poner Focus
            Me.Usuario.Focus()
        End If
    End Sub
End Class