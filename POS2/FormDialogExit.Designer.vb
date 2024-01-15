<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDialogExit
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
        Me.BtnExitDialogCancel = New System.Windows.Forms.Button()
        Me.BtnExitDialogConfirm = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnExitDialogCancel
        '
        Me.BtnExitDialogCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.BtnExitDialogCancel.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnExitDialogCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnExitDialogCancel.Location = New System.Drawing.Point(306, 179)
        Me.BtnExitDialogCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExitDialogCancel.Name = "BtnExitDialogCancel"
        Me.BtnExitDialogCancel.Size = New System.Drawing.Size(142, 55)
        Me.BtnExitDialogCancel.TabIndex = 0
        Me.BtnExitDialogCancel.Text = "Cancel"
        Me.BtnExitDialogCancel.UseVisualStyleBackColor = False
        '
        'BtnExitDialogConfirm
        '
        Me.BtnExitDialogConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnExitDialogConfirm.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnExitDialogConfirm.Location = New System.Drawing.Point(128, 179)
        Me.BtnExitDialogConfirm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExitDialogConfirm.Name = "BtnExitDialogConfirm"
        Me.BtnExitDialogConfirm.Size = New System.Drawing.Size(142, 55)
        Me.BtnExitDialogConfirm.TabIndex = 1
        Me.BtnExitDialogConfirm.Text = "Confirm"
        Me.BtnExitDialogConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnExitDialogConfirm.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(23, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 45)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Confirmation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 64)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Do you want to logout" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your account?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormDialogExit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(540, 265)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnExitDialogConfirm)
        Me.Controls.Add(Me.BtnExitDialogCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormDialogExit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDialogExit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExitDialogCancel As Button
    Friend WithEvents BtnExitDialogConfirm As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
