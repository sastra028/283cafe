Imports System.Collections.Generic
Imports System.Linq
Imports System.Security.Policy
Imports System.Windows.Forms

Public Class Form2

    Public orderModelList As List(Of OrderModel) = New List(Of OrderModel)
    Dim menuTypeHash As New Dictionary(Of String, Integer)()
    Public orderDate As String = ""

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "สรุปยอดขาย " + orderDate
        drawTableRow()
    End Sub
    Private Sub drawTableRow()
        DataGridView1.Rows.Clear()

        Dim sum As Integer = 0
        Dim paidRemaing As Integer = 0
        DataGridView1.Rows.Clear()
        Dim count As Integer = 0
        For Each item As OrderModel In orderModelList
            If item.orderDetailModel IsNot Nothing Then
                Dim menuType As String = item.orderDetailModel.menuType
                Dim orderType As String = item.orderDetailModel.orderType
                Dim special As String = item.orderDetailModel.special
                Dim typeTemp As String = menuType + " + " + orderType
                If special.Length > 0 Then
                    typeTemp += " + " + special
                End If
                add(menuTypeHash, typeTemp, item.number)
                If item.orderDetailModel.onTop.Length > 0 Then
                    add(menuTypeHash, item.orderDetailModel.onTop, item.number)
                End If
                If "ราดข้าว".Equals(orderType) Then
                    add(menuTypeHash, "ข้าว", item.number)
                Else
                    add(menuTypeHash, "กับข้าว", item.number)
                End If
                count = count + item.number
            End If
        Next
        add(menuTypeHash, "จำนวนที่ขาย", count)
        Dim hashTemp As List(Of KeyValuePair(Of String, Integer)) = menuTypeHash.ToList()
        Dim countTable As Integer = 1
        For Each kvp As KeyValuePair(Of String, Integer) In hashTemp
            addRow(DataGridView1, kvp.Key, kvp.Value, countTable)
            countTable = countTable + 1
        Next

    End Sub

    Private Sub add(hash As Dictionary(Of String, Integer), key As String, number As Integer)
        If hash.ContainsKey(key) Then
            updateHashMap(hash, key, number)
        Else
            hash.Add(key, number)
        End If
    End Sub

    Private Sub updateHashMap(hash As Dictionary(Of String, Integer), key As String, number As Integer)
        Dim numberExisting = getValueByKey(hash, key)
        hash.Remove(key)
        hash.Add(key, number + numberExisting)
    End Sub


    Function getValueByKey(hash As Dictionary(Of String, Integer), key As String)

        Dim hashTemp As List(Of KeyValuePair(Of String, Integer)) = hash.ToList()
        For Each kvp As KeyValuePair(Of String, Integer) In hashTemp
            If kvp.Key.Equals(key) Then
                Return kvp.Value
            End If
        Next
        Return 0
    End Function

    Function getHashValue(hash As Dictionary(Of String, Integer), key As String)
        Dim result As Integer = 0
        If hash.ContainsKey(key) Then
            result = hash(key)
        End If
        Return result
    End Function
    Private Sub addRow(dataGridView As DataGridView, menuType As String, number As Integer, countTable As Integer)
        dataGridView.Rows.Add(countTable, menuType, number)
    End Sub
End Class