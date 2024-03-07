Public Class SupplierA
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim dashboard = New Adminb
        dashboard.Show()
    End Sub
End Class