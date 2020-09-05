Public Class Form1
    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim Cantidad = txtCantidad.Text
        Dim Unidades = txtUnidades.Text
        Dim Respuesta = txtRespuesta.Text
        Dim s, nr, sb, bc, pp, rp, nt, d, ro, z

        If txtRespuesta.Text = "" Then
            rp = (Cantidad / Unidades)
            nr = Int(rp)
            sb = Cantidad - (nr * Unidades)
            txtRespuesta.Text = nr.ToString() + "/" + sb.ToString()
        End If

        If txtCantidad.Text = "" Then
            bc = ""
            z = 0
            nt = txtRespuesta.Text.Length

            While z < nt
                bc = txtRespuesta.Text.Substring(z, 1)
                If bc = "/" Then
                    d = z
                End If
                z = z + 1
            End While

            s = txtRespuesta.Text.Substring(0, d)
            nt = (nt - d) - 1
            d = d + 1
            pp = txtRespuesta.Text.Substring(d, nt)
            ro = (s * Unidades) + pp
            txtCantidad.Text = ro
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtCantidad.Clear()
        txtUnidades.Clear()
        txtRespuesta.Clear()
    End Sub

    Private Sub btnConvetir1_Click(sender As Object, e As EventArgs) Handles btnConvetir1.Click
        Dim num1 As Double

        num1 = txtvalores.Text

        If cbxde.Text = "Tareas" And cbxa.Text = "Pie cuadrado" Then
            lblr.Text = num1 * 6768.34687
        ElseIf cbxde.Text = "Tareas" And cbxa.Text = "Vara cuadrada" Then
            lblr.Text = num1 * 877.17424789
        ElseIf cbxde.Text = "Tareas" And cbxa.Text = "Yarda cuadrada" Then
            lblr.Text = num1 * 752.0385411
        ElseIf cbxde.Text = "Tareas" And cbxa.Text = "Metro cuadrado" Then
            lblr.Text = num1 * 628.8
        ElseIf cbxde.Text = "Tareas" And cbxa.Text = "Tareas" Then
            lblr.Text = num1
        ElseIf cbxde.Text = "Tareas" And cbxa.Text = "Manzanas" Then
            lblr.Text = num1 * 0.08926746167
        ElseIf cbxde.Text = "Tareas" And cbxa.Text = "Hectarea" Then
            lblr.Text = num1 * 0.06288
        ElseIf cbxde.Text = "Manzanas" And cbxa.Text = "Pie cuadrado" Then
            lblr.Text = num1 * 151641.96995
        ElseIf cbxde.Text = "Manzanas" And cbxa.Text = "Vara cuadrada" Then
            lblr.Text = num1 * 9826.3603723
        ElseIf cbxde.Text = "Manzanas" And cbxa.Text = "Yarda cuadrada" Then
            lblr.Text = num1 * 824.5538861
        ElseIf cbxde.Text = "Manzanas" And cbxa.Text = "Metro cuadrado" Then
            lblr.Text = num1 * 7044
        ElseIf cbxde.Text = "Manzanas" And cbxa.Text = "Tareas" Then
            lblr.Text = num1 * 11.202290076
        ElseIf cbxde.Text = "Manzanas" And cbxa.Text = "Manzanas" Then
            lblr.Text = num1
        ElseIf cbxde.Text = "Manzanas" And cbxa.Text = "Hectarea" Then
            lblr.Text = num1 * 0.7044

        End If
    End Sub
End Class