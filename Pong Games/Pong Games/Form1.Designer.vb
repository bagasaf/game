<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PongMain
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
        Me.paddleComputer = New System.Windows.Forms.PictureBox()
        Me.paddlePlayer = New System.Windows.Forms.PictureBox()
        Me.gameBall = New System.Windows.Forms.PictureBox()
        Me.compScoreDraw = New System.Windows.Forms.Label()
        Me.playerScoreDraw = New System.Windows.Forms.Label()
        CType(Me.paddleComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paddlePlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gameBall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'paddleComputer
        '
        Me.paddleComputer.BackColor = System.Drawing.Color.CadetBlue
        Me.paddleComputer.Location = New System.Drawing.Point(25, 140)
        Me.paddleComputer.Name = "paddleComputer"
        Me.paddleComputer.Size = New System.Drawing.Size(15, 130)
        Me.paddleComputer.TabIndex = 0
        Me.paddleComputer.TabStop = False
        '
        'paddlePlayer
        '
        Me.paddlePlayer.BackColor = System.Drawing.Color.CadetBlue
        Me.paddlePlayer.Location = New System.Drawing.Point(585, 140)
        Me.paddlePlayer.Name = "paddlePlayer"
        Me.paddlePlayer.Size = New System.Drawing.Size(15, 130)
        Me.paddlePlayer.TabIndex = 1
        Me.paddlePlayer.TabStop = False
        '
        'gameBall
        '
        Me.gameBall.BackColor = System.Drawing.Color.CadetBlue
        Me.gameBall.Location = New System.Drawing.Point(300, 190)
        Me.gameBall.Name = "gameBall"
        Me.gameBall.Size = New System.Drawing.Size(15, 15)
        Me.gameBall.TabIndex = 2
        Me.gameBall.TabStop = False
        '
        'compScoreDraw
        '
        Me.compScoreDraw.AutoSize = True
        Me.compScoreDraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compScoreDraw.Location = New System.Drawing.Point(12, 9)
        Me.compScoreDraw.Name = "compScoreDraw"
        Me.compScoreDraw.Size = New System.Drawing.Size(27, 29)
        Me.compScoreDraw.TabIndex = 3
        Me.compScoreDraw.Text = "0"
        '
        'playerScoreDraw
        '
        Me.playerScoreDraw.AutoSize = True
        Me.playerScoreDraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playerScoreDraw.Location = New System.Drawing.Point(585, 9)
        Me.playerScoreDraw.Name = "playerScoreDraw"
        Me.playerScoreDraw.Size = New System.Drawing.Size(27, 29)
        Me.playerScoreDraw.TabIndex = 4
        Me.playerScoreDraw.Text = "0"
        '
        'PongMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.playerScoreDraw)
        Me.Controls.Add(Me.compScoreDraw)
        Me.Controls.Add(Me.gameBall)
        Me.Controls.Add(Me.paddlePlayer)
        Me.Controls.Add(Me.paddleComputer)
        Me.Name = "PongMain"
        Me.Text = "PONG GAMES"
        CType(Me.paddleComputer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paddlePlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gameBall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents paddleComputer As System.Windows.Forms.PictureBox
    Friend WithEvents paddlePlayer As System.Windows.Forms.PictureBox
    Friend WithEvents gameBall As System.Windows.Forms.PictureBox
    Friend WithEvents compScoreDraw As System.Windows.Forms.Label
    Friend WithEvents playerScoreDraw As System.Windows.Forms.Label

End Class
