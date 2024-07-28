Imports System.Runtime.InteropServices

Public Class FormMain

    Private FormAbierto As Windows.Forms.Form

    Private Sub abrirForm(formNiño As Windows.Forms.Form)

        If FormAbierto IsNot Nothing Then

            FormAbierto.Hide()
        End If

        FormAbierto = formNiño
        formNiño.MdiParent = Me
        formNiño.Top = False
        formNiño.FormBorderStyle = FormBorderStyle.None
        formNiño.Dock = DockStyle.Fill
        Me.ToolStripContainer1.ContentPanel.Controls.Add(formNiño)
        formNiño.Show()
    End Sub


    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub Sendmessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelBarratitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarratitulo.MouseMove
        ReleaseCapture()
        Sendmessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    'Funcionalidad de los botones cerrar, minimizar maximizar etc()










    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Text = ActiveUser.Nombre + " " + ActiveUser.Apellidos
        Label2.Text = ActiveUser.email
        Label3.Text = ActiveUser.position

        If ActiveUser.position <> "Administrador" Then
            Ibtn_Administrar.Visible = False

        Else
            Ibtn_Administrar.Visible = True
        End If
        abrirForm(New FormRegisAsistecia)

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If MessageBox.Show("Estás seguro de que deseas cerrar la aplicación?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles Ibtn_Editar.Click
        Dim frmeditususario As New FormEditUser

        frmeditususario.Show()
        Me.Close()


    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles Ibtn_cerrar.Click
        If MessageBox.Show("Estas seguro de que deseas salir de la sesión", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
            ActiveUser.idUser = ""
            ActiveUser.Nombre = ""
            ActiveUser.Apellidos = ""
            ActiveUser.position = ""
            ActiveUser.email = ""
            Dim frm1 As New FormInicio
            frm1.Show()
        End If
    End Sub

    Private Sub Ibtn_Insertar_Click(sender As Object, e As EventArgs) Handles Ibtn_Insertar.Click
        abrirForm(New FormRegisAsistecia)
    End Sub

    Private Sub Ibtn_Actualizar_Click(sender As Object, e As EventArgs) Handles Ibtn_Actualizar.Click
        abrirForm(New FormActAsistencia)
    End Sub

    Private Sub Ibtn_Eliminar_Click(sender As Object, e As EventArgs) Handles Ibtn_Eliminar.Click
        abrirForm(New FormElimAsistencia)
    End Sub

    Private Sub Ibtn_Consultar_Click(sender As Object, e As EventArgs) Handles Ibtn_Consultar.Click
        abrirForm(New FormConsulAsistencia)

    End Sub

    Private Sub Ibtn_Administrar_Click(sender As Object, e As EventArgs) Handles Ibtn_Administrar.Click
        abrirForm(New FormAdmin)
    End Sub
End Class