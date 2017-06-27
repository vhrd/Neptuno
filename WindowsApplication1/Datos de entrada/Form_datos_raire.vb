Public Class Form_datos_raire

    Private Sub Form_datos_raire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rb_si.Checked = True
        txt_area_frontal.Text = area_frontal
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rb_no.CheckedChanged

    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles rb_no.Click
        txt_area_frontal.ReadOnly = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rb_si.CheckedChanged

    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles rb_si.Click
        txt_area_frontal.ReadOnly = False
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        area_frontal = txt_area_frontal.Text
        raire = 0.5 * densidad_aire * Val(txt_coef_arrastre.Text) + (txt_velocidad_viento.Text) ^ 2

    End Sub

    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles txt_area_frontal.MouseHover
        ToolTip1.SetToolTip(txt_area_frontal, "Area proyectada en " & "m" & Chr(178) & "")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_area_frontal.TextChanged

    End Sub

    Private Sub txt_coef_arrastre_Click(sender As Object, e As EventArgs) Handles txt_coef_arrastre.Click

    End Sub

    Private Sub txt_coef_arrastre_TextChanged(sender As Object, e As EventArgs) Handles txt_coef_arrastre.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class