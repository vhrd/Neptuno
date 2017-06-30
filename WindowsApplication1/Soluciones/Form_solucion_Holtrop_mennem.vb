Imports Vb = Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Math
Public Class Form_solucion_Holtrop_mennem
    Dim cod_resultados As Integer
    Dim nR As Decimal
    Dim Cv As Decimal
    Dim cod_datos As Integer = 1
    Dim a As Integer
    Dim b As Integer
    Dim paso As Integer
    Dim vb_ms As Decimal
    Dim Rt As Decimal
    Dim Rnh As Decimal
    Dim Rf As Decimal
    Dim Rw As Decimal
    Dim Rapp As Decimal
    Dim Cf As Decimal
    Dim Rn As Decimal
    Dim factor_formas As Decimal
    Dim Lr As Decimal
    Dim C14 As Decimal
    Dim C15 As Decimal
    Dim C12 As Decimal

    Dim C1 As Decimal
    Dim C3 As Decimal
    Dim C5 As Decimal
    Dim C7 As Decimal
    Dim C16 As Decimal
    Dim iE As Decimal

    Dim k2eq As Decimal
    Dim BL As Decimal
    Dim TB As Decimal
    Dim LB As Decimal
    Dim BT As Decimal
    Dim LT As Decimal
    Dim lamda As Decimal
    Dim m1 As Decimal
    Dim Fn As Decimal
    Dim Fn_vol As Decimal
    Dim m2 As Decimal
    Dim d As Decimal
    Dim C2 As Decimal
    Dim Rb As Decimal
    Dim Fni As Decimal
    Dim FnT As Decimal
    Dim C6 As Decimal
    Dim Rtr As Decimal
    Dim Ca As Decimal
    Dim C4 As Decimal
    Dim Ra As Decimal

    Dim Rwb As Decimal
    Dim C17 As Decimal
    Dim m3 As Decimal
    Dim m4 As Decimal
    Dim Rwa As Decimal
    Dim vb As Decimal
    Public dtw As DataRow
    Dim ds As New DataSet_RT
    Dim ok As Integer = 0
    Private Sub btn_ejecutar_Click(sender As Object, e As EventArgs) Handles btn_ejecutar.Click
        If metodo_holtrop = False And metodo_radojcic = False And metodo_savitsky = False Then
            MsgBox("Seleccionar al menos un método de cálculo.", MsgBoxStyle.Information, "INFORMACION IMPORTANTE")
        Else

            Try
                'definir velocidades
                a = txt_velocidad_inicial.Text
                b = txt_velocidad_final.Text
                paso = 1
                ' limpiar tablas
                dt_datos.Clear()

                dtholtrop.Clear()
                'llenar datos principales de embarcacion
                llenar_datos_embarcacion()
                'calcular holtrop
                If metodo_holtrop = True Then
                    holtrop_constantes()
                    For Me.vb = a To b Step paso
                        calculo_holtrop()
                    Next
                End If
            Catch ex As Exception

            End Try
            
            Try
                'calcular savitsky
                If metodo_savitsky = True Then

                    calculo_savitsky()

                End If
            Catch ex As Exception

            End Try


            



            If ok > 0 Then
                MsgBox("Cálculos realizados correctamente.", MsgBoxStyle.OkOnly, "INFORMACION")
                Me.Close()
                Form_grafico.MdiParent = Mdi_menu
                Form_grafico.Location = New Point(665, 0)
                Form_grafico.WindowState = FormWindowState.Normal
                Form_grafico.Show()
                If metodo_savitsky = True And metodo_holtrop = False Then
                    Form_grafico.ComboBox1.SelectedIndex = 1
                    Form_grafico.llenar_grafico_savitsky()

                    Forma_savitsky.MdiParent = Mdi_menu
                    Forma_savitsky.WindowState = FormWindowState.Normal
                    Forma_savitsky.Show()
                End If
                If metodo_holtrop = True And metodo_savitsky = False Then

                    Form_grafico.llenar_grafico_holtrop()
                    Form_grafico.ComboBox1.SelectedIndex = 0
                    Forma_holtrop.MdiParent = Mdi_menu
                    Forma_holtrop.WindowState = FormWindowState.Normal
                    Forma_holtrop.Show()

                End If

                If metodo_holtrop = True And metodo_savitsky = True Then
                    Form_grafico.llenar_grafico_holtrop()
                    Form_grafico.ComboBox1.SelectedIndex = 0
                    Forma_holtrop.MdiParent = Mdi_menu
                    Forma_holtrop.WindowState = FormWindowState.Normal
                    Forma_holtrop.Show()
                End If
            End If

            
        End If
    End Sub
    Sub llenar_datos_embarcacion()

        row_datos = dt_datos.NewRow
        row_datos("proyecto") = proyecto
        row_datos("embarcacion") = embarcacion
        row_datos("ingeniero") = ingeniero
        row_datos("l") = Round(eslora_wl, 2)
        row_datos("b") = Round(manga_wl, 2)
        row_datos("tm") = Round(calado_medio, 2)
        row_datos("ta") = Round(calado_popa, 2)
        row_datos("tf") = Round(calado_proa, 2)
        row_datos("s") = Round(Area_mojada, 2)
        row_datos("cp") = Round(Cprismatico, 2)
        row_datos("cb") = Round(Cblock, 2)
        row_datos("cwp") = Round(Cwaterplane, 2)
        row_datos("transom") = Round(area_transom, 2)
        row_datos("area_b") = Round(areaT_bulbo, 2)
        row_datos("altura_b") = Round(centroV_area_bulbo, 2)
        row_datos("area_apendices") = Round(Sapp, 2)
        row_datos("fluido") = tipo_fluido
        row_datos("densidad") = Round(densidad, 2)
        row_datos("viscosidad") = Round(viscosidad_cinematica, 2)
        row_datos("vs") = Round(Vs, 2)
        row_datos("desplazamiento") = Round(desplazamiento, 2)

        dt_datos.Rows.Add(row_datos)
    End Sub
    Sub holtrop_constantes()
        Try
            Area_mojada = eslora_wl * (2 * calado_medio + manga_wl) * (Sqrt(Cmaestra)) * (0.45300000000000001 + 0.4425 * Cblock - 0.28620000000000001 * Cmaestra - 0.003467 * (manga_wl / calado_medio) + 0.36959999999999998 * Cwaterplane) + 2.3799999999999999 * (areaT_bulbo / Cblock)
        Catch ex As Exception

        End Try

    End Sub
    Sub calculo_holtrop()

        Dim BT As Decimal = manga_wl / calado_medio
        Dim L As Decimal = eslora_wl
        Dim B As Decimal = manga_wl
        Dim BL As Decimal = B / L
        Dim TL As Decimal = calado_medio / L
        Dim LB As Decimal = L / B
        Dim LT As Decimal = L / calado_medio
        Dim TB As Decimal = calado_medio / B
        Dim C13 As Decimal
        Dim densidad_m As Decimal = densidad / 9.8100000000000005
        Dim Lr As Decimal
        'CALCULO RF
        Lr = L * (1 - Cprismatico + 0.059999999999999998 * Cprismatico * LCBporcentaje / (4 * Cprismatico - 1)) 'No depende de vb

        Select Case TL 'No depende de vb
            Case Is > 0.050000000000000003
                C12 = TL ^ 0.2228446
            Case Is < 0.050000000000000003

                C12 = 48.200000000000003 * (TL - 0.02) ^ (2.0779999999999998) + 0.47994799999999999

              
            Case Is < 0.02
                C12 = 0.47994799999999999
        End Select
        C13 = 1 + 0.0030000000000000001 * Cstern
        factor_formas = C13 * (0.93000000000000005 + C12 * ((B / Lr) ^ 0.92496999999999996) * ((0.94999999999999996 - Cprismatico) ^ -0.52144800000000002) * ((1 - Cprismatico + 0.022499999999999999 * LCBporcentaje) ^ 0.69059999999999999)) 'No depende vb


        vb_ms = vb * 0.51444440000000002
        Rn = (vb_ms * eslora_wl) / (viscocidad_cinematica_mar)
        Cf = (0.074999999999999997) / ((Log10(Rn) - 2) ^ 2)
        Fn = vb_ms / Sqrt(aceleracion * eslora_wl)
        Rf = (Cf) * 0.5 * densidad * Area_mojada * (vb_ms ^ 2) / 1000 'diferencia de 3KN

        

        'CALCULO RW
        C3 = 0.56000000000000005 * ((areaT_bulbo ^ 1.5) / ((manga_wl * calado_medio) * (0.31 * Sqrt(areaT_bulbo) + calado_proa - centroV_area_bulbo)))

        iE = 1 + 89 * Exp(-(LB ^ 0.80855999999999995) * ((1 - Cwaterplane) ^ 0.30484) * ((1 - Cprismatico - 0.022499999999999999 * LCBporcentaje) ^ 0.63670000000000004) * ((Lr / manga_wl) ^ 0.34573999999999999) * (((100 * Vs) / (eslora_wl ^ 3)) ^ 0.16302))

        d = -0.90000000000000002

        Dim lvs As Decimal = (L ^ 3) / (Vs)
        Select Case lvs
            Case Is < 512
                C15 = -1.6938500000000001
            Case Is > 1726.9100000000001
                C15 = 0.0
            Case 512 To 1726.9100000000001
                C15 = -1.6938500000000001 + ((L / (Vs ^ (1 / 3))) - 8) / 2.3599999999999999
        End Select

        m2 = C15 * (Cprismatico ^ 2) * Exp(-0.10000000000000001 * (Fn ^ -2))

        Select Case Cprismatico
            Case Is < 0.80000000000000004
                C16 = 8.0798100000000002 * Cprismatico - 13.8673 * (Cprismatico ^ 2) + 6.984388 * (Cprismatico ^ 3)
            Case Is > 0.80000000000000004
                C16 = 1.73014 - 0.70669999999999999 * Cprismatico
        End Select

        m1 = 0.0140407 * LT - 1.75254 * (Vs ^ (1 / 3)) / eslora_wl - 4.7932300000000003 * BL - C16

        Select Case LB
            Case Is < 12
                lamda = 1.446 * Cprismatico - 0.029999999999999999 * LB
            Case LB > 12
                lamda = 1.446 * Cprismatico - 0.35999999999999999
        End Select



        C5 = 1 - 0.80000000000000004 * area_transom / (B * calado_medio * Cmaestra)
        C2 = Exp(-1.8899999999999999 * Sqrt(C3))
     


        Select Case BL
            Case Is < 0.11
                C7 = 0.229577 * BL ^ 0.33333000000000002
            Case 0.11 To 0.25
                C7 = BL
            Case Is > 0.25
                C7 = 0.5 - 0.0625 * LB
        End Select

        C1 = 2223105 * (C7 ^ 3.78613) * (TB ^ 1.07961) * (90 - iE) ^ -1.37565

        Rw = (C1 * C2 * C5 * Vs * densidad * aceleracion * Exp(m1 * (Fn ^ d) + m2 * Cos(lamda * (Fn ^ -2)))) / 1000

        'CALCULAR Rb

        Dim Pb As Decimal = 0.56000000000000005 * Sqrt(areaT_bulbo) / (calado_proa - 1.5 * centroV_area_bulbo)
        Fni = vb_ms / Sqrt(aceleracion * (calado_proa - centroV_area_bulbo - 0.25 * Sqrt(areaT_bulbo)) + 0.14999999999999999 * (vb_ms ^ 2))
        Rb = (0.11 * Exp(-3 * Pb ^ -2) * (Fni ^ 3) * (areaT_bulbo ^ 1.5) * (densidad * aceleracion) / (1 + (Fni ^ 2))) / 1000

        'CALCULAR Rtr
        FnT = vb_ms / Sqrt(2 * aceleracion * area_transom / (manga_wl + manga_wl * Cwaterplane))
        Select Case FnT
            Case Is < 5
                C6 = 0.20000000000000001 * (1 - 0.20000000000000001 * FnT)
            Case Is >= 5
                C6 = 0
        End Select
        Rtr = (0.5 * densidad * (vb_ms ^ 2) * area_transom * C6) / (1000)

        'CALCULAR Ra

        Dim Tf As Decimal = calado_proa / eslora_wl
        Select Case Tf
            Case Is <= 0.040000000000000001
                C4 = Tf
            Case Is > 0.040000000000000001
                C4 = 0.040000000000000001
        End Select
        Ca = 0.0060000000000000001 * ((eslora_wl + 100) ^ -0.16) - 0.0020500000000000002 + 0.0030000000000000001 * Sqrt(eslora_wl / 7.5) * (Cblock ^ 4) * C2 * (0.040000000000000001 - C4)
        Dim Ks As Decimal = 150 * 10 ^ -6
        Ca = Ca + ((0.105 * Ks ^ (1 / 3)) - 0.0055789999999999998) / (L ^ (1 / 3))

        Ra = (0.5 * (densidad) * (vb_ms ^ 2) * Ca * Area_mojada) / 1000

        'CALCULO Rt

        Rt = Rf * (factor_formas) + Rapp + Rw + Rb + Rtr + Ra

        'CALCULO RAPP
        If areas_apendinces = True Then

            Sapp = (I + II + III + IV + V + VI + VII + VIII + +IX + X)
            k2eq = (I * I_ + II * II_ + III * III_ + IV * IV_ + V * V_ + VI * VI_ + VII * VII_ * VIII * VIII_ + IX * IX_ + X * X_) / (Sapp)

            Dim rapp_thruster As Decimal = (densidad / aceleracion) * (vb_ms ^ 2) * coef_thruster * PI * diametro_thruster ^ 2
            Rapp = 0.5 * (densidad / aceleracion) * (vb_ms ^ 2) * Sapp * (k2eq) * Cf
        Else
            Rapp = (Rapp_porcentaje / 100) * Rt
        End If

        row_holtrop = dtholtrop.NewRow
        row_holtrop("vb") = Round(vb, 2)
        row_holtrop("vb_ms") = Round(vb_ms, 2)
        row_holtrop("fn") = Round(Fn, 2)
        row_holtrop("rf") = Round(Rf, 2)
        row_holtrop("rapp") = Round(Rapp, 2)
        row_holtrop("rw") = Round(Rw, 2)
        row_holtrop("rb") = Round(Rb, 2)
        row_holtrop("rtr") = Round(Rtr, 2)
        row_holtrop("ra") = Round(Ra, 2)
        row_holtrop("rt") = Round(Rt, 2)
        row_holtrop("ehp") = Round(Rt * vb_ms, 2)

        dtholtrop.Rows.Add(row_holtrop)
        ok = ok + 1

    End Sub
  
    
   
    Sub calculo_radojcic()
        Dim A As Decimal
        Dim B As Decimal
        Dim C As Decimal
        Dim D As Decimal
        Dim FACTOR As Decimal = eslora_wl / (Vs ^ (1 / 3))
        vb_ms = vb * 0.51439999999999997
        Fn = vb_ms / Sqrt(aceleracion * eslora_wl)

        A = -0.0048694000000000003 * ((FACTOR) ^ 4) + 0.1057838 * (FACTOR ^ 3) - 0.8432151 * (FACTOR ^ 2) + 2.8994540999999998 * FACTOR - 3.5683178999999998
        B = 0.030122099999999999 * (FACTOR ^ 4) - 0.65626510000000005 * (FACTOR ^ 3) + 5.2443776 * (FACTOR ^ 2) - 18.056059999999999 * FACTOR + 22.165677800000001
        C = -0.050881000000000003 * (FACTOR ^ 4) + 1.1119496 * (FACTOR ^ 3) - 8.9006694 * (FACTOR ^ 2) + 30.606677900000001 * FACTOR - 37.211255700000002
        D = 0.020913999999999999 * (FACTOR ^ 4) - 0.45732610000000001 * (FACTOR ^ 3) + 3.6580100999999998 * (FACTOR ^ 2) - 12.543146699999999 * FACTOR + 15.14353
        Rnh = desplazamiento * (A * (Fn_vol ^ 3) + B * (Fn_vol ^ 2) + C * Fn_vol + D)
        Rnh = Rnh / 1000
        Me.Rapp = (Rapp_porcentaje / 100) * Rnh
        row_radojcic = dtradojcic.NewRow
        row_radojcic("vb_kn") = Round(vb, 2)
        row_radojcic("vb_ms") = Round(vb_ms, 2)
        row_radojcic("fn") = Round(Fn, 2)
        row_radojcic("rnh") = Round(Me.Rnh, 2)
        row_radojcic("rapp") = Round(Me.Rapp, 2)
        row_radojcic("rtotal") = Round((Rnh + Rapp), 2)
        row_radojcic("ehp") = Round(((Rnh + Rapp) * vb_ms), 2)

        dtradojcic.Rows.Add(row_radojcic)
    End Sub
    Sub calculo_savitsky()
        'calculo preplaneo
        Dim arraylist_param As New ArrayList
        Dim variable As String = ""
        If eslora_wl = 0 Then
            arraylist_param.Add("Eslora")
        End If
        If manga_wl = 0 Then
            arraylist_param.Add("Manga")
        End If

        If Vs = 0 Then
            arraylist_param.Add("Coeficiente de block")
        End If
        If area_transom = 0 Then
            arraylist_param.Add("Area sumergida espejo")
        End If
        If area_amidship = 0 Then
            arraylist_param.Add("Area sección media")
        End If

        If arraylist_param.Count > 0 Then
            Dim n As Integer
            For n = 0 To arraylist_param.Count - 1
                variable = variable + "," + arraylist_param.Item(n).ToString
            Next

            MsgBox("Falta ingresar las siguiente medidas para el método de Savitsky:" & variable & " ", MsgBoxStyle.Critical, "INFORMACION IMPORTANTE")
        Else
            Dim Tmfeet As Decimal = calado_medio * 3.28084
            Dim Lfeet As Decimal = eslora_wl * 3.28084
            Dim Bpxfeet As Decimal = Bpx * 3.28084
            Dim Vsfeet As Decimal = Vs * 35.314700000000002
            Dim Lvs13 As Decimal = Lfeet / (Vsfeet ^ (1 / 3))
            Dim Atfeet As Decimal = area_transom * 10.7639
            Dim Axfeet As Decimal = area_amidship * 10.7639
            Dim Bx_feet As Decimal = manga_wl * 3.28084
            Dim wetted_area As Decimal = 2.262 * Sqrt(Lvs13) * (1 + 0.045999999999999999 * (Bx_feet / Tmfeet) + 0.0028700000000000002 * (Bx_feet / Tmfeet) ^ 2)
            Dim Cf_100 As Decimal
            Dim Rn_100 As Decimal
            Dim desplazamiento_lbs As Decimal = Vs * densidad * 2.2046199999999998
            Dim Rt_100 As Decimal
            Dim X, Z, U, W As Decimal
            X = (Vsfeet ^ (1 / 3)) / Lfeet
            Z = Vsfeet / (Bpxfeet ^ 3)
            U = Sqrt(2 * iee)
            W = Atfeet / Axfeet

            Dim i As Decimal
            Dim n As Integer = 0
            Ca = 0
            dtsavitsky.Clear()

            For i = 1.0 To 2.0 Step 0.10000000000000001
                vb_ms = i * Sqrt(aceleracion * Vs ^ (1 / 3))
                vb = vb_ms / 0.51439999999999997
                n = n + 1

                Rt_100 = (A1(n) * 1 + A2(n) * X + A4(n) * U + A5(n) * W + A6(n) * X * Z + A7(n) * X * U + A8(n) * X * W + A9(n) * Z * U + A10(n) * Z * W + A15(n) * (W ^ 2) + A18(n) * X * (W ^ 2) + A19(n) * Z * (X ^ 2) + A24(n) * U * (W ^ 2) + A27(n) * W * (U ^ 2))

                Rn_100 = 17500544 * i * Lvs13
                Cf_100 = 0.074999999999999997 / ((Log10(Rn_100) - 2) ^ 2)


                Fn = vb_ms / (Sqrt(aceleracion * eslora_wl))

                Rn = i * Lvs13 * Sqrt(32.200000000000003 * desplazamiento_lbs / 64) / 0.000012816999999999999
                Cf = 0.074999999999999997 / ((Log10(Rn) - 2) ^ 2)

                Rt = (Rt_100 + ((Cf + Ca) - Cf_100) * 0.5 * wetted_area * (i ^ 2)) * desplazamiento_lbs
                Rt = Rt * 0.453592 * aceleracion / 1000

                row_savitsky = dtsavitsky.NewRow
                row_savitsky("vb_kn") = Round(vb, 2)
                row_savitsky("vb_ms") = Round(vb_ms, 2)
                row_savitsky("fn") = Round(Fn, 2)
                row_savitsky("fnvol") = Round(i, 2)
                row_savitsky("rapp") = Round(Me.Rapp, 2)
                row_savitsky("raire") = Round(raire, 2)
                row_savitsky("rtotal") = Round(Rt + Rapp + raire, 2)
                row_savitsky("ehp") = Round(Rt * vb_ms, 2) 'Pe en KW

                dtsavitsky.Rows.Add(row_savitsky)

            Next
            ok = ok + 1
        End If





    End Sub

    Private Sub Form_solucion_Holtrop_mennem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_incremento.Text = 1
        txt_velocidad_final.Text = 25

        txt_velocidad_inicial.Text = 5

    End Sub

End Class