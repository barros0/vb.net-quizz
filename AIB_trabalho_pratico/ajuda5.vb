Public Class ajuda5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Eu penso que a resposta certa seja Sofrer golo")
        Me.Visible = False
        pergunta5.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Eu penso que a resposta certa seja Tentar fazer cueca")
        Me.Visible = False
        pergunta5.Show()
    End Sub

    Private Sub ajuda5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class