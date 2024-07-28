Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class Form1
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

    Dim Cadenaubicacion As String
    Dim Area As String
    Dim rango As String

    Private Function Cargar_hoja(ByVal cadena As String, ByVal area As String, ByVal rango As String, ByVal data As DataGridView)
        Try
            If System.IO.File.Exists(cadena) Then
                Dim objetodataset As System.Data.DataSet
                Dim objetodataadapter As System.Data.OleDb.OleDbDataAdapter
                Dim scs2010 As String = "provider=Microsoft.ACE.OLEDB.12.0; " & "data source=" & cadena & "; Excel 12.0; IMEX=1; HDR=YES;"
                Dim objetoconexion As System.Data.OleDb.OleDbConnection
                objetoconexion = New System.Data.OleDb.OleDbConnection(scs2010)
                Dim consulta As String = "select * from " & "[" & area & "$" & rango & "]"
                objetodataadapter = New System.Data.OleDb.OleDbDataAdapter(consulta, objetoconexion)
                objetodataset = New System.Data.DataSet
                objetodataadapter.Fill(objetodataset)
                objetoconexion.Close()
                With data
                    .DataSource = objetodataset
                    .DataMember = objetodataset.Tables(0).TableName
                End With


            Else

                MsgBox("No se ha encontrado el archivo" & Cadenaubicacion, vbOKOnly + vbExclamation, "Atención")
            End If
        Catch ex As Exception
            MsgBox("Error al importar listas verifique que sea el archivo y hoja correctos", vbOKOnly + vbExclamation, "Atención")
        End Try
    End Function




    Private Sub Guardar_Click_1(sender As Object, e As EventArgs) Handles Guardar.Click


        Select Case Cmb1.SelectedIndex
            Case -1
                MsgBox("Seleccione donde desea exportar", vbOKOnly + vbExclamation, "Advertencia")
            Case 0
                Dim agregar As SqlCommand = New SqlCommand("INSERT INTO Estudiantes (Cedula_est, Primer_apest, Segundo_apest, Nombre_est, Seccion_est, Especialidad_est) values (@Cedula_est, @Primer_apest, @Segundo_apest, @Nombre_est, @Seccion_est, @Especialidad_est)", cadena)

                Dim fila As DataGridViewRow = New DataGridViewRow()
                cadena.Open()
                If MessageBox.Show("Desea añadir los siguientes datos a la tabla estudiantes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then




                    Try
                        For i = 0 To DataGridView1.Rows.Count - 1
                            agregar.Parameters.Clear()

                            agregar.Parameters.AddWithValue("@Cedula_est", Convert.ToString(DataGridView1.Rows(i).Cells(0).Value))
                            agregar.Parameters.AddWithValue("@Primer_apest", Convert.ToString(DataGridView1.Rows(i).Cells(1).Value))
                            agregar.Parameters.AddWithValue("@Segundo_apest", Convert.ToString(DataGridView1.Rows(i).Cells(2).Value))
                            agregar.Parameters.AddWithValue("@Nombre_est", Convert.ToString(DataGridView1.Rows(i).Cells(3).Value))
                            agregar.Parameters.AddWithValue("@Seccion_est", Convert.ToString(DataGridView1.Rows(i).Cells(4).Value))
                            agregar.Parameters.AddWithValue("@Especialidad_est", Convert.ToString(DataGridView1.Rows(i).Cells(5).Value))

                            agregar.ExecuteNonQuery()

                        Next
                        MsgBox("Datos añadidos correctamente", vbOKOnly + vbExclamation, "Advertencia")


                    Catch ex As Exception



                        If ex.ToString.Contains("Violation") Then

                            MsgBox("Uno o más datos ya existen en la base de datos", vbOKOnly + vbExclamation, "Advertencia")
                        End If
                        If ex.ToString.Contains("value Null") Then

                            MsgBox("Los datos no coinciden con los de la tabla " & Cmb1.SelectedItem, vbOKOnly + vbExclamation, "Advertencia")
                        End If

                        If ex.ToString.Contains("intervalo") Then

                            MsgBox("Los datos no coinciden con los de la tabla " & Cmb1.SelectedItem, vbOKOnly + vbExclamation, "Advertencia")
                        End If
                    End Try


                End If
                cadena.Close()
            Case 1

                Dim agregar As SqlCommand = New SqlCommand("INSERT INTO Profesores (Cedula_prof, Primer_aprof, Segundo_aprof, Nombre_prof) values (@Cedula_prof, @Primer_aprof, @Segundo_aprof, @Nombre_prof)", cadena)

                Dim fila As DataGridViewRow = New DataGridViewRow()
                cadena.Open()
                If MessageBox.Show("Desea añadir los siguientes datos a la tabla Profesores?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then




                    Try
                        For i = 0 To DataGridView1.Rows.Count - 1
                            agregar.Parameters.Clear()

                            agregar.Parameters.AddWithValue("@Cedula_prof", Convert.ToString(DataGridView1.Rows(i).Cells(0).Value))
                            agregar.Parameters.AddWithValue("@Primer_aprof", Convert.ToString(DataGridView1.Rows(i).Cells(1).Value))
                            agregar.Parameters.AddWithValue("@Segundo_aprof", Convert.ToString(DataGridView1.Rows(i).Cells(2).Value))
                            agregar.Parameters.AddWithValue("@Nombre_prof", Convert.ToString(DataGridView1.Rows(i).Cells(3).Value))


                            agregar.ExecuteNonQuery()

                        Next
                        MsgBox("Datos añadidos correctamente", vbOKOnly + vbExclamation, "Advertencia")


                    Catch ex As Exception


                        If ex.ToString.Contains("Violation") Then

                            MsgBox("Uno o más datos ya existen en la base de datos", vbOKOnly + vbExclamation, "Advertencia")
                        End If
                        If ex.ToString.Contains("value Null") Then
                            MsgBox("Los datos no coinciden con los de la tabla " & Cmb1.SelectedItem, vbOKOnly + vbExclamation, "Advertencia")
                        End If


                        If ex.ToString.Contains("intervalo") Then

                            MsgBox("Los datos no coinciden con los de la tabla " & Cmb1.SelectedItem, vbOKOnly + vbExclamation, "Advertencia")
                        End If
                    End Try


                End If
                cadena.Close()


        End Select

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dir As String
        Dim fileopen As New OpenFileDialog
        fileopen.ShowDialog()
        dir = fileopen.FileName
        TextBox1.Text = dir
        Cadenaubicacion = dir
        TextBox2.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Area = TextBox2.Text
        rango = TextBox3.Text
        Cargar_hoja(Cadenaubicacion, Area, rango, DataGridView1)
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        If MessageBox.Show("Desea limpiar la tabla?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            DataGridView1.Columns.Clear()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""

        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

End Class
