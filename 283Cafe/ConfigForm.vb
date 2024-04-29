Imports System.Collections.Generic

Public Class ConfigForm


    Dim menu1List As List(Of MenuModel) = New List(Of MenuModel)
    Dim menu2List As List(Of MenuModel) = New List(Of MenuModel)
    Dim menu3List As List(Of MenuModel) = New List(Of MenuModel)
    Dim menu4List As List(Of MenuModel) = New List(Of MenuModel)
    Private Sub AddMenu1_Click(sender As Object, e As EventArgs) Handles AddMenu1.Click
        addMenu_1()
    End Sub

    Private Sub addMenu_1()
        Dim name = Menu1.Text

        Dim price As Integer = getMenyPrice1()

        If name.Length = 0 Or price <= 0 Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ")
            Exit Sub
        End If
        If isDuplicateName(menu1List, name) Then
            MsgBox("รายการซ้ำ")
            Exit Sub
        End If
        Dim menuModel = New MenuModel
        menuModel.seq = menu1List.Count + 1
        menuModel.name = name
        menuModel.price = price
        menu1List.Add(menuModel)
        drawTableRow()
        Menu1.Text = ""
        MenuPrice1.Text = ""
    End Sub

    Function getMenyPrice1()
        Dim result As Integer = 0
        Try
            result = MenuPrice1.Text
        Catch ex As Exception

        End Try
        Return result
    End Function

    Function isDuplicateName(model As List(Of MenuModel), name As String)
        For Each item As MenuModel In model
            If name.Equals(item.name) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub drawTableRow()
        DataGridMenu1.Rows.Clear()

        Dim sum As Integer = 0
        Dim paidRemaing As Integer = 0
        Dim paidByTransfer As Integer = 0
        Dim paidByCash As Integer = 0

        For Each item As MenuModel In menu1List
            addRow(DataGridMenu1, item)
        Next
    End Sub
    Private Sub addRow(dataGridView As DataGridView, item As MenuModel)
        dataGridView.Rows.Add(
            item.seq, item.name, item.price)

    End Sub

    Private Sub MenuPrice1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MenuPrice1.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub MenuPrice1_KeyDown(sender As Object, e As KeyEventArgs) Handles MenuPrice1.KeyDown
        If e.KeyCode = Keys.Enter Then
            addMenu_1()
        End If
    End Sub

    Private Sub Menu1_KeyDown(sender As Object, e As KeyEventArgs) Handles Menu1.KeyDown
        If e.KeyCode = Keys.Enter Then
            addMenu_1()
        End If
    End Sub

    Private Sub ConfigForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class