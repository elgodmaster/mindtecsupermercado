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
            MessageBox.Show("No ha especificado la cantidad a retirar.", "Salidas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            numRetiro.Focus()
            Return
        End If

        If txtRazonSalida.Text.Trim = "" Then
            MessageBox.Show("No ha especificado la razón del retiro.", "Salidas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRazonSalida.Focus()
            Return
        End If

        ' Se llama a al consulta111 conocer el total de dinero
        ' acumulado.

        Caja = "consulta111" : Parametros = "V1=" & usuario & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        Dim sumEnt As Decimal
        Dim sumSal As Decimal
        Dim dinIni As Decimal
        Dim ventasTotal As Decimal
        Dim total As Decimal

        sumEnt = Decimal.Parse(ObjRet.DS.Tables(3).Rows(0).Item(1))
        sumSal = Decimal.Parse(ObjRet.DS.Tables(3).Rows(0).Item(2))
        dinIni = Decimal.Parse(ObjRet.DS.Tables(3).Rows(0).Item(0))
        ventasTotal = Decimal.Parse(ObjRet.DS.Tables(3).Rows(0).Item(3))
        total = dinIni + sumEnt + ventasTotal - sumSal

        If numRetiro.Value > total Then
            MessageBox.Show("La cantidad a retirar es mayor que el dinero actual en la caja." & _
                            vbCrLf & _
                            "Dinero en la caja: $" & total & _
                            vbCrLf & _
                            "Suma a retirar: $" & numRetiro.Value.ToString, "Salidas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            numRetiro.Focus()
            numRetiro.Select(0, 9)
            Return
        End If

        Caja = "GRABAR112" : Parametros = "V1=1" & _
                                          "|V2=" & usuario & _
                                          "|V3=" & numRetiro.Value & _
                                          "|V4=" & txtRazonSalida.Text & "|"
        ' Donde los parámetros son:
        ' V1 = IDCaja, por el momento 1.
        ' V2 = IDUsuario, por el momento 1.
        ' V3 = Monto a retirar.
        ' V4 = Concepto del retiro.

        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        MessageBox.Show("Cantidad retirada con éxito", "Salidas", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()

    End Sub

    Private Sub numRetiro_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numRetiro.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRazonSalida.Focus()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtRazonSalida_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRazonSalida.KeyDown
        If e.KeyCode = Keys.Enter Then
            OK_Button.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
