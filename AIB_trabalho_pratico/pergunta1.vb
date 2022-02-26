Public Class pergunta1
    Dim m As Integer = 0
    Dim s As Integer = 0
    Dim ml As Integer = 0
    Private Sub pergunta1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        My.Computer.Audio.Play(My.Resources._5_Minutos__Música_para_Meditação___Medite_em_5_minutos_, AudioPlayMode.BackgroundLoop)
        Timer1.Interval = 1000
        Timer1.Start()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True And CheckBox4.Checked = True Then
            MessageBox.Show("Está errado, fica para a próxima")
            Me.Visible = False
            pergunta2.Show()
            pontos.Text = 0
        ElseIf CheckBox3.Checked = True And CheckBox4.Checked = True And CheckBox1.Checked = True Then
            MessageBox.Show("Está errado, fica para a próxima")
            Me.Visible = False
            pergunta2.Show()
            pontos.Text = 0
        ElseIf CheckBox3.Checked = True And CheckBox4.Checked = True And CheckBox2.Checked = True Then
            MessageBox.Show("Está errado, fica para a próxima")
            Me.Visible = False
            pergunta2.Show()
            pontos.Text = 0
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.checked Then
            MessageBox.Show("Está errado, fica para a próxima")
            Me.Visible = False
            pergunta2.Show()
            pontos.Text = 0
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox4.checked Then
            MessageBox.Show("Está errado, fica para a próxima")
            Me.Visible = False
            pergunta2.Show()
            pontos.Text = 0
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
            MessageBox.Show("Está errado, fica para a próxima")
            Me.Visible = False
            pergunta2.Show()
            pontos.Text = 0
        ElseIf CheckBox3.Checked = True And CheckBox4.Checked = True Then
            pontos.Text = 1
            MessageBox.Show("Está correto, Parabéns podes continuar")
            Me.Visible = False
            pergunta2.Show()

        ElseIf CheckBox1.Checked = True Then
            MessageBox.Show("Está errado, fica para a próxima")
            Me.Visible = False
            pergunta2.Show()
            pontos.Text = 0
        ElseIf CheckBox2.Checked = True Then
            MessageBox.Show("Está errado, fica para a próxima")
            Me.Visible = False
            pergunta2.Show()
            pontos.Text = 0
        ElseIf CheckBox3.Checked = True Then
            MessageBox.Show("Está errado, fica para a próxima")
            Me.Visible = False
            pergunta2.Show()
            pontos.Text = 0
        ElseIf CheckBox4.Checked = True Then
            MessageBox.Show("Está errado, fica para a próxima")
            Me.Visible = False
            pergunta2.Show()
            pontos.Text = 0
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Os votos do publico: 14% - agronomia 20% - arqueologia 34% - mecânica 32% - roubo")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ajuda1.Show()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ml += 1
        Label3.Text = m & " : " & s & " : " & ml
        If ml = 60 Then
            ml = 0
            s += 1
            Label3.Text = m & " : " & s & " : " & ml
            If s = 60 Then
                s = 0
                m += 1
                Label3.Text = m & " : " & s & " : " & ml
                If m = 60 Then
                    Timer1.Stop()
                    m = 0
                    s = 0
                    ml = 0
                    Label3.Text = m & " : " & s & " : " & ml
                End If
            End If
        End If
    End Sub
End Class

