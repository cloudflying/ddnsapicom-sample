<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnDNSUpdate = New System.Windows.Forms.Button()
        Me.btnNewDevice = New System.Windows.Forms.Button()
        Me.btnAllDevices = New System.Windows.Forms.Button()
        Me.btnDeviceLookup = New System.Windows.Forms.Button()
        Me.btnIPLookup = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDNSUpdate
        '
        Me.btnDNSUpdate.Location = New System.Drawing.Point(12, 12)
        Me.btnDNSUpdate.Name = "btnDNSUpdate"
        Me.btnDNSUpdate.Size = New System.Drawing.Size(186, 23)
        Me.btnDNSUpdate.TabIndex = 0
        Me.btnDNSUpdate.Text = "Simulate DNS update"
        Me.btnDNSUpdate.UseVisualStyleBackColor = True
        '
        'btnNewDevice
        '
        Me.btnNewDevice.Location = New System.Drawing.Point(12, 41)
        Me.btnNewDevice.Name = "btnNewDevice"
        Me.btnNewDevice.Size = New System.Drawing.Size(186, 23)
        Me.btnNewDevice.TabIndex = 1
        Me.btnNewDevice.Text = "Create New Device"
        Me.btnNewDevice.UseVisualStyleBackColor = True
        '
        'btnAllDevices
        '
        Me.btnAllDevices.Location = New System.Drawing.Point(12, 70)
        Me.btnAllDevices.Name = "btnAllDevices"
        Me.btnAllDevices.Size = New System.Drawing.Size(186, 23)
        Me.btnAllDevices.TabIndex = 2
        Me.btnAllDevices.Text = "View All Devices"
        Me.btnAllDevices.UseVisualStyleBackColor = True
        '
        'btnDeviceLookup
        '
        Me.btnDeviceLookup.Location = New System.Drawing.Point(12, 99)
        Me.btnDeviceLookup.Name = "btnDeviceLookup"
        Me.btnDeviceLookup.Size = New System.Drawing.Size(186, 23)
        Me.btnDeviceLookup.TabIndex = 3
        Me.btnDeviceLookup.Text = "View Individual Device (Device ID)"
        Me.btnDeviceLookup.UseVisualStyleBackColor = True
        '
        'btnIPLookup
        '
        Me.btnIPLookup.Location = New System.Drawing.Point(12, 128)
        Me.btnIPLookup.Name = "btnIPLookup"
        Me.btnIPLookup.Size = New System.Drawing.Size(186, 23)
        Me.btnIPLookup.TabIndex = 4
        Me.btnIPLookup.Text = "View Individual Device (IP Lookup)"
        Me.btnIPLookup.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 253)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(186, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 288)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnIPLookup)
        Me.Controls.Add(Me.btnDeviceLookup)
        Me.Controls.Add(Me.btnAllDevices)
        Me.Controls.Add(Me.btnNewDevice)
        Me.Controls.Add(Me.btnDNSUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DDNSAPI.COM SAMPLE"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDNSUpdate As System.Windows.Forms.Button
    Friend WithEvents btnNewDevice As System.Windows.Forms.Button
    Friend WithEvents btnAllDevices As System.Windows.Forms.Button
    Friend WithEvents btnDeviceLookup As System.Windows.Forms.Button
    Friend WithEvents btnIPLookup As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
