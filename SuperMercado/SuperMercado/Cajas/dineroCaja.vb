Imports System.Data
Imports System.Data.SqlClient
Public Class dineroCaja

#Region "Variables de trabajo"
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
#End Region

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        'El monto inicial será cero si el usuario hace clic en "Cancelar"
        Caja = "GRABAR110" : Parametros = "V1=0.0|"

        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        Me.Close()

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        ' Valida la cantidad dinero inical.
        If numDineroInicial.Value < 0 Then
            MessageBox.Show("No ha ingresado una cantidad inicial.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            numDineroInicial.Focus()
            Return
        End If

        ' Ingresa el valor a la tabla CORTE_CAJA

        Caja = "GRABAR110" : Parametros = "V1=" & numDineroInicial.Value & "|"

        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        Me.Close()

    End Sub

    Private Sub numDineroInicial_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numDineroInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            OK_Button.Focus()
        End If
    End Sub

    Private Sub dineroCaja_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        numDineroInicial.Focus()
        numDineroInicial.Select(0, 8)
    End Sub
End Class