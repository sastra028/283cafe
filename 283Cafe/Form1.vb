Imports System.Collections.Generic
Imports System.Windows.Forms

Public Class Form1

    Dim orderModelList As New List(Of OrderModel)
    'Dim orderModel As OrderModel
    Dim _orderName As String = ""
    Dim _totalPrice As Integer = 0
    Dim _menuPrice As Integer = 0
    Dim _menuTypePrice As Integer = 0
    Dim _orderTypePrice As Integer = 0
    Dim _onTopPrice As Integer = 0
    Dim _specialPrice As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles กระเพรา.Click
        TextBox1.Text = "กระเพรา"
        calPrice()
    End Sub

    Private Sub คะน้า_Click(sender As Object, e As EventArgs) Handles คะน้า.Click
        TextBox1.Text = "คะน้า"
        calPrice()
    End Sub

    Private Sub ผัดพริกแกง_Click(sender As Object, e As EventArgs) Handles ผัดพริกแกง.Click
        TextBox1.Text = "ผัดพริกแกง"
        calPrice()
    End Sub

    Private Sub ข้าวกระเทียม_Click(sender As Object, e As EventArgs) Handles ข้าวกระเทียม.Click
        TextBox1.Text = "ข้าวกระเทียม"
        calPrice()
    End Sub

    Private Sub ข้าวผัด_Click(sender As Object, e As EventArgs) Handles ข้าวผัด.Click
        TextBox1.Text = "ข้าวผัด"
        calPrice()
    End Sub

    Private Sub ข้าวไข่ข้น_Click(sender As Object, e As EventArgs) Handles ข้าวไข่ข้น.Click
        TextBox1.Text = "ข้าวไข่ข้น"
        calPrice()
    End Sub

    Private Sub ข้าวไข่เจียว_Click(sender As Object, e As EventArgs) Handles ข้าวไข่เจียว.Click
        TextBox1.Text = "ข้าวไข่เจียว"
        calPrice()
    End Sub

    Private Sub หมูสับ_Click(sender As Object, e As EventArgs) Handles หมูสับ.Click
        TextBox2.Text = "หมูสับ"
        calPrice()
    End Sub

    Private Sub หมูชิ้น_Click(sender As Object, e As EventArgs) Handles หมูชิ้น.Click
        TextBox2.Text = "หมูชิ้น"
        calPrice()
    End Sub

    Private Sub ไก่_Click(sender As Object, e As EventArgs) Handles ไก่.Click
        TextBox2.Text = "ไก่"
        calPrice()
    End Sub

    Private Sub เนื้อสับ_Click(sender As Object, e As EventArgs) Handles เนื้อสับ.Click
        TextBox2.Text = "เนื้อสับ"
        calPrice()
    End Sub

    Private Sub กุ้ง_Click(sender As Object, e As EventArgs) Handles กุ้ง.Click
        TextBox2.Text = "กุ้ง"
        calPrice()
    End Sub

    Private Sub หมึก_Click(sender As Object, e As EventArgs) Handles หมึก.Click
        TextBox2.Text = "หมึก"
        calPrice()
    End Sub

    Private Sub ไข่เยี่ยวม้า_Click(sender As Object, e As EventArgs) Handles ไข่เยี่ยวม้า.Click
        TextBox2.Text = "ไข่เยี่ยวม้า"
        calPrice()
    End Sub

    Private Sub หมูกรอบ_Click(sender As Object, e As EventArgs) Handles หมูกรอบ.Click
        TextBox2.Text = "หมูกรอบ"
        calPrice()
    End Sub

    Private Sub ทะเล_Click(sender As Object, e As EventArgs) Handles ทะเล.Click
        TextBox2.Text = "ทะเล"
        calPrice()
    End Sub

    Private Sub กุนเชียง_Click(sender As Object, e As EventArgs) Handles กุนเชียง.Click
        TextBox2.Text = "กุนเชียง"
        calPrice()
    End Sub

    Private Sub ราดข้าว_Click(sender As Object, e As EventArgs) Handles ราดข้าว.Click
        TextBox3.Text = "ราดข้าว"
        calPrice()
    End Sub

    Private Sub กับข้าว_Click(sender As Object, e As EventArgs) Handles กับข้าว.Click
        TextBox3.Text = "กับข้าว"
        calPrice()
    End Sub

    Private Sub ไข่ดาว_Click(sender As Object, e As EventArgs) Handles ไข่ดาว.Click
        TextBox4.Text = "ไข่ดาว"
        calPrice()
    End Sub

    Private Sub ไข่เจียว_Click(sender As Object, e As EventArgs) Handles ไข่เจียว.Click
        TextBox4.Text = "ไข่เจียว"
        calPrice()
    End Sub

    Private Sub พิเศษ_Click(sender As Object, e As EventArgs) Handles พิเศษ.Click
        TextBox5.Text = "พิเศษ"
        calPrice()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedText = 1
        address1.SelectedItem = 1
    End Sub

    Private Sub calPrice()
        Dim menu = TextBox1.Text
        Dim type = TextBox2.Text
        Dim menuPrice As Integer = 50
        Dim menuTypePrice As Integer = getSubPrice()
        Dim orderTypePrice As Integer = getOrderTypePrice()
        Dim onTopPrice As Integer = getOnTopPrice()
        Dim specialPrice As Integer = getSpecialPrice()
        Dim orderName = TextBox1.Text + TextBox2.Text + " + " + TextBox4.Text + " + " + TextBox5.Text + " (" + TextBox3.Text + ") "
        If "กระเพรา".Equals(menu) Then
            menuPrice = 50
        ElseIf "คะน้า".Equals(menu) Then
            menuPrice = 50
        ElseIf "กระเทียม".Equals(menu) Then
            menuPrice = 50
        ElseIf "ผัดพริกแกง".Equals(menu) Then
            menuPrice = 50
        ElseIf "ข้าวผัด".Equals(menu) Then
            menuPrice = 50
        ElseIf "ข้าวไข่ข้น".Equals(menu) Then
            menuPrice = 50
        ElseIf "ข้าวไข่เจียว".Equals(menu) Then
            menuPrice = 50
        End If
        Dim totalPrice As Integer = 0
        If TextBox1.TextLength > 0 And TextBox2.TextLength > 0 Then
            totalPrice = menuPrice + menuTypePrice + orderTypePrice + onTopPrice + specialPrice
            price.Text = totalPrice.ToString("####")
            _orderName = orderName
            _totalPrice = totalPrice
            _menuPrice = menuPrice
            _menuTypePrice = menuTypePrice
            _orderTypePrice = orderTypePrice
            _onTopPrice = onTopPrice
            _specialPrice = specialPrice

            'Dim orderModel = New OrderModel()
            'orderModel.seq = 1
            'orderModel.orderDesc = orderName
            'orderModel.number = ComboBox1.Text.ToString()
            'orderModel.price = totalPrice
            'orderModel.address1 = address1.Text
            'orderModel.address2 = address2.Text
            'Dim orderDetailModel = New OrderDetailModel()
            'orderDetailModel.menu = TextBox1.Text
            'orderDetailModel.menuPrice = menuPrice
            'orderDetailModel.menuType = TextBox2.Text
            'orderDetailModel.menuTypePrice = menuTypePrice
            'orderDetailModel.orderType = TextBox3.Text
            'orderDetailModel.orderTypePrice = orderTypePrice
            'orderDetailModel.onTop = TextBox4.Text
            'orderDetailModel.onTopPrice = onTopPrice
            'orderDetailModel.special = TextBox5.Text
            'orderDetailModel.specialPrice = specialPrice
            'orderModel.orderDetailModel = orderDetailModel
        Else
            totalPrice = 0
            price.Text = totalPrice.ToString("####")

        End If
    End Sub

    Function getSubPrice()
        Dim type = TextBox2.Text
        Dim subPrice = 0
        If "หมูสับ".Equals(type) Then
            subPrice = 10
        ElseIf "หมูชิ้น".Equals(type) Then
            subPrice = 10
        ElseIf "ไก่".Equals(type) Then
            subPrice = 10
        ElseIf "เนื้อสับ".Equals(type) Then
            subPrice = 10
        ElseIf "กุ้ง".Equals(type) Then
            subPrice = 20
        ElseIf "หมึก".Equals(type) Then
            subPrice = 20
        ElseIf "ไข่เยี่ยวม้า".Equals(type) Then
            subPrice = 20
        ElseIf "หมูกรอบ".Equals(type) Then
            subPrice = 20
        ElseIf "ทะเล".Equals(type) Then
            subPrice = 20
        ElseIf "กุนเชียง".Equals(type) Then
            subPrice = 10
        End If
        Return subPrice
    End Function

    Function getOrderTypePrice()
        Dim type = TextBox3.Text
        Dim orderTypePrice = 0
        If "ราดข้าว".Equals(type) Then
            orderTypePrice = 0
        ElseIf "กับข้าว".Equals(type) Then
            orderTypePrice = 20
        End If
        Return orderTypePrice
    End Function

    Function getOnTopPrice()
        Dim type = TextBox4.Text
        Dim onTopPrice = 0
        If "ไข่ดาว".Equals(type) Then
            onTopPrice = 10
        ElseIf "ไขเจียว".Equals(type) Then
            onTopPrice = 10
        End If
        Return onTopPrice
    End Function

    Function getSpecialPrice()
        Dim type = TextBox5.Text
        Dim onTopPrice = 0
        If "พิเศษ".Equals(type) Then
            onTopPrice = 10
        End If
        Return onTopPrice
    End Function

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Dim orderModel = New OrderModel()
        orderModel.seq = 1
        orderModel.datetime = getCurrentTime("dd/MM/yyyy HHmm")
        orderModel.orderDesc = _orderName
        orderModel.number = ComboBox1.Text.ToString()
        orderModel.price = _totalPrice
        orderModel.address1 = address1.Text
        orderModel.address2 = address2.Text
        Dim orderDetailModel = New OrderDetailModel()
        orderDetailModel.menu = TextBox1.Text
        orderDetailModel.menuPrice = _menuPrice
        orderDetailModel.menuType = TextBox2.Text
        orderDetailModel.menuTypePrice = _menuTypePrice
        orderDetailModel.orderType = TextBox3.Text
        orderDetailModel.orderTypePrice = _orderTypePrice
        orderDetailModel.onTop = TextBox4.Text
        orderDetailModel.onTopPrice = _onTopPrice
        orderDetailModel.special = TextBox5.Text
        orderDetailModel.specialPrice = _specialPrice
        orderModel.orderDetailModel = orderDetailModel
        orderModelList.Add(orderModel)
        clear()
        drawTableRow()
    End Sub

    Function getCurrentTime(format As String)
        Dim time As DateTime = DateTime.Now
        If format.Equals("") Then
            format = "ddMMyyyy-HHmmss"
        End If
        Return time.ToString(format, System.Globalization.DateTimeFormatInfo.InvariantInfo)
    End Function
    Private Sub drawTableRow()
        DataGridView1.Rows.Clear()

        For Each item As OrderModel In orderModelList
            addRow(DataGridView1, item)
        Next

    End Sub
    Private Sub addRow(dataGridView As DataGridView, item As OrderModel)
        dataGridView.Rows.Add(
            item.seq, item.datetime, item.orderDesc, item.number, item.price, item.address1 + item.address2)

    End Sub

    Private Sub clear()
        _orderName = ""
        _totalPrice = 0
        _menuPrice = 0
        _menuTypePrice = 0
        _orderTypePrice = 0
        _onTopPrice = 0
        _specialPrice = 0
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        price.Text = ""
        ComboBox1.SelectedText = 1
        address1.Text = ""
        address2.Text = ""
    End Sub
End Class