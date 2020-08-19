Public Class Form1
    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim num1 As Decimal
        num1 = txtvalor.Text
        'Almacenamiento
        If cbxEntrada.Text = "Bits" And cbxSalida.Text = "Bits" Then
            lblr.Text = Val(txtvalor.Text)
            lblu.Text = "bits"
        ElseIf cbxEntrada.Text = "Bits" And cbxSalida.Text = "Bytes" Then
            lblr.Text = Val(txtvalor.Text) / 8
            lblu.Text = "B"
        ElseIf cbxEntrada.Text = "Bits" And cbxSalida.Text = "Gigabits" Then
            lblr.Text = Val(txtvalor.Text) / 1073741824
            lblu.Text = "GBit"
        ElseIf cbxEntrada.Text = "Bits" And cbxSalida.Text = "Gigabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8589934592
            lblu.Text = "GB"
        ElseIf cbxEntrada.Text = "Bits" And cbxSalida.Text = "Kilobits" Then
            lblr.Text = Val(txtvalor.Text) / 1024
            lblu.Text = "KBit"
        ElseIf cbxEntrada.Text = "Bits" And cbxSalida.Text = "Kilobytes" Then
            lblr.Text = Val(txtvalor.Text) / 8192
            lblu.Text = "KB"
        ElseIf cbxEntrada.Text = "Bits" And cbxSalida.Text = "Megabits" Then
            lblr.Text = Val(txtvalor.Text) / 1048576
            lblu.Text = "MBit"
        ElseIf cbxEntrada.Text = "Bits" And cbxSalida.Text = "Megabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8388608
            lblu.Text = "MB"
        ElseIf cbxEntrada.Text = "Bits" And cbxSalida.Text = "Petabits" Then
            lblr.Text = Val(txtvalor.Text) / 1125899906842620
            lblu.Text = "Pbit"
        ElseIf cbxEntrada.Text = "Bits" And cbxSalida.Text = "Petabytes" Then
            lblr.Text = Val(txtvalor.Text) / 9007199254740990
            lblu.Text = "PB"


        ElseIf cbxEntrada.Text = "Bytes" And cbxSalida.Text = "Bits" Then
            lblr.Text = Val(txtvalor.Text) * 8
            lblu.Text = "bits"
        ElseIf cbxEntrada.Text = "Bytes" And cbxSalida.Text = "Bytes" Then
            lblr.Text = Val(txtvalor.Text)
            lblu.Text = "B"
        ElseIf cbxEntrada.Text = "Bytes" And cbxSalida.Text = "Gigabits" Then
            lblr.Text = Val(txtvalor.Text) / 134217728
            lblu.Text = "GBit"
        ElseIf cbxEntrada.Text = "Bytes" And cbxSalida.Text = "Gigabytes" Then
            lblr.Text = Val(txtvalor.Text) / 1073741824
            lblu.Text = "GB"
        ElseIf cbxEntrada.Text = "Bytes" And cbxSalida.Text = "kilobits" Then
            lblr.Text = Val(txtvalor.Text) / 128
            lblu.Text = "KBit"
        ElseIf cbxEntrada.Text = "Bytes" And cbxSalida.Text = "Kilobytes" Then
            lblr.Text = Val(txtvalor.Text) / 1000
            lblu.Text = "KB"
        ElseIf cbxEntrada.Text = "Bytes" And cbxSalida.Text = "Megabits" Then
            lblr.Text = Val(txtvalor.Text) / 131072
            lblu.Text = "MBit"
        ElseIf cbxEntrada.Text = "Bytes" And cbxSalida.Text = "Megabytes" Then
            lblr.Text = Val(txtvalor.Text) / 1048576
            lblu.Text = "MB"
        ElseIf cbxEntrada.Text = "Bytes" And cbxSalida.Text = "Petabits" Then
            lblr.Text = Val(txtvalor.Text) / 140737488355328
            lblu.Text = "PBit"
        ElseIf cbxEntrada.Text = "Bytes" And cbxSalida.Text = "Petabytes" Then
            lblr.Text = Val(txtvalor.Text) / 1125899906842620
            lblu.Text = "PB"


        ElseIf cbxEntrada.Text = "Gigabits" And cbxSalida.Text = "Bits" Then
            lblr.Text = Val(txtvalor.Text) * 1073741824
            lblu.Text = "bits"
        ElseIf cbxEntrada.Text = "Gigabits" And cbxSalida.Text = "Bytes" Then
            lblr.Text = Val(txtvalor.Text) * 134217728
            lblu.Text = "B"
        ElseIf cbxEntrada.Text = "Gigabits" And cbxSalida.Text = "Gigabits" Then
            lblr.Text = Val(txtvalor.Text)
            lblu.Text = "GBit"
        ElseIf cbxEntrada.Text = "Gigabits" And cbxSalida.Text = "Gigabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8
            lblu.Text = "GB"
        ElseIf cbxEntrada.Text = "Gigabits" And cbxSalida.Text = "Kilobits" Then
            lblr.Text = Val(txtvalor.Text) * 1048576
            lblu.Text = "KBit"
        ElseIf cbxEntrada.Text = "Gigabits" And cbxSalida.Text = "Kilobytes" Then
            lblr.Text = Val(txtvalor.Text) * 131072
            lblu.Text = "KB"
        ElseIf cbxEntrada.Text = "Gigabits" And cbxSalida.Text = "Megabits" Then
            lblr.Text = Val(txtvalor.Text) * 1024
            lblu.Text = "MBit"
        ElseIf cbxEntrada.Text = "Gigabits" And cbxSalida.Text = "Megabytes" Then
            lblr.Text = Val(txtvalor.Text) * 128
            lblu.Text = "MB"
        ElseIf cbxEntrada.Text = "Gigabits" And cbxSalida.Text = "Petabits" Then
            lblr.Text = Val(txtvalor.Text) / 1048576
            lblu.Text = "PBit"
        ElseIf cbxEntrada.Text = "Gigabits" And cbxSalida.Text = "Petabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8388608
            lblu.Text = "GBit"


        ElseIf cbxEntrada.Text = "Gigabytes" And cbxSalida.Text = "Bits" Then
            lblr.Text = Val(txtvalor.Text) * 8589934592
            lblu.Text = "bits"
        ElseIf cbxEntrada.Text = "Gigabytes" And cbxSalida.Text = "Bytes" Then
            lblr.Text = Val(txtvalor.Text) * 1073741824
            lblu.Text = "B"
        ElseIf cbxEntrada.Text = "Gigabytes" And cbxSalida.Text = "Gigabits" Then
            lblr.Text = Val(txtvalor.Text) * 8
            lblu.Text = "GBit"
        ElseIf cbxEntrada.Text = "Gigabytes" And cbxSalida.Text = "Gigabytes" Then
            lblr.Text = Val(txtvalor.Text)
            lblu.Text = "GB"
        ElseIf cbxEntrada.Text = "Gigabytes" And cbxSalida.Text = "Kilobits" Then
            lblr.Text = Val(txtvalor.Text) * 8388608
            lblu.Text = "KBit"
        ElseIf cbxEntrada.Text = "Gigabytes" And cbxSalida.Text = "Kilobytes" Then
            lblr.Text = Val(txtvalor.Text) * 1048576
            lblu.Text = "KB"
        ElseIf cbxEntrada.Text = "Gigabytes" And cbxSalida.Text = "Megabits" Then
            lblr.Text = Val(txtvalor.Text) * 8192
            lblu.Text = "MBit"
        ElseIf cbxEntrada.Text = "Gigabytes" And cbxSalida.Text = "Megabytes" Then
            lblr.Text = Val(txtvalor.Text) * 1024
            lblu.Text = "MB"
        ElseIf cbxEntrada.Text = "Gigabytes" And cbxSalida.Text = "Petabits" Then
            lblr.Text = Val(txtvalor.Text) / 131072
            lblu.Text = "PBit"
        ElseIf cbxEntrada.Text = "Gigabytes" And cbxSalida.Text = "Petabytes" Then
            lblr.Text = Val(txtvalor.Text) / 1048576
            lblu.Text = "PB"


        ElseIf cbxEntrada.Text = "Kilobits" And cbxSalida.Text = "Bits" Then
            lblr.Text = Val(txtvalor.Text) * 1024
            lblu.Text = "bits"
        ElseIf cbxEntrada.Text = "Kilobits" And cbxSalida.Text = "Bytes" Then
            lblr.Text = Val(txtvalor.Text) * 128
            lblu.Text = "B"
        ElseIf cbxEntrada.Text = "Kilobits" And cbxSalida.Text = "Gigabits" Then
            lblr.Text = Val(txtvalor.Text) / 1048576
            lblu.Text = "GBit"
        ElseIf cbxEntrada.Text = "Kilobits" And cbxSalida.Text = "Gigabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8388608
            lblu.Text = "GB"
        ElseIf cbxEntrada.Text = "Kilobits" And cbxSalida.Text = "Kilobits" Then
            lblr.Text = Val(txtvalor.Text)
            lblu.Text = "KBit"
        ElseIf cbxEntrada.Text = "Kilobits" And cbxSalida.Text = "kilobytes" Then
            lblr.Text = Val(txtvalor.Text) / 8
            lblu.Text = "KB"
        ElseIf cbxEntrada.Text = "Kilobits" And cbxSalida.Text = "Megabits" Then
            lblr.Text = Val(txtvalor.Text) / 1024
            lblu.Text = "MBit"
        ElseIf cbxEntrada.Text = "Kilobits" And cbxSalida.Text = "Megabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8192
            lblu.Text = "MB"
        ElseIf cbxEntrada.Text = "Kilobits" And cbxSalida.Text = "Petabits" Then
            lblr.Text = Val(txtvalor.Text) / 1099511627776
            lblu.Text = "PBit"
        ElseIf cbxEntrada.Text = "Kilobits" And cbxSalida.Text = "Petabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8796093022208
            lblu.Text = "PB"


        ElseIf cbxEntrada.Text = "Kilobytes" And cbxSalida.Text = "Bits" Then
            lblr.Text = Val(txtvalor.Text) * 8192
            lblu.Text = "bit"
        ElseIf cbxEntrada.Text = "Kilobytes" And cbxSalida.Text = "Bytes" Then
            lblr.Text = Val(txtvalor.Text) * 1000
            lblu.Text = "B"
        ElseIf cbxEntrada.Text = "Kilobytes" And cbxSalida.Text = "Gigabits" Then
            lblr.Text = Val(txtvalor.Text) / 131072
            lblu.Text = "GBit"
        ElseIf cbxEntrada.Text = "Kilobytes" And cbxSalida.Text = "Gigabytes" Then
            lblr.Text = Val(txtvalor.Text) / 1048576
            lblu.Text = "GB"
        ElseIf cbxEntrada.Text = "Kilobytes" And cbxSalida.Text = "Kilobits" Then
            lblr.Text = Val(txtvalor.Text) * 8
            lblu.Text = "KBit"
        ElseIf cbxEntrada.Text = "Kilobytes" And cbxSalida.Text = "Kilobytes" Then
            lblr.Text = Val(txtvalor.Text)
            lblu.Text = "KB"
        ElseIf cbxEntrada.Text = "Kilobytes" And cbxSalida.Text = "Megabits" Then
            lblr.Text = Val(txtvalor.Text) / 128
            lblu.Text = "MBit"
        ElseIf cbxEntrada.Text = "Kilobytes" And cbxSalida.Text = "Megabytes" Then
            lblr.Text = Val(txtvalor.Text) / 1024
            lblu.Text = "MB"
        ElseIf cbxEntrada.Text = "Kilobytes" And cbxSalida.Text = "Petabits" Then
            lblr.Text = Val(txtvalor.Text) / 137438953472
            lblu.Text = "PBit"
        ElseIf cbxEntrada.Text = "Kilobytes" And cbxSalida.Text = "Petabytes" Then
            lblr.Text = Val(txtvalor.Text) / 1099511627776
            lblu.Text = "PB"


        ElseIf cbxEntrada.Text = "Megabits" And cbxSalida.Text = "Bits" Then
            lblr.Text = Val(txtvalor.Text) * 1048576
            lblu.Text = "bit"
        ElseIf cbxEntrada.Text = "Megabits" And cbxSalida.Text = "Bytes" Then
            lblr.Text = Val(txtvalor.Text) * 131072
            lblu.Text = "B"
        ElseIf cbxEntrada.Text = "Megabits" And cbxSalida.Text = "Gigabits" Then
            lblr.Text = Val(txtvalor.Text) / 1024
            lblu.Text = "GBit"
        ElseIf cbxEntrada.Text = "Megabits" And cbxSalida.Text = "Gigabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8192
            lblu.Text = "GB"
        ElseIf cbxEntrada.Text = "Megabits" And cbxSalida.Text = "Kilobits" Then
            lblr.Text = Val(txtvalor.Text) * 1024
            lblu.Text = "KBit"
        ElseIf cbxEntrada.Text = "Megabits" And cbxSalida.Text = "Kilobytes" Then
            lblr.Text = Val(txtvalor.Text) * 128
            lblu.Text = "KB"
        ElseIf cbxEntrada.Text = "Megabits" And cbxSalida.Text = "Megabits" Then
            lblr.Text = Val(txtvalor.Text)
            lblu.Text = "MBit"
        ElseIf cbxEntrada.Text = "Megabits" And cbxSalida.Text = "Megabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8
            lblu.Text = "MB"
        ElseIf cbxEntrada.Text = "Megabits" And cbxSalida.Text = "Petabits" Then
            lblr.Text = Val(txtvalor.Text) / 1073741824
            lblu.Text = "GBit"
        ElseIf cbxEntrada.Text = "Megabits" And cbxSalida.Text = "Petabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8589934592
            lblu.Text = "GB"


        ElseIf cbxEntrada.Text = "Megabytes" And cbxSalida.Text = "Bits" Then
            lblr.Text = Val(txtvalor.Text) * 8388608
            lblu.Text = "bit"
        ElseIf cbxEntrada.Text = "Megabytes" And cbxSalida.Text = "Bytes" Then
            lblr.Text = Val(txtvalor.Text) * 1048576
            lblu.Text = "B"
        ElseIf cbxEntrada.Text = "Megabytes" And cbxSalida.Text = "Gigabits" Then
            lblr.Text = Val(txtvalor.Text) / 128
            lblu.Text = "GBit"
        ElseIf cbxEntrada.Text = "Megabytes" And cbxSalida.Text = "Gigabytes" Then
            lblr.Text = Val(txtvalor.Text) / 1024
            lblu.Text = "GB"
        ElseIf cbxEntrada.Text = "Megabytes" And cbxSalida.Text = "Kilobits" Then
            lblr.Text = Val(txtvalor.Text) * 8192
            lblu.Text = "KBit"
        ElseIf cbxEntrada.Text = "Megabytes" And cbxSalida.Text = "Kilobytes" Then
            lblr.Text = Val(txtvalor.Text) * 1024
            lblu.Text = "KB"
        ElseIf cbxEntrada.Text = "Megabytes" And cbxSalida.Text = "Megabits" Then
            lblr.Text = Val(txtvalor.Text) * 8
            lblu.Text = "MBit"
        ElseIf cbxEntrada.Text = "Megabytes" And cbxSalida.Text = "Megabytes" Then
            lblr.Text = Val(txtvalor.Text)
            lblu.Text = "MB"
        ElseIf cbxEntrada.Text = "Megabytes" And cbxSalida.Text = "Petabits" Then
            lblr.Text = Val(txtvalor.Text) / 134217728
            lblu.Text = "PBit"
        ElseIf cbxEntrada.Text = "Megabytes" And cbxSalida.Text = "Petabytes" Then
            lblr.Text = Val(txtvalor.Text) / 1073741824
            lblu.Text = "PB"


        ElseIf cbxEntrada.Text = "Petabits" And cbxSalida.Text = "Bits" Then
            lblr.Text = Val(txtvalor.Text) * 1125899906842620
            lblu.Text = "bit"
        ElseIf cbxEntrada.Text = "Petabits" And cbxSalida.Text = "Bytes" Then
            lblr.Text = Val(txtvalor.Text) * 140737488355328
            lblu.Text = "B"
        ElseIf cbxEntrada.Text = "Petabits" And cbxSalida.Text = "Gigabits" Then
            lblr.Text = Val(txtvalor.Text) * 1048576
            lblu.Text = "GBit"
        ElseIf cbxEntrada.Text = "Petabits" And cbxSalida.Text = "Gigabytes" Then
            lblr.Text = Val(txtvalor.Text) * 131072
            lblu.Text = "GB"
        ElseIf cbxEntrada.Text = "Petabits" And cbxSalida.Text = "Kilobits" Then
            lblr.Text = Val(txtvalor.Text) * 1099511627776
            lblu.Text = "KBit"
        ElseIf cbxEntrada.Text = "Petabits" And cbxSalida.Text = "Kilobytes" Then
            lblr.Text = Val(txtvalor.Text) * 137438953472
            lblu.Text = "KB"
        ElseIf cbxEntrada.Text = "Petabits" And cbxSalida.Text = "Megabits" Then
            lblr.Text = Val(txtvalor.Text) * 1073741824
            lblu.Text = "MBit"
        ElseIf cbxEntrada.Text = "Petabits" And cbxSalida.Text = "Megabytes" Then
            lblr.Text = Val(txtvalor.Text) * 134217728
            lblu.Text = "MB"
        ElseIf cbxEntrada.Text = "Petabits" And cbxSalida.Text = "Petabits" Then
            lblr.Text = Val(txtvalor.Text)
            lblu.Text = "PBit"
        ElseIf cbxEntrada.Text = "Petabits" And cbxSalida.Text = "Petabytes" Then
            lblr.Text = Val(txtvalor.Text) / 8
            lblu.Text = "PB"


        ElseIf cbxEntrada.Text = "Petabytes" And cbxSalida.Text = "Bits" Then
            lblr.Text = Val(txtvalor.Text) * 9007199254740990
            lblu.Text = "bit"
        ElseIf cbxEntrada.Text = "Petabytes" And cbxSalida.Text = "Bytes" Then
            lblr.Text = Val(txtvalor.Text) * 1125899906842620
            lblu.Text = "B"
        ElseIf cbxEntrada.Text = "Petabytes" And cbxSalida.Text = "Gigabits" Then
            lblr.Text = Val(txtvalor.Text) * 8388608
            lblu.Text = "GBit"
        ElseIf cbxEntrada.Text = "Petabytes" And cbxSalida.Text = "Gigabytes" Then
            lblr.Text = Val(txtvalor.Text) * 1048576
            lblu.Text = "GB"
        ElseIf cbxEntrada.Text = "Petabytes" And cbxSalida.Text = "Kilobits" Then
            lblr.Text = Val(txtvalor.Text) * 8796093022208
            lblu.Text = "KBit"
        ElseIf cbxEntrada.Text = "Petabytes" And cbxSalida.Text = "Kilobytes" Then
            lblr.Text = Val(txtvalor.Text) * 1099511627776
            lblu.Text = "KB"
        ElseIf cbxEntrada.Text = "Petabytes" And cbxSalida.Text = "Megabits" Then
            lblr.Text = Val(txtvalor.Text) * 8589934592
            lblu.Text = "MBit"
        ElseIf cbxEntrada.Text = "Petabytes" And cbxSalida.Text = "Megabytes" Then
            lblr.Text = Val(txtvalor.Text) * 1073741824
            lblu.Text = "MB"
        ElseIf cbxEntrada.Text = "Petabytes" And cbxSalida.Text = "Petabits" Then
            lblr.Text = Val(txtvalor.Text) * 8
            lblu.Text = "PBit"
        ElseIf cbxEntrada.Text = "petabytes" And cbxSalida.Text = "Petabytes" Then
            lblr.Text = Val(txtvalor.Text)
            lblu.Text = "PB"

            'VOLUMEN
        ElseIf cbxvol1.Text = "Litro" And cbxVol2.Text = "Mililitro" Then
            lblr.Text = num1 * 1000
        ElseIf cbxvol1.Text = "Litro" And cbxVol2.Text = "Pie cubico" Then
            lblr.Text = num1 / 28.317
        ElseIf cbxvol1.Text = "Litro" And cbxVol2.Text = "Pulgada Cubica" Then
            lblr.Text = num1 * 61.024
        ElseIf cbxvol1.Text = "Litro" And cbxVol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 * 35.195
        ElseIf cbxvol1.Text = "Litro" And cbxVol2.Text = "Metro cubico" Then
            lblr.Text = num1 / 1000
        ElseIf cbxvol1.Text = "Litro" And cbxVol2.Text = "Galon imperial" Then
            lblr.Text = num1 / 4.546
        ElseIf cbxvol1.Text = "Litro" And cbxVol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 * 1.057
        ElseIf cbxvol1.Text = "Litro" And cbxVol2.Text = "Taza imperial" Then
            lblr.Text = num1 * 3.52
        ElseIf cbxvol1.Text = "Litro" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 67.628
        ElseIf cbxvol1.Text = "Litro" And cbxVol2.Text = "Litro" Then
            lblr.Text = num1
        ElseIf cbxvol1.Text = "Mililitro" And cbxVol2.Text = "Litro" Then
            lblr.Text = num1 / 1000
        ElseIf cbxvol1.Text = "Mililitro" And cbxVol2.Text = "Mililitro" Then
            lblr.Text = num1
        ElseIf cbxvol1.Text = "Mililitro" And cbxVol2.Text = "Pie cubico" Then
            lblr.Text = num1 / 28317
        ElseIf cbxvol1.Text = "Mililitro" And cbxVol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 / 28.413
        ElseIf cbxvol1.Text = "Mililitro" And cbxVol2.Text = "Metro Cubico" Then
            lblr.Text = num1 / 1000000.0
        ElseIf cbxvol1.Text = "Mililitro" And cbxVol2.Text = "Pulgada Cubica" Then
            lblr.Text = num1 / 16.387
        ElseIf cbxvol1.Text = "Mililitro" And cbxVol2.Text = "Galon imperial" Then
            lblr.Text = num1 / 4546
        ElseIf cbxvol1.Text = "Mililitro" And cbxVol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 / 946
        ElseIf cbxvol1.Text = "Mililitro" And cbxVol2.Text = "Taza imperial" Then
            lblr.Text = num1 / 284
        ElseIf cbxvol1.Text = "Mililitro" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 / 14.787
        ElseIf cbxvol1.Text = "Pie cubico" And cbxVol2.Text = "Litro" Then
            lblr.Text = num1 * 28.317
        ElseIf cbxvol1.Text = "Pie cubico" And cbxVol2.Text = "Mililitro" Then
            lblr.Text = num1 * 28317
        ElseIf cbxvol1.Text = "Pie cubico" And cbxVol2.Text = "Pie cubico" Then
            lblr.Text = num1
        ElseIf cbxvol1.Text = "Pie cubico" And cbxVol2.Text = "Pulgada Cubica" Then
            lblr.Text = num1 * 1728
        ElseIf cbxvol1.Text = "Pie cubico" And cbxVol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 * 996.614
        ElseIf cbxvol1.Text = "Pie cubico" And cbxVol2.Text = "Metro cubico" Then
            lblr.Text = num1 / 35.315
        ElseIf cbxvol1.Text = "Pie cubico" And cbxVol2.Text = "Galon imperial" Then
            lblr.Text = num1 * 24.9153
        ElseIf cbxvol1.Text = "Pie cubico" And cbxVol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 * 29.922
        ElseIf cbxvol1.Text = "Pie cubico" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 1915.01
        ElseIf cbxvol1.Text = "Pie cubico" And cbxVol2.Text = "Taza imperial" Then
            lblr.Text = num1 * 99.6614
        ElseIf cbxvol1.Text = "Pulgada Cubica" And cbxVol2.Text = "Litro" Then
            lblr.Text = num1 / 61.024
        ElseIf cbxvol1.Text = "Pulgada Cubica" And cbxVol2.Text = "Mililitro" Then
            lblr.Text = num1 * 16.3871
        ElseIf cbxvol1.Text = "Pulgada Cubica" And cbxVol2.Text = "Pie cubico" Then
            lblr.Text = num1 / 1728
        ElseIf cbxvol1.Text = "Pulgada Cubica" And cbxVol2.Text = "Pulgada Cubica" Then
            lblr.Text = num1
        ElseIf cbxvol1.Text = "Pulgada Cubica" And cbxVol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 / 1.734
        ElseIf cbxvol1.Text = "Pulgada Cubica" And cbxVol2.Text = "Metro cubico" Then
            lblr.Text = num1 / 61024
        ElseIf cbxvol1.Text = "Pulgada Cubica" And cbxVol2.Text = "Galon imperial" Then
            lblr.Text = num1 / 277
        ElseIf cbxvol1.Text = "Pulgada Cubica" And cbxVol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 / 57.75
        ElseIf cbxvol1.Text = "Pulgada Cubica" And cbxVol2.Text = "Taza imperial" Then
            lblr.Text = num1 / 17.339
        ElseIf cbxvol1.Text = "Pulgada Cubica" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 1.10823
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Litro" Then
            lblr.Text = num1 * 0.0284131
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Mililitro" Then
            lblr.Text = num1 * 28.413
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Pie cubico" Then
            lblr.Text = num1 / 997
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Pulgada Cubica" Then
            lblr.Text = num1 * 1.734
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Metro cubico" Then
            lblr.Text = num1 / 35195
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Galon imperial" Then
            lblr.Text = num1 / 160
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 / 33.307
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Taza imperial" Then
            lblr.Text = num1 / 10
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 1.92152
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 1.92152
        ElseIf cbxvol1.Text = "Metro cubico" And cbxVol2.Text = "Litro" Then
            lblr.Text = num1 * 1000
        ElseIf cbxvol1.Text = "Metro cubico" And cbxVol2.Text = "Mililitro" Then
            lblr.Text = num1 * 1000000.0
        ElseIf cbxvol1.Text = "Metro cubico" And cbxVol2.Text = "Pie cubico" Then
            lblr.Text = num1 * 35.3147
        ElseIf cbxvol1.Text = "Metro cubico" And cbxVol2.Text = "Pulgada Cubica" Then
            lblr.Text = num1 * 61023.7
        ElseIf cbxvol1.Text = "Metro cubico" And cbxVol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 * 35195.1
        ElseIf cbxvol1.Text = "Metro cubico" And cbxVol2.Text = "Metro cubico" Then
            lblr.Text = num1
        ElseIf cbxvol1.Text = "Metro cubico" And cbxVol2.Text = "Galon imperial" Then
            lblr.Text = num1 * 219.969
        ElseIf cbxvol1.Text = "Metro cubico" And cbxVol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 * 1056.69
        ElseIf cbxvol1.Text = "Metro cubico" And cbxVol2.Text = "Taza imperial" Then
            lblr.Text = num1 * 3519.51
        ElseIf cbxvol1.Text = "Metro cubico" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 67628
        ElseIf cbxvol1.Text = "Galon imperial" And cbxVol2.Text = "Litro" Then
            lblr.Text = num1 * 4.54609
        ElseIf cbxvol1.Text = "Galon imperial" And cbxVol2.Text = "Mililitro" Then
            lblr.Text = num1 * 454609
        ElseIf cbxvol1.Text = "Galon imperial" And cbxVol2.Text = "Pie cubico" Then
            lblr.Text = num1 * 0.160544
        ElseIf cbxvol1.Text = "Galon imperial" And cbxVol2.Text = "Pulgada Cubica" Then
            lblr.Text = num1 * 277.419
        ElseIf cbxvol1.Text = "Galon imperial" And cbxVol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 * 160
        ElseIf cbxvol1.Text = "Galon imperial" And cbxVol2.Text = "Metro cubico" Then
            lblr.Text = num1 * 0.004546609
        ElseIf cbxvol1.Text = "Galon imperial" And cbxVol2.Text = "Galon imperial" Then
            lblr.Text = num1
        ElseIf cbxvol1.Text = "Galon imperial" And cbxVol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 * 4.8038
        ElseIf cbxvol1.Text = "Galon imperial" And cbxVol2.Text = "Taza imperial" Then
            lblr.Text = num1 * 16
        ElseIf cbxvol1.Text = "Galon imperial" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 307.443
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxVol2.Text = "Litro" Then
            lblr.Text = num1 * 0.946343
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxVol2.Text = "Mililitro" Then
            lblr.Text = num1 * 946.353
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxVol2.Text = "Pie cubico" Then
            lblr.Text = num1 * 0.0334201
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxVol2.Text = "Pulgada Cubica" Then
            lblr.Text = num1 * 57.75
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxVol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 * 33.307
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxVol2.Text = "Metro cubico" Then
            lblr.Text = num1 * 0.000946353
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxVol2.Text = "Galon imperial" Then
            lblr.Text = num1 * 0.208169
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxVol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxVol2.Text = "Taza imperial" Then
            lblr.Text = num1 * 3.3307
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 64
        ElseIf cbxvol1.Text = "Taza imperial" And cbxVol2.Text = "Litro" Then
            lblr.Text = num1 * 0.284131
        ElseIf cbxvol1.Text = "Taza imperial" And cbxVol2.Text = "Mililitro" Then
            lblr.Text = num1 * 284.131
        ElseIf cbxvol1.Text = "Taza imperial" And cbxVol2.Text = "Pie cubico" Then
            lblr.Text = num1 * 0.010034
        ElseIf cbxvol1.Text = "Taza imperial" And cbxVol2.Text = "Pulgada Cubica" Then
            lblr.Text = num1 * 17.3387
        ElseIf cbxvol1.Text = "Taza imperial" And cbxVol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 * 10
        ElseIf cbxvol1.Text = "Taza imperial" And cbxVol2.Text = "Metro cubico" Then
            lblr.Text = num1 * 0.000284131
        ElseIf cbxvol1.Text = "Taza imperial" And cbxVol2.Text = "Galon imperial" Then
            lblr.Text = num1 * 0.0625
        ElseIf cbxvol1.Text = "Taza imperial" And cbxVol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 * 0.300237
        ElseIf cbxvol1.Text = "Taza imperial" And cbxVol2.Text = "Taza imperial" Then
            lblr.Text = num1
        ElseIf cbxvol1.Text = "Taza imperial" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 19.2152
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxVol2.Text = "Litro" Then
            lblr.Text = num1 * 0.0147868
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxVol2.Text = "Mililitro" Then
            lblr.Text = num1 * 14.7868
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxVol2.Text = "Pie cubico" Then
            lblr.Text = num1 * 0.00052219
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxVol2.Text = "Pulgada Cubica" Then
            lblr.Text = num1 * 0.902344
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxVol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 * 0.520421
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxVol2.Text = "Metro cubico" Then
            lblr.Text = num1 / 67628
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxVol2.Text = "Galon imperial" Then
            lblr.Text = num1 * 0.00325263
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxVol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 * 0.015625
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxVol2.Text = "Taza imperial" Then
            lblr.Text = num1 * 0.0520421
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1

            'TIEMPO
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 * 0.001
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1 / 1000000.0
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 / 1000000000.0
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 / 60000000000.0
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 1000
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1 * 0.001
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 / 1000000.0
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 / 60000000.0
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 1000000.0
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 * 1000
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 * 0.001
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 * 0.000016667
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 1000000000.0
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 * 1000000.0
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1 * 1000
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 / 60




        End If

    End Sub


End Class