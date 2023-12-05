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
        Label1 = New Label()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnSearch = New Button()
        btnAdd = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(334, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(349, 86)
        Label1.TabIndex = 0
        Label1.Text = "WELCOME"
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(550, 344)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(152, 59)
        btnDelete.TabIndex = 11
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(357, 344)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(152, 59)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(550, 266)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(152, 59)
        btnSearch.TabIndex = 9
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(357, 266)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(152, 59)
        btnAdd.TabIndex = 8
        btnAdd.Text = "ADD PRODUCT"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1018, 533)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnSearch)
        Controls.Add(btnAdd)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Inventory System"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAdd As Button
End Class
