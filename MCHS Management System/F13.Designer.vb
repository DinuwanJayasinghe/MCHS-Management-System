<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F13
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F13))
        Me.CMDPRE = New System.Windows.Forms.Button()
        Me.CMDCLSE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CMDPRE
        '
        Me.CMDPRE.BackgroundImage = CType(resources.GetObject("CMDPRE.BackgroundImage"), System.Drawing.Image)
        Me.CMDPRE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDPRE.Location = New System.Drawing.Point(12, 529)
        Me.CMDPRE.Name = "CMDPRE"
        Me.CMDPRE.Size = New System.Drawing.Size(75, 23)
        Me.CMDPRE.TabIndex = 0
        Me.CMDPRE.Text = "<<Previous"
        Me.CMDPRE.UseVisualStyleBackColor = True
        '
        'CMDCLSE
        '
        Me.CMDCLSE.BackgroundImage = CType(resources.GetObject("CMDCLSE.BackgroundImage"), System.Drawing.Image)
        Me.CMDCLSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCLSE.Location = New System.Drawing.Point(361, 529)
        Me.CMDCLSE.Name = "CMDCLSE"
        Me.CMDCLSE.Size = New System.Drawing.Size(75, 23)
        Me.CMDCLSE.TabIndex = 1
        Me.CMDCLSE.Text = "Cancel"
        Me.CMDCLSE.UseVisualStyleBackColor = True
        '
        'F13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.c8a2314b89fc1a0d80e2b37f668509b2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(448, 564)
        Me.Controls.Add(Me.CMDCLSE)
        Me.Controls.Add(Me.CMDPRE)
        Me.MaximizeBox = False
        Me.Name = "F13"
        Me.Text = "College Anthom"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMDPRE As System.Windows.Forms.Button
    Friend WithEvents CMDCLSE As System.Windows.Forms.Button
End Class
