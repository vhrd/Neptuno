Public Class Form_datos_forma_casco



    Private Sub Form_datos_forma_casco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If metodo_holtrop = False And metodo_savitsky = True Then
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
        End If


        txt_area_transv_bulbo.Text = areaT_bulbo
        txt_centro_area_bulbo.Text = centroV_area_bulbo
        txt_area_transom.Text = area_transom
        txt_rea_seccion_media.Text = area_amidship
        If forma_casco = "normal" Then
            rb_normal.Checked = True
        ElseIf forma_casco = "v" Then
            rb_v.Checked = True
        ElseIf forma_casco = "u" Then
            rb_u.Checked = True
        End If
        
    End Sub

    Private Sub rb_v_Click(sender As Object, e As EventArgs) Handles rb_v.Click
        forma_casco = "v"
        Cstern = -10
    End Sub

    Private Sub rb_u_Click(sender As Object, e As EventArgs) Handles rb_u.Click
        forma_casco = "u"
        Cstern = 10
    End Sub

    Private Sub rb_normal_Click(sender As Object, e As EventArgs) Handles rb_normal.Click
        forma_casco = "normal"
        Cstern = 0
    End Sub

 
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        areaT_bulbo = txt_area_transv_bulbo.Text
        centroV_area_bulbo = txt_centro_area_bulbo.Text
        area_transom = txt_area_transom.Text
        area_amidship = txt_rea_seccion_media.Text

        Me.Close()
    End Sub

   
    Private Sub rb_v_CheckedChanged(sender As Object, e As EventArgs) Handles rb_v.CheckedChanged

    End Sub

    Private Sub txt_area_transv_bulbo_MouseHover(sender As Object, e As EventArgs) Handles txt_area_transv_bulbo.MouseHover
        ToolTip1.SetToolTip(txt_area_transv_bulbo, "Area en " & "m" & Chr(178) & "")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txt_centro_area_bulbo_MouseHover(sender As Object, e As EventArgs) Handles txt_centro_area_bulbo.MouseHover
        ToolTip1.SetToolTip(txt_centro_area_bulbo, "Area en metros.")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form_imagen_bulbo.MdiParent = Mdi_menu
        Form_imagen_bulbo.Show()
    End Sub
End Class