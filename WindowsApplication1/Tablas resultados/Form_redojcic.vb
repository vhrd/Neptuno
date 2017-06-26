Public Class Form_redojcic

    Private Sub Form_redojcic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaximizeBox = False
        dg_radojcic.DataSource = dtradojcic
        With dg_radojcic
            .Columns(0).HeaderText = "Kn"
            .Columns(1).HeaderText = "m/s"
            .Columns(2).HeaderText = "Fn"
            .Columns(3).HeaderText = "Rnh"
            .Columns(4).HeaderText = "Rapp"
            .Columns(5).HeaderText = "Rtotal"
            .Columns(6).HeaderText = "EHP"


        End With



        With dg_radojcic
            .AllowUserToAddRows = False
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        End With
        Me.Width = dg_radojcic.Width + 16
    End Sub
End Class