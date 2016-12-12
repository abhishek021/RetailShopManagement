Imports System.Data.SqlClient
Public Class order
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        services.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""


    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Try
            TextBox4.Text = CStr(TextBox4.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connection As New SqlConnection("Server=ADMIN\SQLEXPRESS;Database =registration; Integrated Security = true")
        Dim command As New SqlCommand("insert into Ordermade(Fname,Lname,Phone,Email,Onumber,Saddress,Zip,City,Pdesc,Quantity) values(@fname,@lname,@phone,@email,@onumber,@saddress,@zip,@city,@pdesc,@quantity)", connection)
        If TextBox1.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox2.Text = "" Or TextBox5.Text = "" Or TextBox3.Text = "" Or TextBox2.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Invalid Input")
            Exit Sub
        End If
        Try
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = TextBox3.Text
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = TextBox1.Text
            command.Parameters.Add("@onumber", SqlDbType.VarChar).Value = TextBox4.Text
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = TextBox6.Text
            command.Parameters.Add("@pdesc", SqlDbType.VarChar).Value = TextBox10.Text
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = TextBox2.Text
            command.Parameters.Add("@saddress", SqlDbType.VarChar).Value = TextBox5.Text
            command.Parameters.Add("@zip", SqlDbType.VarChar).Value = TextBox7.Text
            command.Parameters.Add("@city", SqlDbType.VarChar).Value = TextBox8.Text
            command.Parameters.Add("@quantity", SqlDbType.VarChar).Value = TextBox9.Text
            connection.Open()
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Order successfully placed", "Done", MessageBoxButtons.OK)
                services.Show()
                Me.Hide()
            Else
                MessageBox.Show("Order Unsuccessfull", "Done", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub order_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class