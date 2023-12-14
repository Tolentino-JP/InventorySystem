Imports MySql.Data.MySqlClient

Public Class Add

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Table()
    End Sub

    Private Sub Load_Table()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=127.0.0.1;Database=inventorysystem;User Id=root;convert zero datetime=True;"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()

            Dim Query As String
            Query = "SELECT Product_Id, Product_Name, Quantity, Price FROM inventorysystem.products"
            COMMAND = New MySqlCommand(Query, MysqlConn)

            SDA.SelectCommand = COMMAND
            dbDataSet.Clear()
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
        End Try

    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=127.0.0.1;Database=inventorysystem;User Id=root;"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO inventorysystem.products (Product_Name, Quantity, Price) VALUES ('" & inputName.Text & "', '" & inputQuantity.Text & "', '" & inputPrice.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Product Added!", "Inventory System")

            MysqlConn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Load_Table()
        inputName.Text = ""
        inputPrice.Text = ""
        inputQuantity.Text = ""

    End Sub
End Class