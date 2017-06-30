<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forma_savitsky
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Forma_savitsky))
        Me.dg_savitsky = New System.Windows.Forms.DataGridView()
        CType(Me.dg_savitsky, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_savitsky
        '
        Me.dg_savitsky.BackgroundColor = System.Drawing.Color.White
        Me.dg_savitsky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_savitsky.Location = New System.Drawing.Point(1, 2)
        Me.dg_savitsky.Name = "dg_savitsky"
        Me.dg_savitsky.Size = New System.Drawing.Size(512, 236)
        Me.dg_savitsky.TabIndex = 0
        '
        'Forma_savitsky
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 254)
        Me.Controls.Add(Me.dg_savitsky)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Forma_savitsky"
        Me.Text = "RESULTADOS MÉTODO DE SAVITSKY-PREPLANEO"
        CType(Me.dg_savitsky, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dg_savitsky As System.Windows.Forms.DataGridView
End Class
