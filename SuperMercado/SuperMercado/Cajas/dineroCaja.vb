Imports System.Data
Imports System.Data.SqlClient

Public Class dineroCaja

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Visible = False
        Me.Close()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        ' Valida la cantidad dinero inical.
        If numDineroInicial.Value <= 0 Then
            MessageBox.Show("No ha ingresado una cantidad inicial.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            numDineroInicial.Focus()
            Return
        End If

        ' Ingresa el valor a la tabla CORTE_CAJA

        Dim lConexion As New SqlConnection
        '*-- Para conectar desde el servidor.                --*
        Dim sCadena As String = String.Empty
        sCadena = My.Settings.Servidor
        lConexion.ConnectionString = sCadena

        '*-- Para conectarla localmente desde PCLINDORMARIO. --*
        'Dim lConexion As New SqlConnection
        'lConexion.ConnectionString = "Data Source=PCLINDORMARIO;Initial Catalog=PVF_LogicaNegocios;Integrated Security=True"

        Try
            lConexion.Open()
        Catch ex As Exception
            MessageBox.Show("Error al tratar de conectar a la base de datos.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Dim objSqlAdapter As New SqlDataAdapter
        Dim objDataSet As New DataSet
        Dim objCommand As New SqlCommand

        objCommand.CommandText = "GRABAR110"
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Connection = lConexion

        With objCommand.Parameters
            .Clear()
            .Add("@dinInicial", SqlDbType.Decimal, "12,2").Value = numDineroInicial.Value
        End With

        objSqlAdapter.SelectCommand = objCommand

        Try
            objSqlAdapter.Fill(objDataSet)
        Catch ex As Exception
            MessageBox.Show("Error al tratar de insertar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        lConexion.Close()

        Me.Close()

        Dim cajaActual As New Caja
        cajaActual.MdiParent = Principal
        cajaActual.WindowState = FormWindowState.Maximized

        cajaActual.StartPosition = FormStartPosition.CenterScreen
        cajaActual.Focus()
        cajaActual.Show()

    End Sub

    Private Sub numDineroInicial_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numDineroInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            OK_Button.Focus()
        End If
    End Sub
End Class