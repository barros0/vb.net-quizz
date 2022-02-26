Public Class menujogar
    Private Sub menujogar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        My.Computer.Audio.Play(My.Resources._5_Minutos__Música_para_Meditação___Medite_em_5_minutos_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ask As MsgBoxResult = MsgBox("Tem a certeza que quer sair??", MsgBoxStyle.YesNo, "Exit")
        If ask = MsgBoxResult.Yes Then
            End
        Else
            MsgBox("Ok, obrigado por ficar!!", MsgBoxStyle.OkCancel, "Exit")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        registo.show()
        Me.Visible = False
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Visible = False
        Inicio.Show()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        opcoes.Show()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
        instrucoes.Show()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        My.Computer.Audio.Stop()
        Button8.Visible = False
        Button6.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Computer.Audio.Play(My.Resources._5_Minutos__Música_para_Meditação___Medite_em_5_minutos_, AudioPlayMode.BackgroundLoop)
        Button6.Visible = False
        Button8.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Visible = False
        solucoes.show()
        My.Computer.Audio.Stop()
    End Sub
End Class