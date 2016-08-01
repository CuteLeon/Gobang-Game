<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AbortMe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AbortMe))
        Me.CloseMe = New XYButton.XYButton()
        Me.CopyToClipboard = New XYButton.XYButton()
        Me.SuspendLayout()
        '
        'CloseMe
        '
        Me.CloseMe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.CloseMe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CloseMe.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.CloseMe.BackColor = System.Drawing.Color.Transparent
        Me.CloseMe.BackgroundImage = CType(resources.GetObject("CloseMe.BackgroundImage"), System.Drawing.Image)
        Me.CloseMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CloseMe.Location = New System.Drawing.Point(248, 257)
        Me.CloseMe.Name = "CloseMe"
        Me.CloseMe.Size = New System.Drawing.Size(140, 36)
        Me.CloseMe.TabIndex = 0
        '
        'CopyToClipboard
        '
        Me.CopyToClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.CopyToClipboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CopyToClipboard.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.CopyToClipboard.BackColor = System.Drawing.Color.Transparent
        Me.CopyToClipboard.BackgroundImage = CType(resources.GetObject("CopyToClipboard.BackgroundImage"), System.Drawing.Image)
        Me.CopyToClipboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CopyToClipboard.Location = New System.Drawing.Point(62, 257)
        Me.CopyToClipboard.Name = "CopyToClipboard"
        Me.CopyToClipboard.Size = New System.Drawing.Size(140, 36)
        Me.CopyToClipboard.TabIndex = 1
        '
        'AbortMe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.五子棋_X.Y.My.Resources.五子棋Resource.关于
        Me.ClientSize = New System.Drawing.Size(450, 320)
        Me.Controls.Add(Me.CopyToClipboard)
        Me.Controls.Add(Me.CloseMe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AbortMe"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AbortMe"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CloseMe As XYButton.XYButton
    Friend WithEvents CopyToClipboard As XYButton.XYButton
End Class
