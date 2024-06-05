Public Class FrmNiveles

    Private Sub FrmNiveles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PbxAtras_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxAtras.MouseEnter

        My.Computer.Audio.Play(My.Resources.interaccion, AudioPlayMode.Background)

        PbxAtras.Height = 80
        PbxAtras.Width = 260

    End Sub

    Private Sub PbxAtras_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PbxAtras.MouseLeave

        My.Computer.Audio.Stop()
        PbxAtras.Height = 69
        PbxAtras.Width = 245
    End Sub

    Private Sub PbxAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxAtras.Click
        FrmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Static color As Integer
        color = color + 1
        If color = 1 Then
            Label1.ForeColor = Drawing.Color.White
        ElseIf color = 2 Then
            Label1.ForeColor = Drawing.Color.Yellow
        ElseIf color = 3 Then
            Label1.ForeColor = Drawing.Color.Cyan
        ElseIf color = 4 Then
            Label1.ForeColor = Drawing.Color.GreenYellow
        Else : color = 5
            color = 0
        End If
    End Sub


    Private Sub PbxNivel1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxNivel1.MouseEnter
        My.Computer.Audio.Play(My.Resources.interaccion, AudioPlayMode.Background)

        PbxNivel1.Height = 200
        PbxNivel1.Width = 230

    End Sub

    Private Sub PbxNivel1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PbxNivel1.MouseLeave
        My.Computer.Audio.Stop()

        PbxNivel1.Height = 192
        PbxNivel1.Width = 213
    End Sub

    Private Sub PbxNivel2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxNivel2.MouseEnter
        My.Computer.Audio.Play(My.Resources.interaccion, AudioPlayMode.Background)

        PbxNivel2.Height = 200
        PbxNivel2.Width = 230
    End Sub

    Private Sub PbxNivel2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PbxNivel2.MouseLeave
        My.Computer.Audio.Stop()

        PbxNivel2.Height = 192
        PbxNivel2.Width = 213
    End Sub

    Private Sub PbxNivel3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxNivel3.MouseEnter
        My.Computer.Audio.Play(My.Resources.interaccion, AudioPlayMode.Background)

        PbxNivel3.Height = 200
        PbxNivel3.Width = 230
    End Sub

    Private Sub PbxNivel3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PbxNivel3.MouseLeave
        My.Computer.Audio.Stop()

        PbxNivel3.Height = 192
        PbxNivel3.Width = 213
    End Sub

    Private Sub PbxNivel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxNivel2.Click

        FrmNivel2.BackgroundImage = BackgroundImage
        FrmSeleccion.Show()
        FrmSeleccion.Label1.Text = "¿DESEA IR AL NIVEL 2?"
    End Sub

    Private Sub PbxNivel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxNivel1.Click

        FrmSeleccion.Show()
        FrmSeleccion.Label1.Text = "¿DESEA IR AL NIVEL 1?"
    End Sub

    Private Sub PbxNivel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxNivel3.Click

        FrmSeleccion.Show()
        FrmSeleccion.Label1.Text = "¿DESEA IR AL NIVEL 3?"

    End Sub
End Class