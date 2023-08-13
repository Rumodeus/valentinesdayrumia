Option Strict On
Option Explicit On
Option Infer Off
Imports System.Net
Imports System.Net.WebRequestMethods
Imports System.Security.Policy

Public Class Form1
    Dim counter As New Integer
    Private Function _
        GetImageFromURL(ByVal url As String) As Image

        Dim retVal As Image = Nothing

        Try
            If Not String.IsNullOrWhiteSpace(url) Then
                Dim req As System.Net.WebRequest = System.Net.WebRequest.Create(url.Trim)

                Using request As System.Net.WebResponse = req.GetResponse
                    Using stream As System.IO.Stream = request.GetResponseStream
                        retVal = New Bitmap(System.Drawing.Image.FromStream(stream))
                    End Using
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show(String.Format("An error occurred:{0}{0}{1}",
                                          vbCrLf, ex.Message),
                                          "Exception Thrown",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning)

        End Try

        Return retVal

    End Function

    Dim array() As String = {"https://i.imgur.com/drsBCLg.jpg", "https://i.imgur.com/ctz0zo9.png", "https://i.imgur.com/zBg2jUk.jpeg", "https://i.imgur.com/CiHvMNN.png", "https://i.imgur.com/CiHvMNN.png", "https://i.imgur.com/6muok6u.jpeg", "https://i.imgur.com/bVe8Gfv.png", "https://i.imgur.com/S23m3uI.png", "https://i.imgur.com/Ns8sNCR.jpeg", "https://i.imgur.com/eAeWLGE.jpeg", "https://i.imgur.com/9VrWxnO.jpeg", "https://i.imgur.com/ztKBrCr.jpeg", "https://i.imgur.com/oQEaG8v.jpeg", "https://i.imgur.com/KQxnKJX.png", "https://i.imgur.com/Zajo9wr.jpeg", "https://i.imgur.com/VXBU0t0.jpeg", "https://i.imgur.com/VC4Mrd7.jpeg", "https://i.imgur.com/clS41mk.jpeg", "https://i.imgur.com/BjgsakV.jpeg", "https://i.imgur.com/UhFECGo.png"}
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        counter = counter + 1
        If counter = 5 Then
            Button1.Text = "Fucking Weeb (Click for Rumia)"
        End If
        If counter = 10 Then
            Process.Start("http://www.maerivoet.org/website/links/miscellaneous/speed-seduction-book/resources/speed-seduction-book.pdf")
        End If
        If counter = 15 Then
            MsgBox("go outside please", vbCritical, "No Females have ever touched you")
            Application.Exit()
        End If
        Dim randomNumber As New Random
        Dim url1 As String = (array(randomNumber.Next(0, array.Length)))
        Dim url2 As String = (array(randomNumber.Next(0, array.Length)))
        'should this be here????
        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        With PictureBox1
            .SizeMode = PictureBoxSizeMode.Zoom
            Dim img As Image = GetImageFromURL(url1)
            If img IsNot Nothing Then
                .Image = img
            End If
        End With
        With PictureBox2
            .SizeMode = PictureBoxSizeMode.Zoom
            Dim img2 As Image = GetImageFromURL(url2)
            If img2 IsNot Nothing Then
                .Image = img2
            End If
        End With
    End Sub

    Private Sub RoundButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.FromArgb(255, 140, 255)
        btn.ForeColor = Color.Black
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Nirmala UI", 17)
        Dim Raduis As New Drawing2D.GraphicsPath
        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()
        btn.Region = New Region(Raduis)
    End Sub
    Private Sub RoundButton2(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.FromArgb(255, 140, 255)
        btn.ForeColor = Color.Black
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Nirmala UI", 14)
        Dim Raduis As New Drawing2D.GraphicsPath
        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()
        btn.Region = New Region(Raduis)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundButton(Button1)
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundButton2(Button2)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        counter = 0
        With PictureBox1
            PictureBox1.Image = Nothing
        End With
        With PictureBox2
            PictureBox2.Image = Nothing
        End With
    End Sub
End Class