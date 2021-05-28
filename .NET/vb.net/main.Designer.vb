<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmMain
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
        Me.lbInfo = New System.Windows.Forms.ListBox()
        Me.btGetErrorInfo = New System.Windows.Forms.Button()
        Me.cbUseLocalFile = New System.Windows.Forms.CheckBox()
        Me.edErrorValue = New System.Windows.Forms.TextBox()
        Me.laErrorValue = New System.Windows.Forms.Label()
        Me.laTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbInfo
        '
        Me.lbInfo.FormattingEnabled = True
        Me.lbInfo.Location = New System.Drawing.Point(12, 93)
        Me.lbInfo.Name = "lbInfo"
        Me.lbInfo.Size = New System.Drawing.Size(382, 329)
        Me.lbInfo.TabIndex = 11
        '
        'btGetErrorInfo
        '
        Me.btGetErrorInfo.Location = New System.Drawing.Point(299, 64)
        Me.btGetErrorInfo.Name = "btGetErrorInfo"
        Me.btGetErrorInfo.Size = New System.Drawing.Size(95, 23)
        Me.btGetErrorInfo.TabIndex = 10
        Me.btGetErrorInfo.Text = "Get Error Info"
        Me.btGetErrorInfo.UseVisualStyleBackColor = True
        '
        'cbUseLocalFile
        '
        Me.cbUseLocalFile.AutoSize = True
        Me.cbUseLocalFile.Location = New System.Drawing.Point(203, 41)
        Me.cbUseLocalFile.Name = "cbUseLocalFile"
        Me.cbUseLocalFile.Size = New System.Drawing.Size(86, 17)
        Me.cbUseLocalFile.TabIndex = 9
        Me.cbUseLocalFile.Text = "Use local file"
        Me.cbUseLocalFile.UseVisualStyleBackColor = True
        '
        'edErrorValue
        '
        Me.edErrorValue.Location = New System.Drawing.Point(79, 39)
        Me.edErrorValue.Name = "edErrorValue"
        Me.edErrorValue.Size = New System.Drawing.Size(107, 20)
        Me.edErrorValue.TabIndex = 8
        Me.edErrorValue.Text = "0x00000000"
        '
        'laErrorValue
        '
        Me.laErrorValue.AutoSize = True
        Me.laErrorValue.Location = New System.Drawing.Point(12, 42)
        Me.laErrorValue.Name = "laErrorValue"
        Me.laErrorValue.Size = New System.Drawing.Size(61, 13)
        Me.laErrorValue.TabIndex = 7
        Me.laErrorValue.Text = "Error value:"
        '
        'laTitle
        '
        Me.laTitle.AutoSize = True
        Me.laTitle.Location = New System.Drawing.Point(12, 9)
        Me.laTitle.Name = "laTitle"
        Me.laTitle.Size = New System.Drawing.Size(382, 13)
        Me.laTitle.TabIndex = 6
        Me.laTitle.Text = "Enter error code in HEX or DEC in the Edit Box below. HEX should start with 0x."
        '
        'fmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 434)
        Me.Controls.Add(Me.lbInfo)
        Me.Controls.Add(Me.btGetErrorInfo)
        Me.Controls.Add(Me.cbUseLocalFile)
        Me.Controls.Add(Me.edErrorValue)
        Me.Controls.Add(Me.laErrorValue)
        Me.Controls.Add(Me.laTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "fmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Get WCL Error Infor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lbInfo As ListBox
    Private WithEvents btGetErrorInfo As Button
    Private WithEvents cbUseLocalFile As CheckBox
    Private WithEvents edErrorValue As TextBox
    Private WithEvents laErrorValue As Label
    Private WithEvents laTitle As Label
End Class
