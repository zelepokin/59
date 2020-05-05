Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Dim a, S, k, c As Integer
        a = TB.Text
        S = 0
        k = 0
        While a <> 0
            c = a Mod 10
            k = k + 1
            S = S + c
            a = a \ 10
        End While
        Ts.Text = (S)
        Tk.Text = (k)
    End Sub
End Class
