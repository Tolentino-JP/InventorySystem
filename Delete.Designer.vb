﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delete
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnCancel = New Button()
        btnUpdate = New Button()
        labelPrice = New Label()
        inputPrice = New TextBox()
        labelQuantity = New Label()
        inputQuantity = New TextBox()
        labelName = New Label()
        inputName = New TextBox()
        labelId = New Label()
        inputId = New TextBox()
        DataGridView1 = New DataGridView()
        columnId = New DataGridViewTextBoxColumn()
        columnProductName = New DataGridViewTextBoxColumn()
        columnQuantity = New DataGridViewTextBoxColumn()
        columnPrice = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(629, 396)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(221, 37)
        btnCancel.TabIndex = 31
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(629, 439)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(221, 37)
        btnUpdate.TabIndex = 30
        btnUpdate.Text = "UPDATE PRODUCT"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' labelPrice
        ' 
        labelPrice.AutoSize = True
        labelPrice.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        labelPrice.Location = New Point(628, 314)
        labelPrice.Name = "labelPrice"
        labelPrice.Size = New Size(47, 20)
        labelPrice.TabIndex = 29
        labelPrice.Text = "PRICE"
        ' 
        ' inputPrice
        ' 
        inputPrice.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        inputPrice.Location = New Point(630, 350)
        inputPrice.Name = "inputPrice"
        inputPrice.Size = New Size(221, 27)
        inputPrice.TabIndex = 28
        ' 
        ' labelQuantity
        ' 
        labelQuantity.AutoSize = True
        labelQuantity.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        labelQuantity.Location = New Point(628, 231)
        labelQuantity.Name = "labelQuantity"
        labelQuantity.Size = New Size(79, 20)
        labelQuantity.TabIndex = 27
        labelQuantity.Text = "QUANTITY"
        ' 
        ' inputQuantity
        ' 
        inputQuantity.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        inputQuantity.Location = New Point(629, 262)
        inputQuantity.Name = "inputQuantity"
        inputQuantity.Size = New Size(221, 27)
        inputQuantity.TabIndex = 26
        ' 
        ' labelName
        ' 
        labelName.AutoSize = True
        labelName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        labelName.Location = New Point(628, 147)
        labelName.Name = "labelName"
        labelName.Size = New Size(121, 20)
        labelName.TabIndex = 25
        labelName.Text = "PRODUCT NAME"
        ' 
        ' inputName
        ' 
        inputName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        inputName.Location = New Point(629, 178)
        inputName.Name = "inputName"
        inputName.Size = New Size(221, 27)
        inputName.TabIndex = 24
        ' 
        ' labelId
        ' 
        labelId.AutoSize = True
        labelId.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        labelId.Location = New Point(628, 61)
        labelId.Name = "labelId"
        labelId.Size = New Size(94, 20)
        labelId.TabIndex = 23
        labelId.Text = "PRODUCT ID"
        ' 
        ' inputId
        ' 
        inputId.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        inputId.Location = New Point(629, 92)
        inputId.Name = "inputId"
        inputId.Size = New Size(221, 27)
        inputId.TabIndex = 22
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {columnId, columnProductName, columnQuantity, columnPrice})
        DataGridView1.Location = New Point(12, 13)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(591, 468)
        DataGridView1.TabIndex = 21
        ' 
        ' columnId
        ' 
        columnId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        columnId.HeaderText = "PRODUCT ID"
        columnId.Name = "columnId"
        ' 
        ' columnProductName
        ' 
        columnProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        columnProductName.HeaderText = "PRODUCT NAME"
        columnProductName.Name = "columnProductName"
        ' 
        ' columnQuantity
        ' 
        columnQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        columnQuantity.HeaderText = "QUANTITY"
        columnQuantity.Name = "columnQuantity"
        ' 
        ' columnPrice
        ' 
        columnPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        columnPrice.HeaderText = "PRICE"
        columnPrice.Name = "columnPrice"
        ' 
        ' Delete
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(863, 495)
        Controls.Add(btnCancel)
        Controls.Add(btnUpdate)
        Controls.Add(labelPrice)
        Controls.Add(inputPrice)
        Controls.Add(labelQuantity)
        Controls.Add(inputQuantity)
        Controls.Add(labelName)
        Controls.Add(inputName)
        Controls.Add(labelId)
        Controls.Add(inputId)
        Controls.Add(DataGridView1)
        Name = "Delete"
        Text = "Delete"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents labelPrice As Label
    Friend WithEvents inputPrice As TextBox
    Friend WithEvents labelQuantity As Label
    Friend WithEvents inputQuantity As TextBox
    Friend WithEvents labelName As Label
    Friend WithEvents inputName As TextBox
    Friend WithEvents labelId As Label
    Friend WithEvents inputId As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents columnId As DataGridViewTextBoxColumn
    Friend WithEvents columnProductName As DataGridViewTextBoxColumn
    Friend WithEvents columnQuantity As DataGridViewTextBoxColumn
    Friend WithEvents columnPrice As DataGridViewTextBoxColumn
End Class