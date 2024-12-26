Public Class F9

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

    Private Sub F9_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_2016_SEP_MCHSDataSet5.qLeftStudents' table. You can move, or remove it, as needed.
        Me.QLeftStudentsTableAdapter.Fill(Me._2016_SEP_MCHSDataSet5.qLeftStudents)

    End Sub
End Class