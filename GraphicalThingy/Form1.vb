Public Class Form1

    Dim Velocity As Double = 0.5
    Dim LRVelocity As Double = 0
    Dim LRDirection As Integer = 0
    Dim Xpos As Integer = 180
    Dim Ypos As Integer = 50
    Dim Thrust As Double = 0.5
    Dim EngineOn As Boolean = False
    Dim Key As Integer
    Private Physics As CPhysics
    Private Sub Screen_Paint(sender As Object, e As PaintEventArgs) Handles Screen.Paint

        Dim g As Graphics
        g = e.Graphics
        DrawCircle(g)

    End Sub
    Private Sub DrawCircle(g As Graphics)

        Dim PenA As Pen = New Pen(Brushes.OrangeRed, 2)
        g.DrawEllipse(PenA, Xpos, Ypos, 20, 20)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Decides whether the object is getting pulled up or down

        Gravity()

        UpThrust()
        LeftRight()
        Meter.Text = Velocity
        Screen.Refresh()
    End Sub


    Private Sub Gravity()
        'Increases Velocity over time exponentially

        'If Velocity < 15 And Velocity > 0 Then
        '    Velocity = (Velocity * 1.025) + 0.01
        'ElseIf EngineOn = False Then
        '    Velocity = (Velocity * 0.95) + 0.1
        'End If
        'Ypos = Ypos + Velocity
        'If Ypos > 420 Then
        '    Velocity = 0
        'End If
        If Velocity < 15 And Velocity > 0 Then
            Velocity = (Velocity * 1.025) + 0.01
        ElseIf EngineOn = False Then
            Velocity = (Velocity * 0.99) + 0.6
        End If
        Ypos = Ypos + Velocity
        If Ypos > 700 Then
            Velocity = 0
        End If

    End Sub
    Private Sub LeftRight()
        If LRDirection = 0 Then
            If LRVelocity > 0 Then
                Xpos = Xpos + LRVelocity
                LRVelocity = LRVelocity - 0.5
            ElseIf LRVelocity < 0 Then
                Xpos = Xpos + LRVelocity
                LRVelocity = LRVelocity + 0.5
            End If
        ElseIf LRDirection = 1 Then
            Xpos = Xpos + (LRVelocity + 2)
        ElseIf LRDirection = -1 Then
            Xpos = Xpos + (LRVelocity - 2)
        End If
    End Sub
    Private Sub UpThrust()
        'Gives Upward direction

        If EngineOn = True Then

            Velocity = Velocity - 0.25

        End If

    End Sub
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click

        Timer1.Enabled = True

    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click

        Timer1.Enabled = False

    End Sub
    'Exits the game

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        MessageBox.Show("Are you sure you want to exit?")
        End

    End Sub
    'Resets everything to the default value
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click

        Ypos = 50
        Xpos = 180
        Velocity = 0.5
        EngineOn = False
        Screen.Refresh()

    End Sub
    'Turns the upward thrust on or off with a button
    Private Sub EngineOnButton_Click(sender As Object, e As EventArgs) Handles EngineOnButton.Click

        EngineOn = True

    End Sub

    Private Sub EngineOffButton_Click(sender As Object, e As EventArgs) Handles EngineOffButton.Click

        EngineOn = False

    End Sub

    ''Supposed to add keyboard controls
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.W And EngineOn = False Then
            EngineOn = True
            Screen.Refresh()
        ElseIf e.KeyCode = Keys.A And LRDirection = 0 Then
            LRDirection = -1
        ElseIf e.KeyCode = Keys.D And LRDirection = 0 Then
            LRDirection = 1
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.W And EngineOn = True Then
            EngineOn = False
            Screen.Refresh()
        ElseIf e.KeyCode = Keys.A And LRDirection = -1 Then
            LRDirection = 0
        ElseIf e.KeyCode = Keys.D And LRDirection = 1 Then
            LRDirection = 0
        End If

    End Sub

End Class