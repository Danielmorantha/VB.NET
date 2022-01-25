Imports MySql.Data.MySqlClient
Imports System.Data

Public Class frmAkunAdmin
    Dim Koneksi As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim dr As MySqlDataReader
    Dim ds As DataSet


    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        FrmTmbhProduk.Show()
        Me.Close()
    End Sub

    Sub Koneksi_DB()
        Koneksi = New MySqlConnection("server='localhost';user id='root';password='';database='tokorame'")
        Koneksi.Open()
    End Sub


    Sub SemuaData()
        Dim myadapter As New MySqlDataAdapter("select * from admin", Koneksi)
        Dim mydata As New DataTable
        myadapter.Fill(mydata)
        DataGridView1.DataSource = mydata
    End Sub

    Sub HapusTeks()
        BoxIDAdm.Text = ""
        BoxNmaAdm.Text = ""
        BoxPwAdm.Text = ""
    End Sub

    Private Sub TmblTmbh_Click(sender As Object, e As EventArgs) Handles TmblTmbh.Click
        'pop up konfirmasi
        Dim dr As DialogResult
        dr = MessageBox.Show("Simpan Data Admin?", "Simpan", MessageBoxButtons.YesNo)
        If dr = DialogResult.No Then

        Else
            'Form yang mau diinput
            If Len(Trim(BoxIDAdm.Text)) = 0 Then
                MessageBox.Show("Mohon masukan ID Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BoxIDAdm.Focus()
            ElseIf Len(Trim(BoxNmaAdm.Text)) = 0 Then
                MessageBox.Show("Mohon masukan Nama Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BoxNmaAdm.Focus()
            ElseIf Len(Trim(BoxPwAdm.Text)) = 0 Then
                MessageBox.Show("Mohon masukan Kata Sandi Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BoxPwAdm.Focus()
            Else
                Dim InptData As New MySqlCommand("insert into admin (ID_Admin, Nama, Kata_Sandi) values (" & BoxIDAdm.Text & ", '" & BoxNmaAdm.Text & "', '" & BoxPwAdm.Text & "')", Koneksi)
                InptData.ExecuteNonQuery()
                SemuaData() ' Data sudah diperbarui
                MsgBox("Tersimpan")
            End If
        End If
    End Sub

    Private Sub TmblUbh_Click(sender As Object, e As EventArgs) Handles TmblUbh.Click
        'pop up konfirmasi
        Dim dr As DialogResult
        dr = MessageBox.Show("Simpan Perubahan?", "Simpan", MessageBoxButtons.YesNo)
        If dr = DialogResult.No Then

        Else
            'Form yang mau diinput
            If Len(Trim(BoxIDAdm.Text)) = 0 Then
                MessageBox.Show("Mohon masukan ID Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BoxIDAdm.Focus()
            ElseIf Len(Trim(BoxNmaAdm.Text)) = 0 Then
                MessageBox.Show("Mohon masukan Nama Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BoxNmaAdm.Focus()
            ElseIf Len(Trim(BoxPwAdm.Text)) = 0 Then
                MessageBox.Show("Mohon masukan Kata Sandi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BoxPwAdm.Focus()
            Else
                Dim HpsDta As New MySqlCommand("update admin set ID_Admin='" & BoxIDAdm.Text & "', Nama='" & BoxNmaAdm.Text & "',Kata_Sandi='" & BoxPwAdm.Text & " 'where ID_Admin=" & BoxIDAdm.Text & "", Koneksi)
                HpsDta.ExecuteNonQuery()
                SemuaData()
                MsgBox("Admin berhasil di ubah")

            End If
        End If
    End Sub

    Private Sub frmAkunAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi_DB()
        SemuaData()
    End Sub

    Private Sub TmblHps_Click(sender As Object, e As EventArgs) Handles TmblHps.Click
        Dim dr As DialogResult
        dr = MessageBox.Show("Hapus Data Admin?", "Hapus", MessageBoxButtons.YesNo)
        If dr = DialogResult.No Then
        Else
            If BoxIDAdm.Text = "" Then
                MsgBox("Masukan ID yang mau di hapus")
            Else
                Dim HapusData As New MySqlDataAdapter("Delete from admin where ID_Admin = '" & BoxIDAdm.Text & "'", Koneksi)
                Dim table1 As New DataTable
                HapusData.Fill(table1)
                DataGridView1.DataSource = table1
                SemuaData()
                MsgBox("Admin Berhasi di hapus")
            End If
        End If
    End Sub




    Private Sub TmblBrsihTlsn_Click(sender As Object, e As EventArgs) Handles TmblBrsihTlsn.Click
        HapusTeks()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        login.Show()
        Me.Close()
    End Sub
End Class