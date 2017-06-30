
Imports Vb = Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Object
Imports System.IO.FileStream
Imports System.IO
Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms
Public Class Mdi_menu
    Public fuente As New ReportDataSource
    Public fuente1 As New ReportDataSource
    Public fuente2 As New ReportDataSource
    Private Sub CASCOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CASCOToolStripMenuItem.Click
        If metodo_holtrop = False And metodo_savitsky = False Then
            MsgBox("Seleccionar al menos un método de cálculo.", MsgBoxStyle.Exclamation, "INFORMACIÓN IMPORTANTE")
        Else
            Datos_casco.MdiParent = Me
            Datos_casco.Show()
        End If
     
    End Sub
    Private Sub myMdiControlPaint(ByVal sender As Object, _
ByVal e As System.Windows.Forms.PaintEventArgs)
        e.Graphics.DrawImage(Me.pbBackground.Image, 0, 0, Me.Width, Me.Height)
    End Sub

    Private Sub myMdiControlResize(ByVal sender As Object, _
    ByVal e As System.EventArgs)
        CType(sender, MdiClient).Invalidate()
    End Sub

    Private Sub Menu_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtholtrop = New DataTable
        With dtholtrop
            .Columns.Add("vb")
            .Columns.Add("vb_ms")
            .Columns.Add("fn")
            .Columns.Add("rf")
            .Columns.Add("rapp")
            .Columns.Add("rw")
            .Columns.Add("rb")
            .Columns.Add("rtr")
            .Columns.Add("ra")
            .Columns.Add("rt")
            .Columns.Add("ehp")

        End With

        dtsavitsky = New DataTable
        With dtsavitsky
            .Columns.Add("vb_kn")
            .Columns.Add("vb_ms")
            .Columns.Add("fn")
            .Columns.Add("fnvol")
            .Columns.Add("rapp")
            .Columns.Add("raire")
            .Columns.Add("rtotal")
            .Columns.Add("ehp")

        End With


        dt_datos = New DataTable
        With dt_datos
            .Columns.Add("proyecto")
            .Columns.Add("embarcacion")
            .Columns.Add("ingeniero")
            .Columns.Add("l")
            .Columns.Add("b")
            .Columns.Add("tm")
            .Columns.Add("ta")
            .Columns.Add("tf")
            .Columns.Add("s")
            .Columns.Add("cp")
            .Columns.Add("cb")
            .Columns.Add("cwp")
            .Columns.Add("transom")
            .Columns.Add("area_b")
            .Columns.Add("altura_b")
            .Columns.Add("area_apendices")
            .Columns.Add("fluido")
            .Columns.Add("densidad")
            .Columns.Add("viscosidad")
            .Columns.Add("vs")
            .Columns.Add("desplazamiento")
        End With
     


        Forma_holtrop.MdiParent = Me
        Forma_holtrop.WindowState = FormWindowState.Minimized
        Forma_holtrop.Show()

        Form_grafico.MdiParent = Me
        Form_grafico.WindowState = FormWindowState.Minimized
        Form_grafico.Show()



        Me.WindowState = FormWindowState.Maximized


        Dim ctl As Control
        Dim ctlmdi As MdiClient
        For Each ctl In Me.Controls
            Try
                ctlmdi = CType(ctl, MdiClient)
                ctlmdi.BackColor = Color.White

            Catch ex As Exception

            End Try
        Next
        pbBackground.Visible = False

        For Each c As Control In Me.Controls
            If TypeOf c Is MdiClient Then
                AddHandler c.Paint, AddressOf myMdiControlPaint
                AddHandler c.SizeChanged, AddressOf myMdiControlResize
                Exit For
            End If
        Next
    End Sub



    Private Sub OBTENERSOLUCIÓNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OBTENERSOLUCIÓNToolStripMenuItem.Click
        Form_solucion_Holtrop_mennem.MdiParent = Me
        Form_solucion_Holtrop_mennem.Show()

    End Sub



    Private Sub PropulsiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropulsiónToolStripMenuItem.Click
        If metodo_holtrop = False And metodo_savitsky = False Then
            MsgBox("Seleccionar al menos un método de cálculo.", MsgBoxStyle.Exclamation, "INFORMACIÓN IMPORTANTE")
        Else
            Form_datos_propusion.MdiParent = Me
            Form_datos_propusion.Show()
        End If
        
    End Sub

    Private Sub FormaDelCascoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormaDelCascoToolStripMenuItem.Click
        If metodo_holtrop = False And metodo_savitsky = False Then
            MsgBox("Seleccionar al menos un método de cálculo.", MsgBoxStyle.Exclamation, "INFORMACIÓN IMPORTANTE")
        Else
            Form_datos_forma_casco.MdiParent = Me
            Form_datos_forma_casco.Show()
        End If
       
    End Sub

    Private Sub PropiedadesDelFluidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropiedadesDelFluidoToolStripMenuItem.Click
        Form_datos_fluido.MdiParent = Me
        Form_datos_fluido.Show()
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form_datos_apendices.MdiParent = Me
        Form_datos_apendices.Show()
    End Sub


    Private Sub ApendicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApendicesToolStripMenuItem.Click
        If metodo_holtrop = False And metodo_savitsky = False Then
            MsgBox("Seleccionar al menos un método de cálculo.", MsgBoxStyle.Exclamation, "INFORMACIÓN IMPORTANTE")
        Else
            Form_apendices.MdiParent = Me
            Form_apendices.Show()
        End If
        
    End Sub

    Private Sub REPORTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTESToolStripMenuItem.Click

    End Sub
    Sub llamar_reporte()


        Form_reporte_holtrop_sin_base.ReportViewer1.LocalReport.DataSources.Clear()
        Form_reporte_holtrop_sin_base.ReportViewer1.LocalReport.DataSources.Add(fuente)
        Form_reporte_holtrop_sin_base.ReportViewer1.LocalReport.DataSources.Add(fuente1)
        Form_reporte_holtrop_sin_base.ReportViewer1.LocalReport.DataSources.Add(fuente2)
        Form_reporte_holtrop_sin_base.ReportViewer1.LocalReport.ReportEmbeddedResource = "Neptuno.Reporte_holtrop_sin_base.rdlc"
        Form_reporte_holtrop_sin_base.Show()
    End Sub
    Sub almacenar_holtrop()
        Dim ds As New DataSet_RT
        Dim dtw As DataRow
        For i As Integer = 0 To dtholtrop.Rows.Count - 1
            dtw = ds.tabla_rt.NewRow
            dtw("vb_kn") = dtholtrop.Rows(i).Item("vb")
            dtw("vb_ms") = dtholtrop.Rows(i).Item("vb_ms")
            dtw("fn") = dtholtrop.Rows(i).Item("fn")
            dtw("rf") = dtholtrop.Rows(i).Item("rf")
            dtw("rapp") = dtholtrop.Rows(i).Item("rapp")
            dtw("rw") = dtholtrop.Rows(i).Item("rw")
            dtw("rb") = dtholtrop.Rows(i).Item("rb")
            dtw("rtr") = dtholtrop.Rows(i).Item("rtr")
            dtw("ra") = dtholtrop.Rows(i).Item("ra")
            dtw("rtotal") = dtholtrop.Rows(i).Item("rt")
            dtw("ehp") = dtholtrop.Rows(i).Item("ehp")

            ds.tabla_rt.Rows.Add(dtw)

        Next
        fuente.Name = "resultados"
        fuente.Value = ds.Tables(0)

    End Sub

   

    Private Sub DatosDelProyectoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosDelProyectoToolStripMenuItem.Click
        Form_datos_proyecto.ShowDialog()
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        abrir()

    End Sub
    Sub abrir()
        Try
            Dim openFileDialog1 As New OpenFileDialog
            'Directorio Predeterminado
            openFileDialog1.InitialDirectory = "C:\desktop"
            'Filtramos solo archivos con extension *.xls
            openFileDialog1.Filter = "Archivos(*.rt)|*.rt"
            openFileDialog1.FilterIndex = 1
            If openFileDialog1.ShowDialog() = DialogResult.OK Then

                ruta_archivo = openFileDialog1.FileName
            End If

            Using fs As FileStream = New FileStream("" & ruta_archivo & "", FileMode.Open, FileAccess.Read, FileShare.Read)
                Using reader As StreamReader = New StreamReader(fs)
                    Const maxLines As Integer = 10
                    Dim lineNumber As Integer = 0
                    Dim text As String

                    While Not reader.EndOfStream AndAlso lineNumber < maxLines
                        text = reader.ReadLine

                        Select Case lineNumber
                            Case 1
                                proyecto = text
                            Case 2
                                embarcacion = text
                            Case 3
                                ingeniero = text
                            Case 4
                                eslora_wl = text
                            Case 5
                                manga_wl = text
                            Case 6
                                puntal = text

                            Case 7
                                calado_popa = text
                            Case 8
                                calado_proa = text
                            Case 9
                                calado_medio = text
                            Case 10
                                LCBporcentaje = text
                            Case 11
                                LCBmetrico = text
                            Case 12
                                Cblock = text
                            Case 13
                                Cwaterplane = text
                            Case 14
                                Cmaestra = text
                            Case 15
                                Cprismatico = text
                            Case 16
                                desplazamiento = text
                            Case 17
                                Vs = text
                            Case 18
                                aceleracion = text
                            Case 19
                                factor_formas = text
                            Case 20
                                viscosidad_cinematica = text
                            Case 21
                                forma_casco = text
                            Case 22
                                Cstern = text
                            Case 23
                                densidad = text
                            Case 24
                                tipo_fluido = text
                            Case 25
                                Rapp_porcentaje = text
                            Case 26
                                diametro_thruster = text
                            Case 27
                                coef_thruster = text
                            Case 28
                                calculo_raap = text
                            Case 29
                                area_transom = text
                            Case 30
                                tipo_propulsion = text
                            Case 31
                                diametro_helice = text
                            Case 32
                                area_expandida = text
                            Case 33
                                angulo_entrada = text
                            Case 34
                                area_frontal = text
                            Case 35
                                num_helices = text
                            Case 36
                                paso = text

                        End Select

                        lineNumber += 1
                    End While
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        guardar()
    End Sub
    Sub guardar()

        Try
            SaveFileDialog1.Filter = "rt files (*.rt)|*.rt|All files (*.*)|*.*"
            SaveFileDialog1.FilterIndex = 1
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                ruta_archivo = SaveFileDialog1.FileName
            End If

            Dim obj As New Object

            Dim archivo As New Object

            Dim ruta As String = ruta_archivo 'Ej: Documentos\archivo1.txt



            obj = CreateObject("Scripting.FileSystemObject")

            archivo = obj.CreateTextFile(ruta, True)

            'Luego agregas las lineas que quieras al archivo
            archivo.WriteLine("")
            archivo.WriteLine("" & proyecto & "")
            archivo.WriteLine("" & embarcacion & "")
            archivo.WriteLine("" & ingeniero & "")
            archivo.WriteLine("" & eslora_wl & "")
            archivo.WriteLine("" & manga_wl & "")
            archivo.WriteLine("" & puntal & "")
            archivo.WriteLine("" & calado_popa & "")
            archivo.WriteLine("" & calado_proa & "")
            archivo.WriteLine("" & calado_medio & "")
            archivo.WriteLine("" & LCBporcentaje & "")
            archivo.WriteLine("" & LCBmetrico & "")
            archivo.WriteLine("" & Cblock & "")
            archivo.WriteLine("" & Cwaterplane & "")
            archivo.WriteLine("" & Cmaestra & "")
            archivo.WriteLine("" & Cprismatico & "")
            archivo.WriteLine("" & desplazamiento & "")
            archivo.WriteLine("" & Vs & "")
            archivo.WriteLine("" & aceleracion & "")
            archivo.WriteLine("" & factor_formas & "")
            archivo.WriteLine("" & viscosidad_cinematica & "")
            archivo.WriteLine("" & forma_casco & "")
            archivo.WriteLine("" & Cstern & "")
            archivo.WriteLine("" & densidad & "")
            archivo.WriteLine("" & tipo_fluido & "")
            archivo.WriteLine("" & Rapp_porcentaje & "")
            archivo.WriteLine("" & diametro_thruster & "")
            archivo.WriteLine("" & coef_thruster & "")
            archivo.WriteLine("" & calculo_raap & "")
            archivo.WriteLine("" & area_transom & "")
            archivo.WriteLine("" & tipo_propulsion & "")
            archivo.WriteLine("" & diametro_helice & "")
            archivo.WriteLine("" & area_expandida & "")
            archivo.WriteLine("" & angulo_entrada & "")
            archivo.WriteLine("" & area_frontal & "")
            archivo.WriteLine("" & num_helices & "")
            archivo.WriteLine("" & paso & "")

            archivo.close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click


    End Sub

    Private Sub HoltropToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HoltropToolStripMenuItem.Click
        If dtholtrop.Rows.Count = 0 Then
            MsgBox("No existen calculos para el metodo de Holtrop.", MsgBoxStyle.Exclamation, "INFORMACION")
        Else

            almacenar_holtrop() 'calculos
            almacenar_savitsky()
            llenar_datos()
            llamar_reporte()

        End If

    End Sub
  
    Sub llenar_datos()


        Dim ds As New DataSet_RT
        Dim dtw As DataRow
        dtw = ds.tabla_datos.NewRow
        dtw("proyecto") = dt_datos.Rows(0).Item("proyecto")
        dtw("embarcacion") = dt_datos.Rows(0).Item("embarcacion")
        dtw("ingeniero") = dt_datos.Rows(0).Item("ingeniero")
        dtw("l") = dt_datos.Rows(0).Item("l")
        dtw("b") = dt_datos.Rows(0).Item("b")
        dtw("tm") = dt_datos.Rows(0).Item("tm")
        dtw("ta") = dt_datos.Rows(0).Item("ta")
        dtw("tf") = dt_datos.Rows(0).Item("tf")
        dtw("s") = dt_datos.Rows(0).Item("s")
        dtw("cp") = dt_datos.Rows(0).Item("cp")
        dtw("cb") = dt_datos.Rows(0).Item("cb")
        dtw("cwp") = dt_datos.Rows(0).Item("cwp")
        dtw("transom") = dt_datos.Rows(0).Item("transom")
        dtw("area_b") = dt_datos.Rows(0).Item("area_b")
        dtw("altura_b") = dt_datos.Rows(0).Item("altura_b")
        dtw("area_apendices") = dt_datos.Rows(0).Item("area_apendices")
        dtw("fluido") = dt_datos.Rows(0).Item("fluido")
        dtw("densidad") = dt_datos.Rows(0).Item("densidad")
        dtw("viscosidad") = dt_datos.Rows(0).Item("viscosidad")
        dtw("vs") = dt_datos.Rows(0).Item("vs")
        dtw("desplazamiento") = dt_datos.Rows(0).Item("desplazamiento")
        ds.tabla_datos.Rows.Add(dtw)

        fuente1.Name = "datos"
        fuente1.Value = ds.Tables(1)


    End Sub

    Private Sub GraficosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GraficosToolStripMenuItem.Click
        Form_grafico.MdiParent = Me
        Form_grafico.WindowState = FormWindowState.Normal
        Form_grafico.Show()
    End Sub

    Private Sub CascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)
    End Sub


    Private Sub CerrarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarTodoToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal)
    End Sub

    Private Sub MinimizarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizarTodoToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical)
    End Sub


    Private Sub GraficosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GraficosToolStripMenuItem1.Click
        Form_grafico.MdiParent = Me
        Form_grafico.WindowState = FormWindowState.Normal
        Form_grafico.Show()
    End Sub

    Private Sub ResultadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResultadosToolStripMenuItem.Click
        Forma_holtrop.MdiParent = Me
        Forma_holtrop.WindowState = FormWindowState.Normal
        Forma_holtrop.Show()
    End Sub

    Private Sub ReportesToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub ToolStripMenuItem23_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CrystalToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        abrir()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        guardar()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Form_datos_proyecto.ShowDialog()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Datos_casco.MdiParent = Me
        Datos_casco.Show()
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        Form_datos_forma_casco.MdiParent = Me
        Form_datos_forma_casco.Show()
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        Form_datos_propusion.MdiParent = Me
        Form_datos_propusion.Show()
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        Form_datos_fluido.MdiParent = Me
        Form_datos_fluido.Show()
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        Form_apendices.MdiParent = Me
        Form_apendices.Show()
    End Sub

    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles ToolStripButton13.Click
        Form_solucion_Holtrop_mennem.MdiParent = Me
        Form_solucion_Holtrop_mennem.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Form_grafico.MdiParent = Me
        Form_grafico.WindowState = FormWindowState.Normal
        Form_grafico.Show()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click


        Forma_holtrop.MdiParent = Me
        Forma_holtrop.WindowState = FormWindowState.Normal
        Forma_holtrop.Show()

        Forma_savitsky.MdiParent = Me
        Forma_savitsky.WindowState = FormWindowState.Normal
        Forma_savitsky.Show()
    End Sub

    Private Sub MetodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MetodosToolStripMenuItem.Click
       
    End Sub

    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        Form_metodos.MdiParent = Me
        Form_metodos.Show()
    End Sub

    Private Sub SeleccionarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarToolStripMenuItem.Click
        Form_metodos.MdiParent = Me
        Form_metodos.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub HoltropToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HoltropToolStripMenuItem1.Click
        Forma_holtrop.MdiParent = Me
        Forma_holtrop.WindowState = FormWindowState.Normal

        Forma_holtrop.Show()
    End Sub

  



    Private Sub TodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodosToolStripMenuItem.Click
        Forma_savitsky.MdiParent = Me
        Forma_savitsky.WindowState = FormWindowState.Normal
        Forma_savitsky.Show()
        Forma_holtrop.MdiParent = Me
        Forma_holtrop.WindowState = FormWindowState.Normal
        Forma_holtrop.Show()


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PruebasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PruebasToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        If dtsavitsky.Rows.Count = 0 And dtholtrop.Rows.Count = 0 Then
            MsgBox("No existen cálculos para ningún método.", MsgBoxStyle.Exclamation, "INFORMACIÓN")
        Else
            If metodo_holtrop = True Then
                almacenar_holtrop() 'calculos
                llenar_datos()

            End If
            If metodo_savitsky = True Then
                almacenar_savitsky()
                llenar_datos()

            End If
            If metodo_holtrop = True Or metodo_savitsky = True Then
                llamar_reporte()
            End If

        End If
    End Sub



    Private Sub SavitskyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SavitskyToolStripMenuItem.Click
        If dtsavitsky.Rows.Count = 0 Then
            MsgBox("No existen cálculos para el metodo de Savitsky.", MsgBoxStyle.Exclamation, "INFORMACIÓN")
        Else
            almacenar_holtrop()
            almacenar_savitsky()
            llenar_datos()
            llamar_reporte()

        End If
    End Sub
    Sub almacenar_savitsky()
        Dim ds As New DataSet_RT
        Dim dtw As DataRow
        For i As Integer = 0 To dtsavitsky.Rows.Count - 1
            dtw = ds.tabla_savitsky.NewRow
            dtw("vb_kn") = dtsavitsky.Rows(i).Item("vb_kn")
            dtw("vb_ms") = dtsavitsky.Rows(i).Item("vb_ms")
            dtw("fn") = dtsavitsky.Rows(i).Item("fn")
            dtw("fnvol") = dtsavitsky.Rows(i).Item("fnvol")
            dtw("rapp") = dtsavitsky.Rows(i).Item("rapp")
            dtw("raire") = dtsavitsky.Rows(i).Item("raire")
            dtw("rtotal") = dtsavitsky.Rows(i).Item("rtotal")
            dtw("ehp") = dtsavitsky.Rows(i).Item("ehp")

            ds.tabla_savitsky.Rows.Add(dtw)

        Next
        fuente2.Name = "resultados_savitsky"
        fuente2.Value = ds.Tables(2)
    End Sub
    Private Sub PlaneoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlaneoToolStripMenuItem.Click
        If metodo_holtrop = False And metodo_savitsky = False Then
            MsgBox("Seleccionar al menos un método de cálculo.", MsgBoxStyle.Exclamation, "INFORMACIÓN IMPORTANTE")
        Else
            form_datos_savitsky.MdiParent = Me
            form_datos_savitsky.Show()
        End If

    End Sub

    Private Sub FactorDeServicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FactorDeServicioToolStripMenuItem.Click
        Form_factor_servicio.MdiParent = Me
        Form_factor_servicio.Show()
    End Sub

    Private Sub SavitskyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SavitskyToolStripMenuItem1.Click
        Forma_savitsky.MdiParent = Me
        Forma_savitsky.WindowState = FormWindowState.Normal
        Forma_savitsky.Show()
    End Sub


    Private Sub TodosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TodosToolStripMenuItem1.Click
        If dtsavitsky.Rows.Count = 0 And dtholtrop.Rows.Count = 0 Then
            MsgBox("No existen cálculos para ningún método.", MsgBoxStyle.Exclamation, "INFORMACIÓN")
        Else
            If metodo_holtrop = True Then
                almacenar_holtrop() 'calculos
                llenar_datos()

            End If
            If metodo_savitsky = True Then
                almacenar_savitsky()
                llenar_datos()

            End If
            If metodo_holtrop = True Or metodo_savitsky = True Then
                llamar_reporte()
            End If

        End If
    End Sub
End Class
