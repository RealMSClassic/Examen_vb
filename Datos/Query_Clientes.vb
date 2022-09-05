Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Imports System.Data.Sql
Imports System.Configuration.ConfigurationManager
Imports Entidad

Public Class Query_Clientes
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
        adaptador = New SqlDataAdapter("SELECT * FROM clientes ", cn)
        dt = New DataTable
        adaptador.Fill(dt)

        Return dt
        cerrar()

    End Function
    Public Function PedirDatos(ByVal a As Integer) As DataTable
        abrir()
        Dim Query As String = "SELECT ID,Cliente,Telefono,Correo FROM clientes WHERE ID LIKE '" & a & "%'"

        adaptador = New SqlDataAdapter(Query, cn)
        dt = New DataTable
        adaptador.Fill(dt)

        Return dt
    End Function
    Public Sub Ingresar(ByVal cliente As entidadClientes)
        abrir()

        Dim query As String = "  INSERT INTO clientes(Cliente,Telefono,Correo)VALUES ('" & cliente.Nombre.ToString & "', '" & cliente.Telefono.ToString & "', '" & cliente.Correo.ToString & "');"
        Dim adapte As New SqlCommand(query, cn)


        adapte.ExecuteNonQuery()
        MsgBox("Datos Ingresados")
        cerrar()
    End Sub
    Public Sub Modificar(ByVal enti As entidadClientes)
        abrir()
        MsgBox(enti.Nombre.ToString + " " + enti.Telefono.ToString + " " + enti.Correo.ToString)
        Dim Query As String = "UPDATE clientes SET Cliente='" & enti.Nombre & "', Telefono='" & enti.Telefono & "', Correo='" & enti.Correo & "' WHERE  ID = '" & enti.Id & "';
"
        Dim adapte As New SqlCommand(Query, cn)

        adapte.ExecuteNonQuery()
        cerrar()

    End Sub
    Public Sub Eliminar(ByVal enti As Integer)
        abrir()
        Dim Query As String = "DELETE FROM clientes WHERE  ID = '" & enti & "';"
        Dim Comando As New SqlCommand(Query, cn)
        Comando.ExecuteNonQuery()
        cerrar()
    End Sub
    Public Function Buscar(ByVal a As String, ByVal b As String) As DataTable
        abrir()
        Dim Query As String = "SELECT * FROM clientes WHERE " & b & " LIKE '" & a & "%'"
        adaptador = New SqlDataAdapter(Query, cn)
        dt = New DataTable
        adaptador.Fill(dt)

        Return dt
    End Function
End Class
