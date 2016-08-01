Imports System.Drawing.Drawing2D

Public Class AbortMe

    Private Sub AbortMe_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ReleaseCapture()
        SendMessageA(Me.Handle, &HA1, 2, 0&)
    End Sub

    '绘制界面
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim MyGraphics As Graphics = e.Graphics
        MyGraphics.SmoothingMode = SmoothingMode.HighQuality
        MyGraphics.PixelOffsetMode = PixelOffsetMode.HighQuality
        Dim MyBitmap As New Bitmap(My.Resources.五子棋Resource.作者)
        MyGraphics.DrawImage(MyBitmap, 120, 145, MyBitmap.Width, MyBitmap.Height)
    End Sub

    Private Sub AbortMe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CloseMe.SetCaption("关闭")
        CopyToClipboard.SetCaption("复制到剪切板")
    End Sub

    Private Sub CloseMe_Click(sender As Object, e As EventArgs) Handles CloseMe.Click
        For index As Int16 = 20 To 0 Step -1
            Threading.Thread.Sleep(20)
            Me.Opacity = index / 20
        Next
        Me.Opacity = 1
        Me.Hide()
    End Sub

    Private Sub CopyToClipboard_Click(sender As Object, e As EventArgs) Handles CopyToClipboard.Click
        Clipboard.SetText("小眼五子棋" & vbCrLf & "作者：小眼" & vbCrLf & "QQ:2543280836" & vbCrLf & "E-mail：15824734237@qq.com")
        CopyToClipboard.SetCaption("已拷贝到剪切板！")
    End Sub

    Private Sub AbortMe_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        For index As Int16 = 0 To 20
            Threading.Thread.Sleep(20)
            Me.Opacity = index / 20
        Next
    End Sub

End Class