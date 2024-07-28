Imports System.Runtime.InteropServices
Public Class FormRegisEst
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

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim FormEstudiantes As New FormEstudiantes
        FormEstudiantes.Show()
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtcedu.Text = "" Or txtpriape.Text = "" Or txtseguape.Text = "" Or txtnom.Text = "" Or txtseccion.Text = "" Or txtespe.Text = "" Then
            MsgBox("Llene los campos correctamente", vbOKOnly + vbExclamation, "Advertencia")

        Else
            conexion()

            RegisEst(txtcedu.Text.ToString, txtpriape.Text.ToString, txtseguape.Text.ToString, txtnom.Text.ToString, txtseccion.Text.ToString, txtespe.Text.ToString)


            txtcedu.Text = ""

            txtpriape.Text = ""

            txtseguape.Text = ""

            txtnom.Text = ""

            txtseccion.Text = ""

            txtespe.Text = ""

            cadena.Close()

        End If
    End Sub
End Class