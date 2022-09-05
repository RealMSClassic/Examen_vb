Public Class entidadClientes
    Private _id As Integer
    Private _nombre As String
    Private _telefono As String
    Private _correo As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, nombre As String, telefono As String, correo As String)
        _id = id
        _nombre = nombre
        _telefono = telefono
        _correo = correo
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

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property
End Class
