Public Class F3

    Private Sub CMD_ADMIN_Click(sender As System.Object, e As System.EventArgs) Handles CMD_ADMIN.Click
        Hide()
        F4.ShowDialog()
    End Sub

    Private Sub CMD_PAYMENTS_Click(sender As System.Object, e As System.EventArgs) Handles CMD_PAYMENTS.Click
        Hide()
        F5.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles CMD_TIME.Click
        Hide()
        F6.ShowDialog()
    End Sub

    Private Sub CMDCLOSE_Click(sender As System.Object, e As System.EventArgs) Handles CMDCLOSE.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure to you went to close this program?", vbYesNo, "Close The program")
        If ans = vbYes Then
            End
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Hide()
        F7.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Hide()
        F8.ShowDialog()
    End Sub

    Private Sub CMD_OPEN_Click(sender As System.Object, e As System.EventArgs) Handles CMD_OPEN.Click
        Hide()
        F9.ShowDialog()
    End Sub

    Private Sub CMDOP_Click(sender As System.Object, e As System.EventArgs) Handles CMDOP.Click
        Hide()
        F10.ShowDialog()
    End Sub

    Private Sub CMD_NEXT_Click(sender As System.Object, e As System.EventArgs) Handles CMD_NEXT.Click
        Hide()
        F13.ShowDialog()
    End Sub
End Class