
Public Class Datos_casco

    Private Sub Datos_casco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If metodo_savitsky = True And metodo_holtrop = False Then
            txt_cmaestra.Enabled = False
            txt_cwp.Enabled = False
            txt_LCB.Enabled = False
        End If
        Me.ToolTip1.IsBalloon = True
        txt_eslorawl.Text = eslora_wl
        txt_mangawl.Text = manga_wl
        txt_calado_proa.Text = calado_proa
        txt_calado_popa.Text = calado_popa

        txt_cblock.Text = Cblock
        txt_cmaestra.Text = Cmaestra
        txt_cwp.Text = Cwaterplane
        txt_LCB.Text = LCBporcentaje

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        eslora_wl = txt_eslorawl.Text
        manga_wl = txt_mangawl.Text
        calado_proa = txt_calado_proa.Text
        calado_popa = txt_calado_popa.Text
        calado_medio = (calado_popa + calado_proa) / 2

        Cblock = txt_cblock.Text
        Cwaterplane = txt_cwp.Text
        Cmaestra = txt_cmaestra.Text

        Try
            Cprismatico = Cblock / Cmaestra
            Vs = eslora_wl * calado_medio * manga_wl * Cblock
        Catch ex As Exception
            Vs = 0
        End Try

        LCBporcentaje = txt_LCB.Text
        LCBmetrico = (txt_LCB.Text / 100) * eslora_wl

        desplazamiento = Vs * densidad

        Me.Close()
    End Sub

    Private Sub txt_eslorawl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_eslorawl.KeyPress

    End Sub

    Private Sub txt_eslorawl_MouseHover(sender As Object, e As EventArgs) Handles txt_eslorawl.MouseHover
        ToolTip1.SetToolTip(txt_eslorawl, "Eslora en METROS.")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txt_eslorawl_TextChanged(sender As Object, e As EventArgs) Handles txt_eslorawl.TextChanged

    End Sub

    Private Sub txt_mangawl_MouseHover(sender As Object, e As EventArgs) Handles txt_mangawl.MouseHover
        ToolTip1.SetToolTip(txt_mangawl, "Manga en METROS.")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txt_calado_proa_MouseHover(sender As Object, e As EventArgs) Handles txt_calado_proa.MouseHover
        ToolTip1.SetToolTip(txt_calado_proa, "Calado de proa en METROS.")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txt_calado_popa_MouseHover(sender As Object, e As EventArgs) Handles txt_calado_popa.MouseHover
        ToolTip1.SetToolTip(txt_calado_popa, "Calado de popa en METROS.")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txt_LCB_MouseHover(sender As Object, e As EventArgs) Handles txt_LCB.MouseHover
        ToolTip1.SetToolTip(txt_LCB, "Ingresar dato como porcentaje." & vbCrLf & "Correcto: 3" & vbCrLf & "Incorrecto: 0,03")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txt_LCB_TextChanged(sender As Object, e As EventArgs) Handles txt_LCB.TextChanged

    End Sub
End Class