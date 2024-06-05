<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class opciones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblMusica1 = New System.Windows.Forms.Label()
        Me.LblMusica2 = New System.Windows.Forms.Label()
        Me.LblMusica3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape5, Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(284, 342)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BackColor = System.Drawing.Color.Fuchsia
        Me.RectangleShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape5.BorderColor = System.Drawing.Color.Purple
        Me.RectangleShape5.BorderWidth = 3
        Me.RectangleShape5.CornerRadius = 15
        Me.RectangleShape5.Location = New System.Drawing.Point(113, 274)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(58, 44)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BackColor = System.Drawing.Color.Fuchsia
        Me.RectangleShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape4.BorderColor = System.Drawing.Color.Purple
        Me.RectangleShape4.BorderWidth = 3
        Me.RectangleShape4.CornerRadius = 15
        Me.RectangleShape4.Location = New System.Drawing.Point(45, 201)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(195, 44)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.Fuchsia
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.BorderColor = System.Drawing.Color.Purple
        Me.RectangleShape3.BorderWidth = 3
        Me.RectangleShape3.CornerRadius = 15
        Me.RectangleShape3.Location = New System.Drawing.Point(45, 134)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(195, 44)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.Fuchsia
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Purple
        Me.RectangleShape2.BorderWidth = 3
        Me.RectangleShape2.CornerRadius = 15
        Me.RectangleShape2.Location = New System.Drawing.Point(45, 66)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(195, 44)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.RectangleShape1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.Violet
        Me.RectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal
        Me.RectangleShape1.Location = New System.Drawing.Point(21, 51)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(242, 210)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(35, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MUSICAS DEL JUEGO"
        '
        'LblMusica1
        '
        Me.LblMusica1.AutoSize = True
        Me.LblMusica1.BackColor = System.Drawing.Color.Fuchsia
        Me.LblMusica1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMusica1.ForeColor = System.Drawing.Color.Yellow
        Me.LblMusica1.Location = New System.Drawing.Point(88, 76)
        Me.LblMusica1.Name = "LblMusica1"
        Me.LblMusica1.Size = New System.Drawing.Size(109, 26)
        Me.LblMusica1.TabIndex = 2
        Me.LblMusica1.Text = "MUSICA 1"
        '
        'LblMusica2
        '
        Me.LblMusica2.AutoSize = True
        Me.LblMusica2.BackColor = System.Drawing.Color.Fuchsia
        Me.LblMusica2.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMusica2.ForeColor = System.Drawing.Color.Yellow
        Me.LblMusica2.Location = New System.Drawing.Point(90, 143)
        Me.LblMusica2.Name = "LblMusica2"
        Me.LblMusica2.Size = New System.Drawing.Size(109, 26)
        Me.LblMusica2.TabIndex = 3
        Me.LblMusica2.Text = "MUSICA 2"
        '
        'LblMusica3
        '
        Me.LblMusica3.AutoSize = True
        Me.LblMusica3.BackColor = System.Drawing.Color.Fuchsia
        Me.LblMusica3.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMusica3.ForeColor = System.Drawing.Color.Yellow
        Me.LblMusica3.Location = New System.Drawing.Point(90, 210)
        Me.LblMusica3.Name = "LblMusica3"
        Me.LblMusica3.Size = New System.Drawing.Size(109, 26)
        Me.LblMusica3.TabIndex = 4
        Me.LblMusica3.Text = "MUSICA 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Fuchsia
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(130, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 26)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "<"
        '
        'opciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(284, 342)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblMusica3)
        Me.Controls.Add(Me.LblMusica2)
        Me.Controls.Add(Me.LblMusica1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "opciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "opciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents LblMusica1 As System.Windows.Forms.Label
    Friend WithEvents LblMusica2 As System.Windows.Forms.Label
    Friend WithEvents LblMusica3 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
