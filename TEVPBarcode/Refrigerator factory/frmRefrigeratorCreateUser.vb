Imports System.Data.SqlClient
Imports TEVPBarcode.sher
Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Configuration
Imports System.Security.Cryptography
Public Class frmRefrigeratorCreateUser
    Public Property StringPass4 As String
    Private Sub frmRefrigeratorCreateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _Refresh1()
        '     StringPass1 = Label7.Text
        Label8.Text = StringPass4

    End Sub

    Private Function Add1_New() As Boolean
        Try
            ''          Dim ddd As String = sher.sap

            Dim sql As String = ""
            sql = "INSERT INTO Login"
            sql += "( Username, Password, UserType,FactoryCode,SapUser,SapCreateBY)"
            sql += " VALUES ('" & txtusername.Text & "','" & Encrypt(txtpassword.Text) & "','" & txtusertype.Text & "','" & txtFactoryID.Text & "'," & txt_Sap.Text & ",'" & Label8.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Function Encrypt(clearText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function

    Private Function Decrypt(cipherText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function
    Private Function _Refresh1() As Boolean
        Try

            Dim sql1 As String = "SELECT Username, Password, UserType,FactoryCode FROM Login"
            sql1 += "   where FactoryCode ='Refrigerator_C'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Login")
            ds.Tables("Login").Columns(0).ColumnName = "أسم المستخدم"
            ds.Tables("Login").Columns(1).ColumnName = "كلمة  المرور"
            ds.Tables("Login").Columns(2).ColumnName = "صلاحيات المستخدم"
            ds.Tables("Login").Columns(3).ColumnName = "كود المصنع"
            dg.DataSource = ds.Tables("Login")
            dg.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Add1_New()
        _Refresh1()
        txtusername.Text = ""
        txtpassword.Text = ""
        txtusertype.Text = ""
        txt_Sap.Text = ""
        TextBox1.Text = ""

        txtusername.Focus()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        Update12()
        _Refresh1()
        txtusername.Text = ""
        txtpassword.Text = ""
        txtusertype.Text = ""
        TextBox1.Text = ""

        txtusername.Focus()
    End Sub

    Private Function Update12() As Boolean
        Try
            Dim sql As String

            sql = "UPDATE Login Set"
            sql += " Password ='" & txtpassword.Text & "'"
            sql += " where Username = '" & txtusername.Text & "'"
            sql += " and  UserType = '" & txtusertype.Text & "'"
            sql += " and  FactoryCode = '" & txtFactoryID.Text & "'"

            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        'txtusername.Text = dg.Item(0, dg.CurrentRow.Index).Value
        'txtpassword.Text = dg.Item(1, dg.CurrentRow.Index).Value
        'txtusertype.Text = dg.Item(2, dg.CurrentRow.Index).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sql As String
        sql = "DELETE FROM Login"
        sql += " where SapUser = '" & txt_Sap.Text & "'"
        'sql += " and  UserType = '" & txtusertype.Text & "'"
        'sql += " and  FactoryCode = '" & txtFactoryID.Text & "'"

        Dim cmd As New SqlClient.SqlCommand(sql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        '   lbl_Msg.ForeColor = Color.GreenYellow
        ' lbl_Msg.Text = "Delete Model"
        txtusername.Text = ""
        txtpassword.Text = ""
        txtusertype.Text = ""
        TextBox1.Text = ""
        txt_Sap.Text = ""
        txtusername.Focus()
        _Refresh1()

    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub txtusertype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtusertype.SelectedIndexChanged

    End Sub
End Class