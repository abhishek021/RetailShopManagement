Public Class stockdetails
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'GridView1.Rows.Clear()
        services.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GridView1.DataSource = Nothing
        GridView1.Rows.Clear()
        GridView1.Columns.Clear()

        search.Show()
        Me.Hide()

    End Sub

    Private Sub stockdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView1.CellContentClick

    End Sub
End Class