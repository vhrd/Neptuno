Public NotInheritable Class Form_splash
    Dim contador As Integer
    Private Sub Form_splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TransparencyKey = BackColor
        Timer1.Enabled = True
        Timer1.Interval = 300
       

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            contador = contador + 50
            ProgressBar1.Value = contador
        Else

            Mdi_menu.Show()
            Me.Close()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
