<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Screen = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.VelocityMeter = New System.Windows.Forms.Label()
        Me.Meter = New System.Windows.Forms.Label()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.EngineOnButton = New System.Windows.Forms.Button()
        Me.EngineOffButton = New System.Windows.Forms.Button()
        CType(Me.Screen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Screen
        '
        Me.Screen.BackColor = System.Drawing.SystemColors.Control
        Me.Screen.Location = New System.Drawing.Point(12, 12)
        Me.Screen.Name = "Screen"
        Me.Screen.Size = New System.Drawing.Size(1240, 585)
        Me.Screen.TabIndex = 0
        Me.Screen.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'StartButton
        '
        Me.StartButton.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.Location = New System.Drawing.Point(12, 605)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(87, 29)
        Me.StartButton.TabIndex = 1
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopButton.Location = New System.Drawing.Point(105, 605)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(87, 29)
        Me.StopButton.TabIndex = 2
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(1165, 640)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(87, 29)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'VelocityMeter
        '
        Me.VelocityMeter.AutoSize = True
        Me.VelocityMeter.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VelocityMeter.Location = New System.Drawing.Point(198, 614)
        Me.VelocityMeter.Name = "VelocityMeter"
        Me.VelocityMeter.Size = New System.Drawing.Size(75, 11)
        Me.VelocityMeter.TabIndex = 4
        Me.VelocityMeter.Text = "Velocity: "
        '
        'Meter
        '
        Me.Meter.AutoSize = True
        Me.Meter.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Meter.Location = New System.Drawing.Point(279, 614)
        Me.Meter.Name = "Meter"
        Me.Meter.Size = New System.Drawing.Size(12, 11)
        Me.Meter.TabIndex = 5
        Me.Meter.Text = "0"
        '
        'ResetButton
        '
        Me.ResetButton.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.Location = New System.Drawing.Point(12, 640)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(87, 29)
        Me.ResetButton.TabIndex = 6
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'EngineOnButton
        '
        Me.EngineOnButton.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EngineOnButton.Location = New System.Drawing.Point(334, 614)
        Me.EngineOnButton.Name = "EngineOnButton"
        Me.EngineOnButton.Size = New System.Drawing.Size(104, 19)
        Me.EngineOnButton.TabIndex = 7
        Me.EngineOnButton.Text = "Engine On"
        Me.EngineOnButton.UseVisualStyleBackColor = True
        '
        'EngineOffButton
        '
        Me.EngineOffButton.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EngineOffButton.Location = New System.Drawing.Point(334, 639)
        Me.EngineOffButton.Name = "EngineOffButton"
        Me.EngineOffButton.Size = New System.Drawing.Size(104, 19)
        Me.EngineOffButton.TabIndex = 8
        Me.EngineOffButton.Text = "Engine Off"
        Me.EngineOffButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.EngineOffButton)
        Me.Controls.Add(Me.EngineOnButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.Meter)
        Me.Controls.Add(Me.VelocityMeter)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.Screen)
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "SpaceLander"
        CType(Me.Screen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Screen As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents VelocityMeter As Label
    Friend WithEvents Meter As Label
    Friend WithEvents ResetButton As Button
    Friend WithEvents EngineOnButton As Button
    Friend WithEvents EngineOffButton As Button
End Class
