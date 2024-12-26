Public Class F13

    Private Sub CMDCLSE_Click(sender As System.Object, e As System.EventArgs) Handles CMDCLSE.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure to you went toclose this program?", vbYesNo, "Close the program")
        If ans = vbYes Then
            End
        End If
    End Sub

    Private Sub CMDPRE_Click(sender As System.Object, e As System.EventArgs) Handles CMDPRE.Click
        Hide()
        F3.Show()
    End Sub
End Class