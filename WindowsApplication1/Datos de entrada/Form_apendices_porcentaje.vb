Public Class Form_apendices_porcentaje

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        calculo_raap = 1
        Rapp_porcentaje = Val(TextBox1.Text)
        Me.Close()
        Form_apendices.Close()
    End Sub

    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        ToolTip1.SetToolTip(TextBox1, "Ingresar dato como porcentaje." & vbCrLf & "Correcto: 3" & vbCrLf & "Incorrecto: 0,03")
        ToolTip1.ToolTipTitle = "Información."
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class