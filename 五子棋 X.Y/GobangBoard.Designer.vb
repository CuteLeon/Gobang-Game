<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GobangBoard
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GobangBoard))
        Me.PicClose = New System.Windows.Forms.Label()
        Me.PicMin = New System.Windows.Forms.Label()
        Me.ReStartButton = New XYButton.XYButton()
        Me.RegretButton = New XYButton.XYButton()
        Me.BeMinButton = New XYButton.XYButton()
        Me.ExitGameButton = New XYButton.XYButton()
        Me.AboutMeButton = New XYButton.XYButton()
        Me.PicPlayer = New System.Windows.Forms.Label()
        Me.GiveUpButton = New XYButton.XYButton()
        Me.SuspendLayout()
        '
        'PicClose
        '
        Me.PicClose.BackColor = System.Drawing.Color.Transparent
        Me.PicClose.Image = Global.五子棋_X.Y.My.Resources.五子棋Resource.关闭窗口
        Me.PicClose.Location = New System.Drawing.Point(687, 1)
        Me.PicClose.Name = "PicClose"
        Me.PicClose.Size = New System.Drawing.Size(27, 27)
        Me.PicClose.TabIndex = 0
        '
        'PicMin
        '
        Me.PicMin.BackColor = System.Drawing.Color.Transparent
        Me.PicMin.Image = Global.五子棋_X.Y.My.Resources.五子棋Resource.最小化
        Me.PicMin.Location = New System.Drawing.Point(660, 1)
        Me.PicMin.Name = "PicMin"
        Me.PicMin.Size = New System.Drawing.Size(27, 27)
        Me.PicMin.TabIndex = 1
        '
        'ReStartButton
        '
        Me.ReStartButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ReStartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ReStartButton.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ReStartButton.BackColor = System.Drawing.Color.Transparent
        Me.ReStartButton.BackgroundImage = CType(resources.GetObject("ReStartButton.BackgroundImage"), System.Drawing.Image)
        Me.ReStartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ReStartButton.Location = New System.Drawing.Point(609, 296)
        Me.ReStartButton.Name = "ReStartButton"
        Me.ReStartButton.Size = New System.Drawing.Size(100, 36)
        Me.ReStartButton.TabIndex = 2
        '
        'RegretButton
        '
        Me.RegretButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.RegretButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RegretButton.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.RegretButton.BackColor = System.Drawing.Color.Transparent
        Me.RegretButton.BackgroundImage = CType(resources.GetObject("RegretButton.BackgroundImage"), System.Drawing.Image)
        Me.RegretButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RegretButton.Location = New System.Drawing.Point(609, 338)
        Me.RegretButton.Name = "RegretButton"
        Me.RegretButton.Size = New System.Drawing.Size(100, 36)
        Me.RegretButton.TabIndex = 3
        '
        'BeMinButton
        '
        Me.BeMinButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BeMinButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BeMinButton.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BeMinButton.BackColor = System.Drawing.Color.Transparent
        Me.BeMinButton.BackgroundImage = CType(resources.GetObject("BeMinButton.BackgroundImage"), System.Drawing.Image)
        Me.BeMinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BeMinButton.Location = New System.Drawing.Point(609, 496)
        Me.BeMinButton.Name = "BeMinButton"
        Me.BeMinButton.Size = New System.Drawing.Size(100, 36)
        Me.BeMinButton.TabIndex = 4
        '
        'ExitGameButton
        '
        Me.ExitGameButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ExitGameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ExitGameButton.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ExitGameButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitGameButton.BackgroundImage = CType(resources.GetObject("ExitGameButton.BackgroundImage"), System.Drawing.Image)
        Me.ExitGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExitGameButton.Location = New System.Drawing.Point(609, 538)
        Me.ExitGameButton.Name = "ExitGameButton"
        Me.ExitGameButton.Size = New System.Drawing.Size(100, 36)
        Me.ExitGameButton.TabIndex = 5
        '
        'AboutMeButton
        '
        Me.AboutMeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AboutMeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AboutMeButton.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.AboutMeButton.BackColor = System.Drawing.Color.Transparent
        Me.AboutMeButton.BackgroundImage = CType(resources.GetObject("AboutMeButton.BackgroundImage"), System.Drawing.Image)
        Me.AboutMeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutMeButton.Location = New System.Drawing.Point(609, 454)
        Me.AboutMeButton.Name = "AboutMeButton"
        Me.AboutMeButton.Size = New System.Drawing.Size(100, 36)
        Me.AboutMeButton.TabIndex = 6
        '
        'PicPlayer
        '
        Me.PicPlayer.BackColor = System.Drawing.Color.Transparent
        Me.PicPlayer.Image = Global.五子棋_X.Y.My.Resources.五子棋Resource.黑色棋罐
        Me.PicPlayer.Location = New System.Drawing.Point(630, 136)
        Me.PicPlayer.Name = "PicPlayer"
        Me.PicPlayer.Size = New System.Drawing.Size(58, 52)
        Me.PicPlayer.TabIndex = 8
        '
        'GiveUpButton
        '
        Me.GiveUpButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.GiveUpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GiveUpButton.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.GiveUpButton.BackColor = System.Drawing.Color.Transparent
        Me.GiveUpButton.BackgroundImage = CType(resources.GetObject("GiveUpButton.BackgroundImage"), System.Drawing.Image)
        Me.GiveUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GiveUpButton.Location = New System.Drawing.Point(609, 380)
        Me.GiveUpButton.Name = "GiveUpButton"
        Me.GiveUpButton.Size = New System.Drawing.Size(100, 36)
        Me.GiveUpButton.TabIndex = 9
        '
        'GobangBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.五子棋_X.Y.My.Resources.五子棋Resource.棋盘
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(715, 615)
        Me.Controls.Add(Me.GiveUpButton)
        Me.Controls.Add(Me.PicPlayer)
        Me.Controls.Add(Me.AboutMeButton)
        Me.Controls.Add(Me.ExitGameButton)
        Me.Controls.Add(Me.BeMinButton)
        Me.Controls.Add(Me.RegretButton)
        Me.Controls.Add(Me.ReStartButton)
        Me.Controls.Add(Me.PicMin)
        Me.Controls.Add(Me.PicClose)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(-615, -635)
        Me.Name = "GobangBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "GobangBoard"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PicClose As System.Windows.Forms.Label
    Friend WithEvents PicMin As System.Windows.Forms.Label
    Friend WithEvents ReStartButton As XYButton.XYButton
    Friend WithEvents RegretButton As XYButton.XYButton
    Friend WithEvents BeMinButton As XYButton.XYButton
    Friend WithEvents ExitGameButton As XYButton.XYButton
    Friend WithEvents AboutMeButton As XYButton.XYButton
    Friend WithEvents PicPlayer As System.Windows.Forms.Label
    Friend WithEvents GiveUpButton As XYButton.XYButton
End Class
