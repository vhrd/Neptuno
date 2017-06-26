<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_datos_propusion
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_datos_propusion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_2helices = New System.Windows.Forms.RadioButton()
        Me.rb_1helice_abierta = New System.Windows.Forms.RadioButton()
        Me.rb_1helice_conv = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_paso = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_area_expandida = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_diametro_helice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_2helices)
        Me.GroupBox1.Controls.Add(Me.rb_1helice_abierta)
        Me.GroupBox1.Controls.Add(Me.rb_1helice_conv)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 194)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de propulsión"
        '
        'rb_2helices
        '
        Me.rb_2helices.AutoSize = True
        Me.rb_2helices.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_2helices.Location = New System.Drawing.Point(30, 147)
        Me.rb_2helices.Name = "rb_2helices"
        Me.rb_2helices.Size = New System.Drawing.Size(104, 22)
        Me.rb_2helices.TabIndex = 2
        Me.rb_2helices.TabStop = True
        Me.rb_2helices.Text = "Dos helices"
        Me.rb_2helices.UseVisualStyleBackColor = True
        '
        'rb_1helice_abierta
        '
        Me.rb_1helice_abierta.AutoSize = True
        Me.rb_1helice_abierta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_1helice_abierta.Location = New System.Drawing.Point(30, 88)
        Me.rb_1helice_abierta.Name = "rb_1helice_abierta"
        Me.rb_1helice_abierta.Size = New System.Drawing.Size(165, 40)
        Me.rb_1helice_abierta.TabIndex = 1
        Me.rb_1helice_abierta.TabStop = True
        Me.rb_1helice_abierta.Text = "Una hélice con popa " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "abierta"
        Me.rb_1helice_abierta.UseVisualStyleBackColor = True
        '
        'rb_1helice_conv
        '
        Me.rb_1helice_conv.AutoSize = True
        Me.rb_1helice_conv.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_1helice_conv.Location = New System.Drawing.Point(30, 29)
        Me.rb_1helice_conv.Name = "rb_1helice_conv"
        Me.rb_1helice_conv.Size = New System.Drawing.Size(165, 40)
        Me.rb_1helice_conv.TabIndex = 0
        Me.rb_1helice_conv.TabStop = True
        Me.rb_1helice_conv.Text = "Una hélice con popa " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "convencional"
        Me.rb_1helice_conv.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_paso)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_area_expandida)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_diametro_helice)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(287, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(392, 160)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de hélice"
        '
        'txt_paso
        '
        Me.txt_paso.Location = New System.Drawing.Point(224, 99)
        Me.txt_paso.Name = "txt_paso"
        Me.txt_paso.Size = New System.Drawing.Size(100, 24)
        Me.txt_paso.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Paso :"
        '
        'txt_area_expandida
        '
        Me.txt_area_expandida.Location = New System.Drawing.Point(224, 63)
        Me.txt_area_expandida.Name = "txt_area_expandida"
        Me.txt_area_expandida.Size = New System.Drawing.Size(100, 24)
        Me.txt_area_expandida.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Relación de area expandida:"
        '
        'txt_diametro_helice
        '
        Me.txt_diametro_helice.Location = New System.Drawing.Point(224, 23)
        Me.txt_diametro_helice.Name = "txt_diametro_helice"
        Me.txt_diametro_helice.Size = New System.Drawing.Size(100, 24)
        Me.txt_diametro_helice.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Diametro hélice (m):"
        '
        'btn_salir
        '
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.Location = New System.Drawing.Point(495, 178)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(83, 35)
        Me.btn_salir.TabIndex = 6
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.Location = New System.Drawing.Point(375, 178)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(83, 35)
        Me.btn_guardar.TabIndex = 5
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Form_datos_propusion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 225)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_datos_propusion"
        Me.Text = "DATOS DE PROPULSIÓN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_2helices As System.Windows.Forms.RadioButton
    Friend WithEvents rb_1helice_abierta As System.Windows.Forms.RadioButton
    Friend WithEvents rb_1helice_conv As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_diametro_helice As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_area_expandida As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents txt_paso As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
