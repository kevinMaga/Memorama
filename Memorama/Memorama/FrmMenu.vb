Public Class FrmMenu



    Private Sub Pbxvolumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbxvolumen1.Click

        If Pbxvolumen1.Visible = True And Pbxvolumen1.Enabled = True Then

            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            Pbxvolumen2.Enabled = True
            Pbxvolumen2.Visible = True
            Pbxvolumen1.Visible = False
            Pbxvolumen1.Enabled = False

        End If
    End Sub

    Private Sub Pbxvolumen2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbxvolumen2.Click

        If Pbxvolumen2.Visible = True And Pbxvolumen2.Enabled = True Then

            AxWindowsMediaPlayer1.Ctlcontrols.play()
            Pbxvolumen1.Enabled = True
            Pbxvolumen1.Visible = True
            Pbxvolumen2.Visible = False
            Pbxvolumen2.Enabled = False
        End If

    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter

        My.Computer.Audio.Play(My.Resources.interaccion, AudioPlayMode.Background)

        PictureBox1.Height = 80
        PictureBox1.Width = 260

        '245; 69
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        My.Computer.Audio.Stop()
        PictureBox1.Height = 69
        PictureBox1.Width = 245
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        My.Computer.Audio.Play(My.Resources.interaccion, AudioPlayMode.Background)
        PictureBox2.Height = 80
        PictureBox2.Width = 260
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        My.Computer.Audio.Stop()
        PictureBox2.Height = 69
        PictureBox2.Width = 245
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        My.Computer.Audio.Play(My.Resources.interaccion, AudioPlayMode.Background)
        PictureBox3.Height = 80
        PictureBox3.Width = 260
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        My.Computer.Audio.Stop()
        PictureBox3.Height = 69
        PictureBox3.Width = 245
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Salir.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        opciones.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblHora.Text = TimeOfDay
        LblCambio.Text += 1
        If LblCambio.Text = 160 Then
            LblCambio.Text = "0"
        End If


    End Sub

    Private Sub LblCambio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblCambio.TextChanged

        Dim cambiar As VariantType
        cambiar = LblCambio.Text
        Select Case cambiar
            Case 21 To 80
                BackgroundImage = My.Resources.Fondo2
            Case 81 To 120
                BackgroundImage = My.Resources.Fondo3

            Case 121 To 160
                BackgroundImage = My.Resources.Fondo1

        End Select
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        FrmNiveles.BackgroundImage = BackgroundImage
        FrmNivel2.BackgroundImage = BackgroundImage
        FrmNiveles.Show()
        Me.Hide()

    End Sub

    Private Sub FrmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AxWindowsMediaPlayer1.settings.setMode("loop", True)
        AxWindowsMediaPlayer1.URL = My.Application.Info.DirectoryPath & "/musicas/musica1.mp3"

        Timer1.Start()


    End Sub
End Class
