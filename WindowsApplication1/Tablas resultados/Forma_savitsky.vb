
Public Class Forma_savitsky

    Private Sub Forma_savitsky_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaximizeBox = False
        dg_savitsky.DataSource = dtsavitsky
        With dg_savitsky
            .Columns(0).HeaderText = "Kn"
            .Columns(1).HeaderText = "m/s"
            .Columns(2).HeaderText = "Fn"
            .Columns(3).HeaderText = "Fnvol"
            .Columns(4).HeaderText = "Rapp"
            .Columns(5).HeaderText = "Raire"
            .Columns(6).HeaderText = "Rtotal(KN)"
            .Columns(7).HeaderText = "Pe(KW)"
          
        End With
        With dg_savitsky
            .AllowUserToAddRows = False
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End With
        Me.Width = dg_savitsky.Width + 16
    End Sub
End Class