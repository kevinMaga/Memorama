Public Class FrmPerdiste

    Private Sub LblVolver_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblVolver.MouseEnter
        LblVolver.Font = New Font("Swis721 Cn BT", 12.5, FontStyle.Underline)
    End Sub

    Private Sub LblVolver_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblVolver.MouseLeave
        LblVolver.Font = New Font("Swis721 Cn BT", 12.5, FontStyle.Regular)
    End Sub

    Private Sub LblMenu_MouseEnter(sender As System.Object, e As System.EventArgs) Handles LblMenu.MouseEnter
        LblMenu.Font = New Font("Swis721 Cn BT", 12.5, FontStyle.Underline)
    End Sub

    Private Sub LblMenu_MouseLeave(sender As Object, e As System.EventArgs) Handles LblMenu.MouseLeave
        LblMenu.Font = New Font("Swis721 Cn BT", 12.5, FontStyle.Regular)
    End Sub

    Private Sub LblVolver_Click(sender As System.Object, e As System.EventArgs) Handles LblVolver.Click
        FrmNivel3.Pbx1.Image = Nothing
        FrmNivel3.Pbx2.Image = Nothing
        FrmNivel3.Pbx3.Image = Nothing
        FrmNivel3.Pbx4.Image = Nothing
        FrmNivel3.Pbx5.Image = Nothing
        FrmNivel3.Pbx6.Image = Nothing
        FrmNivel3.Pbx7.Image = Nothing
        FrmNivel3.Pbx8.Image = Nothing
        FrmNivel3.Pbx9.Image = Nothing
        FrmNivel3.Pbx10.Image = Nothing
        FrmNivel3.Pbx11.Image = Nothing
        FrmNivel3.Pbx12.Image = Nothing
        FrmNivel3.Pbx13.Image = Nothing
        FrmNivel3.Pbx14.Image = Nothing
        FrmNivel3.Pbx15.Image = Nothing
        FrmNivel3.Pbx16.Image = Nothing
        FrmNivel3.Pbx17.Image = Nothing
        FrmNivel3.Pbx18.Image = Nothing
        FrmNivel3.Pbx19.Image = Nothing
        FrmNivel3.Pbx20.Image = Nothing
        FrmNivel3.Pbx21.Image = Nothing
        FrmNivel3.Pbx22.Image = Nothing
        FrmNivel3.Pbx23.Image = Nothing
        FrmNivel3.Pbx24.Image = Nothing

        FrmNivel3.GroupBox1.Enabled = False
        FrmNivel3.TimConteo.Enabled = False
        FrmNivel3.LblConteo.Text = "60"
        FrmNivel3.Show()
        Me.Hide()

        FrmMenu.AxWindowsMediaPlayer1.Ctlcontrols.play()
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub LblMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblMenu.Click
        FrmNivel3.Pbx1.Image = Nothing
        FrmNivel3.Pbx2.Image = Nothing
        FrmNivel3.Pbx3.Image = Nothing
        FrmNivel3.Pbx4.Image = Nothing
        FrmNivel3.Pbx5.Image = Nothing
        FrmNivel3.Pbx6.Image = Nothing
        FrmNivel3.Pbx7.Image = Nothing
        FrmNivel3.Pbx8.Image = Nothing
        FrmNivel3.Pbx9.Image = Nothing
        FrmNivel3.Pbx10.Image = Nothing
        FrmNivel3.Pbx11.Image = Nothing
        FrmNivel3.Pbx12.Image = Nothing
        FrmNivel3.Pbx13.Image = Nothing
        FrmNivel3.Pbx14.Image = Nothing
        FrmNivel3.Pbx15.Image = Nothing
        FrmNivel3.Pbx16.Image = Nothing
        FrmNivel3.Pbx17.Image = Nothing
        FrmNivel3.Pbx18.Image = Nothing
        FrmNivel3.Pbx19.Image = Nothing
        FrmNivel3.Pbx20.Image = Nothing
        FrmNivel3.Pbx21.Image = Nothing
        FrmNivel3.Pbx22.Image = Nothing
        FrmNivel3.Pbx23.Image = Nothing
        FrmNivel3.Pbx24.Image = Nothing

        FrmNivel3.GroupBox1.Enabled = False
        FrmNivel3.TimConteo.Enabled = False
        FrmNivel3.LblConteo.Text = "60"
        FrmNiveles.Show()
        FrmNivel3.Hide()
        Me.Hide()

        FrmMenu.AxWindowsMediaPlayer1.Ctlcontrols.play()
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub
    Private Sub FrmPerdiste_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.URL = My.Application.Info.DirectoryPath & "/musicas/Perdiste.mp3"
        FrmMenu.AxWindowsMediaPlayer1.Ctlcontrols.pause()
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub


    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click

    End Sub
End Class