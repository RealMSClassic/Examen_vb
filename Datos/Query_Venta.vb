Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Imports System.Data.Sql
Imports System.Configuration.ConfigurationManager
Imports Entidad
Imports System.Data.SqlClient.SqlTransaction
Public Class Query_Venta

    Private tran As SqlTransaction
    Private cn As SqlConnection
    Private adaptador As SqlDataAdapter
    Private _llave As String = ConfigurationManager.ConnectionStrings("cn").ToString
    Private dt As DataTable

    Public Sub abrir()
        Try
            cn = New SqlConnection(_llave)
            cn.Open()
        Catch ex As Exception

        End Try


    End Sub
    Public Sub cerrar()
        Try
            cn = New SqlConnection(_llave)
            cn.Close()
        Catch ex As Exception

        End Try


    End Sub
    Public Function PedirIdVenta() As DataTable
        Try
            abrir()
            adaptador = New SqlDataAdapter("select top(1) * from ventas ORDER BY ID desc", cn)
            dt = New DataTable
            adaptador.Fill(dt)


        Catch ex As Exception

        End Try
        Return dt
        cerrar()

    End Function
    Public Function Mostrar() As DataTable
        Try
            abrir()
            adaptador = New SqlDataAdapter("SELECT * FROM productos ", cn)
            dt = New DataTable
            adaptador.Fill(dt)

        Catch ex As Exception

        End Try
        Return dt
        cerrar()


    End Function
    Public Function MostrarVentas() As DataTable
        Try
            abrir()
            adaptador = New SqlDataAdapter("SELECT * FROM ventas ", cn)
            dt = New DataTable
            adaptador.Fill(dt)

        Catch ex As Exception

        End Try

        Return dt
        cerrar()


    End Function

    Public Function Mostrarclientes() As DataTable
        Try
            abrir()
            adaptador = New SqlDataAdapter("SELECT ID,Cliente FROM clientes  ", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            cerrar()
        Catch ex As Exception

        End Try
        Return dt

    End Function


    Public Sub Ingresar(ByVal venta As entidadVenta, ByVal items As List(Of entidadVentaItem))
        Try
            cn.Close() 'cierro la conexion porque en algun lado queda abierta. Fijarse esto

            cn.Open()
            'seteo la transaccion
            tran = cn.BeginTransaction()

            'al final de la query pongo SELECT SCOPE_IDENTITY() para obtener el id de la factura agregada
            Dim query As String = "  INSERT INTO ventas (IDCliente,Fecha,Total)VALUES ('" & venta.IdCliente & "', '" & venta.Fecha & "', '" & venta.Total & "'); SELECT SCOPE_IDENTITY()"
            Dim adapte As New SqlCommand(query, cn, tran)
            'executescalar: obtiene el valor de la primera columna de la primera fila (el id de la venta en este caso)
            Dim id As Integer = adapte.ExecuteScalar()

            'si el id es 0 es porque algo salio mal. se hace rollback
            If id = 0 Then
                tran.Rollback()
                Return
            End If

            'ya con el id de venta, agregamos los items.
            For Each i As entidadVentaItem In items
                query = "INSERT INTO ventasitems (IDVenta,IDProducto,PrecioUnitario,Cantidad,PrecioTotal)VALUES ('" & id & "', '" & i.IdProducto & "', '" & CDbl(i.PrecioUnidad) & "', '" & CDbl(i.Cantidad) & "', '" & CDbl(i.Total) & "')"
                adapte.CommandText = query
                adapte.ExecuteNonQuery()
            Next

            'hacemos commit de la transaccion
            tran.Commit()
        Catch ex As Exception
            'si algo sale mal, mensaje y rollback de la transaccion.
            MsgBox("En ingresar " + ex.Message)
            tran.Rollback()
        Finally
            cn.Close()
        End Try
    End Sub
    Public Sub IngresarItemVenta(ByVal a As entidadVentaItem)
        Try

            Dim query As String = "  INSERT INTO ventasitems (IDVenta,IDProducto,PrecioUnitario,Cantidad,PrecioTotal)VALUES ('" & a.IdVenta & "', '" & a.IdProducto & "', '" & CDbl(a.PrecioUnidad) & "', '" & CDbl(a.Cantidad) & "', '" & CDbl(a.Total) & "')"
            Dim adapte As New SqlCommand(query, cn, tran)
            adapte.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("en ingresar Items" + ex.Message)
        End Try

    End Sub
    Public Function Buscar(ByVal a As String) As DataTable
        Try
            abrir()
            Dim Query As String = "SELECT * FROM productos WHERE Nombre LIKE '" & a & "%'"
            adaptador = New SqlDataAdapter(Query, cn)
            dt = New DataTable
            adaptador.Fill(dt)


        Catch ex As Exception

        End Try
        Return dt
    End Function
    Public Function BuscarFil(ByVal a As String, ByVal b As String) As DataTable
        Try
            abrir()
            Dim Query As String = "SELECT * FROM ventas WHERE " & b & " LIKE '" & a & "%'"
            adaptador = New SqlDataAdapter(Query, cn)
            dt = New DataTable
            adaptador.Fill(dt)



        Catch ex As Exception

        End Try
        Return dt
    End Function
    Public Function IDCliente(ByVal a As String) As DataTable
        Try
            abrir()
            Dim Query As String = "SELECT ID,Cliente,Telefono,Correo FROM clientes WHERE ID LIKE '" & a & "%'"
            adaptador = New SqlDataAdapter(Query, cn)
            dt = New DataTable
            adaptador.Fill(dt)



        Catch ex As Exception

        End Try
        Return dt
    End Function
    Public Function BuscarResumen(ByVal a As Integer) As DataTable
        Try
            abrir()
            Dim Query As String = "SELECT vi.IDVenta,p.Nombre,vi.PrecioUnitario,vi.Cantidad,vi.PrecioTotal FROM
ventasitems vi inner join productos p on vi.IDProducto= p.ID WHERE IDVenta LIKE '" & a & "%'"
            adaptador = New SqlDataAdapter(Query, cn)
            dt = New DataTable
            adaptador.Fill(dt)


        Catch ex As Exception

        End Try
        Return dt
    End Function
    Public Function BuscarResID(ByVal a As Integer) As DataTable
        Try
            abrir()
            Dim Query As String = "SELECT * FROM productos  WHERE ID LIKE '" & a & "%'"
            adaptador = New SqlDataAdapter(Query, cn)
            dt = New DataTable
            adaptador.Fill(dt)


        Catch ex As Exception

        End Try
        Return dt
    End Function

    Public Sub EliminarListaVentas(ByVal enti As Integer)

        Try
            abrir()
            Dim Query As String = "DELETE FROM ventas WHERE  ID = '" & enti & "';"
            Dim Comando As New SqlCommand(Query, cn)
            Comando.ExecuteNonQuery()
        Catch
        End Try
        cerrar()
    End Sub
    Public Sub beginTransaccion()

        Try
            abrir()
            tran = cn.BeginTransaction
            ' Dim query As String = "begin tran"
            '  Dim adapte As New SqlCommand(query, cn)
            '  adapte.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub rollback()

        Try
            tran.Rollback()


            cerrar()
        Catch ex As Exception

        End Try


    End Sub
    Public Sub commit()
        Try

            tran.Commit()
            cerrar()
        Catch ex As Exception

        End Try

    End Sub

End Class
