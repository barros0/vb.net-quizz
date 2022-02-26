Public Class opcoes
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Visible = False
        menujogar.Show()
    End Sub

    Private Sub opcoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class