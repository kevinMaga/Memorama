Public Class FrmSiguiente2

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

        FrmNivel2.PictureBox1.Visible = False
        FrmNivel2.PictureBox2.Visible = False
        FrmNivel2.PictureBox3.Visible = False
        FrmNivel2.PictureBox4.Visible = False
        FrmNivel2.PictureBox5.Visible = False
        FrmNivel2.PictureBox6.Visible = False
        FrmNivel2.PictureBox7.Visible = False
        FrmNivel2.PictureBox8.Visible = False
        FrmNivel2.PictureBox9.Visible = False
        FrmNivel2.PictureBox10.Visible = False
        FrmNivel2.PictureBox11.Visible = False
        FrmNivel2.PictureBox12.Visible = False
        FrmNivel2.PictureBox13.Visible = False
        FrmNivel2.PictureBox14.Visible = False
        FrmNivel2.PictureBox15.Visible = False
        FrmNivel2.PictureBox16.Visible = False

        FrmNivel2.PictureBox1.Enabled = False
        FrmNivel2.PictureBox2.Enabled = False
        FrmNivel2.PictureBox3.Enabled = False
        FrmNivel2.PictureBox4.Enabled = False
        FrmNivel2.PictureBox5.Enabled = False
        FrmNivel2.PictureBox6.Enabled = False
        FrmNivel2.PictureBox7.Enabled = False
        FrmNivel2.PictureBox8.Enabled = False
        FrmNivel2.PictureBox9.Enabled = False
        FrmNivel2.PictureBox10.Enabled = False
        FrmNivel2.PictureBox11.Enabled = False
        FrmNivel2.PictureBox12.Enabled = False
        FrmNivel2.PictureBox13.Enabled = False
        FrmNivel2.PictureBox14.Enabled = False
        FrmNivel2.PictureBox15.Enabled = False
        FrmNivel2.PictureBox16.Enabled = False

        FrmNivel2.GroupBox1.Enabled = False
        FrmNivel2.tim_conteo.Enabled = False
        FrmNivel2.LblConteo.Text = "40"

        FrmNivel3.Show()
        Me.Hide()

        FrmMenu.AxWindowsMediaPlayer1.Ctlcontrols.play()
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub LblMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblMenu.Click

        FrmNivel2.PictureBox1.Visible = False
        FrmNivel2.PictureBox2.Visible = False
        FrmNivel2.PictureBox3.Visible = False
        FrmNivel2.PictureBox4.Visible = False
        FrmNivel2.PictureBox5.Visible = False
        FrmNivel2.PictureBox6.Visible = False
        FrmNivel2.PictureBox7.Visible = False
        FrmNivel2.PictureBox8.Visible = False
        FrmNivel2.PictureBox9.Visible = False
        FrmNivel2.PictureBox10.Visible = False
        FrmNivel2.PictureBox11.Visible = False
        FrmNivel2.PictureBox12.Visible = False
        FrmNivel2.PictureBox13.Visible = False
        FrmNivel2.PictureBox14.Visible = False
        FrmNivel2.PictureBox15.Visible = False
        FrmNivel2.PictureBox16.Visible = False

        FrmNivel2.PictureBox1.Enabled = False
        FrmNivel2.PictureBox2.Enabled = False
        FrmNivel2.PictureBox3.Enabled = False
        FrmNivel2.PictureBox4.Enabled = False
        FrmNivel2.PictureBox5.Enabled = False
        FrmNivel2.PictureBox6.Enabled = False
        FrmNivel2.PictureBox7.Enabled = False
        FrmNivel2.PictureBox8.Enabled = False
        FrmNivel2.PictureBox9.Enabled = False
        FrmNivel2.PictureBox10.Enabled = False
        FrmNivel2.PictureBox11.Enabled = False
        FrmNivel2.PictureBox12.Enabled = False
        FrmNivel2.PictureBox13.Enabled = False
        FrmNivel2.PictureBox14.Enabled = False
        FrmNivel2.PictureBox15.Enabled = False
        FrmNivel2.PictureBox16.Enabled = False

        FrmNivel2.GroupBox1.Enabled = False
        FrmNivel2.tim_conteo.Enabled = False
        FrmNivel2.LblConteo.Text = "40"

        FrmMenu.Show()
        Me.Hide()

        FrmMenu.AxWindowsMediaPlayer1.Ctlcontrols.play()
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub FrmSiguiente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.URL = My.Application.Info.DirectoryPath & "/musicas/Ganaste.mp3"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        FrmMenu.AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub
End Class