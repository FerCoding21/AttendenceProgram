
Public Class FormEditUser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtApellidos.Text <> "" And txtEmail.Text <> "" And txtNombre.Text <> "" And txtPasswAct.Text <> "" And txtPasswdNew.Text <> "" And txtPasswdNewConf.Text <> "" Then


            If txtPasswAct.Text = ActiveUser.passw Then

                If txtPasswdNew.Text = txtPasswdNewConf.Text Then
                    conexion()
                    editusuario(txtNombre.Text, txtApellidos.Text, txtEmail.Text, txtPasswdNewConf.Text, txtPasswAct.Text)
                    cadena.Close()

                Else

                    MsgBox("Las contraseñas nuevas no coinciden", vbOKOnly + vbExclamation, "Atención")

                End If


            Else


                MsgBox("La contraseña no es correcta", vbOKOnly + vbExclamation, "Atención")


            End If

        Else

            MsgBox("Llene los campos antes de seguir", vbOKOnly + vbExclamation, "Atención")

        End If



    End Sub

    Private Sub TitleBar_Paint(sender As Object, e As PaintEventArgs) Handles TitleBar.Paint

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim FormMain As New FormMain
        FormMain.Show()

        Me.Close()

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
