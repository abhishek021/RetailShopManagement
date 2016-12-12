Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class login
    Public x As String
    Public pass As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connection As New SqlConnection("Server=ADMIN\SQLEXPRESS;Database =registration; Integrated Security = true")
        connection.Open()
        Dim command As New SqlCommand("select * from Registration where LoginId = @login and Password = @pass", connection)
        Dim adp As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Try
            command.Parameters.Add("@login", SqlDbType.VarChar).Value = TextBox1.Text
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = TextBox2.Text
            adp.Fill(table)
            If table.Rows.Count() <= 0 Then
                MsgBox("Invalid credentials")
                TextBox1.Text = ""
                TextBox2.Text = ""
            Else
                x = CStr(TextBox1.Text)
                pass = TextBox2.Text
                TextBox2.Text = ""
                services.Show()
                Me.Hide()


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        registration.Show()
        Me.Hide()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        home.Show()
        Me.Hide()


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class