<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Launcher
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Launcher))
        Me.PicClose = New System.Windows.Forms.PictureBox()
        Me.ProgressBar = New System.Windows.Forms.PictureBox()
        Me.LauncherInfo = New System.Windows.Forms.Label()
        Me.LoadPrograssion = New System.Windows.Forms.Timer(Me.components)
        Me.StartGame = New XYButton.XYButton()
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicClose
        '
        Me.PicClose.BackColor = System.Drawing.Color.Transparent
        Me.PicClose.Location = New System.Drawing.Point(512, 1)
        Me.PicClose.Name = "PicClose"
        Me.PicClose.Size = New System.Drawing.Size(27, 27)
        Me.PicClose.TabIndex = 2
        Me.PicClose.TabStop = False
        '
        'ProgressBar
        '
        Me.ProgressBar.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBar.BackgroundImage = Global.五子棋_X.Y.My.Resources.五子棋Resource.进度条
        Me.ProgressBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProgressBar.Location = New System.Drawing.Point(106, 200)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(0, 26)
        Me.ProgressBar.TabIndex = 4
        Me.ProgressBar.TabStop = False
        '
        'LauncherInfo
        '
        Me.LauncherInfo.BackColor = System.Drawing.Color.Transparent
        Me.LauncherInfo.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LauncherInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LauncherInfo.Location = New System.Drawing.Point(0, 183)
        Me.LauncherInfo.Name = "LauncherInfo"
        Me.LauncherInfo.Size = New System.Drawing.Size(540, 16)
        Me.LauncherInfo.TabIndex = 5
        Me.LauncherInfo.Text = "欢迎使用小眼五子棋！"
        Me.LauncherInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoadPrograssion
        '
        Me.LoadPrograssion.Interval = 10
        '
        'StartGame
        '
        Me.StartGame.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.StartGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.StartGame.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.StartGame.BackColor = System.Drawing.Color.Transparent
        Me.StartGame.BackgroundImage = CType(resources.GetObject("StartGame.BackgroundImage"), System.Drawing.Image)
        Me.StartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StartGame.Location = New System.Drawing.Point(200, 240)
        Me.StartGame.Name = "StartGame"
        Me.StartGame.Size = New System.Drawing.Size(140, 36)
        Me.StartGame.TabIndex = 6
        '
        'Launcher
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.五子棋_X.Y.My.Resources.五子棋Resource.Launcher
        Me.ClientSize = New System.Drawing.Size(540, 360)
        Me.Controls.Add(Me.StartGame)
        Me.Controls.Add(Me.LauncherInfo)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.PicClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Launcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "小眼五子棋-Launcher"
        Me.TopMost = True
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PicClose As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar As System.Windows.Forms.PictureBox
    Friend WithEvents LauncherInfo As System.Windows.Forms.Label
    Friend WithEvents LoadPrograssion As System.Windows.Forms.Timer
    Friend WithEvents StartGame As XYButton.XYButton

End Class
