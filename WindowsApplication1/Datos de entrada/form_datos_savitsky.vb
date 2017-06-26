Public Class form_datos_savitsky

    Private Sub form_datos_savitsky_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Bp.Text = Bpx

    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Bpx = txt_Bp.Text



        Me.Close()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    
End Class