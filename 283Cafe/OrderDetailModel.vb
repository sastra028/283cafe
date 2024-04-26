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

    Private _menuPrice As String
    Public Property menuPrice() As String
        Get
            Return _menuPrice
        End Get
        Set(ByVal value As String)
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
    Private _menuTypePrice As String
    Public Property menuTypePrice() As String
        Get
            Return _menuTypePrice
        End Get
        Set(ByVal value As String)
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
    Private _orderTypePrice As String
    Public Property orderTypePrice() As String
        Get
            Return _orderTypePrice
        End Get
        Set(ByVal value As String)
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
    Private _onTopPrice As String
    Public Property onTopPrice() As String
        Get
            Return _onTopPrice
        End Get
        Set(ByVal value As String)
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
    Private _specialPrice As String
    Public Property specialPrice() As String
        Get
            Return _specialPrice
        End Get
        Set(ByVal value As String)
            _specialPrice = value
        End Set
    End Property

End Class
