Imports System.Drawing.Drawing2D
Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class employeedasboard
    Dim connectionString As String = "server=localhost;user id=root;password=your_password;database=your_database"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Do you want to discard the changes?", "Back", MessageBoxButtons.YesNo)
        Me.Hide()
        Dim login = New Login
        login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim customer = New customerE
        customer.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        Dim product = New productE
        product.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim employee = New employeeE
        employee.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            PrintDocument1.Print()
        Catch ex As Exception
            MessageBox.Show("Error occurred while printing: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            create("INSERT INTO `show` (showId,date,customerId1,productId1,employeeId1,quantity,price,payment) VALUES('" & TextBox8.Text & "','" & TextBox7.Text & "','" & TextBox9.Text & "','" & TextBox6.Text & "','" & TextBox5.Text & "','" & TextBox4.Text & "','" & TextBox2.Text & "','" & TextBox1.Text & "')")
            create("INSERT INTO sales(salesId,date,customerId,productId,employeeId,quantity,price,payment) VALUES('" & TextBox8.Text & "','" & TextBox7.Text & "','" & TextBox9.Text & "','" & TextBox6.Text & "','" & TextBox5.Text & "','" & TextBox4.Text & "','" & TextBox2.Text & "','" & TextBox1.Text & "')")
            TextBox8.Clear()
            TextBox7.Clear()
            TextBox9.Clear()
            TextBox6.Clear()
            TextBox5.Clear()
            TextBox4.Clear()
            TextBox2.Clear()
            TextBox1.Clear()
            reload("SELECT * FROM `show`", DataGridView1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub employeedasboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Hello, Welcome to the employee page, here you shall be able to do the billing. Thank you!!!!!")
        tranculate("TRUNCATE TABLE `show`")
        reload("SELECT * FROM `show`", DataGridView1)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Print store name and address
        Dim storeName As String = "Skylark Men's Wear"
        Dim storeAddress As String = "536, Arvind Vihar, Baghmugalia, Bhopal"
        Dim contentFont As New Font("Courier New", 20, FontStyle.Bold) ' Larger and bolder font for store name and address
        Dim totalAmountFont As New Font("Courier New", 12, FontStyle.Bold) ' Larger and bolder font for total amount

        Dim yPos As Single = 100 ' Start position for content
        Dim centerPos As Single = e.PageBounds.Width / 2 ' Center position for content

        ' Print store name
        Dim storeNameSize As SizeF = e.Graphics.MeasureString(storeName, contentFont)
        Dim storeNameX As Single = centerPos - storeNameSize.Width / 2
        e.Graphics.DrawString(storeName, contentFont, Brushes.Black, storeNameX, yPos)

        ' Print store address
        yPos += storeNameSize.Height + 5 ' Add some spacing
        Dim storeAddressSize As SizeF = e.Graphics.MeasureString(storeAddress, contentFont)
        Dim storeAddressX As Single = centerPos - storeAddressSize.Width / 2
        e.Graphics.DrawString(storeAddress, contentFont, Brushes.Black, storeAddressX, yPos)

        ' Draw a dotted line
        Dim lineY As Single = yPos + storeAddressSize.Height + 20 ' Position the line below the store address
        Dim dottedPen As New Pen(Color.Black)
        dottedPen.DashStyle = DashStyle.Dot
        e.Graphics.DrawLine(dottedPen, 20, lineY, e.PageBounds.Width - 20, lineY)

        ' Print billing info heading
        Dim billingInfoHeading As String = "Billing Information"
        Dim billingInfoFont As New Font("Courier New", 12, FontStyle.Bold)
        Dim billingInfoSize As SizeF = e.Graphics.MeasureString(billingInfoHeading, billingInfoFont)
        yPos = lineY + 30 ' Position the billing info heading below the dotted line
        Dim billingInfoX As Single = centerPos - billingInfoSize.Width / 2
        e.Graphics.DrawString(billingInfoHeading, billingInfoFont, Brushes.Black, billingInfoX, yPos)

        ' Print column titles
        Dim columnNames() As String = {"ID", "Date", "Customer ID", "Product ID", "Employee ID", "Quantity", "Price", "Payment"}
        Dim columnFont As New Font("Courier New", 10, FontStyle.Bold)
        Dim columnWidth As Single = e.PageBounds.Width / columnNames.Length
        yPos += billingInfoSize.Height + 10 ' Add some spacing
        Dim columnX As Single = 20 ' Start position for the first column
        For Each columnName As String In columnNames
            e.Graphics.DrawString(columnName, columnFont, Brushes.Black, columnX, yPos)
            columnX += columnWidth ' Move to the next column position
        Next

        ' Draw a dotted line
        Dim lineY2 As Single = yPos + 30 ' Position the line below the column titles
        e.Graphics.DrawLine(dottedPen, 20, lineY2, e.PageBounds.Width - 20, lineY2)

        ' Print sales data (from DataGridView1)
        Dim printFont As New Font("Courier New", 10) ' Using a typewriter font for data
        Dim rowHeight As Integer = printFont.Height + 5
        yPos = lineY2 + 10 ' Start position for data rows
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim columnX2 As Single = 20 ' Start position for the first column
                For Each cell As DataGridViewCell In row.Cells
                    e.Graphics.DrawString(cell.Value.ToString(), printFont, Brushes.Black, columnX2, yPos)
                    columnX2 += columnWidth ' Move to the next column position
                Next
                yPos += rowHeight ' Move to the next row position
            End If
        Next

        ' Draw a dotted line after content
        Dim lineY3 As Single = yPos + 10 ' Position the line below the content
        e.Graphics.DrawLine(dottedPen, 20, lineY3, e.PageBounds.Width - 20, lineY3)

        ' Calculate and print total amount
        Dim totalAmount As Double = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                totalAmount += CDbl(row.Cells("Price").Value) ' Assuming "Price" is the column containing the price
            End If
        Next
        Dim totalAmountString As String = "Total Amount: Rs." & totalAmount.ToString("0.00")
        Dim totalAmountSize As SizeF = e.Graphics.MeasureString(totalAmountString, totalAmountFont)
        Dim totalAmountX As Single = centerPos - totalAmountSize.Width / 2
        Dim totalAmountY As Single = yPos + 30 ' Position the total amount below the dotted line
        e.Graphics.DrawString(totalAmountString, totalAmountFont, Brushes.Black, totalAmountX, totalAmountY)
    End Sub
End Class
