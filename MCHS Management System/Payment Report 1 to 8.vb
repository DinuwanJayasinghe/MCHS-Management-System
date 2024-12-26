Public Class F11

    Private Sub F11_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_2016_SEP_MCHSDataSet6.qPayments4Repo1to8' table. You can move, or remove it, as needed.
        Me.QPayments4Repo1to8TableAdapter.Fill(Me._2016_SEP_MCHSDataSet6.qPayments4Repo1to8)

    End Sub

    Private Sub CMDPR_Click(sender As System.Object, e As System.EventArgs) Handles CMDPR.Click
        Hide()
        F3.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles CMDCL.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure to you went to close this program?", vbYesNo, "Close The program")
        If ans = vbYes Then
            End
        End If
    End Sub
End Class