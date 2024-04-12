Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Module database
    Public serverstring As String = "Server=localhost; user id= vmi; password=meenu2002; database=vmi"
    Public strcon As MySqlConnection = New MySqlConnection(serverstring)
    Public cmd As MySqlCommand = New MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable
    Public result As String

    Public Sub create(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed to save data", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data has been inserted and saved", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub
    Public Sub updates(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed to save data", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data has been updated", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub
    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            ' Initialize the MySqlDataAdapter object
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            DTG.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            strcon.Close()
            If da IsNot Nothing Then
                da.Dispose()
            End If
        End Try
    End Sub



    Public Sub delete(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed to save data", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data has been deleted", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub
    Public Sub tranculate(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed to save data", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Table is clear", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub
End Module
