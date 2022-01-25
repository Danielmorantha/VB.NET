<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BoxNmaAdm = New System.Windows.Forms.TextBox()
        Me.BoxPwAdm = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TmblMsk = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(84, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Pengguna"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(84, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kata Sandi"
        '
        'BoxNmaAdm
        '
        Me.BoxNmaAdm.Location = New System.Drawing.Point(294, 195)
        Me.BoxNmaAdm.Name = "BoxNmaAdm"
        Me.BoxNmaAdm.Size = New System.Drawing.Size(200, 31)
        Me.BoxNmaAdm.TabIndex = 2
        '
        'BoxPwAdm
        '
        Me.BoxPwAdm.Location = New System.Drawing.Point(294, 259)
        Me.BoxPwAdm.Name = "BoxPwAdm"
        Me.BoxPwAdm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.BoxPwAdm.Size = New System.Drawing.Size(200, 31)
        Me.BoxPwAdm.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(319, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 119)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'TmblMsk
        '
        Me.TmblMsk.BackColor = System.Drawing.Color.Silver
        Me.TmblMsk.Location = New System.Drawing.Point(336, 315)
        Me.TmblMsk.Name = "TmblMsk"
        Me.TmblMsk.Size = New System.Drawing.Size(112, 34)
        Me.TmblMsk.TabIndex = 5
        Me.TmblMsk.Text = "Masuk"
        Me.TmblMsk.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(594, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 32)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "X"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(649, 436)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TmblMsk)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BoxPwAdm)
        Me.Controls.Add(Me.BoxNmaAdm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BoxNmaAdm As TextBox
    Friend WithEvents BoxPwAdm As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TmblMsk As Button
    Friend WithEvents Label4 As Label
End Class
