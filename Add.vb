﻿Imports MySql.Data.MySqlClient

Public Class Add

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load



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

            MessageBox.Show("PRODUCT ADDED")

            MysqlConn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try


    End Sub
End Class