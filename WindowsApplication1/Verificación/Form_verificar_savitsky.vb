Imports System.Math
Public Class Form_verificar_savitsky

    Private Sub Form_verificar_savitsky_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Mdi_menu.Width - (Me.Width + 20), 0)
        With dg_savitsky
            .Rows.Add("ie", "3.7 - 28.6")
            .Rows.Add("L/B", "2.52 - 18.26")
            .Rows.Add("B/T", "1.7 - 9.8")
            .Rows.Add("At/Ax", "0 - 1")
            '.Rows.Add("LCG/L", "-6.56% - 0.3%")
            .AllowUserToAddRows = False
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .ClearSelection()
        End With

        contador_savitsky = 0
        Try
            With dg_savitsky
                .Rows(0).Cells(2).Value = iee
                If iee > 3.7000000000000002 And iee < 28.600000000000001 Then
                    .Rows(0).Cells(2).Value = dg_savitsky.Rows(0).Cells(2).Value & " " & "✓"
                    .Item(2, 0).Style.ForeColor = Color.Green
                    contador_savitsky = contador_savitsky + 1
                ElseIf iee <= 3.7000000000000002 Then
                    .Rows(0).Cells(2).Value = dg_savitsky.Rows(0).Cells(2).Value & " " & "▼"
                    .Item(2, 0).Style.ForeColor = Color.Red
                ElseIf iee >= 28.600000000000001 Then
                    .Rows(0).Cells(2).Value = dg_savitsky.Rows(0).Cells(2).Value & " " & "▲"
                    .Item(2, 0).Style.ForeColor = Color.Orange
                End If

                Dim LBB As Decimal = Round(eslora_wl / manga_wl, 2)
                .Rows(1).Cells(2).Value = LBB
                If LBB > 2.52 And LBB < 18.260000000000002 Then
                    .Rows(1).Cells(2).Value = dg_savitsky.Rows(1).Cells(2).Value & " " & "✓"
                    .Item(2, 1).Style.ForeColor = Color.Green
                    contador_savitsky = contador_savitsky + 1
                ElseIf LBB <= 2.52 Then
                    .Rows(1).Cells(2).Value = dg_savitsky.Rows(1).Cells(2).Value & " " & "▼"
                    .Item(2, 1).Style.ForeColor = Color.Red
                ElseIf LBB >= 18.260000000000002 Then
                    .Rows(1).Cells(2).Value = dg_savitsky.Rows(1).Cells(2).Value & " " & "▲"
                    .Item(2, 1).Style.ForeColor = Color.Red
                End If

                Dim BTT As Decimal = Round(manga_wl / calado_medio, 2)
                .Rows(2).Cells(2).Value = BTT
                If BTT > 1.7 And BTT < 9.8000000000000007 Then
                    .Rows(2).Cells(2).Value = dg_savitsky.Rows(2).Cells(2).Value & " " & "✓"
                    .Item(2, 2).Style.ForeColor = Color.Green
                    contador_savitsky = contador_savitsky + 1
                ElseIf LBB <= 1.7 Then
                    .Rows(2).Cells(2).Value = dg_savitsky.Rows(2).Cells(2).Value & " " & "▼"
                    .Item(2, 2).Style.ForeColor = Color.Red
                ElseIf LBB >= 9.8000000000000007 Then
                    .Rows(2).Cells(2).Value = dg_savitsky.Rows(2).Cells(2).Value & " " & "▲"
                    .Item(2, 2).Style.ForeColor = Color.Red
                End If

                Dim atx As Decimal = Round(area_transom / area_amidship, 2)
                .Rows(3).Cells(2).Value = atx
                If atx > 0 And atx < 1 Then
                    .Rows(3).Cells(2).Value = dg_savitsky.Rows(3).Cells(2).Value & " " & "✓"
                    contador_savitsky = contador_savitsky + 1
                    .Item(2, 3).Style.ForeColor = Color.Green
                ElseIf LBB <= 0 Then
                    .Rows(3).Cells(2).Value = dg_savitsky.Rows(3).Cells(2).Value & " " & "▼"
                    .Item(2, 3).Style.ForeColor = Color.Red
                ElseIf LBB >= 1 Then
                    .Rows(3).Cells(2).Value = dg_savitsky.Rows(3).Cells(2).Value & " " & "▲"
                    .Item(2, 3).Style.ForeColor = Color.Red
                End If


                '  Dim lcgl As Decimal = Round(LCG / eslora_wl, 2)
                '  .Rows(3).Cells(2).Value = lcgl
                '  If lcgl > -6.5599999999999996 And lcgl < 0.29999999999999999 Then
                '.Rows(1).Cells(3).Value = "Normal"
                '     contador_savitsky = contador_savitsky + 1
                '  ElseIf lcgl <= -6056 Then
                '  .Rows(1).Cells(3).Value = "Bajo"
                '  ElseIf lcgl >= 0.29999999999999999 Then
                '  .Rows(1).Cells(3).Value = "Alto"
                '  End If


            End With
        Catch ex As Exception

        End Try
        
    End Sub
End Class