Imports System.Collections.Generic

Public Class OrderMain

    Private _orderModel As List(Of OrderModel)
    Public Property orderModel() As List(Of OrderModel)
        Get
            Return _orderModel
        End Get
        Set(ByVal value As List(Of OrderModel))
            _orderModel = value
        End Set
    End Property
End Class
