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
            lblu.Text = "ml"
        ElseIf cbxvol1.Text = "Litro" And cbxVol2.Text = "Pie cubico" Then
            lblr.Text = num1 / 28.317
            lblu.Text = "ft3"
        ElseIf cbxvol1.Text = "Litro" And cbxVol2.Text = "Pulgada Cubica" Then
            lblr.Text = num1 * 61.024
            lblu.Text = "in3"
        ElseIf cbxvol1.Text = "Litro" And cbxVol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 * 35.195
            lblu.Text = "oz"
        ElseIf cbxvol1.Text = "Litro" And cbxVol2.Text = "Metro cubico" Then
            lblr.Text = num1 / 1000
            lblu.Text = "m3"
        ElseIf cbxvol1.Text = "Litro" And cbxVol2.Text = "Galon imperial" Then
            lblr.Text = num1 / 4.546
            lblu.Text = "gl"
        ElseIf cbxvol1.Text = "Litro" And cbxVol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 * 1.057
            lblu.Text = "qt"
        ElseIf cbxvol1.Text = "Litro" And cbxVol2.Text = "Taza imperial" Then
            lblr.Text = num1 * 3.52
            lblu.Text = "Tz"
        ElseIf cbxvol1.Text = "Litro" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 67.628
            lblu.Text = "Cda"
        ElseIf cbxvol1.Text = "Litro" And cbxVol2.Text = "Litro" Then
            lblr.Text = num1
            lblu.Text = "l"
        ElseIf cbxvol1.Text = "Mililitro" And cbxVol2.Text = "Litro" Then
            lblr.Text = num1 / 1000
            lblu.Text = "l"
        ElseIf cbxvol1.Text = "Mililitro" And cbxVol2.Text = "Mililitro" Then
            lblr.Text = num1
            lblu.Text = "ml"
        ElseIf cbxvol1.Text = "Mililitro" And cbxVol2.Text = "Pie cubico" Then
            lblr.Text = num1 / 28317
            lblu.Text = "In3"
        ElseIf cbxvol1.Text = "Mililitro" And cbxVol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 / 28.413
            lblu.Text = "oz"
        ElseIf cbxvol1.Text = "Mililitro" And cbxVol2.Text = "Metro Cubico" Then
            lblr.Text = num1 / 1000000.0
            lblu.Text = "m3"
        ElseIf cbxvol1.Text = "Mililitro" And cbxVol2.Text = "Pulgada Cubica" Then
            lblr.Text = num1 / 16.387
            lblu.Text = "ft3"
        ElseIf cbxvol1.Text = "Mililitro" And cbxVol2.Text = "Galon imperial" Then
            lblr.Text = num1 / 4546
            lblu.Text = "gl"
        ElseIf cbxvol1.Text = "Mililitro" And cbxVol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 / 946
            lblu.Text = "qt"
        ElseIf cbxvol1.Text = "Mililitro" And cbxVol2.Text = "Taza imperial" Then
            lblr.Text = num1 / 284
            lblu.Text = "Tz"
        ElseIf cbxvol1.Text = "Mililitro" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 / 14.787
            lblu.Text = "Cda"
        ElseIf cbxvol1.Text = "Pie cubico" And cbxVol2.Text = "Litro" Then
            lblr.Text = num1 * 28.317
            lblu.Text = "l"
        ElseIf cbxvol1.Text = "Pie cubico" And cbxVol2.Text = "Mililitro" Then
            lblr.Text = num1 * 28317
            lblu.Text = "ml"
        ElseIf cbxvol1.Text = "Pie cubico" And cbxVol2.Text = "Pie cubico" Then
            lblr.Text = num1
            lblu.Text = "ft3"
        ElseIf cbxvol1.Text = "Pie cubico" And cbxVol2.Text = "Pulgada Cubica" Then
            lblr.Text = num1 * 1728
            lblu.Text = "in3"
        ElseIf cbxvol1.Text = "Pie cubico" And cbxVol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 * 996.614
            lblu.Text = "oz"
        ElseIf cbxvol1.Text = "Pie cubico" And cbxVol2.Text = "Metro cubico" Then
            lblr.Text = num1 / 35.315
            lblu.Text = "m3"
        ElseIf cbxvol1.Text = "Pie cubico" And cbxVol2.Text = "Galon imperial" Then
            lblr.Text = num1 * 24.9153
            lblu.Text = "gl"
        ElseIf cbxvol1.Text = "Pie cubico" And cbxVol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 * 29.922
            lblu.Text = "qt"
        ElseIf cbxvol1.Text = "Pie cubico" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 1915.01
            lblu.Text = "Cda"
        ElseIf cbxvol1.Text = "Pie cubico" And cbxVol2.Text = "Taza imperial" Then
            lblr.Text = num1 * 99.6614
            lblu.Text = "Tz"
        ElseIf cbxvol1.Text = "Pulgada Cubica" And cbxVol2.Text = "Litro" Then
            lblr.Text = num1 / 61.024
            lblu.Text = "l"
        ElseIf cbxvol1.Text = "Pulgada Cubica" And cbxVol2.Text = "Mililitro" Then
            lblr.Text = num1 * 16.3871
            lblu.Text = "ml"
        ElseIf cbxvol1.Text = "Pulgada Cubica" And cbxVol2.Text = "Pie cubico" Then
            lblr.Text = num1 / 1728
            lblu.Text = "ft3"
        ElseIf cbxvol1.Text = "Pulgada Cubica" And cbxVol2.Text = "Pulgada Cubica" Then
            lblr.Text = num1
            lblu.Text = "in3"
        ElseIf cbxvol1.Text = "Pulgada Cubica" And cbxVol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 / 1.734
            lblu.Text = "oz"
        ElseIf cbxvol1.Text = "Pulgada Cubica" And cbxVol2.Text = "Metro cubico" Then
            lblr.Text = num1 / 61024
            lblu.Text = "m3"
        ElseIf cbxvol1.Text = "Pulgada Cubica" And cbxVol2.Text = "Galon imperial" Then
            lblr.Text = num1 / 277
            lblu.Text = "gl"
        ElseIf cbxvol1.Text = "Pulgada Cubica" And cbxVol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 / 57.75
            lblu.Text = "qt"
        ElseIf cbxvol1.Text = "Pulgada Cubica" And cbxVol2.Text = "Taza imperial" Then
            lblr.Text = num1 / 17.339
            lblu.Text = "Tz"
        ElseIf cbxvol1.Text = "Pulgada Cubica" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 1.10823
            lblu.Text = "Cda"
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Litro" Then
            lblr.Text = num1 * 0.0284131
            lblu.Text = "l"
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Mililitro" Then
            lblr.Text = num1 * 28.413
            lblu.Text = "ml"
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Pie cubico" Then
            lblr.Text = num1 / 997
            lblu.Text = "ft3"
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Pulgada Cubica" Then
            lblr.Text = num1 * 1.734
            lblu.Text = "in3"
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1
            lblu.Text = "oz"
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Metro cubico" Then
            lblr.Text = num1 / 35195
            lblu.Text = "m3"
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Galon imperial" Then
            lblr.Text = num1 / 160
            lblu.Text = "gl"
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 / 33.307
            lblu.Text = "qt"
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Taza imperial" Then
            lblr.Text = num1 / 10
            lblu.Text = "Tz"
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 1.92152
            lblu.Text = "Cda"
        ElseIf cbxvol1.Text = "Metro cubico" And cbxVol2.Text = "Litro" Then
            lblr.Text = num1 * 1000
            lblu.Text = "l"
        ElseIf cbxvol1.Text = "Metro cubico" And cbxVol2.Text = "Mililitro" Then
            lblr.Text = num1 * 1000000.0
            lblu.Text = "ml"
        ElseIf cbxvol1.Text = "Metro cubico" And cbxVol2.Text = "Pie cubico" Then
            lblr.Text = num1 * 35.3147
            lblu.Text = "ft3"
        ElseIf cbxvol1.Text = "Metro cubico" And cbxVol2.Text = "Pulgada Cubica" Then
            lblr.Text = num1 * 61023.7
            lblu.Text = "in3"
        ElseIf cbxvol1.Text = "Metro cubico" And cbxVol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 * 35195.1
            lblu.Text = "oz"
        ElseIf cbxvol1.Text = "Metro cubico" And cbxVol2.Text = "Metro cubico" Then
            lblr.Text = num1
            lblu.Text = "m3"
        ElseIf cbxvol1.Text = "Metro cubico" And cbxVol2.Text = "Galon imperial" Then
            lblr.Text = num1 * 219.969
            lblu.Text = "gl"
        ElseIf cbxvol1.Text = "Metro cubico" And cbxVol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 * 1056.69
            lblu.Text = "qt"
        ElseIf cbxvol1.Text = "Metro cubico" And cbxVol2.Text = "Taza imperial" Then
            lblr.Text = num1 * 3519.51
            lblu.Text = "Tz"
        ElseIf cbxvol1.Text = "Metro cubico" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 67628
            lblu.Text = "Cda"
        ElseIf cbxvol1.Text = "Galon imperial" And cbxVol2.Text = "Litro" Then
            lblr.Text = num1 * 4.54609
            lblu.Text = "l"
        ElseIf cbxvol1.Text = "Galon imperial" And cbxVol2.Text = "Mililitro" Then
            lblr.Text = num1 * 454609
            lblu.Text = "ml"
        ElseIf cbxvol1.Text = "Galon imperial" And cbxVol2.Text = "Pie cubico" Then
            lblr.Text = num1 * 0.160544
            lblu.Text = "ft3"
        ElseIf cbxvol1.Text = "Galon imperial" And cbxVol2.Text = "Pulgada Cubica" Then
            lblr.Text = num1 * 277.419
            lblu.Text = "in3"
        ElseIf cbxvol1.Text = "Galon imperial" And cbxVol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 * 160
            lblu.Text = "oz"
        ElseIf cbxvol1.Text = "Galon imperial" And cbxVol2.Text = "Metro cubico" Then
            lblr.Text = num1 * 0.004546609
            lblu.Text = "m3"
        ElseIf cbxvol1.Text = "Galon imperial" And cbxVol2.Text = "Galon imperial" Then
            lblr.Text = num1
            lblu.Text = "gl"
        ElseIf cbxvol1.Text = "Galon imperial" And cbxVol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 * 4.8038
            lblu.Text = "qt"
        ElseIf cbxvol1.Text = "Galon imperial" And cbxVol2.Text = "Taza imperial" Then
            lblr.Text = num1 * 16
            lblu.Text = "Tz"
        ElseIf cbxvol1.Text = "Galon imperial" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 307.443
            lblu.Text = "Cda"
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxVol2.Text = "Litro" Then
            lblr.Text = num1 * 0.946343
            lblu.Text = "l"
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxVol2.Text = "Mililitro" Then
            lblr.Text = num1 * 946.353
            lblu.Text = "ml"
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxVol2.Text = "Pie cubico" Then
            lblr.Text = num1 * 0.0334201
            lblu.Text = "ft3"
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxVol2.Text = "Pulgada Cubica" Then
            lblr.Text = num1 * 57.75
            lblu.Text = "in3"
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxVol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 * 33.307
            lblu.Text = "oz"
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxVol2.Text = "Metro cubico" Then
            lblr.Text = num1 * 0.000946353
            lblu.Text = "m3"
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxVol2.Text = "Galon imperial" Then
            lblr.Text = num1 * 0.208169
            lblu.Text = "gl"
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxVol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1
            lblu.Text = "qt"
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxVol2.Text = "Taza imperial" Then
            lblr.Text = num1 * 3.3307
            lblu.Text = "Tz"
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 64
            lblu.Text = "Cda"
        ElseIf cbxvol1.Text = "Taza imperial" And cbxVol2.Text = "Litro" Then
            lblr.Text = num1 * 0.284131
            lblu.Text = "l"
        ElseIf cbxvol1.Text = "Taza imperial" And cbxVol2.Text = "Mililitro" Then
            lblr.Text = num1 * 284.131
            lblu.Text = "ml"
        ElseIf cbxvol1.Text = "Taza imperial" And cbxVol2.Text = "Pie cubico" Then
            lblr.Text = num1 * 0.010034
            lblu.Text = "ft3"
        ElseIf cbxvol1.Text = "Taza imperial" And cbxVol2.Text = "Pulgada Cubica" Then
            lblr.Text = num1 * 17.3387
            lblu.Text = "in3"
        ElseIf cbxvol1.Text = "Taza imperial" And cbxVol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 * 10
            lblu.Text = "oz"
        ElseIf cbxvol1.Text = "Taza imperial" And cbxVol2.Text = "Metro cubico" Then
            lblr.Text = num1 * 0.000284131
            lblu.Text = "m3"
        ElseIf cbxvol1.Text = "Taza imperial" And cbxVol2.Text = "Galon imperial" Then
            lblr.Text = num1 * 0.0625
            lblu.Text = "gl"
        ElseIf cbxvol1.Text = "Taza imperial" And cbxVol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 * 0.300237 \
                 lblu.Text = "qt"
        ElseIf cbxvol1.Text = "Taza imperial" And cbxVol2.Text = "Taza imperial" Then
            lblr.Text = num1
            lblu.Text = "Tz"
        ElseIf cbxvol1.Text = "Taza imperial" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 19.2152
            lblu.Text = "Cda"
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxVol2.Text = "Litro" Then
            lblr.Text = num1 * 0.0147868
            lblu.Text = "l"
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxVol2.Text = "Mililitro" Then
            lblr.Text = num1 * 14.7868
            lblu.Text = "ml"
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxVol2.Text = "Pie cubico" Then
            lblr.Text = num1 * 0.00052219
            lblu.Text = "ft3"
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxVol2.Text = "Pulgada Cubica" Then
            lblr.Text = num1 * 0.902344
            lblu.Text = "in3"
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxVol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 * 0.520421
            lblu.Text = "oz"
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxVol2.Text = "Metro cubico" Then
            lblr.Text = num1 / 67628
            lblu.Text = "m3"
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxVol2.Text = "Galon imperial" Then
            lblr.Text = num1 * 0.00325263
            lblu.Text = "gl"
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxVol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 *
                 lblu.Text = "qt"
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxVol2.Text = "Taza imperial" Then
            lblr.Text = num1 * 0.0520421
            lblu.Text = "Tz"
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxVol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1
            lblu.Text = "Cda"

            'TIEMPO
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 * 0.001
            lblu.Text = "Ms"
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1 / 1000000.0
            lblu.Text = "Ks"
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 / 1000000000.0
            lblu.Text = "S"
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 / 60000000000.0
            lblu.Text = "min"
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1
            lblu.Text = "Gs"
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Hora" Then
            lblr.Text = num1 / 0.00000000000027778
            lblu.Text = "h"
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Dia" Then
            lblr.Text = num1 / 0.000000000000011574
            lblu.Text = "Dia"
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Semana" Then
            lblr.Text = num1 / 0.0000000000000016534
            lblu.Text = "Semana"
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Decada" Then
            lblr.Text = num1 / 3.171E-18
            lblu.Text = "Decada"
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Año natural" Then
            lblr.Text = num1 / 3.17E-17
            lblu.Text = "An"
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 1000
            lblu.Text = "Gs"
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1
            lblu.Text = "Ms"
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1 * 0.001
            lblu.Text = "Ks"
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 / 1000000.0
            lblu.Text = "S"
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 / 60000000.0
            lblu.Text = "min"
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Hora" Then
            lblr.Text = num1 / 3600000000.0
            lblu.Text = "h"
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Dia" Then
            lblr.Text = num1 / 86400000000.0
            lblu.Text = "Dia"
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Semana" Then
            lblr.Text = num1 / 604800000000.0
            lblu.Text = "Seamana"
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Decada" Then
            lblr.Text = num1 / 315400000000000.0
            lblu.Text = "Decada"
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Año natural" Then
            lblr.Text = num1 / 31000000000000.0
            lblu.Text = "An"
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 1000000.0
            lblu.Text = "Gs"
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 * 1000
            lblu.Text = "Ms"
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1
            lblu.Text = "Ks"
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 * 0.001
            lblu.Text = "S"
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 * 0.000016667
            lblu.Text = "min"
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Hora" Then
            lblr.Text = num1 / 3600000.0
            lblu.Text = "h"
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Dia" Then
            lblr.Text = num1 / 86400000.0
            lblu.Text = "Dia"
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Semana" Then
            lblr.Text = num1 / 604800000.0
            lblu.Text = "Semana"
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Deacada" Then
            lblr.Text = num1 / 315400000000.0
            lblu.Text = "Deacada"
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Año natural" Then
            lblr.Text = num1 / 31540000000.0
            lblu.Text = "AN"
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 1000000000.0
            lblu.Text = "Gs"
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 * 1000000.0
            lblu.Text = "Ms"
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1 * 1000
            lblu.Text = "Ks"
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1
            lblu.Text = "S"
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 / 60
            lblu.Text = "min"
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Dia" Then
            lblr.Text = num1 / 86400
            lblu.Text = "Dia"
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Semana" Then
            lblr.Text = num1 / 604800
            lblu.Text = "Semana"
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Decada" Then
            lblr.Text = num1 / 315400000.0
            lblu.Text = "Decada"
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Año natural" Then
            lblr.Text = num1 / 31540000.0
            lblu.Text = "AN"
        ElseIf cbxtiem1.Text = "Minuto" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 60000000000.0
            lblu.Text = "Gs"
        ElseIf cbxtiem1.Text = "Minuto" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 * 60000000.0
            lblu.Text = "Ms"
        ElseIf cbxtiem1.Text = "Minuto" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1 * 60000
            lblu.Text = "Ks"
        ElseIf cbxtiem1.Text = "Minuto" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 * 60
            lblu.Text = "S"
        ElseIf cbxtiem1.Text = "Minuto" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1
            lblu.Text = "min"
        ElseIf cbxtiem1.Text = "Minuto" And cbxtiem2.Text = "Hora" Then
            lblr.Text = num1 / 60
            lblu.Text = "h"
        ElseIf cbxtiem1.Text = "Minuto" And cbxtiem2.Text = "Dia" Then
            lblr.Text = num1 * 0.000694444
            lblu.Text = "Dia"
        ElseIf cbxtiem1.Text = "Minuto" And cbxtiem2.Text = "Semana" Then
            lblr.Text = num1 * 0.000099206
            lblu.Text = "Semana"
        ElseIf cbxtiem1.Text = "Minuto" And cbxtiem2.Text = "Decada" Then
            lblr.Text = num1 * 0.00000019026
            lblu.Text = "Decada"
        ElseIf cbxtiem1.Text = "Minuto" And cbxtiem2.Text = "Año natural" Then
            lblr.Text = num1 * 0.0000019026
            lblu.Text = "AN"

            'LONGITUD 
        ElseIf cbxuni1.Text = "Metro" And cbxuni2.Text = "Centimetro" Then
            lblr.Text = num1 * 100
            lblu.Text = "cm"
        ElseIf cbxuni1.Text = "Metro" And cbxuni2.Text = "Milimetro" Then
            lblr.Text = num1 * 1000
            lblu.Text = "mm"
        ElseIf cbxuni1.Text = "Metro" And cbxuni2.Text = "Milla" Then
            lblr.Text = num1 / 1609
            lblu.Text = "mi"
        ElseIf cbxuni1.Text = "Metro" And cbxuni2.Text = "Yarda" Then
            lblr.Text = num1 * 1.094
            lblu.Text = "yd"
        ElseIf cbxuni1.Text = "Metro" And cbxuni2.Text = "Pie" Then
            lblr.Text = num1 * 3.281
            lblu.Text = "ft"
        ElseIf cbxuni1.Text = "Metro" And cbxuni2.Text = "Pulgada" Then
            lblr.Text = num1 * 39.37
            lblu.Text = "in"
        ElseIf cbxuni1.Text = "Metro" And cbxuni2.Text = "Kilometro" Then
            lblr.Text = num1 / 1000
            lblu.Text = "km"
        ElseIf cbxuni1.Text = "Metro" And cbxuni2.Text = "Nanometro" Then
            lblr.Text = num1 * 1000000000.0
            lblu.Text = "nm"
        ElseIf cbxuni1.Text = "Metro" And cbxuni2.Text = "Micrometro" Then
            lblr.Text = num1 * 1000000.0
            lblu.Text = "µm"
        ElseIf cbxuni1.Text = "Centimetro" And cbxuni2.Text = "Metro" Then
            lblr.Text = num1 / 100
            lblu.Text = "m"
        ElseIf cbxuni1.Text = "Centimetro" And cbxuni2.Text = "Milimetros" Then
            lblr.Text = num1 * 10
            lblu.Text = "mm"
        ElseIf cbxuni1.Text = "Centimetro" And cbxuni2.Text = "Milla" Then
            lblr.Text = num1 / 160934
            lblu.Text = "mi"
        ElseIf cbxuni1.Text = "Centimetro" And cbxuni2.Text = "Yarda" Then
            lblr.Text = num1 / 91.44
            lblu.Text = "yd"
        ElseIf cbxuni1.Text = "Centimetro" And cbxuni2.Text = "Pie" Then
            lblr.Text = num1 / 30.48
            lblu.Text = "ft"
        ElseIf cbxuni1.Text = "Centimetro" And cbxuni2.Text = "Pulgada" Then
            lblr.Text = num1 / 2.54
            lblu.Text = "in"
        ElseIf cbxuni1.Text = "Centimetro" And cbxuni2.Text = "Kilometro" Then
            lblr.Text = num1 * 100000
            lblu.Text = "km"
        ElseIf cbxuni1.Text = "Centimetro" And cbxuni2.Text = "Nanometro" Then
            lblr.Text = num1 * 10000000.0
            lblu.Text = "nm"
        ElseIf cbxuni1.Text = "Centimetro" And cbxuni2.Text = "Micrometro" Then
            lblr.Text = num1 * 10000
            lblu.Text = "µm"
        ElseIf cbxuni1.Text = "Milimetro" And cbxuni2.Text = "Metro" Then
            lblr.Text = num1 / 1000
            lblu.Text = "m"
        ElseIf cbxuni1.Text = "Milimetro" And cbxuni2.Text = "Centimetro" Then
            lblr.Text = num1 / 10
            lblu.Text = "cm"
        ElseIf cbxuni1.Text = "Milimetro" And cbxuni2.Text = "Milimetro" Then
            lblr.Text = num1
            lblu.Text = "mm"
        ElseIf cbxuni1.Text = "Milimetro" And cbxuni2.Text = "Milla" Then
            lblr.Text = num1 / 1609000.0
            lblu.Text = "mi"
        ElseIf cbxuni1.Text = "Milimetro" And cbxuni2.Text = "Yarda" Then
            lblr.Text = num1 / 914
            lblu.Text = "yd"
        ElseIf cbxuni1.Text = "Milimetro" And cbxuni2.Text = "Pie" Then
            lblr.Text = num1 / 305
            lblu.Text = "ft"
        ElseIf cbxuni1.Text = "Milimetro" And cbxuni2.Text = "Pulgada" Then
            lblr.Text = num1 / 25.4
            lblu.Text = "in"
        ElseIf cbxuni1.Text = "Milimetro" And cbxuni2.Text = "Kilometro" Then
            lblr.Text = num1 / 1000000.0
            lblu.Text = "km"
        ElseIf cbxuni1.Text = "Milimetro" And cbxuni2.Text = "Nanometro" Then
            lblr.Text = num1 * 1000000.0
            lblu.Text = "nm"
        ElseIf cbxuni1.Text = "Milimetro" And cbxuni2.Text = "Micrometro" Then
            lblr.Text = num1 * 1000
            lblu.Text = "µm"
        ElseIf cbxuni1.Text = "Milla" And cbxuni2.Text = "Metro" Then
            lblr.Text = num1 * 1604.34
            lblu.Text = "m"
        ElseIf cbxuni1.Text = "Milla" And cbxuni2.Text = "Centimetro" Then
            lblr.Text = num1 * 160934
            lblu.Text = "cm"
        ElseIf cbxuni1.Text = "Milla" And cbxuni2.Text = "Milimetro" Then
            lblr.Text = num1 * 1609000.0
            lblu.Text = "mm"
        ElseIf cbxuni1.Text = "Milla" And cbxuni2.Text = "Milla" Then
            lblr.Text = num1
            lblu.Text = "mi"
        ElseIf cbxuni1.Text = "Milla" And cbxuni2.Text = "Yarda" Then
            lblr.Text = num1 * 1760
            lblu.Text = "yd"
        ElseIf cbxuni1.Text = "Milla" And cbxuni2.Text = "Pie" Then
            lblr.Text = num1 * 5280
            lblu.Text = "ft"
        ElseIf cbxuni1.Text = "Milla" And cbxuni2.Text = "Pulgada" Then
            lblr.Text = num1 * 63360
            lblu.Text = "in"
        ElseIf cbxuni1.Text = "Milla" And cbxuni2.Text = "Kilometro" Then
            lblr.Text = num1 * 1.60934
            lblu.Text = "km"
        ElseIf cbxuni1.Text = "Milla" And cbxuni2.Text = "Nanometro" Then
            lblr.Text = num1 * 1609000000000.0
            lblu.Text = "nm"
        ElseIf cbxuni1.Text = "Milla" And cbxuni2.Text = "Micrometro" Then
            lblr.Text = num1 * 1609000000.0
            lblu.Text = "µm"
        ElseIf cbxuni1.Text = "Yarda" And cbxuni2.Text = "Metro" Then
            lblr.Text = num1 * 0.9144
            lblu.Text = "m"
        ElseIf cbxuni1.Text = "Yarda" And cbxuni2.Text = "Centimetro" Then
            lblr.Text = num1 * 91.44
            lblu.Text = "cm"
        ElseIf cbxuni1.Text = "Yarda" And cbxuni2.Text = "Milimetro" Then
            lblr.Text = num1 * 914.4
            lblu.Text = "mm"
        ElseIf cbxuni1.Text = "Yarda" And cbxuni2.Text = "Milla" Then
            lblr.Text = num1 * 0.000568182
            lblu.Text = "mi"
        ElseIf cbxuni1.Text = "Yarda" And cbxuni2.Text = "Yarda" Then
            lblr.Text = num1
            lblu.Text = "yd"
        ElseIf cbxuni1.Text = "Yarda" And cbxuni2.Text = "Pie" Then
            lblr.Text = num1 * 3
            lblu.Text = "ft"
        ElseIf cbxuni1.Text = "Yarda" And cbxuni2.Text = "Pulgada" Then
            lblr.Text = num1 * 36
            lblu.Text = "in"
        ElseIf cbxuni1.Text = "Yarda" And cbxuni2.Text = "Kilometro" Then
            lblr.Text = num1 * 0.0009144
            lblu.Text = "km"
        ElseIf cbxuni1.Text = "Yarda" And cbxuni2.Text = "Nanometro" Then
            lblr.Text = num1 * 914400000.0
            lblu.Text = "nm"
        ElseIf cbxuni1.Text = "Yarda" And cbxuni2.Text = "Micrometro" Then
            lblr.Text = num1 * 914400
            lblu.Text = "µm"
        ElseIf cbxuni1.Text = "Pie" And cbxuni2.Text = "Metro" Then
            lblr.Text = num1 * 0.3048
            lblu.Text = "m"
        ElseIf cbxuni1.Text = "Pie" And cbxuni2.Text = "Centimetro" Then
            lblr.Text = num1 * 3048
            lblu.Text = "cm"
        ElseIf cbxuni1.Text = "Pie" And cbxuni2.Text = "Milimetro" Then
            lblr.Text = num1 * 304.8
            lblu.Text = "mm"
        ElseIf cbxuni1.Text = "Pie" And cbxuni2.Text = "Milla" Then
            lblr.Text = num1 * 0.000189394
            lblu.Text = "mi"
        ElseIf cbxuni1.Text = "Pie" And cbxuni2.Text = "Yarda" Then
            lblr.Text = num1 / 3
            lblu.Text = "yd"
        ElseIf cbxuni1.Text = "Pie" And cbxuni2.Text = "Pie" Then
            lblr.Text = num1
            lblu.Text = "ft"
        ElseIf cbxuni1.Text = "Pie" And cbxuni2.Text = "Pulgada" Then
            lblr.Text = num1 * 12
            lblu.Text = "in"
        ElseIf cbxuni1.Text = "Pie" And cbxuni2.Text = "Kilometro" Then
            lblr.Text = num1 * 0.0003048
            lblu.Text = "km"
        ElseIf cbxuni1.Text = "Pie" And cbxuni2.Text = "Nanometro" Then
            lblr.Text = num1 * 304800000.0
            lblu.Text = "nm"
        ElseIf cbxuni1.Text = "Pie" And cbxuni2.Text = "Micrometro" Then
            lblr.Text = num1 * 304800
            lblu.Text = "µm"
        ElseIf cbxuni1.Text = "Pulgada" And cbxuni2.Text = "Metro" Then
            lblr.Text = num1 * 0.0254
            lblu.Text = "m"
        ElseIf cbxuni1.Text = "Pulgada" And cbxuni2.Text = "Centimetro" Then
            lblr.Text = num1 * 2.54
            lblu.Text = "cm"
        ElseIf cbxuni1.Text = "Pulgada" And cbxuni2.Text = "Miliimetro" Then
            lblr.Text = num1 * 25.4
            lblu.Text = "mm"
        ElseIf cbxuni1.Text = "Pulgada" And cbxuni2.Text = "Milla" Then
            lblr.Text = num1 * 0.000015783
            lblu.Text = "mi"
        ElseIf cbxuni1.Text = "Pulgada" And cbxuni2.Text = "Yarda" Then
            lblr.Text = num1 * 0.0277778
            lblu.Text = "yd"
        ElseIf cbxuni1.Text = "Pulgada" And cbxuni2.Text = "Pie" Then
            lblr.Text = num1 * 0.0833333
            lblu.Text = "ft"
        ElseIf cbxuni1.Text = "Pulgada" And cbxuni2.Text = "Pulgada" Then
            lblr.Text = num1
            lblu.Text = "in"
        ElseIf cbxuni1.Text = "Pulgada" And cbxuni2.Text = "Kilometro" Then
            lblr.Text = num1 * 0.0000254
            lblu.Text = "km"
        ElseIf cbxuni1.Text = "Pulgada" And cbxuni2.Text = "Nanometro" Then
            lblr.Text = num1 * 25400000.0
            lblu.Text = "nm"
        ElseIf cbxuni1.Text = "Pulgada" And cbxuni2.Text = "Micrometro" Then
            lblr.Text = num1 * 25400
            lblu.Text = "µm"
        ElseIf cbxuni1.Text = "Kilometro" And cbxuni2.Text = "Metro" Then
            lblr.Text = num1 * 1000
            lblu.Text = "m"
        ElseIf cbxuni1.Text = "Kilometro" And cbxuni2.Text = "Centimetro" Then
            lblr.Text = num1 * 100000
            lblu.Text = "cm"
        ElseIf cbxuni1.Text = "Kilometro" And cbxuni2.Text = "Milimetro" Then
            lblr.Text = num1 * 1000000.0
            lblu.Text = "mm"
        ElseIf cbxuni1.Text = "Kilometro" And cbxuni2.Text = "Milla" Then
            lblr.Text = num1 * 0.621371
            lblu.Text = "mi"
        ElseIf cbxuni1.Text = "Kilometro" And cbxuni2.Text = "Yarda" Then
            lblr.Text = num1 * 1093.61
            lblu.Text = "yd"
        ElseIf cbxuni1.Text = "Kilometro" And cbxuni2.Text = "Pie" Then
            lblr.Text = num1 * 3280.84
            lblu.Text = "ft"
        ElseIf cbxuni1.Text = "Kilometro" And cbxuni2.Text = "Pulgada" Then
            lblr.Text = num1 * 39370.1
            lblu.Text = "in"
        ElseIf cbxuni1.Text = "Kilometro" And cbxuni2.Text = "Kilometro" Then
            lblr.Text = num1
            lblu.Text = "km"
        ElseIf cbxuni1.Text = "Kilometro" And cbxuni2.Text = "Nanometro" Then
            lblr.Text = num1 * 1000000000000.0
            lblu.Text = "nm"
        ElseIf cbxuni1.Text = "Kilometro" And cbxuni2.Text = "Micrometro" Then
            lblr.Text = num1 * 1000000000.0
            lblu.Text = "µm"
        ElseIf cbxuni1.Text = "Nanometro" And cbxuni2.Text = "Metro" Then
            lblr.Text = num1 * 0.000000001
            lblu.Text = "m"
        ElseIf cbxuni1.Text = "Nanometro" And cbxuni2.Text = "Centimetro" Then
            lblr.Text = num1 * 0.0000001
            lblu.Text = "cm"
        ElseIf cbxuni1.Text = "Nanometro" And cbxuni2.Text = "Milimetro" Then
            lblr.Text = num1 * 0.000001
            lblu.Text = "mm"
        ElseIf cbxuni1.Text = "Nanometro" And cbxuni2.Text = "Milla" Then
            lblr.Text = num1 * 0.00000000000062137
            lblu.Text = "mi"
        ElseIf cbxuni1.Text = "Nanometro" And cbxuni2.Text = "Yarda" Then
            lblr.Text = num1 * 0.0000000010936
            lblu.Text = "yd"
        ElseIf cbxuni1.Text = "Nanometro" And cbxuni2.Text = "Pie" Then
            lblr.Text = num1 * 0.0000000032808
            lblu.Text = "ft"
        ElseIf cbxuni1.Text = "Nanometro" And cbxuni2.Text = "Pulgada" Then
            lblr.Text = num1 * 0.00000003937
            lblu.Text = "in"
        ElseIf cbxuni1.Text = "Nanometro" And cbxuni2.Text = "Kilometro" Then
            lblr.Text = num1 * 0.000000000001
            lblu.Text = "km"
        ElseIf cbxuni1.Text = "Nanometro" And cbxuni2.Text = "Nanometro" Then
            lblr.Text = num1
            lblu.Text = "nm"
        ElseIf cbxuni1.Text = "Nanometro" And cbxuni2.Text = "Micrometro" Then
            lblr.Text = num1 * 0.001
            lblu.Text = "µm"
        ElseIf cbxuni1.Text = "Micrometro" And cbxuni2.Text = "Metro" Then
            lblr.Text = num1 * 0.000001
            lblu.Text = "m"
        ElseIf cbxuni1.Text = "Micrometro" And cbxuni2.Text = "Centimetro" Then
            lblr.Text = num1 * 0.0001
            lblu.Text = "cm"
        ElseIf cbxuni1.Text = "Micrometro" And cbxuni2.Text = "Milimetro" Then
            lblr.Text = num1 * 0.001
            lblu.Text = "mm"
        ElseIf cbxuni1.Text = "Micrometro" And cbxuni2.Text = "Milla" Then
            lblr.Text = num1 * 0.00000000062137
            lblu.Text = "mi"
        ElseIf cbxuni1.Text = "Micrometro" And cbxuni2.Text = "Yarda" Then
            lblr.Text = num1 * 0.0000010936
            lblu.Text = "yd"
        ElseIf cbxuni1.Text = "Micrometro" And cbxuni2.Text = "Pie" Then
            lblr.Text = num1 * 0.000016404
            lblu.Text = "ft"
        ElseIf cbxuni1.Text = "Micrometro" And cbxuni2.Text = "Pulgada" Then
            lblr.Text = num1 * 0.00003937
            lblu.Text = "in"
        ElseIf cbxuni1.Text = "Micrometro" And cbxuni2.Text = "Kilometro" Then
            lblr.Text = num1 * 0.000000001
            lblu.Text = "km"
        ElseIf cbxuni1.Text = "Micrometro" And cbxuni2.Text = "Nanometro" Then
            lblr.Text = num1 * 1000
            lblu.Text = "nm"
        ElseIf cbxuni1.Text = "Micrometro" And cbxuni2.Text = "Micrometro" Then
            lblr.Text = num1
            lblu.Text = "µm"

        ElseIf cbxtiem1.Text = "Hora" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 3600000000000.0
            lblu.Text = "Gs"
        ElseIf cbxtiem1.Text = "Hora" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 * 3600000000.0
            lblu.Text = "Ms"
        ElseIf cbxtiem1.Text = "Hora" And cbxuni2.Text = "Milisegundo" Then
            lblr.Text = num1 * 3600000.0
            lblu.Text = "ks"
        ElseIf cbxtiem1.Text = "Hora" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 * 3600
            lblu.Text = "s"
        ElseIf cbxtiem1.Text = "Hora" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 * 60
            lblu.Text = "min"
        ElseIf cbxtiem1.Text = "Hora" And cbxtiem2.Text = "Hora" Then
            lblr.Text = num1
            lblu.Text = "H"
        ElseIf cbxtiem1.Text = "Hora" And cbxtiem2.Text = "Dia" Then
            lblr.Text = num1 * 0.0416667
            lblu.Text = "dia"
        ElseIf cbxtiem1.Text = "Hora" And cbxtiem2.Text = "Semana" Then
            lblr.Text = num1 * 0.00595238
            lblu.Text = "semana"
        ElseIf cbxtiem1.Text = "Hora" And cbxtiem2.Text = "Decada" Then
            lblr.Text = num1 * 0.000011416
            lblu.Text = "decada"
        ElseIf cbxtiem1.Text = "Hora" And cbxtiem2.Text = "Año natural" Then
            lblr.Text = num1 * 0.000114155
            lblu.Text = "AN"
        ElseIf cbxtiem1.Text = "Dia" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 85400000000000.0
            lblu.Text = "Gs"
        ElseIf cbxtiem1.Text = "Dia" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 * 86400000000.0
            lblu.Text = "Ms"
        ElseIf cbxtiem1.Text = "Dia" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1 * 86400000.0
            lblu.Text = "ks"
        ElseIf cbxtiem1.Text = "Dia" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 * 86400
            lblu.Text = "s"
        ElseIf cbxtiem1.Text = "Dia" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 * 1440
            lblu.Text = "min"
        ElseIf cbxtiem1.Text = "Dia" And cbxtiem2.Text = "Hora" Then
            lblr.Text = num1 * 1440
            lblu.Text = "h"
        ElseIf cbxtiem1.Text = "Dia" And cbxtiem2.Text = "Dia" Then
            lblr.Text = num1
            lblu.Text = "dia"
        ElseIf cbxtiem1.Text = "Dia" And cbxtiem2.Text = "Semana" Then
            lblr.Text = num1 / 7
            lblu.Text = "semana"
        ElseIf cbxtiem1.Text = "Dia" And cbxtiem2.Text = "Decada" Then
            lblr.Text = num1 * 0.000273973
            lblu.Text = "decada"
        ElseIf cbxtiem1.Text = "Dia" And cbxtiem2.Text = "Año natural" Then
            lblr.Text = num1 / 365
            lblu.Text = "AN"
        ElseIf cbxtiem1.Text = "Semana" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 604800000000000.0
            lblu.Text = "Gs"
        ElseIf cbxtiem1.Text = "Semana" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 * 604800000000.0
            lblu.Text = "Ms"
        ElseIf cbxtiem1.Text = "Semana" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1 * 604800000.0
            lblu.Text = "ks"
        ElseIf cbxtiem1.Text = "Semana" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 * 604800
            lblu.Text = "S"
        ElseIf cbxtiem1.Text = "Semana" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 * 10080
            lblu.Text = "min"
        ElseIf cbxtiem1.Text = "Semana" And cbxtiem2.Text = "Dia" Then
            lblr.Text = num1 * 7
            lblu.Text = "Dia"
        ElseIf cbxtiem1.Text = "Semana" And cbxtiem2.Text = "Hora" Then
            lblr.Text = num1 * 168
            lblu.Text = "H"
        ElseIf cbxtiem1.Text = "Semana" And cbxtiem2.Text = "Semana" Then
            lblr.Text = num1
            lblu.Text = "semana"
        ElseIf cbxtiem1.Text = "Semana" And cbxtiem2.Text = "Decada" Then
            lblr.Text = num1 * 0.00191781
            lblu.Text = "decada"
        ElseIf cbxtiem1.Text = "Semana" And cbxtiem2.Text = "Año natural" Then
            lblr.Text = num1 * 0.0191781
            lblu.Text = "AN"
        ElseIf cbxtiem1.Text = "Decada" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 3.15E+17
            lblu.Text = "Gs"
        ElseIf cbxtiem1.Text = "Decada" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 * 315400000000000.0
            lblu.Text = "Ms"
        ElseIf cbxtiem1.Text = "Decada" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1 * 315400000000.0
            lblu.Text = "ks"
        ElseIf cbxtiem1.Text = "Decada" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 * 315400000.0
            lblu.Text = "S"
        ElseIf cbxtiem1.Text = "Decada" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 * 5256000.0
            lblu.Text = "min"
        ElseIf cbxtiem1.Text = "Decada" And cbxtiem2.Text = "Hora" Then
            lblr.Text = num1 * 87600
            lblu.Text = "H"
        ElseIf cbxtiem1.Text = "Decada" And cbxtiem2.Text = "Dia" Then
            lblr.Text = num1 * 3650
            lblu.Text = "dia"
        ElseIf cbxtiem1.Text = "Decada" And cbxtiem2.Text = "Semana" Then
            lblr.Text = num1 * 521.429
            lblu.Text = "semana"
        ElseIf cbxtiem1.Text = "Decada" And cbxtiem2.Text = "Decada " Then
            lblr.Text = num1
            lblu.Text = "decasa"
        ElseIf cbxtiem1.Text = "Decada" And cbxtiem2.Text = "Año natural" Then
            lblr.Text = num1 * 10
            lblu.Text = "AN"
        ElseIf cbxtiem1.Text = "Año natural" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 3.154E+16
            lblu.Text = "Gs"
        ElseIf cbxtiem1.Text = "Año natural" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 * 31540000000000.0
            lblu.Text = "Ms"
        ElseIf cbxtiem1.Text = "Año natural" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1 * 31540000000.0
            lblu.Text = "ks"
        ElseIf cbxtiem1.Text = "Año natural" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 * 31540000.0
            lblu.Text = "S"
        ElseIf cbxtiem1.Text = "Año natural" And cbxuni2.Text = "Minuto" Then
            lblr.Text = num1 * 525600
            lblu.Text = "min"
        ElseIf cbxtiem1.Text = "Año natural" And cbxtiem2.Text = "Hora" Then
            lblr.Text = num1 * 8760
            lblu.Text = "H"
        ElseIf cbxtiem1.Text = "Año natural" And cbxtiem2.Text = "Dia" Then
            lblr.Text = num1 * 365
            lblu.Text = "dia"
        ElseIf cbxtiem1.Text = "Año natural" And cbxtiem2.Text = "Semana" Then
            lblr.Text = num1 * 52.1429
            lblu.Text = "semana"
        ElseIf cbxtiem1.Text = "Año natural" And cbxtiem2.Text = "Decada" Then
            lblr.Text = num1 * 0.1
            lblu.Text = "decada"
        ElseIf cbxtiem1.Text = "Año natural" And cbxtiem2.Text = "Año natural" Then
            lblr.Text = num1
            lblu.Text = "AN"
        End If

    End Sub


End Class