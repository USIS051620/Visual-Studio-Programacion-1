<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarClientes
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
        Me.txtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.lblBuscarCliente = New System.Windows.Forms.Label()
        Me.grdBuscarCliente = New System.Windows.Forms.DataGridView()
        Me.IdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSeleccionarCliente = New System.Windows.Forms.Button()
        Me.btnCancelarCliente = New System.Windows.Forms.Button()
        CType(Me.grdBuscarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.Location = New System.Drawing.Point(92, 32)
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(661, 20)
        Me.txtBuscarCliente.TabIndex = 0
        '
        'lblBuscarCliente
        '
        Me.lblBuscarCliente.AutoSize = True
        Me.lblBuscarCliente.Location = New System.Drawing.Point(35, 35)
        Me.lblBuscarCliente.Name = "lblBuscarCliente"
        Me.lblBuscarCliente.Size = New System.Drawing.Size(54, 13)
        Me.lblBuscarCliente.TabIndex = 1
        Me.lblBuscarCliente.Text = "BUSCAR:"
        '
        'grdBuscarCliente
        '
        Me.grdBuscarCliente.AllowUserToAddRows = False
        Me.grdBuscarCliente.AllowUserToDeleteRows = False
        Me.grdBuscarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCliente, Me.codigo, Me.nombre, Me.direccion, Me.telefono, Me.email})
        Me.grdBuscarCliente.Location = New System.Drawing.Point(38, 75)
        Me.grdBuscarCliente.Name = "grdBuscarCliente"
        Me.grdBuscarCliente.ReadOnly = True
        Me.grdBuscarCliente.Size = New System.Drawing.Size(715, 313)
        Me.grdBuscarCliente.TabIndex = 2
        '
        'IdCliente
        '
        Me.IdCliente.DataPropertyName = "IdCliente"
        Me.IdCliente.HeaderText = "ID"
        Me.IdCliente.Name = "IdCliente"
        Me.IdCliente.ReadOnly = True
        Me.IdCliente.Visible = False
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "Codigo"
        Me.codigo.HeaderText = "CODIGO"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "Nombre"
        Me.nombre.HeaderText = "NOMBRE"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 150
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "Direccion"
        Me.direccion.HeaderText = "DIRECCION"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Width = 150
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "Telefono"
        Me.telefono.HeaderText = "TELEFONO"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        '
        'email
        '
        Me.email.DataPropertyName = "Email"
        Me.email.HeaderText = "EMAIL"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 150
        '
        'btnSeleccionarCliente
        '
        Me.btnSeleccionarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarCliente.Location = New System.Drawing.Point(302, 394)
        Me.btnSeleccionarCliente.Name = "btnSeleccionarCliente"
        Me.btnSeleccionarCliente.Size = New System.Drawing.Size(214, 52)
        Me.btnSeleccionarCliente.TabIndex = 3
        Me.btnSeleccionarCliente.Text = "Seleccionar Cliente"
        Me.btnSeleccionarCliente.UseVisualStyleBackColor = True
        '
        'btnCancelarCliente
        '
        Me.btnCancelarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarCliente.Location = New System.Drawing.Point(539, 394)
        Me.btnCancelarCliente.Name = "btnCancelarCliente"
        Me.btnCancelarCliente.Size = New System.Drawing.Size(214, 52)
        Me.btnCancelarCliente.TabIndex = 4
        Me.btnCancelarCliente.Text = "Cancelar"
        Me.btnCancelarCliente.UseVisualStyleBackColor = True
        '
        'frmBuscarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 458)
        Me.Controls.Add(Me.btnCancelarCliente)
        Me.Controls.Add(Me.btnSeleccionarCliente)
        Me.Controls.Add(Me.grdBuscarCliente)
        Me.Controls.Add(Me.lblBuscarCliente)
        Me.Controls.Add(Me.txtBuscarCliente)
        Me.Name = "frmBuscarClientes"
        Me.Text = "Busqueda de registro de clientes "
        CType(Me.grdBuscarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscarCliente As TextBox
    Friend WithEvents lblBuscarCliente As Label
    Friend WithEvents grdBuscarCliente As DataGridView
    Friend WithEvents btnSeleccionarCliente As Button
    Friend WithEvents btnCancelarCliente As Button
    Friend WithEvents IdCliente As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
End Class
