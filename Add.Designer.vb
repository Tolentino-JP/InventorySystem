<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add
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
        DataGridView1 = New DataGridView()
        columnId = New DataGridViewTextBoxColumn()
        columnProductName = New DataGridViewTextBoxColumn()
        columnQuantity = New DataGridViewTextBoxColumn()
        columnPrice = New DataGridViewTextBoxColumn()
        labelName = New Label()
        inputName = New TextBox()
        labelQuantity = New Label()
        inputQuantity = New TextBox()
        labelPrice = New Label()
        inputPrice = New TextBox()
        btnSubmit = New Button()
        btnCancel = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {columnId, columnProductName, columnQuantity, columnPrice})
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(591, 468)
        DataGridView1.TabIndex = 0
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
        ' labelName
        ' 
        labelName.AutoSize = True
        labelName.Location = New Point(636, 146)
        labelName.Name = "labelName"
        labelName.Size = New Size(97, 15)
        labelName.TabIndex = 4
        labelName.Text = "PRODUCT NAME"
        ' 
        ' inputName
        ' 
        inputName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        inputName.Location = New Point(629, 177)
        inputName.Name = "inputName"
        inputName.Size = New Size(221, 27)
        inputName.TabIndex = 3
        ' 
        ' labelQuantity
        ' 
        labelQuantity.AutoSize = True
        labelQuantity.Location = New Point(636, 230)
        labelQuantity.Name = "labelQuantity"
        labelQuantity.Size = New Size(63, 15)
        labelQuantity.TabIndex = 6
        labelQuantity.Text = "QUANTITY"
        ' 
        ' inputQuantity
        ' 
        inputQuantity.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        inputQuantity.Location = New Point(629, 261)
        inputQuantity.Name = "inputQuantity"
        inputQuantity.Size = New Size(221, 27)
        inputQuantity.TabIndex = 5
        ' 
        ' labelPrice
        ' 
        labelPrice.AutoSize = True
        labelPrice.Location = New Point(636, 313)
        labelPrice.Name = "labelPrice"
        labelPrice.Size = New Size(38, 15)
        labelPrice.TabIndex = 8
        labelPrice.Text = "PRICE"
        ' 
        ' inputPrice
        ' 
        inputPrice.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        inputPrice.Location = New Point(629, 344)
        inputPrice.Name = "inputPrice"
        inputPrice.Size = New Size(221, 27)
        inputPrice.TabIndex = 7
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(629, 438)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(221, 37)
        btnSubmit.TabIndex = 9
        btnSubmit.Text = "ADD PRODUCT"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(629, 395)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(221, 37)
        btnCancel.TabIndex = 10
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Add
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(878, 492)
        Controls.Add(btnCancel)
        Controls.Add(btnSubmit)
        Controls.Add(labelPrice)
        Controls.Add(inputPrice)
        Controls.Add(labelQuantity)
        Controls.Add(inputQuantity)
        Controls.Add(labelName)
        Controls.Add(inputName)
        Controls.Add(DataGridView1)
        Name = "Add"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents columnId As DataGridViewTextBoxColumn
    Friend WithEvents columnProductName As DataGridViewTextBoxColumn
    Friend WithEvents columnQuantity As DataGridViewTextBoxColumn
    Friend WithEvents columnPrice As DataGridViewTextBoxColumn
    Friend WithEvents labelName As Label
    Friend WithEvents inputName As TextBox
    Friend WithEvents labelQuantity As Label
    Friend WithEvents inputQuantity As TextBox
    Friend WithEvents labelPrice As Label
    Friend WithEvents inputPrice As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
End Class
