Public Class instrucoes
    Private Sub instrucoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Visible = False
        menujogar.Show()
    End Sub
End Class