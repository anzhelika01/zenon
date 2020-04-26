
Imports System.Drawing
    Imports System.Drawing.Graphics
    Public Class Form1
        Const A_Width = 40
        Const A_Height = 160
        Const T_Width = 40
        Const T_Height = 40
        Dim BM As Bitmap
        Dim g As Graphics
    Dim Sx As Integer
    Dim Sy As Integer
    Dim X1 As Single
    Dim X2 As Single
    Dim V1 As Single
    Dim V2 As Single
    Dim t As Single
    Dim ds As Single
    Dim dt As Single

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sx = PictureBox1.DisplayRectangle.Width
        Sy = PictureBox1.DisplayRectangle.Height
        BM = New Bitmap(Sx, Sy)
        g = FromImage(BM)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        V1 = Val(TextBox1.Text)
        V2 = Val(TextBox2.Text)
        X1 = 0
        X2 = Sx / 4
        dt = (X2 - X1) / V1 / 100
        g.Clear(PictureBox1.BackColor)
        g.FillRectangle(Brushes.Gray, X1, Sy - A_Height, A_Width, A_Height)
        g.FillEllipse(Brushes.Green, X2, Sy - T_Height \ 2, T_Width, T_Height)
        PictureBox1.Image = BM
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ds = X2 - X1 - A_Width
        t = ds / V1
        If dt > t And RadioButton1.Checked Then dt = t / 100
        X1 = X1 + V1 * dt
        X2 = X2 + V2 * dt
        g.Clear(PictureBox1.BackColor)
        g.FillRectangle(Brushes.Gray, X1, Sy - A_Height, A_Width, A_Height)
        g.FillEllipse(Brushes.Green, X2, Sy - T_Height \ 2, T_Width, T_Height)
        PictureBox1.Image = BM
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer1.Enabled = False
    End Sub


End Class
