Imports System.Math
Public Class Form_verificar_holtrop

    Private Sub Form_verificar_holtrop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Mdi_menu.Width - (Me.Width + 20), Form_verificar_savitsky.Height)
        With dg_savitsky
            .Rows.Add("Cp", "0.55 a 0.85")
            .Rows.Add("L/B", "3.90 a 14.90")
            .Rows.Add("B/T", "2.10 a 4.00")
            .AllowUserToAddRows = False
            .ReadOnly = True
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ClearSelection()
        End With
        contador_holtrop = 0

        Try
            With dg_savitsky
                .Rows(0).Cells(2).Value = Round(Cprismatico, 2)
                If Cprismatico > 0.55000000000000004 And Cprismatico < 0.84999999999999998 Then
                    .Rows(0).Cells(2).Value = dg_savitsky.Rows(0).Cells(2).Value & " " & "✓"
                    .Item(2, 0).Style.ForeColor = Color.Green
                    contador_holtrop = contador_holtrop + 1
                ElseIf Cprismatico <= 0.55000000000000004 Then
                    .Rows(0).Cells(2).Value = dg_savitsky.Rows(0).Cells(2).Value & " " & "▼"
                    .Item(2, 0).Style.ForeColor = Color.Red
                ElseIf Cprismatico >= 0.84999999999999998 Then
                    .Rows(0).Cells(2).Value = dg_savitsky.Rows(0).Cells(2).Value & " " & "▲"
                    .Item(2, 0).Style.ForeColor = Color.Orange
                End If

                Dim LBB As Decimal = Round(eslora_wl / manga_wl, 2)
                .Rows(1).Cells(2).Value = LBB
                If LBB > 3.8999999999999999 And LBB < 15 Then
                    .Rows(1).Cells(2).Value = dg_savitsky.Rows(1).Cells(2).Value & " " & "✓"
                    .Item(2, 1).Style.ForeColor = Color.Green
                    contador_holtrop = contador_holtrop + 1
                ElseIf LBB <= 3.8999999999999999 Then
                    .Rows(1).Cells(2).Value = dg_savitsky.Rows(1).Cells(2).Value & " " & "▼"
                    .Item(2, 1).Style.ForeColor = Color.Red
                ElseIf LBB >= 15 Then
                    .Rows(1).Cells(2).Value = dg_savitsky.Rows(1).Cells(2).Value & " " & "▲"
                    .Item(2, 1).Style.ForeColor = Color.Red
                End If

                Dim BTT As Decimal = Round(manga_wl / calado_medio, 2)
                .Rows(2).Cells(2).Value = BTT
                If BTT > 1.7 And BTT < 9.8000000000000007 Then
                    .Rows(2).Cells(2).Value = dg_savitsky.Rows(2).Cells(2).Value & " " & "✓"
                    .Item(2, 2).Style.ForeColor = Color.Green
                    contador_holtrop = contador_holtrop + 1
                ElseIf LBB <= 1.7 Then
                    .Rows(2).Cells(2).Value = dg_savitsky.Rows(2).Cells(2).Value & " " & "▼"
                    .Item(2, 2).Style.ForeColor = Color.Red
                ElseIf LBB >= 9.8000000000000007 Then
                    .Rows(2).Cells(2).Value = dg_savitsky.Rows(2).Cells(2).Value & " " & "▲"
                    .Item(2, 2).Style.ForeColor = Color.Red
                End If


            End With
        Catch ex As Exception

        End Try
    End Sub
End Class