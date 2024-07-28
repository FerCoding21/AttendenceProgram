Module FuncionesAsistencia
    Public cedestasis, primapestasis, segapestasis, nomestasis, secestasis, espestasis, cedprofasis, primapprofasis, segapprofasis, nomprofasis, observación, fecha, lecciones, materia As String

    Public Sub registrarAsis(Cedula_est As String, Primer_apest As String, Segundo_apest As String, Nombre_est As String, Seccion_est As String, Especialidad_est As String, Cedula_prof As String, Primer_aprof As String, Segundo_aprof As String, Nombre_prof As String, Observaciones As String, Fecha As String, Lecciones As String, Materia As String)
        cmd.CommandType = CommandType.Text
        cmd.Connection = cadena
        cmd.CommandText = "Insert into Asistencia (Cedula_est, Primer_apest, Segundo_apest, Nombre_est, Seccion_est, Especialidad_est, Cedula_prof, Primer_aprof, Segundo_aprof, Nombre_prof, Observacion, Fecha, Lecciones, Materia) values( " & Cedula_est & " ,'" & Primer_apest & "', '" & Segundo_apest & "', '" & Nombre_est & "', '" & Seccion_est & "', '" & Especialidad_est & "', " & Cedula_prof & " , '" & Primer_aprof & "', '" & Segundo_aprof & "', '" & Nombre_prof & "', '" & Observaciones & "', '" & Fecha & "', '" & Lecciones & "', '" & Materia & "')"

        If MessageBox.Show("Estas seguro de que deseas registrar esta ausencia?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                If (cmd.ExecuteNonQuery() = 0) Then
                    MsgBox("No se ha podido registrar correctamente ", vbOKOnly + vbInformation, "Advertencia")
                Else
                    MsgBox("Ausencia registrada correctamente", vbOKOnly + vbInformation, "Advertencia")

                End If

            Catch ex As Exception
                MsgBox(ex.ToString)

                If ex.ToString.Contains("Invalid column") Then

                    MsgBox("El formato de id es incorrecto", vbOKOnly + vbExclamation, "Advertencia")
                End If




            End Try
        End If
    End Sub

    Public Sub actualizarAsis(idAsis As String, Cedula_est As String, Primer_apest As String, Segundo_apest As String, Nombre_est As String, Seccion_est As String, Especialidad_est As String, Cedula_prof As String, Primer_aprof As String, Segundo_aprof As String, Nombre_prof As String, Observaciones As String, Fecha As String, Lecciones As String, Materia As String)
        cmd.CommandType = CommandType.Text
        cmd.Connection = cadena
        cmd.CommandText = "UPDATE Asistencia set Cedula_est='" & Cedula_est & "', Primer_apest='" & Primer_apest & "', Segundo_apest='" & Segundo_apest & "', Nombre_est='" & Nombre_est & "', Seccion_est='" & Seccion_est & "', Especialidad_est='" & Especialidad_est & "', Cedula_prof='" & Cedula_prof & "', Primer_aprof='" & Primer_aprof & "', Segundo_aprof='" & Segundo_aprof & "', Nombre_prof='" & Nombre_prof & "', Observacion='" & Observaciones & "', Fecha='" & Fecha & "', Lecciones='" & Lecciones & "', Materia='" & Materia & "' Where ID_Asistencia=" & idAsis

        If MessageBox.Show("Estas seguro de que deseas actualizar la información de este registro?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                If (cmd.ExecuteNonQuery() = 0) Then
                    MsgBox("No se ha podido actualizar correctamente ", vbOKOnly + vbInformation, "Advertencia")
                Else
                    MsgBox("Registro de asistencia actualizado correctamente", vbOKOnly + vbInformation, "Advertencia")

                End If

            Catch ex As Exception


                If ex.ToString.Contains("Invalid column") Then

                    MsgBox("El formato de id es incorrecto", vbOKOnly + vbExclamation, "Advertencia")
                End If




            End Try
        End If

    End Sub

    Public Sub consultarAsis(idAsis As String)
        cmd.CommandType = CommandType.Text
        cmd.Connection = cadena
        cmd.CommandText = "Select * from Asistencia where Id_Asistencia=" & idAsis
        cedestasis = ""
        primapestasis = ""
        segapestasis = ""
        nomestasis = ""
        secestasis = ""
        espestasis = ""
        cedprofasis = ""
        primapprofasis = ""
        segapprofasis = ""
        nomprofasis = ""
        observación = ""
        fecha = DateTime.Today
        lecciones = ""
        materia = ""
        Try
            dr = cmd.ExecuteReader()

            If dr.Read Then

                cedestasis = dr.GetInt32(1)
                primapestasis = dr.GetString(2)
                segapestasis = dr.GetString(3)
                nomestasis = dr.GetString(4)
                secestasis = dr.GetString(5)
                espestasis = dr.GetString(6)
                cedprofasis = dr.GetInt32(7)
                primapprofasis = dr.GetString(8)
                segapprofasis = dr.GetString(9)
                nomprofasis = dr.GetString(10)
                observación = dr.GetString(11)
                fecha = dr.GetString(12)
                lecciones = dr.GetString(13)
                materia = dr.GetString(14)
                dr.Close()

            Else
                MsgBox("No se encontró el registro relacionado al número de id", vbOKOnly + vbInformation, "Advertencia")
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
            If ex.ToString.Contains("Invalid column") Then

                MsgBox("El formato de id es incorrecto", vbOKOnly + vbExclamation, "Advertencia")
            End If

        End Try
    End Sub
    Public Sub eliminarAsis(idAsis As String)
        cmd.CommandType = CommandType.Text
        cmd.Connection = cadena
        sql = "DELETE FROM asistencia WHERE id_asistencia = " & idAsis
        cmd.CommandText = sql




        If MessageBox.Show("Estas seguro de que deseas eliminar este registro?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then




            Try
                cmd.ExecuteNonQuery()
                MsgBox("registro eliminado correctamente", vbOKOnly + vbInformation, "Advertencia")
            Catch ex As Exception



                MsgBox(ex.ToString)



            End Try



        End If



    End Sub
    Public Sub buscagridAsis(Cedula_est As String, Primer_apest As String, Segundo_apest As String, Nombre_est As String, Seccion_est As String, Especialidad_est As String, Cedula_prof As String, Primer_aprof As String, Segundo_aprof As String, Nombre_prof As String, Fecha As String, Materia As String)

        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strSql As String = "select * from Asistencia where Cedula_est like '%" & Cedula_est & "%' and Primer_apest like '%" & Primer_apest & "%' and Segundo_apest like '%" & Segundo_apest & "%'and Nombre_est like '%" & Nombre_est & "%' and Seccion_est like '%" & Seccion_est & "%' and Especialidad_est like '%" & Especialidad_est & "%' and Cedula_prof like '%" & Cedula_prof & "%' and Primer_aprof like '%" & Primer_aprof & "%' and Nombre_Prof like '%" & Nombre_prof & "%' and Segundo_aprof like '%" & Segundo_aprof & "%' and Fecha like '%" & Fecha & "%' and Materia like '%" & Materia & "%'"
        Dim adp As New SqlClient.SqlDataAdapter(strSql, cadena)

        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))

        dataset = ds.Tables("tabla")

    End Sub

End Module
