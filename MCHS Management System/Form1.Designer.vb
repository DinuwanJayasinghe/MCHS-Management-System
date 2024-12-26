<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1))
        Me.CMD2 = New System.Windows.Forms.Button()
        Me.CMD1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CMD2
        '
        Me.CMD2.BackgroundImage = CType(resources.GetObject("CMD2.BackgroundImage"), System.Drawing.Image)
        Me.CMD2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMD2.Location = New System.Drawing.Point(724, 481)
        Me.CMD2.Name = "CMD2"
        Me.CMD2.Size = New System.Drawing.Size(75, 23)
        Me.CMD2.TabIndex = 0
        Me.CMD2.Text = "Start"
        Me.CMD2.UseVisualStyleBackColor = True
        '
        'CMD1
        '
        Me.CMD1.BackgroundImage = CType(resources.GetObject("CMD1.BackgroundImage"), System.Drawing.Image)
        Me.CMD1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMD1.Location = New System.Drawing.Point(12, 481)
        Me.CMD1.Name = "CMD1"
        Me.CMD1.Size = New System.Drawing.Size(75, 23)
        Me.CMD1.TabIndex = 0
        Me.CMD1.Text = "Close"
        Me.CMD1.UseVisualStyleBackColor = True
        '
        'F1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Untitled
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(811, 516)
        Me.Controls.Add(Me.CMD1)
        Me.Controls.Add(Me.CMD2)
        Me.MaximizeBox = False
        Me.Name = "F1"
        Me.Text = "MCHS Management System"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMD2 As System.Windows.Forms.Button
    Friend WithEvents CMD1 As System.Windows.Forms.Button

End Class
