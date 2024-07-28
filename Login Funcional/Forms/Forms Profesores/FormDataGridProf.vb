Imports System.Runtime.InteropServices
Public Class FormDataGridProf
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
        Dim FormConsulProf As New FormConsulProf
        FormConsulProf.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        buscagridProf(TextBox4.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text)
        DataGridView1.DataSource = dataset
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        buscagridProf(TextBox4.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text)
        DataGridView1.DataSource = dataset
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        buscagridProf(TextBox4.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text)
        DataGridView1.DataSource = dataset
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        buscagridProf(TextBox4.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text)
        DataGridView1.DataSource = dataset
    End Sub
End Class