Public Class Form_datos_propusion

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        diametro_helice = txt_diametro_helice.Text
        area_expandida = txt_area_expandida.Text
        paso = txt_paso.Text
        Me.Close()
    End Sub

    Private Sub Form_datos_propusion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rb_1helice_conv.Checked = True
        txt_area_expandida.Text = area_expandida
        txt_diametro_helice.Text = diametro_helice
        txt_paso.Text = paso
    End Sub

    Private Sub rb_1helice_conv_CheckedChanged(sender As Object, e As EventArgs) Handles rb_1helice_conv.CheckedChanged

    End Sub

    Private Sub rb_1helice_conv_Click(sender As Object, e As EventArgs) Handles rb_1helice_conv.Click
        num_helices = 1
    End Sub

    Private Sub rb_1helice_abierta_CheckedChanged(sender As Object, e As EventArgs) Handles rb_1helice_abierta.CheckedChanged

    End Sub

    Private Sub rb_1helice_abierta_Click(sender As Object, e As EventArgs) Handles rb_1helice_abierta.Click
        num_helices = 1.1
    End Sub

    Private Sub rb_2helices_CheckedChanged(sender As Object, e As EventArgs) Handles rb_2helices.CheckedChanged

    End Sub

    Private Sub rb_2helices_Click(sender As Object, e As EventArgs) Handles rb_2helices.Click
        num_helices = 2
    End Sub

    Private Sub txt_diametro_helice_MouseHover(sender As Object, e As EventArgs) Handles txt_diametro_helice.MouseHover
        ToolTip1.SetToolTip(txt_diametro_helice, "Diametro en metros.")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class