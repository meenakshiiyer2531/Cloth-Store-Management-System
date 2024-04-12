Imports MySql.Data.MySqlClient

Public Class Login

    ' Connection string for MySQL database
    Private connectionString As String = "Server=localhost;user id=vmi;password=meenu2002;database=vmi;"

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = Guna2TextBox3.Text
        Dim password As String = Guna2TextBox4.Text
        Guna2TextBox2.Clear()

        ' Fetch employee credentials from the database
        Dim employeeCredentials As Dictionary(Of String, String) = GetEmployeeCredentialsFromDatabase()

        If employeeCredentials.ContainsKey(username) AndAlso employeeCredentials(username) = password Then
            ' If the credentials are correct, open the main form or dashboard for employees
            Me.Hide()
            Dim mainForm As New employeedasboard
            mainForm.Show()
            MsgBox("Welcome to the employee dashboard")

        ElseIf username = "admin" AndAlso password = "password" Then
            ' If the credentials are for admin
            Me.Hide()
            Dim mainForm As New Adminb
            mainForm.Show()
            MsgBox("Welcome to the admin dashboard")

        Else
            ' If the credentials are incorrect, show an error message
            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Guna2TextBox4.Text = ""
            Guna2TextBox3.Text = ""
            Guna2TextBox3.Focus()
        End If
    End Sub

    Private Function GetEmployeeCredentialsFromDatabase() As Dictionary(Of String, String)
        Dim employeeCredentials As New Dictionary(Of String, String)()

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT username, password FROM employee"
                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Add username-password pair to dictionary
                            employeeCredentials.Add(reader("username").ToString(), reader("password").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Handle database errors
            MessageBox.Show("Error fetching employee credentials: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return employeeCredentials
    End Function

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' You can perform any initialization here if needed
    End Sub

End Class
