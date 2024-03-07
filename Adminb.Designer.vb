<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adminb
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Adminb))
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gold
        Button1.Location = New Point(77, 220)
        Button1.Name = "Button1"
        Button1.Size = New Size(163, 33)
        Button1.TabIndex = 0
        Button1.Text = "CUSTOMER"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Gold
        Button2.Location = New Point(401, 220)
        Button2.Name = "Button2"
        Button2.Size = New Size(160, 33)
        Button2.TabIndex = 1
        Button2.Text = "PRODUCT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Gold
        Button3.Location = New Point(727, 220)
        Button3.Name = "Button3"
        Button3.Size = New Size(142, 33)
        Button3.TabIndex = 2
        Button3.Text = "SALES"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Gold
        Button4.Location = New Point(77, 549)
        Button4.Name = "Button4"
        Button4.Size = New Size(163, 30)
        Button4.TabIndex = 3
        Button4.Text = "SUPPLIER"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Gold
        Button5.Location = New Point(401, 549)
        Button5.Name = "Button5"
        Button5.Size = New Size(160, 30)
        Button5.TabIndex = 4
        Button5.Text = "EMPLOYEE"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Gold
        Button6.Location = New Point(727, 549)
        Button6.Name = "Button6"
        Button6.Size = New Size(142, 30)
        Button6.TabIndex = 5
        Button6.Text = "PURCHASE ORDER"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Adminb
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(975, 651)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        DoubleBuffered = True
        Name = "Adminb"
        Text = "Adminb"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
