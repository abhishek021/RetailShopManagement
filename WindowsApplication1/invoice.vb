Imports System.Data.SqlClient

Public Class invoice
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        services.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Try
            TextBox6.Text = CSng(TextBox6.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)

        End Try
    End Sub

    Private Sub invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connection As New SqlConnection("Server=ADMIN\SQLEXPRESS;Database =registration; Integrated Security = true")
        Dim command As New SqlCommand("insert into GenInvoice(Name,Phone,Date,InvoicenNo,Address,Payment,Ddate,Bdue,Total,Itemdesc,Quantity,Rate,Amount) values(@name,@phone,@date,@invoice,@address,@payment,@ddate,@bdate,@total,@itemdesc,@quantity,@rate,@amt)", connection)
        Try
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = TextBox3.Text
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = TextBox5.Text
            command.Parameters.Add("@date", SqlDbType.VarChar).Value = TextBox4.Text
            command.Parameters.Add("@invoice", SqlDbType.Char).Value = TextBox1.Text
            command.Parameters.Add("@address", SqlDbType.Char).Value = TextBox2.Text
            command.Parameters.Add("@payment", SqlDbType.VarChar).Value = TextBox7.Text
            command.Parameters.Add("@ddate", SqlDbType.VarChar).Value = TextBox9.Text
            command.Parameters.Add("@bdate", SqlDbType.VarChar).Value = TextBox6.Text
            command.Parameters.Add("@total", SqlDbType.VarChar).Value = TextBox30.Text
            command.Parameters.Add("@itemdesc", SqlDbType.VarChar).Value = TextBox10.Text
            command.Parameters.Add("@quantity", SqlDbType.VarChar).Value = TextBox13.Text
            command.Parameters.Add("@rate", SqlDbType.VarChar).Value = TextBox12.Text
            command.Parameters.Add("@amt", SqlDbType.VarChar).Value = TextBox11.Text
            connection.Open()
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Invoice Generated", "Done", MessageBoxButtons.OK)
                services.Show()
                Me.Hide()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
End Class