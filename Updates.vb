Imports MySql.Data.MySqlClient

Public Class Updates

    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim dbDataSet As New DataTable
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Updates_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            Command = New MySqlCommand(Query, MysqlConn)

            SDA.SelectCommand = Command
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

    Private Sub inputName_TextChanged(sender As Object, e As EventArgs) Handles inputName.TextChanged

        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("Product_Name Like '%{0}%'", inputName.Text)
        DataGridView1.DataSource = DV

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=127.0.0.1;Database=inventorysystem;User Id=root;"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()

            Dim Query As String
            Query = "UPDATE inventorysystem.products SET 
                    Quantity = '" & inputQuantity.Text & "',
                    Price = '" & inputPrice.Text & "'
                    WHERE Product_Name= '" & inputName.Text & "'"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader

            MessageBox.Show("Product Updated!", "Inventory System")

            MysqlConn.Close()
        Catch ex As MySqlException
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