﻿Public Class CustomerA
    Private Sub CustomerA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim dashboard = New Adminb
        dashboard.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    End Sub
End Class