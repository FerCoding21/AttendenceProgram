Imports System.Runtime.InteropServices
Public Class FormInicio

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub Sendmessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub



    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If MessageBox.Show("Estas seguro de que deseas cerrar la aplicación?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user = TxtUser.Text
        Dim pass = TxtPass.Text
        conexion()
        Dim validaruser = Login(user, pass)

        If TxtPass.Text <> "" And TxtUser.Text <> "" Then
            If validaruser = True Then
                Dim frm As New FormMain
                frm.Show()
                Me.Hide()
            Else
                MsgBox("Usuario incorrecto o contraseña incorrecta", vbOKOnly + vbExclamation, "Intente de nuevo")
                TxtPass.Clear()
                TxtUser.Clear()

            End If
        Else
            MsgBox("Llene los campos antes de seguir", vbOKOnly + vbExclamation, "Atención")
        End If

        cadena.Close()

    End Sub

    Private Sub TitleBar_Paint(sender As Object, e As PaintEventArgs) Handles TitleBar.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked



    End Sub

    Private Sub LinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click


        Dim FormRecContraseña As New FormRecContraseña

        FormRecContraseña.Show()
        Me.Hide()

    End Sub

    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseMove
        ReleaseCapture()
        Sendmessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class
