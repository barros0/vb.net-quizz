﻿Public Class pergunta2
    Private Sub pergunta2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        My.Computer.Audio.Play(My.Resources._5_Minutos__Música_para_Meditação___Medite_em_5_minutos_, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Computer.Audio.Play(My.Resources._5_Minutos__Música_para_Meditação___Medite_em_5_minutos_, AudioPlayMode.BackgroundLoop)
        Button6.Visible = False
        Button1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
        Button1.Visible = False
        Button6.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim ask As MsgBoxResult = MsgBox("Tem a certeza que quer sair?? Vai perder o progresso todo", MsgBoxStyle.YesNo, "Exit")
        If ask = MsgBoxResult.Yes Then
            menujogar.Show()
            Me.Visible = False
        Else
            MsgBox("Ok, Continue a jogar", MsgBoxStyle.OkCancel, "Exit")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Os votos do publico: 11% - kebabs 20% - ibis 69% - mundial 0% - roma")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ajuda2.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Resposta errada :/ Tenta para a proxima")
        pergunta3.Show()
        Me.Visible = False
        pontos.Text = 0
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        pontos.Text = 1
        MsgBox("Resposta certa!! Parabéns podes continuar")
        pergunta3.Show()

        Me.Visible = False

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MsgBox("Resposta errada :/ Tenta para a proxima")
        pergunta3.show()
        Me.Visible = False
        pontos.Text = 0
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MsgBox("Resposta errada :/ Tenta para a proxima")
        pergunta3.show()
        Me.Visible = False
        pontos.Text = 0
    End Sub
End Class