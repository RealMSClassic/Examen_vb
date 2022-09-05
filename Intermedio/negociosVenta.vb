Imports Datos
Imports Entidad
Public Class negociosVenta
    Dim consulta As Query_Venta = New Query_Venta
    Public Function cargar_Clientes() As DataTable
        Return consulta.Mostrarclientes()
    End Function
    Public Function cargar_ventas() As DataTable
        Return consulta.MostrarVentas()
    End Function

    Public Sub registrar_Venta(ByVal a As entidadVenta, ByVal items As List(Of entidadVentaItem))
        Try
            consulta.Ingresar(a, items)
        Catch ex As Exception
            Throw
        End Try

    End Sub
    Public Function PedirIDVenta() As DataTable
        Return consulta.PedirIdVenta()
    End Function
    Public Function MostrarVentasFecha(ByVal a As String, ByVal b As String) As DataTable
        Return consulta.MostrarVentasFecha(a, b)
    End Function


    Public Sub ventaItem(ByVal da As entidadVentaItem)
        consulta.IngresarItemVenta(da)
    End Sub
    Public Function mostrarItemsBusqueda(ByVal a As String) As DataTable
        Return consulta.Buscar(a)
    End Function

End Class
