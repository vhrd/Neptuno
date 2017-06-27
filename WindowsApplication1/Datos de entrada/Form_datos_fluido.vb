Public Class Form_datos_fluido

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub Form_datos_fluido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tipo_fluido = "agua_mar" Then
            rb_agua_mar.Checked = True
            txt_densidad.Text = densidad
            txt_viscosidad_cinematica.Text = Format(viscosidad_cinematica, "e5")
            GroupBox2.Enabled = False
        ElseIf tipo_fluido = "agua_dulce" Then
            rb_agua_dulce.Checked = True
            txt_densidad.Text = densidad
            txt_viscosidad_cinematica.Text = Format(viscosidad_cinematica, "e5")
            GroupBox2.Enabled = False
        ElseIf tipo_fluido = "otro" Then
            RadioButton1.Checked = True
            txt_densidad.Text = densidad
            txt_viscosidad_cinematica.Text = Format(viscosidad_cinematica, "e5")
            GroupBox2.Enabled = True
        End If
        txt_densidad_aire.Text = densidad_aire
    End Sub

    Private Sub rb_agua_mar_CheckedChanged(sender As Object, e As EventArgs) Handles rb_agua_mar.CheckedChanged

    End Sub

    Private Sub rb_agua_mar_Click(sender As Object, e As EventArgs) Handles rb_agua_mar.Click
        txt_densidad.Text = 1025.87
        txt_viscosidad_cinematica.Text = Format(0.00000118831, "e5")

    End Sub

    Private Sub rb_agua_dulce_CheckedChanged(sender As Object, e As EventArgs) Handles rb_agua_dulce.CheckedChanged

    End Sub

    Private Sub rb_agua_dulce_Click(sender As Object, e As EventArgs) Handles rb_agua_dulce.Click
        txt_densidad.Text = 999
        txt_viscosidad_cinematica.Text = Format(0.00000113902, "e5")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        GroupBox2.Enabled = True
        

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If txt_densidad.Text = "" Or txt_viscosidad_cinematica.Text = "" Then
            MsgBox("Falta ingresar informacion.", MsgBoxStyle.Information, "INFORMACION IMPORTANTE")
        Else
            densidad = txt_densidad.Text
            viscosidad_cinematica = txt_viscosidad_cinematica.Text
            If rb_agua_mar.Checked = True Then
                tipo_fluido = "agua_mar"
            ElseIf rb_agua_dulce.Checked = True Then
                tipo_fluido = "agua_dulce"
            ElseIf RadioButton1.Checked = True Then
                tipo_fluido = "otro"
            End If
        End If
        densidad_aire = txt_densidad_aire.Text
        Me.Close()
    End Sub
End Class