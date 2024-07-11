<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employeedasboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(employeedasboard))
        Button1 = New Button()
        Button4 = New Button()
        TextBox9 = New TextBox()
        TextBox8 = New TextBox()
        TextBox7 = New TextBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        Button5 = New Button()
        DataGridView1 = New DataGridView()
        Button6 = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        Label1 = New Label()
        Button7 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Teal
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Location = New Point(87, 30)
        Button1.Name = "Button1"
        Button1.Size = New Size(51, 39)
        Button1.TabIndex = 35
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Gold
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(42, 700)
        Button4.Name = "Button4"
        Button4.Size = New Size(269, 33)
        Button4.TabIndex = 34
        Button4.Text = "BILL SAVE & MESSAGE"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' TextBox9
        ' 
        TextBox9.BackColor = Color.Teal
        TextBox9.Location = New Point(443, 299)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(270, 23)
        TextBox9.TabIndex = 33
        ' 
        ' TextBox8
        ' 
        TextBox8.BackColor = Color.Teal
        TextBox8.Location = New Point(443, 175)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(270, 23)
        TextBox8.TabIndex = 32
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = Color.Teal
        TextBox7.Location = New Point(443, 232)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(270, 23)
        TextBox7.TabIndex = 31
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.Teal
        TextBox6.Location = New Point(443, 363)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(270, 23)
        TextBox6.TabIndex = 30
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.Teal
        TextBox5.Location = New Point(443, 419)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(270, 23)
        TextBox5.TabIndex = 29
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.Teal
        TextBox4.Location = New Point(443, 489)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(270, 23)
        TextBox4.TabIndex = 28
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Teal
        TextBox2.Location = New Point(443, 552)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(270, 23)
        TextBox2.TabIndex = 27
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Teal
        TextBox1.Location = New Point(443, 621)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(270, 23)
        TextBox1.TabIndex = 26
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Gold
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(721, 299)
        Button2.Name = "Button2"
        Button2.Size = New Size(89, 33)
        Button2.TabIndex = 36
        Button2.Text = "ADD"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Gold
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(721, 353)
        Button3.Name = "Button3"
        Button3.Size = New Size(89, 33)
        Button3.TabIndex = 37
        Button3.Text = "ADD"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Gold
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(721, 411)
        Button5.Name = "Button5"
        Button5.Size = New Size(89, 33)
        Button5.TabIndex = 38
        Button5.Text = "VIEW"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(824, 119)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(701, 564)
        DataGridView1.TabIndex = 39
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Gold
        Button6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.Location = New Point(648, 700)
        Button6.Name = "Button6"
        Button6.Size = New Size(174, 33)
        Button6.TabIndex = 40
        Button6.Text = "ADD DATA"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Teal
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(355, 616)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 25)
        Label1.TabIndex = 41
        Label1.Text = "(MODE)"
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.SeaGreen
        Button7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.ForeColor = SystemColors.ButtonHighlight
        Button7.Location = New Point(397, 700)
        Button7.Name = "Button7"
        Button7.Size = New Size(174, 33)
        Button7.TabIndex = 42
        Button7.Text = "WHATSAPP"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' employeedasboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1587, 761)
        Controls.Add(Button7)
        Controls.Add(Label1)
        Controls.Add(Button6)
        Controls.Add(DataGridView1)
        Controls.Add(Button5)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Button4)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        DoubleBuffered = True
        Name = "employeedasboard"
        Text = "employeedasboard"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label1 As Label
    Friend WithEvents Button7 As Button
End Class
