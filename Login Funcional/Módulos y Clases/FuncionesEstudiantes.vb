
Module FuncionesEstudiantes

    Public sql As String = ""

    Public Primer_apest, Segundo_apest, Nombre_est, Seccion_est, Especialidad As String


    Public Sub RegisEst(cedula As String, primerape As String, segundoape As String, nombre As String, seccion As String, especialidad As String)
        cmd.CommandText = CommandType.Text
        cmd.Connection = cadena
        sql = " INSERT INTO Estudiantes (Cedula_est, Primer_apest, Segundo_apest, Nombre_est, Seccion_est, Especialidad_est) "
        sql += " Values (" & cedula & ",'" & primerape & "','" & segundoape & "','" & nombre & "','" & seccion & "','" & especialidad & "') "
        cmd.CommandText = sql
        If MessageBox.Show("Estas seguro de que deseas añadir este estudiante?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then


            Try
                cmd.ExecuteNonQuery()

                MsgBox("Usuario añadido correctamente", vbOKOnly + vbInformation, "Advertencia")

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


    Public Sub consultEst(cedula As String)
        cmd.CommandType = CommandType.Text
        cmd.Connection = cadena
        cmd.CommandText = "SELECT * FROM Estudiantes WHERE Cedula_est =" & cedula

        Primer_apest = ""
        Segundo_apest = ""
        Nombre_est = ""
        Seccion_est = ""
        Especialidad = ""

        Try
            dr = cmd.ExecuteReader()

            If dr.Read Then
                Primer_apest = dr.GetString(1)
                Segundo_apest = dr.GetString(2)
                Nombre_est = dr.GetString(3)
                Seccion_est = dr.GetString(4)
                Especialidad = dr.GetString(5)
                dr.Close()
            Else
                MsgBox("No se encontró el estudiante relacionado al número de cédula", vbOKOnly + vbInformation, "Advertencia")
            End If


        Catch ex As Exception

            If ex.ToString.Contains("Invalid column") Then

                MsgBox("El formato de cédula es incorrecto", vbOKOnly + vbExclamation, "Advertencia")
            End If

        End Try

    End Sub

    Public Sub eliminarEst(cedula As String)
        cmd.CommandType = CommandType.Text
        cmd.Connection = cadena
        sql = "DELETE FROM Estudiantes WHERE Cedula_est = " & cedula
        cmd.CommandText = sql


        If MessageBox.Show("Estas seguro de que deseas eliminar este estudiante?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then


            Try
                cmd.ExecuteNonQuery()
                MsgBox("Estudiante eliminado correctamente", vbOKOnly + vbInformation, "Advertencia")
            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

        End If

    End Sub

    Public Sub actualizarEst(cedula As String, primerape As String, segundoape As String, nombre As String, seccion As String, especialidad As String)
        cmd.CommandType = CommandType.Text
        cmd.Connection = cadena
        cmd.CommandText = "UPDATE Estudiantes set Primer_apest='" & primerape & "', Segundo_apest='" & segundoape & "', Nombre_est='" & nombre & "', Seccion_est='" & seccion & "', Especialidad_est='" & especialidad & "' Where Cedula_est='" & cedula & "'"
        If MessageBox.Show("Estas seguro de que deseas actualizar la información de este estudiante?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                cmd.ExecuteNonQuery()

                cmd.ExecuteNonQuery()
                If (cmd.ExecuteNonQuery() = 0) Then
                    MsgBox("No se ha podido actualizar correctamente ", vbOKOnly + vbInformation, "Advertencia")
                Else
                    MsgBox("Estudiante actualizado correctamente", vbOKOnly + vbInformation, "Advertencia")

                End If

            Catch ex As Exception

                If ex.ToString.Contains("Invalid column") Then

                    MsgBox("El formato de cédula es incorrecto", vbOKOnly + vbExclamation, "Advertencia")
                End If




            End Try
        End If

    End Sub


    Public Sub llenagridEst()

        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strSql As String = "SELECT * FROM Estudiantes "
        Dim adp As New SqlClient.SqlDataAdapter(strSql, cadena)

        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))

        dataset = ds.Tables("tabla")

    End Sub
    Public Sub buscagridEst(filtroCedula As String, filtroPapellido As String, filtroSapellido As String, filtroNombre As String, FiltroEspe As String, FiltroSeccion As String)

        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strSql As String = "select * from Estudiantes where Cedula_est like '%" & filtroCedula & "%' and Primer_apest like '%" & filtroPapellido & "%' and Segundo_apest like '%" & filtroSapellido & "%'and Nombre_est like '%" & filtroNombre & "%' and Seccion_est like '%" & FiltroSeccion & "%' and Especialidad_est like '%" & FiltroEspe & "%'"
        Dim adp As New SqlClient.SqlDataAdapter(strSql, cadena)

        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))

        dataset = ds.Tables("tabla")

    End Sub











End Module
