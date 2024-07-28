Imports System.Runtime.InteropServices
Public Class FormElimUsuario


    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub Sendmessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseMove
        ReleaseCapture()
        Sendmessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress



        If Asc(e.KeyChar) = 13 Then
            If txtUser.Text <> "" Then
                conexion()
                consulUser(txtUser.Text.ToString)
                cadena.Close()

                txtPassw.Text = Password1
                txtApellidos.Text = Apellidos1
                txtEmail.Text = email1
                txtNombre.Text = Nombre1
                TextBox1.Text = rango1
            Else

                MsgBox("LLene los campos correctamente", vbOKOnly + vbExclamation, "Advertencia")
                txtUser.Text = ""
                txtPassw.Text = ""
                txtNombre.Text = ""
                txtApellidos.Text = ""
                TextBox1.Text = ""
                txtEmail.Text = ""

            End If

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtUser.Text <> "" Then
            conexion()

            elimUser(txtUser.Text)

            cadena.Close()

            txtUser.Text = ""
            txtPassw.Text = ""
            txtNombre.Text = ""
            txtApellidos.Text = ""
            TextBox1.Text = ""
            txtEmail.Text = ""

        Else
            MsgBox("Llene los campos correctamente", vbOKOnly + vbExclamation, "Advertencia")
        End If

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim FormUsuarios As New FormUsuarios
        FormUsuarios.Show()
        Me.Close()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class