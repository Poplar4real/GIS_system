﻿Public Class Form1
    Const help_information = "GIS 系统可以提供地理信息查询服务"
    Dim x(1000), y(1000) As Single '在画框的位置
    Dim longtitude, latitude As String '实际经纬度
    Dim i As Integer '计数器
    Dim count As Integer
    Dim st As String
    Dim drawline As Boolean = False

    Private Sub MenuStrip1_Click(sender As Object, e As EventArgs) Handles MenuStrip1.Click
        MsgBox(help_information) '弹出帮助消息
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PictureBox1.Size = Me.Size
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Button1.Visible = False '按钮不可见
        drawline = True
        'PictureBox1.Size = Me.Size '图片框大小
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        If drawline Then
            Dim map As Graphics = PictureBox1.CreateGraphics() '画布
            Dim pen1 As Pen = New Pen(Color.Blue, 1) '画笔
            FileOpen(1, "coastline.dat", OpenMode.Input)
            Input(1, longtitude)
            Do While Not EOF(1)
                Input(1, latitude)
                longtitude = latitude = ""
                Do Until longtitude = "#" Or EOF(1)
                    i = 0
                    Input(1, longtitude)
                    Input(1, latitude)
                    x(i) = (Val(longtitude) + 180) * Me.Width / 360
                    y(i) = (90 - Val(latitude)) * Me.Height / 180
                    i = i + 1
                Loop
                count = i - 1
                For i = 0 To count
                    map.DrawLine(pen1, x(i), y(i), x(i + 1), y(i + 1))
                Next i
            Loop
            FileClose()
        End If
    End Sub
End Class
