Public Class Cat_Clientes_RegistroAbono

#Region "  Variables de trabajo  "
    ' Variables para la consulta.
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno

    Dim pos As Integer
    Dim montoAbono As String
    Dim cuenta As String
    Dim usuario As String
    Dim codigo As String
    Dim dataSet As DataSet
    Dim DsViewCuentas As Object
    Dim lblSaldoActual As Label

#End Region

#Region "  Botón ACEPTAR  "
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If numAbono.Value < 0 Then
            MessageBox.Show("No ha registrado una la cantidad del abono.", " Abonos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            numAbono.Focus()
            numAbono.Select(0, 9)
            Return
        End If

        Dim adeudoActual As Decimal
        adeudoActual = dataSet.Tables(0).Rows(pos).Item(3)

        If numAbono.Value > adeudoActual Then
            MessageBox.Show("El abono es mayor que el adeudo", " Abonos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            numAbono.Focus()
            numAbono.Select(0, 9)
            Return
        End If

        montoAbono = numAbono.Value.ToString
        Caja = "GRABAR117"
        Parametros = "V1=" & cuenta & _
                     "|V2=" & montoAbono & _
                     "|V3=" & usuario & _
                     "|V4=" & codigo

        ObjRet = lConsulta.LlamarCaja(Caja, 1, Parametros)

        dataSet.Tables(0).Clear()

        ' -------------------------------------------
        '| Se actualiza los datos de su estado de cuenta.
        ' -------------------------------------------

        Caja = "Consulta117" : Parametros = "V1=" & codigo & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, 1, Parametros)

        ' Se inserta la consulta en el Grid Cuentas.
        If Not ObjRet.DS Is DBNull.Value Then
            If Not ObjRet.DS.Tables Is DBNull.Value Then
                If ObjRet.DS.Tables.Count > 0 Then
                    For i As Integer = 0 To ObjRet.DS.Tables(0).Rows.Count - 1
                        dataSet.Tables(0).ImportRow(ObjRet.DS.Tables(0).Rows(i))
                    Next
                    dataSet.Tables(0).AcceptChanges()
                    DsViewCuentas = dataSet.Tables(0).DefaultView
                    'Else
                    '   FilaVacia()

                End If
            End If
        End If

        Caja = "Consulta105" : Parametros = "V1=" & codigo.Trim
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)

        lblSaldoActual.Text = "$ " & lConsulta.ObtenerValor("V17", ObjRet.sResultado, "|")

        Me.Close()

    End Sub
#End Region

#Region "  Botón Cancelar  "
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub
#End Region

#Region "  Rutina grabarAbono  "
    Friend Sub pasoVariables(ByVal posR As Integer, _
                             ByRef cuentaR As String, _
                             ByRef usuarioR As String, _
                             ByRef codigoR As String, _
                             ByRef dataSetR As DataSet, _
                             ByRef dsViewCuentasR As Object, _
                             ByRef labelR As Label)
        Me.pos = posR
        Me.cuenta = cuentaR
        Me.usuario = usuarioR
        Me.codigo = codigoR
        Me.dataSet = dataSetR
        Me.DsViewCuentas = dsViewCuentasR
        Me.lblSaldoActual = labelR

    End Sub
#End Region

#Region "  Evento LOAD  "
    Private Sub Cat_Clientes_RegistroAbono_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        numAbono.Focus()
        numAbono.Select(0, 9)
    End Sub
#End Region

#Region "  Evento KeyDown  "
    Private Sub numAbono_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numAbono.KeyDown
        If e.KeyCode = Keys.Enter Then
            OK_Button.Focus()
        End If
    End Sub
#End Region

End Class