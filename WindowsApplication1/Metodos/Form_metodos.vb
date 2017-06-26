Public Class Form_metodos

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If chb_holtrop.Checked = True Then
            metodo_holtrop = True
        Else
            metodo_holtrop = False
        End If
        If chb_savitsky.Checked = True Then
            metodo_savitsky = True
        Else
            metodo_savitsky = False
        End If

        If chb_radojcic.Checked = True Then
            metodo_radojcic = True
        Else
            metodo_radojcic = False
        End If
        Me.Close()
    End Sub

    Private Sub Form_metodos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If metodo_holtrop = True Then
            chb_holtrop.Checked = True
        End If
        If metodo_radojcic = True Then
            chb_radojcic.Checked = True
        End If
        If metodo_savitsky = True Then
            chb_savitsky.Checked = True
        End If
    End Sub
End Class