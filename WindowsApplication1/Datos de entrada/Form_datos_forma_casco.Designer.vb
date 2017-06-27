<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_datos_forma_casco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_datos_forma_casco))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_normal = New System.Windows.Forms.RadioButton()
        Me.rb_u = New System.Windows.Forms.RadioButton()
        Me.rb_v = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_centro_area_bulbo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_area_transv_bulbo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_area_transom = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_rea_seccion_media = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_normal)
        Me.GroupBox1.Controls.Add(Me.rb_u)
        Me.GroupBox1.Controls.Add(Me.rb_v)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 147)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Forma de popa"
        '
        'rb_normal
        '
        Me.rb_normal.AutoSize = True
        Me.rb_normal.Location = New System.Drawing.Point(23, 62)
        Me.rb_normal.Name = "rb_normal"
        Me.rb_normal.Size = New System.Drawing.Size(143, 22)
        Me.rb_normal.TabIndex = 2
        Me.rb_normal.TabStop = True
        Me.rb_normal.Text = "Forma de Normal"
        Me.rb_normal.UseVisualStyleBackColor = True
        '
        'rb_u
        '
        Me.rb_u.AutoSize = True
        Me.rb_u.Location = New System.Drawing.Point(23, 101)
        Me.rb_u.Name = "rb_u"
        Me.rb_u.Size = New System.Drawing.Size(181, 22)
        Me.rb_u.TabIndex = 1
        Me.rb_u.TabStop = True
        Me.rb_u.Text = "Forma de sección en U"
        Me.rb_u.UseVisualStyleBackColor = True
        '
        'rb_v
        '
        Me.rb_v.AutoSize = True
        Me.rb_v.Location = New System.Drawing.Point(23, 23)
        Me.rb_v.Name = "rb_v"
        Me.rb_v.Size = New System.Drawing.Size(179, 22)
        Me.rb_v.TabIndex = 0
        Me.rb_v.TabStop = True
        Me.rb_v.Text = "Forma de sección en V"
        Me.rb_v.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(Me.txt_centro_area_bulbo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_area_transv_bulbo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(304, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(542, 147)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bulbo"
        '
        'txt_centro_area_bulbo
        '
        Me.txt_centro_area_bulbo.Location = New System.Drawing.Point(366, 62)
        Me.txt_centro_area_bulbo.Name = "txt_centro_area_bulbo"
        Me.txt_centro_area_bulbo.Size = New System.Drawing.Size(100, 24)
        Me.txt_centro_area_bulbo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(346, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Centro de area vertical del bulbo desde la quilla (m):"
        '
        'txt_area_transv_bulbo
        '
        Me.txt_area_transv_bulbo.Location = New System.Drawing.Point(366, 28)
        Me.txt_area_transv_bulbo.Name = "txt_area_transv_bulbo"
        Me.txt_area_transv_bulbo.Size = New System.Drawing.Size(100, 24)
        Me.txt_area_transv_bulbo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Area transversal del bulbo (m^2):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(426, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Area (sumergida) transversal del espejo a velocidad cero (m^2):"
        '
        'txt_area_transom
        '
        Me.txt_area_transom.Location = New System.Drawing.Point(556, 36)
        Me.txt_area_transom.Name = "txt_area_transom"
        Me.txt_area_transom.Size = New System.Drawing.Size(116, 24)
        Me.txt_area_transom.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_rea_seccion_media)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txt_area_transom)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 165)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(701, 145)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Areas transversales"
        '
        'txt_rea_seccion_media
        '
        Me.txt_rea_seccion_media.Location = New System.Drawing.Point(556, 78)
        Me.txt_rea_seccion_media.Name = "txt_rea_seccion_media"
        Me.txt_rea_seccion_media.Size = New System.Drawing.Size(116, 24)
        Me.txt_rea_seccion_media.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(490, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Area (sumergida) transversal de la sección media a velocidad cero (m^2):"
        '
        'btn_salir
        '
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.Location = New System.Drawing.Point(741, 218)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(105, 35)
        Me.btn_salir.TabIndex = 8
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.Location = New System.Drawing.Point(741, 168)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(105, 35)
        Me.btn_guardar.TabIndex = 7
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(214, 105)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(82, 18)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Ver imagen"
        '
        'Form_datos_forma_casco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 322)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_datos_forma_casco"
        Me.Text = "DATOS FORMA DEL CASCO Y BULBO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_normal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_u As System.Windows.Forms.RadioButton
    Friend WithEvents rb_v As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_centro_area_bulbo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_area_transv_bulbo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_area_transom As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txt_rea_seccion_media As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
