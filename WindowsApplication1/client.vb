Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class client

    Public Function validateEmail(emailAddress) As Boolean
        ' Dim email As New Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        services.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim connection As New SqlConnection("Server=ADMIN\SQLEXPRESS;Database =registration; Integrated Security = true")
        Dim command As New SqlCommand("insert into Addclient(Fname,Lname,Phone,Sex,Email,Age) values(@fname,@lname,@phone,@sex,@emailid,@age)", connection)

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox5.Text = "" Or TextBox3.Text = "" Or TextBox2.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Invalid Input")
            Exit Sub
        End If
        Try
            If validateEmail(TextBox6.Text) = True Then
                command.Parameters.Add("@fname", SqlDbType.VarChar).Value = TextBox1.Text
                command.Parameters.Add("@lname", SqlDbType.VarChar).Value = TextBox2.Text
                command.Parameters.Add("@phone", SqlDbType.VarChar).Value = TextBox5.Text
                command.Parameters.Add("@sex", SqlDbType.Char).Value = TextBox3.Text
                command.Parameters.Add("@emailid", SqlDbType.VarChar).Value = TextBox6.Text
                command.Parameters.Add("@age", SqlDbType.Char).Value = TextBox4.Text
                connection.Open()
                If command.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Client added Successfully", "Done", MessageBoxButtons.OK)
                    services.Show()
                    Me.Hide()
                End If
            Else
                MsgBox("Email is not Valid")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub client_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class