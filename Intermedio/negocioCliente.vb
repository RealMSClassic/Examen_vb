Imports Entidad
Imports Datos
Public Class negocioCliente
    Dim consulta As Query_Clientes = New Query_Clientes


    'agregar datos  a Cliente
    Public Sub AgregarCliente(ByVal cliente As entidadClientes)
        consulta.Ingresar(cliente)

    End Sub


    'verifica los datos antes de ingresar
    Public Function verificar(ByVal cliente As entidadClientes) As Boolean
        Dim resultado As Boolean = True
        If cliente.Nombre = "" Then
            MsgBox("Nombre obligatorio")
            resultado = False
        ElseIf cliente.Telefono = "" Then
            MsgBox("Telefono Obligatorio")
            resultado = False
        ElseIf cliente.Correo = "" Then
            resultado = False
            MsgBox("Correo Oblgiatorio")
        Else
            resultado = True
        End If
        Return resultado
    End Function

    'extrae los datos de Cliente seleccionado por id

    Public Function BackModificar(ByVal a As Integer) As entidadClientes
        Dim cliente As entidadClientes = New entidadClientes
        Dim tb As DataTable = consulta.PedirDatos(a)
        cliente.Id = CInt(tb.Rows(0)(0))
        cliente.Nombre = tb.Rows(0)(1)
        cliente.Telefono = tb.Rows(0)(2)
        cliente.Correo = tb.Rows(0)(3)
        Return cliente
    End Function

    Public Sub EditarCliente(ByVal enti As entidadClientes)
        consulta.Modificar(enti)
    End Sub
    Public Sub elimnar(ByVal enti As Integer)

        consulta.Eliminar(enti)
    End Sub
    'Public Function buscar(ByVal a As String) As DataTable
    ' Return consulta.Buscar(a)

    'End Function
End Class
