Public Class Login



    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text


        ' For simplicity, let's assume the username is "admin" and password is "password"
        If username = "admin" AndAlso password = "password" Then
            ' If the credentials are correct, open the main form or dashboard
            Me.Hide()
            Dim mainForm = New Adminb
            mainForm.Show()

            MsgBox("Welcome to admin dashboard")
        Else
            ' If the credentials are incorrect, show an error message
            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtUsername.Focus()
        End If
    End Sub


End Class


