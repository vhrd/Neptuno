Public Class Form_factor_servicio

    Private Sub Form_factor_servicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = factor_servicio
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        factor_servicio = TextBox1.Text
    End Sub
End Class