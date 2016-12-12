Imports System.Data.SqlClient
'Imports System.Text.RegularExpressions

Public Class updateuser
    Dim a As String

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub updateuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection("Server=ADMIN\SQLEXPRESS;Database =registration; Integrated Security = true")
        Dim command As New SqlCommand("select * from Registration where Password= @password", connection)
        connection.Open()
        Dim adp As New SqlDataAdapter(command)
        Dim table As New DataTable()
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = login.pass
        adp.Fill(table)
        If table.Rows.Count() >= 0 Then
            a = table.Rows(0)(2).ToString
        End If
        Label1.Text = a


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New SqlConnection("Server=ADMIN\SQLEXPRESS;Database =registration; Integrated Security = true")
        Dim command As New SqlCommand("Update Registration set Name = @name,Phone = @phone,EmailId = @emailid, Password = @password where Tin = @tin  ", connection)
        'update registrations set Name = @name,Phone = @phone,EmailId = @emailid, Password = @password"

        If TextBoxPassword.Text = "" Or TextBoxName.Text = "" Or TextBoxPhone.Text = "" Or TextBoxEmail.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Invalid Input")
            Exit Sub
        End If
        Try

            command.Parameters.Add("@tin", SqlDbType.VarChar).Value = registration.tin
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxPassword.Text
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = TextBoxName.Text
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = TextBoxPhone.Text
            command.Parameters.Add("@emailid", SqlDbType.VarChar).Value = TextBoxEmail.Text
            connection.Open()
            If command.ExecuteNonQuery() = 1 Then
                MsgBox("Details Updated")
                ' MsgBox(registration.tin)
                services.Show()
                Me.Hide()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        services.Show()
        Me.Hide()

    End Sub
End Class