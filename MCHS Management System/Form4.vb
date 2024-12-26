Public Class F4

    Private Sub Copy_Of_tMchsAdmissionsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Copy_Of_tMchsAdmissionsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Copy_Of_tMchsAdmissionsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._2016_SEP_MCHSDataSet)

    End Sub

    Private Sub F4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_2016_SEP_MCHSDataSet.Copy_Of_tMchsAdmissions' table. You can move, or remove it, as needed.
        Me.Copy_Of_tMchsAdmissionsTableAdapter.Fill(Me._2016_SEP_MCHSDataSet.Copy_Of_tMchsAdmissions)

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