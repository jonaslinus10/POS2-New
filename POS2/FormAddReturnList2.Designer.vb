<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddReturnList2
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
        Me.BtnAddItemBack = New System.Windows.Forms.Button()
        Me.LblItemName = New System.Windows.Forms.Label()
        Me.tbReturnQTY = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAddQTYEnter = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.tbRemarks = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnAddItemBack
        '
        Me.BtnAddItemBack.FlatAppearance.BorderSize = 0
        Me.BtnAddItemBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddItemBack.Image = Global.POS2.My.Resources.Resources.ic_exit
        Me.BtnAddItemBack.Location = New System.Drawing.Point(377, 1)
        Me.BtnAddItemBack.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAddItemBack.Name = "BtnAddItemBack"
        Me.BtnAddItemBack.Size = New System.Drawing.Size(64, 59)
        Me.BtnAddItemBack.TabIndex = 51
        Me.BtnAddItemBack.UseVisualStyleBackColor = True
        '
        'LblItemName
        '
        Me.LblItemName.Font = New System.Drawing.Font("Nirmala UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItemName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.LblItemName.Location = New System.Drawing.Point(24, 50)
        Me.LblItemName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblItemName.Name = "LblItemName"
        Me.LblItemName.Size = New System.Drawing.Size(214, 53)
        Me.LblItemName.TabIndex = 52
        Me.LblItemName.Text = "Return Item"
        Me.LblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbReturnQTY
        '
        Me.tbReturnQTY.Font = New System.Drawing.Font("Nirmala UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbReturnQTY.Location = New System.Drawing.Point(32, 129)
        Me.tbReturnQTY.Margin = New System.Windows.Forms.Padding(4)
        Me.tbReturnQTY.Name = "tbReturnQTY"
        Me.tbReturnQTY.Size = New System.Drawing.Size(367, 39)
        Me.tbReturnQTY.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(146, 147)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 39)
        Me.Label1.TabIndex = 79
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(27, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(305, 29)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Enter Exact QTY To Return:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnAddQTYEnter
        '
        Me.BtnAddQTYEnter.BackColor = System.Drawing.Color.DarkRed
        Me.BtnAddQTYEnter.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddQTYEnter.ForeColor = System.Drawing.Color.Transparent
        Me.BtnAddQTYEnter.Location = New System.Drawing.Point(306, 372)
        Me.BtnAddQTYEnter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAddQTYEnter.Name = "BtnAddQTYEnter"
        Me.BtnAddQTYEnter.Size = New System.Drawing.Size(92, 48)
        Me.BtnAddQTYEnter.TabIndex = 81
        Me.BtnAddQTYEnter.Text = "Enter"
        Me.BtnAddQTYEnter.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnClear.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.White
        Me.BtnClear.Location = New System.Drawing.Point(208, 372)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(92, 48)
        Me.BtnClear.TabIndex = 82
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'tbRemarks
        '
        Me.tbRemarks.Font = New System.Drawing.Font("Nirmala UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRemarks.Location = New System.Drawing.Point(32, 214)
        Me.tbRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.tbRemarks.Multiline = True
        Me.tbRemarks.Name = "tbRemarks"
        Me.tbRemarks.Size = New System.Drawing.Size(366, 141)
        Me.tbRemarks.TabIndex = 83
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(30, 183)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(305, 29)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Remarks:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormAddReturnList2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(442, 448)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbRemarks)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnAddQTYEnter)
        Me.Controls.Add(Me.tbReturnQTY)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblItemName)
        Me.Controls.Add(Me.BtnAddItemBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormAddReturnList2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAddItemOrder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAddItemBack As Button
    Friend WithEvents LblItemName As Label
    Friend WithEvents tbReturnQTY As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAddQTYEnter As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents tbRemarks As TextBox
    Friend WithEvents Label3 As Label
End Class
