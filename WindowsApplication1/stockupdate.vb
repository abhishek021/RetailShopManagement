Imports System.Data.SqlClient
Public Class stockupdate
    Public p As String
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        services.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProductBox.Text = ""
        IdBox.Text = ""
        BrandBox.Text = ""
        QBox.Text = ""
        RateBox.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connection As New SqlConnection("Server=ADMIN\SQLEXPRESS;Database =registration; Integrated Security = true")
        connection.Open()

        Try

            Dim command As New SqlCommand("insert into Stockdetails(Pname,Pid,Brand,Quantity,Rate) values(@pname,@pid,@brand,@quantity,@rate)", connection)

            command.Parameters.Add("@pname", SqlDbType.VarChar).Value = ProductBox.Text '+ vbNewLine + ProductBox2.Text + vbNewLine + ProductBox3.Text + vbNewLine + ProductBox4.Text + vbNewLine + ProductBox5.Text + vbNewLine + ProductBox6.Text
            command.Parameters.Add("@pid", SqlDbType.VarChar).Value = IdBox.Text '+ vbNewLine + IdBox2.Text + vbNewLine + IdBox3.Text + vbNewLine + IdBox4.Text + vbNewLine + IdBox5.Text + vbNewLine + IdBox6.Text
            command.Parameters.Add("@brand", SqlDbType.VarChar).Value = BrandBox.Text '+ vbNewLine + BrandBox2.Text + vbNewLine + BrandBox3.Text + vbNewLine + BrandBox4.Text + vbNewLine + BrandBox5.Text + vbNewLine + BrandBox6.Text
            command.Parameters.Add("@quantity", SqlDbType.VarChar).Value = QBox.Text '+ vbNewLine + QBox2.Text + vbNewLine + QBox3.Text + vbNewLine + QBox4.Text + vbNewLine + QBox5.Text + vbNewLine + QBox6.Text
            command.Parameters.Add("@rate", SqlDbType.VarChar).Value = RateBox.Text '+ vbNewLine + RateBox2.Text + vbNewLine + RateBox3.Text + vbNewLine + RateBox4.Text + vbNewLine + RateBox5.Text + vbNewLine + RateBox6.Text

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Stock Added", "Done", MessageBoxButtons.OK)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
        connection.Close()


    End Sub

    Private Sub stockupdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connection As New SqlConnection("Server=ADMIN\SQLEXPRESS;Database =registration; Integrated Security = true")
        connection.Open()
        Dim command As New SqlCommand("delete from Stockdetails where Pid=@pid", connection)
        Try
            command.Parameters.Add("@pid", SqlDbType.VarChar).Value = IdBox.Text
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Item Deleted", "Done", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim connection As New SqlConnection("Server=ADMIN\SQLEXPRESS;Database =registration; Integrated Security = true")
        connection.Open()

        Try

            Dim command As New SqlCommand("update Stockdetails set Pname=@pname,Brand=@brand,Quantity=@quantity,Rate=@rate where Pid = @pid and Pname= @pname", connection)

            command.Parameters.Add("@pname", SqlDbType.VarChar).Value = ProductBox.Text
            command.Parameters.Add("@pid", SqlDbType.VarChar).Value = IdBox.Text
            command.Parameters.Add("@brand", SqlDbType.VarChar).Value = BrandBox.Text
            command.Parameters.Add("@quantity", SqlDbType.VarChar).Value = QBox.Text
            command.Parameters.Add("@rate", SqlDbType.VarChar).Value = RateBox.Text

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Stock Updated", "Done", MessageBoxButtons.OK)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
        connection.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class