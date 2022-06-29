Public Class Form2
    Dim jenis As String
    Dim nilai As String
    Dim sqlnya As String

    Sub panggildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM data_siswa", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "data_siswa")
        DataGridView1.DataSource = DS.Tables("data_siswa")
        DataGridView1.Enabled = True
    End Sub

    Sub jalan()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = sqlnya
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call panggildata()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If CheckBox1.Checked = True Then
            nilai += 1
        End If
        If CheckBox10.Checked = True Then
            nilai += 1
        End If
        If CheckBox4.Checked = True Then
            nilai += 1
        End If
        If CheckBox6.Checked = True Then
            nilai += 1
        End If
        If CheckBox8.Checked = True Then
            nilai += 1
        End If
        If CheckBox12.Checked = True Then
            nilai += 1
        End If
        If CheckBox14.Checked = True Then
            nilai += 1
        End If
        If CheckBox16.Checked = True Then
            nilai += 1
        End If
        If CheckBox18.Checked = True Then
            nilai += 1
        End If
        If CheckBox20.Checked = True Then
            nilai += 1
        End If
        If CheckBox22.Checked = True Then
            nilai += 1
        End If
        If CheckBox24.Checked = True Then
            nilai += 1
        End If
        If CheckBox26.Checked = True Then
            nilai += 1
        End If
        If CheckBox28.Checked = True Then
            nilai += 1
        End If
        If CheckBox30.Checked = True Then
            nilai += 1
        End If
        If CheckBox32.Checked = True Then
            nilai += 1
        End If
        If CheckBox33.Checked = True Then
            nilai += 1
        End If
        If CheckBox35.Checked = True Then
            nilai += 1
        End If
        If CheckBox35.Checked = True Then
            nilai += 1
        End If
        If CheckBox37.Checked = True Then
            nilai += 1
        End If
        If CheckBox39.Checked = True Then
            nilai += 1
        End If
        If CheckBox41.Checked = True Then
            nilai += 1
        End If
        If nilai < 8 Then
            jenis = "Resiko Rendah"
            MsgBox("Anda Beresiko Rendah Tertular Covid-19 ")
        ElseIf nilai < 15 Then
            jenis = "Resiko Sedang"
            MsgBox("Anda Beresiko Sedang Tertular Covid-19 ")
        ElseIf nilai > 14 Then
            jenis = "Resiko Tinggi"
            MsgBox("Anda Beresiko Tinggi Tertular Covid-19 ")
        End If
        TextBox4.Text = jenis
        sqlnya = "insert into data_siswa (ID_Pengguna,Nama,Jenis_Kelamin,Resiko) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
        Call jalan()
        MsgBox("Data Berhasil Tersimpan")
        Call panggildata()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class