Imports MySql.Data.MySqlClient
Public Class login

    Dim Koneksi As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim dr As MySqlDataReader
    Dim ds As DataSet

    Private Sub LoginAdmin()
        If Len(Trim(BoxNmaAdm.Text)) = 0 Then
            MessageBox.Show("Mohon Masukan Nama", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BoxNmaAdm.Focus()
            Exit Sub
        End If
        If Len(Trim(BoxPwAdm.Text)) = 0 Then
            MessageBox.Show("Mohon masukan kata sandi", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BoxPwAdm.Focus()
            Exit Sub
        End If
        Try
            Koneksi = New MySqlConnection("server='localhost';user id='root';password='';database='tokorame'")
            cmd = New MySqlCommand("SELECT Nama,Kata_Sandi FROM admin WHERE Nama = @Nama AND Kata_Sandi = @Kata_Sandi", Koneksi)
            Dim Nama_Admin As New MySqlParameter("@Nama", MySqlDbType.VarChar)
            Dim Kata_Sandi As New MySqlParameter("@Kata_Sandi", MySqlDbType.VarChar)

            Nama_Admin.Value = BoxNmaAdm.Text
            Kata_Sandi.Value = BoxPwAdm.Text
            cmd.Parameters.Add(Nama_Admin)
            cmd.Parameters.Add(Kata_Sandi)
            cmd.Connection.Open()

            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Dim Login As Object = 0

            If dr.HasRows Then
                dr.Read()
                Login = dr(Login)
            End If

            If Login = Nothing Then
                MsgBox("data yang dimasukan salah !", MsgBoxStyle.Critical, "Akses masuk ditolak")
                BoxNmaAdm.Clear()
                BoxPwAdm.Clear()
                BoxNmaAdm.Focus()

            Else
                MsgBox("Akses masuk diberikan", MsgBoxStyle.Information, "Silahkan Masuk")
                BoxNmaAdm.Text = ""
                BoxPwAdm.Text = ""
                Me.Hide()
                FrmTmbhProduk.Show()

            End If

            cmd.Dispose()
            Koneksi.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Koneksi_DB()
        Koneksi = New MySqlConnection("server='localhost';user id='root';password='';database='pinjambuku'")
    End Sub
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TmblMsk_Click(sender As Object, e As EventArgs) Handles TmblMsk.Click
        LoginAdmin()
    End Sub


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub
End Class