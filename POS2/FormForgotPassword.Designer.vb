<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormForgotPassword
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
        Me.components = New System.ComponentModel.Container()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtAnswer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnClearAllFields = New System.Windows.Forms.Button()
        Me.tbSignupUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnCheck = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCPassword = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbShowPassword = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnChangePass = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbquestion = New System.Windows.Forms.ComboBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(28, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 23)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Answer"
        '
        'TxtAnswer
        '
        Me.TxtAnswer.BackColor = System.Drawing.Color.White
        Me.TxtAnswer.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAnswer.ForeColor = System.Drawing.Color.Black
        Me.TxtAnswer.Location = New System.Drawing.Point(207, 124)
        Me.TxtAnswer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAnswer.Name = "TxtAnswer"
        Me.TxtAnswer.Size = New System.Drawing.Size(228, 29)
        Me.TxtAnswer.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(27, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 23)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Question"
        '
        'BtnClearAllFields
        '
        Me.BtnClearAllFields.BackColor = System.Drawing.Color.Transparent
        Me.BtnClearAllFields.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClearAllFields.FlatAppearance.BorderSize = 0
        Me.BtnClearAllFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClearAllFields.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearAllFields.ForeColor = System.Drawing.Color.Maroon
        Me.BtnClearAllFields.Location = New System.Drawing.Point(189, 107)
        Me.BtnClearAllFields.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnClearAllFields.Name = "BtnClearAllFields"
        Me.BtnClearAllFields.Size = New System.Drawing.Size(228, 44)
        Me.BtnClearAllFields.TabIndex = 66
        Me.BtnClearAllFields.Text = "Clear All Fields"
        Me.BtnClearAllFields.UseVisualStyleBackColor = False
        '
        'tbSignupUsername
        '
        Me.tbSignupUsername.BackColor = System.Drawing.Color.White
        Me.tbSignupUsername.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSignupUsername.ForeColor = System.Drawing.Color.Black
        Me.tbSignupUsername.Location = New System.Drawing.Point(206, 43)
        Me.tbSignupUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSignupUsername.Name = "tbSignupUsername"
        Me.tbSignupUsername.Size = New System.Drawing.Size(228, 29)
        Me.tbSignupUsername.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(28, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Username"
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Image = Global.POS2.My.Resources.Resources.ic_exit
        Me.BtnClose.Location = New System.Drawing.Point(522, 0)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(56, 52)
        Me.BtnClose.TabIndex = 63
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnCheck
        '
        Me.BtnCheck.BackColor = System.Drawing.Color.DarkRed
        Me.BtnCheck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCheck.FlatAppearance.BorderSize = 0
        Me.BtnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCheck.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCheck.ForeColor = System.Drawing.Color.White
        Me.BtnCheck.Location = New System.Drawing.Point(207, 166)
        Me.BtnCheck.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnCheck.Name = "BtnCheck"
        Me.BtnCheck.Size = New System.Drawing.Size(228, 44)
        Me.BtnCheck.TabIndex = 73
        Me.BtnCheck.Text = "Proceed"
        Me.BtnCheck.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(7, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 23)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "New Password"
        '
        'TxtNPassword
        '
        Me.TxtNPassword.BackColor = System.Drawing.Color.White
        Me.TxtNPassword.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNPassword.ForeColor = System.Drawing.Color.Black
        Me.TxtNPassword.Location = New System.Drawing.Point(189, 34)
        Me.TxtNPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNPassword.Name = "TxtNPassword"
        Me.TxtNPassword.Size = New System.Drawing.Size(228, 29)
        Me.TxtNPassword.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(4, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 23)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Confirm Password"
        '
        'TxtCPassword
        '
        Me.TxtCPassword.BackColor = System.Drawing.Color.White
        Me.TxtCPassword.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCPassword.ForeColor = System.Drawing.Color.Black
        Me.TxtCPassword.Location = New System.Drawing.Point(190, 74)
        Me.TxtCPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCPassword.Name = "TxtCPassword"
        Me.TxtCPassword.Size = New System.Drawing.Size(225, 29)
        Me.TxtCPassword.TabIndex = 77
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(43, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(233, 37)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Forgot Password"
        '
        'CbShowPassword
        '
        Me.CbShowPassword.Appearance = System.Windows.Forms.Appearance.Button
        Me.CbShowPassword.BackgroundImage = Global.POS2.My.Resources.Resources.eyecon
        Me.CbShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CbShowPassword.FlatAppearance.BorderSize = 0
        Me.CbShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbShowPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbShowPassword.Location = New System.Drawing.Point(428, 57)
        Me.CbShowPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CbShowPassword.Name = "CbShowPassword"
        Me.CbShowPassword.Size = New System.Drawing.Size(33, 24)
        Me.CbShowPassword.TabIndex = 84
        Me.CbShowPassword.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnChangePass)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CbShowPassword)
        Me.GroupBox1.Controls.Add(Me.BtnClearAllFields)
        Me.GroupBox1.Controls.Add(Me.TxtNPassword)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtCPassword)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(40, 332)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(478, 235)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Password Field"
        '
        'btnChangePass
        '
        Me.btnChangePass.BackColor = System.Drawing.Color.DarkRed
        Me.btnChangePass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangePass.FlatAppearance.BorderSize = 0
        Me.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePass.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePass.ForeColor = System.Drawing.Color.White
        Me.btnChangePass.Location = New System.Drawing.Point(131, 166)
        Me.btnChangePass.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(228, 44)
        Me.btnChangePass.TabIndex = 86
        Me.btnChangePass.Text = "Save Password"
        Me.btnChangePass.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbquestion)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbSignupUsername)
        Me.GroupBox2.Controls.Add(Me.BtnCheck)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtAnswer)
        Me.GroupBox2.Location = New System.Drawing.Point(40, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(478, 234)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Find User"
        '
        'cbquestion
        '
        Me.cbquestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbquestion.FormattingEnabled = True
        Me.cbquestion.Location = New System.Drawing.Point(207, 84)
        Me.cbquestion.Name = "cbquestion"
        Me.cbquestion.Size = New System.Drawing.Size(227, 24)
        Me.cbquestion.TabIndex = 74
        '
        'FormForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(582, 652)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormForgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormForgotPassword"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents TxtAnswer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnClearAllFields As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents tbSignupUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCheck As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCPassword As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label5 As Label
    Friend WithEvents CbShowPassword As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnChangePass As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbquestion As ComboBox
End Class
