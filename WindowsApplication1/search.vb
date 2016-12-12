Imports System.Data.SqlClient
Public Class search
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New SqlConnection("Server=ADMIN\SQLEXPRESS;Database =registration; Integrated Security = true")
        connection.Open()
        Dim command As New SqlCommand("select * from Stockdetails where Pname=@pname and Pid=@pid ", connection)
        Dim adp As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Try
            command.Parameters.Add("@pname", SqlDbType.VarChar).Value = TextBox1.Text
            command.Parameters.Add("@pid", SqlDbType.VarChar).Value = TextBox3.Text
            adp.Fill(table)
            stockdetails.GridView1.DataSource = table
            stockdetails.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        services.Show()
        Me.Hide()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim connection As New SqlConnection("Server=ADMIN\SQLEXPRESS;Database =registration; Integrated Security = true")
        connection.Open()
        Dim command As New SqlCommand("select * from Stockdetails", connection)
        Dim adp As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adp.Fill(table)
        stockdetails.GridView1.DataSource = table
        stockdetails.Show()
        Me.Hide()
    End Sub

    Private Sub search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class