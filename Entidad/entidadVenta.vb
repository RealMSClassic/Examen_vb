Public Class entidadVenta
    Private _id As Integer
    Private _idCliente As Integer
    Private _fecha As DateTime
    Private _total As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, idCliente As Integer, fecha As DateTime, total As String)
        Me.Id = id
        Me.IdCliente = idCliente
        Me.Fecha = fecha
        Me.Total = total
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property IdCliente As Integer
        Get
            Return _idCliente
        End Get
        Set(value As Integer)
            _idCliente = value
        End Set
    End Property

    Public Property Fecha As DateTime
        Get
            Return _fecha
        End Get
        Set(value As DateTime)
            _fecha = value
        End Set
    End Property

    Public Property Total As String
        Get
            Return _total
        End Get
        Set(value As String)
            _total = value
        End Set
    End Property
End Class
Public Class entidadVentaItem
    Private _id As Integer
    Private _idVenta As Integer
    Private _idProducto As Integer
    Private _precioUnidad As Double
    Private _cantidad As Double
    Private _total As Double

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, idVenta As Integer, idProducto As Integer, precioUnidad As Double, cantidad As Double, total As Double)
        _id = id
        _idVenta = idVenta
        _idProducto = idProducto
        _precioUnidad = precioUnidad
        _cantidad = cantidad
        _total = total
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property IdVenta As Integer
        Get
            Return _idVenta
        End Get
        Set(value As Integer)
            _idVenta = value
        End Set
    End Property

    Public Property IdProducto As Integer
        Get
            Return _idProducto
        End Get
        Set(value As Integer)
            _idProducto = value
        End Set
    End Property

    Public Property PrecioUnidad As Double
        Get
            Return _precioUnidad
        End Get
        Set(value As Double)
            _precioUnidad = value
        End Set
    End Property

    Public Property Cantidad As Double
        Get
            Return _cantidad
        End Get
        Set(value As Double)
            _cantidad = value
        End Set
    End Property

    Public Property Total As Double
        Get
            Return _total
        End Get
        Set(value As Double)
            _total = value
        End Set
    End Property
End Class
