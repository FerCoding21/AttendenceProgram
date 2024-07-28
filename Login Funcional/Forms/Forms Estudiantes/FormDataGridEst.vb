Imports System.Runtime.InteropServices
Public Class FormDataGridEst
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
        Dim FormConsulEst As New FormConsulEst
        FormConsulEst.Show()
        Me.Close()
    End Sub

    Private Sub TxtCedula_TextChanged(sender As Object, e As EventArgs) Handles TxtCedula.TextChanged
        buscagridEst(TxtCedula.Text, TxtPapellido.Text, TxtSapellido.Text, TxtNombre.Text, TxtEspecialidad.Text, TxtSeccion.Text)
        DataGridView1.DataSource = dataset
    End Sub

    Private Sub TxtEspecialidad_TextChanged(sender As Object, e As EventArgs) Handles TxtEspecialidad.TextChanged
        buscagridEst(TxtCedula.Text, TxtPapellido.Text, TxtSapellido.Text, TxtNombre.Text, TxtEspecialidad.Text, TxtSeccion.Text)
        DataGridView1.DataSource = dataset
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        buscagridEst(TxtCedula.Text, TxtPapellido.Text, TxtSapellido.Text, TxtNombre.Text, TxtEspecialidad.Text, TxtSeccion.Text)
        DataGridView1.DataSource = dataset
    End Sub

    Private Sub TxtPapellido_TextChanged(sender As Object, e As EventArgs) Handles TxtPapellido.TextChanged
        buscagridEst(TxtCedula.Text, TxtPapellido.Text, TxtSapellido.Text, TxtNombre.Text, TxtEspecialidad.Text, TxtSeccion.Text)
        DataGridView1.DataSource = dataset
    End Sub

    Private Sub TxtSapellido_TextChanged(sender As Object, e As EventArgs) Handles TxtSapellido.TextChanged
        buscagridEst(TxtCedula.Text, TxtPapellido.Text, TxtSapellido.Text, TxtNombre.Text, TxtEspecialidad.Text, TxtSeccion.Text)
        DataGridView1.DataSource = dataset
    End Sub

    Private Sub TxtSeccion_TextChanged(sender As Object, e As EventArgs) Handles TxtSeccion.TextChanged
        buscagridEst(TxtCedula.Text, TxtPapellido.Text, TxtSapellido.Text, TxtNombre.Text, TxtEspecialidad.Text, TxtSeccion.Text)
        DataGridView1.DataSource = dataset
    End Sub
End Class