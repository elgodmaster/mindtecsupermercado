Imports System.Windows.Forms

Public Class registroEntrada

#Region " Variables de trabajo "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
#End Region

    ' Guarda el ingreso registrado.

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub registroEntrada_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        numIngreso.Focus()
        numIngreso.Select(0, 4)
    End Sub


    Private Sub txtRazonEntrada_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRazonEntrada.KeyDown
        If e.KeyCode = Keys.Enter Then
            OK_Button.Focus()
        End If
    End Sub

    Private Sub OK_Button_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If numIngreso.Value <= 0 Then
            MessageBox.Show("No ha registrado una cantidad de ingreso.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            numIngreso.Focus()
            Return
        End If
        Caja = "Grabar111" : Parametros = "V1=1|" & _
                                          "V2=1|" & _
                                          "V3=" & numIngreso.Value & "|" & _
                                          "V4=" & txtRazonEntrada.Text & "|"
        ' Donde los parámetros son:
        ' V1 = IDCaja, por el momento 1.
        ' V2 = IDUsuario, por el momento 1.
        ' V3 = Monto a ingresar.
        ' V4 = Concepto del ingreso.

        If lConsulta Is Nothing Then lConsulta = New ClsConsultas

        ' Aquí se llama al procedimiento almacenado GRABAR111
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
        If (ObjRet.bOk) Then
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False), "Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If

        ' CONFIGURACION_CAJA
        ' Si está activado un monto máximo por defecto se sugiere
        ' que se haga el corte.
        Caja = "Consulta112" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        Dim activadoMontoMaximo As Boolean
        Dim montoPorDefecto As Decimal
        activadoMontoMaximo = ObjRet.DS.Tables(0).Rows(0).Item(3)
        montoPorDefecto = ObjRet.DS.Tables(0).Rows(0).Item(4)

        If activadoMontoMaximo Then
            ' Se llama a al consulta111 conocer el total de dinero
            ' acumulado.

            Caja = "consulta111" : Parametros = ""
            ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

            Dim sumEnt As Decimal
            Dim sumSal As Decimal
            Dim dinIni As Decimal
            Dim total As Decimal
            Dim ventasTotal As Decimal

            sumEnt = Decimal.Parse(ObjRet.DS.Tables(3).Rows(0).Item(1))
            sumSal = Decimal.Parse(ObjRet.DS.Tables(3).Rows(0).Item(2))
            dinIni = Decimal.Parse(ObjRet.DS.Tables(3).Rows(0).Item(0))
            ventasTotal = Decimal.Parse(ObjRet.DS.Tables(3).Rows(0).Item(3))
            total = dinIni + sumEnt + ventasTotal - sumSal

            If total >= montoPorDefecto Then
                MessageBox.Show("La cantidad actual en la caja es: $" & total & vbCrLf & _
                            "La cantidad máxima a tener en caja es: $" & montoPorDefecto & vbCrLf & _
                            vbCrLf & "Se le sugiere que haga el corte en caja.", "Información", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub numIngreso_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numIngreso.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRazonEntrada.Focus()
        End If
    End Sub
End Class

