﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Splash


    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub


    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2CircleProgressBar1.Increment(1)
        If Guna2CircleProgressBar1.Value = 100 Then
            Me.Hide()
            Dim log = New Login
            log.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Guna2CircleProgressBar1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2CircleProgressBar1.ValueChanged

    End Sub
End Class
