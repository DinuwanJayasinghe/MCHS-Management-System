Public Class F12

    Private Sub F12_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_2016_SEP_MCHSDataSet7.qRegistrationFee' table. You can move, or remove it, as needed.
        Me.QRegistrationFeeTableAdapter.Fill(Me._2016_SEP_MCHSDataSet7.qRegistrationFee)

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