Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class registration

    Public tin As String
    Public a As String
    Dim b As String
    ' Dim x As Single

    Public Function validateEmail(emailAddress) As Boolean
        ' Dim email As New Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        home.Show()
        Me.Hide()


    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTin.TextChanged
        tin = CStr(TextBoxTin.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connection As New SqlConnection("Server=ADMIN\SQLEXPRESS;Database =registration; Integrated Security = true")
        Dim command As New SqlCommand("insert into Registration(Name,Phone,Tin,EmailId,LoginId,Password) values(@name,@phone,@tin,@emailid,@userid,@password)", connection)

        a = CStr(TextBoxPassword.Text)
        b = CStr(TextBox4.Text)

        If TextBoxUserId.Text = "" Or TextBoxPassword.Text = "" Or TextBoxName.Text = "" Or TextBoxPhone.Text = "" Or TextBoxTin.Text = "" Or TextBoxEmail.Text = "" Then
            MsgBox("Invalid Input")
            Exit Sub
        End If
        If (a <> b) Then
            MsgBox("Password mismatch")
            Exit Sub
        End If
        If validateEmail(TextBoxEmail.Text) = False Then
            MsgBox("Email is not Valid")
            Exit Sub
        End If

        Try
            command.Parameters.Add("@userid", SqlDbType.VarChar).Value = TextBoxUserId.Text
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxPassword.Text
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = TextBoxName.Text
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = TextBoxPhone.Text
            command.Parameters.Add("@tin", SqlDbType.VarChar).Value = TextBoxTin.Text
            command.Parameters.Add("@emailid", SqlDbType.VarChar).Value = TextBoxEmail.Text
            connection.Open()


            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Registration Completed", "Done", MessageBoxButtons.OK)
                home.Show()
                Me.Hide()
            Else
                MessageBox.Show("Registration Unsuccessfull", "Done", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassword.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPhone.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class