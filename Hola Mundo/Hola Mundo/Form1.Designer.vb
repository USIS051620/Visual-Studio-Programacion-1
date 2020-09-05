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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.txtUnidades = New System.Windows.Forms.TextBox()
        Me.lblUnidades = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblr = New System.Windows.Forms.Label()
        Me.cbxa = New System.Windows.Forms.ComboBox()
        Me.cbxde = New System.Windows.Forms.ComboBox()
        Me.lblA = New System.Windows.Forms.Label()
        Me.btnConvetir1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDe = New System.Windows.Forms.Label()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.txtvalores = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(46, 31)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(575, 335)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gray
        Me.TabPage1.Controls.Add(Me.btnBorrar)
        Me.TabPage1.Controls.Add(Me.btnConvertir)
        Me.TabPage1.Controls.Add(Me.txtRespuesta)
        Me.TabPage1.Controls.Add(Me.lblRespuesta)
        Me.TabPage1.Controls.Add(Me.txtUnidades)
        Me.TabPage1.Controls.Add(Me.lblUnidades)
        Me.TabPage1.Controls.Add(Me.txtCantidad)
        Me.TabPage1.Controls.Add(Me.lblCantidad)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(567, 309)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Universal"
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBorrar.Location = New System.Drawing.Point(255, 187)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(142, 65)
        Me.btnBorrar.TabIndex = 7
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnConvertir
        '
        Me.btnConvertir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnConvertir.Location = New System.Drawing.Point(40, 187)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(142, 65)
        Me.btnConvertir.TabIndex = 6
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = False
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Location = New System.Drawing.Point(104, 107)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(100, 20)
        Me.txtRespuesta.TabIndex = 5
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRespuesta.Location = New System.Drawing.Point(37, 110)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(61, 13)
        Me.lblRespuesta.TabIndex = 4
        Me.lblRespuesta.Text = "Respuesta:"
        '
        'txtUnidades
        '
        Me.txtUnidades.Location = New System.Drawing.Point(313, 44)
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.Size = New System.Drawing.Size(100, 20)
        Me.txtUnidades.TabIndex = 3
        '
        'lblUnidades
        '
        Me.lblUnidades.AutoSize = True
        Me.lblUnidades.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUnidades.Location = New System.Drawing.Point(252, 47)
        Me.lblUnidades.Name = "lblUnidades"
        Me.lblUnidades.Size = New System.Drawing.Size(55, 13)
        Me.lblUnidades.TabIndex = 2
        Me.lblUnidades.Text = "Unidades:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(104, 44)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 1
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCantidad.Location = New System.Drawing.Point(37, 47)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(52, 13)
        Me.lblCantidad.TabIndex = 0
        Me.lblCantidad.Text = "Cantidad:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gray
        Me.TabPage2.Controls.Add(Me.lblr)
        Me.TabPage2.Controls.Add(Me.cbxa)
        Me.TabPage2.Controls.Add(Me.cbxde)
        Me.TabPage2.Controls.Add(Me.lblA)
        Me.TabPage2.Controls.Add(Me.btnConvetir1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.lblDe)
        Me.TabPage2.Controls.Add(Me.lblNum1)
        Me.TabPage2.Controls.Add(Me.txtvalores)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(567, 309)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Area (Superficie)"
        '
        'lblr
        '
        Me.lblr.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblr.Location = New System.Drawing.Point(408, 206)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(100, 23)
        Me.lblr.TabIndex = 19
        '
        'cbxa
        '
        Me.cbxa.BackColor = System.Drawing.Color.White
        Me.cbxa.FormattingEnabled = True
        Me.cbxa.Items.AddRange(New Object() {"Pie cuadrado", "Vara cuadrada", "Yarda cuadrada", "Metro cuadrado", "Tareas", "Manzanas", "Hectarea"})
        Me.cbxa.Location = New System.Drawing.Point(387, 118)
        Me.cbxa.Name = "cbxa"
        Me.cbxa.Size = New System.Drawing.Size(121, 21)
        Me.cbxa.TabIndex = 18
        '
        'cbxde
        '
        Me.cbxde.BackColor = System.Drawing.Color.White
        Me.cbxde.FormattingEnabled = True
        Me.cbxde.Items.AddRange(New Object() {"Pie cuadrado", "Vara cuadrada", "Yarda cuadrada", "Metro cuadrado", "Tareas", "Manzanas", "Hectarea"})
        Me.cbxde.Location = New System.Drawing.Point(387, 63)
        Me.cbxde.Name = "cbxde"
        Me.cbxde.Size = New System.Drawing.Size(121, 21)
        Me.cbxde.TabIndex = 17
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblA.Location = New System.Drawing.Point(318, 127)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(19, 15)
        Me.lblA.TabIndex = 16
        Me.lblA.Text = "A:"
        '
        'btnConvetir1
        '
        Me.btnConvetir1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnConvetir1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnConvetir1.Location = New System.Drawing.Point(107, 164)
        Me.btnConvetir1.Name = "btnConvetir1"
        Me.btnConvetir1.Size = New System.Drawing.Size(128, 81)
        Me.btnConvetir1.TabIndex = 15
        Me.btnConvetir1.Text = "Convertir"
        Me.btnConvetir1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(315, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Respuesta?"
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDe.Location = New System.Drawing.Point(315, 72)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(26, 15)
        Me.lblDe.TabIndex = 13
        Me.lblDe.Text = "De:"
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNum1.ForeColor = System.Drawing.Color.Black
        Me.lblNum1.Location = New System.Drawing.Point(59, 68)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(46, 15)
        Me.lblNum1.TabIndex = 12
        Me.lblNum1.Text = "Numero"
        '
        'txtvalores
        '
        Me.txtvalores.Location = New System.Drawing.Point(126, 65)
        Me.txtvalores.Name = "txtvalores"
        Me.txtvalores.Size = New System.Drawing.Size(100, 20)
        Me.txtvalores.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 413)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Parcial_1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnConvertir As Button
    Friend WithEvents txtRespuesta As TextBox
    Friend WithEvents lblRespuesta As Label
    Friend WithEvents txtUnidades As TextBox
    Friend WithEvents lblUnidades As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnBorrar As Button
    Friend WithEvents lblr As Label
    Friend WithEvents cbxa As ComboBox
    Friend WithEvents cbxde As ComboBox
    Friend WithEvents lblA As Label
    Friend WithEvents btnConvetir1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDe As Label
    Friend WithEvents lblNum1 As Label
    Friend WithEvents txtvalores As TextBox
End Class
