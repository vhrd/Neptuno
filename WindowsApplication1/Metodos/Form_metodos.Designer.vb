<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_metodos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_metodos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chb_holtrop = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chb_radojcic = New System.Windows.Forms.CheckBox()
        Me.chb_savitsky = New System.Windows.Forms.CheckBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chb_holtrop)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 59)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Desplazamiento"
        '
        'chb_holtrop
        '
        Me.chb_holtrop.AutoSize = True
        Me.chb_holtrop.Location = New System.Drawing.Point(21, 29)
        Me.chb_holtrop.Name = "chb_holtrop"
        Me.chb_holtrop.Size = New System.Drawing.Size(60, 17)
        Me.chb_holtrop.TabIndex = 0
        Me.chb_holtrop.Text = "Holtrop"
        Me.chb_holtrop.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chb_radojcic)
        Me.GroupBox2.Controls.Add(Me.chb_savitsky)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 60)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Planeo y semi-planeo"
        '
        'chb_radojcic
        '
        Me.chb_radojcic.AutoSize = True
        Me.chb_radojcic.Location = New System.Drawing.Point(107, 66)
        Me.chb_radojcic.Name = "chb_radojcic"
        Me.chb_radojcic.Size = New System.Drawing.Size(68, 17)
        Me.chb_radojcic.TabIndex = 2
        Me.chb_radojcic.Text = "Radojcic"
        Me.chb_radojcic.UseVisualStyleBackColor = True
        '
        'chb_savitsky
        '
        Me.chb_savitsky.AutoSize = True
        Me.chb_savitsky.Location = New System.Drawing.Point(21, 29)
        Me.chb_savitsky.Name = "chb_savitsky"
        Me.chb_savitsky.Size = New System.Drawing.Size(66, 17)
        Me.chb_savitsky.TabIndex = 1
        Me.chb_savitsky.Text = "Savitsky"
        Me.chb_savitsky.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.Location = New System.Drawing.Point(117, 149)
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
        Me.btn_guardar.Location = New System.Drawing.Point(21, 149)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(83, 35)
        Me.btn_guardar.TabIndex = 5
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Form_metodos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 199)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_metodos"
        Me.Text = "MÉTODOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chb_holtrop As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chb_savitsky As System.Windows.Forms.CheckBox
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents chb_radojcic As System.Windows.Forms.CheckBox
End Class
