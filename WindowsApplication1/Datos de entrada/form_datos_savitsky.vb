Public Class form_datos_savitsky

    Private Sub form_datos_savitsky_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_ie.Text = iee
        txt_Bpx.Text = Bpx

    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Bpx = txt_Bpx.Text
        iee = txt_ie.Text
        Me.Close()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form_imagen_eslora_mojada.MdiParent = Mdi_menu
        Form_imagen_eslora_mojada.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form_imagen_manga_pantoque.MdiParent = Mdi_menu
        Form_imagen_manga_pantoque.Show()
    End Sub
End Class