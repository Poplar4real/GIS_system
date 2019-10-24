'#######################################################################################################################################
'Project: GIS_system
'Description: This system can paint the map of the world on the windows_form. It can show the latitude and longitude
'of the pet on the map. When rolling the mouse, the map can zoom in and out automatically.
'Author: Zhiyuan Yang
'beta Version:  1.0
'  Date:Sept.21st 
'  Description:This is the very basic version of the GIS system, it now can paint the map on the windows form. It can also show the longitude
'and latitude of the pet on the map. But th recreation speed is very slow. Further work and better algothim is needed.
'beta Version:  2.0
'  Date:Oct.8th
'  Description:I made a lot of changes in this verion. To easily control the size of the map, we decide to use a bitmap to show the map instead
'  of painting it on the form directly. In this version, the app can show the locatio of the mosue, and you can zoom in and out the map with the 
'  mousewheel down or up.
'Version: 3.0
'  Date:Oct.9th
'  Description: We fixed some bugs in the beta version
'#######################################################################################################################################

Imports System.IO
Public Class Form1
    Dim st As String 'st用来读取每行信息
    Dim x(300), y(300) As Single
    Dim i As Integer '计数器
    Dim st_split() As String '分离后的字符
    Dim symbol As String '分隔符
    Dim mouse_x, mouse_y, lo, la As Single '鼠标位置和经纬度
    Dim mouse_position As Point '记录鼠标位置
    Dim map As Boolean = False '记录地图是否画过
    Dim world_map As Bitmap '地图图片
    Dim g As Graphics '绘图对象 
    Dim my_pen As Pen '画笔
    Dim rate As Double = 1 '放大缩小比例
    Dim theta As Double = 0.2 '控制鼠标移动速度参数
    Dim mouse_control As Boolean = False '当前是否由鼠标控制
    Dim delta_x As Double = 0
    Dim delta_y As Double = 0 '记录鼠标本次位移
    Dim start_point_x, start_point_y As Double '记录鼠标开始拖拽的位置
    Dim former_x, former_y As Double '记录鼠标之前的位移
    Dim cursorpoint_x, cursorpoint_y As Double '记录光标放大位置
    Public Structure Info
        Dim longitude As String '经度
        Dim latitude As String '纬度
    End Structure


    '<summary>
    'This is the most important function of the whole program.
    'We read from the coastline.dat and then draw the line.
    'When the mouse is down, or the mousewheel rolls, we will recall the
    'function to form a new picture.
    'The parameters will change when mouse is down or the mousewheel rolls.
    '</summary>

    Public Sub show_map()
        g = Graphics.FromImage(world_map)
        g.Clear(Me.BackColor)
        my_pen = New Pen(Color.Blue, 0.5)
        Dim fm As New IO.FileStream(Application.StartupPath & "/coastline.dat", FileMode.Open)
        Dim reader As New System.IO.StreamReader(fm)
        Dim pet As Info
        symbol = reader.ReadLine()
        Do Until reader.EndOfStream
            st = reader.ReadLine
            i = 0
            Do Until st = symbol Or reader.EndOfStream
                st_split = st.Split(New Char, vbTab)
                pet.longitude = st_split(0)
                pet.latitude = st_split(1)
                x(i) = (Val(pet.longitude) + 180) * PictureBox1.Width * rate / 360 + delta_x
                y(i) = (90 - Val(pet.latitude)) * PictureBox1.Height * rate / 180 + delta_y
                If i > 0 Then
                    g.DrawLine(my_pen, x(i), y(i), x(i - 1), y(i - 1))
                End If
                i = i + 1
                st = reader.ReadLine
            Loop
        Loop
        reader.Close()
        PictureBox1.Image = Nothing
        PictureBox1.Image = world_map
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        PictureBox1.Image = world_map
        FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        map = False
    End Sub


    '<summary>
    'This block of code show the origin map of coastdata.dat
    '</summary>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        world_map = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        show_map()
        map = True
        PictureBox1.Image = world_map
        Button2.Visible = False
    End Sub


    '<summary>
    'This block of code shows the locatio of the mouse in the map
    '</summary>
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If map Then
            mouse_position = Me.PointToClient(Control.MousePosition)
            mouse_x = mouse_position.X
            mouse_y = mouse_position.Y
            lo = (mouse_x - delta_x) * 360 / PictureBox1.Width / rate - 180
            la = 90 - 180 * (mouse_y - delta_y) / rate / PictureBox1.Height
            ToolStripStatusLabel1.Text = "longitude=" & lo.ToString & "   " & "latitude =" & la.ToString
            If mouse_control Then
                delta_x = e.X - start_point_x + former_x
                delta_y = e.Y - start_point_y + former_y
            End If
            cursorpoint_x = e.X
            cursorpoint_y = e.Y
        End If
    End Sub


    '<summary>
    'This block of code aims to zoom in and out the map.
    '</summary>
    Private Sub PictureBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseWheel
        If map Then
            If e.Delta > 0 Then
                rate += theta
                delta_x -= cursorpoint_x * theta
                delta_y -= cursorpoint_y * theta
            Else
                rate -= theta
                delta_x += cursorpoint_x * theta
                delta_y += cursorpoint_y * theta
            End If
        End If
        If map Then
            show_map()
        End If
    End Sub

    '<summary>
    'This block of code re-paints the map when the mouse is down.
    '</summary>
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If map Then
            mouse_control = True
            former_x = delta_x
            former_y = delta_y
            start_point_x = e.X
            start_point_y = e.Y
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        If map Then
            mouse_control = False
            show_map()
        End If
    End Sub

    'We use a timer to control the phase of repainting.
    Private Sub refresh_mouse() Handles Timer1.Tick
        If mouse_control And map Then
            show_map()
        End If
    End Sub

    Private Sub 倍放大速率ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 倍放大速率ToolStripMenuItem.Click
        theta = 0.1
    End Sub


    Private Sub 倍放大速率ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 倍放大速率ToolStripMenuItem1.Click
        theta = 0.5
    End Sub

    Private Sub 倍放大速率ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles 倍放大速率ToolStripMenuItem2.Click
        theta = 1
    End Sub

    Private Sub 倍速率缩放ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 倍速率缩放ToolStripMenuItem.Click
        theta = 0.2
    End Sub


    Private Sub DeveloperInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeveloperInformationToolStripMenuItem.Click
        MessageBox.Show("
                         Author: Zhiyuan Yang
                         beta Version:  1.0  Date:Sept.21st
                         beta Version:  2.0  Date:Oct.8th 
                         Version: 3.0        Date:Oct.9th  
                         Version: 4.0        Date:Oct.13th   
                         GIS 系统可以读取地图数据并绘制地图；放大缩小，平移地图
                         同时可以在状态栏实时显示鼠标所在动态位置坐标，可以控制鼠标放大放小速率")
    End Sub


    Private Sub 开发日记ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 开发日记ToolStripMenuItem.Click
        MessageBox.Show("
                         beta Version 1.0 Date: Sept.21st
                            ·实现了地图绘制
                            ·实现显示鼠标位置信息
                         beta Version 2.0 Date: Oct.8th
                            ·增加了缩放放大功能
                            ·增加地图平移功能
                            ·修复了存在的一些bug
                         Version: 3.0 Date: Oct.9th
                            ·修复了存在的bug，实现在光标处缩放
                            ·修复了存在的bug，修复了图片拖拽时与拖拽位置不符的情况
                         Version: 4.0 Date: Oct.13th
                            ·增加了选择缩放速率功能
                                                     ")
    End Sub

End Class
