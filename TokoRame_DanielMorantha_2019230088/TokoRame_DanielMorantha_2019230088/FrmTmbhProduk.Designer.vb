<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTmbhProduk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTmbhProduk))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TmblBersih = New System.Windows.Forms.Button()
        Me.TmblPencari = New System.Windows.Forms.Button()
        Me.BoxPencari = New System.Windows.Forms.TextBox()
        Me.CmbPencari = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TmblBrsihTlsn = New System.Windows.Forms.Button()
        Me.TmblHps = New System.Windows.Forms.Button()
        Me.TmblUbh = New System.Windows.Forms.Button()
        Me.TmblTmbh = New System.Windows.Forms.Button()
        Me.CmbKtgri = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BoxHrg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BoxNma = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BoxID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.TmblBersih)
        Me.Panel1.Controls.Add(Me.TmblPencari)
        Me.Panel1.Controls.Add(Me.BoxPencari)
        Me.Panel1.Controls.Add(Me.CmbPencari)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.TmblBrsihTlsn)
        Me.Panel1.Controls.Add(Me.TmblHps)
        Me.Panel1.Controls.Add(Me.TmblUbh)
        Me.Panel1.Controls.Add(Me.TmblTmbh)
        Me.Panel1.Controls.Add(Me.CmbKtgri)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.BoxHrg)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.BoxNma)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.BoxID)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(152, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(916, 780)
        Me.Panel1.TabIndex = 0
        '
        'TmblBersih
        '
        Me.TmblBersih.BackColor = System.Drawing.Color.Silver
        Me.TmblBersih.Location = New System.Drawing.Point(769, 334)
        Me.TmblBersih.Name = "TmblBersih"
        Me.TmblBersih.Size = New System.Drawing.Size(77, 34)
        Me.TmblBersih.TabIndex = 21
        Me.TmblBersih.Text = "Bersih"
        Me.TmblBersih.UseVisualStyleBackColor = False
        '
        'TmblPencari
        '
        Me.TmblPencari.BackColor = System.Drawing.Color.Silver
        Me.TmblPencari.Location = New System.Drawing.Point(693, 334)
        Me.TmblPencari.Name = "TmblPencari"
        Me.TmblPencari.Size = New System.Drawing.Size(69, 34)
        Me.TmblPencari.TabIndex = 20
        Me.TmblPencari.Text = "Cari"
        Me.TmblPencari.UseVisualStyleBackColor = False
        '
        'BoxPencari
        '
        Me.BoxPencari.Location = New System.Drawing.Point(539, 334)
        Me.BoxPencari.Name = "BoxPencari"
        Me.BoxPencari.Size = New System.Drawing.Size(148, 31)
        Me.BoxPencari.TabIndex = 19
        '
        'CmbPencari
        '
        Me.CmbPencari.FormattingEnabled = True
        Me.CmbPencari.Items.AddRange(New Object() {"ID_Produk", "Nama_Produk", "Harga", "Kategori_Produk"})
        Me.CmbPencari.Location = New System.Drawing.Point(471, 332)
        Me.CmbPencari.Name = "CmbPencari"
        Me.CmbPencari.Size = New System.Drawing.Size(61, 33)
        Me.CmbPencari.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Gold
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(365, 332)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Pencarian"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Location = New System.Drawing.Point(410, 698)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 53)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Cetak"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(82, 374)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(747, 318)
        Me.DataGridView1.TabIndex = 13
        '
        'TmblBrsihTlsn
        '
        Me.TmblBrsihTlsn.BackColor = System.Drawing.Color.Silver
        Me.TmblBrsihTlsn.Location = New System.Drawing.Point(658, 267)
        Me.TmblBrsihTlsn.Name = "TmblBrsihTlsn"
        Me.TmblBrsihTlsn.Size = New System.Drawing.Size(112, 34)
        Me.TmblBrsihTlsn.TabIndex = 12
        Me.TmblBrsihTlsn.Text = "Bersih"
        Me.TmblBrsihTlsn.UseVisualStyleBackColor = False
        '
        'TmblHps
        '
        Me.TmblHps.BackColor = System.Drawing.Color.Silver
        Me.TmblHps.Location = New System.Drawing.Point(500, 267)
        Me.TmblHps.Name = "TmblHps"
        Me.TmblHps.Size = New System.Drawing.Size(112, 34)
        Me.TmblHps.TabIndex = 11
        Me.TmblHps.Text = "Hapus"
        Me.TmblHps.UseVisualStyleBackColor = False
        '
        'TmblUbh
        '
        Me.TmblUbh.BackColor = System.Drawing.Color.Silver
        Me.TmblUbh.Location = New System.Drawing.Point(332, 267)
        Me.TmblUbh.Name = "TmblUbh"
        Me.TmblUbh.Size = New System.Drawing.Size(112, 34)
        Me.TmblUbh.TabIndex = 10
        Me.TmblUbh.Text = "Ubah"
        Me.TmblUbh.UseVisualStyleBackColor = False
        '
        'TmblTmbh
        '
        Me.TmblTmbh.BackColor = System.Drawing.Color.Silver
        Me.TmblTmbh.Location = New System.Drawing.Point(164, 267)
        Me.TmblTmbh.Name = "TmblTmbh"
        Me.TmblTmbh.Size = New System.Drawing.Size(112, 34)
        Me.TmblTmbh.TabIndex = 9
        Me.TmblTmbh.Text = "Tambah"
        Me.TmblTmbh.UseVisualStyleBackColor = False
        '
        'CmbKtgri
        '
        Me.CmbKtgri.FormattingEnabled = True
        Me.CmbKtgri.Items.AddRange(New Object() {"Kerupuk", "Minyak Goreng", "Es Krim"})
        Me.CmbKtgri.Location = New System.Drawing.Point(365, 199)
        Me.CmbKtgri.Name = "CmbKtgri"
        Me.CmbKtgri.Size = New System.Drawing.Size(184, 33)
        Me.CmbKtgri.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(274, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Kategori"
        '
        'BoxHrg
        '
        Me.BoxHrg.BackColor = System.Drawing.SystemColors.Window
        Me.BoxHrg.Location = New System.Drawing.Point(662, 122)
        Me.BoxHrg.Name = "BoxHrg"
        Me.BoxHrg.Size = New System.Drawing.Size(184, 31)
        Me.BoxHrg.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(591, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Harga"
        '
        'BoxNma
        '
        Me.BoxNma.BackColor = System.Drawing.SystemColors.Window
        Me.BoxNma.Location = New System.Drawing.Point(365, 122)
        Me.BoxNma.Name = "BoxNma"
        Me.BoxNma.Size = New System.Drawing.Size(184, 31)
        Me.BoxNma.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(295, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama"
        '
        'BoxID
        '
        Me.BoxID.BackColor = System.Drawing.SystemColors.Window
        Me.BoxID.Location = New System.Drawing.Point(119, 122)
        Me.BoxID.Name = "BoxID"
        Me.BoxID.Size = New System.Drawing.Size(104, 31)
        Me.BoxID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(82, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(346, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kelola Produk"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DarkViolet
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(12, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Akun Admin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(12, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Kelola Produk"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DarkViolet
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(32, 460)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 25)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Keluar"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'FrmTmbhProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(1059, 773)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTmbhProduk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTmbhProduk"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TmblBrsihTlsn As Button
    Friend WithEvents TmblHps As Button
    Friend WithEvents TmblUbh As Button
    Friend WithEvents TmblTmbh As Button
    Friend WithEvents CmbKtgri As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BoxHrg As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BoxNma As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BoxID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents TmblPencari As Button
    Friend WithEvents BoxPencari As TextBox
    Friend WithEvents CmbPencari As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TmblBersih As Button
End Class
