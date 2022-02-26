Public Class Inicio
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        My.Computer.Audio.Play(My.Resources._5_Minutos__Música_para_Meditação___Medite_em_5_minutos_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        menujogar.Show()
        Me.Visible = False
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources._5_Minutos__Música_para_Meditação___Medite_em_5_minutos_, AudioPlayMode.BackgroundLoop)
        Button2.Visible = False
        Button3.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Audio.Stop()
        Button3.Visible = False
        Button2.Visible = True
    End Sub
End Class
