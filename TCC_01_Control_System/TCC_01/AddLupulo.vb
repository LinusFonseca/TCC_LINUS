Public Class AddLupulo



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Supervisorio.Buzzer = 0
        Me.Close()
        Supervisorio.EscreveAoLadoDaHora("Adição de lúpulo realizada")
    End Sub

End Class