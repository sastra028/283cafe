Public Class MenuModel
    Private _seq As String
    Public Property seq() As String
        Get
            Return _seq
        End Get
        Set(ByVal value As String)
            _seq = value
        End Set
    End Property
    Private _name As String
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
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
End Class
