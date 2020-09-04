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
End Class