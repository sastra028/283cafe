<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AddMenu1 = New System.Windows.Forms.Button()
        Me.MenuPrice1 = New System.Windows.Forms.TextBox()
        Me.Menu1 = New System.Windows.Forms.TextBox()
        Me.DataGridMenu1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddMenu1
        '
        Me.AddMenu1.Location = New System.Drawing.Point(244, 14)
        Me.AddMenu1.Name = "AddMenu1"
        Me.AddMenu1.Size = New System.Drawing.Size(37, 43)
        Me.AddMenu1.TabIndex = 6
        Me.AddMenu1.Text = "+"
        Me.AddMenu1.UseVisualStyleBackColor = True
        '
        'MenuPrice1
        '
        Me.MenuPrice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.MenuPrice1.Location = New System.Drawing.Point(172, 12)
        Me.MenuPrice1.Multiline = True
        Me.MenuPrice1.Name = "MenuPrice1"
        Me.MenuPrice1.Size = New System.Drawing.Size(66, 43)
        Me.MenuPrice1.TabIndex = 5
        '
        'Menu1
        '
        Me.Menu1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Menu1.Location = New System.Drawing.Point(12, 12)
        Me.Menu1.Multiline = True
        Me.Menu1.Name = "Menu1"
        Me.Menu1.Size = New System.Drawing.Size(154, 43)
        Me.Menu1.TabIndex = 4
        '
        'DataGridMenu1
        '
        Me.DataGridMenu1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMenu1.Location = New System.Drawing.Point(12, 63)
        Me.DataGridMenu1.Name = "DataGridMenu1"
        Me.DataGridMenu1.RowHeadersWidth = 62
        Me.DataGridMenu1.RowTemplate.Height = 28
        Me.DataGridMenu1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridMenu1.TabIndex = 7
        '
        'ConfigForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 583)
        Me.Controls.Add(Me.DataGridMenu1)
        Me.Controls.Add(Me.AddMenu1)
        Me.Controls.Add(Me.MenuPrice1)
        Me.Controls.Add(Me.Menu1)
        Me.Name = "ConfigForm"
        Me.Text = "ConfigForm"
        CType(Me.DataGridMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddMenu1 As Button
    Friend WithEvents MenuPrice1 As TextBox
    Friend WithEvents Menu1 As TextBox
    Friend WithEvents DataGridMenu1 As DataGridView
End Class
