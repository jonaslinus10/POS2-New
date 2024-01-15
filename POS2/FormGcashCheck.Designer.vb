<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGcashCheck
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
        Me.tbGcashRef = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAddItemEnter = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAddItemBack
        '
        Me.BtnAddItemBack.FlatAppearance.BorderSize = 0
        Me.BtnAddItemBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddItemBack.Image = Global.POS2.My.Resources.Resources.ic_exit
        Me.BtnAddItemBack.Location = New System.Drawing.Point(424, 1)
        Me.BtnAddItemBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAddItemBack.Name = "BtnAddItemBack"
        Me.BtnAddItemBack.Size = New System.Drawing.Size(72, 74)
        Me.BtnAddItemBack.TabIndex = 51
        Me.BtnAddItemBack.UseVisualStyleBackColor = True
        '
        'LblItemName
        '
        Me.LblItemName.Font = New System.Drawing.Font("Nirmala UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItemName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.LblItemName.Location = New System.Drawing.Point(-2, 62)
        Me.LblItemName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblItemName.Name = "LblItemName"
        Me.LblItemName.Size = New System.Drawing.Size(368, 66)
        Me.LblItemName.TabIndex = 52
        Me.LblItemName.Text = "G-cash Payment"
        Me.LblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbGcashRef
        '
        Me.tbGcashRef.Font = New System.Drawing.Font("Nirmala UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGcashRef.Location = New System.Drawing.Point(36, 161)
        Me.tbGcashRef.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbGcashRef.Name = "tbGcashRef"
        Me.tbGcashRef.Size = New System.Drawing.Size(412, 45)
        Me.tbGcashRef.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(164, 184)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 49)
        Me.Label1.TabIndex = 79
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(30, 124)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 36)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Reference Number:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnAddItemEnter
        '
        Me.BtnAddItemEnter.BackColor = System.Drawing.Color.DarkRed
        Me.BtnAddItemEnter.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddItemEnter.ForeColor = System.Drawing.Color.Transparent
        Me.BtnAddItemEnter.Location = New System.Drawing.Point(345, 235)
        Me.BtnAddItemEnter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAddItemEnter.Name = "BtnAddItemEnter"
        Me.BtnAddItemEnter.Size = New System.Drawing.Size(104, 60)
        Me.BtnAddItemEnter.TabIndex = 81
        Me.BtnAddItemEnter.Text = "Enter"
        Me.BtnAddItemEnter.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnClear.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.White
        Me.BtnClear.Location = New System.Drawing.Point(235, 235)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(104, 60)
        Me.BtnClear.TabIndex = 82
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'FormGcashCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(497, 354)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnAddItemEnter)
        Me.Controls.Add(Me.tbGcashRef)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblItemName)
        Me.Controls.Add(Me.BtnAddItemBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormGcashCheck"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAddItemOrder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAddItemBack As Button
    Friend WithEvents LblItemName As Label
    Friend WithEvents tbGcashRef As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAddItemEnter As Button
    Friend WithEvents BtnClear As Button
End Class
