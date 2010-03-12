Imports System.Data
Imports System.Data.SqlClient


    Public Class ClsConsultas

#Region " Variables de Trabajo "
        Dim lConexion As SqlConnection
#End Region

#Region " Procedimiento para conectar a la BD "
        Public Sub Conectar()
            Dim sCadena As String = String.Empty
            lConexion = New SqlConnection
        sCadena = My.Settings.Servidor
            lConexion.ConnectionString = sCadena
            Try
                lConexion.Open()
            Catch ex As Exception

            End Try
        End Sub
        Public Sub Desconectar()
            Me.lConexion.Close()
            lConexion = Nothing
        End Sub
#End Region

#Region " Controlador de Mensajes "

#End Region

#Region " Emulador ArqDOS"

        Public Function LlamarCaja(ByVal Caja As String, ByVal Validar As String, ByVal Parametro As String, _
                           Optional ByVal Ds As DataSet = Nothing) As cRetorno
        Dim objRet As New cRetorno
        Dim Regreso As String = ""
        Dim Cmd As New SqlCommand
        Dim Sql As String = String.Empty
        Dim Da As New SqlDataAdapter
        Dim DtSet As New DataSet

        Conectar()
        Sql = Caja
        Cmd.CommandText = Sql
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.Connection = Me.lConexion

        Parametro = Parametro & "|"
        With Cmd.Parameters
            .Clear()
            .Add("@Cabezero", SqlDbType.VarChar, 8000).Value = Parametro
            .Add("@Resul", SqlDbType.VarChar, 8000).Value = ""
            .Item("@Resul").Direction = ParameterDirection.InputOutput
            If Not Ds Is Nothing Then
                .Add("@DataSet", SqlDbType.NText).Value = Ds.GetXml
            Else
                .Add("@DataSet", SqlDbType.NText).Value = ""
            End If
            .Add("@Validar", SqlDbType.Int).Value = Validar
            '.Add("@UsuarioSistema", SqlDbType.VarChar, 8000).Value = "Web"
        End With

        Da.SelectCommand = Cmd

        Try
            Da.Fill(DtSet)
            Regreso = Cmd.Parameters.Item("@Resul").Value
            objRet.DS = DtSet
            objRet.sResultado = Regreso.Trim & "|"

            'Controlar Mensajes
            If ObtenerValor("2R", Regreso, "|") = "OK" Then
                objRet.bOk = True
            Else
                objRet.bOk = False
            End If
        Catch ex As Exception
            objRet.bOk = False
            objRet.DS = Nothing
            objRet.sResultado = "2R=ERROR|2M=" & Replace(ex.Message, "'", """") & "|"
        End Try
        Desconectar()
        Return objRet
    End Function
        Public Function ObtenerValor(ByVal pNombreCampo As String, ByVal pCadena As String, ByVal pCaracterSeparador As String, Optional ByVal TodoMayuscula As Boolean = True) As String
            Dim nLon As Integer
            Dim nPos_Campo As Integer
            Dim nPos_Separador As Integer
            Dim     sRetorna As String = ""

            Try
                If TodoMayuscula Then
                    pNombreCampo = pNombreCampo.ToUpper
                    pCadena = pCadena.ToUpper
                Else
                    pNombreCampo = pNombreCampo.ToUpper
                    pCadena = pCadena
                End If

                nLon = Len(pNombreCampo) + 1

                nPos_Campo = pCadena.IndexOf(pNombreCampo & "=")

                If nPos_Campo > -1 Then
                    nPos_Separador = pCadena.IndexOf(pCaracterSeparador, nPos_Campo + 1)
                    sRetorna = pCadena.Substring(nPos_Campo + nLon, nPos_Separador - (nPos_Campo + nLon))
                End If
            Catch Ex As Exception
                'Return Ex.Message
            End Try

            Return sRetorna
        End Function
#End Region
End Class

Public Class CRetorno
    Public DS As DataSet
    Public bOk As Boolean
    Public sResultado As String
End Class