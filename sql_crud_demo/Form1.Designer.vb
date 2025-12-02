<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxAge = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Labael3 = New System.Windows.Forms.Label()
        Me.ButtonCreat = New System.Windows.Forms.Button()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBoxHiddenId = New System.Windows.Forms.TextBox()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Location = New System.Drawing.Point(34, 26)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(171, 48)
        Me.ButtonConnect.TabIndex = 0
        Me.ButtonConnect.Text = "Connect My SQL"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(69, 106)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxName.TabIndex = 2
        '
        'TextBoxAge
        '
        Me.TextBoxAge.Location = New System.Drawing.Point(69, 136)
        Me.TextBoxAge.Name = "TextBoxAge"
        Me.TextBoxAge.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxAge.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Age"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(69, 169)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxEmail.TabIndex = 6
        '
        'Labael3
        '
        Me.Labael3.AutoSize = True
        Me.Labael3.Location = New System.Drawing.Point(31, 169)
        Me.Labael3.Name = "Labael3"
        Me.Labael3.Size = New System.Drawing.Size(32, 13)
        Me.Labael3.TabIndex = 5
        Me.Labael3.Text = "Email"
        '
        'ButtonCreat
        '
        Me.ButtonCreat.Location = New System.Drawing.Point(26, 195)
        Me.ButtonCreat.Name = "ButtonCreat"
        Me.ButtonCreat.Size = New System.Drawing.Size(171, 48)
        Me.ButtonCreat.TabIndex = 7
        Me.ButtonCreat.Text = "Create(InsertData)"
        Me.ButtonCreat.UseVisualStyleBackColor = True
        '
        'ButtonRead
        '
        Me.ButtonRead.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonRead.Location = New System.Drawing.Point(26, 246)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(171, 48)
        Me.ButtonRead.TabIndex = 8
        Me.ButtonRead.Text = "Read(GetData)"
        Me.ButtonRead.UseMnemonic = False
        Me.ButtonRead.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 300)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(776, 138)
        Me.DataGridView1.TabIndex = 9
        '
        'TextBoxHiddenId
        '
        Me.TextBoxHiddenId.Location = New System.Drawing.Point(69, 80)
        Me.TextBoxHiddenId.Name = "TextBoxHiddenId"
        Me.TextBoxHiddenId.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxHiddenId.TabIndex = 10
        Me.TextBoxHiddenId.Visible = False
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(203, 195)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(171, 48)
        Me.ButtonUpdate.TabIndex = 11
        Me.ButtonUpdate.Text = "Update(Modify Exixting Data)"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(203, 246)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(171, 48)
        Me.ButtonDelete.TabIndex = 12
        Me.ButtonDelete.Text = "Delete (Modify Exixting Data)"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.TextBoxHiddenId)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonRead)
        Me.Controls.Add(Me.ButtonCreat)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.Labael3)
        Me.Controls.Add(Me.TextBoxAge)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonConnect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxAge As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Labael3 As Label
    Friend WithEvents ButtonCreat As Button
    Friend WithEvents ButtonRead As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBoxHiddenId As TextBox
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
End Class
