<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        username = New RichTextBox()
        password = New RichTextBox()
        Button1 = New Button()
        RichTextBox1 = New RichTextBox()
        RichTextBox2 = New RichTextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' username
        ' 
        username.BackColor = Color.Teal
        username.Location = New Point(4486, 1115)
        username.Margin = New Padding(11, 9, 11, 9)
        username.Name = "username"
        username.Size = New Size(1479, 236)
        username.TabIndex = 0
        username.Text = ""
        ' 
        ' password
        ' 
        password.BackColor = Color.Teal
        password.Location = New Point(4486, 1617)
        password.Margin = New Padding(11, 9, 11, 9)
        password.Name = "password"
        password.Size = New Size(1479, 236)
        password.TabIndex = 1
        password.Text = ""
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gold
        Button1.Font = New Font("Calisto MT", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(4061, 2276)
        Button1.Margin = New Padding(11, 9, 11, 9)
        Button1.Name = "Button1"
        Button1.Size = New Size(950, 206)
        Button1.TabIndex = 2
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.Teal
        RichTextBox1.Location = New Point(701, 256)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(243, 53)
        RichTextBox1.TabIndex = 3
        RichTextBox1.Text = ""
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.BackColor = Color.Teal
        RichTextBox2.Location = New Point(701, 360)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(243, 53)
        RichTextBox2.TabIndex = 4
        RichTextBox2.Text = ""
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Gold
        Button2.ForeColor = Color.Teal
        Button2.Location = New Point(548, 494)
        Button2.Name = "Button2"
        Button2.Size = New Size(199, 64)
        Button2.TabIndex = 5
        Button2.Text = "Login"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(25F, 43F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(974, 625)
        Controls.Add(Button2)
        Controls.Add(RichTextBox2)
        Controls.Add(RichTextBox1)
        Controls.Add(Button1)
        Controls.Add(password)
        Controls.Add(username)
        Font = New Font("Century Schoolbook", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(11, 9, 11, 9)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents username As RichTextBox
    Friend WithEvents password As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Button2 As Button
End Class
