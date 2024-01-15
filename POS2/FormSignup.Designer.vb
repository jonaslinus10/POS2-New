<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSignup
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
        Me.tbSignupConfirmPassword = New System.Windows.Forms.TextBox()
        Me.tbSignupPassword = New System.Windows.Forms.TextBox()
        Me.tbSignupUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSignup = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnClearAllFields = New System.Windows.Forms.Button()
        Me.cbSignupAccountType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Question = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'tbSignupConfirmPassword
        '
        Me.tbSignupConfirmPassword.BackColor = System.Drawing.Color.White
        Me.tbSignupConfirmPassword.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSignupConfirmPassword.ForeColor = System.Drawing.Color.Black
        Me.tbSignupConfirmPassword.Location = New System.Drawing.Point(201, 250)
        Me.tbSignupConfirmPassword.Name = "tbSignupConfirmPassword"
        Me.tbSignupConfirmPassword.Size = New System.Drawing.Size(254, 33)
        Me.tbSignupConfirmPassword.TabIndex = 14
        '
        'tbSignupPassword
        '
        Me.tbSignupPassword.BackColor = System.Drawing.Color.White
        Me.tbSignupPassword.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSignupPassword.ForeColor = System.Drawing.Color.Black
        Me.tbSignupPassword.Location = New System.Drawing.Point(201, 202)
        Me.tbSignupPassword.Name = "tbSignupPassword"
        Me.tbSignupPassword.Size = New System.Drawing.Size(254, 33)
        Me.tbSignupPassword.TabIndex = 13
        '
        'tbSignupUsername
        '
        Me.tbSignupUsername.BackColor = System.Drawing.Color.White
        Me.tbSignupUsername.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSignupUsername.ForeColor = System.Drawing.Color.Black
        Me.tbSignupUsername.Location = New System.Drawing.Point(201, 157)
        Me.tbSignupUsername.Name = "tbSignupUsername"
        Me.tbSignupUsername.Size = New System.Drawing.Size(254, 33)
        Me.tbSignupUsername.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 28)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Confirm Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 28)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 28)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Username"
        '
        'BtnSignup
        '
        Me.BtnSignup.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnSignup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSignup.FlatAppearance.BorderSize = 0
        Me.BtnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSignup.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSignup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSignup.Location = New System.Drawing.Point(122, 485)
        Me.BtnSignup.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnSignup.Name = "BtnSignup"
        Me.BtnSignup.Size = New System.Drawing.Size(244, 55)
        Me.BtnSignup.TabIndex = 47
        Me.BtnSignup.Text = "Proceed"
        Me.BtnSignup.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(20, 43)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 32)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Create User Account"
        '
        'BtnClearAllFields
        '
        Me.BtnClearAllFields.BackColor = System.Drawing.Color.Transparent
        Me.BtnClearAllFields.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClearAllFields.FlatAppearance.BorderSize = 0
        Me.BtnClearAllFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClearAllFields.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearAllFields.ForeColor = System.Drawing.Color.Maroon
        Me.BtnClearAllFields.Location = New System.Drawing.Point(122, 550)
        Me.BtnClearAllFields.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnClearAllFields.Name = "BtnClearAllFields"
        Me.BtnClearAllFields.Size = New System.Drawing.Size(244, 55)
        Me.BtnClearAllFields.TabIndex = 50
        Me.BtnClearAllFields.Text = "Clear All Fields"
        Me.BtnClearAllFields.UseVisualStyleBackColor = False
        '
        'cbSignupAccountType
        '
        Me.cbSignupAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSignupAccountType.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSignupAccountType.ForeColor = System.Drawing.Color.Black
        Me.cbSignupAccountType.FormattingEnabled = True
        Me.cbSignupAccountType.Items.AddRange(New Object() {"Cashier", "Admin"})
        Me.cbSignupAccountType.Location = New System.Drawing.Point(201, 111)
        Me.cbSignupAccountType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbSignupAccountType.Name = "cbSignupAccountType"
        Me.cbSignupAccountType.Size = New System.Drawing.Size(254, 36)
        Me.cbSignupAccountType.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 28)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Account Type"
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Image = Global.POS2.My.Resources.Resources.ic_exit
        Me.BtnClose.Location = New System.Drawing.Point(445, 3)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(63, 65)
        Me.BtnClose.TabIndex = 44
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Question
        '
        Me.Question.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Question.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question.ForeColor = System.Drawing.Color.Black
        Me.Question.FormattingEnabled = True
        Me.Question.Items.AddRange(New Object() {"What is your favorite color?", "What is your favorite food?", "Name of your pet?"})
        Me.Question.Location = New System.Drawing.Point(201, 356)
        Me.Question.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Question.Name = "Question"
        Me.Question.Size = New System.Drawing.Size(254, 36)
        Me.Question.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 28)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Question"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(201, 407)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(254, 33)
        Me.TextBox1.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 408)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 28)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Answer"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Location = New System.Drawing.Point(256, 298)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(176, 26)
        Me.CheckBox1.TabIndex = 57
        Me.CheckBox1.Text = "Show password"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CheckBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FormSignup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(511, 642)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Question)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbSignupAccountType)
        Me.Controls.Add(Me.BtnClearAllFields)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnSignup)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.tbSignupConfirmPassword)
        Me.Controls.Add(Me.tbSignupPassword)
        Me.Controls.Add(Me.tbSignupUsername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormSignup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSignup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbSignupConfirmPassword As TextBox
    Friend WithEvents tbSignupPassword As TextBox
    Friend WithEvents tbSignupUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnSignup As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnClearAllFields As Button
    Friend WithEvents cbSignupAccountType As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Question As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
