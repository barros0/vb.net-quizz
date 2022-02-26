Public Class registo
    Private Sub registo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        My.Computer.Audio.Play(My.Resources._5_Minutos__Música_para_Meditação___Medite_em_5_minutos_, AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If IsNumeric(TextBox2.Text) Then
            TextBox2.Clear()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Computer.Audio.Stop()
        Dim resposta As Integer
        Dim nome = (TextBox2.Text)
        Dim day = DateTimePicker1.Value.Day
        Dim month = DateTimePicker1.Value.Month
        Dim year = DateTimePicker1.Value.Year

        Dim today = Date.Today.Day
        Dim tomonth = Date.Today.Month
        Dim toyear = Date.Today.Year

        Dim med = toyear - 18
        Dim med100 = toyear - 100

        If TextBox2.Text = "" Then
            MsgBox("Introduz um nome válido")
        Else
            If year > med Then
                resposta = MessageBox.Show("Desculpa mas não tens idade para jogar este quizz", "", MessageBoxButtons.RetryCancel)
            End If
            If year < med And year >= med100 Then
                resposta = MessageBox.Show("Olá " & nome & "!! Bem vindo ao quizz", "", MessageBoxButtons.OK)
                pergunta1.Show()
                Me.Hide()
            End If
            If year = med And month < tomonth Then
                resposta = MsgBox("Olá " & nome & "!! Bem vindo ao quizz")
                pergunta1.Show()
                Me.Hide()
            End If
            If year <= med100 Then
                resposta = MessageBox.Show("Idade igual ou superior a 100 não permitida", "", MessageBoxButtons.RetryCancel)
                menujogar.Hide()
                Me.Show()
            End If
            If year = med And month > tomonth Then
                resposta = MessageBox.Show("Desculpa mas não tens idade para jogar este quizz", "", MessageBoxButtons.RetryCancel)
            End If
            If year = med And month = tomonth And day > today Then
                resposta = MessageBox.Show("Desculpa mas não tens idade para jogar este quizz", "", MessageBoxButtons.RetryCancel)
            End If
            If year = med And month = tomonth And day <= today Then
                resposta = MsgBox("Olá " & nome & " Bem vindo ao quizz")
                pergunta1.Show()
                Me.Hide()
            End If
        End If
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
