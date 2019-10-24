<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.倍放大速率ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.倍放大速率ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.倍放大速率ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.倍速率缩放ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeveloperInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.开发日记ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1426, 623)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "绘制完成"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1167, 596)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 16
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1021, 566)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 34)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "开始绘制"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripSplitButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 626)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1167, 26)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "123"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 21)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.倍放大速率ToolStripMenuItem2, Me.倍放大速率ToolStripMenuItem1, Me.倍放大速率ToolStripMenuItem, Me.倍速率缩放ToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(39, 24)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        '倍放大速率ToolStripMenuItem2
        '
        Me.倍放大速率ToolStripMenuItem2.Name = "倍放大速率ToolStripMenuItem2"
        Me.倍放大速率ToolStripMenuItem2.Size = New System.Drawing.Size(241, 26)
        Me.倍放大速率ToolStripMenuItem2.Text = "1倍速率缩放"
        '
        '倍放大速率ToolStripMenuItem1
        '
        Me.倍放大速率ToolStripMenuItem1.Name = "倍放大速率ToolStripMenuItem1"
        Me.倍放大速率ToolStripMenuItem1.Size = New System.Drawing.Size(241, 26)
        Me.倍放大速率ToolStripMenuItem1.Text = "0.5倍速率缩放"
        '
        '倍放大速率ToolStripMenuItem
        '
        Me.倍放大速率ToolStripMenuItem.Name = "倍放大速率ToolStripMenuItem"
        Me.倍放大速率ToolStripMenuItem.Size = New System.Drawing.Size(241, 26)
        Me.倍放大速率ToolStripMenuItem.Text = "0.1倍速率缩放"
        '
        '倍速率缩放ToolStripMenuItem
        '
        Me.倍速率缩放ToolStripMenuItem.Name = "倍速率缩放ToolStripMenuItem"
        Me.倍速率缩放ToolStripMenuItem.Size = New System.Drawing.Size(241, 26)
        Me.倍速率缩放ToolStripMenuItem.Text = "0.2倍速率缩放（推荐）"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1167, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeveloperInformationToolStripMenuItem, Me.开发日记ToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.HelpToolStripMenuItem.Text = "关于..."
        '
        'DeveloperInformationToolStripMenuItem
        '
        Me.DeveloperInformationToolStripMenuItem.Name = "DeveloperInformationToolStripMenuItem"
        Me.DeveloperInformationToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.DeveloperInformationToolStripMenuItem.Text = "开发者信息"
        '
        '开发日记ToolStripMenuItem
        '
        Me.开发日记ToolStripMenuItem.Name = "开发日记ToolStripMenuItem"
        Me.开发日记ToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.开发日记ToolStripMenuItem.Text = "开发日记..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 652)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "GIS_system"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Public WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeveloperInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 开发日记ToolStripMenuItem As ToolStripMenuItem
    Public WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents 倍放大速率ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents 倍放大速率ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 倍放大速率ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 倍速率缩放ToolStripMenuItem As ToolStripMenuItem
End Class
