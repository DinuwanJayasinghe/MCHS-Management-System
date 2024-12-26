Public Class F8

    Private Sub F8_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_2016_SEP_MCHSDataSet4.qInfoAll' table. You can move, or remove it, as needed.
        Me.QInfoAllTableAdapter.Fill(Me._2016_SEP_MCHSDataSet4.qInfoAll)

    End Sub

    Private Sub CMD_CLOSE_Click(sender As System.Object, e As System.EventArgs) Handles CMD_CLOSE.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure to you went to close this program?", vbYesNo, "Close The program")
        If ans = vbYes Then
            End
        End If
    End Sub

    Private Sub CMD_PRE_Click(sender As System.Object, e As System.EventArgs) Handles CMD_PRE.Click
        F3.Show()
        Hide()
    End Sub
End Class