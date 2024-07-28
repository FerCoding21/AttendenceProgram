Public Class FormElimAsistencia
    Private Sub txtIdAus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdAus.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtIdAus.Text <> "" Then
                conexion()
                consultarAsis(txtIdAus.Text.ToString)
                txtcedu.Text = cedestasis
                txtpriape.Text = primapestasis
                txtseguape.Text = segapestasis
                txtnom.Text = nomestasis
                txtseccion.Text = secestasis
                txtespe.Text = espestasis
                TextBox1.Text = cedprofasis
                TextBox2.Text = primapprofasis
                TextBox3.Text = segapprofasis
                TextBox4.Text = nomprofasis
                If observación = ("Ausencia") Then
                    CmbObservación.SelectedIndex = 0
                ElseIf observación = ("Tardía") Then
                    CmbObservación.SelectedIndex = 1
                Else
                    CmbObservación.SelectedIndex = -1
                End If
                txtMaterias.Text = materia
                DtpFecha.Text = fecha

                Select Case lecciones
                    Case ""
                        CmbLecciones.SelectedIndex = -1
                    Case "1"
                        CmbLecciones.SelectedIndex = 0
                    Case "2"
                        CmbLecciones.SelectedIndex = 1
                    Case "3"
                        CmbLecciones.SelectedIndex = 2
                    Case "4"
                        CmbLecciones.SelectedIndex = 3
                    Case "5"
                        CmbLecciones.SelectedIndex = 4
                    Case "6"
                        CmbLecciones.SelectedIndex = 5
                    Case "7"
                        CmbLecciones.SelectedIndex = 6
                    Case "8"
                        CmbLecciones.SelectedIndex = 7
                    Case "9"
                        CmbLecciones.SelectedIndex = 8
                    Case "10"
                        CmbLecciones.SelectedIndex = 9
                    Case "11"
                        CmbLecciones.SelectedIndex = 10
                    Case "12"
                        CmbLecciones.SelectedIndex = 11
                    Case "13"
                        CmbLecciones.SelectedIndex = 12
                    Case "14"
                        CmbLecciones.SelectedIndex = 13



                End Select
                cadena.Close()
            Else



                MsgBox("LLene los campos correctamente", vbOKOnly + vbExclamation, "Advertencia")
                txtcedu.Text = ""



                txtpriape.Text = ""



                txtseguape.Text = ""



                txtnom.Text = ""



                txtseccion.Text = ""



                txtespe.Text = ""
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                txtIdAus.Text = ""
                CmbLecciones.SelectedIndex = -1
                CmbObservación.SelectedIndex = -1
                txtMaterias.Text = ""
                DtpFecha.Value = DateTime.Today
            End If
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtIdAus.Text <> "" Then





            conexion()





            eliminarAsis(txtIdAus.Text.ToString)



            cadena.Close()



            txtcedu.Text = ""



            txtpriape.Text = ""



            txtseguape.Text = ""



            txtnom.Text = ""



            txtseccion.Text = ""



            txtespe.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            txtIdAus.Text = ""
            CmbLecciones.SelectedIndex = -1
            CmbObservación.SelectedIndex = -1
            txtMaterias.Text = ""
            DtpFecha.Value = DateTime.Today





        Else
            MsgBox("LLene los campos correctamente", vbOKOnly + vbExclamation, "Advertencia")
        End If
    End Sub
End Class