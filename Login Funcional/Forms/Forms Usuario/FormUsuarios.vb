﻿Imports System.Runtime.InteropServices
Public Class FormUsuarios


    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub Sendmessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub


    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim FormMain As New FormMain
        FormMain.Show()
        Me.Close()

    End Sub

    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseMove
        ReleaseCapture()
        Sendmessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FormsRegisUsuario As New FormRegisUsuario


        FormsRegisUsuario.Show()
        Me.Close()


    End Sub

    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim FormELimUsuario As New FormElimUsuario
        FormELimUsuario.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim FormActUsuario As New FormActUsuario
        FormActUsuario.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FormconsulUsuario As New FormConsulUsuario
        FormconsulUsuario.Show()
        Me.Close()
    End Sub
End Class