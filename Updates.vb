Imports MySql.Data.MySqlClient

Public Class Updates

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=127.0.0.1;Database=inventorysystem;User Id=root;"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE inventorysystem.products set  
            Product_Name ='" & inputName.Text & "', 
            Quantity ='" & inputQuantity.Text & "', 
            Price ='" & inputPrice.Text & "'
            WHERE Product_Id = '" & inputId.Text & "'"


            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = Command.ExecuteReader

            MessageBox.Show("PRODUCT UPDATED")

            MysqlConn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class