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
        Me.lblnum1 = New System.Windows.Forms.Label()
        Me.optSuma = New System.Windows.Forms.RadioButton()
        Me.optResta = New System.Windows.Forms.RadioButton()
        Me.optMultiplicacion = New System.Windows.Forms.RadioButton()
        Me.optDivision = New System.Windows.Forms.RadioButton()
        Me.optPotenciacion = New System.Windows.Forms.RadioButton()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.optPorcentaje = New System.Windows.Forms.RadioButton()
        Me.optMod = New System.Windows.Forms.RadioButton()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.lblnum2 = New System.Windows.Forms.Label()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.cboOperaciones = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblnum1
        '
        Me.lblnum1.AutoSize = True
        Me.lblnum1.Location = New System.Drawing.Point(32, 56)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(38, 13)
        Me.lblnum1.TabIndex = 0
        Me.lblnum1.Text = "Num1:"
        '
        'optSuma
        '
        Me.optSuma.AutoSize = True
        Me.optSuma.Location = New System.Drawing.Point(199, 56)
        Me.optSuma.Name = "optSuma"
        Me.optSuma.Size = New System.Drawing.Size(31, 17)
        Me.optSuma.TabIndex = 1
        Me.optSuma.TabStop = True
        Me.optSuma.Text = "+"
        Me.optSuma.UseVisualStyleBackColor = True
        '
        'optResta
        '
        Me.optResta.AutoSize = True
        Me.optResta.Location = New System.Drawing.Point(199, 79)
        Me.optResta.Name = "optResta"
        Me.optResta.Size = New System.Drawing.Size(28, 17)
        Me.optResta.TabIndex = 2
        Me.optResta.TabStop = True
        Me.optResta.Text = "-"
        Me.optResta.UseVisualStyleBackColor = True
        '
        'optMultiplicacion
        '
        Me.optMultiplicacion.AutoSize = True
        Me.optMultiplicacion.Location = New System.Drawing.Point(199, 102)
        Me.optMultiplicacion.Name = "optMultiplicacion"
        Me.optMultiplicacion.Size = New System.Drawing.Size(29, 17)
        Me.optMultiplicacion.TabIndex = 3
        Me.optMultiplicacion.TabStop = True
        Me.optMultiplicacion.Text = "*"
        Me.optMultiplicacion.UseVisualStyleBackColor = True
        '
        'optDivision
        '
        Me.optDivision.AutoSize = True
        Me.optDivision.Location = New System.Drawing.Point(198, 125)
        Me.optDivision.Name = "optDivision"
        Me.optDivision.Size = New System.Drawing.Size(30, 17)
        Me.optDivision.TabIndex = 4
        Me.optDivision.TabStop = True
        Me.optDivision.Text = "/"
        Me.optDivision.UseVisualStyleBackColor = True
        '
        'optPotenciacion
        '
        Me.optPotenciacion.AutoSize = True
        Me.optPotenciacion.Location = New System.Drawing.Point(199, 171)
        Me.optPotenciacion.Name = "optPotenciacion"
        Me.optPotenciacion.Size = New System.Drawing.Size(31, 17)
        Me.optPotenciacion.TabIndex = 5
        Me.optPotenciacion.TabStop = True
        Me.optPotenciacion.Text = "^"
        Me.optPotenciacion.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(174, 229)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(90, 39)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'optPorcentaje
        '
        Me.optPorcentaje.AutoSize = True
        Me.optPorcentaje.Location = New System.Drawing.Point(199, 148)
        Me.optPorcentaje.Name = "optPorcentaje"
        Me.optPorcentaje.Size = New System.Drawing.Size(33, 17)
        Me.optPorcentaje.TabIndex = 7
        Me.optPorcentaje.TabStop = True
        Me.optPorcentaje.Text = "%"
        Me.optPorcentaje.UseVisualStyleBackColor = True
        '
        'optMod
        '
        Me.optMod.AutoSize = True
        Me.optMod.Location = New System.Drawing.Point(199, 194)
        Me.optMod.Name = "optMod"
        Me.optMod.Size = New System.Drawing.Size(50, 17)
        Me.optMod.TabIndex = 8
        Me.optMod.TabStop = True
        Me.optMod.Text = "MOD"
        Me.optMod.UseVisualStyleBackColor = True
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(74, 53)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 20)
        Me.txtnum1.TabIndex = 9
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(294, 53)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(100, 20)
        Me.txtnum2.TabIndex = 11
        '
        'lblnum2
        '
        Me.lblnum2.AutoSize = True
        Me.lblnum2.Location = New System.Drawing.Point(252, 56)
        Me.lblnum2.Name = "lblnum2"
        Me.lblnum2.Size = New System.Drawing.Size(38, 13)
        Me.lblnum2.TabIndex = 10
        Me.lblnum2.Text = "Num2:"
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Location = New System.Drawing.Point(416, 56)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(70, 13)
        Me.lblrespuesta.TabIndex = 12
        Me.lblrespuesta.Text = "Respuesta: ?"
        '
        'cboOperaciones
        '
        Me.cboOperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperaciones.FormattingEnabled = True
        Me.cboOperaciones.Items.AddRange(New Object() {"Seleccione una opción:", "Suma", "Resta", "Multiplicacion", "Division", "Porcentaje", "Potenciacion ", "MOD"})
        Me.cboOperaciones.Location = New System.Drawing.Point(365, 121)
        Me.cboOperaciones.Name = "cboOperaciones"
        Me.cboOperaciones.Size = New System.Drawing.Size(121, 21)
        Me.cboOperaciones.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 300)
        Me.Controls.Add(Me.cboOperaciones)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.lblnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.optMod)
        Me.Controls.Add(Me.optPorcentaje)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.optPotenciacion)
        Me.Controls.Add(Me.optDivision)
        Me.Controls.Add(Me.optMultiplicacion)
        Me.Controls.Add(Me.optResta)
        Me.Controls.Add(Me.optSuma)
        Me.Controls.Add(Me.lblnum1)
        Me.Name = "Form1"
        Me.Text = "Calculadora Basica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnum1 As Label
    Friend WithEvents optSuma As RadioButton
    Friend WithEvents optResta As RadioButton
    Friend WithEvents optMultiplicacion As RadioButton
    Friend WithEvents optDivision As RadioButton
    Friend WithEvents optPotenciacion As RadioButton
    Friend WithEvents btnCalcular As Button
    Friend WithEvents optPorcentaje As RadioButton
    Friend WithEvents optMod As RadioButton
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents lblnum2 As Label
    Friend WithEvents lblrespuesta As Label
    Friend WithEvents cboOperaciones As ComboBox
End Class
