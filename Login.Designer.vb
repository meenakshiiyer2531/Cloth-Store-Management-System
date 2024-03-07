<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        Button2 = New Button()
        txtPassword = New RichTextBox()
        txtUsername = New RichTextBox()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Gold
        Button2.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.Teal
        Button2.Location = New Point(615, 462)
        Button2.Name = "Button2"
        Button2.Size = New Size(209, 64)
        Button2.TabIndex = 8
        Button2.Text = "Login"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.Teal
        txtPassword.Font = New Font("MS Outlook", 18F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(697, 300)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(258, 53)
        txtPassword.TabIndex = 7
        txtPassword.Text = ""
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.Teal
        txtUsername.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.Location = New Point(697, 213)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(258, 53)
        txtUsername.TabIndex = 6
        txtUsername.Text = ""
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(967, 575)
        Controls.Add(Button2)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        DoubleBuffered = True
        Name = "Login"
        Text = "Splash"
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents txtPassword As RichTextBox
    Friend WithEvents txtUsername As RichTextBox
End Class
