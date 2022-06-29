Public Class Form1
    Dim sqlnya As String
    Dim gender As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox4.Enabled = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        gender = ("Laki-Laki")
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        gender = ("Perempuan")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not IsNumeric(TextBox1.Text) Or TextBox1.Text = "" Then
            MsgBox("Silahkan lengkapi data terlebih dahulu dengan angka")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Silahkan lengkapi data terlebih dahulu")
        ElseIf gender = "" Then
            MsgBox("Silahkan lengkapi data terlebih dahulu")
        End If
        Form2.TextBox1.Text = TextBox1.Text
        Form2.TextBox2.Text = TextBox2.Text
        Form2.TextBox3.Text = gender
        Form2.TextBox4.text = TextBox4.Text
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
