Public Class Informacion

    Private Sub LinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        Try
            System.Diagnostics.Process.Start("https://github.com/vhrd/Neptuno")
        Catch
            'Code to handle the error.
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub
End Class