Imports System.Windows.Forms

Public Class registroSalida

#Region " Variables de trabajo "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
#End Region

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub registroSalida_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        numRetiro.Focus()
        numRetiro.Select(0, 4)
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If numRetiro.Value <= 0 Then
            MessageBox.Show("No ha especificado la cantidad a retirar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            numRetiro.Focus()
            Return
        End If

        Caja = "GRABAR112" : Parametros = "V1=1|" & _
                                          "V2=1|" & _
                                          "V3=" & numRetiro.Value & "|" & _
                                          "V4=" & txtRazonSalida.Text & "|"
        ' Donde los parámetros son:
        ' V1 = IDCaja, por el momento 1.
        ' V2 = IDUsuario, por el momento 1.
        ' V3 = Monto a retirar.
        ' V4 = Concepto del retiro.

        If lConsulta Is Nothing Then lConsulta = New ClsConsultas

        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        If (ObjRet.bOk) Then
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False), "Retiros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' No se ha especificado el concepto.
            If lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|", False) = "ERROR1" Then
                txtRazonSalida.Focus()
                ' La suma a retirar es mayor que el monto actual.
            ElseIf lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|", False) = "ERROR2" Then
                numRetiro.Select(0, 8)
                numRetiro.Focus()
            End If
        End If
    End Sub

    Private Sub numRetiro_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numRetiro.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRazonSalida.Focus()
        End If
    End Sub

    Private Sub txtRazonSalida_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRazonSalida.KeyDown
        If e.KeyCode = Keys.Enter Then
            OK_Button.Focus()
        End If
    End Sub
End Class
