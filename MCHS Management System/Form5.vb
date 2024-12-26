Public Class F5

    Private Sub Copy_Of_tPaymentsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Copy_Of_tPaymentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Copy_Of_tPaymentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._2016_SEP_MCHSDataSet1)

    End Sub

    Private Sub F5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_2016_SEP_MCHSDataSet1.Copy_Of_tPayments' table. You can move, or remove it, as needed.
        Me.Copy_Of_tPaymentsTableAdapter.Fill(Me._2016_SEP_MCHSDataSet1.Copy_Of_tPayments)

    End Sub

    Private Sub CMD_PRE_Click(sender As System.Object, e As System.EventArgs) Handles CMD_PRE.Click
        Hide()
        F3.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        F12.ShowDialog()
        Hide()
    End Sub

    Private Sub CMDCL_Click(sender As System.Object, e As System.EventArgs) Handles CMDCL.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure to you went to close this program?", vbYesNo, "Close The program")
        If ans = vbYes Then
            End
        End If
    End Sub
End Class