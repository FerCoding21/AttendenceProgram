Imports System.Data.SqlClient
Imports System.Data.Sql

Module FuncionesGenerales

    'Capa de conexion'
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public cadena As New SqlConnection("Data Source=PC_YASSIR;Initial Catalog=Mycompany;Integrated Security=True")
    Public codigover As String = ""
    Public Sub conexion()

        Try

            cadena.Open()


        Catch ex As Exception

            MsgBox(ex.ToString)
        End Try

        'Creo la funcion conexion para cuando quiera conectarme a la base de datos desde cualquier parte de mi programa simplemente llame a la funcion y se abra la conexion el catch va a mostrarme el error en caso de que la conexion haya fallado


    End Sub



    'Capa de negociacion'
    Public Function Login(user As String, pass As String) As Boolean


        cmd.Connection = cadena
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * From Users where LoginName= '" & user & "' COLLATE SQL_Latin1_General_CP1_CS_AS and Password='" & pass & "' COLLATE SQL_Latin1_General_CP1_CS_AS"


        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    ActiveUser.idUser = dr.GetInt32(0)
                    ActiveUser.User = dr.GetString(1)
                    ActiveUser.passw = dr.GetString(2)
                    ActiveUser.Nombre = dr.GetString(3)
                    ActiveUser.Apellidos = dr.GetString(4)
                    ActiveUser.position = dr.GetString(5)
                    ActiveUser.email = dr.GetString(6)



                End While

                Return True

            Else
                Return False

            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function

    Public Function reestablecercontraseña(usuariosolicitante As String) As String

        cmd.Connection = cadena
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * From Users where LoginName= '" & usuariosolicitante & "' or Correo='" & usuariosolicitante & "'"

        Try
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                Dim NomUsuario = dr.GetString(3) & " " & dr.GetString(4)
                Dim CorrUsuario = dr.GetString(6)
                Dim PassUsuario = dr.GetString(2)

                Dim CorreoSoporte As New CorreoSoporte
                CorreoSoporte.enviarMail(asunto:="SISTEMA: Recuperación de Contraseña", cuerpo:="Hola, " & NomUsuario & vbNewLine & "Has solicitado recuperar tu contraseña." & vbNewLine & "Su código de recuperación es " & codigover & vbNewLine & "Una vez entre al sistema de nuevo realice un cambio de contraseña ", receptor:=New List(Of String) From {CorrUsuario})
                Return "Hola " & NomUsuario & " solicitaste un cambio de contraseña " & vbNewLine & "Por favor revise su correo electrónico " & CorrUsuario

            Else
                Return "Lo sentimos, no se encontró ningúna cuenta registrada con ese nombre de usuario o correo"
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function

    Public Sub ActContrseña(password As String)
        cmd.Connection = cadena
        cmd.CommandText = CommandType.Text
        cmd.CommandText = "UPDATE Users SET Password= '" & password & "' WHERE LoginName= '" & User & "'"
        'MsgBox(cmd.CommandText.ToString)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Contraseña actualizada correctamente", vbOKOnly + vbInformation, "Advertencia")

        Catch ex As Exception
            MsgBox("Ingrese el nombre de usuario para poder realizar el cambio de contraseña", vbOKOnly + vbInformation, "Advertencia")
            MsgBox(ex.ToString)
        End Try


    End Sub

    Public Sub editusuario(nombre As String, apellidos As String, email As String, passwnew As String, passwact As String)
        cmd.Connection = cadena
        cmd.CommandText = CommandType.Text
        cmd.CommandText = "UPDATE Users SET Password= '" & passwnew & "', Nombre= '" & nombre & "', Apellidos= '" & apellidos & "', Correo= '" & email & "' WHERE LoginName= '" & ActiveUser.User & "' and Password= '" & passwact & "'"
        'MsgBox(cmd.CommandText.ToString)

        Try
            cmd.ExecuteNonQuery()


            MsgBox("Usuario actualizado correctamente", vbOKOnly + vbInformation, "Advertencia")

        Catch ex As Exception

            If ex.ToString.Contains("Violation") Then

                MsgBox("Este nombre de usuario ya existe", vbOKOnly + vbExclamation, "Advertencia")

            End If
        End Try


    End Sub
    Public Sub actualizaractiveuser(user As String, pass As String)


        cmd.Connection = cadena
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * From Users where LoginName= '" & user & "' and Password='" & pass & "'"
        MsgBox(cmd.CommandText.ToString)

        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    ActiveUser.idUser = dr.GetInt32(0)
                    ActiveUser.User = dr.GetString(1)
                    ActiveUser.Nombre = dr.GetString(3)
                    ActiveUser.Apellidos = dr.GetString(4)
                    ActiveUser.position = dr.GetString(5)
                    ActiveUser.email = dr.GetString(6)


                    Dim FormMain As New FormMain
                    FormMain.Label1.Text = ActiveUser.Nombre + " " + ActiveUser.Apellidos
                    FormMain.Text = ActiveUser.email
                    FormMain.Label3.Text = ActiveUser.position



                End While



            Else


            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    'Capa de presentacion'

End Module
