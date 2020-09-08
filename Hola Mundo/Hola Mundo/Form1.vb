Public Class Form1

    Dim objdirecciones = New direcciones()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboDepto.Items.AddRange(objdirecciones.depto)
    End Sub

    Private Sub cboDepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepto.SelectedIndexChanged
        cboMun.Items.Clear()
        cboMun.Text = ""
        cboMun.Items.AddRange(objdirecciones.mun(cboDepto.SelectedIndex))
    End Sub
End Class
Class direcciones
    Public depto() As String = {"Seleccione un depto.", "Usulutan", "San Miguel", "La Union", "San Salvador", "Morazan", "La Libertad", "Ahuachapán", "Cabañas", "Chalatenango", "Cuscatlán", "La Paz", "San Vicente", "Santa Ana", "Sonsonate"}
    Public mun()() As String = {
            New String() {"Seleccione un depto."},
            New String() {"Seleccione un municipio", "Usulutan", "Jiquilisco", "Santa Elena", "Ozatlán", "Santa Maria"},                       '0->Usulutan
            New String() {"Seleccione un municipio", "San Miguel", "El Transito", "Moncagua", "San Rafael Ote", "San Jorge"},                  '1->San Miguel
            New String() {"Seleccione un municipio", "La Union", "San Alejo", "Anamoros", "Pasauina", "Bolivar"},                              '2->La Unión
            New String() {"Seleccione un municipio", "Arambala", "Perquin", "Corinto", "Jocoro", "Cacaopera"},                                 '3->Morazán
            New String() {"Seleccione un municipio", "San Salvador", "San Marcos", "Soyapango", "Ilopoango", "Apopa"},                         '4->San Salvador
            New String() {"Seleccione un municipio", "Santa Tecla", "Ciudad Arce", "Quezaltepeque", "Colón"},                                  '5->La Libertad
            New String() {"Seleccione un municipio", "Ahuachapán", "Apaneca", "San Lorenzo", "Tacuba", "Turín"},                               '6->Ahuachapán
            New String() {"Seleccione un municipio", "Sensuntepeque", "Ilobasco", "San Isidro", "Tejutepeque", "Jutiapa"},                     '7->Cabañas
            New String() {"Seleccione un municipio", "Chalatenango", "Comalapa", "San Francisco Morazán", "San Rafael", "San Ingacio"},        '8->Chalatenango
            New String() {"Seleccione un municipio", "Cojutepeque", "San Cristóbal", "El Rosario", "San Ramón", "Suchitoto"},                  '9->Cuscatlán
            New String() {"Seleccione un municipio", "Zacatecoluca", "Olocuilta", "San Juan Nonualco", "San Luis Talpa", "Jerusalén"},         '10->La Paz
            New String() {"Seleccione un municipio", "San Vicente", "San Lorenzo", "San Sebastián", "Santa Clara", "Verapaz"},                 '11->San Vicente
            New String() {"Seleccione un municipio", "Santa Ana", "Chalchuapa", "Metapán", "El Congo", "Masahuat"},                            '12->Santa Ana
            New String() {"Seleccione un municipio", "Sonsonate", "Acajutla", "Izalco", "Nahuizalco", "San Julián"}                            '13->Sonsonate
    }
End Class