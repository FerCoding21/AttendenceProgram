Module FuncionesUsuarios

    Public Password1
    Public Nombre1
    Public Apellidos1
    Public rango1
    Public email1
    Public Userid1
    Public dataset


    Public Sub regisUser(user As String, passwd As String, nombre As String, apellidos As String, rango As String, correo As String)

        cmd.Connection = cadena
        cmd.CommandText = CommandType.Text
        cmd.CommandText = "Insert into Users (LoginName, Password, Nombre, Apellidos, Rango, Correo) values ('" & user & "', '" & passwd & "', '" & nombre & "', '" & apellidos & "', '" & rango & "','" & correo & "')"
        'MsgBox(cmd.CommandText)

        If MessageBox.Show("Estas seguro de que deseas añadir este usuario?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then


            Try
                cmd.ExecuteNonQuery()
                MsgBox("Usuario añadido correctamente", vbOKOnly + vbInformation, "Advertencia")
            Catch ex As Exception

                If ex.ToString.Contains("Violation") Then

                    MsgBox("Este nombre de usuario ya existe", vbOKOnly + vbExclamation, "Advertencia")

                End If

            End Try

        End If



    End Sub

    Public Sub elimUser(user As String)

        cmd.Connection = cadena
        cmd.CommandText = CommandType.Text
        cmd.CommandText = "Delete from Users where LoginName='" & user & "'"
        'MsgBox(cmd.CommandText)

        If MessageBox.Show("Estas seguro de que deseas eliminar este usuario?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then


            Try
                cmd.ExecuteNonQuery()
                MsgBox("Usuario eliminado correctamente", vbOKOnly + vbInformation, "Advertencia")
            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

        End If



    End Sub

    Public Sub actUser(user As String, passwd As String, nombre As String, apellidos As String, rango As String, correo As String)

        cmd.Connection = cadena
        cmd.CommandText = CommandType.Text
        cmd.CommandText = "Update Users set LoginName='" & user & "', Password ='" & passwd & "', Nombre='" & nombre & "', Apellidos ='" & apellidos & "', Rango='" & rango & "', Correo='" & correo & "' where UserID='" & Userid1 & "'"
        'MsgBox(cmd.CommandText)

        If MessageBox.Show("Estas seguro de que deseas cambiar la información de este usuario?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then


            Try
                cmd.ExecuteNonQuery()
                If (cmd.ExecuteNonQuery() = 0) Then
                    MsgBox("No se ha podido actualizar correctamente ", vbOKOnly + vbInformation, "Advertencia")
                Else
                    MsgBox("Usuario actualizado correctamente", vbOKOnly + vbInformation, "Advertencia")

                End If
            Catch ex As Exception

                If ex.ToString.Contains("Violation") Then

                    MsgBox("Este nombre de usuario ya existe", vbOKOnly + vbExclamation, "Advertencia")

                End If

            End Try

        End If



    End Sub


    Public Sub consulUser(user As String)

        cmd.Connection = cadena
        cmd.CommandText = CommandType.Text
        cmd.CommandText = "select * from Users where LoginName='" & user & "'"
        'MsgBox(cmd.CommandText)
        Userid1 = ""
        Password1 = ""
        Nombre1 = ""
        Apellidos1 = ""
        rango1 = ""
        email1 = ""
        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Userid1 = dr.GetInt32(0)
                    Password1 = dr.GetString(2)
                    Nombre1 = dr.GetString(3)
                    Apellidos1 = dr.GetString(4)
                    rango1 = dr.GetString(5)
                    email1 = dr.GetString(6)

                End While



            Else

                MsgBox("Lo sentimos, no se encontró ningúna cuenta registrada con ese nombre de usuario", vbOKOnly + vbExclamation, "Advertencia")
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



    End Sub

    Public Sub llenagridUsuario()

        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strSql As String = "SELECT * FROM USERS "
        Dim adp As New SqlClient.SqlDataAdapter(strSql, cadena)

        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))

        dataset = ds.Tables("tabla")

    End Sub

    Public Sub buscagridUsuario(filtroUser As String, filtroNombre As String, filtroApellidos As String, filtroCorreo As String)

        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strSql As String = "select LoginName, Nombre, Apellidos, Correo from Users where LoginName like '%" & filtroUser & "%' and Nombre like '%" & filtroNombre & "%' and Apellidos like '%" & filtroApellidos & "%'and Correo like '%" & filtroCorreo & "%'"
        Dim adp As New SqlClient.SqlDataAdapter(strSql, cadena)

        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))

        dataset = ds.Tables("tabla")

    End Sub


End Module
