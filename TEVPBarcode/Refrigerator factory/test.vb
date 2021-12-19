Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO

Imports System.Drawing.Imaging
Imports TEVPBarcode.sher
Public Class test
    Public conn As SqlConnection
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  bind1()
        Me.CenterToScreen()
        Call awal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim command1 As New SqlCommand("Insert into Movie(name,genre,poster)values(@name,@genre,@poster1)", cn)

            command1.Parameters.Add("@name", SqlDbType.NVarChar).Value = TextBox1.Text
            command1.Parameters.Add("@genre", SqlDbType.NVarChar).Value = TextBox2.Text
            Dim memstr As New MemoryStream
            PictureBox1.Image.Save(memstr, PictureBox1.Image.RawFormat)
            command1.Parameters.Add("@poster1", SqlDbType.Image).Value = memstr.ToArray
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            command1.ExecuteNonQuery()
            MessageBox.Show("image inserted")
            cn.Close()
            bind1()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub fileuploadposter_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles fileuploadposter.FileOk

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim openfiledialog1 As New OpenFileDialog


        openfiledialog1.Filter = "images|*.jpg;*.png;*.gif;*.bmp"


        If openfiledialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then



            PictureBox1.Image = Image.FromFile(openfiledialog1.FileName)


        End If
    End Sub
    Private Sub bind1()

        Dim command1 As New SqlCommand("Select * from Movie", cn)


        Dim adapter As New SqlDataAdapter(command1)


        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False

        DataGridView1.RowTemplate.Height = 90


        Dim pic1 As New DataGridViewImageColumn

        DataGridView1.DataSource = table

        pic1 = DataGridView1.Columns(3)

        pic1.ImageLayout = DataGridViewImageCellLayout.Stretch


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Label4.Text = DataGridView1.CurrentRow.Cells(0).Value

        TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value


        TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value



        Dim img As Byte()

        img = DataGridView1.CurrentRow.Cells(3).Value

        Dim memstr As New MemoryStream(img)


        PictureBox1.Image = Image.FromStream(memstr)



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error Resume Next
        OpenFileDialog1.ShowDialog()
        TextBox3.Text = OpenFileDialog1.FileName
        AxAcroPDF1.src = (TextBox3.Text)
    End Sub
    Sub Ketemu()
        On Error Resume Next
        TextBox2.Text = dr(1)
        TextBox3.Text = dr(2)
        TextBox2.Focus()
        AxAcroPDF1.src = (TextBox3.Text)
    End Sub
    Sub Carikode()
        ' Call Koneksi()
        cmd = New SqlCommand("select * from Movie ", cn)
        dr = cmd.ExecuteReader
        dr.Read()
    End Sub
    Sub Tampilgrid()

        da = New SqlDataAdapter("select * from movie", cn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.AliceBlue
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor =
        Color.AntiqueWhite
    End Sub
    Sub awal()
        'Call Kosongkan()
        Call Tampilgrid()
    End Sub
End Class