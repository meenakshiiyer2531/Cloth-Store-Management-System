Public Class productE
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim dashboard = New employeedasboard
        dashboard.Show()
    End Sub

    Private Sub ProductE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload("SELECT * FROM products ", DataGridView1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            create("INSERT INTO products(productId,name,description,price,quantity,brand,category,size,color)VALUES('" & TextBox8.Text & "','" & TextBox7.Text & "','" & TextBox9.Text & "','" & TextBox6.Text & "','" & TextBox5.Text & "','" & TextBox4.Text & "','" & TextBox3.Text & "','" & TextBox2.Text & "','" & TextBox1.Text & "')")
            TextBox8.Clear()
            TextBox7.Clear()
            TextBox9.Clear()
            TextBox6.Clear()
            TextBox5.Clear()
            TextBox4.Clear()
            TextBox3.Clear()
            TextBox2.Clear()
            TextBox1.Clear()
            reload("SELECT * FROM products ", DataGridView1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            updates("UPDATE products SET productId='" & TextBox8.Text & "',name='" & TextBox7.Text & "',description='" & TextBox9.Text & "',price='" & TextBox6.Text & "',quantity='" & TextBox5.Text & "',brand='" & TextBox4.Text & "',category='" & TextBox3.Text & "',size='" & TextBox2.Text & "',color='" & TextBox1.Text & "'")
            TextBox8.Clear()
            TextBox7.Clear()
            TextBox9.Clear()
            TextBox6.Clear()
            TextBox5.Clear()
            TextBox4.Clear()
            TextBox3.Clear()
            TextBox2.Clear()
            TextBox1.Clear()
            reload("SELECT * FROM products ", DataGridView1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            delete("DELETE FROM products WHERE productId='" & TextBox8.Text & "'")
            TextBox8.Clear()
            TextBox7.Clear()
            TextBox9.Clear()
            TextBox6.Clear()
            TextBox5.Clear()
            TextBox4.Clear()
            TextBox3.Clear()
            TextBox2.Clear()
            TextBox1.Clear()
            reload("SELECT * FROM products ", DataGridView1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox8.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox7.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox9.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox6.Text = DataGridView1.CurrentRow.Cells(3).Value
        TextBox5.Text = DataGridView1.CurrentRow.Cells(4).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells(5).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(6).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(7).Value
        TextBox1.Text = DataGridView1.CurrentRow.Cells(8).Value
    End Sub
End Class