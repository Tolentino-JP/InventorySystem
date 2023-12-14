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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add))
        DataGridView1 = New DataGridView()
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
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(17, 20)
        DataGridView1.Margin = New Padding(4, 5, 4, 5)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(844, 575)
        DataGridView1.TabIndex = 0
        ' 
        ' labelName
        ' 
        labelName.AutoSize = True
        labelName.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        labelName.Location = New Point(886, 44)
        labelName.Margin = New Padding(4, 0, 4, 0)
        labelName.Name = "labelName"
        labelName.Size = New Size(171, 28)
        labelName.TabIndex = 4
        labelName.Text = "PRODUCT NAME"
        ' 
        ' inputName
        ' 
        inputName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        inputName.Location = New Point(886, 77)
        inputName.Margin = New Padding(4, 5, 4, 5)
        inputName.Name = "inputName"
        inputName.Size = New Size(338, 37)
        inputName.TabIndex = 3
        ' 
        ' labelQuantity
        ' 
        labelQuantity.AutoSize = True
        labelQuantity.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        labelQuantity.Location = New Point(886, 156)
        labelQuantity.Margin = New Padding(4, 0, 4, 0)
        labelQuantity.Name = "labelQuantity"
        labelQuantity.Size = New Size(113, 28)
        labelQuantity.TabIndex = 6
        labelQuantity.Text = "QUANTITY"
        ' 
        ' inputQuantity
        ' 
        inputQuantity.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        inputQuantity.Location = New Point(886, 189)
        inputQuantity.Margin = New Padding(4, 5, 4, 5)
        inputQuantity.Name = "inputQuantity"
        inputQuantity.Size = New Size(338, 37)
        inputQuantity.TabIndex = 5
        ' 
        ' labelPrice
        ' 
        labelPrice.AutoSize = True
        labelPrice.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        labelPrice.Location = New Point(886, 270)
        labelPrice.Margin = New Padding(4, 0, 4, 0)
        labelPrice.Name = "labelPrice"
        labelPrice.Size = New Size(66, 28)
        labelPrice.TabIndex = 8
        labelPrice.Text = "PRICE"
        ' 
        ' inputPrice
        ' 
        inputPrice.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        inputPrice.Location = New Point(886, 303)
        inputPrice.Margin = New Padding(4, 5, 4, 5)
        inputPrice.Name = "inputPrice"
        inputPrice.Size = New Size(338, 37)
        inputPrice.TabIndex = 7
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.DarkOrange
        btnSubmit.Cursor = Cursors.Hand
        btnSubmit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnSubmit.ForeColor = SystemColors.ControlLightLight
        btnSubmit.Location = New Point(970, 468)
        btnSubmit.Margin = New Padding(4, 5, 4, 5)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(193, 45)
        btnSubmit.TabIndex = 9
        btnSubmit.Text = "ADD PRODUCT"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Cursor = Cursors.Hand
        btnCancel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnCancel.Location = New Point(970, 535)
        btnCancel.Margin = New Padding(4, 5, 4, 5)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(193, 45)
        btnCancel.TabIndex = 10
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Add
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(1254, 623)
        Controls.Add(btnCancel)
        Controls.Add(btnSubmit)
        Controls.Add(labelPrice)
        Controls.Add(inputPrice)
        Controls.Add(labelQuantity)
        Controls.Add(inputQuantity)
        Controls.Add(labelName)
        Controls.Add(inputName)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Add"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Product Addition"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents labelName As Label
    Friend WithEvents inputName As TextBox
    Friend WithEvents labelQuantity As Label
    Friend WithEvents inputQuantity As TextBox
    Friend WithEvents labelPrice As Label
    Friend WithEvents inputPrice As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
End Class
