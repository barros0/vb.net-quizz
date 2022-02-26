Public Class ajuda7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("A resposta certa é KTM como é obvio")
        Me.Visible = False
        pergunta7.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("A resposta certa é KTM como é obvio")
        Me.Visible = False
        pergunta7.Show()
    End Sub

    Private Sub ajuda7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class