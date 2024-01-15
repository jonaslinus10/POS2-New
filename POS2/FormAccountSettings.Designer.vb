<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccountSettings
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LvUsers = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnFormAccSettRefresh = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BtnUnmarkAll = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnFormAccSettAddUser = New System.Windows.Forms.Button()
        Me.BtnDeleteMarked = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.LvUsers)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1298, 554)
        Me.Panel1.TabIndex = 0
        '
        'LvUsers
        '
        Me.LvUsers.CheckBoxes = True
        Me.LvUsers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4})
        Me.LvUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LvUsers.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvUsers.FullRowSelect = True
        Me.LvUsers.GridLines = True
        Me.LvUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LvUsers.HideSelection = False
        Me.LvUsers.Location = New System.Drawing.Point(0, 132)
        Me.LvUsers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LvUsers.Name = "LvUsers"
        Me.LvUsers.Size = New System.Drawing.Size(1294, 418)
        Me.LvUsers.TabIndex = 1
        Me.LvUsers.UseCompatibleStateImageBehavior = False
        Me.LvUsers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "User ID"
        Me.ColumnHeader1.Width = 350
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "User Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 350
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "User Role"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 350
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1294, 132)
        Me.Panel2.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(9, 66)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(246, 60)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Employees"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnFormAccSettRefresh)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.BtnUnmarkAll)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.BtnFormAccSettAddUser)
        Me.Panel3.Controls.Add(Me.BtnDeleteMarked)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(561, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(733, 132)
        Me.Panel3.TabIndex = 0
        '
        'BtnFormAccSettRefresh
        '
        Me.BtnFormAccSettRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BtnFormAccSettRefresh.Font = New System.Drawing.Font("Nirmala UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BtnFormAccSettRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnFormAccSettRefresh.Location = New System.Drawing.Point(220, 66)
        Me.BtnFormAccSettRefresh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnFormAccSettRefresh.Name = "BtnFormAccSettRefresh"
        Me.BtnFormAccSettRefresh.Size = New System.Drawing.Size(156, 59)
        Me.BtnFormAccSettRefresh.TabIndex = 7
        Me.BtnFormAccSettRefresh.Text = "Refresh"
        Me.BtnFormAccSettRefresh.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(548, 66)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(156, 59)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Mark All"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'BtnUnmarkAll
        '
        Me.BtnUnmarkAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BtnUnmarkAll.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUnmarkAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnUnmarkAll.Location = New System.Drawing.Point(548, 4)
        Me.BtnUnmarkAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnUnmarkAll.Name = "BtnUnmarkAll"
        Me.BtnUnmarkAll.Size = New System.Drawing.Size(156, 59)
        Me.BtnUnmarkAll.TabIndex = 5
        Me.BtnUnmarkAll.Text = "Unmark All"
        Me.BtnUnmarkAll.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 3
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(383, 66)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(156, 59)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Delete All"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BtnFormAccSettAddUser
        '
        Me.BtnFormAccSettAddUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnFormAccSettAddUser.Font = New System.Drawing.Font("Nirmala UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFormAccSettAddUser.Image = Global.POS2.My.Resources.Resources.add_user
        Me.BtnFormAccSettAddUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnFormAccSettAddUser.Location = New System.Drawing.Point(220, 4)
        Me.BtnFormAccSettAddUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnFormAccSettAddUser.Name = "BtnFormAccSettAddUser"
        Me.BtnFormAccSettAddUser.Size = New System.Drawing.Size(156, 59)
        Me.BtnFormAccSettAddUser.TabIndex = 3
        Me.BtnFormAccSettAddUser.Text = "Add Account"
        Me.BtnFormAccSettAddUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnFormAccSettAddUser.UseVisualStyleBackColor = False
        '
        'BtnDeleteMarked
        '
        Me.BtnDeleteMarked.BackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.BtnDeleteMarked.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteMarked.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnDeleteMarked.Location = New System.Drawing.Point(383, 4)
        Me.BtnDeleteMarked.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnDeleteMarked.Name = "BtnDeleteMarked"
        Me.BtnDeleteMarked.Size = New System.Drawing.Size(156, 59)
        Me.BtnDeleteMarked.TabIndex = 2
        Me.BtnDeleteMarked.Text = "Delete Marked"
        Me.BtnDeleteMarked.UseVisualStyleBackColor = False
        '
        'FormAccountSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1298, 554)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormAccountSettings"
        Me.Text = "FormAccountSettings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LvUsers As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnFormAccSettAddUser As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnUnmarkAll As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents BtnFormAccSettRefresh As Button
    Friend WithEvents BtnDeleteMarked As Button
End Class
