Public Class Form1
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim ntabla, i As Int64
        ntabla = txtntabla.Text
        i = 1

        lstTablas.Items.Clear()
        While i <= 10
            lstTablas.Items.Add(ntabla.ToString() + “x” + i.ToString() + “=” + (ntabla * i).ToString())
            i = i + 1
        End While

    End Sub
End Class