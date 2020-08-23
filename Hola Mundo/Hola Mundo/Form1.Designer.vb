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
        Me.cbxmonedas = New System.Windows.Forms.ComboBox()
        Me.cbxmonedas1 = New System.Windows.Forms.ComboBox()
        Me.cbxmasa = New System.Windows.Forms.ComboBox()
        Me.cbxmasa1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnConvertir
        '
        Me.btnConvertir.Location = New System.Drawing.Point(437, 135)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(75, 23)
        Me.btnConvertir.TabIndex = 0
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'cbxEntrada
        '
        Me.cbxEntrada.Items.AddRange(New Object() {"Bits", "Bytes", "Gigabits", "Gigabytes", "Kilobits", "Kilobytes", "Megabits", "Megabytes", "Petabits", "Petabytes"})
        Me.cbxEntrada.Location = New System.Drawing.Point(483, 35)
        Me.cbxEntrada.Name = "cbxEntrada"
        Me.cbxEntrada.Size = New System.Drawing.Size(132, 21)
        Me.cbxEntrada.TabIndex = 1
        Me.cbxEntrada.Text = "Almacenamiento"
        '
        'cbxSalida
        '
        Me.cbxSalida.FormattingEnabled = True
        Me.cbxSalida.Items.AddRange(New Object() {"Bits", "Bytes", "Gigabits", "Gigabytes", "Kilobits", "Kilobytes", "Megabits", "Megabytes", "Petabits", "Petabytes"})
        Me.cbxSalida.Location = New System.Drawing.Point(481, 74)
        Me.cbxSalida.Name = "cbxSalida"
        Me.cbxSalida.Size = New System.Drawing.Size(132, 21)
        Me.cbxSalida.TabIndex = 2
        '
        'lblvalor
        '
        Me.lblvalor.AutoSize = True
        Me.lblvalor.Location = New System.Drawing.Point(29, 38)
        Me.lblvalor.Name = "lblvalor"
        Me.lblvalor.Size = New System.Drawing.Size(147, 13)
        Me.lblvalor.TabIndex = 4
        Me.lblvalor.Text = "Ingrese el numero a convertir:"
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(32, 75)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor.TabIndex = 5
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Location = New System.Drawing.Point(204, 38)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(24, 13)
        Me.lblDe.TabIndex = 6
        Me.lblDe.Text = "De:"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(204, 78)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(17, 13)
        Me.lblA.TabIndex = 7
        Me.lblA.Text = "A:"
        '
        'cbxvol1
        '
        Me.cbxvol1.FormattingEnabled = True
        Me.cbxvol1.Items.AddRange(New Object() {"Litro", "Mililitro", "Pie cubico", "Pulgada Cubica", "Onza liquida imperial", "Metro cubico", "Galon imperial", "Cuarto estadounidense", "Taza imperial", "Cucharada estadounidense"})
        Me.cbxvol1.Location = New System.Drawing.Point(356, 35)
        Me.cbxvol1.Name = "cbxvol1"
        Me.cbxvol1.Size = New System.Drawing.Size(121, 21)
        Me.cbxvol1.TabIndex = 8
        Me.cbxvol1.Text = "Volumen"
        '
        'cbxVol2
        '
        Me.cbxVol2.FormattingEnabled = True
        Me.cbxVol2.Items.AddRange(New Object() {"Litro", "Mililitro", "Pie cubico", "Pulgada Cubica", "Onza liquida imperial", "Metro cubico", "Galon imperial", "Cuarto estadounidense", "Taza imperial", "Cucharada estadounidense"})
        Me.cbxVol2.Location = New System.Drawing.Point(354, 74)
        Me.cbxVol2.Name = "cbxVol2"
        Me.cbxVol2.Size = New System.Drawing.Size(121, 21)
        Me.cbxVol2.TabIndex = 9
        '
        'lblr
        '
        Me.lblr.AutoSize = True
        Me.lblr.Location = New System.Drawing.Point(542, 140)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(55, 13)
        Me.lblr.TabIndex = 10
        Me.lblr.Text = "Resultado"
        '
        'lblu
        '
        Me.lblu.Location = New System.Drawing.Point(497, 293)
        Me.lblu.Name = "lblu"
        Me.lblu.Size = New System.Drawing.Size(100, 23)
        Me.lblu.TabIndex = 11
        '
        'cbxtiem1
        '
        Me.cbxtiem1.FormattingEnabled = True
        Me.cbxtiem1.Items.AddRange(New Object() {"Nanosegundo", "Microsegundo", "Milisegundo", "Segundo", "Minuto", "Hora", "Dia", "Semana", "Decada", "Año natural"})
        Me.cbxtiem1.Location = New System.Drawing.Point(229, 35)
        Me.cbxtiem1.Name = "cbxtiem1"
        Me.cbxtiem1.Size = New System.Drawing.Size(121, 21)
        Me.cbxtiem1.TabIndex = 12
        Me.cbxtiem1.Text = "Tiempo"
        '
        'cbxtiem2
        '
        Me.cbxtiem2.FormattingEnabled = True
        Me.cbxtiem2.Items.AddRange(New Object() {"Nanosegundo", "Microsegundo", "Milisegundo", "Segundo", "Minuto", "Hora", "Dia", "Semana", "Decada", "Año natural"})
        Me.cbxtiem2.Location = New System.Drawing.Point(227, 74)
        Me.cbxtiem2.Name = "cbxtiem2"
        Me.cbxtiem2.Size = New System.Drawing.Size(121, 21)
        Me.cbxtiem2.TabIndex = 13
        '
        'cbxmonedas
        '
        Me.cbxmonedas.FormattingEnabled = True
        Me.cbxmonedas.Items.AddRange(New Object() {"Dolar estadounidense", "Euro", "Yen", "Lempira", "Cordoba nicaraguense", "Quetzal", "Balboa", "Peso mexicano", "Libra esterlina", "Bolivar venezolano"})
        Me.cbxmonedas.Location = New System.Drawing.Point(621, 35)
        Me.cbxmonedas.Name = "cbxmonedas"
        Me.cbxmonedas.Size = New System.Drawing.Size(121, 21)
        Me.cbxmonedas.TabIndex = 14
        Me.cbxmonedas.Text = "Monedas"
        '
        'cbxmonedas1
        '
        Me.cbxmonedas1.FormattingEnabled = True
        Me.cbxmonedas1.Items.AddRange(New Object() {"Dolar estadounidense", "Euro", "Yen", "Lempira", "Cordoba nicaraguense", "Quetzal", "Balboa", "Peso mexicano", "Libra esterlina", "Bolivar venezolano"})
        Me.cbxmonedas1.Location = New System.Drawing.Point(621, 73)
        Me.cbxmonedas1.Name = "cbxmonedas1"
        Me.cbxmonedas1.Size = New System.Drawing.Size(121, 21)
        Me.cbxmonedas1.TabIndex = 15
        '
        'cbxmasa
        '
        Me.cbxmasa.FormattingEnabled = True
        Me.cbxmasa.Items.AddRange(New Object() {"Kilogramos", "Hectogramos", "Decagramos", "Gramos", "Decigramos", "Centigramos", "Miligramos", "Libras", "Onzas", "Quilates"})
        Me.cbxmasa.Location = New System.Drawing.Point(748, 35)
        Me.cbxmasa.Name = "cbxmasa"
        Me.cbxmasa.Size = New System.Drawing.Size(121, 21)
        Me.cbxmasa.TabIndex = 16
        Me.cbxmasa.Text = "Masa"
        '
        'cbxmasa1
        '
        Me.cbxmasa1.FormattingEnabled = True
        Me.cbxmasa1.Items.AddRange(New Object() {"Kilogramos", "Hectogramos", "Decagramos", "Gramos", "Decigramos", "Centigramos", "Miligramos", "Libras", "Onzas", "Quilates"})
        Me.cbxmasa1.Location = New System.Drawing.Point(749, 73)
        Me.cbxmasa1.Name = "cbxmasa1"
        Me.cbxmasa1.Size = New System.Drawing.Size(121, 21)
        Me.cbxmasa1.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 547)
        Me.Controls.Add(Me.cbxmasa1)
        Me.Controls.Add(Me.cbxmasa)
        Me.Controls.Add(Me.cbxmonedas1)
        Me.Controls.Add(Me.cbxmonedas)
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
    Friend WithEvents cbxmonedas As ComboBox
    Friend WithEvents cbxmonedas1 As ComboBox
    Friend WithEvents cbxmasa As ComboBox
    Friend WithEvents cbxmasa1 As ComboBox
End Class
