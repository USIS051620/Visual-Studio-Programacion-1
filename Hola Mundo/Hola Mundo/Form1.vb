Public Class Form1
    Dim objEstadistica As New Estadistica
    Private Sub bntmMediaAritmetica_Click(sender As Object, e As EventArgs) Handles bntmMediaAritmetica.Click
        lblrespuestaMedia.Text = objEstadistica.calcularMedia(txtserie.Text.Split(","))
        lblrespuestaVarianza.Text = objEstadistica.calcularVarianza(txtserie.Text.Split(","))
        lblrespuestaDesvTipica.Text = objEstadistica.calcularDesvTipica(txtserie.Text.Split(","))
    End Sub
End Class