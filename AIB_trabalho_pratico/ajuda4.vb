Public Class ajuda4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Eu penso que a resposta certa seja Kunami")
        Me.Visible = False
        pergunta4.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Eu penso que a resposta certa seja Kunami")
        Me.Visible = False
        pergunta4.Show()
    End Sub

    Private Sub ajuda4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class