Public Class ajuda6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Mekie miguinho, claro que a resposta é droga ! Força nisso pinguim")
        Me.Visible = False
        pergunta6.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Eu penso que a resposta certa seja droga")
        Me.Visible = False
        pergunta6.Show()
    End Sub

    Private Sub ajuda6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub
End Class