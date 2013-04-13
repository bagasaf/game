Public Class pongMain

#Region "Global"
    Dim speed As Single = 10 'kecepatan bola
    Dim rndInst As New Random() 'bola acak
    Dim xVel As Single = CSng(Math.Cos(rndInst.Next(5, 10)) * speed)
    Dim yVel As Single = CSng(Math.Sin(rndInst.Next(5, 10)) * speed)

    'player score
    Dim compScore As Integer = 0
    Dim playScore As Integer = 0
#End Region

#Region "Memindahkan paddle menurut mouse yang digerakkan"
    Private Sub pongMain_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Y > 5 And e.Y < Me.Height - 40 - paddlePlayer.Height Then
            paddlePlayer.Location = New Point(paddlePlayer.Location.X, e.Y)
        End If
    End Sub
#End Region

#Region "Main Timer"
    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        If gameBall.Location.Y > 5 And gameBall.Location.Y < Me.Height - 40 - paddlePlayer.Height Then
            paddleComputer.Location = New Point(paddleComputer.Location.X, gameBall.Location.Y)
        End If
        'memindahkan bola
        gameBall.Location = New Point(CInt(gameBall.Location.X + xVel), CInt(gameBall.Location.Y + yVel))

        'cek dari atas
        If gameBall.Location.Y < 0 Then
            gameBall.Location = New Point(gameBall.Location.X, 0)
            yVel = -yVel
        End If

        'cek dari bawah
        If gameBall.Location.Y > Me.Height - gameBall.Size.Height - 45 Then
            gameBall.Location = New Point(gameBall.Location.X, Me.Height - gameBall.Size.Height - 45)
            yVel = -yVel
        End If

        'cek player
        If gameBall.Bounds.IntersectsWith(paddlePlayer.Bounds) Then
            gameBall.Location = New Point(paddlePlayer.Location.X - gameBall.Size.Width, gameBall.Location.Y)
            xVel = -xVel
        End If

        'cek computer
        If gameBall.Bounds.IntersectsWith(paddleComputer.Bounds) Then
            gameBall.Location = New Point(paddleComputer.Location.X + paddleComputer.Size.Width + 1, gameBall.Location.Y)
            xVel = -xVel
        End If

        'cek dari samping kiri
        If gameBall.Location.X < 0 Then
            playScore += 1
            gameBall.Location = New Point(CInt(Me.Size.Width / 2), CInt(Me.Size.Height / 2))
            playerScoreDraw.Text = Convert.ToString(playScore)
        End If

        'cek dari samping kanan
        If gameBall.Location.X > Me.Height - gameBall.Size.Width - paddlePlayer.Width Then
            compScore += 1
            gameBall.Location = New Point(CInt(Me.Size.Width / 2), CInt(Me.Size.Height / 2))
            compScoreDraw.Text = Convert.ToString(compScore)
        End If
    End Sub
#End Region

#Region "Menyembunyikan kursor"
    Private Sub pongMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Windows.Forms.Cursor.Hide()
    End Sub
#End Region

#Region "Akhir Game"
    Private Sub pongMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Escape Then
            Me.Close()
        End If
    End Sub
#End Region

#Region "Paddle dan score akan tetap walaupun ukuran form diubah"
    Private Sub pongMain_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        paddlePlayer.Location = New Point(Me.Width - 44, paddlePlayer.Location.Y)
        playerScoreDraw.Location = New Point(Me.Width - 54, playerScoreDraw.Location.Y)
    End Sub
#End Region

End Class
