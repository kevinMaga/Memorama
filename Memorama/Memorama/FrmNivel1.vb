Public Class FrmNivel1
    Dim Aciertos As Byte
    Dim Fallas As Byte
    Dim clic As Byte
    Dim Img_Act As String
    Dim Ele_Act As Byte
    Dim Img_Nue As String
    Dim Ele_Nue As Byte
    Dim Max As Integer
    Dim segundos As Byte

    Private Function Aleatorio1(ByVal minimo As Long, ByVal maximo As Long) As Long
        Randomize()
        Aleatorio1 = CLng((minimo - maximo) * Rnd() + maximo)
    End Function

    Sub ver_pareja()

        If Img_Nue = Img_Act Then

            Aciertos = Aciertos + 1

            If Aciertos = Max Then
                FrmSiguiente.Show()
                Me.Hide()
                tim_conteo.Enabled = False
            End If


            Select Case (Ele_Nue)
                Case 1 : PictureBox1.Enabled = False
                Case 2 : PictureBox2.Enabled = False
                Case 3 : PictureBox3.Enabled = False
                Case 4 : PictureBox4.Enabled = False
                Case 5 : PictureBox5.Enabled = False
                Case 6 : PictureBox6.Enabled = False
                Case 7 : PictureBox7.Enabled = False
                Case 8 : PictureBox8.Enabled = False

            End Select
            Select Case (Ele_Act)
                Case 1 : PictureBox1.Enabled = False
                Case 2 : PictureBox2.Enabled = False
                Case 3 : PictureBox3.Enabled = False
                Case 4 : PictureBox4.Enabled = False
                Case 5 : PictureBox5.Enabled = False
                Case 6 : PictureBox6.Enabled = False
                Case 7 : PictureBox7.Enabled = False
                Case 8 : PictureBox8.Enabled = False
            End Select
        Else
            Gbx1.Enabled = False
            tim_verparejas.Enabled = True
        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Select Case PictureBox1.Tag
            Case "1" : PictureBox1.Image = My.Resources.img1
            Case "2" : PictureBox1.Image = My.Resources.img2
            Case "3" : PictureBox1.Image = My.Resources.img3
            Case "4" : PictureBox1.Image = My.Resources.img4
            Case "5" : PictureBox1.Image = My.Resources.img5
            Case "6" : PictureBox1.Image = My.Resources.img6
            Case "7" : PictureBox1.Image = My.Resources.img7
            Case "8" : PictureBox1.Image = My.Resources.imgn8
            Case Else : MsgBox("Ninguno" & PictureBox1.Tag)
        End Select

        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox1.Tag
            Ele_Act = 1
        Else
            clic = 0
            Img_Nue = PictureBox1.Tag
            Ele_Nue = 1
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Select Case PictureBox2.Tag
            Case "1" : PictureBox2.Image = My.Resources.img1
            Case "2" : PictureBox2.Image = My.Resources.img2
            Case "3" : PictureBox2.Image = My.Resources.img3
            Case "4" : PictureBox2.Image = My.Resources.img4
            Case "5" : PictureBox2.Image = My.Resources.img5
            Case "6" : PictureBox2.Image = My.Resources.img6
            Case "7" : PictureBox2.Image = My.Resources.img7
            Case "8" : PictureBox2.Image = My.Resources.imgn8
            Case Else : MsgBox("Ninguno" & PictureBox2.Tag)
        End Select

        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox2.Tag
            Ele_Act = 2
        Else
            clic = 0
            Img_Nue = PictureBox2.Tag
            Ele_Nue = 2
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Select Case PictureBox3.Tag
            Case "1" : PictureBox3.Image = My.Resources.img1
            Case "2" : PictureBox3.Image = My.Resources.img2
            Case "3" : PictureBox3.Image = My.Resources.img3
            Case "4" : PictureBox3.Image = My.Resources.img4
            Case "5" : PictureBox3.Image = My.Resources.img5
            Case "6" : PictureBox3.Image = My.Resources.img6
            Case "7" : PictureBox3.Image = My.Resources.img7
            Case "8" : PictureBox3.Image = My.Resources.imgn8
            Case Else : MsgBox("Ninguno" & PictureBox3.Tag)
        End Select

        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox3.Tag
            Ele_Act = 3
        Else
            clic = 0
            Img_Nue = PictureBox3.Tag
            Ele_Nue = 3
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Select Case PictureBox4.Tag
            Case "1" : PictureBox4.Image = My.Resources.img1
            Case "2" : PictureBox4.Image = My.Resources.img2
            Case "3" : PictureBox4.Image = My.Resources.img3
            Case "4" : PictureBox4.Image = My.Resources.img4
            Case "5" : PictureBox4.Image = My.Resources.img5
            Case "6" : PictureBox4.Image = My.Resources.img6
            Case "7" : PictureBox4.Image = My.Resources.img7
            Case "8" : PictureBox4.Image = My.Resources.imgn8
            Case Else : MsgBox("Ninguno" & PictureBox4.Tag)
        End Select

        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox4.Tag
            Ele_Act = 4
        Else
            clic = 0
            Img_Nue = PictureBox4.Tag
            Ele_Nue = 4
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Select Case PictureBox5.Tag
            Case "1" : PictureBox5.Image = My.Resources.img1
            Case "2" : PictureBox5.Image = My.Resources.img2
            Case "3" : PictureBox5.Image = My.Resources.img3
            Case "4" : PictureBox5.Image = My.Resources.img4
            Case "5" : PictureBox5.Image = My.Resources.img5
            Case "6" : PictureBox5.Image = My.Resources.img6
            Case "7" : PictureBox5.Image = My.Resources.img7
            Case "8" : PictureBox5.Image = My.Resources.imgn8
            Case Else : MsgBox("Ninguno" & PictureBox5.Tag)
        End Select

        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox5.Tag
            Ele_Act = 5
        Else
            clic = 0
            Img_Nue = PictureBox5.Tag
            Ele_Nue = 5
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Select Case PictureBox6.Tag
            Case "1" : PictureBox6.Image = My.Resources.img1
            Case "2" : PictureBox6.Image = My.Resources.img2
            Case "3" : PictureBox6.Image = My.Resources.img3
            Case "4" : PictureBox6.Image = My.Resources.img4
            Case "5" : PictureBox6.Image = My.Resources.img5
            Case "6" : PictureBox6.Image = My.Resources.img6
            Case "7" : PictureBox6.Image = My.Resources.img7
            Case "8" : PictureBox6.Image = My.Resources.imgn8
            Case Else : MsgBox("Ninguno" & PictureBox6.Tag)
        End Select

        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox6.Tag
            Ele_Act = 6
        Else
            clic = 0
            Img_Nue = PictureBox6.Tag
            Ele_Nue = 6
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Select Case PictureBox7.Tag
            Case "1" : PictureBox7.Image = My.Resources.img1
            Case "2" : PictureBox7.Image = My.Resources.img2
            Case "3" : PictureBox7.Image = My.Resources.img3
            Case "4" : PictureBox7.Image = My.Resources.img4
            Case "5" : PictureBox7.Image = My.Resources.img5
            Case "6" : PictureBox7.Image = My.Resources.img6
            Case "7" : PictureBox7.Image = My.Resources.img7
            Case "8" : PictureBox7.Image = My.Resources.imgn8
            Case Else : MsgBox("Ninguno" & PictureBox7.Tag)
        End Select

        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox7.Tag
            Ele_Act = 7
        Else
            clic = 0
            Img_Nue = PictureBox7.Tag
            Ele_Nue = 7
            ver_pareja()
        End If
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Select Case PictureBox8.Tag
            Case "1" : PictureBox8.Image = My.Resources.img1
            Case "2" : PictureBox8.Image = My.Resources.img2
            Case "3" : PictureBox8.Image = My.Resources.img3
            Case "4" : PictureBox8.Image = My.Resources.img4
            Case "5" : PictureBox8.Image = My.Resources.img5
            Case "6" : PictureBox8.Image = My.Resources.img6
            Case "7" : PictureBox8.Image = My.Resources.img7
            Case "8" : PictureBox8.Image = My.Resources.imgn8
            Case Else : MsgBox("Ninguno" & PictureBox8.Tag)
        End Select

        If clic = 0 Then
            clic = 1
            Img_Act = PictureBox8.Tag
            Ele_Act = 8
        Else
            clic = 0
            Img_Nue = PictureBox8.Tag
            Ele_Nue = 8
            ver_pareja()
        End If
    End Sub

    Private Sub tim_verparejas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tim_verparejas.Tick
        segundos = segundos + 1
        If segundos >= 3 Then
            tim_verparejas.Enabled = False
            segundos = 0
            Gbx1.Enabled = True
            Select Case (Ele_Nue)
                Case 1 : PictureBox1.Image = My.Resources.signo
                Case 2 : PictureBox2.Image = My.Resources.signo
                Case 3 : PictureBox3.Image = My.Resources.signo
                Case 4 : PictureBox4.Image = My.Resources.signo
                Case 5 : PictureBox5.Image = My.Resources.signo
                Case 6 : PictureBox6.Image = My.Resources.signo
                Case 7 : PictureBox7.Image = My.Resources.signo
                Case 8 : PictureBox8.Image = My.Resources.signo

            End Select
            Select Case (Ele_Act)
                Case 1 : PictureBox1.Image = My.Resources.signo
                Case 2 : PictureBox2.Image = My.Resources.signo
                Case 3 : PictureBox3.Image = My.Resources.signo
                Case 4 : PictureBox4.Image = My.Resources.signo
                Case 5 : PictureBox5.Image = My.Resources.signo
                Case 6 : PictureBox6.Image = My.Resources.signo
                Case 7 : PictureBox7.Image = My.Resources.signo
                Case 8 : PictureBox8.Image = My.Resources.signo

            End Select
        End If
    End Sub

    Private Sub tim_conteo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tim_conteo.Tick
        LblConteo.Text = LblConteo.Text - 1
        If LblConteo.Text = "0" Then
            tim_conteo.Enabled = False
            FrmPerdiste3.Show()
        End If
    End Sub

    Private Sub PbxJugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxJugar.Click
        LblConteo.Text = "20"
        tim_conteo.Enabled = True


        If PbxJugar.Enabled = True Then
            PictureBox1.Enabled = True
            PictureBox2.Enabled = True
            PictureBox3.Enabled = True
            PictureBox4.Enabled = True
            PictureBox5.Enabled = True
            PictureBox6.Enabled = True
            PictureBox7.Enabled = True
            PictureBox8.Enabled = True

            PictureBox1.Image = My.Resources.signo
            PictureBox2.Image = My.Resources.signo
            PictureBox3.Image = My.Resources.signo
            PictureBox4.Image = My.Resources.signo
            PictureBox5.Image = My.Resources.signo
            PictureBox6.Image = My.Resources.signo
            PictureBox7.Image = My.Resources.signo
            PictureBox8.Image = My.Resources.signo

            PictureBox1.Show()
            PictureBox2.Show()
            PictureBox3.Show()
            PictureBox4.Show()
            PictureBox5.Show()
            PictureBox6.Show()
            PictureBox7.Show()
            PictureBox8.Show()
            Randomize()

            Dim i, j As Integer
            Dim pareja As Integer
            Dim conta As Integer
            Dim vec(16) As Integer
            ListBox1.Items.Clear()

            Max = 4
            For i = 1 To Max * 2
                vec(i) = 0
            Next
            i = 1
            Do While i <= Max * 2
                pareja = Rnd() * Max + 1
                If pareja <= Max Then
                    conta = 0
                    For j = 1 To Max * 2
                        If vec(j) = pareja Then
                            conta = conta + 1
                        End If
                    Next
                    If conta < 2 Then
                        vec(i) = pareja
                        ListBox1.Items.Add(i & " " & vec(i) & "con" & conta)
                        i = i + 1
                    End If
                End If
            Loop

            PictureBox1.Tag = vec(1)
            PictureBox2.Tag = vec(2)
            PictureBox3.Tag = vec(3)
            PictureBox4.Tag = vec(4)
            PictureBox5.Tag = vec(5)
            PictureBox6.Tag = vec(6)
            PictureBox7.Tag = vec(7)
            PictureBox8.Tag = vec(8)

            clic = 0
            Aciertos = 0
            Fallas = 0
            Max = 4
            Gbx1.Enabled = True
        End If
    End Sub

    Private Sub PbxJugar_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxJugar.MouseEnter
        My.Computer.Audio.Play(My.Resources.interaccion, AudioPlayMode.Background)
        PbxJugar.Height = 80
        PbxJugar.Width = 260
    End Sub

    Private Sub PbxJugar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PbxJugar.MouseLeave
        My.Computer.Audio.Stop()
        PbxJugar.Height = 69
        PbxJugar.Width = 245
    End Sub

    Private Sub PbxSal_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxSal.MouseEnter
        My.Computer.Audio.Play(My.Resources.interaccion, AudioPlayMode.Background)
        PbxSal.Height = 80
        PbxSal.Width = 260
    End Sub

    Private Sub PbxSal_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PbxSal.MouseLeave
        My.Computer.Audio.Stop()
        PbxSal.Height = 69
        PbxSal.Width = 245
    End Sub

    Private Sub PbxVol1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxVol1.Click
        If PbxVol1.Visible = True And PbxVol1.Enabled = True Then

            FrmMenu.AxWindowsMediaPlayer1.Ctlcontrols.pause()
            PbxVol2.Enabled = True
            PbxVol2.Visible = True
            PbxVol1.Visible = False
            PbxVol1.Enabled = False
        End If
    End Sub

    Private Sub PbxVol2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxVol2.Click
        If PbxVol2.Visible = True And PbxVol2.Enabled = True Then

            FrmMenu.AxWindowsMediaPlayer1.Ctlcontrols.play()
            PbxVol1.Enabled = True
            PbxVol1.Visible = True
            PbxVol2.Visible = False
            PbxVol2.Enabled = False
        End If
    End Sub

    Private Sub PbxOpcio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxOpcio.Click
        FrmOp.Show()
        tim_conteo.Enabled = False
    End Sub

    Private Sub PbxSal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxSal.Click
        tim_conteo.Enabled = False
        salir4a.Show()
    End Sub
End Class