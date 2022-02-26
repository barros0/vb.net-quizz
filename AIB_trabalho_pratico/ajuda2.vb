Public Class ajuda2
    Private Sub ajuda2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox("Eu penso que a resposta certa seja Mundial")
        Me.Visible = False
        pergunta2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Eu penso que a resposta certa seja Kebabs")
        Me.Visible = False
        pergunta2.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Eu penso que a resposta certa seja Mundial")
        Me.Visible = False
        pergunta2.Show()
    End Sub
End Class