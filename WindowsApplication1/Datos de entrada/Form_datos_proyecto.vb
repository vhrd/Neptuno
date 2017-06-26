Public Class Form_datos_proyecto

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        embarcacion = txt_embarcacion.Text
        proyecto = txt_proyecto.Text
        ingeniero = txt_ingeniero.Text
        Me.Close()
    End Sub

    Private Sub Form_datos_proyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_embarcacion.Text = embarcacion
        txt_proyecto.Text = proyecto
        txt_ingeniero.Text = ingeniero
    End Sub
End Class