Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim num1, num2, respuesta As Double

        num1 = txtnum1.Text
        num2 = txtnum2.Text

        If optSuma.Checked Then
            lblrespuesta.Text = num1 + num2
        End If

        If optResta.Checked Then
            lblrespuesta.Text = num1 - num2
        End If

        If optMultiplicacion.Checked Then
            lblrespuesta.Text = num1 * num2
        End If

        If optDivision.Checked Then
            lblrespuesta.Text = num1 / num2
        End If

        If optPorcentaje.Checked Then
            lblrespuesta.Text = num1 * num2 / 100
        End If

        If optPotenciacion.Checked Then
            lblrespuesta.Text = num1 ^ num2
        End If

        If optMod.Checked Then
            lblrespuesta.Text = num1 Mod num2
        End If

        Select Case cboOperaciones.SelectedIndex
            Case 1 'Suma
                lblrespuesta.Text = num1 + num2

            Case 2 'Resta
                lblrespuesta.Text = num1 - num2

            Case 3 'Multiplicacion
                lblrespuesta.Text = num1 * num2

            Case 4 'Division
                lblrespuesta.Text = num1 / num2

            Case 5 'Porcentaje 
                lblrespuesta.Text = num1 * num2 / 100

            Case 6 'Potenciacion
                lblrespuesta.Text = num1 ^ num2

            Case 7 'MOD
                lblrespuesta.Text = num1 Mod num2
        End Select
    End Sub
End Class