Public Class Splash

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value >= 100 Then
            Timer1.Stop()
            ProgressBar1.Value = 0
            Login.Show()
            Me.Hide()
        End If
        ProgressBar1.Value += 1
        Label2.Text = "Please Wait... LOADING " & ProgressBar1.Value & "%"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
