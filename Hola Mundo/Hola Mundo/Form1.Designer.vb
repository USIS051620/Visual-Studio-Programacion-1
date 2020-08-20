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
        Me.lblvalor = New System.Windows.Forms.Label()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.lblDe = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.cbxvol1 = New System.Windows.Forms.ComboBox()
        Me.cbxVol2 = New System.Windows.Forms.ComboBox()
        Me.lblr = New System.Windows.Forms.Label()
        Me.lblu = New System.Windows.Forms.Label()
        Me.cbxtiem1 = New System.Windows.Forms.ComboBox()
        Me.cbxtiem2 = New System.Windows.Forms.ComboBox()
        Me.cbxuni1 = New System.Windows.Forms.ComboBox()
        Me.cbxuni2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnConvertir
        '
        Me.btnConvertir.Location = New System.Drawing.Point(224, 348)
        Me.btnConvertir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(100, 28)
        Me.btnConvertir.TabIndex = 0
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'cbxEntrada
        '
        Me.cbxEntrada.Items.AddRange(New Object() {"Bits", "Bytes", "Gigabits", "Gigabytes", "Kilobits", "Kilobytes", "Megabits", "Megabytes", "Petabits", "Petabytes"})
        Me.cbxEntrada.Location = New System.Drawing.Point(793, 47)
        Me.cbxEntrada.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxEntrada.Name = "cbxEntrada"
        Me.cbxEntrada.Size = New System.Drawing.Size(175, 24)
        Me.cbxEntrada.TabIndex = 1
        Me.cbxEntrada.Text = "Almacenamiento"
        '
        'cbxSalida
        '
        Me.cbxSalida.FormattingEnabled = True
        Me.cbxSalida.Items.AddRange(New Object() {"Bits", "Bytes", "Gigabits", "Gigabytes", "Kilobits", "Kilobytes", "Megabits", "Megabytes", "Petabits", "Petabytes"})
        Me.cbxSalida.Location = New System.Drawing.Point(793, 116)
        Me.cbxSalida.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxSalida.Name = "cbxSalida"
        Me.cbxSalida.Size = New System.Drawing.Size(175, 24)
        Me.cbxSalida.TabIndex = 2
        '
        'lblvalor
        '
        Me.lblvalor.AutoSize = True
        Me.lblvalor.Location = New System.Drawing.Point(39, 47)
        Me.lblvalor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblvalor.Name = "lblvalor"
        Me.lblvalor.Size = New System.Drawing.Size(197, 17)
        Me.lblvalor.TabIndex = 4
        Me.lblvalor.Text = "Ingrese el numero a convertir:"
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(43, 92)
        Me.txtvalor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(132, 22)
        Me.txtvalor.TabIndex = 5
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Location = New System.Drawing.Point(292, 47)
        Me.lblDe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(30, 17)
        Me.lblDe.TabIndex = 6
        Me.lblDe.Text = "De:"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(301, 133)
        Me.lblA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(21, 17)
        Me.lblA.TabIndex = 7
        Me.lblA.Text = "A:"
        '
        'cbxvol1
        '
        Me.cbxvol1.FormattingEnabled = True
        Me.cbxvol1.Items.AddRange(New Object() {"Litro", "Mililitro", "Pie cubico", "Pulgada Cubica", "Onza liquida imperial", "Metro cubico", "Galon imperial", "Cuarto estadounidense", "Taza imperial", "Cucharada estadounidense"})
        Me.cbxvol1.Location = New System.Drawing.Point(609, 43)
        Me.cbxvol1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxvol1.Name = "cbxvol1"
        Me.cbxvol1.Size = New System.Drawing.Size(160, 24)
        Me.cbxvol1.TabIndex = 8
        Me.cbxvol1.Text = "Volumen"
        '
        'cbxVol2
        '
        Me.cbxVol2.FormattingEnabled = True
        Me.cbxVol2.Items.AddRange(New Object() {"Litro", "Mililitro", "Pie cubico", "Pulgada Cubica", "Onza liquida imperial", "Metro cubico", "Galon imperial", "Cuarto estadounidense", "Taza imperial", "Cucharada estadounidense"})
        Me.cbxVol2.Location = New System.Drawing.Point(609, 116)
        Me.cbxVol2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxVol2.Name = "cbxVol2"
        Me.cbxVol2.Size = New System.Drawing.Size(160, 24)
        Me.cbxVol2.TabIndex = 9
        '
        'lblr
        '
        Me.lblr.AutoSize = True
        Me.lblr.Location = New System.Drawing.Point(409, 361)
        Me.lblr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(72, 17)
        Me.lblr.TabIndex = 10
        Me.lblr.Text = "Resultado"
        '
        'lblu
        '
        Me.lblu.Location = New System.Drawing.Point(663, 361)
        Me.lblu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblu.Name = "lblu"
        Me.lblu.Size = New System.Drawing.Size(133, 28)
        Me.lblu.TabIndex = 11
        '
        'cbxtiem1
        '
        Me.cbxtiem1.FormattingEnabled = True
        Me.cbxtiem1.Items.AddRange(New Object() {"Nanosegundo", "Microsegundo", "Milisegundo", "Segundo", "Minuto", "Hora", "Dia", "Semana", "Decada", "Año natural"})
        Me.cbxtiem1.Location = New System.Drawing.Point(413, 43)
        Me.cbxtiem1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxtiem1.Name = "cbxtiem1"
        Me.cbxtiem1.Size = New System.Drawing.Size(160, 24)
        Me.cbxtiem1.TabIndex = 12
        Me.cbxtiem1.Text = "Tiempo"
        '
        'cbxtiem2
        '
        Me.cbxtiem2.FormattingEnabled = True
        Me.cbxtiem2.Items.AddRange(New Object() {"Nanosegundo", "Microsegundo", "Milisegundo", "Segundo", "Minuto", "Hora", "Dia", "Semana", "Decada", "Año natural"})
        Me.cbxtiem2.Location = New System.Drawing.Point(413, 116)
        Me.cbxtiem2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxtiem2.Name = "cbxtiem2"
        Me.cbxtiem2.Size = New System.Drawing.Size(160, 24)
        Me.cbxtiem2.TabIndex = 13
        '
        'cbxuni1
        '
        Me.cbxuni1.FormattingEnabled = True
        Me.cbxuni1.Items.AddRange(New Object() {"Metro", "Centimetro", "Milimetro", "Milla", "Yarda", "Pie", "Pulgada", "Kilometro", "Nanometro", "Micrometro"})
        Me.cbxuni1.Location = New System.Drawing.Point(1046, 47)
        Me.cbxuni1.Name = "cbxuni1"
        Me.cbxuni1.Size = New System.Drawing.Size(151, 24)
        Me.cbxuni1.TabIndex = 14
        Me.cbxuni1.Text = "Longitud"
        '
        'cbxuni2
        '
        Me.cbxuni2.FormattingEnabled = True
        Me.cbxuni2.Items.AddRange(New Object() {"Metro", "Centimetro", "Milimetro", "Milla", "Yarda", "Pie", "Pulgada", "Kilometro", "Nanometro", "Micrometro"})
        Me.cbxuni2.Location = New System.Drawing.Point(1046, 114)
        Me.cbxuni2.Name = "cbxuni2"
        Me.cbxuni2.Size = New System.Drawing.Size(151, 24)
        Me.cbxuni2.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1322, 612)
        Me.Controls.Add(Me.cbxuni2)
        Me.Controls.Add(Me.cbxuni1)
        Me.Controls.Add(Me.cbxtiem2)
        Me.Controls.Add(Me.cbxtiem1)
        Me.Controls.Add(Me.lblu)
        Me.Controls.Add(Me.lblr)
        Me.Controls.Add(Me.cbxVol2)
        Me.Controls.Add(Me.cbxvol1)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lblDe)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.lblvalor)
        Me.Controls.Add(Me.cbxSalida)
        Me.Controls.Add(Me.cbxEntrada)
        Me.Controls.Add(Me.btnConvertir)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Conversores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvertir As Button
    Friend WithEvents cbxEntrada As ComboBox
    Friend WithEvents cbxSalida As ComboBox
    Friend WithEvents lblvalor As Label
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents lblDe As Label
    Friend WithEvents lblA As Label
    Friend WithEvents cbxvol1 As ComboBox
    Friend WithEvents cbxVol2 As ComboBox
    Friend WithEvents lblr As Label
    Friend WithEvents lblu As Label
    Friend WithEvents cbxtiem1 As ComboBox
    Friend WithEvents cbxtiem2 As ComboBox
    Friend WithEvents cbxuni1 As ComboBox
    Friend WithEvents cbxuni2 As ComboBox
End Class
