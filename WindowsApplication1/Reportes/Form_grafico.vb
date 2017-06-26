
Imports System.Windows.Forms.DataVisualization.Charting


Public Class Form_grafico

    Private Sub Form_grafico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart1.Dock = DockStyle.Left
        Chart1.Dock = DockStyle.Right
        Chart1.Dock = DockStyle.Bottom
        ComboBox1.SelectedIndex = 0
    
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.SelectedIndex = 0 Then
            llenar_grafico_holtrop()
        ElseIf ComboBox1.SelectedIndex = 1 Then

            llenar_grafico_savitsky()
        End If
    End Sub
 
    Sub llenar_grafico_holtrop()

        Me.Chart1.Series("rt").Points.Clear()
        Dim view As DataView = New DataView(dtholtrop)
        Dim x As Integer
        For x = 0 To view.Count - 1

            Me.Chart1.Series("rt").Points.AddXY(view(x)("vb"), view(x)("rt"))

        Next
    End Sub

    Sub llenar_grafico_savitsky()
        Me.Chart1.Series("rt").Points.Clear()
    End Sub
End Class