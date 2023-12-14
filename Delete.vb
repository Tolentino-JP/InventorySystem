Imports MySql.Data.MySqlClient

Public Class Delete

    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim dbDataset As New DataTable

    Private Sub Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=127.0.0.1;Database=inventorysystem;User Id=root;convert zero datetime=True;"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()

            Dim Query As String
            Query = "SELECT Product_Id, Product_Name, Quantity, Price FROM inventorysystem.products"
            Command = New MySqlCommand(Query, MysqlConn)

            SDA.SelectCommand = Command
            'dbDataset.Clear()
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataset)

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub inputName_TextChanged(sender As Object, e As EventArgs) Handles inputSearch.TextChanged

        Dim DV As New DataView(dbDataset)
        DV.RowFilter = String.Format("Product_Name Like '%{0}%'", inputSearch.Text)
        DataGridView1.DataSource = DV

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=127.0.0.1;Database=InventorySystem;User Id=root;"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()

            Dim Query As String
            Query = "DELETE FROM InventorySystem.products WHERE Product_Name = '" & inputSearch.Text & "'"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader

            MessageBox.Show("Product Deleted!", "Inventory System")

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
        End Try

        Load_Table()
        inputSearch.Text = ""

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
            Command = New MySqlCommand(Query, MysqlConn)

            SDA.SelectCommand = Command
            dbDataset.Clear()
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataset)

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

End Class