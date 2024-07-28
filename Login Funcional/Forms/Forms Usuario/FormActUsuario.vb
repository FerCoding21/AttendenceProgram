Imports System.Runtime.InteropServices
Public Class FormActUsuario
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

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim FormUsuarios As New FormUsuarios
        FormUsuarios.Show()
        Me.Close()
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
                If rango1 = "Profesor" Then
                    CmbRango.SelectedIndex = 1
                ElseIf rango1 = "Administrador" Then
                    CmbRango.SelectedIndex = 0
                End If
            Else

                MsgBox("LLene los campos correctamente", vbOKOnly + vbExclamation, "Advertencia")

                txtUser.Text = ""
                txtPassw.Text = ""
                txtNombre.Text = ""
                txtApellidos.Text = ""
                CmbRango.SelectedIndex = -1
                txtEmail.Text = ""

            End If

        End If



    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If txtUser.Text <> "" And txtPassw.Text <> "" And txtNombre.Text <> "" And txtApellidos.Text <> "" And CmbRango.SelectedIndex <> -1 And txtEmail.Text <> "" Then
            conexion()

            actUser(txtUser.Text.ToString, txtPassw.Text.ToString, txtNombre.Text.ToString, txtApellidos.Text.ToString, CmbRango.SelectedItem, txtEmail.Text.ToString)

            cadena.Close()

            txtUser.Text = ""
            txtPassw.Text = ""
            txtNombre.Text = ""
            txtApellidos.Text = ""
            CmbRango.SelectedIndex = -1
            txtEmail.Text = ""

        Else
            MsgBox("Llene los campos correctamente", vbOKOnly + vbExclamation, "Advertencia")
        End If


    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class