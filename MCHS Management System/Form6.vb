Public Class F6

    Private Sub TTimeChartBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TTimeChartBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TTimeChartBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._2016_SEP_MCHSDataSet2)

    End Sub

    Private Sub F6_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_2016_SEP_MCHSDataSet2.tTimeChart' table. You can move, or remove it, as needed.
        Me.TTimeChartTableAdapter.Fill(Me._2016_SEP_MCHSDataSet2.tTimeChart)

    End Sub

    Private Sub CMD_PRE_Click(sender As System.Object, e As System.EventArgs) Handles CMD_PRE.Click
        F3.Show()
        Hide()
    End Sub

    Private Sub CMD_CLOSE_Click(sender As System.Object, e As System.EventArgs) Handles CMD_CLOSE.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure to you went to close this program?", vbYesNo, "Close The program")
        If ans = vbYes Then
            End
        End If
    End Sub
End Class