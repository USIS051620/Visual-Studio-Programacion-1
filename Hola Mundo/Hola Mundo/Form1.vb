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

            'Monedas
        ElseIf cbxmonedas.Text = "Dolar estadounidense" And cbxmonedas1.Text = "Euro" Then
            lblr.Text = num1 * 0.84
            lblu.Text = "EUR"
        ElseIf cbxmonedas.Text = "Dolar estadounidense" And cbxmonedas1.Text = "Yen" Then
            lblr.Text = num1 * 106.01
            lblu.Text = "JPY"
        ElseIf cbxmonedas.Text = "Dolar estadounidense" And cbxmonedas1.Text = "Lempira" Then
            lblr.Text = num1 * 24.77
            lblu.Text = "HNL"
        ElseIf cbxmonedas.Text = "Dolar estadounidense" And cbxmonedas1.Text = "Cordoba nicaraguense" Then
            lblr.Text = num1 * 34.55
            lblu.Text = "NIO"
        ElseIf cbxmonedas.Text = "Dolar estadounidense" And cbxmonedas1.Text = "Quetzal" Then
            lblr.Text = num1 * 7.7
            lblu.Text = "Q"
        ElseIf cbxmonedas.Text = "Dolar estadounidense" And cbxmonedas1.Text = "Balboa" Then
            lblr.Text = num1 * 1.0
            lblu.Text = "PAB"
        ElseIf cbxmonedas.Text = "Dolar estadounidense" And cbxmonedas1.Text = "Peso mexicano" Then
            lblr.Text = num1 * 22.12
            lblu.Text = "MXN"
        ElseIf cbxmonedas.Text = "Dolar estadounidense" And cbxmonedas1.Text = "Libra esterlina" Then
            lblr.Text = num1 * 0.76
            lblu.Text = "GBP"
        ElseIf cbxmonedas.Text = "Dolar estadounidense" And cbxmonedas1.Text = "Bolivar venezolano" Then
            lblr.Text = num1 * 283663.0
            lblu.Text = "VEF"
        ElseIf cbxmonedas.Text = "Euro" And cbxmonedas1.Text = "Dolar estadounidense" Then
            lblr.Text = num1 * 1.19
            lblu.Text = "USD"
        ElseIf cbxmonedas.Text = "Euro" And cbxmonedas1.Text = "Yen" Then
            lblr.Text = num1 * 125.82
            lblu.Text = "JPY"
        ElseIf cbxmonedas.Text = "Euro" And cbxmonedas1.Text = "Lempira" Then
            lblr.Text = num1 * 29.38
            lblu.Text = "HNL"
        ElseIf cbxmonedas.Text = "Euro" And cbxmonedas1.Text = "Cordoba nicaraguense" Then
            lblr.Text = num1 * 41.07
            lblu.Text = "NIO"
        ElseIf cbxmonedas.Text = "Euro" And cbxmonedas1.Text = "Quetzal" Then
            lblr.Text = num1 * 9.14
            lblu.Text = "Q"
        ElseIf cbxmonedas.Text = "Euro" And cbxmonedas1.Text = "Balboa" Then
            lblr.Text = num1 * 1.19
            lblu.Text = "PAB"
        ElseIf cbxmonedas.Text = "Euro" And cbxmonedas1.Text = "Peso mexicano" Then
            lblr.Text = num1 * 26.32
            lblu.Text = "MXN"
        ElseIf cbxmonedas.Text = "Euro" And cbxmonedas1.Text = "Libra esterlina" Then
            lblr.Text = num1 * 0.91
            lblu.Text = "GBP"
        ElseIf cbxmonedas.Text = "Euro" And cbxmonedas1.Text = "Bolivar venezolano" Then
            lblr.Text = num1 * 336700.89
            lblu.Text = "VEF"
        ElseIf cbxmonedas.Text = "Yen" And cbxmonedas1.Text = "Dolar estadounidense" Then
            lblr.Text = num1 * 0.0094
            lblu.Text = "USD"
        ElseIf cbxmonedas.Text = "Yen" And cbxmonedas1.Text = "Euro" Then
            lblr.Text = num1 * 0.0079
            lblu.Text = "EUR"
        ElseIf cbxmonedas.Text = "Yen" And cbxmonedas1.Text = "Lempira" Then
            lblr.Text = num1 * 0.23
            lblu.Text = "HNL"
        ElseIf cbxmonedas.Text = "Yen" And cbxmonedas1.Text = "Cordoba nicaraguense" Then
            lblr.Text = num1 * 0.33
            lblu.Text = "NIO"
        ElseIf cbxmonedas.Text = "Yen" And cbxmonedas1.Text = "Quetzal" Then
            lblr.Text = num1 * 0.073
            lblu.Text = "Q"
        ElseIf cbxmonedas.Text = "Yen" And cbxmonedas1.Text = "Balboa" Then
            lblr.Text = num1 * 0.0094
            lblu.Text = "PAB"
        ElseIf cbxmonedas.Text = "Yen" And cbxmonedas1.Text = "Peso mexicano" Then
            lblr.Text = num1 * 0.21
            lblu.Text = "MXN"
        ElseIf cbxmonedas.Text = "Yen" And cbxmonedas1.Text = "Libra esterlina" Then
            lblr.Text = num1 * 0.0072
            lblu.Text = "GBP"
        ElseIf cbxmonedas.Text = "Yen" And cbxmonedas1.Text = "Bolivar venezolano" Then
            lblr.Text = num1 * 2676.12
            lblu.Text = "VEF"
        ElseIf cbxmonedas.Text = "Lempira" And cbxmonedas1.Text = "Dolar estadounidense" Then
            lblr.Text = num1 * 0.04
            lblu.Text = "USD"
        ElseIf cbxmonedas.Text = "Lempira" And cbxmonedas1.Text = "Euro" Then
            lblr.Text = num1 * 0.034
            lblu.Text = "EURO"
        ElseIf cbxmonedas.Text = "Lempira" And cbxmonedas1.Text = "Yen" Then
            lblr.Text = num1 * 4.28
            lblu.Text = "JPY"
        ElseIf cbxmonedas.Text = "Lempira" And cbxmonedas1.Text = "Cordoba nicaraguense" Then
            lblr.Text = num1 * 1.4
            lblu.Text = "NIO"
        ElseIf cbxmonedas.Text = "Lempira" And cbxmonedas1.Text = "Quetzal" Then
            lblr.Text = num1 * 0.31
            lblu.Text = "Q"
        ElseIf cbxmonedas.Text = "Lempira" And cbxmonedas1.Text = "Balboa" Then
            lblr.Text = num1 * 0.04
            lblu.Text = "PAB"
        ElseIf cbxmonedas.Text = "Lempira" And cbxmonedas1.Text = "Peso mexicano" Then
            lblr.Text = num1 * 0.9
            lblu.Text = "MXN"
        ElseIf cbxmonedas.Text = "Lempira" And cbxmonedas1.Text = "Libra esterlina" Then
            lblr.Text = num1 * 0.031
            lblu.Text = "GBP"
        ElseIf cbxmonedas.Text = "Lempira" And cbxmonedas1.Text = "Bolivar venezolano" Then
            lblr.Text = num1 * 11458.79
            lblu.Text = "VEF"
        ElseIf cbxmonedas.Text = "Cordoba nicaraguense" And cbxmonedas1.Text = "Dolar estadounidense" Then
            lblr.Text = num1 * 0.029
            lblu.Text = "USD"
        ElseIf cbxmonedas.Text = "Cordoba nicaraguense" And cbxmonedas1.Text = "Euro" Then
            lblr.Text = num1 * 0.024
            lblu.Text = "EUR"
        ElseIf cbxmonedas.Text = "Cordoba nicaraguense" And cbxmonedas1.Text = "Yen" Then
            lblr.Text = num1 * 3.06
            lblu.Text = "JPY"
        ElseIf cbxmonedas.Text = "Cordoba nicaraguense" And cbxmonedas1.Text = "Lempira" Then
            lblr.Text = num1 * 0.72
            lblu.Text = "HNL"
        ElseIf cbxmonedas.Text = "Cordoba nicaraguense" And cbxmonedas1.Text = "Quetzal" Then
            lblr.Text = num1 * 0.22
            lblu.Text = "Q"
        ElseIf cbxmonedas.Text = "Cordoba nicaraguense" And cbxmonedas1.Text = "Balboa" Then
            lblr.Text = num1 * 0.029
            lblu.Text = "PAB"
        ElseIf cbxmonedas.Text = "Cordoba nicaraguense" And cbxmonedas1.Text = "Peso mexicano" Then
            lblr.Text = num1 * 0.64
            lblu.Text = "MXN"
        ElseIf cbxmonedas.Text = "Cordoba nicaraguense" And cbxmonedas1.Text = "Libra esterlina" Then
            lblr.Text = num1 * 0.022
            lblu.Text = "GBP"
        ElseIf cbxmonedas.Text = "Cordoba nicaraguense" And cbxmonedas1.Text = "Bolivar venezolano" Then
            lblr.Text = num1 * 8198.35
            lblu.Text = "VEF"
        ElseIf cbxmonedas.Text = "Quetzal" And cbxmonedas1.Text = "Dolar estadounidense" Then
            lblr.Text = num1 * 0.13
            lblu.Text = "USD"
        ElseIf cbxmonedas.Text = "Quetzal" And cbxmonedas1.Text = "Euro" Then
            lblr.Text = num1 * 0.11
            lblu.Text = "EUR"
        ElseIf cbxmonedas.Text = "Quetzal" And cbxmonedas1.Text = "Yen" Then
            lblr.Text = num1 * 13.77
            lblu.Text = "JPY"
        ElseIf cbxmonedas.Text = "Quetzal" And cbxmonedas1.Text = "Lempira" Then
            lblr.Text = num1 * 3.22
            lblu.Text = "HNL"
        ElseIf cbxmonedas.Text = "Quetzal" And cbxmonedas1.Text = "Cordoba nicaraguense" Then
            lblr.Text = num1 * 4.5
            lblu.Text = "NIO"
        ElseIf cbxmonedas.Text = "Quetzal" And cbxmonedas1.Text = "Balboa" Then
            lblr.Text = num1 * 0.13
            lblu.Text = "PAB"
        ElseIf cbxmonedas.Text = "Quetzal" And cbxmonedas1.Text = "Peso mexicano" Then
            lblr.Text = num1 * 2.88
            lblu.Text = "MXN"
        ElseIf cbxmonedas.Text = "Quetzal" And cbxmonedas1.Text = "Libra esterlina" Then
            lblr.Text = num1 * 0.099
            lblu.Text = "GBP"
        ElseIf cbxmonedas.Text = "Quetzal" And cbxmonedas1.Text = "Bolivar venezolano" Then
            lblr.Text = num1 * 36871.14
            lblu.Text = "VEF"
        ElseIf cbxmonedas.Text = "Balboa" And cbxmonedas1.Text = "Dolar estadounidense" Then
            lblr.Text = num1 * 1.0
            lblu.Text = "USD"
        ElseIf cbxmonedas.Text = "Balboa" And cbxmonedas1.Text = "Euro" Then
            lblr.Text = num1 * 0.84
            lblu.Text = "EUR"
        ElseIf cbxmonedas.Text = "Balboa" And cbxmonedas1.Text = "Yen" Then
            lblr.Text = num1 * 106.05
            lblu.Text = "JPY"
        ElseIf cbxmonedas.Text = "Balboa" And cbxmonedas1.Text = "Lempira" Then
            lblr.Text = num1 * 24.77
            lblu.Text = "HNL"
        ElseIf cbxmonedas.Text = "Balboa" And cbxmonedas1.Text = "Cordoba nicaraguense" Then
            lblr.Text = num1 * 34.61
            lblu.Text = "NIO"
        ElseIf cbxmonedas.Text = "Balboa" And cbxmonedas1.Text = "Quetzal" Then
            lblr.Text = num1 * 7.7
            lblu.Text = "Q"
        ElseIf cbxmonedas.Text = "Balboa" And cbxmonedas1.Text = "Peso mexicano" Then
            lblr.Text = num1 * 22.19
            lblu.Text = "MXN"
        ElseIf cbxmonedas.Text = "Balboa" And cbxmonedas1.Text = "Libra esterlina" Then
            lblr.Text = num1 * 0.76
            lblu.Text = "GBP"
        ElseIf cbxmonedas.Text = "Balboa" And cbxmonedas1.Text = "Bolivar venezolano" Then
            lblr.Text = num1 * 283777.32
            lblu.Text = "VEF"
        ElseIf cbxmonedas.Text = "Peso mexicano" And cbxmonedas1.Text = "Dolar estadounidense" Then
            lblr.Text = num1 * 0.045
            lblu.Text = "USD"
        ElseIf cbxmonedas.Text = "Peso mexicano" And cbxmonedas1.Text = "Euro" Then
            lblr.Text = num1 * 0.038
            lblu.Text = "EUR"
        ElseIf cbxmonedas.Text = "Peso mexicano" And cbxmonedas1.Text = "Yen" Then
            lblr.Text = num1 * 4.78
            lblu.Text = "JPY"
        ElseIf cbxmonedas.Text = "Peso mexicano" And cbxmonedas1.Text = "Lempira" Then
            lblr.Text = num1 * 1.12
            lblu.Text = "HNL"
        ElseIf cbxmonedas.Text = "Peso mexicano" And cbxmonedas1.Text = "Cordoba nicaraguense" Then
            lblr.Text = num1 * 1.56
            lblu.Text = "NIO"
        ElseIf cbxmonedas.Text = "Peso mexicano" And cbxmonedas1.Text = "Quetzal" Then
            lblr.Text = num1 * 0.35
            lblu.Text = "Q"
        ElseIf cbxmonedas.Text = "Peso mexicano" And cbxmonedas1.Text = "Balboa" Then
            lblr.Text = num1 * 0.045
            lblu.Text = "PAB"
        ElseIf cbxmonedas.Text = "Peso mexicano" And cbxmonedas1.Text = "Libra esterlina" Then
            lblr.Text = num1 * 0.034
            lblu.Text = "GBP"
        ElseIf cbxmonedas.Text = "Peso mexicano" And cbxmonedas1.Text = "Bolivar venezolano" Then
            lblr.Text = num1 * 12788.48
            lblu.Text = "VEF"
        ElseIf cbxmonedas.Text = "Libra esterlina" And cbxmonedas1.Text = "Dolar estadounidense" Then
            lblr.Text = num1 * 1.31
            lblu.Text = "USD"
        ElseIf cbxmonedas.Text = "Libra esterlina" And cbxmonedas1.Text = "Euro" Then
            lblr.Text = num1 * 1.1
            lblu.Text = "EUR"
        ElseIf cbxmonedas.Text = "Libra esterlina" And cbxmonedas1.Text = "Yen" Then
            lblr.Text = num1 * 138.93
            lblu.Text = "JPY"
        ElseIf cbxmonedas.Text = "Libra esterlina" And cbxmonedas1.Text = "Lempira" Then
            lblr.Text = num1 * 32.45
            lblu.Text = "HNL"
        ElseIf cbxmonedas.Text = "Libra esterlina" And cbxmonedas1.Text = "Cordoba nicaraguense" Then
            lblr.Text = num1 * 45.35
            lblu.Text = "NIO"
        ElseIf cbxmonedas.Text = "Libra esterlina" And cbxmonedas1.Text = "Quetzal" Then
            lblr.Text = num1 * 10.09
            lblu.Text = "Q"
        ElseIf cbxmonedas.Text = "Libra esterlina" And cbxmonedas1.Text = "Balboa" Then
            lblr.Text = num1 * 1.31
            lblu.Text = "PAB"
        ElseIf cbxmonedas.Text = "Libra esterlina" And cbxmonedas1.Text = "Peso mexicano" Then
            lblr.Text = num1 * 29.08
            lblu.Text = "MXN"
        ElseIf cbxmonedas.Text = "Libra esterlina" And cbxmonedas1.Text = "Bolivar venezolano" Then
            lblr.Text = num1 * 371797.38
            lblu.Text = "VEF"
        ElseIf cbxmonedas.Text = "Bolivar venezolano" And cbxmonedas1.Text = "Dolar estadounidense" Then
            lblr.Text = num1 * 0.0000035
            lblu.Text = "USD"
        ElseIf cbxmonedas.Text = "Bolivar venezolano" And cbxmonedas1.Text = "Euro" Then
            lblr.Text = num1 * 0.000003
            lblu.Text = "EUR"
        ElseIf cbxmonedas.Text = "Bolivar venezolano" And cbxmonedas1.Text = "Yen" Then
            lblr.Text = num1 * 0.00037
            lblu.Text = "JPY"
        ElseIf cbxmonedas.Text = "Bolivar venezolano" And cbxmonedas1.Text = "Lempira" Then
            lblr.Text = num1 * 0.000087
            lblu.Text = "HNL"
        ElseIf cbxmonedas.Text = "Bolivar venezolano" And cbxmonedas1.Text = "Cordoba nicaraguense" Then
            lblr.Text = num1 * 0.00012
            lblu.Text = "NIO"
        ElseIf cbxmonedas.Text = "Bolivar venezolano" And cbxmonedas1.Text = "Quetzal" Then
            lblr.Text = num1 * 0.000027
            lblu.Text = "Q"
        ElseIf cbxmonedas.Text = "Bolivar venezolano" And cbxmonedas1.Text = "Balboa" Then
            lblr.Text = num1 * 0.0000035
            lblu.Text = "PAB"
        ElseIf cbxmonedas.Text = "Bolivar venezolano" And cbxmonedas1.Text = "Peso mexicano" Then
            lblr.Text = num1 * 0.000078
            lblu.Text = "MXN"
        ElseIf cbxmonedas.Text = "Bolivar venezolano" And cbxmonedas1.Text = "Libra esterlina" Then
            lblr.Text = num1 * 0.0000027
            lblu.Text = "GBP"

            'Masa
        ElseIf cbxmasa.Text = "Kilogramos" And cbxmasa1.Text = "Hectogramos" Then
            lblr.Text = num1 * 10
            lblu.Text = "gh"
        ElseIf cbxmasa.Text = "Kilogramos" And cbxmasa1.Text = "Decagramos" Then
            lblr.Text = num1 * 100
            lblu.Text = "dag"
        ElseIf cbxmasa.Text = "Kilogramos" And cbxmasa1.Text = "Gramos" Then
            lblr.Text = num1 * 1000
            lblu.Text = "g"
        ElseIf cbxmasa.Text = "Kilogramos" And cbxmasa1.Text = "Decigramos" Then
            lblr.Text = num1 * 10000
            lblu.Text = "dg"
        ElseIf cbxmasa.Text = "Kilogramos" And cbxmasa1.Text = "Centigramos" Then
            lblr.Text = num1 * 100000
            lblu.Text = "cg"
        ElseIf cbxmasa.Text = "Kilogramos" And cbxmasa1.Text = "Miligramos" Then
            lblr.Text = num1 * 1000000.0
            lblu.Text = "mg"
        ElseIf cbxmasa.Text = "Kilogramos" And cbxmasa1.Text = "Libras" Then
            lblr.Text = num1 * 2.205
            lblu.Text = "lb"
        ElseIf cbxmasa.Text = "Kilogramos" And cbxmasa1.Text = "Onzas" Then
            lblr.Text = num1 * 35.274
            lblu.Text = "oz"
        ElseIf cbxmasa.Text = "Kilogramos" And cbxmasa1.Text = "Quilates" Then
            lblr.Text = num1 * 5000
            lblu.Text = "qte"
        ElseIf cbxmasa.Text = "Hectogramos" And cbxmasa1.Text = "Kilogramos" Then
            lblr.Text = num1 / 10
            lblu.Text = "kg"
        ElseIf cbxmasa.Text = "Hectogramos" And cbxmasa1.Text = "Decagramos" Then
            lblr.Text = num1 * 10
            lblu.Text = "dag"
        ElseIf cbxmasa.Text = "Hectogramos" And cbxmasa1.Text = "Gramos" Then
            lblr.Text = num1 * 100
            lblu.Text = "g"
        ElseIf cbxmasa.Text = "Hectogramos" And cbxmasa1.Text = "Decigramos" Then
            lblr.Text = num1 * 1000
            lblu.Text = "dg"
        ElseIf cbxmasa.Text = "Hectogramos" And cbxmasa1.Text = "Centigramos" Then
            lblr.Text = num1 * 10000
            lblu.Text = "cg"
        ElseIf cbxmasa.Text = "Hectogramos" And cbxmasa1.Text = "Miligramos" Then
            lblr.Text = num1 * 100000
            lblu.Text = "mg"
        ElseIf cbxmasa.Text = "Hectogramos" And cbxmasa1.Text = "Libras" Then
            lblr.Text = num1 / 4.536
            lblu.Text = "lb"
        ElseIf cbxmasa.Text = "Hectogramos" And cbxmasa1.Text = "Onzas" Then
            lblr.Text = num1 * 3.527
            lblu.Text = "oz"
        ElseIf cbxmasa.Text = "Hectogramos" And cbxmasa1.Text = "Quilates" Then
            lblr.Text = num1 * 500
            lblu.Text = "qte"
        ElseIf cbxmasa.Text = "Decagramos" And cbxmasa1.Text = "Kilogramos" Then
            lblr.Text = num1 / 100
            lblu.Text = "kg"
        ElseIf cbxmasa.Text = "Decagramos" And cbxmasa1.Text = "Hectogramos" Then
            lblr.Text = num1 / 10
            lblu.Text = "gh"
        ElseIf cbxmasa.Text = "Decagramos" And cbxmasa1.Text = "Gramos" Then
            lblr.Text = num1 * 10
            lblu.Text = "g"
        ElseIf cbxmasa.Text = "Decagramos" And cbxmasa1.Text = "Decigramos" Then
            lblr.Text = num1 * 100
            lblu.Text = "dg"
        ElseIf cbxmasa.Text = "Decagramos" And cbxmasa1.Text = "Centigramos" Then
            lblr.Text = num1 * 1000
            lblu.Text = "cg"
        ElseIf cbxmasa.Text = "Decagramos" And cbxmasa1.Text = "Miligramos" Then
            lblr.Text = num1 * 10000
            lblu.Text = "mg"
        ElseIf cbxmasa.Text = "Decagramos" And cbxmasa1.Text = "Libras" Then
            lblr.Text = num1 / 45.359
            lblu.Text = "lb"
        ElseIf cbxmasa.Text = "Decagramos" And cbxmasa1.Text = "Onzas" Then
            lblr.Text = num1 / 2.835
            lblu.Text = "oz"
        ElseIf cbxmasa.Text = "Decagramos" And cbxmasa1.Text = "Quilates" Then
            lblr.Text = num1 * 50
            lblu.Text = "qte"
        ElseIf cbxmasa.Text = "Gramos" And cbxmasa1.Text = "Kilogramos" Then
            lblr.Text = num1 * 1000
            lblu.Text = "kg"
        ElseIf cbxmasa.Text = "Gramos" And cbxmasa1.Text = "Hectogramos" Then
            lblr.Text = num1 / 100
            lblu.Text = "gh"
        ElseIf cbxmasa.Text = "Gramos" And cbxmasa1.Text = "Decagramos" Then
            lblr.Text = num1 / 10
            lblu.Text = "dag"
        ElseIf cbxmasa.Text = "Gramos" And cbxmasa1.Text = "Decigramos" Then
            lblr.Text = num1 * 10
            lblu.Text = "dg"
        ElseIf cbxmasa.Text = "Gramos" And cbxmasa1.Text = "Centigramos" Then
            lblr.Text = num1 * 100
            lblu.Text = "cg"
        ElseIf cbxmasa.Text = "Gramos" And cbxmasa1.Text = "Miligramos" Then
            lblr.Text = num1 * 1000
            lblu.Text = "mg"
        ElseIf cbxmasa.Text = "Gramos" And cbxmasa1.Text = "Libras" Then
            lblr.Text = num1 / 454
            lblu.Text = "lb"
        ElseIf cbxmasa.Text = "Gramos" And cbxmasa1.Text = "Onzas" Then
            lblr.Text = num1 / 28.35
            lblu.Text = "oz"
        ElseIf cbxmasa.Text = "Gramos" And cbxmasa1.Text = "Quilates" Then
            lblr.Text = num1 * 5
            lblu.Text = "qte"
        ElseIf cbxmasa.Text = "Decigramos" And cbxmasa1.Text = "Kilogramos" Then
            lblr.Text = num1 * 10000
            lblu.Text = "kg"
        ElseIf cbxmasa.Text = "Decigramos" And cbxmasa1.Text = "Hectogramos" Then
            lblr.Text = num1 / 1000
            lblu.Text = "gh"
        ElseIf cbxmasa.Text = "Decigramos" And cbxmasa1.Text = "Decagramos" Then
            lblr.Text = num1 / 100
            lblu.Text = "dag"
        ElseIf cbxmasa.Text = "Decigramos" And cbxmasa1.Text = "Gramos" Then
            lblr.Text = num1 / 10
            lblu.Text = "g"
        ElseIf cbxmasa.Text = "Decigramos" And cbxmasa1.Text = "Centigramos" Then
            lblr.Text = num1 * 10
            lblu.Text = "cg"
        ElseIf cbxmasa.Text = "Decigramos" And cbxmasa1.Text = "Miligramos" Then
            lblr.Text = num1 * 100
            lblu.Text = "mg"
        ElseIf cbxmasa.Text = "Decigramos" And cbxmasa1.Text = "Libras" Then
            lblr.Text = num1 / 4536
            lblu.Text = "lb"
        ElseIf cbxmasa.Text = "Decigramos" And cbxmasa1.Text = "Onzas" Then
            lblr.Text = num1 / 283
            lblu.Text = "oz"
        ElseIf cbxmasa.Text = "Decigramos" And cbxmasa1.Text = "Quilates" Then
            lblr.Text = num1 / 2
            lblu.Text = "qte"
        ElseIf cbxmasa.Text = "Centigramos" And cbxmasa1.Text = "Kilogramos" Then
            lblr.Text = num1 * 100000
            lblu.Text = "kg"
        ElseIf cbxmasa.Text = "Centigramos" And cbxmasa1.Text = "Hectogramos" Then
            lblr.Text = num1 / 10000
            lblu.Text = "gh"
        ElseIf cbxmasa.Text = "Centigramos" And cbxmasa1.Text = "Decagramos" Then
            lblr.Text = num1 / 1000
            lblu.Text = "dag"
        ElseIf cbxmasa.Text = "Centigramos" And cbxmasa1.Text = "Gramos" Then
            lblr.Text = num1 / 100
            lblu.Text = "g"
        ElseIf cbxmasa.Text = "Centigramos" And cbxmasa1.Text = "Decigramos" Then
            lblr.Text = num1 / 10
            lblu.Text = "dg"
        ElseIf cbxmasa.Text = "Centigramos" And cbxmasa1.Text = "Miligramos" Then
            lblr.Text = num1 * 10
            lblu.Text = "mg"
        ElseIf cbxmasa.Text = "Centimetro" And cbxmasa1.Text = "Libras" Then
            lblr.Text = num1 / 45359
            lblu.Text = "lb"
        ElseIf cbxmasa.Text = "Centimetro" And cbxmasa1.Text = "Onzas" Then
            lblr.Text = num1 / 2835
            lblu.Text = "oz"
        ElseIf cbxmasa.Text = "Centimetro" And cbxmasa1.Text = "Quilates" Then
            lblr.Text = num1 / 20
            lblu.Text = "qte"
        ElseIf cbxmasa.Text = "Miligramos" And cbxmasa1.Text = "Kilogramos" Then
            lblr.Text = num1 / 1000000.0
            lblu.Text = "kg"
        ElseIf cbxmasa.Text = "Miligramos" And cbxmasa1.Text = "Hectogramos" Then
            lblr.Text = num1 / 100000
            lblu.Text = "gh"
        ElseIf cbxmasa.Text = "Miligramos" And cbxmasa1.Text = "Decagramos" Then
            lblr.Text = num1 / 10000
            lblu.Text = "dag"
        ElseIf cbxmasa.Text = "Miligramos" And cbxmasa1.Text = "Gramos" Then
            lblr.Text = num1 / 1000
            lblu.Text = "g"
        ElseIf cbxmasa.Text = "Miligramos" And cbxmasa1.Text = "Decigramos" Then
            lblr.Text = num1 / 100
            lblu.Text = "dg"
        ElseIf cbxmasa.Text = "Miligramos" And cbxmasa1.Text = "Centigramos" Then
            lblr.Text = num1 / 10
            lblu.Text = "cg"
        ElseIf cbxmasa.Text = "Miligramos" And cbxmasa1.Text = "Libras" Then
            lblr.Text = num1 / 453592
            lblu.Text = "lb"
        ElseIf cbxmasa.Text = "Miligramos" And cbxmasa1.Text = "Onzas" Then
            lblr.Text = num1 / 28350
            lblu.Text = "oz"
        ElseIf cbxmasa.Text = "Miligramos" And cbxmasa1.Text = "Quilates" Then
            lblr.Text = num1 / 200
            lblu.Text = "qte"
        ElseIf cbxmasa.Text = "Libras" And cbxmasa1.Text = "Kilogramos" Then
            lblr.Text = num1 / 2.205
            lblu.Text = "kg"
        ElseIf cbxmasa.Text = "Libras" And cbxmasa1.Text = "Hectogramos" Then
            lblr.Text = num1 * 4.536
            lblu.Text = "gh"
        ElseIf cbxmasa.Text = "Libras" And cbxmasa1.Text = "Decagramos" Then
            lblr.Text = num1 * 45.359
            lblu.Text = "dag"
        ElseIf cbxmasa.Text = "Libras" And cbxmasa1.Text = "Gramos" Then
            lblr.Text = num1 / 454
            lblu.Text = "g"
        ElseIf cbxmasa.Text = "Libras" And cbxmasa1.Text = "Decigramos" Then
            lblr.Text = num1 * 4536
            lblu.Text = "dg"
        ElseIf cbxmasa.Text = "Libras" And cbxmasa1.Text = "Centigramos" Then
            lblr.Text = num1 * 45359
            lblu.Text = "cg"
        ElseIf cbxmasa.Text = "Libras" And cbxmasa1.Text = "Miligramos" Then
            lblr.Text = num1 * 453592
            lblu.Text = "mg"
        ElseIf cbxmasa.Text = "Libras" And cbxmasa1.Text = "Onzas" Then
            lblr.Text = num1 * 16
            lblu.Text = "oz"
        ElseIf cbxmasa.Text = "Libras" And cbxmasa1.Text = "Quilates" Then
            lblr.Text = num1 * 2268
            lblu.Text = "qte"
        ElseIf cbxmasa.Text = "Onzas" And cbxmasa1.Text = "Kilogramos" Then
            lblr.Text = num1 / 35.274
            lblu.Text = "kg"
        ElseIf cbxmasa.Text = "Onzas" And cbxmasa1.Text = "Hectogramos" Then
            lblr.Text = num1 / 3.527
            lblu.Text = "gh"
        ElseIf cbxmasa.Text = "Onzas" And cbxmasa1.Text = "Decagramos" Then
            lblr.Text = num1 * 2.835
            lblu.Text = "dag"
        ElseIf cbxmasa.Text = "Onzas" And cbxmasa1.Text = "Gramos" Then
            lblr.Text = num1 * 28.35
            lblu.Text = "g"
        ElseIf cbxmasa.Text = "Onzas" And cbxmasa1.Text = "Decigramos" Then
            lblr.Text = num1 * 283
            lblu.Text = "dg"
        ElseIf cbxmasa.Text = "Onzas" And cbxmasa1.Text = "Centigramos" Then
            lblr.Text = num1 * 2835
            lblu.Text = "cg"
        ElseIf cbxmasa.Text = "Onzas" And cbxmasa1.Text = "Miligramos" Then
            lblr.Text = num1 * 28350
            lblu.Text = "mg"
        ElseIf cbxmasa.Text = "Onzas" And cbxmasa1.Text = "Libras" Then
            lblr.Text = num1 / 16
            lblu.Text = "lb"
        ElseIf cbxmasa.Text = "Onzas" And cbxmasa1.Text = "Quilates" Then
            lblr.Text = num1 * 142
            lblu.Text = "qte"
        ElseIf cbxmasa.Text = "Quilates" And cbxmasa1.Text = "Kilogramos" Then
            lblr.Text = num1 / 5000
            lblu.Text = "kg"
        ElseIf cbxmasa.Text = "Quilates" And cbxmasa1.Text = "Hectogramos" Then
            lblr.Text = num1 / 500
            lblu.Text = "gh"
        ElseIf cbxmasa.Text = "Quilates" And cbxmasa1.Text = "Decagramos" Then
            lblr.Text = num1 / 50
            lblu.Text = "dag"
        ElseIf cbxmasa.Text = "Quilates" And cbxmasa1.Text = "Gramos" Then
            lblr.Text = num1 / 5
            lblu.Text = "g"
        ElseIf cbxmasa.Text = "Quilates" And cbxmasa1.Text = "Decigramos" Then
            lblr.Text = num1 * 2
            lblu.Text = "dg"
        ElseIf cbxmasa.Text = "Quilates" And cbxmasa1.Text = "Centigramos" Then
            lblr.Text = num1 * 20
            lblu.Text = "cg"
        ElseIf cbxmasa.Text = "Quilates" And cbxmasa1.Text = "Miligramos" Then
            lblr.Text = num1 * 200
            lblu.Text = "mg"
        ElseIf cbxmasa.Text = "Quilates" And cbxmasa1.Text = "Libras" Then
            lblr.Text = num1 / 2268
            lblu.Text = "lb"
        ElseIf cbxmasa.Text = "Quilates" And cbxmasa1.Text = "Onzas" Then
            lblr.Text = num1 / 142
            lblu.Text = "oz"


        End If

    End Sub

    Private Sub cbxvol1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxvol1.SelectedIndexChanged

    End Sub
End Class