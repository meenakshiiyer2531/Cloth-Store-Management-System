Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SalesA
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim dashboard = New Adminb
        dashboard.Show()
    End Sub

    Private Sub SalesA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload("SELECT * FROM sales ", DataGridView1)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox8.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox7.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox9.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox6.Text = DataGridView1.CurrentRow.Cells(3).Value
        TextBox5.Text = DataGridView1.CurrentRow.Cells(4).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells(5).Value

        TextBox2.Text = DataGridView1.CurrentRow.Cells(6).Value
        TextBox1.Text = DataGridView1.CurrentRow.Cells(7).Value
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            delete("DELETE FROM sales WHERE salesId='" & TextBox8.Text & "'")
            TextBox8.Clear()
            TextBox7.Clear()
            TextBox9.Clear()
            TextBox6.Clear()
            TextBox5.Clear()
            TextBox4.Clear()

            TextBox2.Clear()
            TextBox1.Clear()
            reload("SELECT * FROM sales ", DataGridView1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            updates("UPDATE sales SET salesId='" & TextBox8.Text & "',date='" & TextBox7.Text & "',customerId='" & TextBox9.Text & "',productId='" & TextBox6.Text & "',employeeId='" & TextBox5.Text & "',quantity='" & TextBox4.Text & "',price='" & TextBox2.Text & "',payment='" & TextBox1.Text & "'")
            TextBox8.Clear()
            TextBox7.Clear()
            TextBox9.Clear()
            TextBox6.Clear()
            TextBox5.Clear()
            TextBox4.Clear()

            TextBox2.Clear()
            TextBox1.Clear()
            reload("SELECT * FROM sales ", DataGridView1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            create("INSERT INTO sales(salesId,date,customerId,productId,employeeId,quantity,price,payment)VALUES('" & TextBox8.Text & "','" & TextBox7.Text & "','" & TextBox9.Text & "','" & TextBox6.Text & "','" & TextBox5.Text & "','" & TextBox4.Text & "','" & TextBox2.Text & "','" & TextBox1.Text & "')")
            TextBox8.Clear()
            TextBox7.Clear()
            TextBox9.Clear()
            TextBox6.Clear()
            TextBox5.Clear()
            TextBox4.Clear()

            TextBox2.Clear()
            TextBox1.Clear()
            reload("SELECT * FROM sales ", DataGridView1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class