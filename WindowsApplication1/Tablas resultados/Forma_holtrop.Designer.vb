<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forma_holtrop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Forma_holtrop))
        Me.datagrid_1 = New System.Windows.Forms.DataGridView()
        Me.DataSet_RT = New Neptuno.DataSet_RT()
        Me.TablartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.datagrid_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_RT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datagrid_1
        '
        Me.datagrid_1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.datagrid_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_1.Location = New System.Drawing.Point(0, 0)
        Me.datagrid_1.Name = "datagrid_1"
        Me.datagrid_1.Size = New System.Drawing.Size(649, 283)
        Me.datagrid_1.TabIndex = 0
        '
        'DataSet_RT
        '
        Me.DataSet_RT.DataSetName = "DataSet_RT"
        Me.DataSet_RT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TablartBindingSource
        '
        Me.TablartBindingSource.DataMember = "tabla_rt"
        Me.TablartBindingSource.DataSource = Me.DataSet_RT
        '
        'Forma_holtrop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 288)
        Me.Controls.Add(Me.datagrid_1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Forma_holtrop"
        Me.Text = "RESULTADOS MÉTODO DE HOLTROP"
        CType(Me.datagrid_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_RT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents datagrid_1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet_RT As Neptuno.DataSet_RT
    Friend WithEvents TablartBindingSource As System.Windows.Forms.BindingSource
End Class
