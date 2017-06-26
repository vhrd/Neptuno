<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_solucion_Holtrop_mennem
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_solucion_Holtrop_mennem))
        Me.btn_ejecutar = New System.Windows.Forms.Button()
        Me.txt_velocidad_inicial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_velocidad_final = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_incremento = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_ejecutar
        '
        Me.btn_ejecutar.Image = CType(resources.GetObject("btn_ejecutar.Image"), System.Drawing.Image)
        Me.btn_ejecutar.Location = New System.Drawing.Point(249, 128)
        Me.btn_ejecutar.Name = "btn_ejecutar"
        Me.btn_ejecutar.Size = New System.Drawing.Size(87, 38)
        Me.btn_ejecutar.TabIndex = 0
        Me.btn_ejecutar.Text = "Ejecutar"
        Me.btn_ejecutar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ejecutar.UseVisualStyleBackColor = True
        '
        'txt_velocidad_inicial
        '
        Me.txt_velocidad_inicial.Location = New System.Drawing.Point(124, 25)
        Me.txt_velocidad_inicial.Name = "txt_velocidad_inicial"
        Me.txt_velocidad_inicial.Size = New System.Drawing.Size(100, 24)
        Me.txt_velocidad_inicial.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Velocidad inicial:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Velocidad final:"
        '
        'txt_velocidad_final
        '
        Me.txt_velocidad_final.Location = New System.Drawing.Point(124, 64)
        Me.txt_velocidad_final.Name = "txt_velocidad_final"
        Me.txt_velocidad_final.Size = New System.Drawing.Size(100, 24)
        Me.txt_velocidad_final.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(320, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Incremento:"
        '
        'txt_incremento
        '
        Me.txt_incremento.Location = New System.Drawing.Point(409, 28)
        Me.txt_incremento.Name = "txt_incremento"
        Me.txt_incremento.Size = New System.Drawing.Size(100, 24)
        Me.txt_incremento.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_velocidad_inicial)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_incremento)
        Me.GroupBox1.Controls.Add(Me.txt_velocidad_final)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 109)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos para el analisis"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(234, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Kn"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(234, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Kn"
        '
        'Form_solucion_Holtrop_mennem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 178)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_ejecutar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_solucion_Holtrop_mennem"
        Me.Text = "HOLTROP AND MENNEM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_ejecutar As System.Windows.Forms.Button
    Friend WithEvents txt_velocidad_inicial As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_velocidad_final As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_incremento As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
