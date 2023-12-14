<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Delete))
        btnCancel = New Button()
        btnDelete = New Button()
        labelName = New Label()
        inputSearch = New TextBox()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCancel
        ' 
        btnCancel.Cursor = Cursors.Hand
        btnCancel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnCancel.Location = New Point(970, 535)
        btnCancel.Margin = New Padding(4, 5, 4, 5)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(193, 45)
        btnCancel.TabIndex = 31
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.DarkOrange
        btnDelete.Cursor = Cursors.Hand
        btnDelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelete.ForeColor = SystemColors.ControlLightLight
        btnDelete.Location = New Point(970, 468)
        btnDelete.Margin = New Padding(4, 5, 4, 5)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(193, 45)
        btnDelete.TabIndex = 30
        btnDelete.Text = "DELETE PRODUCT"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' labelName
        ' 
        labelName.AutoSize = True
        labelName.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        labelName.Location = New Point(884, 112)
        labelName.Margin = New Padding(4, 0, 4, 0)
        labelName.Name = "labelName"
        labelName.Size = New Size(312, 32)
        labelName.TabIndex = 25
        labelName.Text = "SEARCH: PRODUCT NAME"
        ' 
        ' inputSearch
        ' 
        inputSearch.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        inputSearch.Location = New Point(884, 149)
        inputSearch.Margin = New Padding(4, 5, 4, 5)
        inputSearch.Name = "inputSearch"
        inputSearch.Size = New Size(331, 37)
        inputSearch.TabIndex = 24
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(17, 20)
        DataGridView1.Margin = New Padding(4, 5, 4, 5)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(844, 575)
        DataGridView1.TabIndex = 21
        ' 
        ' Delete
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(1254, 623)
        Controls.Add(btnCancel)
        Controls.Add(btnDelete)
        Controls.Add(labelName)
        Controls.Add(inputSearch)
        Controls.Add(DataGridView1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Delete"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Product Deletion"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents labelName As Label
    Friend WithEvents inputSearch As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
