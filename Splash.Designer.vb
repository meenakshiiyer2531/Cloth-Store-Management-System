<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Splash
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        username = New RichTextBox()
        password = New RichTextBox()
        Button1 = New Button()
        Label1 = New Label()
        Timer1 = New Timer(components)
        Guna2CircleProgressBar1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Teal
        Label1.Font = New Font("Algerian", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(312, 417)
        Label1.Name = "Label1"
        Label1.Size = New Size(436, 71)
        Label1.TabIndex = 4
        Label1.Text = "MADE BY VMI"
        ' 
        ' Timer1
        ' 
        ' 
        ' Guna2CircleProgressBar1
        ' 
        Guna2CircleProgressBar1.FillColor = Color.FromArgb(CByte(200), CByte(213), CByte(218), CByte(223))
        Guna2CircleProgressBar1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2CircleProgressBar1.ForeColor = Color.Transparent
        Guna2CircleProgressBar1.Location = New Point(449, 210)
        Guna2CircleProgressBar1.Minimum = 0
        Guna2CircleProgressBar1.Name = "Guna2CircleProgressBar1"
        Guna2CircleProgressBar1.ProgressColor = Color.Gold
        Guna2CircleProgressBar1.ProgressColor2 = Color.PaleGoldenrod
        Guna2CircleProgressBar1.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleProgressBar1.Size = New Size(149, 149)
        Guna2CircleProgressBar1.TabIndex = 5
        Guna2CircleProgressBar1.Text = "Guna2CircleProgressBar1"
        ' 
        ' Splash
        ' 
        AutoScaleDimensions = New SizeF(25F, 43F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(980, 624)
        Controls.Add(Guna2CircleProgressBar1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(password)
        Controls.Add(username)
        DoubleBuffered = True
        Font = New Font("Century Schoolbook", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(11, 9, 11, 9)
        Name = "Splash"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents username As RichTextBox
    Friend WithEvents password As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2CircleProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
End Class
