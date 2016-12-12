Imports System.Data.SqlClient

Public Class feedback
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        home.Show()
        Me.Hide()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connection As New SqlConnection("Server=ADMIN\SQLEXPRESS;Database =registration; Integrated Security = true")
        Dim command As New SqlCommand("insert into Feedback_01(feedback,LoginId) values(@feed, @login)", connection)
        Dim comand As New SqlCommand("select * from Registration where LoginId = @login", connection)
        Dim adp As New SqlDataAdapter(comand)
        Dim table As New DataTable()
        connection.Open()
        'command.ExecuteNonQuery()
        'comand.ExecuteNonQuery()
        Try

            command.Parameters.Add("@login", SqlDbType.VarChar).Value = TextBox2.Text
            command.Parameters.Add("@feed", SqlDbType.VarChar).Value = TextBox1.Text
            comand.Parameters.Add("@login", SqlDbType.VarChar).Value = TextBox2.Text

            adp.Fill(table)
            If table.Rows.Count() <= 0 Then
                MsgBox("Invalid User_Id")
                TextBox1.Text = ""
                Exit Sub
            End If
            If TextBox1.Text = "" Then
                MsgBox("Invalid Input")
                Exit Sub

            End If
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Thankyou for your feedback", "Done", MessageBoxButtons.OK)
                home.Show()
                Me.Hide()
            Else
                MessageBox.Show("Error", "Done", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
                End Try
    End Sub

    Private Sub feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class