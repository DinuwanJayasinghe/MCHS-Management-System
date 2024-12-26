Public Class F2

    Private Sub F2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TB1.Text = ("Our vision is to embody the fullness of life to serve the needist.")
        TB2.Text = ("We are learning community made up of persons of diifferents background where the holistic devolpmentof each and every child isnurtured in the jesuit tradition.")
    End Sub

    Private Sub CMD_NXT_Click(sender As System.Object, e As System.EventArgs)
        Hide()
        F3.ShowDialog()
    End Sub

    Private Sub CMD_SP_Click(sender As System.Object, e As System.EventArgs) Handles CMD_SP.Click
        F1.Show()
        Hide()
    End Sub

End Class