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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButtonCritical = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMajor = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMinor = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(207, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(255, 117)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(51, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selected dimensions are"
        '
        'RadioButtonCritical
        '
        Me.RadioButtonCritical.AutoSize = True
        Me.RadioButtonCritical.Location = New System.Drawing.Point(25, 30)
        Me.RadioButtonCritical.Name = "RadioButtonCritical"
        Me.RadioButtonCritical.Size = New System.Drawing.Size(56, 17)
        Me.RadioButtonCritical.TabIndex = 3
        Me.RadioButtonCritical.TabStop = True
        Me.RadioButtonCritical.Text = "Critical"
        Me.RadioButtonCritical.UseVisualStyleBackColor = True
        '
        'RadioButtonMajor
        '
        Me.RadioButtonMajor.AutoSize = True
        Me.RadioButtonMajor.Location = New System.Drawing.Point(25, 54)
        Me.RadioButtonMajor.Name = "RadioButtonMajor"
        Me.RadioButtonMajor.Size = New System.Drawing.Size(51, 17)
        Me.RadioButtonMajor.TabIndex = 4
        Me.RadioButtonMajor.TabStop = True
        Me.RadioButtonMajor.Text = "Major"
        Me.RadioButtonMajor.UseVisualStyleBackColor = True
        '
        'RadioButtonMinor
        '
        Me.RadioButtonMinor.AutoSize = True
        Me.RadioButtonMinor.Location = New System.Drawing.Point(25, 78)
        Me.RadioButtonMinor.Name = "RadioButtonMinor"
        Me.RadioButtonMinor.Size = New System.Drawing.Size(51, 17)
        Me.RadioButtonMinor.TabIndex = 5
        Me.RadioButtonMinor.TabStop = True
        Me.RadioButtonMinor.Text = "Minor"
        Me.RadioButtonMinor.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 152)
        Me.Controls.Add(Me.RadioButtonMinor)
        Me.Controls.Add(Me.RadioButtonMajor)
        Me.Controls.Add(Me.RadioButtonCritical)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Label dimensions"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButtonCritical As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonMajor As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonMinor As System.Windows.Forms.RadioButton

End Class
