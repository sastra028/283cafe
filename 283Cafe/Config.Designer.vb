<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Config
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Menu1 = New System.Windows.Forms.TextBox()
        Me.MenuPrice1 = New System.Windows.Forms.TextBox()
        Me.AddMenu1 = New System.Windows.Forms.Button()
        Me.DataGridMenu1 = New System.Windows.Forms.DataGridView()
        Me.A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.B = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Menu1
        '
        Me.Menu1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Menu1.Location = New System.Drawing.Point(12, 12)
        Me.Menu1.Multiline = True
        Me.Menu1.Name = "Menu1"
        Me.Menu1.Size = New System.Drawing.Size(154, 43)
        Me.Menu1.TabIndex = 0
        '
        'MenuPrice1
        '
        Me.MenuPrice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.MenuPrice1.Location = New System.Drawing.Point(172, 12)
        Me.MenuPrice1.Multiline = True
        Me.MenuPrice1.Name = "MenuPrice1"
        Me.MenuPrice1.Size = New System.Drawing.Size(66, 43)
        Me.MenuPrice1.TabIndex = 1
        '
        'AddMenu1
        '
        Me.AddMenu1.Location = New System.Drawing.Point(244, 14)
        Me.AddMenu1.Name = "AddMenu1"
        Me.AddMenu1.Size = New System.Drawing.Size(37, 43)
        Me.AddMenu1.TabIndex = 2
        Me.AddMenu1.Text = "+"
        Me.AddMenu1.UseVisualStyleBackColor = True
        '
        'DataGridMenu1
        '
        Me.DataGridMenu1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMenu1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.A, Me.B, Me.C})
        Me.DataGridMenu1.Location = New System.Drawing.Point(12, 63)
        Me.DataGridMenu1.Name = "DataGridMenu1"
        Me.DataGridMenu1.RowHeadersWidth = 62
        Me.DataGridMenu1.RowTemplate.Height = 28
        Me.DataGridMenu1.Size = New System.Drawing.Size(269, 150)
        Me.DataGridMenu1.TabIndex = 3
        '
        'A
        '
        Me.A.HeaderText = "A"
        Me.A.MinimumWidth = 8
        Me.A.Name = "A"
        Me.A.Width = 150
        '
        'B
        '
        Me.B.HeaderText = "B"
        Me.B.MinimumWidth = 8
        Me.B.Name = "B"
        Me.B.Width = 150
        '
        'C
        '
        Me.C.HeaderText = "C"
        Me.C.MinimumWidth = 8
        Me.C.Name = "C"
        Me.C.Width = 150
        '
        'Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 610)
        Me.Controls.Add(Me.DataGridMenu1)
        Me.Controls.Add(Me.AddMenu1)
        Me.Controls.Add(Me.MenuPrice1)
        Me.Controls.Add(Me.Menu1)
        Me.Name = "Config"
        Me.Text = "ตั้งค่า"
        CType(Me.DataGridMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menu1 As TextBox
    Friend WithEvents MenuPrice1 As TextBox
    Friend WithEvents AddMenu1 As Button
    Friend WithEvents DataGridMenu1 As DataGridView
    Friend WithEvents A As DataGridViewTextBoxColumn
    Friend WithEvents B As DataGridViewTextBoxColumn
    Friend WithEvents C As DataGridViewTextBoxColumn
End Class
