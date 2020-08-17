<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.cbxEntrada = New System.Windows.Forms.ComboBox()
        Me.cbxSalida = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblm = New System.Windows.Forms.Label()
        Me.lblr = New System.Windows.Forms.Label()
        Me.lblvalor = New System.Windows.Forms.Label()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.lblDe = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConvertir
        '
        Me.btnConvertir.Location = New System.Drawing.Point(195, 130)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(75, 23)
        Me.btnConvertir.TabIndex = 0
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'cbxEntrada
        '
        Me.cbxEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEntrada.FormattingEnabled = True
        Me.cbxEntrada.Items.AddRange(New Object() {"Bits", "Bytes", "Gigabits", "Gigabytes", "Kilobits", "Kilobytes", "Megabits", "Megabytes", "Petabits", "Petabytes"})
        Me.cbxEntrada.Location = New System.Drawing.Point(393, 72)
        Me.cbxEntrada.Name = "cbxEntrada"
        Me.cbxEntrada.Size = New System.Drawing.Size(121, 21)
        Me.cbxEntrada.TabIndex = 1
        '
        'cbxSalida
        '
        Me.cbxSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSalida.FormattingEnabled = True
        Me.cbxSalida.Items.AddRange(New Object() {"Bits", "Bytes", "Gigabits", "Gigabytes", "Kilobits", "Kilobytes", "Megabits", "Megabytes", "Petabits", "Petabytes"})
        Me.cbxSalida.Location = New System.Drawing.Point(393, 132)
        Me.cbxSalida.Name = "cbxSalida"
        Me.cbxSalida.Size = New System.Drawing.Size(121, 21)
        Me.cbxSalida.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblm)
        Me.GroupBox1.Controls.Add(Me.lblr)
        Me.GroupBox1.Location = New System.Drawing.Point(322, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RESULTADO"
        '
        'lblm
        '
        Me.lblm.AutoSize = True
        Me.lblm.Location = New System.Drawing.Point(153, 43)
        Me.lblm.Name = "lblm"
        Me.lblm.Size = New System.Drawing.Size(0, 13)
        Me.lblm.TabIndex = 1
        '
        'lblr
        '
        Me.lblr.AutoSize = True
        Me.lblr.Location = New System.Drawing.Point(19, 43)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(0, 13)
        Me.lblr.TabIndex = 0
        '
        'lblvalor
        '
        Me.lblvalor.AutoSize = True
        Me.lblvalor.Location = New System.Drawing.Point(42, 80)
        Me.lblvalor.Name = "lblvalor"
        Me.lblvalor.Size = New System.Drawing.Size(147, 13)
        Me.lblvalor.TabIndex = 4
        Me.lblvalor.Text = "Ingrese el numero a convertir:"
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(195, 77)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor.TabIndex = 5
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Location = New System.Drawing.Point(364, 75)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(24, 13)
        Me.lblDe.TabIndex = 6
        Me.lblDe.Text = "De:"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(364, 135)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(17, 13)
        Me.lblA.TabIndex = 7
        Me.lblA.Text = "A:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 321)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lblDe)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.lblvalor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbxSalida)
        Me.Controls.Add(Me.cbxEntrada)
        Me.Controls.Add(Me.btnConvertir)
        Me.Name = "Form1"
        Me.Text = "Conversores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvertir As Button
    Friend WithEvents cbxEntrada As ComboBox
    Friend WithEvents cbxSalida As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblm As Label
    Friend WithEvents lblr As Label
    Friend WithEvents lblvalor As Label
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents lblDe As Label
    Friend WithEvents lblA As Label
End Class
