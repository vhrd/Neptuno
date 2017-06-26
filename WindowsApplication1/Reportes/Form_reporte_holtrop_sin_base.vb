Imports Microsoft.Reporting.WinForms
Public Class Form_reporte_holtrop_sin_base
    Dim parametro As New ReportParameter
    Private Sub Form_reporte_holtrop_sin_base_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        parametro = New ReportParameter("holtrop", metodo_holtrop)
        Me.ReportViewer1.LocalReport.SetParameters(parametro)

        parametro = New ReportParameter("radojcic", metodo_radojcic)
        Me.ReportViewer1.LocalReport.SetParameters(parametro)

        parametro = New ReportParameter("savitsky", metodo_savitsky)
        Me.ReportViewer1.LocalReport.SetParameters(parametro)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100

    End Sub
End Class