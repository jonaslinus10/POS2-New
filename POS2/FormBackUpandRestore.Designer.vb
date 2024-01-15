<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBackupAndRestore
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBackUp = New System.Windows.Forms.Button()
        Me.BtnRestore = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(29, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(447, 60)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Back up and Restore"
        '
        'BtnBackUp
        '
        Me.BtnBackUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnBackUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBackUp.FlatAppearance.BorderSize = 0
        Me.BtnBackUp.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBackUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnBackUp.Location = New System.Drawing.Point(372, 291)
        Me.BtnBackUp.Margin = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.BtnBackUp.Name = "BtnBackUp"
        Me.BtnBackUp.Size = New System.Drawing.Size(195, 70)
        Me.BtnBackUp.TabIndex = 75
        Me.BtnBackUp.Text = "Backup Data"
        Me.BtnBackUp.UseVisualStyleBackColor = False
        '
        'BtnRestore
        '
        Me.BtnRestore.BackColor = System.Drawing.Color.DarkRed
        Me.BtnRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestore.FlatAppearance.BorderSize = 0
        Me.BtnRestore.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnRestore.ForeColor = System.Drawing.Color.White
        Me.BtnRestore.Location = New System.Drawing.Point(577, 291)
        Me.BtnRestore.Margin = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.BtnRestore.Name = "BtnRestore"
        Me.BtnRestore.Size = New System.Drawing.Size(195, 70)
        Me.BtnRestore.TabIndex = 77
        Me.BtnRestore.Text = "Restore"
        Me.BtnRestore.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(227, 259)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(696, 24)
        Me.ComboBox1.TabIndex = 74
        '
        'FormBackupAndRestore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1148, 625)
        Me.Controls.Add(Me.BtnRestore)
        Me.Controls.Add(Me.BtnBackUp)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormBackupAndRestore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBackupAndRestore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBackUp As Button
    Friend WithEvents BtnRestore As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
