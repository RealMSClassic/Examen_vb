Public Class entidadProducto
    Private _id As Integer
    Private _nombre As String
    Private _precio As String
    Private _categoria As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, nombre As String, precio As String, categoria As String)
        _id = id
        _nombre = nombre
        _precio = precio
        _categoria = categoria
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Precio As String
        Get
            Return _precio
        End Get
        Set(value As String)
            _precio = value
        End Set
    End Property

    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property
End Class
