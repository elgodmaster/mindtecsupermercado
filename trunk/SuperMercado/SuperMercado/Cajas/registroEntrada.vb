Imports System.Windows.Forms

Public Class registroEntrada

#Region " Variables de trabajo "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
#End Region

    ' Guarda el ingreso registrado.
#Region "Grabar"
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Validar que se haya tecleado un ingreso
        If numIngreso.Value <= 0 Then
            MessageBox.Show("No ha especificado el ingreso.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Me.Close()

    End Sub
#End Region

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
        Me.Close()
    End Sub

    Private Sub numIngreso_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numIngreso.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRazonEntrada.Focus()
        End If
    End Sub
End Class

