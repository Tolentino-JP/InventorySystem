<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnAdd = New Button()
        btnExit = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(135, 70)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(523, 128)
        Label1.TabIndex = 0
        Label1.Text = "WELCOME"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.DarkOrange
        btnDelete.Cursor = Cursors.Hand
        btnDelete.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelete.Location = New Point(498, 309)
        btnDelete.Margin = New Padding(4, 5, 4, 5)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(202, 69)
        btnDelete.TabIndex = 11
        btnDelete.Text = "DELETE PRODUCT"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.DarkOrange
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        btnUpdate.Location = New Point(288, 309)
        btnUpdate.Margin = New Padding(4, 5, 4, 5)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(202, 69)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "UPDATE PRODUCT"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.DarkOrange
        btnAdd.Cursor = Cursors.Hand
        btnAdd.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        btnAdd.Location = New Point(78, 309)
        btnAdd.Margin = New Padding(4, 5, 4, 5)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(202, 69)
        btnAdd.TabIndex = 8
        btnAdd.Text = "ADD PRODUCT"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.InfoText
        btnExit.Cursor = Cursors.Hand
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnExit.ForeColor = SystemColors.ButtonHighlight
        btnExit.Location = New Point(305, 462)
        btnExit.Margin = New Padding(4, 5, 4, 5)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(168, 39)
        btnExit.TabIndex = 12
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(305, 265)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(168, 25)
        Label2.TabIndex = 13
        Label2.Text = "Choose your action:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(773, 571)
        Controls.Add(Label2)
        Controls.Add(btnExit)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory System"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
End Class
