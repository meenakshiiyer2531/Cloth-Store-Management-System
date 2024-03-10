Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class employeeE
    Private Sub employeeE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload("SELECT * FROM employee ", DataGridView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim employee = New employeedasboard
        employee.Show()
    End Sub
End Class