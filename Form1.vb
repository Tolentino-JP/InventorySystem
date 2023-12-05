Imports MySql.Data.MySqlClient
Public Class Form1

    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=127.0.0.1;Database=InventorySystem;User Id=root;"

        'Try
        '    MysqlConn.Open()
        '    MessageBox.Show("Connection Successful")
        '    MysqlConn.Close()
        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        '
        'Finally
        '    MysqlConn.Dispose()
        'End Try

    End Sub



    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
