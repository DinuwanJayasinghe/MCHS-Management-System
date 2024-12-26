Public Class F7

    Private Sub TPrizeGivingBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TPrizeGivingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TPrizeGivingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._2016_SEP_MCHSDataSet3)

    End Sub

    Private Sub Form7_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_2016_SEP_MCHSDataSet3.tPrizeGiving' table. You can move, or remove it, as needed.
        Me.TPrizeGivingTableAdapter.Fill(Me._2016_SEP_MCHSDataSet3.tPrizeGiving)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles CMDPRE.Click
        F3.Show()
        Hide()
    End Sub

    Private Sub CMDCLOSE_Click(sender As System.Object, e As System.EventArgs) Handles CMDCLOSE.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure to you went to close this program?", vbYesNo, "Close The program")
        If ans = vbYes Then
            End
        End If
    End Sub
End Class