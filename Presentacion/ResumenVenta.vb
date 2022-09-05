Imports Datos
Public Class ResumenVenta
    Private Sub ResumenVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar()
        datos()
    End Sub





    'Agregar listaItem x Id
    Private Sub buscar()
        Dim consulta As Query_Venta = New Query_Venta

        grillVistaResimen.DataSource = consulta.BuscarResumen(checkid)
        grillVistaResimen.Columns("IDVenta").Visible = False


    End Sub

    Private Sub datos()
        Dim consulta As Query_Venta = New Query_Venta
        grilllclienteID.DataSource = consulta.IDCliente(checkCliente)

        lblID.Text = grilllclienteID.Item(0, 0).Value.ToString
        lblclie.Text = grilllclienteID.Item(1, 0).Value.ToString
        lblNVenta.Text = checkid.ToString
        lblVTotal.Text = Ventas.grillVentas.Item(3, Ventas.grillVentas.CurrentRow.Index).Value
    End Sub
    Private Function checkCliente() As Integer
        Dim i As Integer = CInt(Ventas.grillVentas.CurrentRow.Index)
        Dim idcheck As String = Ventas.grillVentas.Item(1, i).Value()

        Return CInt(idcheck)
    End Function


    Private Function checkid() As Integer
        Dim i As Integer = CInt(Ventas.grillVentas.CurrentRow.Index)
        Dim idcheck As String = Ventas.grillVentas.Item(0, i).Value()

        Return CInt(idcheck)
    End Function
End Class