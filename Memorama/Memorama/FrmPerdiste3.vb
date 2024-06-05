Public Class FrmPerdiste3
    Private Sub LblVolver_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblVolver.MouseEnter
        LblVolver.Font = New Font("Swis721 Cn BT", 12.5, FontStyle.Underline)
    End Sub

    Private Sub LblVolver_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblVolver.MouseLeave
        LblVolver.Font = New Font("Swis721 Cn BT", 12.5, FontStyle.Regular)
    End Sub

    Private Sub LblMenu_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblMenu.MouseEnter
        LblMenu.Font = New Font("Swis721 Cn BT", 12.5, FontStyle.Underline)
    End Sub

    Private Sub LblMenu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblMenu.MouseLeave
        LblMenu.Font = New Font("Swis721 Cn BT", 12.5, FontStyle.Regular)
    End Sub

    Private Sub LblVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblVolver.Click
        FrmNivel1.PictureBox1.Image = Nothing
        FrmNivel1.PictureBox2.Image = Nothing
        FrmNivel1.PictureBox3.Image = Nothing
        FrmNivel1.PictureBox4.Image = Nothing
        FrmNivel1.PictureBox5.Image = Nothing
        FrmNivel1.PictureBox6.Image = Nothing
        FrmNivel1.PictureBox7.Image = Nothing
        FrmNivel1.PictureBox8.Image = Nothing

        FrmNivel1.Gbx1.Enabled = False
        FrmNivel1.tim_conteo.Enabled = False
        FrmNivel1.LblConteo.Text = "20"

        FrmMenu.AxWindowsMediaPlayer1.Ctlcontrols.play()
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
        FrmNivel1.Show()
        Me.Hide()

    End Sub

    Private Sub LblMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblMenu.Click
        FrmNivel1.PictureBox1.Image = Nothing
        FrmNivel1.PictureBox2.Image = Nothing
        FrmNivel1.PictureBox3.Image = Nothing
        FrmNivel1.PictureBox4.Image = Nothing
        FrmNivel1.PictureBox5.Image = Nothing
        FrmNivel1.PictureBox6.Image = Nothing
        FrmNivel1.PictureBox7.Image = Nothing
        FrmNivel1.PictureBox8.Image = Nothing

        FrmNivel1.Gbx1.Enabled = False
        FrmNivel1.tim_conteo.Enabled = False
        FrmNivel1.LblConteo.Text = "20"

        FrmMenu.AxWindowsMediaPlayer1.Ctlcontrols.play()
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
        FrmNiveles.Show()
        Me.Hide()
        FrmNivel1.Hide()
    End Sub

    Private Sub FrmPerdiste3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.URL = My.Application.Info.DirectoryPath & "/musicas/Perdiste.mp3"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        FrmMenu.AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click

    End Sub
End Class