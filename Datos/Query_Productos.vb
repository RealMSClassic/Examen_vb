Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Imports System.Data.Sql
Imports System.Configuration.ConfigurationManager
Imports Entidad
Public Class Query_Producto
    Private cn As SqlConnection
    Private adaptador As SqlDataAdapter
    Private _llave As String = ConfigurationManager.ConnectionStrings("cn").ToString
    Private dt As DataTable

    Public Sub abrir()
        cn = New SqlConnection(_llave)
        cn.Open()

    End Sub
    Public Sub cerrar()
        cn = New SqlConnection(_llave)
        cn.Close()

    End Sub

    Public Function Mostrar() As DataTable
        abrir()
        adaptador = New SqlDataAdapter("SELECT * FROM productos ", cn)
        dt = New DataTable
        adaptador.Fill(dt)

        Return dt
        cerrar()

    End Function
    Public Function PedirDatos(ByVal a As Integer) As DataTable
        abrir()
        Dim Query As String = "SELECT ID,Nombre,Precio,Categoria FROM productos WHERE ID LIKE '" & a & "%'"

        adaptador = New SqlDataAdapter(Query, cn)
        dt = New DataTable
        adaptador.Fill(dt)

        Return dt
    End Function
    Public Sub Ingresar(ByVal cliente As entidadProducto)
        abrir()
        'Dim precioComa As String = cliente.Precio

        Dim query As String = "  INSERT INTO productos(Nombre,Precio,Categoria)VALUES ('" & cliente.Nombre.ToString & "', '" & cliente.Precio & "', '" & cliente.Categoria.ToString & "');" '" & CDec(cliente.Precio) & "
        Dim adapte As New SqlCommand(query, cn)


        adapte.ExecuteNonQuery()
        MsgBox("Datos Ingresados")
        cerrar()
    End Sub


    Public Sub Modificar(ByVal enti As entidadProducto)
        abrir()
        ' MsgBox(enti.Nombre.ToString + " " + enti.Precio.ToString + " " + enti.Categoria.ToString)
        Dim Query As String = "UPDATE productos SET Nombre='" & enti.Nombre & "', Precio='" & enti.Precio & "', Categoria='" & enti.Categoria & "' WHERE  ID = '" & enti.Id & "';
"
        Dim adapte As New SqlCommand(Query, cn)

        adapte.ExecuteNonQuery()
        cerrar()

    End Sub
    Public Sub Eliminar(ByVal enti As Integer)
        abrir()
        Dim Query As String = "DELETE FROM productos WHERE  ID = '" & enti & "';"
        Dim Comando As New SqlCommand(Query, cn)
        Comando.ExecuteNonQuery()
        cerrar()
    End Sub
    Public Function Buscar(ByVal a As String) As DataTable
        abrir()
        Dim Query As String = "SELECT * FROM productos WHERE Nombre LIKE '" & a & "%'"
        adaptador = New SqlDataAdapter(Query, cn)
        dt = New DataTable
        adaptador.Fill(dt)

        Return dt
    End Function
    Public Function BuscarXID(ByVal a As Integer) As DataTable
        abrir()
        Dim Query As String = "SELECT * FROM productos WHERE ID LIKE '" & a & "%'"
        adaptador = New SqlDataAdapter(Query, cn)
        dt = New DataTable
        adaptador.Fill(dt)

        Return dt
    End Function
    Public Function BuscarFil(ByVal a As String, ByVal b As String) As DataTable
        abrir()
        Dim Query As String = "SELECT * FROM productos WHERE " & b & " LIKE '" & a & "%'"
        adaptador = New SqlDataAdapter(Query, cn)
        dt = New DataTable
        adaptador.Fill(dt)

        Return dt
    End Function
End Class
