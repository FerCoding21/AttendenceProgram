
Module FuncionesProfesores

    Public Nombre2, Primer_aprof2, Segundo_aprof2 As String



    Public Sub regisProf(Cedula As String, PApellido As String, SApellido As String, Nombre As String)
        cmd.Connection = cadena
        cmd.CommandText = CommandType.Text
        cmd.CommandText = "insert into Profesores (Cedula_prof, Primer_aprof, Segundo_aprof, Nombre_prof) values (" & Cedula & ", '" & PApellido & "', '" & SApellido & "', '" & Nombre & "')"

        If MessageBox.Show("Estas seguro de que deseas registrar este profesor?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Datos añadidos correctamente", vbOKOnly + vbInformation, "Advertencia")

            Catch ex As Exception
                If ex.ToString.Contains("No se han especificado valores") Then

                    MsgBox("Debe insertar los datos correctamente cada campo", vbOKOnly + vbExclamation, "Advertencia")
                End If


                If ex.ToString.Contains("Invalid column") Then

                    MsgBox("El formato de cédula es incorrecto", vbOKOnly + vbExclamation, "Advertencia")
                End If


                If ex.ToString.Contains("PRIMARY KEY") Then

                    MsgBox("Esta cédula ya está registrada en el sistema", vbOKOnly + vbExclamation, "Advertencia")
                End If



            End Try

        End If
    End Sub

    Public Sub EliminarProf(Cedula As String)
        cmd.Connection = cadena
        cmd.CommandText = CommandType.Text
        cmd.CommandText = "delete from Profesores where Cedula_prof= " & Cedula & ""

        If MessageBox.Show("Estas seguro de que deseas eliminar este profesor?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Datos eliminados correctamente", vbOKOnly + vbInformation, "Advertencia")

            Catch ex As Exception
                MsgBox(ex.ToString)

                If ex.ToString.Contains("No se han especificado valores") Then

                    MsgBox("Debe insertar los datos correctamente cada campo", vbOKOnly + vbExclamation, "Advertencia")
                End If

            End Try
        End If
    End Sub

    Public Sub ActualizarProf(cedula As String, PApellido As String, SApellido As String, Nombre As String)
        cmd.Connection = cadena
        cmd.CommandText = CommandType.Text
        cmd.CommandText = "update Profesores set Primer_aprof='" & PApellido & "', Segundo_aprof='" & SApellido & "', Nombre_prof='" & Nombre & "' where Cedula_prof=" & cedula

        If MessageBox.Show("Estas seguro de que deseas actualizar este profesor?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            Try
                cmd.ExecuteNonQuery()
                If (cmd.ExecuteNonQuery() = 0) Then
                    MsgBox("No se ha podido actualizar correctamente ", vbOKOnly + vbInformation, "Advertencia")
                Else
                    MsgBox("Profesor actualizado correctamente", vbOKOnly + vbInformation, "Advertencia")

                End If

        Catch ex As Exception
                MsgBox(ex.ToString)

                If ex.ToString.Contains("No se han especificado valores") Then

                    MsgBox("Debe insertar los datos correctamente cada campo", vbOKOnly + vbExclamation, "Advertencia")
                End If

            End Try
        End If
    End Sub

    Public Sub ConsultarProf(Cedula As string)
        cmd.Connection = cadena
        cmd.CommandText = CommandType.Text
        cmd.CommandText = "select * from Profesores where Cedula_prof=" & Cedula & ""
        Nombre2 = ""
        Primer_aprof2 = ""
        Segundo_aprof2 = ""
        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Nombre2 = dr.GetString(3)
                    Primer_aprof2 = dr.GetString(1)
                    Segundo_aprof2 = dr.GetString(2)
                End While
            Else
                MsgBox("No se ha encontrado ningún profesor relacionado a esta cédula", vbOKOnly + vbExclamation, "Advertencia")
            End If

        Catch ex As Exception
            If ex.ToString.Contains("No se han especificado valores") Then

                MsgBox("Debe insertar los datos correctamente cada campo", vbOKOnly + vbExclamation, "Advertencia")
            End If

            If ex.ToString.Contains("Invalid column") Then

                MsgBox("El formato de cédula es incorrecto", vbOKOnly + vbExclamation, "Advertencia")
            End If

        End Try
    End Sub
    Public Sub llenagridProfesores()

        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strSql As String = "SELECT * FROM Profesores "
        Dim adp As New SqlClient.SqlDataAdapter(strSql, cadena)

        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))

        dataset = ds.Tables("tabla")
    End Sub

    Public Sub buscagridProf(filtroCedula As String, filtroPapellido As String, filtroSapellido As String, filtroNombre As String)

        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strSql As String = "select * from Profesores where Cedula_prof like '%" & filtroCedula & "%' and Primer_aprof like '%" & filtroPapellido & "%' and Nombre_Prof like '%" & filtroNombre & "%' and Segundo_aprof like '%" & filtroSapellido & "%'"
        Dim adp As New SqlClient.SqlDataAdapter(strSql, cadena)

        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))

        dataset = ds.Tables("tabla")

    End Sub
End Module
