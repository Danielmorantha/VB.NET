Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FrmTmbhProduk
    Dim Koneksi As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim dr As MySqlDataReader
    Dim ds As DataSet

    Sub Koneksi_DB()
        Koneksi = New MySqlConnection("server='localhost';user id='root';password='';database='tokorame'")
        Koneksi.Open()
    End Sub

    Private Sub KustomLebarKolom()

        Dim KolomNamaProduk As DataGridViewColumn = DataGridView1.Columns(1)
        KolomNamaProduk.Width = 200 'Atur lebar kolom
    End Sub


    Private Sub FrmTmbhProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi_DB()
        SemuaData()
        KustomLebarKolom()
    End Sub

    Private Sub TmblTmbh_Click(sender As Object, e As EventArgs) Handles TmblTmbh.Click
        'pop up konfirmasi
        Dim dr As DialogResult
        dr = MessageBox.Show("Simpan Data Produk?", "Simpan", MessageBoxButtons.YesNo)
        If dr = DialogResult.No Then

        Else
            'Form yang mau diinput
            If Len(Trim(BoxID.Text)) = 0 Then
                MessageBox.Show("Mohon masukan ID Produk", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BoxID.Focus()
            ElseIf Len(Trim(BoxNma.Text)) = 0 Then
                MessageBox.Show("Mohon masukan Nama Produk", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BoxNma.Focus()
            ElseIf Len(Trim(BoxHrg.Text)) = 0 Then
                MessageBox.Show("Mohon masukan Harga Produk", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BoxHrg.Focus()
            ElseIf Len(Trim(CmbKtgri.Text)) = 0 Then
                MessageBox.Show("Mohon masukan Kategori Produk", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CmbKtgri.Focus()
            Else
                Dim InptData As New MySqlCommand("insert into produk (ID_Produk, Nama_Produk, Harga, Kategori_Produk) values (" & BoxID.Text & ", '" & BoxNma.Text & "', " & BoxHrg.Text & ", '" & CmbKtgri.Text & "')", Koneksi)
                InptData.ExecuteNonQuery()
                SemuaData() ' Data sudah diperbarui
                MsgBox("Tersimpan")
            End If
        End If
    End Sub


    Sub SemuaData()
        Dim myadapter As New MySqlDataAdapter("select * from produk", Koneksi)
        Dim mydata As New DataTable
        myadapter.Fill(mydata)
        DataGridView1.DataSource = mydata
    End Sub

    Sub HapusTeks()
        BoxID.Text = ""
        BoxNma.Text = ""
        BoxHrg.Text = ""
        CmbKtgri.Text = ""
    End Sub

    Private Sub TmblUbh_Click(sender As Object, e As EventArgs) Handles TmblUbh.Click
        'pop up konfirmasi
        Dim dr As DialogResult
        dr = MessageBox.Show("Ubah Data Produk?", "Simpan", MessageBoxButtons.YesNo)
        If dr = DialogResult.No Then

        Else
            'Form yang mau diinput
            If Len(Trim(BoxID.Text)) = 0 Then
                MessageBox.Show("Mohon masukan ID Produk", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BoxID.Focus()
            ElseIf Len(Trim(BoxNma.Text)) = 0 Then
                MessageBox.Show("Mohon masukan Nama Produk", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BoxNma.Focus()
            ElseIf Len(Trim(BoxHrg.Text)) = 0 Then
                MessageBox.Show("Mohon masukan Harga Produk", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BoxHrg.Focus()
            ElseIf Len(Trim(CmbKtgri.Text)) = 0 Then
                MessageBox.Show("Mohon masukan Kategori Produk", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CmbKtgri.Focus()
            Else
                Dim HapusData As New MySqlDataAdapter("update produk set Nama_Produk='" & BoxNma.Text & "', Harga='" & BoxHrg.Text & "',Kategori_Produk='" & CmbKtgri.Text & " 'where ID_Produk=" & BoxID.Text & "", Koneksi)
                Dim table1 As New DataTable
                HapusData.Fill(table1)
                DataGridView1.DataSource = table1
                SemuaData()
                MsgBox("Produk Berhasil di ubah")

            End If
        End If
    End Sub

    Private Sub TmblHps_Click(sender As Object, e As EventArgs) Handles TmblHps.Click
        Dim dr As DialogResult
        dr = MessageBox.Show("Hapus Data Produk?", "Hapus", MessageBoxButtons.YesNo)
        If dr = DialogResult.No Then
        Else
            If BoxID.Text = "" Then
                MsgBox("Masukan ID yang mau di hapus")
            Else
                Dim HapusData As New MySqlDataAdapter("Delete from produk where ID_Produk = '" & BoxID.Text & "'", Koneksi)
                Dim table1 As New DataTable
                HapusData.Fill(table1)
                DataGridView1.DataSource = table1
                SemuaData()
                MsgBox("Produk Berhasil di hapus")
            End If
        End If


    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim GmbrBmp As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        e.Graphics.DrawString("Toko Rame", New Font("Century Gothic", 20), Brushes.MidnightBlue, 350, 40)
        e.Graphics.DrawString("Daftar Produk", New Font("Century Gothic", 20), Brushes.MidnightBlue, 351, 90)
        DataGridView1.DrawToBitmap(GmbrBmp, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(GmbrBmp, 150, 170)

    End Sub


    Private Sub TmblBrsihTlsn_Click(sender As Object, e As EventArgs) Handles TmblBrsihTlsn.Click
        HapusTeks()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
        frmAkunAdmin.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()
        login.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Public Sub Pencarian()
        '' ID_Produk
        '' Nama_Produk
        '' Harga
        '' Kategori_Produk
        If CmbPencari.Text = "ID_Produk" Then
            da = New MySqlDataAdapter("SELECT * FROM produk WHERE ID_Produk like '%" & BoxPencari.Text & "%'", Koneksi)
            da.Fill(dt)
            DataGridView1.DataSource = dt

        ElseIf CmbPencari.Text = "Nama_Produk" Then
            da = New MySqlDataAdapter("SELECT * FROM produk WHERE Nama_Produk like '%" & BoxPencari.Text & "%'", Koneksi)
            da.Fill(dt)
            DataGridView1.DataSource = dt

        ElseIf CmbPencari.Text = "Harga" Then
            da = New MySqlDataAdapter("SELECT * FROM produk WHERE Harga like '%" & BoxPencari.Text & "%'", Koneksi)
            da.Fill(dt)
            DataGridView1.DataSource = dt

        ElseIf CmbPencari.Text = "Kategori_Produk" Then
            da = New MySqlDataAdapter("SELECT * FROM produk WHERE Kategori_Produk like '%" & BoxPencari.Text & "%'", Koneksi)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        End If


    End Sub


    Private Sub TmblPencari_Click(sender As Object, e As EventArgs) Handles TmblPencari.Click
        Pencarian()
    End Sub

    Sub Bersih_Pencarian()
        CmbPencari.Text = ""
        BoxPencari.Text = ""
    End Sub

    Private Sub TmblBersih_Click(sender As Object, e As EventArgs) Handles TmblBersih.Click
        Bersih_Pencarian()
    End Sub
End Class