Public Class OrderModel
    Private _seq As String
    Public Property seq() As String
        Get
            Return _seq
        End Get
        Set(ByVal value As String)
            _seq = value
        End Set
    End Property

    Private _datetime As String
    Public Property datetime() As String
        Get
            Return _datetime
        End Get
        Set(ByVal value As String)
            _datetime = value
        End Set
    End Property

    Private _orderDesc As String
    Public Property orderDesc() As String
        Get
            Return _orderDesc
        End Get
        Set(ByVal value As String)
            _orderDesc = value
        End Set
    End Property

    Private _price As Integer
    Public Property price() As Integer
        Get
            Return _price
        End Get
        Set(ByVal value As Integer)
            _price = value
        End Set
    End Property

    Private _number As Integer
    Public Property number() As Integer
        Get
            Return _number
        End Get
        Set(ByVal value As Integer)
            _number = value
        End Set
    End Property

    Private _address1 As String
    Public Property address1() As String
        Get
            Return _address1
        End Get
        Set(ByVal value As String)
            _address1 = value
        End Set
    End Property

    Private _address2 As String
    Public Property address2() As String
        Get
            Return _address2
        End Get
        Set(ByVal value As String)
            _address2 = value
        End Set
    End Property


    Private _orderDetailModel As OrderDetailModel
    Public Property orderDetailModel() As OrderDetailModel
        Get
            Return _orderDetailModel
        End Get
        Set(ByVal value As OrderDetailModel)
            _orderDetailModel = value
        End Set
    End Property

    Private _paid As Boolean
    Public Property paid() As Boolean
        Get
            Return _paid
        End Get
        Set(ByVal value As Boolean)
            _paid = value
        End Set
    End Property
End Class
