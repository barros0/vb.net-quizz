Public Class resultados
    Dim resultado As Integer
    Private Sub resultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        pergunta1.Timer1.Stop()
        Label1.Text = pergunta1.Label3.Text


        resultado = Val(pergunta1.pontos.Text) + Val(pergunta2.pontos.Text) + Val(pergunta3.pontos.Text) + Val(pergunta4.pontos.Text) + Val(pergunta5.pontos.Text) + Val(pergunta6.pontos.Text) + Val(pergunta7.pontos.Text)

        Dim resultado_percentagem As Integer = Math.Round(Val(resultado / 7 * 100))
        Label5.Text = resultado_percentagem
        ProgressBar1.Value = resultado_percentagem

        If Val(Label5.Text) <= 19.99 Then
            Label6.Text = "Muito Fraco " & registo.TextBox2.Text & " Apenas tiveste " & Label5.Text & "%"
        ElseIf Val(Label5.Text) >= 20 And Label5.Text <= 49.99 Then
            Label6.Text = "Fraco " & registo.TextBox2.Text & " tiveste " & Label5.Text & "%"
        ElseIf Val(Label5.Text) >= 50 And Label5.Text <= 69.99 Then
            Label6.Text = "Suficiente " & registo.TextBox2.Text & " tiveste " & Label5.Text & "%"
        ElseIf Val(Label5.Text) >= 70 And Label5.Text <= 89.99 Then
            Label6.Text = "Bom " & registo.TextBox2.Text & " tiveste " & Label5.Text & "%"
        ElseIf Val(Label5.Text) >= 90 And Label5.Text >= 100 Then
            Label6.Text = "Muito bom " & registo.TextBox2.Text & " tiveste " & Label5.Text & "%"
        End If
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
        Application.Restart()
    End Sub
End Class