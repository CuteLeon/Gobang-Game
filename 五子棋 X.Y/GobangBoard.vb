Option Explicit On

Imports System.Drawing.Drawing2D

'Piece.Tag = 0 : 为放置棋子
'                 = 1 : 黑色棋子
'                 = 2 : 白色棋子
'Piece.Name = (棋子坐标.X *  15 + 棋子坐标.Y)
'PieceArray = 15x15
'Piece.Size = New Size(40,40)

Public Class GobangBoard
    Dim GobangPieces(14, 14) As PictureBox
    Dim IsBlack As Boolean = True

#Region "棋子"

    Private Sub PiecesMouseEnter(Sender As PictureBox, e As EventArgs)
        '鼠标进入显示光标
        If Sender.Tag = 0 Then Sender.BackgroundImage = My.Resources.五子棋Resource.光标
    End Sub

    Private Sub PiecesMouseLeave(Sender As PictureBox, e As EventArgs)
        '鼠标离开隐藏光标
        If Sender.Tag = 0 Then Sender.BackgroundImage = Nothing
    End Sub

    Private Sub PiecesClick(Sender As PictureBox, e As EventArgs)
        '点击棋子
        If Sender.Tag > 0 Then Exit Sub
        Sender.Tag = IIf(IsBlack, 1, 2)
        Sender.Image = My.Resources.五子棋Resource.ResourceManager.GetObject(IIf(IsBlack, "黑", "白") & "色棋子")
        DoesSomebodyWin(Sender)
        IsBlack = Not IsBlack '代码上下顺序不可变动
        PicPlayer.Image = My.Resources.五子棋Resource.ResourceManager.GetObject(IIf(IsBlack, "黑", "白") & "色棋罐")
    End Sub
#End Region

    Private Sub DoesSomebodyWin(ByVal Piece As PictureBox)
        Dim X As Byte = CInt(Piece.Name) \ 15
        Dim Y As Byte = CInt(Piece.Name) - 15 * X
        Dim MyState As Byte = Piece.Tag '中心棋子的状态
        Dim MyString As String = IIf(IsBlack, "11111", "22222")
        Dim StateString As String = vbNullString '周围9个棋子状态连接的字符串，用于判断是否存在连续的棋子
        Dim StartPoint As Byte '遍历开始坐标
        Dim EndPoint As Byte '遍历结束坐标
        Dim Index As SByte
        Dim Win As Boolean

        '水平遍历
        StartPoint = Math.Max(0, X - 4)
        EndPoint = Math.Min(14, X + 4)
        For Index = StartPoint To EndPoint
            StateString &= GobangPieces(Index, Y).Tag
        Next
        If Strings.InStr(StateString, MyString) Then
            Win = True
            For Index = X To StartPoint Step -1
                If GobangPieces(Index, Y).Tag = MyState Then GobangPieces(Index, Y).BackgroundImage = My.Resources.五子棋Resource.棋子高亮 Else Exit For
            Next
            For Index = X To EndPoint
                If GobangPieces(Index, Y).Tag = MyState Then GobangPieces(Index, Y).BackgroundImage = My.Resources.五子棋Resource.棋子高亮 Else Exit For
            Next
        End If
        StateString = vbNullString
        '垂直遍历
        StartPoint = Math.Max(0, Y - 4)
        EndPoint = Math.Min(14, Y + 4)
        For Index = StartPoint To EndPoint
            StateString &= GobangPieces(X, Index).Tag
        Next
        If Strings.InStr(StateString, MyString) Then
            Win = True
            For Index = Y To StartPoint Step -1
                If GobangPieces(X, Index).Tag = MyState Then GobangPieces(X, Index).BackgroundImage = My.Resources.五子棋Resource.棋子高亮 Else Exit For
            Next
            For Index = Y To EndPoint
                If GobangPieces(X, Index).Tag = MyState Then GobangPieces(X, Index).BackgroundImage = My.Resources.五子棋Resource.棋子高亮 Else Exit For
            Next
        End If
        StateString = vbNullString
        '对角线遍历（左上-右下）
        Dim TempX As SByte = X - 4
        Dim TempY As SByte = Y - 4
        For Index = 1 To 9
            If -1 < TempY AndAlso TempY < 15 AndAlso -1 < TempX AndAlso TempX < 15 Then
                StateString &= GobangPieces(TempX, TempY).Tag
            End If
            TempX += 1
            TempY += 1
        Next
        If Strings.InStr(StateString, MyString) Then
            Win = True
            For Index = 0 To 4
                TempX = X - Index : TempY = Y - Index
                If -1 < TempY AndAlso TempY < 15 AndAlso -1 < TempX AndAlso TempX < 15 Then
                    If GobangPieces(TempX, TempY).Tag = MyState Then GobangPieces(TempX, TempY).BackgroundImage = My.Resources.五子棋Resource.棋子高亮 Else Exit For
                End If
            Next
            For Index = 1 To 4
                TempX = X + Index : TempY = Y + Index
                If -1 < TempY AndAlso TempY < 15 AndAlso -1 < TempX AndAlso TempX < 15 Then
                    If GobangPieces(TempX, TempY).Tag = MyState Then GobangPieces(TempX, TempY).BackgroundImage = My.Resources.五子棋Resource.棋子高亮 Else Exit For
                End If
            Next
        End If
        '对角线遍历（右上-左下）
        TempX = X + 4
        TempY = Y - 4
        For Index = 1 To 9
            If -1 < TempY AndAlso TempY < 15 AndAlso -1 < TempX AndAlso TempX < 15 Then
                StateString &= GobangPieces(TempX, TempY).Tag
            End If
            TempX -= 1
            TempY += 1
        Next
        If Strings.InStr(StateString, MyString) Then
            Win = True
            For Index = 0 To 4
                TempX = X - Index : TempY = Y + Index
                If -1 < TempY AndAlso TempY < 15 AndAlso -1 < TempX AndAlso TempX < 15 Then
                    If GobangPieces(TempX, TempY).Tag = MyState Then GobangPieces(TempX, TempY).BackgroundImage = My.Resources.五子棋Resource.棋子高亮 Else Exit For
                End If
            Next
            For Index = 1 To 4
                TempX = X + Index : TempY = Y - Index
                If -1 < TempY AndAlso TempY < 15 AndAlso -1 < TempX AndAlso TempX < 15 Then
                    If GobangPieces(TempX, TempY).Tag = MyState Then GobangPieces(TempX, TempY).BackgroundImage = My.Resources.五子棋Resource.棋子高亮 Else Exit For
                End If
            Next
        End If

        If Win Then
            MsgBox(IIf(MyState = 1, "黑", "白") & "棋获胜！", MsgBoxStyle.Information, "游戏结束：")
            IsBlack = True
            PicPlayer.Image = My.Resources.五子棋Resource.黑色棋罐
            For Each PicControl In GobangPieces
                If PicControl.Tag > 0 Then
                    PicControl.Tag = 0
                    PicControl.BackgroundImage = Nothing
                    PicControl.Image = Nothing
                End If
            Next
        End If
    End Sub

    Public Sub CreatTheBoard()
        Dim LocationX As Integer = 8, LocationY As Integer
        For IndexX As Byte = 0 To 14
            LocationY = 8
            For IndexY As Byte = 0 To 14
                Dim Piece As New PictureBox
                With Piece
                    '用Name属性当做ID标识
                    .Name = IndexX * 15 + IndexY
                    .BackgroundImageLayout = ImageLayout.Center
                    .SizeMode = PictureBoxSizeMode.CenterImage
                    .Tag = 0
                    .BackColor = Color.Transparent
                    .SetBounds(LocationX, LocationY, 40, 40)
                End With
                Me.Controls.Add(Piece)
                AddHandler Piece.MouseEnter, AddressOf PiecesMouseEnter
                AddHandler Piece.MouseLeave, AddressOf PiecesMouseLeave
                AddHandler Piece.Click, AddressOf PiecesClick

                GobangPieces(IndexX, IndexY) = Piece
                LocationY += 40
            Next
            LocationX += 40
        Next
    End Sub

    Private Sub GobangBoard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub

    '鼠标拖动窗体
    Private Sub GobangBoard_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, PicPlayer.MouseDown
        ReleaseCapture()
        SendMessageA(Me.Handle, &HA1, 2, 0&)
    End Sub

    Private Sub GobangBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReStartButton.SetCaption("重新开始")
        RegretButton.SetCaption("悔棋")
        GiveUpButton.SetCaption("认输")
        BeMinButton.SetCaption("最小化")
        ExitGameButton.SetCaption("退出游戏")
        AboutMeButton.SetCaption("关于")

        Dim StateRectangle As New Rectangle(0, 0, 27, 27)
        Dim StateBitmap As New Bitmap(My.Resources.五子棋Resource.关闭窗口.Clone(StateRectangle, Imaging.PixelFormat.Format32bppArgb))
        PicClose.Image = StateBitmap
        StateBitmap = New Bitmap(My.Resources.五子棋Resource.最小化.Clone(StateRectangle, Imaging.PixelFormat.Format32bppArgb))
        PicMin.Image = StateBitmap
    End Sub

#Region "右上角窗口状态按钮"
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
        ExitGame()
    End Sub

    Private Sub PicMin_Click(sender As Object, e As EventArgs) Handles PicMin.Click
        Dim MinRectangle As New Rectangle(54, 0, 27, 27)
        Dim MinBitmap As New Bitmap(My.Resources.五子棋Resource.最小化.Clone(MinRectangle, Imaging.PixelFormat.Format32bppArgb))
        PicMin.Image = MinBitmap
    End Sub
    Private Sub PicMin_MouseDown(sender As Object, e As MouseEventArgs) Handles PicMin.MouseDown
        Dim MinRectangle As New Rectangle(54, 0, 27, 27)
        Dim MinBitmap As New Bitmap(My.Resources.五子棋Resource.最小化.Clone(MinRectangle, Imaging.PixelFormat.Format32bppArgb))
        PicMin.Image = MinBitmap
    End Sub
    Private Sub PicMin_MouseEnter(sender As Object, e As EventArgs) Handles PicMin.MouseEnter
        Dim MinRectangle As New Rectangle(27, 0, 27, 27)
        Dim MinBitmap As New Bitmap(My.Resources.五子棋Resource.最小化.Clone(MinRectangle, Imaging.PixelFormat.Format32bppArgb))
        PicMin.Image = MinBitmap
    End Sub
    Private Sub PicMin_MouseLeave(sender As Object, e As EventArgs) Handles PicMin.MouseLeave
        Dim MinRectangle As New Rectangle(0, 0, 27, 27)
        Dim MinBitmap As New Bitmap(My.Resources.五子棋Resource.最小化.Clone(MinRectangle, Imaging.PixelFormat.Format32bppArgb))
        PicMin.Image = MinBitmap
    End Sub
    Private Sub PicMin_MouseUp(sender As Object, e As MouseEventArgs) Handles PicMin.MouseUp
        Dim MinRectangle As New Rectangle(0, 0, 27, 27)
        Dim MinBitmap As New Bitmap(My.Resources.五子棋Resource.最小化.Clone(MinRectangle, Imaging.PixelFormat.Format32bppArgb))
        PicMin.Image = MinBitmap
        BeMin()
    End Sub
#End Region

#Region "右侧功能按钮"
    Private Sub ReStart_Click(sender As Object, e As EventArgs) Handles ReStartButton.Click
        If MsgBox("确定要重新开始吗？这将清空棋盘所有棋子。", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "确定要重新开始？") = vbYes Then RestartGame()
    End Sub

    Private Sub Regret_Click(sender As Object, e As EventArgs) Handles RegretButton.Click
        '悔棋
    End Sub

    Private Sub AboutMe_Click(sender As Object, e As EventArgs) Handles AboutMeButton.Click
        '关于
        If Not (AbortMe.Visible) Then AbortMe.Show(Me)
    End Sub

    Private Sub BeMin_Up(sender As Object, e As MouseEventArgs) Handles BeMinButton.MouseUp
        '最小化
        BeMin()
    End Sub

    Private Sub ExitGame_MouseUp(sender As Object, e As MouseEventArgs) Handles ExitGameButton.MouseUp
        '关闭
        ExitGame()
    End Sub

    Private Sub GiveUp_Click(sender As Object, e As EventArgs) Handles GiveUpButton.Click
        '认输
        MsgBox("不许认输！")
    End Sub
#End Region

#Region "功能函数"

    Private Sub RestartGame()
        '重新开始
        IsBlack = True
        PicPlayer.Image = My.Resources.五子棋Resource.黑色棋罐
        For Each PicControl In GobangPieces
            PicControl.Tag = 0
            PicControl.BackgroundImage = Nothing
            PicControl.Image = Nothing
        Next
    End Sub

    Private Sub ExitGame()
        If MsgBox("真的要退出吗？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "小眼五子棋：") = MsgBoxResult.Yes Then
            For Index As SByte = 0 To 20
                Threading.Thread.Sleep(20)
                Me.Opacity -= 1 / 20
                If AbortMe.Visible Then AbortMe.Opacity = Me.Opacity
            Next
            Me.Hide()
            End
        End If
    End Sub

    Private Sub BeMin()
        For Index As Byte = 0 To 30
            Threading.Thread.Sleep(10)
            Me.Opacity = 1 - Index / 30
        Next
        Me.WindowState = FormWindowState.Minimized
        Me.Opacity = 1
    End Sub
#End Region

End Class