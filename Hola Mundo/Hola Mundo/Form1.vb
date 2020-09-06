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
        ElseIf cbxde.Text = "Pie cuadrado" And cbxa.Text = "Vara cuadrada" Then
            lblr.Text = num1 / 0.09290304
        ElseIf cbxde.Text = "Pie cuadrado" And cbxa.Text = "Yarda cuadrada" Then
            lblr.Text = num1 / 9
        ElseIf cbxde.Text = "Pie cuadrado" And cbxa.Text = "Metro cuadrado" Then
            lblr.Text = num1 / 10.764
        ElseIf cbxde.Text = "Pie cuadrado" And cbxa.Text = "Tareas" Then
            lblr.Text = num1 / 628.8
        ElseIf cbxde.Text = "Pie cuadrado" And cbxa.Text = "Manzanas" Then
            lblr.Text = num1 * 100
        ElseIf cbxde.Text = "Pie cuadrado" And cbxa.Text = "Hectarea" Then
            lblr.Text = num1 / 107639
        ElseIf cbxde.Text = "Vara cuadrada" And cbxa.Text = "Pie cuadrado" Then
            lblr.Text = num1 * 7.52
        ElseIf cbxde.Text = "Vara cuadrada" And cbxa.Text = "Yarda cuadrada" Then
            lblr.Text = num1 / 0.09290304
        ElseIf cbxde.Text = "Vara cuadrada" And cbxa.Text = "Metro cuadrado" Then
            lblr.Text = num1 / 1
        ElseIf cbxde.Text = "Vara cuadrada" And cbxa.Text = "Tareas" Then
            lblr.Text = num1 * 7.52
        ElseIf cbxde.Text = "Vara cuadrada" And cbxa.Text = "Manzanas" Then
            lblr.Text = num1 * 0.698896
        ElseIf cbxde.Text = "Vara cuadrada" And cbxa.Text = "Hectarea" Then
            lblr.Text = num1 * 14285.71
        ElseIf cbxde.Text = "Yarda cuadrada" And cbxa.Text = "Pie cuadrado" Then
            lblr.Text = num1 * 9
        ElseIf cbxde.Text = "Yarda cuadrada" And cbxa.Text = "Vara cuadrada" Then
            lblr.Text = num1 / 0.09290304
        ElseIf cbxde.Text = "Yarda cuadrada" And cbxa.Text = "Metro cuadrado" Then
            lblr.Text = num1 / 1.196
        ElseIf cbxde.Text = "Yarda cuadrada" And cbxa.Text = "Tareas" Then
            lblr.Text = num1 / 628.8
        ElseIf cbxde.Text = "Yarda cuadrada" And cbxa.Text = "Manzanas" Then
            lblr.Text = num1 / 0.09290304
        ElseIf cbxde.Text = "Yarda cuadrada" And cbxa.Text = "Hectarea" Then
            lblr.Text = num1 / 11960
        ElseIf cbxde.Text = "Hectarea" And cbxa.Text = "Pie cuadrado" Then
            lblr.Text = num1 * 107639.1
        ElseIf cbxde.Text = "Hectarea" And cbxa.Text = "Vara cuadrada" Then
            lblr.Text = num1 * 13999.972136
        ElseIf cbxde.Text = "Hectarea" And cbxa.Text = "Yarda cuadrada" Then
            lblr.Text = num1 * 11959.9
        ElseIf cbxde.Text = "Hectarea" And cbxa.Text = "Metro cuadrado" Then
            lblr.Text = num1 * 10000
        ElseIf cbxde.Text = "Hectarea" And cbxa.Text = "Tareas" Then
            lblr.Text = num1 * 15.903307888
        ElseIf cbxde.Text = "Hectarea" And cbxa.Text = "Manzanas" Then
            lblr.Text = num1 * 1.4196479273
        ElseIf cbxde.Text = "Hectarea" And cbxa.Text = "Hectarea" Then
            lblr.Text = num1
        ElseIf cbxde.Text = "Metro cuadrado" And cbxa.Text = "Pie cuadrado" Then
            lblr.Text = num1 * 10.76391
        ElseIf cbxde.Text = "Metro cuadrado" And cbxa.Text = "Vara cuadrada" Then
            lblr.Text = num1 * 1.3949972136
        ElseIf cbxde.Text = "Metro cuadrado" And cbxa.Text = "Yarda cuadrada" Then
            lblr.Text = num1 * 1.19599
        ElseIf cbxde.Text = "Metro cuadrado" And cbxa.Text = "Metro cuadrado" Then
            lblr.Text = num1
        ElseIf cbxde.Text = "Metro cuadrado" And cbxa.Text = "Tareas" Then
            lblr.Text = num1 * 0.0015903307888
        ElseIf cbxde.Text = "Metro cuadrado" And cbxa.Text = "Manzanas" Then
            lblr.Text = num1 * 0.00014196479273
        ElseIf cbxde.Text = "Metro cuadrado" And cbxa.Text = "Hectarea" Then
            lblr.Text = num1 * 0.0001
            End If
    End Sub
End Class