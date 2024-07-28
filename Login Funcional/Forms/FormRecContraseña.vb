Imports System.Runtime.InteropServices

Public Class FormRecContraseña
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub Sendmessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelTop_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseMove
        ReleaseCapture()
        Sendmessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    Private Sub btnenviar_Click(sender As Object, e As EventArgs) Handles btnenviar.Click
        If txtemail.Text <> "" Then

            Dim letras As New Random
            Dim num As New Random
            Dim codigo As String = ""
            codigover = ""

            For n = 1 To 4
                codigo &= Chr(letras.Next(65, 90))
            Next


            For r = 1 To 4
                codigo &= num.Next(0, 9)
            Next

            codigover = codigo
            'MsgBox(codigo)

            conexion()
            Dim resultado = reestablecercontraseña(txtemail.Text)
            Labelresultado.Text = resultado
            cadena.Close()

            User = txtemail.Text

        Else
            MsgBox("Llene los campos antes de seguir", vbOKOnly + vbExclamation, "Atención")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then


            If codigover = TextBox1.Text Then
                Dim FrmRegis As New FormCambContraseña
                FrmRegis.Show()
                Me.Close()
            Else
                MsgBox("Código incorrecto", vbOKOnly + vbExclamation, "Atención")
            End If

        Else
            MsgBox("Llene los campos antes de seguir", vbOKOnly + vbExclamation, "Atención")
        End If
    End Sub

    Private Sub LabelEmail_Click(sender As Object, e As EventArgs) Handles LabelEmail.Click

    End Sub

    Private Sub PanelTop_Paint(sender As Object, e As PaintEventArgs) Handles PanelTop.Paint

    End Sub

    Private Sub FormRecContraseña_Load(sender As Object, e As EventArgs) Handles Me.Load
        codigover = ""
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
        Dim Form1 As New FormInicio
        Form1.Show()

    End Sub
End Class