Imports Entidad
Imports Datos
Public Class negocioProducto
    Dim consulta As Query_Producto = New Query_Producto


    'agregar datos  a Cliente
    Public Sub AgregarProducto(ByVal product As entidadProducto)
        consulta.Ingresar(product)

    End Sub


    'verifica los datos antes de ingresar
    Public Function verificar(ByVal producto As entidadProducto) As Boolean
        Dim resultado As Boolean = True
        If producto.Nombre = "" Then
            MsgBox("Nombre obligatorio")
            resultado = False
        ElseIf producto.Precio = "" Then
            MsgBox("Precio Obligatorio")
            resultado = False
        ElseIf producto.Categoria = "" Then
            resultado = False
            MsgBox("Categoria Obligatoria")
        Else
            resultado = True
        End If
        Return resultado
    End Function

    'extrae los datos de Cliente seleccionado por id

    Public Function BackModificar(ByVal a As Integer) As entidadProducto
        Dim producto As entidadProducto = New entidadProducto
        Dim tb As DataTable = consulta.PedirDatos(a)
        producto.Id = CInt(tb.Rows(0)(0))
        producto.Nombre = tb.Rows(0)(1)
        producto.Precio = tb.Rows(0)(2)
        producto.Categoria = tb.Rows(0)(3)
        Return producto
    End Function

    Public Sub EditarProducto(ByVal enti As entidadProducto)
        consulta.Modificar(enti)
    End Sub
    Public Sub elimnar(ByVal enti As Integer)

        consulta.Eliminar(enti)
    End Sub
    Public Function buscar(ByVal a As String) As DataTable
        Return consulta.Buscar(a)

    End Function
End Class
