<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateDevice
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
        Me.btnCreateDevice = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMyIp = New System.Windows.Forms.TextBox()
        Me.txtApiKey = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDeviceMan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDeviceModel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDeviceFirmware = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.prgBar = New System.Windows.Forms.ProgressBar()
        Me.txtDeviceName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDeviceID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCreateDevice
        '
        Me.btnCreateDevice.Location = New System.Drawing.Point(317, 320)
        Me.btnCreateDevice.Name = "btnCreateDevice"
        Me.btnCreateDevice.Size = New System.Drawing.Size(107, 27)
        Me.btnCreateDevice.TabIndex = 6
        Me.btnCreateDevice.Text = "Update Device"
        Me.btnCreateDevice.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IP Address"
        '
        'txtMyIp
        '
        Me.txtMyIp.Location = New System.Drawing.Point(17, 247)
        Me.txtMyIp.MaxLength = 15
        Me.txtMyIp.Name = "txtMyIp"
        Me.txtMyIp.Size = New System.Drawing.Size(194, 23)
        Me.txtMyIp.TabIndex = 4
        Me.txtMyIp.Text = "127.0.0.1"
        '
        'txtApiKey
        '
        Me.txtApiKey.Location = New System.Drawing.Point(17, 27)
        Me.txtApiKey.MaxLength = 50
        Me.txtApiKey.Name = "txtApiKey"
        Me.txtApiKey.Size = New System.Drawing.Size(407, 23)
        Me.txtApiKey.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "API Key"
        '
        'txtDeviceMan
        '
        Me.txtDeviceMan.Location = New System.Drawing.Point(17, 115)
        Me.txtDeviceMan.MaxLength = 50
        Me.txtDeviceMan.Name = "txtDeviceMan"
        Me.txtDeviceMan.Size = New System.Drawing.Size(407, 23)
        Me.txtDeviceMan.TabIndex = 1
        Me.txtDeviceMan.Text = "Test Manufacturer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Device Manufacturer"
        '
        'txtDeviceModel
        '
        Me.txtDeviceModel.Location = New System.Drawing.Point(17, 159)
        Me.txtDeviceModel.MaxLength = 50
        Me.txtDeviceModel.Name = "txtDeviceModel"
        Me.txtDeviceModel.Size = New System.Drawing.Size(407, 23)
        Me.txtDeviceModel.TabIndex = 2
        Me.txtDeviceModel.Text = "Test Model"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Device Model"
        '
        'txtDeviceFirmware
        '
        Me.txtDeviceFirmware.Location = New System.Drawing.Point(17, 203)
        Me.txtDeviceFirmware.MaxLength = 50
        Me.txtDeviceFirmware.Name = "txtDeviceFirmware"
        Me.txtDeviceFirmware.Size = New System.Drawing.Size(407, 23)
        Me.txtDeviceFirmware.TabIndex = 3
        Me.txtDeviceFirmware.Text = "1.0.0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Device Firmware Version"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(224, 320)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 27)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(17, 353)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtResult.Size = New System.Drawing.Size(407, 125)
        Me.txtResult.TabIndex = 16
        Me.txtResult.Text = "Result Window"
        '
        'prgBar
        '
        Me.prgBar.Location = New System.Drawing.Point(17, 320)
        Me.prgBar.MarqueeAnimationSpeed = 10
        Me.prgBar.Name = "prgBar"
        Me.prgBar.Size = New System.Drawing.Size(201, 27)
        Me.prgBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.prgBar.TabIndex = 17
        Me.prgBar.Visible = False
        '
        'txtDeviceName
        '
        Me.txtDeviceName.Location = New System.Drawing.Point(17, 291)
        Me.txtDeviceName.MaxLength = 50
        Me.txtDeviceName.Name = "txtDeviceName"
        Me.txtDeviceName.Size = New System.Drawing.Size(407, 23)
        Me.txtDeviceName.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Device Name:"
        '
        'txtDeviceID
        '
        Me.txtDeviceID.Location = New System.Drawing.Point(17, 71)
        Me.txtDeviceID.MaxLength = 50
        Me.txtDeviceID.Name = "txtDeviceID"
        Me.txtDeviceID.Size = New System.Drawing.Size(407, 23)
        Me.txtDeviceID.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Device ID:"
        '
        'updateDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 492)
        Me.Controls.Add(Me.txtDeviceID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDeviceName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.prgBar)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtDeviceFirmware)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDeviceModel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDeviceMan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtApiKey)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMyIp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCreateDevice)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "updateDevice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DNS Update"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreateDevice As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMyIp As System.Windows.Forms.TextBox
    Friend WithEvents txtApiKey As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDeviceMan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDeviceModel As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDeviceFirmware As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents prgBar As System.Windows.Forms.ProgressBar
    Friend WithEvents txtDeviceName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDeviceID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
