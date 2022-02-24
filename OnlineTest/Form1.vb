Public Class Form1
    Dim kondisi As Boolean
    Dim test1, test2 As String
    Private Sub cek()
        test1 = UCase(TextBox1.Text)
        test2 = StrReverse(test1)
        If test2.Equals(test1) Then
            kondisi = True
            MsgBox(kondisi)
        Else
            kondisi = False
            MsgBox(kondisi)
        End If
    End Sub

    Private Sub cek2()
        Dim a, b, c, d, e, f, g, h, i As Single
        a = Val(TextBox2.Text)
        b = Val(TextBox3.Text)
        c = Val(TextBox4.Text)
        d = Val(TextBox5.Text)
        e = Val(TextBox6.Text)
        f = Val(TextBox7.Text)
        g = Val(TextBox8.Text)
        h = Val(TextBox9.Text)
        i = Val(TextBox10.Text)

        TextBox11.Text = a + e + i
        TextBox12.Text = c + e + g
        TextBox13.Text = a + e + i + c + e + g
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cek2()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cek()
    End Sub
End Class
