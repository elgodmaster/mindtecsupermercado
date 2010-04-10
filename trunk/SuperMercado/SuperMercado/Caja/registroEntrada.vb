Imports System.Windows.Forms

Public Class registroEntrada

#Region " Variables de trabajo "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
#End Region

    ' Guarda el ingreso registrado.
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        ' Convierte a String el monto de numIngreso.
        Dim strIngreso As String
        strIngreso = numIngreso.Value

        Caja = "GRABAR_CAJA_ENTRADA"
        Parametros = "V1=" & strIngreso.Trim
        Label1.Text = Parametros
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub registroEntrada_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        numIngreso.Focus()
        numIngreso.Select(0, 4)
    End Sub
End Class

