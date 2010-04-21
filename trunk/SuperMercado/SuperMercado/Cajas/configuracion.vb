Public Class configuracion
#Region "Variables de trabajo"
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
#End Region

    Private Sub configuracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '--- Consulta112: Obtiene la configuración de caja ---''
        Caja = "Consulta112" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        If lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|", False) = "OK" Then
            ' ObjRet.DS.Tables(0).Rows(0).Item(0) corresponde a si está activado o no 
            ' el dinero inicial por defecto en la tabla Caja_Configuración. 
            ' Con un 1 para un sí, y 0 para un no.
            If ObjRet.DS.Tables(0).Rows(0).Item(1) = True Then
                ChBxDineroInicial.Checked = True
                GrBxDineroInicial.Enabled = True
                dinIniPredeterminado.Value = ObjRet.DS.Tables(0).Rows(0).Item(2)
            ElseIf ObjRet.DS.Tables(0).Rows(0).Item(1) = False Then
                ChBxDineroInicial.Checked = False
                GrBxDineroInicial.Enabled = False
                dinIniPredeterminado.Value = ObjRet.DS.Tables(0).Rows(0).Item(2)
            End If

            ' ObjRet.DS.Tables(0).Rows(0).Item(2) corresponde a si está activado o no
            ' el monto máximo en caja en la tabla Caja_Configuración.
            If ObjRet.DS.Tables(0).Rows(0).Item(3) = True Then
                ChBxLimitesMaximos.Checked = True
                GrBxDineroInicial.Enabled = True
                montoMaximo.Value = ObjRet.DS.Tables(0).Rows(0).Item(4)
            ElseIf ObjRet.DS.Tables(0).Rows(0).Item(3) = False Then
                ChBxLimitesMaximos.Checked = False
                GrBxDineroInicial.Enabled = False
                montoMaximo.Value = ObjRet.DS.Tables(0).Rows(0).Item(4)
            End If
        Else
            MessageBox.Show("Error al tratar de realizar la inserción en la tabla Caja_Configuración", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Configuración de los componentes.
        If ChBxDineroInicial.Checked Then
            GrBxDineroInicial.Enabled = True
        Else
            GrBxDineroInicial.Enabled = False
        End If

        If ChBxLimitesMaximos.Checked Then
            GrBxLimites.Enabled = True
        Else
            GrBxLimites.Enabled = False
        End If

    End Sub

    Private Sub ChBxDineroInicial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBxDineroInicial.CheckedChanged
        If ChBxDineroInicial.Checked Then
            GrBxDineroInicial.Enabled = True
        Else
            GrBxDineroInicial.Enabled = False
        End If
    End Sub

    Private Sub ChBxLimitesMaximos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBxLimitesMaximos.CheckedChanged
        If ChBxLimitesMaximos.Checked Then
            GrBxLimites.Enabled = True
        Else
            GrBxLimites.Enabled = False
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Caja = "GRABAR114"
        Parametros = "V1=" & ChBxDineroInicial.Checked.ToString & "|" & _
                     "V2=" & dinIniPredeterminado.Value & "|" & _
                     "V3=" & ChBxLimitesMaximos.Checked.ToString & "|" & _
                     "V4=" & montoMaximo.Value & "|"
        'MessageBox.Show("Parametros: " & Parametros, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        Me.Close()
    End Sub
End Class