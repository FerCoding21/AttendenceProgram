Imports System.Runtime.InteropServices
Public Class FormCambContraseña

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub Sendmessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelBarratitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseMove
        ReleaseCapture()
        Sendmessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TitleBar_Paint(sender As Object, e As PaintEventArgs) Handles TitleBar.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox10.Text <> "" And TextBox9.Text <> "" Then
            If TextBox9.Text <> TextBox10.Text Then
                MsgBox("Las contraseñas no coinciden", vbOKOnly + vbExclamation, "Atención")
            Else
                conexion()
                ActContrseña(TextBox10.Text)
                cadena.Close()
                Me.Close()
                Dim frm1 As New FormInicio
                frm1.Show()

            End If

        Else

            MsgBox("Llene los campos antes de seguir", vbOKOnly + vbExclamation, "Atención")

        End If

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
        Dim ForRecCon As New FormRecContraseña
        ForRecCon.Show()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
