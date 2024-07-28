﻿Imports System.Runtime.InteropServices
Public Class FormConsulProf
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


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then

            conexion()
            ConsultarProf(TextBox1.Text)
            TextBox2.Text = Primer_aprof2
            TextBox3.Text = Segundo_aprof2
            TextBox4.Text = Nombre2
            cadena.Close()
        Else
            MsgBox("LLene los campos correctamente", vbOKOnly + vbExclamation, "Advertencia")
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim FormProfesores As New FormProfesores
        FormProfesores.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FormDataGridProf As New FormDataGridProf
        FormDataGridProf.Show()
        Me.Close()

    End Sub
End Class