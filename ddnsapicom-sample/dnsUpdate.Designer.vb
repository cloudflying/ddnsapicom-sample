<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dnsUpdate
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
        Me.btnUpdateDNS = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMyIp = New System.Windows.Forms.TextBox()
        Me.txtHostName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApiUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.SuspendLayout()
        '
        'btnUpdateDNS
        '
        Me.btnUpdateDNS.Location = New System.Drawing.Point(337, 321)
        Me.btnUpdateDNS.Name = "btnUpdateDNS"
        Me.btnUpdateDNS.Size = New System.Drawing.Size(87, 27)
        Me.btnUpdateDNS.TabIndex = 0
        Me.btnUpdateDNS.Text = "Update DNS"
        Me.btnUpdateDNS.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IP Address"
        '
        'txtMyIp
        '
        Me.txtMyIp.Location = New System.Drawing.Point(17, 28)
        Me.txtMyIp.MaxLength = 15
        Me.txtMyIp.Name = "txtMyIp"
        Me.txtMyIp.Size = New System.Drawing.Size(194, 23)
        Me.txtMyIp.TabIndex = 2
        '
        'txtHostName
        '
        Me.txtHostName.Location = New System.Drawing.Point(17, 72)
        Me.txtHostName.MaxLength = 300
        Me.txtHostName.Name = "txtHostName"
        Me.txtHostName.Size = New System.Drawing.Size(407, 23)
        Me.txtHostName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "HostName: {host}.syncroot.ddnsapi.com"
        '
        'txtApiUsername
        '
        Me.txtApiUsername.Location = New System.Drawing.Point(17, 116)
        Me.txtApiUsername.MaxLength = 300
        Me.txtApiUsername.Name = "txtApiUsername"
        Me.txtApiUsername.ReadOnly = True
        Me.txtApiUsername.Size = New System.Drawing.Size(407, 23)
        Me.txtApiUsername.TabIndex = 6
        Me.txtApiUsername.Text = "updapi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DNS Update Username"
        '
        'txtApiKey
        '
        Me.txtApiKey.Location = New System.Drawing.Point(17, 160)
        Me.txtApiKey.MaxLength = 50
        Me.txtApiKey.Name = "txtApiKey"
        Me.txtApiKey.Size = New System.Drawing.Size(407, 23)
        Me.txtApiKey.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "API Key"
        '
        'txtDeviceMan
        '
        Me.txtDeviceMan.Location = New System.Drawing.Point(17, 204)
        Me.txtDeviceMan.MaxLength = 50
        Me.txtDeviceMan.Name = "txtDeviceMan"
        Me.txtDeviceMan.Size = New System.Drawing.Size(407, 23)
        Me.txtDeviceMan.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Device Manufacturer"
        '
        'txtDeviceModel
        '
        Me.txtDeviceModel.Location = New System.Drawing.Point(17, 248)
        Me.txtDeviceModel.MaxLength = 50
        Me.txtDeviceModel.Name = "txtDeviceModel"
        Me.txtDeviceModel.Size = New System.Drawing.Size(407, 23)
        Me.txtDeviceModel.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Device Model"
        '
        'txtDeviceFirmware
        '
        Me.txtDeviceFirmware.Location = New System.Drawing.Point(17, 292)
        Me.txtDeviceFirmware.MaxLength = 50
        Me.txtDeviceFirmware.Name = "txtDeviceFirmware"
        Me.txtDeviceFirmware.Size = New System.Drawing.Size(407, 23)
        Me.txtDeviceFirmware.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Device Firmware Version"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(244, 321)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 27)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(17, 358)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(407, 76)
        Me.txtResult.TabIndex = 16
        Me.txtResult.Text = "Result Window"
        '
        'prgBar
        '
        Me.prgBar.Location = New System.Drawing.Point(17, 321)
        Me.prgBar.MarqueeAnimationSpeed = 10
        Me.prgBar.Name = "prgBar"
        Me.prgBar.Size = New System.Drawing.Size(223, 27)
        Me.prgBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.prgBar.TabIndex = 17
        Me.prgBar.Visible = False
        '
        'dnsUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 446)
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
        Me.Controls.Add(Me.txtApiUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHostName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMyIp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpdateDNS)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dnsUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DNS Update"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdateDNS As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMyIp As System.Windows.Forms.TextBox
    Friend WithEvents txtHostName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtApiUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
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
End Class
