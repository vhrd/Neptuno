<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_verificar_holtrop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_verificar_holtrop))
        Me.dg_savitsky = New System.Windows.Forms.DataGridView()
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requerido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dg_savitsky, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_savitsky
        '
        Me.dg_savitsky.BackgroundColor = System.Drawing.Color.White
        Me.dg_savitsky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_savitsky.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item, Me.requerido, Me.valor})
        Me.dg_savitsky.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_savitsky.Location = New System.Drawing.Point(0, 0)
        Me.dg_savitsky.Name = "dg_savitsky"
        Me.dg_savitsky.Size = New System.Drawing.Size(346, 131)
        Me.dg_savitsky.TabIndex = 1
        '
        'item
        '
        Me.item.Frozen = True
        Me.item.HeaderText = "Item "
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        '
        'requerido
        '
        Me.requerido.Frozen = True
        Me.requerido.HeaderText = "Requerido"
        Me.requerido.Name = "requerido"
        Me.requerido.ReadOnly = True
        '
        'valor
        '
        Me.valor.Frozen = True
        Me.valor.HeaderText = "Valor"
        Me.valor.Name = "valor"
        Me.valor.ReadOnly = True
        '
        'Form_verificar_holtrop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 131)
        Me.Controls.Add(Me.dg_savitsky)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_verificar_holtrop"
        Me.Text = "HOLTROP"
        CType(Me.dg_savitsky, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dg_savitsky As System.Windows.Forms.DataGridView
    Friend WithEvents item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents requerido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
