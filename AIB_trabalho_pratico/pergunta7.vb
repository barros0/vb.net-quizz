﻿Public Class pergunta7
    Private Sub pergunta7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        My.Computer.Audio.Play(My.Resources._5_Minutos__Música_para_Meditação___Medite_em_5_minutos_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
        Button1.Visible = False
        Button6.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Computer.Audio.Play(My.Resources._5_Minutos__Música_para_Meditação___Medite_em_5_minutos_, AudioPlayMode.BackgroundLoop)
        Button6.Visible = False
        Button1.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Os votos do publico: 50% - DT 50% - KTM do Guilherme")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ajuda7.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Resposta errada :/ Tenta para a proxima")
        resultados.Show()
        Me.Visible = False
        pontos.Text = 0


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Resposta errada :/ Tenta para a proxima")
        resultados.Show()
        Me.Visible = False
        pontos.Text = 0


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MsgBox("Resposta errada :/ Tenta para a proxima")
        resultados.Show()
        Me.Visible = False
        pontos.Text = 0

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        pontos.Text = 1
        MsgBox("Resposta certa!! Parabéns podes continuar")
        resultados.Show()
        Me.Visible = False
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
End Class