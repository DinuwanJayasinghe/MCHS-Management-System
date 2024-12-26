Public Class F1
    Private Sub CMD2_Click(sender As System.Object, e As System.EventArgs) Handles CMD2.Click
        Hide()
        F2.ShowDialog()
    End Sub

    Private Sub CMD1_Click(sender As System.Object, e As System.EventArgs) Handles CMD1.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure to you went to close this program?", vbYesNo, "Close The program")
        If ans = vbYes Then
            End
        End If
    End Sub
End Class
