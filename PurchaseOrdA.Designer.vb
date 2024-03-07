<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrdA
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(PurchaseOrdA))
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        TextBox6 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.Teal
        TextBox5.Location = New Point(234, 108)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(137, 23)
        TextBox5.TabIndex = 16
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.Teal
        TextBox4.Location = New Point(234, 263)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(137, 23)
        TextBox4.TabIndex = 15
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.Teal
        TextBox3.Location = New Point(234, 224)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(137, 23)
        TextBox3.TabIndex = 14
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Teal
        TextBox2.Location = New Point(234, 186)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(137, 23)
        TextBox2.TabIndex = 13
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Teal
        TextBox1.Location = New Point(234, 147)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(137, 23)
        TextBox1.TabIndex = 12
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Gold
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(165, 392)
        Button4.Name = "Button4"
        Button4.Size = New Size(89, 33)
        Button4.TabIndex = 11
        Button4.Text = "DELETE"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Gold
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(84, 354)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 33)
        Button3.TabIndex = 10
        Button3.Text = "EDIT"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Gold
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(259, 354)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 33)
        Button2.TabIndex = 9
        Button2.Text = "ADD"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.Teal
        TextBox6.Location = New Point(234, 301)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(137, 23)
        TextBox6.TabIndex = 17
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Teal
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Location = New Point(61, 29)
        Button1.Name = "Button1"
        Button1.Size = New Size(51, 39)
        Button1.TabIndex = 18
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PurchaseOrdA
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        DoubleBuffered = True
        Name = "PurchaseOrdA"
        Text = "PurchaseOrdA"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button1 As Button
End Class
