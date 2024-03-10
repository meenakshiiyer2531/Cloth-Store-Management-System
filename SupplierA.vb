Public Class SupplierA
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim dashboard = New Adminb
        dashboard.Show()
    End Sub

    Private Sub SupplierA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload("SELECT * FROM supplier ", DataGridView1)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox5.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells(4).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            create("INSERT INTO supplier(supplierId,name,address,contactperson,email)VALUES('" & TextBox5.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')")

            TextBox5.Clear()
            TextBox4.Clear()
            TextBox3.Clear()
            TextBox2.Clear()
            TextBox1.Clear()
            reload("SELECT * FROM supplier ", DataGridView1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        delete("DELETE FROM supplier WHERE supplierId='" & TextBox5.Text & "'")
        TextBox5.Clear()
        TextBox4.Clear()
        TextBox3.Clear()
        TextBox2.Clear()
        TextBox1.Clear()
        reload("SELECT * FROM supplier ", DataGridView1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        updates("UPDATE supplier SET supplierId='" & TextBox5.Text & "',name='" & TextBox1.Text & "',address='" & TextBox2.Text & "',contactperson='" & TextBox3.Text & "',email='" & TextBox4.Text & "'")
        TextBox5.Clear()
        TextBox4.Clear()
        TextBox3.Clear()
        TextBox2.Clear()
        TextBox1.Clear()
        reload("SELECT * FROM supplier ", DataGridView1)
    End Sub
End Class