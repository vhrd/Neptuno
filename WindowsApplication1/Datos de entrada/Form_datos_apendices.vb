Public Class Form_datos_apendices

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        calculo_raap = 0
        I = TextBox1.Text
        II = TextBox2.Text
        III = TextBox3.Text
        IV = TextBox4.Text
        V = TextBox5.Text
        VI = TextBox6.Text
        VII = TextBox7.Text
        VIII = TextBox8.Text
        IX = TextBox9.Text
        X = TextBox10.Text

        X_ = TextBox11.Text
        IX_ = TextBox12.Text
        VIII_ = TextBox13.Text
        VII_ = TextBox14.Text
        VI_ = TextBox15.Text
        V_ = TextBox16.Text
        IV_ = TextBox17.Text
        III_ = TextBox18.Text
        II_ = TextBox19.Text
        I_ = TextBox20.Text

        Me.Close()
        Form_apendices.Close()

    End Sub

    Private Sub Form_datos_apendices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_coef_thruster.Text = 0.0045
        TextBox11.Text = 0
        TextBox12.Text = 1.4
        TextBox13.Text = 2.7
        TextBox14.Text = 2.8
        TextBox15.Text = 3.0
        TextBox16.Text = 3.0
        TextBox17.Text = 1.75
        TextBox18.Text = 3.0
        TextBox19.Text = 2.8
        TextBox20.Text = 1.75

        TextBox1.Text = 50
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0
        TextBox5.Text = 0
        TextBox6.Text = 0
        TextBox7.Text = 0
        TextBox8.Text = 0
        TextBox9.Text = 0
        TextBox10.Text = 0
    End Sub

    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        ToolTip1.SetToolTip(TextBox1, "Area en " & "m" & Chr(178) & "")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox2_MouseHover(sender As Object, e As EventArgs) Handles TextBox2.MouseHover
        ToolTip1.SetToolTip(TextBox2, "Area en " & "m" & Chr(178) & "")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox3_MouseHover(sender As Object, e As EventArgs) Handles TextBox3.MouseHover
        ToolTip1.SetToolTip(TextBox3, "Area en " & "m" & Chr(178) & "")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox4_MouseHover(sender As Object, e As EventArgs) Handles TextBox4.MouseHover
        ToolTip1.SetToolTip(TextBox4, "Area en " & "m" & Chr(178) & "")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox5_MouseHover(sender As Object, e As EventArgs) Handles TextBox5.MouseHover
        ToolTip1.SetToolTip(TextBox5, "Area en " & "m" & Chr(178) & "")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox6_MouseHover(sender As Object, e As EventArgs) Handles TextBox6.MouseHover
        ToolTip1.SetToolTip(TextBox6, "Area en " & "m" & Chr(178) & "")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox7_MouseHover(sender As Object, e As EventArgs) Handles TextBox7.MouseHover
        ToolTip1.SetToolTip(TextBox7, "Area en " & "m" & Chr(178) & "")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox8_MouseHover(sender As Object, e As EventArgs) Handles TextBox8.MouseHover
        ToolTip1.SetToolTip(TextBox8, "Area en " & "m" & Chr(178) & "")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox9_MouseHover(sender As Object, e As EventArgs) Handles TextBox9.MouseHover
        ToolTip1.SetToolTip(TextBox9, "Area en " & "m" & Chr(178) & "")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox10_MouseHover(sender As Object, e As EventArgs) Handles TextBox10.MouseHover
        ToolTip1.SetToolTip(TextBox10, "Area en " & "m" & Chr(178) & "")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txt_diametro_thruster_MouseHover(sender As Object, e As EventArgs) Handles txt_diametro_thruster.MouseHover
        ToolTip1.SetToolTip(TextBox1, "Diametro en metros.")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class