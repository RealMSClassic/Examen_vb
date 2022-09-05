Imports Intermedio
Imports Entidad
Imports Datos
Public Class Registrar_Ventas
    Dim consulta As negociosVenta = New negociosVenta
    Private Sub Registrar_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        cargarListaClientes()
        totalTotal()
        Agregar_Venta.Enabled = False
    End Sub


    Private Sub cargarListaClientes()
        cbxClientes.DataSource = consulta.cargar_Clientes
        cbxClientes.DisplayMember = "Cliente"
        cbxClientes.ValueMember = "ID"
    End Sub


    Private Sub listar()
        For a As Integer = 0 To Agregar_Venta.grillListaVenta.Rows.Count - 1
            Dim nombre2 As String = Agregar_Venta.grillListaVenta.Item(1, a).Value
            If Not nombre2 = "" Then
                Dim id As Integer = Agregar_Venta.grillListaVenta.Item(0, a).Value.ToString
                Dim nombre As String = Agregar_Venta.grillListaVenta.Item(1, a).Value.ToString
                Dim precio As Decimal = Agregar_Venta.grillListaVenta.Item(2, a).Value.ToString
                Dim cantidad As String = Agregar_Venta.grillListaVenta.Item(3, a).Value.ToString
                Dim PrecioTotal As Decimal = CDec(Agregar_Venta.grillListaVenta.Item(2, a).Value * CDec(Agregar_Venta.grillListaVenta.Item(3, a).Value.ToString))

                listarFactura(id, nombre, precio, cantidad, PrecioTotal)
            End If
        Next
    End Sub

    Private Sub listarFactura(ByVal id As Integer, ByVal nombre As String, ByVal precio As Decimal, ByVal cantidad As String, ByVal precioTotal As Decimal)
        grillFacturaFinal.Rows.Add(id, nombre, precio, " x ", cantidad, " = ", precioTotal)
    End Sub

    Public Sub totalTotal()
        grillTotal.Rows.Add("", "TOTAL ", "", "", "", "", total_Ventas.ToString)
    End Sub
    Private Function total_Ventas() As Decimal
        Dim total As Decimal = 0
        For a As Integer = 0 To grillFacturaFinal.Rows.Count - 1
            Dim dato As String = grillFacturaFinal.Item(1, a).Value
            If Not dato = "" Then
                Dim PrecioTotal As Decimal = CDec(grillFacturaFinal.Item(6, a).Value)
                total = total + PrecioTotal
            End If
        Next
        Return total
    End Function

    Private Sub btnFinalizarCompra_Click(sender As Object, e As EventArgs) Handles btnFinalizarCompra.Click
        If lblID.Text = "" Then
        Else
            Try
                'armo una lista con los items.
                Dim items As List(Of entidadVentaItem) = getListOfItems()

                If items.Count = 0 Then
                    'no hay items 
                    Return
                End If

                consulta.registrar_Venta(NuevaVenta, items)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Ventas.cargargrilla()
            Me.Close()
        End If

    End Sub

    Private Sub VentaItems(ByVal a As Integer)
        Dim ItemVenta As entidadVentaItem = New entidadVentaItem
        Try
            ItemVenta.IdVenta = IDVentaR()
            ItemVenta.IdProducto = CInt(grillFacturaFinal.Item(0, a).Value)
            ItemVenta.PrecioUnidad = CDbl(grillFacturaFinal.Item(2, a).Value)
            ItemVenta.Cantidad = CDbl(grillFacturaFinal.Item(4, a).Value)
            ItemVenta.Total = CDbl(grillFacturaFinal.Item(6, a).Value)

            consulta.ventaItem(ItemVenta)
        Catch ex As Exception
            MsgBox("Venta Items" + ex.Message)
        End Try


    End Sub

    Private Function getListOfItems() As List(Of entidadVentaItem)
        Dim listItems As New List(Of entidadVentaItem)

        For Each row As DataGridViewRow In Agregar_Venta.grillListaVenta.Rows
            Dim itemVenta As New entidadVentaItem
            itemVenta.IdProducto = CInt(row.Cells(0).Value)
            itemVenta.PrecioUnidad = CDbl(row.Cells(2).Value)
            itemVenta.Cantidad = CDbl(row.Cells(3).Value)
            itemVenta.Total = CDbl(row.Cells(4).Value)

            'para evitar que agregue el total como item.
            If itemVenta.IdProducto <> 0 Then
                listItems.Add(itemVenta)
            End If

        Next

        Return listItems
    End Function

    Private Function IDVentaR() As Integer 'Pide El Id de la Ultima Venta cargada
        grillID.DataSource = consulta.PedirIDVenta
        Dim id As Integer = CInt(grillID.Item(0, 0).Value)
        Return id
    End Function



    Private Function NuevaVenta() As entidadVenta
        Dim dat = DateTime.Now
        Dim NueVenta As entidadVenta = New entidadVenta

        NueVenta.IdCliente = CInt(lblID.Text)

        NueVenta.Fecha = Format(dat, "yyyy,MM,dd  HH:mm ")
        NueVenta.Total = grillTotal.Item(6, 0).Value
        Return NueVenta
    End Function

    Private Sub Registrar_Ventas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Agregar_Venta.Enabled = True
        Agregar_Venta.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClientesBusqueda.Show()
    End Sub

End Class