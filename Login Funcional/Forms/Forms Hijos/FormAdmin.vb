Public Class FormAdmin
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim FormUsuarios As New FormUsuarios
        FormUsuarios.Show()
        System.Windows.Forms.Application.OpenForms.Item("FormMain").Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FormEstudiantes As New FormEstudiantes
        FormEstudiantes.Show()
        System.Windows.Forms.Application.OpenForms.Item("FormMain").Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FormProfesores As New FormProfesores
        FormProfesores.Show()
        System.Windows.Forms.Application.OpenForms.Item("FormMain").Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim FormImportar As New Form1
        FormImportar.Show()
        System.Windows.Forms.Application.OpenForms.Item("FormMain").Close()
    End Sub
End Class