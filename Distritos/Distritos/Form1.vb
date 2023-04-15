Public Class Form1
    Dim distritos(19) As Distrito

    Private borderForm As New Form
        Private Function RoundedRectangle(rect As RectangleF, diam As Single) As Drawing2D.GraphicsPath
            Dim path As New Drawing2D.GraphicsPath
            path.AddArc(rect.Left, rect.Top, diam, diam, 180, 90)
            path.AddArc(rect.Right - diam, rect.Top, diam, diam, 270, 90)
            path.AddArc(rect.Right - diam, rect.Bottom - diam, diam, diam, 0, 90)
            path.AddArc(rect.Left, rect.Bottom - diam, diam, diam, 90, 90)
            path.CloseFigure()
            Return path
        End Function

        Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            Dim r As New Rectangle(1, 1, Me.Width - 2, Me.Height - 2)
            Dim path As Drawing2D.GraphicsPath = RoundedRectangle(r, 48)


        End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim Str(19), straux As String
        Dim aux As Integer = 0

        FileOpen(1, "distritos.csv", OpenMode.Input)
        While Not EOF(1)
            str(aux) = LineInput(1)
            aux += 1
        End While
        For i = 0 To 19
            distritos(i) = New Distrito
            aux = 0
            straux = ""
            Do
                straux &= str(i)(aux)
                aux += 1
            Loop While str(i)(aux) <> ";"

            distritos(i).numero = straux
            straux = ""
            aux += 1
            Do
                straux &= str(i)(aux)
                aux += 1
            Loop While str(i)(aux) <> ";"


            distritos(i).nome = straux
            straux = ""
            aux += 1
            Do
                straux &= str(i)(aux)
                aux += 1
            Loop While str(i)(aux) <> ";"
            distritos(i).habitantes = straux
            straux = ""
            aux += 1
            Do
                straux &= str(i)(aux)

                aux += 1
            Loop While aux < str(i).Length
            distritos(i).area = straux

        Next




        With Me

            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
        End With
        With borderForm
            .ShowInTaskbar = False
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .StartPosition = FormStartPosition.Manual

            .Opacity = 0.8
            Dim r As Rectangle = Me.Bounds
            r.Inflate(2, 2)
            .Bounds = r
            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
            r = New Rectangle(3, 3, Me.Width - 2, Me.Height - 2)
            .Region.Exclude(RoundedRectangle(r, 48))
            .Show(Me)
        End With



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        PictureBox4.Visible = False
        Label8.Visible = True

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        PictureBox4.Visible = true
        Label8.Visible = False
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        TextBox1.Text = ""
        For i = 0 To 19
            TextBox1.Text &= distritos(i).numero & "-"
            TextBox1.Text &= distritos(i).nome & vbNewLine
        Next
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        TextBox1.Text = ""
        For i = 0 To 19
            TextBox1.Text &= distritos(i).numero & "-"
            TextBox1.Text &= distritos(i).nome & "-"
            TextBox1.Text &= distritos(i).habitantes & vbNewLine
        Next
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        TextBox1.Text = ""
        Dim op As Integer = 0
        If BunifuDropdown1.selectedIndex = -1 Then
            MsgBox("Selecione uma opção")
        Else
            For i = 0 To BunifuDropdown1.selectedIndex
                op += 1
            Next
            TextBox1.Text &= distritos(op - 1).numero & ","
            TextBox1.Text &= distritos(op - 1).nome & ","
            TextBox1.Text &= distritos(op - 1).densidade()
        End If



    End Sub
End Class
