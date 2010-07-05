Public Class Cat_Clientes_Devolucion

#Region "  Variables de trabajo  "
    Dim objDetalleVenta As Cat_Clientes_DetalleVenta
    Dim codigoCliente As String

    Dim totalArt As Integer
    Dim idCuentaDetalle As String
    Dim idCuenta As String

    Dim pos As Integer

    Dim liquidar As Boolean

    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
#End Region

#Region "  Evento: Cat_Clientes_Devolucion LOAD  "
    Private Sub Cat_Clientes_Devolucion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        liquidar = False
        numArt.Select(0, 10)
        numArt.Focus()

        pos = objDetalleVenta.posRow()
        totalArt = objDetalleVenta.dsDatosDetalle.Tables(0).Rows(pos).Item(1)
        idCuentaDetalle = objDetalleVenta.dsDatosDetalle.Tables(0).Rows(pos).Item(5)
        idCuenta = objDetalleVenta.idCuenta

        If totalArt = 1 Then


            If objDetalleVenta.dsDatosDetalle.Tables(0).Rows.Count = 1 Then
                Dim resul As DialogResult
                resul = MessageBox.Show("La cuenta será liquidada, ¿desea continuar?", " Adevertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If resul = Windows.Forms.DialogResult.OK Then
                    liquidar = True
                End If
                If resul = Windows.Forms.DialogResult.Cancel Then
                    Me.Close()
                    Return
                End If
            End If

            idCuentaDetalle = objDetalleVenta.dsDatosDetalle.Tables(0).Rows(pos).Item(5)

            Caja = "GRABAR124" : Parametros = "V1=" & totalArt & _
                                              "|V2=" & totalArt & _
                                              "|V3=" & idCuentaDetalle & _
                                              "|V4=" & idCuenta & _
                                              "|V5=" & objDetalleVenta.codigoCliente & "|"

            ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

            Dim deuda As String
            deuda = lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|")


            objDetalleVenta.dsDatosDetalle.Tables(0).Clear()

            ' Actualiza Cat_Clientes_DetalleVenta
            ' Consulta regresa el detalle de una cuenta por cobrar

            Caja = "consulta118a" : Parametros = "V1=" & objDetalleVenta.idCuenta & "|"
            ObjRet = lConsulta.LlamarCaja(Caja, 1, Parametros)

            ' Se inserta la consulta en el Grid ENTRADAS.
            If Not ObjRet.DS Is DBNull.Value Then
                If Not ObjRet.DS.Tables Is DBNull.Value Then
                    If ObjRet.DS.Tables.Count > 0 Then
                        For i As Integer = 0 To ObjRet.DS.Tables(0).Rows.Count - 1
                            objDetalleVenta.dsDatosDetalle.Tables(0).ImportRow(ObjRet.DS.Tables(0).Rows(i))
                        Next
                        objDetalleVenta.dsDatosDetalle.Tables(0).AcceptChanges()
                        objDetalleVenta.DsViewDetalle = objDetalleVenta.dsDatosDetalle.Tables(0).DefaultView
                        'Else
                        '   FilaVacia()

                    End If
                End If
            End If

            objDetalleVenta.objCatCliente.dsDatosCuentas.Tables(0).Clear()

            ' -------------------------------------------
            '| Obtienen los datos de su estado de cuenta.
            ' -------------------------------------------

            Caja = "Consulta117" : Parametros = "V1=" & codigoCliente & "|"
            ObjRet = lConsulta.LlamarCaja(Caja, 1, Parametros)

            ' Se inserta la consulta en el Grid Cuentas.
            If Not ObjRet.DS Is DBNull.Value Then
                If Not ObjRet.DS.Tables Is DBNull.Value Then
                    If ObjRet.DS.Tables.Count > 0 Then
                        For i As Integer = 0 To ObjRet.DS.Tables(0).Rows.Count - 1
                            objDetalleVenta.objCatCliente.dsDatosCuentas.Tables(0).ImportRow(ObjRet.DS.Tables(0).Rows(i))
                        Next
                        objDetalleVenta.objCatCliente.dsDatosCuentas.Tables(0).AcceptChanges()
                        objDetalleVenta.objCatCliente.DsViewCuentas = objDetalleVenta.objCatCliente.dsDatosCuentas.Tables(0).DefaultView
                        'Else
                        '   FilaVacia()

                    End If
                End If
            End If

            Caja = "Consulta105" : Parametros = "V1=" & codigoCliente & "|"
            ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)

            If lConsulta.ObtenerValor("V17", ObjRet.sResultado, "|") = "" Then
                objDetalleVenta.objCatCliente.lblSaldoActual.Text = "$ 0.00"
            Else
                objDetalleVenta.objCatCliente.lblSaldoActual.Text = "$ " & lConsulta.ObtenerValor("V17", ObjRet.sResultado, "|")
            End If

            If deuda <> "" Then
                Me.Close()
                MessageBox.Show("El cliente había pagado $" & deuda & " por el artículo devuelto", " Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If objDetalleVenta.objCatCliente.dsDatosCuentas.Tables(0).Rows.Count = 0 Then
                    objDetalleVenta.Close()
                End If
            End If

            If liquidar Then
                objDetalleVenta.Close()
            End If

            Me.Close()
        Else
            Me.Opacity = 100
        End If
    End Sub
#End Region

#Region "  Rutina: cargaRefPrin  "
    Friend Sub cargaRefPrin(ByRef objRef As Cat_Clientes_DetalleVenta, _
                            ByRef objRef2 As String)
        objDetalleVenta = objRef
        codigoCliente = objRef2
    End Sub
#End Region

#Region "  Botón Cancelar  "
    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub
#End Region

#Region "  Botón Aceptar  "
    Private Sub ButtonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptar.Click

        pos = objDetalleVenta.posRow()
  

        totalArt = objDetalleVenta.dsDatosDetalle.Tables(0).Rows(pos).Item(1)
        idCuentaDetalle = objDetalleVenta.dsDatosDetalle.Tables(0).Rows(pos).Item(5)
        idCuenta = objDetalleVenta.idCuenta

        '<VALIDACIONES>
        If numArt.Value > totalArt Then
            MessageBox.Show("La cantidad de artículos a devolver excede al número de artículos comprados.", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            numArt.Select(0, 10)
            numArt.Focus()
            Return
        End If

        If numArt.Value = totalArt And _
        objDetalleVenta.dsDatosDetalle.Tables(0).Rows.Count = 1 Then
            Dim resul As DialogResult
            resul = MessageBox.Show("La cuenta será liquidada, ¿desea continuar?", " Adevertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If resul = Windows.Forms.DialogResult.OK Then
                liquidar = True
            End If
            If resul = Windows.Forms.DialogResult.Cancel Then
                Me.Close()
                Return
            End If
        End If


        idCuentaDetalle = objDetalleVenta.dsDatosDetalle.Tables(0).Rows(pos).Item(5)

        Caja = "GRABAR124" : Parametros = "V1=" & numArt.Value & _
                                          "|V2=" & totalArt & _
                                          "|V3=" & idCuentaDetalle & _
                                          "|V4=" & idCuenta & _
                                          "|V5=" & objDetalleVenta.codigoCliente & "|"

        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        Dim deuda As String
        deuda = lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|")



        objDetalleVenta.dsDatosDetalle.Tables(0).Clear()

        ' Actualiza Cat_Clientes_DetalleVenta
        ' Consulta regresa el detalle de una cuenta por cobrar

        Caja = "consulta118a" : Parametros = "V1=" & objDetalleVenta.idCuenta & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, 1, Parametros)

        ' Se inserta la consulta en el Grid ENTRADAS.
        If Not ObjRet.DS Is DBNull.Value Then
            If Not ObjRet.DS.Tables Is DBNull.Value Then
                If ObjRet.DS.Tables.Count > 0 Then
                    For i As Integer = 0 To ObjRet.DS.Tables(0).Rows.Count - 1
                        objDetalleVenta.dsDatosDetalle.Tables(0).ImportRow(ObjRet.DS.Tables(0).Rows(i))
                    Next
                    objDetalleVenta.dsDatosDetalle.Tables(0).AcceptChanges()
                    objDetalleVenta.DsViewDetalle = objDetalleVenta.dsDatosDetalle.Tables(0).DefaultView
                    'Else
                    '   FilaVacia()

                End If
            End If
        End If

        objDetalleVenta.objCatCliente.dsDatosCuentas.Tables(0).Clear()

        ' -------------------------------------------
        '| Obtienen los datos de su estado de cuenta.
        ' -------------------------------------------

        Caja = "Consulta117" : Parametros = "V1=" & codigoCliente & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, 1, Parametros)

        ' Se inserta la consulta en el Grid Cuentas.
        If Not ObjRet.DS Is DBNull.Value Then
            If Not ObjRet.DS.Tables Is DBNull.Value Then
                If ObjRet.DS.Tables.Count > 0 Then
                    For i As Integer = 0 To ObjRet.DS.Tables(0).Rows.Count - 1
                        objDetalleVenta.objCatCliente.dsDatosCuentas.Tables(0).ImportRow(ObjRet.DS.Tables(0).Rows(i))
                    Next
                    objDetalleVenta.objCatCliente.dsDatosCuentas.Tables(0).AcceptChanges()
                    objDetalleVenta.objCatCliente.DsViewCuentas = objDetalleVenta.objCatCliente.dsDatosCuentas.Tables(0).DefaultView
                    'Else
                    '   FilaVacia()

                End If
            End If
        End If

        Caja = "Consulta105" : Parametros = "V1=" & codigoCliente & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)

        If lConsulta.ObtenerValor("V17", ObjRet.sResultado, "|") = "" Then
            objDetalleVenta.objCatCliente.lblSaldoActual.Text = "$ 0.00"
        Else
            objDetalleVenta.objCatCliente.lblSaldoActual.Text = "$ " & lConsulta.ObtenerValor("V17", ObjRet.sResultado, "|")
        End If

        If deuda <> "" Then
            Me.Close()
            MessageBox.Show("El cliente había pagado $" & deuda & " por el artículo devuelto", " Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If objDetalleVenta.objCatCliente.dsDatosCuentas.Tables(0).Rows.Count = 0 Then
                objDetalleVenta.Close()
            End If
        End If

        If liquidar Then
            objDetalleVenta.Close()
        End If

        Me.Close()
    End Sub
#End Region

#Region "  Cambiar de control con Enter  "
    Private Sub numArt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numArt.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonAceptar.Focus()
        End If
    End Sub
#End Region
    
End Class