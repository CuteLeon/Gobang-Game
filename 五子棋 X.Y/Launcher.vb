Imports System.Drawing.Drawing2D

Public Class Launcher
    Dim ThreadOfBoard As Threading.Thread

    '绘制界面
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim MyGraphics As Graphics = e.Graphics
        MyGraphics.SmoothingMode = SmoothingMode.HighQuality
        MyGraphics.PixelOffsetMode = PixelOffsetMode.HighQuality
        '窗体四周加黑色边框
        MyGraphics.DrawLine(Pens.Black, 0, 0, Me.Width, 0)
        MyGraphics.DrawLine(Pens.Black, Me.Width, 0, Me.Width, Me.Height)
        MyGraphics.DrawLine(Pens.Black, 0, 0, 0, Me.Height)
        MyGraphics.DrawLine(Pens.Black, 0, Me.Height, Me.Width, Me.Height)
        '把图像绘制到窗体
        Dim MyBitmap As New Bitmap(My.Resources.五子棋Resource.小眼五子棋Cpation)
        MyGraphics.DrawImage(MyBitmap, 80, 90, MyBitmap.Width, MyBitmap.Height)
        MyBitmap = New Bitmap(My.Resources.五子棋Resource.VSlogo)
        MyGraphics.DrawImage(MyBitmap, 0, 0, MyBitmap.Width, MyBitmap.Height)
        MyBitmap = New Bitmap(My.Resources.五子棋Resource.进度条容器)
        MyGraphics.DrawImage(MyBitmap, 95, 200, MyBitmap.Width, MyBitmap.Height)
        MyBitmap = New Bitmap(My.Resources.五子棋Resource.作者)
        MyGraphics.DrawImage(MyBitmap, 10, 300, MyBitmap.Width, MyBitmap.Height)
    End Sub

    Private Sub Launcher_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        If MsgBox("真的要退出吗？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "小眼五子棋：") = MsgBoxResult.Yes Then
            If Not (ThreadOfBoard Is Nothing) Then
                ThreadOfBoard.Abort()
                ThreadOfBoard = Nothing
            End If

            For index As Int16 = 20 To 0 Step -1
                Threading.Thread.Sleep(20)
                Me.Opacity = index / 20
            Next
            Me.Hide()
            End
        End If
    End Sub

    '鼠标拖动窗体
    Private Sub Launcher_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ReleaseCapture()
        SendMessageA(Me.Handle, &HA1, 2, 0&)
    End Sub

    '程序启动初始化
    Private Sub Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartGame.SetCaption("开始游戏!")
        Dim CloseRectangle As New Rectangle(0, 0, 27, 27)
        Dim CloseBitmap As New Bitmap(My.Resources.五子棋Resource.关闭窗口.Clone(CloseRectangle, Imaging.PixelFormat.Format32bppArgb))
        PicClose.Image = CloseBitmap
    End Sub

#Region "右上角关闭按钮"
    Private Sub PicClose_Click(sender As Object, e As EventArgs) Handles PicClose.Click
        Dim CloseRectangle As New Rectangle(54, 0, 27, 27)
        Dim CloseBitmap As New Bitmap(My.Resources.五子棋Resource.关闭窗口.Clone(CloseRectangle, Imaging.PixelFormat.Format32bppArgb))
        PicClose.Image = CloseBitmap
    End Sub

    Private Sub PicClose_MouseDown(sender As Object, e As MouseEventArgs) Handles PicClose.MouseDown
        Dim CloseRectangle As New Rectangle(54, 0, 27, 27)
        Dim CloseBitmap As New Bitmap(My.Resources.五子棋Resource.关闭窗口.Clone(CloseRectangle, Imaging.PixelFormat.Format32bppArgb))
        PicClose.Image = CloseBitmap
    End Sub

    Private Sub PicClose_MouseEnter(sender As Object, e As EventArgs) Handles PicClose.MouseEnter
        Dim CloseRectangle As New Rectangle(27, 0, 27, 27)
        Dim CloseBitmap As New Bitmap(My.Resources.五子棋Resource.关闭窗口.Clone(CloseRectangle, Imaging.PixelFormat.Format32bppArgb))
        PicClose.Image = CloseBitmap
    End Sub

    Private Sub PicClose_MouseLeave(sender As Object, e As EventArgs) Handles PicClose.MouseLeave
        Dim CloseRectangle As New Rectangle(0, 0, 27, 27)
        Dim CloseBitmap As New Bitmap(My.Resources.五子棋Resource.关闭窗口.Clone(CloseRectangle, Imaging.PixelFormat.Format32bppArgb))
        PicClose.Image = CloseBitmap
    End Sub

    Private Sub PicClose_MouseUp(sender As Object, e As MouseEventArgs) Handles PicClose.MouseUp
        Dim CloseRectangle As New Rectangle(0, 0, 27, 27)
        Dim CloseBitmap As New Bitmap(My.Resources.五子棋Resource.关闭窗口.Clone(CloseRectangle, Imaging.PixelFormat.Format32bppArgb))
        PicClose.Image = CloseBitmap

        If MsgBox("真的要退出吗？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "小眼五子棋：") = MsgBoxResult.Yes Then
            If Not (ThreadOfBoard Is Nothing) Then
                ThreadOfBoard.Abort()
                ThreadOfBoard = Nothing
            End If

            For index As Int16 = 20 To 0 Step -1
                Threading.Thread.Sleep(20)
                Me.Opacity = index / 20
            Next
            Me.Hide()
            End
        End If
    End Sub
#End Region

    Private Sub StartGame_Click(sender As Object, e As EventArgs) Handles StartGame.Click
        '确保控件铺设完毕
        If Not (ThreadOfBoard.ThreadState = Threading.ThreadState.Stopped) Then Exit Sub

        ThreadOfBoard.Abort()
        ThreadOfBoard = Nothing

        Me.Hide()
        GobangBoard.Show()
    End Sub

    Private Sub Launcher_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LauncherInfo.Text = "正在铺设棋盘..."
        ThreadOfBoard = New Threading.Thread(AddressOf GobangBoard.CreatTheBoard)
        ThreadOfBoard.Start()

        LoadPrograssion.Enabled = True
    End Sub

    Private Sub LoadPrograssion_Tick(sender As Object, e As EventArgs) Handles LoadPrograssion.Tick
        ProgressBar.Width += 8
        If ProgressBar.Width = 328 Then LoadPrograssion.Enabled = False : LauncherInfo.Text = "棋盘控件铺设完毕！"
    End Sub

End Class
