<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listDevicesAll
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
        Me.prgBar = New System.Windows.Forms.ProgressBar()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.txtApiKey = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'prgBar
        '
        Me.prgBar.Location = New System.Drawing.Point(15, 56)
        Me.prgBar.MarqueeAnimationSpeed = 10
        Me.prgBar.Name = "prgBar"
        Me.prgBar.Size = New System.Drawing.Size(189, 27)
        Me.prgBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.prgBar.TabIndex = 23
        Me.prgBar.Visible = False
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(15, 89)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtResult.Size = New System.Drawing.Size(407, 229)
        Me.txtResult.TabIndex = 22
        Me.txtResult.Text = "Result Window"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(210, 56)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 27)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnViewAll
        '
        Me.btnViewAll.Location = New System.Drawing.Point(303, 56)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(119, 27)
        Me.btnViewAll.TabIndex = 18
        Me.btnViewAll.Text = "View All Devices"
        Me.btnViewAll.UseVisualStyleBackColor = True
        '
        'txtApiKey
        '
        Me.txtApiKey.Location = New System.Drawing.Point(15, 27)
        Me.txtApiKey.MaxLength = 50
        Me.txtApiKey.Name = "txtApiKey"
        Me.txtApiKey.Size = New System.Drawing.Size(407, 23)
        Me.txtApiKey.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 15)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "API Key"
        '
        'listDevicesAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 332)
        Me.Controls.Add(Me.txtApiKey)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.prgBar)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnViewAll)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "listDevicesAll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View All Devices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents prgBar As System.Windows.Forms.ProgressBar
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnViewAll As System.Windows.Forms.Button
    Friend WithEvents txtApiKey As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
