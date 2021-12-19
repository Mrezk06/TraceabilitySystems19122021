Imports System.IO
Imports TEVPBarcode.sher
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Microsoft.SqlServer


Imports System.Drawing.Imaging


Public Class frmRefrigeratorAddNewModel
    Private Sub btnAddSetID_Click(sender As Object, e As EventArgs) Handles btnAddSetID.Click
        If txtModelName.Text = "" Or txtModelCode.Text = "" Or txtProductionType.Text = "" Or txtColorCode.Text = "" Or txtColorName.Text = "" Or txteanCode.Text = "" Or txteanCode.Text = "" Then

            MsgBox(" من فضلك تاكد من اخال البيانات الرئيسية لتسجيل الموديل وهى كا التالى 1- اسم الموديل . 2- كود الموديل . 3- نوع الانتاج . 4- كود اللون . 5- اسم اللون . 6-الايان كود .7- اختيار الصوره ")
        Else
            Add1_New()
            bind1()
            '  _Refresh1()
            txtModelName.Text = ""
            txtModelCode.Text = ""
            txtProductionType.Text = ""
            txtColorCode.Text = ""
            txtColorName.Text = ""
            TxtDoor1.Text = ""
            txtDoor2.Text = ""
            txtstiker.Text = ""
            txtMotor.Text = ""
            txtline.Text = ""
            txtCarton.Text = ""
            txtMotor.Text = ""
            txteanCode.Text = ""
            txtModelName.Focus()

        End If
        txtModelName.Text = ""
        txtModelCode.Text = ""
    End Sub
    Private Function Add1_New() As Boolean
        ' Try

        Try
            Dim command1 As New SqlCommand("Insert into Refrigerator_Models(R_ModelName,R_ModelControl,R_ProductionType,R_ColorCode,R_ColorName,R_FactoryCode,R_Door1,R_Door2,R_Staker,R_Matore,R_Line,R_EanCode,R_Carton,R_ImagaeSourse)values(@R_ModelName,@R_ModelControl,@R_ProductionType,@R_ColorCode,@R_ColorName,@R_FactoryCode,@R_Door1,@R_Door2,@R_Staker,@R_Matore,@R_Line,@R_EanCode,@R_Carton,@R_ImagaeSourse)", cn)
            command1.Parameters.Add("@R_ModelName", SqlDbType.NVarChar).Value = txtModelName.Text
            command1.Parameters.Add("@R_ModelControl", SqlDbType.NVarChar).Value = txtModelCode.Text
            command1.Parameters.Add("@R_ProductionType", SqlDbType.NVarChar).Value = txtProductionType.Text
            command1.Parameters.Add("@R_ColorCode", SqlDbType.Int).Value = txtColorCode.Text
            command1.Parameters.Add("@R_ColorName", SqlDbType.NVarChar).Value = txtColorName.Text
            command1.Parameters.Add("@R_FactoryCode", SqlDbType.NVarChar).Value = ComboBox1.Text
            command1.Parameters.Add("@R_Door1", SqlDbType.NVarChar).Value = TxtDoor1.Text
            command1.Parameters.Add("@R_Door2", SqlDbType.NVarChar).Value = txtDoor2.Text
            command1.Parameters.Add("@R_Staker", SqlDbType.NVarChar).Value = txtstiker.Text
            command1.Parameters.Add("@R_Matore", SqlDbType.NVarChar).Value = txtMotor.Text
            command1.Parameters.Add("@R_Line", SqlDbType.NVarChar).Value = txtline.Text
            command1.Parameters.Add("@R_EanCode", SqlDbType.NVarChar).Value = txteanCode.Text
            command1.Parameters.Add("@R_Carton", SqlDbType.NVarChar).Value = txtCarton.Text
            Dim memstr As New MemoryStream
            PictureBox1.Image.Save(memstr, PictureBox1.Image.RawFormat)
            command1.Parameters.Add("@R_ImagaeSourse", SqlDbType.Image).Value = memstr.ToArray
            If cn.State = ConnectionState.Closed Then
                    cn.Open()
                End If
            command1.ExecuteNonQuery()
            MessageBox.Show("image inserted")
            cn.Close()
            bind1()
        Catch ex As Exception
            End Try

        Dim sql As String
        '    sql = "	INSERT INTO Refrigerator_Models "
        '    sql += "(R_ModelName, R_ModelControl, R_ProductionType, R_ColorCode, R_ColorName, R_FactoryCode, R_Door1, R_Door2, R_Staker, R_Matore, R_Line, R_EanCode,R_Carton,R_ImagaePath )"

        '    sql += " VALUES ('" & txtModelName.Text & "','" & txtModelCode.Text & "','" & txtProductionType.Text & "'," & txtColorCode.Text & ",'" & txtColorName.Text & "','B','" & TxtDoor1.Text & "','" & txtDoor2.Text & "','" & txtstiker.Text & "','" & txtMotor.Text & "','" & txtline.Text & "','" & txteanCode.Text & "','" & txtCarton.Text & "','" & Label16.Text & "' )"
        '    Dim cmd As New SqlClient.SqlCommand(sql, cn)
        '    If cn.State = ConnectionState.Closed Then cn.Open()
        '    cmd.ExecuteNonQuery()
        '    cn.Close()

        '    Dim sql As String
        '    sql = "	INSERT INTO Refrigerator_Models "
        '    sql += "(R_ModelName, R_ModelControl, R_ProductionType, R_ColorCode, R_ColorName, R_FactoryCode, R_Door1, R_Door2, R_Staker, R_Matore, R_Line, R_EanCode,R_Carton,R_ImagaePath )"

        '    sql += " VALUES ('" & txtModelName.Text & "','" & txtModelCode.Text & "','" & txtProductionType.Text & "'," & txtColorCode.Text & ",'" & txtColorName.Text & "','B','" & TxtDoor1.Text & "','" & txtDoor2.Text & "','" & txtstiker.Text & "','" & txtMotor.Text & "','" & txtline.Text & "','" & txteanCode.Text & "','" & txtCarton.Text & "','" & Label16.Text & "' )"
        '    Dim cmd As New SqlClient.SqlCommand(sql, cn)
        '    If cn.State = ConnectionState.Closed Then cn.Open()
        '    cmd.ExecuteNonQuery()
        '    cn.Close()
        'Catch ex As Exception
        'End Try
    End Function
    Private Sub bind1()

        Dim command1 As New SqlCommand("Select * from Refrigerator_Models where R_FactoryCode ='C'", cn)


        Dim adapter As New SqlDataAdapter(command1)


        Dim table As New DataTable()

        adapter.Fill(table)

        dg.AllowUserToAddRows = False

        dg.RowTemplate.Height = 90


        Dim pic1 As New DataGridViewImageColumn

        dg.DataSource = table

        pic1 = dg.Columns(18)

        pic1.ImageLayout = DataGridViewImageCellLayout.Stretch


    End Sub
    Private Function _Refresh1() As Boolean
        Try

            Dim sql1 As String = "SELECT  R_ModelName, R_ModelControl, R_ProductionType, R_ColorCode, R_ColorName, R_FactoryCode,R_Door1, R_Door2, R_Staker, R_Matore,R_Carton, R_Line, R_EanCode  FROM Refrigerator_Models"
            sql1 += "   where R_FactoryCode ='C'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_Models")
            ds.Tables("Refrigerator_Models").Columns(0).ColumnName = "Model Name"
            ds.Tables("Refrigerator_Models").Columns(1).ColumnName = "Model Control"
            ds.Tables("Refrigerator_Models").Columns(2).ColumnName = "Production Type"
            ds.Tables("Refrigerator_Models").Columns(3).ColumnName = "Color Code"
            ds.Tables("Refrigerator_Models").Columns(4).ColumnName = "Color Name"
            ds.Tables("Refrigerator_Models").Columns(5).ColumnName = "Factory Code"
            ds.Tables("Refrigerator_Models").Columns(6).ColumnName = "Door1"
            ds.Tables("Refrigerator_Models").Columns(7).ColumnName = "Door2"
            ds.Tables("Refrigerator_Models").Columns(8).ColumnName = "Staker"
            ds.Tables("Refrigerator_Models").Columns(9).ColumnName = "Motor"
            ds.Tables("Refrigerator_Models").Columns(10).ColumnName = "Carton"
            ds.Tables("Refrigerator_Models").Columns(11).ColumnName = "Line"
            ds.Tables("Refrigerator_Models").Columns(12).ColumnName = "Ean Code"
            dg.DataSource = ds.Tables("Refrigerator_Models")
            dg.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtS_Laber.Text.Length < 8 Then
            MsgBox("الرجاء التحقق من ساب الموظف لبد ان يكون مكون من 8 أرقام  ")
            txtS_Laber.Focus()
            txtS_Laber.SelectAll()



        Else
            'Dim dsMax As New DataSet
            'Dim Sql = "SELECT  Heater_Name_Laber FROM Heater_Name_Sap where Heater_Sap_Laber='" & txtParts1.Text & "'"
            'Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
            'dsMax.Tables.Clear()
            'da.Fill(dsMax)
            'If dsMax.Tables(0).Rows.Count < 1 Then
            '    ' lbl_Msg.ForeColor = Color.Red
            '    MessageBox = "هذا الاسم غير  مصرح له العمل على الباركود "
            '    txtParts1.Focus()
            '    txtParts1.SelectAll()
            '    Exit Sub

            '    _Refresh315()
            '    lbl_Msg.ForeColor = Color.Green
            '    lbl_Msg.Text = "مرحبا بك فى برنامج مصنع السخان لمتابعة الجوده "
            '    cmb_Pcode.Enabled = True
            '    ' txtline.Enabled = False
            '    txtshift.Enabled = True
            '    'txtshift.Visible = False
            '    Button2.Visible = False
            Add116_New()
            _Refresh315()
            txtS_Laber.Text = ""
            TxtN_Laber.Text = ""

            txtstu.Text = ""
            '    Label10.Visible = False
            '    txtshift.Focus()
        End If

    End Sub
    Private Function Add116_New() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO Heater_Name_Sap "
            sql += "(Heater_Name_Laber,Heater_Sap_Laber)"
            sql += " VALUES ('" & TxtN_Laber.Text & "','" & txtS_Laber.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            'sql += " Heater_sap_stu = '" & txtstu.Text & "'"
            cn.Close()


        Catch ex As Exception

        End Try

    End Function
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber,Heater_Sap_Laber FROM Heater_Name_Sap"
            ' sql += " FROM Output"
            ' sql += " where Heater_Sap_Laber='" & txtParts1.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Name_Sap")
            ds.Tables("Heater_Name_Sap").Columns(0).ColumnName = "Name Laber "
            ds.Tables("Heater_Name_Sap").Columns(1).ColumnName = "Sap Laber "
            '  ds.Tables("Heater_Name_Sap").Columns(2).ColumnName = " Status"
            dg1.DataSource = ds.Tables("Heater_Name_Sap")
            dg1.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Update12()

        _Refresh315()

        txtS_Laber.Text = ""
        TxtN_Laber.Text = ""
        txtstu.Text = ""
    End Sub


    Private Function Update12() As Boolean
        Try
            Dim sql As String
            sql = "UPDATE Heater_Name_Sap Set"
            sql += " Heater_Name_Laber ='" & TxtN_Laber.Text & "',"
            sql += " Heater_Sap_Laber = '" & txtS_Laber.Text & "',"
            '  sql += " Heater_sap_stu = '" & txtstu.Text & "'"
            'sql += " fLine_Name = '" & txtArea.Text & "'"
            sql += " where Heater_Sap_Laber = '" & txtS_Laber.Text & "'"
            ' sql += " and  Model_control = '" & TxtSet.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim sql As String
        sql = "DELETE FROM Heater_Name_Sap"
        sql += " where Heater_Sap_Laber = '" & txtS_Laber.Text & "'"
        Dim cmd As New SqlClient.SqlCommand(sql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        '   lbl_Msg.ForeColor = Color.GreenYellow
        ' lbl_Msg.Text = "Delete Model"
        txtS_Laber.Focus()
        ' txtFATSERIAL.SelectAll()
        _Refresh315()
        txtS_Laber.Text = ""
        TxtN_Laber.Text = ""
        'txtFATSERIAL.Enabled = True
        'txtFATSERIAL.Focus()

    End Sub

    Private Sub dg1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg1.CellContentClick
        TxtN_Laber.Text = dg1.Item(0, dg1.CurrentRow.Index).Value
        txtS_Laber.Text = dg1.Item(1, dg1.CurrentRow.Index).Value
    End Sub
    Public Property StringPass5 As String
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim sql As String
        sql = "DELETE FROM Refrigerator_Models"
        sql += " where R_EanCode = '" & txteanCode.Text & "'"
        Dim cmd As New SqlClient.SqlCommand(sql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        '   lbl_Msg.ForeColor = Color.GreenYellow
        ' lbl_Msg.Text = "Delete Model"
        txteanCode.Text = ""
        txtModelName.Focus()
        _Refresh1()


    End Sub
    Public Property StringPass2 As String
    Private Sub frmRefrigeratorAddNewModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
        bind1()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _Refresh1()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        _Refresh315()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim openfiledialog1 As New OpenFileDialog


        openfiledialog1.Filter = "images|*.jpg;*.png;*.gif;*.bmp"


        If openfiledialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then



            PictureBox1.Image = Image.FromFile(openfiledialog1.FileName)


        End If

        'Dim fichier_txt As String
        'fichier.Filter = "image files|*.png;*.jpg;*.gif"
        'If fichier.ShowDialog = DialogResult.OK Then
        '    fichier_txt = Path.GetFileName(fichier.FileName)
        'End If

        'Label16.Text = fichier_txt


        'Dim filename As String = Path.Combine(Label16.Text)

        'Try
        '    Dim folder As String = "C:\Users\mrezk06\Desktop\Ean Code\"
        '    Dim filename0 As String = Path.Combine(Label16.Text)
        '    Dim filename2 As String = System.IO.Path.Combine(folder + filename0)
        '    Try
        '        Using fs As New System.IO.FileStream(filename2, IO.FileMode.Open)
        '            PictureBox1.Image = New Bitmap(Image.FromStream(fs))
        '        End Using
        '    Catch ex As Exception
        '        Dim msg As String = "Filename: " & filename2 &
        '                Environment.NewLine & Environment.NewLine &
        '                "Exception: " & ex.ToString
        '        MessageBox.Show(msg, "Error Opening Image File")
        '    End Try

        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        'Try

        '    Dim filepath As String = Server.MapPath("~/images/") & Guid.NewGuid().ToString() & fileuploadposter.PostedFile.FileName
        '    fileuploadposter.PostedFile.SaveAs(filepath)
        '    Dim fS As New FileStream(filepath, FileMode.Open, FileAccess.Read)
        '    Dim br As New BinaryReader(fS)
        '    Dim bytes As Byte() = br.ReadBytes(Convert.ToInt32(fS.Length))
        '    fS.Close()
        '    br.Close()
        '    fS.Close()
        '    Dim sql As String
        '    sql = "	INSERT INTO Refrigerator_Models "
        '    sql += "(R_ModelName, R_ModelControl, R_ProductionType, R_ColorCode, R_ColorName, R_FactoryCode, R_Door1, R_Door2, R_Staker, R_Matore, R_Line, R_EanCode,R_Carton,R_ImagaePath )"
        '    sql += " VALUES ('" & txtModelName.Text & "','" & txtModelCode.Text & "','" & txtProductionType.Text & "'," & txtColorCode.Text & ",'" & txtColorName.Text & "','B','" & TxtDoor1.Text & "','" & txtDoor2.Text & "','" & txtstiker.Text & "','" & txtMotor.Text & "','" & txtline.Text & "','" & txteanCode.Text & "','" & txtCarton.Text & "','" & Label16.Text & "')"
        '    Dim cmd As New SqlClient.SqlCommand(sql, cn)
        '    If cn.State = ConnectionState.Closed Then cn.Open()
        '    cmd.ExecuteNonQuery()
        '    cn.Close()
        'Catch ex As Exception

        'End Try

        ''Try
        ''    If fileuploadposter.HasFile Then
        ''        Dim filepath As String = Server.MapPath("~/images/") & Guid.NewGuid().ToString() & fileuploadposter.PostedFile.FileName
        ''        fileuploadposter.PostedFile.SaveAs(filepath)
        ''        Dim fS As New FileStream(filepath, FileMode.Open, FileAccess.Read)
        ''        Dim br As New BinaryReader(fS)
        ''        Dim bytes As Byte() = br.ReadBytes(Convert.ToInt32(fS.Length))
        ''        fS.Close()
        ''        br.Close()
        ''        fS.Close()
        ''        Dim cmd As New SqlCommand("Sp_InsertMovieDetail", con)
        ''        cmd.CommandType = CommandType.StoredProcedure
        ''        con.Open()
        ''        cmd.Parameters.AddWithValue("@name", txtname.Text)
        ''        cmd.Parameters.AddWithValue("@genre", txtgenre.Text)
        ''        cmd.Parameters.AddWithValue("@cost", txtcost.Text)
        ''        cmd.Parameters.AddWithValue("@poster", bytes)
        ''        cmd.ExecuteNonQuery()
        ''        con.Close()
        ''        cmd.Dispose()
        ''        ClearControl()
        ''        Response.Write("<script type=""text/javascript"">alert('Record Insert Successfully!!!');</script>")
        ''    End If
        ''Catch ex As Exception
        ''End Try
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        Try
            txtModelName.Text = dg.CurrentRow.Cells(0).Value
            txtModelCode.Text = dg.CurrentRow.Cells(1).Value
            txteanCode.Text = dg.CurrentRow.Cells(2).Value
            Dim img As Byte()
            img = dg.CurrentRow.Cells(18).Value
            Dim memstr As New MemoryStream(img)
            PictureBox1.Image = Image.FromStream(memstr)

        Catch ex As Exception

        End Try

    End Sub
End Class