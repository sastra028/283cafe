Public Class OrderDetailModel
    Private _menu As String
    Public Property menu() As String
        Get
            Return _menu
        End Get
        Set(ByVal value As String)
            _menu = value
        End Set
    End Property

    Private _menuPrice As Integer
    Public Property menuPrice() As Integer
        Get
            Return _menuPrice
        End Get
        Set(ByVal value As Integer)
            _menuPrice = value
        End Set
    End Property

    Private _menuType As String
    Public Property menuType() As String
        Get
            Return _menuType
        End Get
        Set(ByVal value As String)
            _menuType = value
        End Set
    End Property
    Private _menuTypePrice As Integer
    Public Property menuTypePrice() As Integer
        Get
            Return _menuTypePrice
        End Get
        Set(ByVal value As Integer)
            _menuTypePrice = value
        End Set
    End Property

    Private _orderType As String
    Public Property orderType() As String
        Get
            Return _orderType
        End Get
        Set(ByVal value As String)
            _orderType = value
        End Set
    End Property
    Private _orderTypePrice As Integer
    Public Property orderTypePrice() As Integer
        Get
            Return _orderTypePrice
        End Get
        Set(ByVal value As Integer)
            _orderTypePrice = value
        End Set
    End Property

    Private _onTop As String
    Public Property onTop() As String
        Get
            Return _onTop
        End Get
        Set(ByVal value As String)
            _onTop = value
        End Set
    End Property
    Private _onTopPrice As Integer
    Public Property onTopPrice() As Integer
        Get
            Return _onTopPrice
        End Get
        Set(ByVal value As Integer)
            _onTopPrice = value
        End Set
    End Property

    Private _special As String
    Public Property special() As String
        Get
            Return _special
        End Get
        Set(ByVal value As String)
            _special = value
        End Set
    End Property
    Private _specialPrice As Integer
    Public Property specialPrice() As Integer
        Get
            Return _specialPrice
        End Get
        Set(ByVal value As Integer)
            _specialPrice = value
        End Set
    End Property

End Class
