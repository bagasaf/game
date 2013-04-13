<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pongMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gameBall = New System.Windows.Forms.PictureBox()
        Me.paddlePlayer = New System.Windows.Forms.PictureBox()
        Me.paddleComputer = New System.Windows.Forms.PictureBox()
        Me.compScoreDraw = New System.Windows.Forms.Label()
        Me.playerScoreDraw = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.gameBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paddlePlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paddleComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gameBall
        '
        Me.gameBall.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gameBall.BackColor = System.Drawing.Color.ForestGreen
        Me.gameBall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gameBall.Location = New System.Drawing.Point(311, 201)
        Me.gameBall.Name = "gameBall"
        Me.gameBall.Size = New System.Drawing.Size(20, 20)
        Me.gameBall.TabIndex = 0
        Me.gameBall.TabStop = False
        '
        'paddlePlayer
        '
        Me.paddlePlayer.BackColor = System.Drawing.Color.DarkViolet
        Me.paddlePlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paddlePlayer.Location = New System.Drawing.Point(436, 151)
        Me.paddlePlayer.Name = "paddlePlayer"
        Me.paddlePlayer.Size = New System.Drawing.Size(16, 128)
        Me.paddlePlayer.TabIndex = 1
        Me.paddlePlayer.TabStop = False
        '
        'paddleComputer
        '
        Me.paddleComputer.BackColor = System.Drawing.Color.MediumBlue
        Me.paddleComputer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paddleComputer.Location = New System.Drawing.Point(59, 151)
        Me.paddleComputer.Name = "paddleComputer"
        Me.paddleComputer.Size = New System.Drawing.Size(16, 128)
        Me.paddleComputer.TabIndex = 2
        Me.paddleComputer.TabStop = False
        '
        'compScoreDraw
        '
        Me.compScoreDraw.AutoSize = True
        Me.compScoreDraw.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compScoreDraw.Location = New System.Drawing.Point(48, 32)
        Me.compScoreDraw.Name = "compScoreDraw"
        Me.compScoreDraw.Size = New System.Drawing.Size(26, 26)
        Me.compScoreDraw.TabIndex = 3
        Me.compScoreDraw.Text = "0"
        '
        'playerScoreDraw
        '
        Me.playerScoreDraw.AutoSize = True
        Me.playerScoreDraw.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playerScoreDraw.Location = New System.Drawing.Point(549, 32)
        Me.playerScoreDraw.Name = "playerScoreDraw"
        Me.playerScoreDraw.Size = New System.Drawing.Size(26, 26)
        Me.playerScoreDraw.TabIndex = 4
        Me.playerScoreDraw.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Computer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(531, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Player"
        '
        'gameTimer
        '
        Me.gameTimer.Enabled = True
        Me.gameTimer.Interval = 20
        '
        'pongMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(624, 446)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.playerScoreDraw)
        Me.Controls.Add(Me.compScoreDraw)
        Me.Controls.Add(Me.paddleComputer)
        Me.Controls.Add(Me.paddlePlayer)
        Me.Controls.Add(Me.gameBall)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "pongMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pong Game"
        CType(Me.gameBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paddlePlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paddleComputer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gameBall As System.Windows.Forms.PictureBox
    Friend WithEvents paddlePlayer As System.Windows.Forms.PictureBox
    Friend WithEvents paddleComputer As System.Windows.Forms.PictureBox
    Friend WithEvents compScoreDraw As System.Windows.Forms.Label
    Friend WithEvents playerScoreDraw As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gameTimer As System.Windows.Forms.Timer

End Class
