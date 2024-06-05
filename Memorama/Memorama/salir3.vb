Public Class salir3

    Private Sub LblSi_Click(sender As System.Object, e As System.EventArgs) Handles LblSi.Click
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
        Me.Hide()
        FrmNivel3.Hide()
    End Sub

    Private Sub LblNo_Click(sender As System.Object, e As System.EventArgs) Handles LblNo.Click
        FrmNivel3.TimConteo.Enabled = True
        FrmNivel3.Show()

        Me.Hide()
    End Sub
End Class