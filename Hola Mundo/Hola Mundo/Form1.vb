Public Class Form1
    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click

        If cbxEntrada.Text = "Bits" And cbxSalida.Text = "Bits" Then
            lblr.Text = Val(txtvalor.Text)
            lblm.Text = "bits"
        ElseIf cbxEntrada.Text = "Bits" And cbxSalida.Text = "Bytes" Then
            lblr.Text = Val(txtvalor.Text) / 8
            lblm.Text = "B"
        ElseIf cbxEntrada.Text = "Bits" And cbxSalida.Text = "Gigabits" Then
            lblr.Text = Val(txtvalor.Text) / 1073741824
            lblm.Text = "GBit"
        ElseIf cbxEntrada.Text = "Bits" And cbxSalida.Text = "Gigabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8589934592
            lblm.Text = "GB"
        ElseIf cbxEntrada.Text = "Bits" And cbxSalida.Text = "Kilobits" Then
            lblr.Text = Val(txtvalor.Text) / 1024
            lblm.Text = "KBit"
        ElseIf cbxEntrada.Text = "Bits" And cbxSalida.Text = "Kilobytes" Then
            lblr.Text = Val(txtvalor.Text) / 8192
            lblm.Text = "KB"
        ElseIf cbxEntrada.Text = "Bits" And cbxSalida.Text = "Megabits" Then
            lblr.Text = Val(txtvalor.Text) / 1048576
            lblm.Text = "MBit"
        ElseIf cbxEntrada.Text = "Bits" And cbxSalida.Text = "Megabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8388608
            lblm.Text = "MB"
        ElseIf cbxEntrada.Text = "Bits" And cbxSalida.Text = "Petabits" Then
            lblr.Text = Val(txtvalor.Text) / 1125899906842620
            lblm.Text = "Pbit"
        ElseIf cbxEntrada.Text = "Bits" And cbxSalida.Text = "Petabytes" Then
            lblr.Text = Val(txtvalor.Text) / 9007199254740990
            lblm.Text = "PB"


        ElseIf cbxEntrada.Text = "Bytes" And cbxSalida.Text = "Bits" Then
            lblr.Text = Val(txtvalor.Text) * 8
            lblm.Text = "bits"
        ElseIf cbxEntrada.Text = "Bytes" And cbxSalida.Text = "Bytes" Then
            lblr.Text = Val(txtvalor.Text)
            lblm.Text = "B"
        ElseIf cbxEntrada.Text = "Bytes" And cbxSalida.Text = "Gigabits" Then
            lblr.Text = Val(txtvalor.Text) / 134217728
            lblm.Text = "GBit"
        ElseIf cbxEntrada.Text = "Bytes" And cbxSalida.Text = "Gigabytes" Then
            lblr.Text = Val(txtvalor.Text) / 1073741824
            lblm.Text = "GB"
        ElseIf cbxEntrada.Text = "Bytes" And cbxSalida.Text = "kilobits" Then
            lblr.Text = Val(txtvalor.Text) / 128
            lblm.Text = "KBit"
        ElseIf cbxEntrada.Text = "Bytes" And cbxSalida.Text = "Kilobytes" Then
            lblr.Text = Val(txtvalor.Text) / 1000
            lblm.Text = "KB"
        ElseIf cbxEntrada.Text = "Bytes" And cbxSalida.Text = "Megabits" Then
            lblr.Text = Val(txtvalor.Text) / 131072
            lblm.Text = "MBit"
        ElseIf cbxEntrada.Text = "Bytes" And cbxSalida.Text = "Megabytes" Then
            lblr.Text = Val(txtvalor.Text) / 1048576
            lblm.Text = "MB"
        ElseIf cbxEntrada.Text = "Bytes" And cbxSalida.Text = "Petabits" Then
            lblr.Text = Val(txtvalor.Text) / 140737488355328
            lblm.Text = "PBit"
        ElseIf cbxEntrada.Text = "Bytes" And cbxSalida.Text = "Petabytes" Then
            lblr.Text = Val(txtvalor.Text) / 1125899906842620
            lblm.Text = "PB"


        ElseIf cbxEntrada.Text = "Gigabits" And cbxSalida.Text = "Bits" Then
            lblr.Text = Val(txtvalor.Text) * 1073741824
            lblm.Text = "bits"
        ElseIf cbxEntrada.Text = "Gigabits" And cbxSalida.Text = "Bytes" Then
            lblr.Text = Val(txtvalor.Text) * 134217728
            lblm.Text = "B"
        ElseIf cbxEntrada.Text = "Gigabits" And cbxSalida.Text = "Gigabits" Then
            lblr.Text = Val(txtvalor.Text)
            lblm.Text = "GBit"
        ElseIf cbxEntrada.Text = "Gigabits" And cbxSalida.Text = "Gigabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8
            lblm.Text = "GB"
        ElseIf cbxEntrada.Text = "Gigabits" And cbxSalida.Text = "Kilobits" Then
            lblr.Text = Val(txtvalor.Text) * 1048576
            lblm.Text = "KBit"
        ElseIf cbxEntrada.Text = "Gigabits" And cbxSalida.Text = "Kilobytes" Then
            lblr.Text = Val(txtvalor.Text) * 131072
            lblm.Text = "KB"
        ElseIf cbxEntrada.Text = "Gigabits" And cbxSalida.Text = "Megabits" Then
            lblr.Text = Val(txtvalor.Text) * 1024
            lblm.Text = "MBit"
        ElseIf cbxEntrada.Text = "Gigabits" And cbxSalida.Text = "Megabytes" Then
            lblr.Text = Val(txtvalor.Text) * 128
            lblm.Text = "MB"
        ElseIf cbxEntrada.Text = "Gigabits" And cbxSalida.Text = "Petabits" Then
            lblr.Text = Val(txtvalor.Text) / 1048576
            lblm.Text = "PBit"
        ElseIf cbxEntrada.Text = "Gigabits" And cbxSalida.Text = "Petabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8388608
            lblm.Text = "GBit"


        ElseIf cbxEntrada.Text = "Gigabytes" And cbxSalida.Text = "Bits" Then
            lblr.Text = Val(txtvalor.Text) * 8589934592
            lblm.Text = "bits"
        ElseIf cbxEntrada.Text = "Gigabytes" And cbxSalida.Text = "Bytes" Then
            lblr.Text = Val(txtvalor.Text) * 1073741824
            lblm.Text = "B"
        ElseIf cbxEntrada.Text = "Gigabytes" And cbxSalida.Text = "Gigabits" Then
            lblr.Text = Val(txtvalor.Text) * 8
            lblm.Text = "GBit"
        ElseIf cbxEntrada.Text = "Gigabytes" And cbxSalida.Text = "Gigabytes" Then
            lblr.Text = Val(txtvalor.Text)
            lblm.Text = "GB"
        ElseIf cbxEntrada.Text = "Gigabytes" And cbxSalida.Text = "Kilobits" Then
            lblr.Text = Val(txtvalor.Text) * 8388608
            lblm.Text = "KBit"
        ElseIf cbxEntrada.Text = "Gigabytes" And cbxSalida.Text = "Kilobytes" Then
            lblr.Text = Val(txtvalor.Text) * 1048576
            lblm.Text = "KB"
        ElseIf cbxEntrada.Text = "Gigabytes" And cbxSalida.Text = "Megabits" Then
            lblr.Text = Val(txtvalor.Text) * 8192
            lblm.Text = "MBit"
        ElseIf cbxEntrada.Text = "Gigabytes" And cbxSalida.Text = "Megabytes" Then
            lblr.Text = Val(txtvalor.Text) * 1024
            lblm.Text = "MB"
        ElseIf cbxEntrada.Text = "Gigabytes" And cbxSalida.Text = "Petabits" Then
            lblr.Text = Val(txtvalor.Text) / 131072
            lblm.Text = "PBit"
        ElseIf cbxEntrada.Text = "Gigabytes" And cbxSalida.Text = "Petabytes" Then
            lblr.Text = Val(txtvalor.Text) / 1048576
            lblm.Text = "PB"


        ElseIf cbxEntrada.Text = "Kilobits" And cbxSalida.Text = "Bits" Then
            lblr.Text = Val(txtvalor.Text) * 1024
            lblm.Text = "bits"
        ElseIf cbxEntrada.Text = "Kilobits" And cbxSalida.Text = "Bytes" Then
            lblr.Text = Val(txtvalor.Text) * 128
            lblm.Text = "B"
        ElseIf cbxEntrada.Text = "Kilobits" And cbxSalida.Text = "Gigabits" Then
            lblr.Text = Val(txtvalor.Text) / 1048576
            lblm.Text = "GBit"
        ElseIf cbxEntrada.Text = "Kilobits" And cbxSalida.Text = "Gigabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8388608
            lblm.Text = "GB"
        ElseIf cbxEntrada.Text = "Kilobits" And cbxSalida.Text = "Kilobits" Then
            lblr.Text = Val(txtvalor.Text)
            lblm.Text = "KBit"
        ElseIf cbxEntrada.Text = "Kilobits" And cbxSalida.Text = "kilobytes" Then
            lblr.Text = Val(txtvalor.Text) / 8
            lblm.Text = "KB"
        ElseIf cbxEntrada.Text = "Kilobits" And cbxSalida.Text = "Megabits" Then
            lblr.Text = Val(txtvalor.Text) / 1024
            lblm.Text = "MBit"
        ElseIf cbxEntrada.Text = "Kilobits" And cbxSalida.Text = "Megabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8192
            lblm.Text = "MB"
        ElseIf cbxEntrada.Text = "Kilobits" And cbxSalida.Text = "Petabits" Then
            lblr.Text = Val(txtvalor.Text) / 1099511627776
            lblm.Text = "PBit"
        ElseIf cbxEntrada.Text = "Kilobits" And cbxSalida.Text = "Petabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8796093022208
            lblm.Text = "PB"


        ElseIf cbxEntrada.Text = "Kilobytes" And cbxSalida.Text = "Bits" Then
            lblr.Text = Val(txtvalor.Text) * 8192
            lblm.Text = "bit"
        ElseIf cbxEntrada.Text = "Kilobytes" And cbxSalida.Text = "Bytes" Then
            lblr.Text = Val(txtvalor.Text) * 1000
            lblm.Text = "B"
        ElseIf cbxEntrada.Text = "Kilobytes" And cbxSalida.Text = "Gigabits" Then
            lblr.Text = Val(txtvalor.Text) / 131072
            lblm.Text = "GBit"
        ElseIf cbxEntrada.Text = "Kilobytes" And cbxSalida.Text = "Gigabytes" Then
            lblr.Text = Val(txtvalor.Text) / 1048576
            lblm.Text = "GB"
        ElseIf cbxEntrada.Text = "Kilobytes" And cbxSalida.Text = "Kilobits" Then
            lblr.Text = Val(txtvalor.Text) * 8
            lblm.Text = "KBit"
        ElseIf cbxEntrada.Text = "Kilobytes" And cbxSalida.Text = "Kilobytes" Then
            lblr.Text = Val(txtvalor.Text)
            lblm.Text = "KB"
        ElseIf cbxEntrada.Text = "Kilobytes" And cbxSalida.Text = "Megabits" Then
            lblr.Text = Val(txtvalor.Text) / 128
            lblm.Text = "MBit"
        ElseIf cbxEntrada.Text = "Kilobytes" And cbxSalida.Text = "Megabytes" Then
            lblr.Text = Val(txtvalor.Text) / 1024
            lblm.Text = "MB"
        ElseIf cbxEntrada.Text = "Kilobytes" And cbxSalida.Text = "Petabits" Then
            lblr.Text = Val(txtvalor.Text) / 137438953472
            lblm.Text = "PBit"
        ElseIf cbxEntrada.Text = "Kilobytes" And cbxSalida.Text = "Petabytes" Then
            lblr.Text = Val(txtvalor.Text) / 1099511627776
            lblm.Text = "PB"


        ElseIf cbxEntrada.Text = "Megabits" And cbxSalida.Text = "Bits" Then
            lblr.Text = Val(txtvalor.Text) * 1048576
            lblm.Text = "bit"
        ElseIf cbxEntrada.Text = "Megabits" And cbxSalida.Text = "Bytes" Then
            lblr.Text = Val(txtvalor.Text) * 131072
            lblm.Text = "B"
        ElseIf cbxEntrada.Text = "Megabits" And cbxSalida.Text = "Gigabits" Then
            lblr.Text = Val(txtvalor.Text) / 1024
            lblm.Text = "GBit"
        ElseIf cbxEntrada.Text = "Megabits" And cbxSalida.Text = "Gigabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8192
            lblm.Text = "GB"
        ElseIf cbxEntrada.Text = "Megabits" And cbxSalida.Text = "Kilobits" Then
            lblr.Text = Val(txtvalor.Text) * 1024
            lblm.Text = "KBit"
        ElseIf cbxEntrada.Text = "Megabits" And cbxSalida.Text = "Kilobytes" Then
            lblr.Text = Val(txtvalor.Text) * 128
            lblm.Text = "KB"
        ElseIf cbxEntrada.Text = "Megabits" And cbxSalida.Text = "Megabits" Then
            lblr.Text = Val(txtvalor.Text)
            lblm.Text = "MBit"
        ElseIf cbxEntrada.Text = "Megabits" And cbxSalida.Text = "Megabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8
            lblm.Text = "MB"
        ElseIf cbxEntrada.Text = "Megabits" And cbxSalida.Text = "Petabits" Then
            lblr.Text = Val(txtvalor.Text) / 1073741824
            lblm.Text = "GBit"
        ElseIf cbxEntrada.Text = "Megabits" And cbxSalida.Text = "Petabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8589934592
            lblm.Text = "GB"


        ElseIf cbxEntrada.Text = "Megabytes" And cbxSalida.Text = "Bits" Then
            lblr.Text = Val(txtvalor.Text) * 8388608
            lblm.Text = "bit"
        ElseIf cbxEntrada.Text = "Megabytes" And cbxSalida.Text = "Bytes" Then
            lblr.Text = Val(txtvalor.Text) * 1048576
            lblm.Text = "B"
        ElseIf cbxEntrada.Text = "Megabytes" And cbxSalida.Text = "Gigabits" Then
            lblr.Text = Val(txtvalor.Text) / 128
            lblm.Text = "GBit"
        ElseIf cbxEntrada.Text = "Megabytes" And cbxSalida.Text = "Gigabytes" Then
            lblr.Text = Val(txtvalor.Text) / 1024
            lblm.Text = "GB"
        ElseIf cbxEntrada.Text = "Megabytes" And cbxSalida.Text = "Kilobits" Then
            lblr.Text = Val(txtvalor.Text) * 8192
            lblm.Text = "KBit"
        ElseIf cbxEntrada.Text = "Megabytes" And cbxSalida.Text = "Kilobytes" Then
            lblr.Text = Val(txtvalor.Text) * 1024
            lblm.Text = "KB"
        ElseIf cbxEntrada.Text = "Megabytes" And cbxSalida.Text = "Megabits" Then
            lblr.Text = Val(txtvalor.Text) * 8
            lblm.Text = "MBit"
        ElseIf cbxEntrada.Text = "Megabytes" And cbxSalida.Text = "Megabytes" Then
            lblr.Text = Val(txtvalor.Text)
            lblm.Text = "MB"
        ElseIf cbxEntrada.Text = "Megabytes" And cbxSalida.Text = "Petabits" Then
            lblr.Text = Val(txtvalor.Text) / 134217728
            lblm.Text = "PBit"
        ElseIf cbxEntrada.Text = "Megabytes" And cbxSalida.Text = "Petabytes" Then
            lblr.Text = Val(txtvalor.Text) / 1073741824
            lblm.Text = "PB"


        ElseIf cbxEntrada.Text = "Petabits" And cbxSalida.Text = "Bits" Then
            lblr.Text = Val(txtvalor.Text) * 1125899906842620
            lblm.Text = "bit"
        ElseIf cbxEntrada.Text = "Petabits" And cbxSalida.Text = "Bytes" Then
            lblr.Text = Val(txtvalor.Text) * 140737488355328
            lblm.Text = "B"
        ElseIf cbxEntrada.Text = "Petabits" And cbxSalida.Text = "Gigabits" Then
            lblr.Text = Val(txtvalor.Text) * 1048576
            lblm.Text = "GBit"
        ElseIf cbxEntrada.Text = "Petabits" And cbxSalida.Text = "Gigabytes" Then
            lblr.Text = Val(txtvalor.Text) * 131072
            lblm.Text = "GB"
        ElseIf cbxEntrada.Text = "Petabits" And cbxSalida.Text = "Kilobits" Then
            lblr.Text = Val(txtvalor.Text) * 1099511627776
            lblm.Text = "KBit"
        ElseIf cbxEntrada.Text = "Petabits" And cbxSalida.Text = "Kilobytes" Then
            lblr.Text = Val(txtvalor.Text) * 137438953472
            lblm.Text = "KB"
        ElseIf cbxEntrada.Text = "Petabits" And cbxSalida.Text = "Megabits" Then
            lblr.Text = Val(txtvalor.Text) * 1073741824
            lblm.Text = "MBit"
        ElseIf cbxEntrada.Text = "Petabits" And cbxSalida.Text = "Megabytes" Then
            lblr.Text = Val(txtvalor.Text) * 134217728
            lblm.Text = "MB"
        ElseIf cbxEntrada.Text = "Petabits" And cbxSalida.Text = "Petabits" Then
            lblr.Text = Val(txtvalor.Text)
            lblm.Text = "PBit"
        ElseIf cbxEntrada.Text = "Petabits" And cbxSalida.Text = "Petabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8
            lblm.Text = "PB"


        ElseIf cbxEntrada.Text = "Petabytes" And cbxSalida.Text = "Bits" Then
            lblr.Text = Val(txtvalor.Text) * 9007199254740990
            lblm.Text = "bit"
        ElseIf cbxEntrada.Text = "Petabytes" And cbxSalida.Text = "Bytes" Then
            lblr.Text = Val(txtvalor.Text) * 1125899906842620
            lblm.Text = "B"
        ElseIf cbxEntrada.Text = "Petabytes" And cbxSalida.Text = "Gigabits" Then
            lblr.Text = Val(txtvalor.Text) * 8388608
            lblm.Text = "GBit"
        ElseIf cbxEntrada.Text = "Petabytes" And cbxSalida.Text = "Gigabytes" Then
            lblr.Text = Val(txtvalor.Text) * 1048576
            lblm.Text = "GB"
        ElseIf cbxEntrada.Text = "Petabytes" And cbxSalida.Text = "Kilobits" Then
            lblr.Text = Val(txtvalor.Text) * 8796093022208
            lblm.Text = "KBit"
        ElseIf cbxEntrada.Text = "Petabytes" And cbxSalida.Text = "Kilobytes" Then
            lblr.Text = Val(txtvalor.Text) * 1099511627776
            lblm.Text = "KB"
        ElseIf cbxEntrada.Text = "Petabytes" And cbxSalida.Text = "Megabits" Then
            lblr.Text = Val(txtvalor.Text) * 8589934592
            lblm.Text = "MBit"
        ElseIf cbxEntrada.Text = "Petabytes" And cbxSalida.Text = "Megabytes" Then
            lblr.Text = Val(txtvalor.Text) * 1073741824
            lblm.Text = "MB"
        ElseIf cbxEntrada.Text = "Petabytes" And cbxSalida.Text = "Petabits" Then
            lblr.Text = Val(txtvalor.Text) * 8
            lblm.Text = "PBit"
        ElseIf cbxEntrada.Text = "petabytes" And cbxSalida.Text = "Petabytes" Then
            lblr.Text = Val(txtvalor.Text)
            lblm.Text = "PB"
        End If
    End Sub
End Class