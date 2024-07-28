Public Class FormRegisAsistecia
    Private Sub txtcedu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcedu.KeyPress
        If Asc(e.KeyChar) = 13 Then

            If txtcedu.Text <> "" Then
                conexion()

                consultEst(txtcedu.Text.ToString)

                txtpriape.Text = Primer_apest
                txtseguape.Text = Segundo_apest
                txtnom.Text = Nombre_est
                txtseccion.Text = Seccion_est
                txtespe.Text = Especialidad

                cadena.Close()
            Else

                MsgBox("LLene los campos correctamente", vbOKOnly + vbExclamation, "Advertencia")

                txtcedu.Text = ""

                txtpriape.Text = ""

                txtseguape.Text = ""

                txtnom.Text = ""

                txtseccion.Text = ""

                txtespe.Text = ""

            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If TextBox1.Text <> "" Then
                conexion()
                ConsultarProf(TextBox1.Text.ToString)
                TextBox2.Text = Primer_aprof2
                TextBox3.Text = Segundo_aprof2
                TextBox4.Text = Nombre2
                cadena.Close()
            Else

                MsgBox("LLene los campos correctamente", vbOKOnly + vbExclamation, "Advertencia")

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtcedu.Text <> "" And txtpriape.Text <> "" And txtseguape.Text <> "" And txtnom.Text <> "" And txtseccion.Text <> "" And txtespe.Text <> "" And TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And CmbLecciones.SelectedIndex <> -1 And CmbObservación.SelectedIndex <> -1 And txtMaterias.Text <> "" Then

            conexion()

            registrarAsis(txtcedu.Text.ToString, txtpriape.Text.ToString, txtseguape.Text.ToString, txtnom.Text.ToString, txtseccion.Text.ToString, txtespe.Text.ToString, TextBox1.Text.ToString, TextBox2.Text.ToString, TextBox3.Text.ToString, TextBox4.Text.ToString, CmbObservación.SelectedItem, DtpFecha.Text.ToString, CmbLecciones.SelectedItem.ToString, txtMaterias.Text.ToString)

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

            CmbLecciones.SelectedIndex = -1
            CmbObservación.SelectedIndex = -1
            txtMaterias.Text = ""
            DtpFecha.Value = DateTime.Today


        Else
            MsgBox("Llene los campos correctamente", vbOKOnly + vbExclamation, "Advertencia")
        End If

    End Sub

End Class