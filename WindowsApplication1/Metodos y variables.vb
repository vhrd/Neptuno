Imports Vb = Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Math
Imports Microsoft.Reporting.WinForms
Module Variables
    Public metodo_holtrop As Boolean
    Public metodo_savitsky As Boolean
    Public metodo_radojcic As Boolean

    Public proyecto As String = "Proyecto01"
    Public embarcacion As String = "Embarcación01"
    Public ingeniero As String = "Ingeniero01"
    
    Public eslora_total As Decimal
    Public eslora_wl As Decimal = 205

    Public manga_maxima As Decimal
    Public manga_wl As Decimal = 32

    Public puntal As Decimal = 15

    Public calado_popa As Decimal = 10
    Public calado_proa As Decimal = 10
    Public calado_medio As Decimal = 10
    Public LCBporcentaje As Decimal = -0.75
    Public LCBmetrico As Decimal

    Public Cblock As Decimal = 0.5716
    Public Cwaterplane As Decimal = 0.75
    Public Cmaestra As Decimal = 0.98
    Public Cprismatico As Decimal = 0.5833

    Public desplazamiento As Decimal = 37500 * densidad
    Public Vs As Decimal = 37500

    Public Sapp As Decimal

    Public aceleracion As Decimal = 9.80665

    Public factor_formas As Decimal

    Public viscocidad_cinematica_mar As Decimal = 1.14 * 10 ^ -6

    'bulbo y forma de casco
    Public c13 As Decimal
    Public forma_casco As String = "u"
    Public Cstern As Integer = 10

    Public areaT_bulbo As Decimal = 20
    Public centroV_area_bulbo As Decimal = 4

    'datos del fluido
    Public densidad As Decimal = 1025.87
    Public viscosidad_cinematica As Decimal = 0.00000118831
    Public tipo_fluido As String = "agua_mar"

    Public Fn As Decimal

    Public factor_formas_eq As Decimal

    Public I As Decimal
    Public II As Decimal
    Public III As Decimal
    Public IV As Decimal
    Public V As Decimal
    Public VI As Decimal
    Public VII As Decimal
    Public VIII As Decimal
    Public IX As Decimal
    Public X As Decimal

    Public I_ As Decimal
    Public II_ As Decimal
    Public III_ As Decimal
    Public IV_ As Decimal
    Public V_ As Decimal
    Public VI_ As Decimal
    Public VII_ As Decimal
    Public VIII_ As Decimal
    Public IX_ As Decimal
    Public X_ As Decimal

    Public Rapp_porcentaje As Decimal = 3
    Public Area_mojada As Decimal
    Public diametro_thruster As Decimal
    Public coef_thruster As Decimal
    Public calculo_raap As Integer = 1
    Public area_transom As Decimal = 16
    Public area_amidship As Decimal = 16

    Public ruta_archivo As String
    Public tipo_propulsion As String = ""
    Public diametro_helice As Decimal = 8
    Public area_expandida As Decimal = 0.7393
    Public angulo_entrada As Decimal = 0
    Public cr As Decimal = 0
    Public raire As Decimal = 0
    Public w As Decimal = 0
    Public t As Decimal = 0
    Public area_frontal As Decimal = 0
    Public num_helices As Integer = 1
    Public paso As Decimal

    Public dtholtrop As DataTable
    Public row_holtrop As DataRow
    Public ds_holtrop As DataSet

    Public dtradojcic As DataTable
    Public row_radojcic As DataRow
    Public ds_radojcic As DataSet

    Public dtsavitsky As DataTable
    Public row_savitsky As DataRow
    Public ds_savitsky As DataSet

    Public dt_datos As DataTable
    Public row_datos As DataRow


    'variables planeo
    Public Bpx As Decimal = 0
    Public iee As Decimal
    Public AT As Decimal
    Public Ax As Decimal

    Public densidad_aire As Decimal = 1.2929999999999999
    Public factor_servicio As Decimal

    'valores vectores 
    Public A1() As Decimal = {0, 0.064729999999999996, 0.10775999999999999, 0.094829999999999998, 0.034750000000000003, 0.030130000000000001, 0.031629999999999998, 0.031940000000000003, 0.043430000000000003, 0.050360000000000002, 0.056120000000000003, 0.059670000000000001}
    Public A2() As Decimal = {0, -0.48680000000000001, -0.88787000000000005, -0.63719999999999999, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0}
    Public A4() As Decimal = {0, -0.0103, -0.01634, -0.0154, -0.0097800000000000005, -0.0066400000000000001, 0, 0, 0, 0, 0, 0}
    Public A5() As Decimal = {0, 0.064899999999999999, -0.13444, -0.1358, -0.050970000000000001, -0.055399999999999998, -0.10543, -0.085989999999999997, -0.13289000000000001, -0.15597, -0.18661, -0.19758000000000001}
    Public A6() As Decimal = {0, 0, 0, -0.16045999999999999, -0.21879999999999999, -0.19359000000000001, -0.2054, -0.19442000000000001, -0.18062, -0.17813000000000001, -0.18287999999999999, 0.20152}
    Public A7() As Decimal = {0, 0.10628, 0.18185999999999999, 0.16803000000000001, 0.10434, 0.096119999999999997, 0.060069999999999998, 0.06191, 0.054870000000000002, 0.050990000000000001, 0.047440000000000003, 0.046449999999999998}
    Public A8() As Decimal = {0, 0.97309999999999997, 1.8308, 1.55972, 0.43509999999999999, 0.51819999999999999, 0.58230000000000004, 0.52049000000000001, 0.78195000000000003, 0.92859000000000003, 1.1856899999999999, 1.30026}
    Public A9() As Decimal = {0, -0.0027200000000000002, -0.0038899999999999998, -0.0030899999999999999, -0.00198, -0.00215, -0.0037200000000000002, -0.0035999999999999999, -0.00332, -0.0030799999999999998, -0.0024399999999999999, -0.0021199999999999999}
    Public A10() As Decimal = {0, 0.01089, 0.014670000000000001, 0.034810000000000001, 0.04113, 0.039010000000000003, 0.047940000000000003, 0.044359999999999997, 0.041869999999999997, 0.041110000000000001, 0.041239999999999999, 0.043430000000000003}
    Public A15() As Decimal = {0, 0, 0, 0, 0, 0, 0.083169999999999994, 0.073660000000000003, 0.12146999999999999, 0.14928, 0.18090000000000001, 0.19769}
    Public A18() As Decimal = {0, -1.4096200000000001, -2.4669599999999998, -2.1555599999999999, -0.92662999999999995, -0.95276000000000005, -0.70894999999999997, -0.72057000000000004, -0.95928999999999998, -1.12178, -1.3864399999999999, -1.5512699999999999}
    Public A19() As Decimal = {0, 0.29136000000000001, 0.47305000000000003, 1.0299199999999999, 1.06392, 0.97757000000000005, 1.19737, 1.18119, 1.01562, 0.93144000000000005, 0.78413999999999995, 0.78281999999999996}
    Public A24() As Decimal = {0, -0.02971, 0.058770000000000003, 0.051979999999999998, 0.022089999999999999, 0.024129999999999999, 0, 0, 0, 0, 0, 0}
    Public A27() As Decimal = {0, -0.0015, -0.0035599999999999998, -0.0030300000000000001, -0.0010499999999999999, -0.0014, 0, 0, 0, 0, 0, 0}

End Module
