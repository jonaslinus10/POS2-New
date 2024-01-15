<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateAccount
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbNewPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbConfirmPassword = New System.Windows.Forms.TextBox()
        Me.CbUARole = New System.Windows.Forms.ComboBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnFormUASave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbUAPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbUAUsername = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.tbNewPassword)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tbConfirmPassword)
        Me.Panel1.Controls.Add(Me.CbUARole)
        Me.Panel1.Controls.Add(Me.BtnExit)
        Me.Panel1.Controls.Add(Me.BtnFormUASave)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TbUAPassword)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TbUAUsername)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(477, 521)
        Me.Panel1.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Location = New System.Drawing.Point(203, 365)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(176, 26)
        Me.CheckBox1.TabIndex = 66
        Me.CheckBox1.Text = "Show password"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CheckBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 28)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Confirm Password"
        '
        'tbNewPassword
        '
        Me.tbNewPassword.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNewPassword.Location = New System.Drawing.Point(202, 260)
        Me.tbNewPassword.Name = "tbNewPassword"
        Me.tbNewPassword.Size = New System.Drawing.Size(250, 37)
        Me.tbNewPassword.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 30)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "New Password"
        '
        'tbConfirmPassword
        '
        Me.tbConfirmPassword.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConfirmPassword.Location = New System.Drawing.Point(203, 313)
        Me.tbConfirmPassword.Name = "tbConfirmPassword"
        Me.tbConfirmPassword.Size = New System.Drawing.Size(250, 37)
        Me.tbConfirmPassword.TabIndex = 61
        '
        'CbUARole
        '
        Me.CbUARole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbUARole.Enabled = False
        Me.CbUARole.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbUARole.ForeColor = System.Drawing.Color.Black
        Me.CbUARole.FormattingEnabled = True
        Me.CbUARole.Items.AddRange(New Object() {"Cashier", "Admin"})
        Me.CbUARole.Location = New System.Drawing.Point(203, 109)
        Me.CbUARole.Name = "CbUARole"
        Me.CbUARole.Size = New System.Drawing.Size(249, 38)
        Me.CbUARole.TabIndex = 59
        '
        'BtnExit
        '
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Image = Global.POS2.My.Resources.Resources.ic_exit
        Me.BtnExit.Location = New System.Drawing.Point(435, 0)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(42, 42)
        Me.BtnExit.TabIndex = 58
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnFormUASave
        '
        Me.BtnFormUASave.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnFormUASave.FlatAppearance.BorderSize = 0
        Me.BtnFormUASave.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFormUASave.ForeColor = System.Drawing.Color.Black
        Me.BtnFormUASave.Location = New System.Drawing.Point(117, 439)
        Me.BtnFormUASave.Name = "BtnFormUASave"
        Me.BtnFormUASave.Size = New System.Drawing.Size(214, 55)
        Me.BtnFormUASave.TabIndex = 56
        Me.BtnFormUASave.Text = "Save"
        Me.BtnFormUASave.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 30)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Role"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 30)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Password"
        '
        'TbUAPassword
        '
        Me.TbUAPassword.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbUAPassword.Location = New System.Drawing.Point(203, 211)
        Me.TbUAPassword.Name = "TbUAPassword"
        Me.TbUAPassword.Size = New System.Drawing.Size(250, 37)
        Me.TbUAPassword.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 30)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Username"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(7, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(261, 45)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Update Account"
        '
        'TbUAUsername
        '
        Me.TbUAUsername.Enabled = False
        Me.TbUAUsername.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbUAUsername.Location = New System.Drawing.Point(203, 161)
        Me.TbUAUsername.Name = "TbUAUsername"
        Me.TbUAUsername.ReadOnly = True
        Me.TbUAUsername.Size = New System.Drawing.Size(250, 37)
        Me.TbUAUsername.TabIndex = 0
        '
        'FormUpdateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(477, 521)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUpdateAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Account"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TbUAUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbUAPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnFormUASave As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents CbUARole As ComboBox
    Friend WithEvents tbConfirmPassword As TextBox
    Friend WithEvents tbNewPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
