<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class botones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(botones))
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_guardar
        '
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.Location = New System.Drawing.Point(39, 132)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(83, 35)
        Me.btn_guardar.TabIndex = 0
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.Location = New System.Drawing.Point(310, 211)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(85, 32)
        Me.btn_eliminar.TabIndex = 1
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Image = CType(resources.GetObject("btn_agregar.Image"), System.Drawing.Image)
        Me.btn_agregar.Location = New System.Drawing.Point(310, 173)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(85, 32)
        Me.btn_agregar.TabIndex = 2
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Image = CType(resources.GetObject("btn_actualizar.Image"), System.Drawing.Image)
        Me.btn_actualizar.Location = New System.Drawing.Point(310, 135)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(85, 32)
        Me.btn_actualizar.TabIndex = 3
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.Location = New System.Drawing.Point(39, 173)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(83, 35)
        Me.btn_salir.TabIndex = 4
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Image = CType(resources.GetObject("btn_modificar.Image"), System.Drawing.Image)
        Me.btn_modificar.Location = New System.Drawing.Point(412, 135)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(85, 32)
        Me.btn_modificar.TabIndex = 5
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'botones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 379)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Name = "botones"
        Me.Text = "botones"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_actualizar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
End Class
