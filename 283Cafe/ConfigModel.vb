Imports System.Collections.Generic

Public Class ConfigModel

    Private _menu1List As List(Of MenuModel)
    Public Property menu1List() As List(Of MenuModel)
        Get
            Return _menu1List
        End Get
        Set(ByVal value As List(Of MenuModel))
            _menu1List = value
        End Set
    End Property
    Private _menu2List As List(Of MenuModel)
    Public Property menu2List() As List(Of MenuModel)
        Get
            Return _menu2List
        End Get
        Set(ByVal value As List(Of MenuModel))
            _menu2List = value
        End Set
    End Property
    Private _menu3List As List(Of MenuModel)
    Public Property menu3List() As List(Of MenuModel)
        Get
            Return _menu3List
        End Get
        Set(ByVal value As List(Of MenuModel))
            _menu3List = value
        End Set
    End Property

    Private _menu4List As List(Of MenuModel)
    Public Property menu4List() As List(Of MenuModel)
        Get
            Return _menu4List
        End Get
        Set(ByVal value As List(Of MenuModel))
            _menu4List = value
        End Set
    End Property
End Class
