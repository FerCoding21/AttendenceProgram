Public Class FormConsulAsistencia
    Private Sub txtcedu_TextChanged(sender As Object, e As EventArgs) Handles txtcedu.TextChanged
        buscagridAsis(txtcedu.Text.ToString, txtpriape.Text.ToString, txtseguape.Text.ToString, txtnom.Text.ToString, txtseccion.Text.ToString, txtespe.Text.ToString, TextBox1.Text.ToString, TextBox2.Text.ToString, TextBox3.Text.ToString, TextBox4.Text.ToString, txtFecha.Text.ToString, txtMaterias.Text.ToString)
        DataGridView1.DataSource = dataset
    End Sub

    Private Sub txtespe_TextChanged(sender As Object, e As EventArgs) Handles txtespe.TextChanged
        buscagridAsis(txtcedu.Text.ToString, txtpriape.Text.ToString, txtseguape.Text.ToString, txtnom.Text.ToString, txtseccion.Text.ToString, txtespe.Text.ToString, TextBox1.Text.ToString, TextBox2.Text.ToString, TextBox3.Text.ToString, TextBox4.Text.ToString, txtFecha.Text.ToString, txtMaterias.Text.ToString)
        DataGridView1.DataSource = dataset
    End Sub

    Private Sub txtFecha_TextChanged(sender As Object, e As EventArgs) Handles txtFecha.TextChanged
        buscagridAsis(txtcedu.Text.ToString, txtpriape.Text.ToString, txtseguape.Text.ToString, txtnom.Text.ToString, txtseccion.Text.ToString, txtespe.Text.ToString, TextBox1.Text.ToString, TextBox2.Text.ToString, TextBox3.Text.ToString, TextBox4.Text.ToString, txtFecha.Text.ToString, txtMaterias.Text.ToString)
        DataGridView1.DataSource = dataset
    End Sub

    Private Sub txtMaterias_TextChanged(sender As Object, e As EventArgs) Handles txtMaterias.TextChanged
        buscagridAsis(txtcedu.Text.ToString, txtpriape.Text.ToString, txtseguape.Text.ToString, txtnom.Text.ToString, txtseccion.Text.ToString, txtespe.Text.ToString, TextBox1.Text.ToString, TextBox2.Text.ToString, TextBox3.Text.ToString, TextBox4.Text.ToString, txtFecha.Text.ToString, txtMaterias.Text.ToString)
        DataGridView1.DataSource = dataset
    End Sub

    Private Sub txtnom_TextChanged(sender As Object, e As EventArgs) Handles txtnom.TextChanged
        buscagridAsis(txtcedu.Text.ToString, txtpriape.Text.ToString, txtseguape.Text.ToString, txtnom.Text.ToString, txtseccion.Text.ToString, txtespe.Text.ToString, TextBox1.Text.ToString, TextBox2.Text.ToString, TextBox3.Text.ToString, TextBox4.Text.ToString, txtFecha.Text.ToString, txtMaterias.Text.ToString)
        DataGridView1.DataSource = dataset
    End Sub

    Private Sub txtpriape_TextChanged(sender As Object, e As EventArgs) Handles txtpriape.TextChanged
        buscagridAsis(txtcedu.Text.ToString, txtpriape.Text.ToString, txtseguape.Text.ToString, txtnom.Text.ToString, txtseccion.Text.ToString, txtespe.Text.ToString, TextBox1.Text.ToString, TextBox2.Text.ToString, TextBox3.Text.ToString, TextBox4.Text.ToString, txtFecha.Text.ToString, txtMaterias.Text.ToString)
        DataGridView1.DataSource = dataset
    End Sub

    Private Sub txtseccion_TextChanged(sender As Object, e As EventArgs) Handles txtseccion.TextChanged
        buscagridAsis(txtcedu.Text.ToString, txtpriape.Text.ToString, txtseguape.Text.ToString, txtnom.Text.ToString, txtseccion.Text.ToString, txtespe.Text.ToString, TextBox1.Text.ToString, TextBox2.Text.ToString, TextBox3.Text.ToString, TextBox4.Text.ToString, txtFecha.Text.ToString, txtMaterias.Text.ToString)
        DataGridView1.DataSource = dataset
    End Sub

    Private Sub txtseguape_TextChanged(sender As Object, e As EventArgs) Handles txtseguape.TextChanged
        buscagridAsis(txtcedu.Text.ToString, txtpriape.Text.ToString, txtseguape.Text.ToString, txtnom.Text.ToString, txtseccion.Text.ToString, txtespe.Text.ToString, TextBox1.Text.ToString, TextBox2.Text.ToString, TextBox3.Text.ToString, TextBox4.Text.ToString, txtFecha.Text.ToString, txtMaterias.Text.ToString)
        DataGridView1.DataSource = dataset
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        buscagridAsis(txtcedu.Text.ToString, txtpriape.Text.ToString, txtseguape.Text.ToString, txtnom.Text.ToString, txtseccion.Text.ToString, txtespe.Text.ToString, TextBox1.Text.ToString, TextBox2.Text.ToString, TextBox3.Text.ToString, TextBox4.Text.ToString, txtFecha.Text.ToString, txtMaterias.Text.ToString)
        DataGridView1.DataSource = dataset
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        buscagridAsis(txtcedu.Text.ToString, txtpriape.Text.ToString, txtseguape.Text.ToString, txtnom.Text.ToString, txtseccion.Text.ToString, txtespe.Text.ToString, TextBox1.Text.ToString, TextBox2.Text.ToString, TextBox3.Text.ToString, TextBox4.Text.ToString, txtFecha.Text.ToString, txtMaterias.Text.ToString)
        DataGridView1.DataSource = dataset
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        buscagridAsis(txtcedu.Text.ToString, txtpriape.Text.ToString, txtseguape.Text.ToString, txtnom.Text.ToString, txtseccion.Text.ToString, txtespe.Text.ToString, TextBox1.Text.ToString, TextBox2.Text.ToString, TextBox3.Text.ToString, TextBox4.Text.ToString, txtFecha.Text.ToString, txtMaterias.Text.ToString)
        DataGridView1.DataSource = dataset
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        buscagridAsis(txtcedu.Text.ToString, txtpriape.Text.ToString, txtseguape.Text.ToString, txtnom.Text.ToString, txtseccion.Text.ToString, txtespe.Text.ToString, TextBox1.Text.ToString, TextBox2.Text.ToString, TextBox3.Text.ToString, TextBox4.Text.ToString, txtFecha.Text.ToString, txtMaterias.Text.ToString)
        DataGridView1.DataSource = dataset
    End Sub

    Private Sub FormConsulAsistencia_Load(sender As Object, e As EventArgs) Handles Me.Load


        buscagridAsis(txtcedu.Text.ToString, txtpriape.Text.ToString, txtseguape.Text.ToString, txtnom.Text.ToString, txtseccion.Text.ToString, txtespe.Text.ToString, TextBox1.Text.ToString, TextBox2.Text.ToString, TextBox3.Text.ToString, TextBox4.Text.ToString, txtFecha.Text.ToString, txtMaterias.Text.ToString)
        DataGridView1.DataSource = dataset

        If ActiveUser.position <> "Administrador" Then
            Button1.Visible = False
            DataGridView1.Width = 643
            DataGridView1.Height = 269

        Else
            Button1.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ds As New DataSet1
        Dim dt As New DataTable

        dt = ds.Tables("DataTable1")

        For i = 0 To DataGridView1.Rows.Count - 1

            dt.Rows.Add(DataGridView1.Rows(i).Cells(1).Value, DataGridView1.Rows(i).Cells(2).Value, DataGridView1.Rows(i).Cells(3).Value, DataGridView1.Rows(i).Cells(4).Value, DataGridView1.Rows(i).Cells(5).Value,
                DataGridView1.Rows(i).Cells(6).Value,
                DataGridView1.Rows(i).Cells(7).Value,
                DataGridView1.Rows(i).Cells(8).Value,
                DataGridView1.Rows(i).Cells(9).Value,
                DataGridView1.Rows(i).Cells(10).Value,
                DataGridView1.Rows(i).Cells(11).Value,
                DataGridView1.Rows(i).Cells(12).Value,
                DataGridView1.Rows(i).Cells(13).Value,
                DataGridView1.Rows(i).Cells(14).Value)

        Next

        With FormReporteAsis.ReportViewer1.LocalReport

            .ReportPath = "ReporteAsistencia.rdlc"
            .DataSources.Clear()
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("myDataSet1", dt))
        End With
        FormReporteAsis.ShowDialog()
        FormReporteAsis.ReportViewer1.Refresh()
    End Sub
End Class