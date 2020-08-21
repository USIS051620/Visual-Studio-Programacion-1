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
        Me.bntmMediaAritmetica = New System.Windows.Forms.Button()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.lblserie = New System.Windows.Forms.Label()
        Me.lblrespuestaMedia = New System.Windows.Forms.Label()
        Me.lblrespuestaVarianza = New System.Windows.Forms.Label()
        Me.lblmedia = New System.Windows.Forms.Label()
        Me.lblvarianza = New System.Windows.Forms.Label()
        Me.lblDesvTipica = New System.Windows.Forms.Label()
        Me.lblrespuestaDesvTipica = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bntmMediaAritmetica
        '
        Me.bntmMediaAritmetica.Location = New System.Drawing.Point(55, 214)
        Me.bntmMediaAritmetica.Name = "bntmMediaAritmetica"
        Me.bntmMediaAritmetica.Size = New System.Drawing.Size(224, 45)
        Me.bntmMediaAritmetica.TabIndex = 0
        Me.bntmMediaAritmetica.Text = "Calculos estadisticos"
        Me.bntmMediaAritmetica.UseVisualStyleBackColor = True
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(103, 55)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(187, 20)
        Me.txtserie.TabIndex = 1
        '
        'lblserie
        '
        Me.lblserie.AutoSize = True
        Me.lblserie.Location = New System.Drawing.Point(52, 58)
        Me.lblserie.Name = "lblserie"
        Me.lblserie.Size = New System.Drawing.Size(34, 13)
        Me.lblserie.TabIndex = 2
        Me.lblserie.Text = "Serie:"
        '
        'lblrespuestaMedia
        '
        Me.lblrespuestaMedia.AutoSize = True
        Me.lblrespuestaMedia.Location = New System.Drawing.Point(136, 98)
        Me.lblrespuestaMedia.Name = "lblrespuestaMedia"
        Me.lblrespuestaMedia.Size = New System.Drawing.Size(13, 13)
        Me.lblrespuestaMedia.TabIndex = 3
        Me.lblrespuestaMedia.Text = "?"
        '
        'lblrespuestaVarianza
        '
        Me.lblrespuestaVarianza.AutoSize = True
        Me.lblrespuestaVarianza.Location = New System.Drawing.Point(136, 138)
        Me.lblrespuestaVarianza.Name = "lblrespuestaVarianza"
        Me.lblrespuestaVarianza.Size = New System.Drawing.Size(13, 13)
        Me.lblrespuestaVarianza.TabIndex = 4
        Me.lblrespuestaVarianza.Text = "?"
        '
        'lblmedia
        '
        Me.lblmedia.AutoSize = True
        Me.lblmedia.Location = New System.Drawing.Point(52, 98)
        Me.lblmedia.Name = "lblmedia"
        Me.lblmedia.Size = New System.Drawing.Size(39, 13)
        Me.lblmedia.TabIndex = 5
        Me.lblmedia.Text = "Media:"
        '
        'lblvarianza
        '
        Me.lblvarianza.AutoSize = True
        Me.lblvarianza.Location = New System.Drawing.Point(52, 138)
        Me.lblvarianza.Name = "lblvarianza"
        Me.lblvarianza.Size = New System.Drawing.Size(51, 13)
        Me.lblvarianza.TabIndex = 6
        Me.lblvarianza.Text = "Varianza:"
        '
        'lblDesvTipica
        '
        Me.lblDesvTipica.AutoSize = True
        Me.lblDesvTipica.Location = New System.Drawing.Point(52, 178)
        Me.lblDesvTipica.Name = "lblDesvTipica"
        Me.lblDesvTipica.Size = New System.Drawing.Size(67, 13)
        Me.lblDesvTipica.TabIndex = 7
        Me.lblDesvTipica.Text = "Desv Tipica:"
        '
        'lblrespuestaDesvTipica
        '
        Me.lblrespuestaDesvTipica.AutoSize = True
        Me.lblrespuestaDesvTipica.Location = New System.Drawing.Point(136, 178)
        Me.lblrespuestaDesvTipica.Name = "lblrespuestaDesvTipica"
        Me.lblrespuestaDesvTipica.Size = New System.Drawing.Size(13, 13)
        Me.lblrespuestaDesvTipica.TabIndex = 8
        Me.lblrespuestaDesvTipica.Text = "?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 321)
        Me.Controls.Add(Me.lblrespuestaDesvTipica)
        Me.Controls.Add(Me.lblDesvTipica)
        Me.Controls.Add(Me.lblvarianza)
        Me.Controls.Add(Me.lblmedia)
        Me.Controls.Add(Me.lblrespuestaVarianza)
        Me.Controls.Add(Me.lblrespuestaMedia)
        Me.Controls.Add(Me.lblserie)
        Me.Controls.Add(Me.txtserie)
        Me.Controls.Add(Me.bntmMediaAritmetica)
        Me.Name = "Form1"
        Me.Text = "Matrices y POO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bntmMediaAritmetica As Button
    Friend WithEvents txtserie As TextBox
    Friend WithEvents lblserie As Label
    Friend WithEvents lblrespuestaMedia As Label
    Friend WithEvents lblrespuestaVarianza As Label
    Friend WithEvents lblmedia As Label
    Friend WithEvents lblvarianza As Label
    Friend WithEvents lblDesvTipica As Label
    Friend WithEvents lblrespuestaDesvTipica As Label
End Class
