<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNiveles
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNiveles))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PbxNivel3 = New System.Windows.Forms.PictureBox()
        Me.PbxNivel1 = New System.Windows.Forms.PictureBox()
        Me.PbxNivel2 = New System.Windows.Forms.PictureBox()
        Me.PbxAtras = New System.Windows.Forms.PictureBox()
        CType(Me.PbxNivel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxNivel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxNivel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxAtras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(205, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 31)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "SELECCION DE NIVELES"
        '
        'PbxNivel3
        '
        Me.PbxNivel3.BackColor = System.Drawing.Color.Transparent
        Me.PbxNivel3.Image = Global.Menu.My.Resources.Resources.cartel3
        Me.PbxNivel3.Location = New System.Drawing.Point(515, 114)
        Me.PbxNivel3.Name = "PbxNivel3"
        Me.PbxNivel3.Size = New System.Drawing.Size(213, 192)
        Me.PbxNivel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxNivel3.TabIndex = 19
        Me.PbxNivel3.TabStop = False
        '
        'PbxNivel1
        '
        Me.PbxNivel1.BackColor = System.Drawing.Color.Transparent
        Me.PbxNivel1.Image = CType(resources.GetObject("PbxNivel1.Image"), System.Drawing.Image)
        Me.PbxNivel1.Location = New System.Drawing.Point(29, 114)
        Me.PbxNivel1.Name = "PbxNivel1"
        Me.PbxNivel1.Size = New System.Drawing.Size(213, 192)
        Me.PbxNivel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxNivel1.TabIndex = 18
        Me.PbxNivel1.TabStop = False
        '
        'PbxNivel2
        '
        Me.PbxNivel2.BackColor = System.Drawing.Color.Transparent
        Me.PbxNivel2.Image = Global.Menu.My.Resources.Resources.cartel2
        Me.PbxNivel2.Location = New System.Drawing.Point(272, 114)
        Me.PbxNivel2.Name = "PbxNivel2"
        Me.PbxNivel2.Size = New System.Drawing.Size(213, 192)
        Me.PbxNivel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxNivel2.TabIndex = 17
        Me.PbxNivel2.TabStop = False
        '
        'PbxAtras
        '
        Me.PbxAtras.BackColor = System.Drawing.Color.Transparent
        Me.PbxAtras.Image = Global.Menu.My.Resources.Resources.Atras
        Me.PbxAtras.Location = New System.Drawing.Point(261, 354)
        Me.PbxAtras.Name = "PbxAtras"
        Me.PbxAtras.Size = New System.Drawing.Size(245, 69)
        Me.PbxAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxAtras.TabIndex = 15
        Me.PbxAtras.TabStop = False
        '
        'FrmNiveles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 468)
        Me.Controls.Add(Me.PbxNivel3)
        Me.Controls.Add(Me.PbxNivel1)
        Me.Controls.Add(Me.PbxNivel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PbxAtras)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmNiveles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmNiveles"
        CType(Me.PbxNivel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxNivel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxNivel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxAtras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PbxAtras As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PbxNivel2 As System.Windows.Forms.PictureBox
    Friend WithEvents PbxNivel1 As System.Windows.Forms.PictureBox
    Friend WithEvents PbxNivel3 As System.Windows.Forms.PictureBox
End Class
