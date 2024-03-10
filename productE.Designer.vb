<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(productE))
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        TextBox9 = New TextBox()
        TextBox8 = New TextBox()
        TextBox7 = New TextBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(496, 101)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(509, 481)
        DataGridView1.TabIndex = 28
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Teal
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Location = New Point(57, 44)
        Button1.Name = "Button1"
        Button1.Size = New Size(51, 39)
        Button1.TabIndex = 27
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Gold
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(218, 561)
        Button4.Name = "Button4"
        Button4.Size = New Size(89, 33)
        Button4.TabIndex = 26
        Button4.Text = "DELETE"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Gold
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(137, 523)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 33)
        Button3.TabIndex = 25
        Button3.Text = "EDIT"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Gold
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(312, 523)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 33)
        Button2.TabIndex = 24
        Button2.Text = "ADD"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox9
        ' 
        TextBox9.BackColor = Color.Teal
        TextBox9.Location = New Point(304, 211)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(176, 23)
        TextBox9.TabIndex = 23
        ' 
        ' TextBox8
        ' 
        TextBox8.BackColor = Color.Teal
        TextBox8.Location = New Point(304, 127)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(176, 23)
        TextBox8.TabIndex = 22
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = Color.Teal
        TextBox7.Location = New Point(304, 168)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(176, 23)
        TextBox7.TabIndex = 21
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.Teal
        TextBox6.Location = New Point(304, 250)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(176, 23)
        TextBox6.TabIndex = 20
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.Teal
        TextBox5.Location = New Point(304, 293)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(176, 23)
        TextBox5.TabIndex = 19
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.Teal
        TextBox4.Location = New Point(304, 335)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(176, 23)
        TextBox4.TabIndex = 18
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.Teal
        TextBox3.Location = New Point(304, 383)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(176, 23)
        TextBox3.TabIndex = 17
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Teal
        TextBox2.Location = New Point(304, 427)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(176, 23)
        TextBox2.TabIndex = 16
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Teal
        TextBox1.Location = New Point(304, 466)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(176, 23)
        TextBox1.TabIndex = 15
        ' 
        ' productE
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1028, 639)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        DoubleBuffered = True
        Name = "productE"
        Text = "productE"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
