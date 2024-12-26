<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F2
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
        Dim CMD_NXT As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F2))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TB1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TB2 = New System.Windows.Forms.TextBox()
        Me.CMD_SP = New System.Windows.Forms.Button()
        CMD_NXT = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CMD_NXT
        '
        CMD_NXT.BackgroundImage = CType(resources.GetObject("CMD_NXT.BackgroundImage"), System.Drawing.Image)
        CMD_NXT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        CMD_NXT.ForeColor = System.Drawing.Color.Black
        CMD_NXT.Location = New System.Drawing.Point(759, 576)
        CMD_NXT.Name = "CMD_NXT"
        CMD_NXT.Size = New System.Drawing.Size(75, 23)
        CMD_NXT.TabIndex = 0
        CMD_NXT.Text = "Next"
        CMD_NXT.UseVisualStyleBackColor = True
        AddHandler CMD_NXT.Click, AddressOf Me.CMD_NXT_Click
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.TB1)
        Me.GroupBox1.Font = New System.Drawing.Font("Candara", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(836, 182)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vision :-"
        '
        'TB1
        '
        Me.TB1.BackColor = System.Drawing.SystemColors.Control
        Me.TB1.Enabled = False
        Me.TB1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB1.ForeColor = System.Drawing.Color.Black
        Me.TB1.Location = New System.Drawing.Point(15, 28)
        Me.TB1.Multiline = True
        Me.TB1.Name = "TB1"
        Me.TB1.ReadOnly = True
        Me.TB1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TB1.Size = New System.Drawing.Size(803, 137)
        Me.TB1.TabIndex = 2
        Me.TB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.TB2)
        Me.GroupBox2.Font = New System.Drawing.Font("Candara", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 221)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(836, 349)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mission :-"
        '
        'TB2
        '
        Me.TB2.BackColor = System.Drawing.SystemColors.Control
        Me.TB2.Enabled = False
        Me.TB2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB2.ForeColor = System.Drawing.Color.Black
        Me.TB2.Location = New System.Drawing.Point(15, 28)
        Me.TB2.Multiline = True
        Me.TB2.Name = "TB2"
        Me.TB2.ReadOnly = True
        Me.TB2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TB2.Size = New System.Drawing.Size(803, 304)
        Me.TB2.TabIndex = 2
        Me.TB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CMD_SP
        '
        Me.CMD_SP.BackgroundImage = CType(resources.GetObject("CMD_SP.BackgroundImage"), System.Drawing.Image)
        Me.CMD_SP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMD_SP.ForeColor = System.Drawing.Color.Black
        Me.CMD_SP.Location = New System.Drawing.Point(27, 576)
        Me.CMD_SP.Name = "CMD_SP"
        Me.CMD_SP.Size = New System.Drawing.Size(75, 23)
        Me.CMD_SP.TabIndex = 2
        Me.CMD_SP.Text = "Start Page"
        Me.CMD_SP.UseVisualStyleBackColor = True
        '
        'F2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(846, 604)
        Me.Controls.Add(Me.CMD_SP)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(CMD_NXT)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MaximizeBox = False
        Me.Name = "F2"
        Me.Text = "College vision & mission"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TB1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TB2 As System.Windows.Forms.TextBox
    Friend WithEvents CMD_SP As System.Windows.Forms.Button
End Class
