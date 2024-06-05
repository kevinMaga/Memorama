Public Class salir4a

    Private Sub LblSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblSi.Click
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


        FrmNiveles.Show()
        Me.Hide()
        FrmNivel1.Hide()
    End Sub

    Private Sub LblNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblNo.Click
        FrmNivel1.tim_conteo.Enabled = True
        FrmNivel1.Show()

        Me.Hide()
    End Sub
End Class