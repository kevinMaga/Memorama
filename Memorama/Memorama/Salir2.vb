Public Class Salir2

    Private Sub LblSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblSi.Click
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
        FrmNivel2.LblConteo.Text = "30"

        FrmNiveles.Show()
        Me.Hide()
        FrmNivel2.Hide()

    End Sub

    Private Sub LblNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblNo.Click
        FrmNivel2.tim_conteo.Enabled = True
        FrmNivel2.Show()

        Me.Hide()
    End Sub
End Class