Public Class F10

    Private Sub F10_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_2016_SEP_MCHSDataSet6.qPayments4Repo1to8' table. You can move, or remove it, as needed.
        Me.QPayments4Repo1to8TableAdapter.Fill(Me._2016_SEP_MCHSDataSet6.qPayments4Repo1to8)
        'TODO: This line of code loads data into the '_2016_SEP_MCHSDataSet6.qPayments4Reports' table. You can move, or remove it, as needed.
        Me.QPayments4ReportsTableAdapter.Fill(Me._2016_SEP_MCHSDataSet6.qPayments4Reports)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.QPayments4Repo1to8TableAdapter.FillBy(Me._2016_SEP_MCHSDataSet6.qPayments4Repo1to8)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles TSB1.Click
        F11.ShowDialog()
        Hide()
    End Sub

    Private Sub CMDCAN_Click(sender As System.Object, e As System.EventArgs) Handles CMDCAN.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure to you went to close this program?", vbYesNo, "Close The program")
        If ans = vbYes Then
            End
        End If
    End Sub

    Private Sub CMDPRE_Click(sender As System.Object, e As System.EventArgs) Handles CMDPRE.Click
        Hide()
        F3.Show()
    End Sub
End Class