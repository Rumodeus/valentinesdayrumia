﻿Option Strict On
Option Explicit On
Option Infer Off
Imports System.Net
Imports System.Net.WebRequestMethods
Imports System.Security.Policy

Public Class Form1
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
    Dim randomNumber As New Random
    Dim url1 As String = (array(randomNumber.Next(0, array.Length)))
    Dim url2 As String = (array(randomNumber.Next(0, array.Length)))
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Restart()
    End Sub
End Class