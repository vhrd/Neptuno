Public Class Forma_holtrop

    Private Sub Form_datagrid_reporte_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub Form_datagrid_reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaximizeBox = False

        datagrid_1.DataSource = dtholtrop
        With datagrid_1
            .Columns(0).HeaderText = "Kn"
            .Columns(1).HeaderText = "m/s"
            .Columns(2).HeaderText = "Fn"
            .Columns(3).HeaderText = "Rf*(1+k1)"
            .Columns(4).HeaderText = "Rapp"
            .Columns(5).HeaderText = "Rw"
            .Columns(6).HeaderText = "Rb"
            .Columns(7).HeaderText = "Rtr"
            .Columns(8).HeaderText = "Ra"
            .Columns(9).HeaderText = "Rtotal(KN)"
            .Columns(10).HeaderText = "Pe(KW)"


        End With

        With datagrid_1
            .AllowUserToAddRows = False
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        End With
        Me.Width = datagrid_1.Width + 16



    End Sub
End Class