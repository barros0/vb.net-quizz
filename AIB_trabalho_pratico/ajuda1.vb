Public Class ajuda1
    Private Sub ajuda1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Eu penso que a resposta certa seja Mecânica e Roubo")
        Me.Visible = False
        pergunta1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Eu penso que a resposta certa seja Mecânica")
        Me.Visible = False
        pergunta1.Show()
    End Sub
End Class