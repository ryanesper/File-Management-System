Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Security.Cryptography
Imports System.Text

Module globalconnection
    'Public con As New SqlConnection("data source = Boss-PC\SQLEXPRESS; initial catalog=fms; integrated security=true")
    Public con As New mySqlConnection
    Public cmd As New mySqlCommand
    Public dr As MySqlDataReader
    Public mypath As String
    Public datetime As New DateTime
    Public sqlda As MySqlDataAdapter
    Public user As String
    Public dt As DataTable
    Public ds As DataSet
    'Public path As String = "\\192.168.0.6\Students_Accounts"
    Public cmdselect1, cmdselect, cmddelete, cmddelete2, cmddelete3, confirm, strconn, fileid, i, o, fullview As String
    Public combination1, combination2 As String
    Public loadmypicture As String

    Public id As String = ""
    Public firstname As String = ""
    Public middlename As String = ""
    Public lastname As String = ""
    Public number As String = ""
    Public address As String = ""
    Public email As String = ""
    Public picname As String = ""
    Public username As String = ""
    Public password As String = ""
    Public account_type As String = ""
    Public regdate As String = ""

    Public student_id As String = ""
    Public subject_id As String = ""
    Public subject_name As String = ""
    Public subject_time As String = ""
    Public subject_day As String = ""

    Public getpictypeforprofpic As String
    Public picfullname As String
    Public imageszeroallocatedspace As Boolean = False

    Public remoteservername As String
    Public clientinitialpath As String
    Public drive_location As String
    Public serverinitialpath As String
    Public sizenumber As String
    Public unit As String
    Public allocatedspace As String
    Public asinbytes As Long
    Public serverpcusername As String
    Public serverpcpassword As String

    Public totalsize As Decimal = 0
    Public kb As Decimal = 1024
    Public mb As Decimal = kb * 1024
    Public gb As Decimal = mb * 1024
    'Public allocatedspace As Decimal = 4 * gb
    Public remainingspace As Decimal

    Public subjectgrabber As String
    Public daygrabber As String
    Public timegrabber As String

    Public selectedsubject As String
    Public selectedtime As String
    Public selectedday As String

    Public pathlength As Integer = 0
    Public selectedfolderlength As String = 0
    Public selectedfoldername As String
    Public getstudentfoldersize As String

    'Public file_id, file_name, file_type, file_size, file_stored, file_comment, file_creation_time, file_last_access_time, file_last_write_time As String

    Public Sub openconnection()
        If con.State = ConnectionState.Closed Then
            con.ConnectionString = "Server= " & My.Settings.serversettings & "; User Id= " & My.Settings.usersettings & "; Password= " & My.Settings.passwordsettings & "; Database= " & My.Settings.databasesettings & ";"
            'con.ConnectionString = "Server=localhost; User Id=esper; Password=root; Database=fms;"
            'con.ConnectionString = "Server=localhost; User Id=root; Password=; Database=fms;"
            'con.ConnectionString = "Server=192.168.0.1; User Id=esper; Password=root; Database=fms;"
            con.Open()
            cmd.Connection = con
        End If
    End Sub

    Public Sub studentsaccountquery()
        cmdselect = "SELECT * FROM `students_account`"
        sqlda = New MySqlDataAdapter(cmdselect, con)
        dt = New DataTable
        sqlda.Fill(dt)
    End Sub

    Public Sub querysubject()
        cmdselect = "SELECT * FROM `instructor_subject` where instructor_id = '" & id & "'"
        sqlda = New MySqlDataAdapter(cmdselect, con)
        dt = New DataTable
        sqlda.Fill(dt)
    End Sub

    Public Sub querystudents()
        cmdselect = "select students_account.account_id, students_account.firstname, students_account.middlename, students_account.lastname, students_account.course, students_account.year, students_account.fullname from students_account inner join student_subject on students_account.account_id = student_subject.student_id where student_subject.subject_name = '" & frmmain.cbosubject.Text & "' and student_subject.time = '" & frmmain.cbostime.Text & "' and student_subject.day = '" & frmmain.cbosday.Text & "'"
        sqlda = New MySqlDataAdapter(cmdselect, con)
        dt = New DataTable
        sqlda.Fill(dt)
    End Sub

    Public Sub queryallinstructors()
        cmdselect = "SELECT * FROM `admin` where account_type = 'Instructor Admin'"
        'cmdselect = "SELECT * FROM `admin`"
        sqlda = New MySqlDataAdapter(cmdselect, con)
        dt = New DataTable
        sqlda.Fill(dt)
    End Sub


    Public Sub mysubjectsquery()
        cmdselect = "select file_id as 'File ID', file_name as 'Name', file_type as 'Type', file_size as 'Size', time_stored as 'Date Stored' from myfiles1 where fileid = '" & fullview & "'"""
        sqlda = New MySqlDataAdapter(cmdselect, con)
        dt = New DataTable
        sqlda.Fill(dt)
    End Sub

    'Public Sub query4()
    '    cmdselect1 = "select * from superadmin"
    '    sqlda = New SqlDataAdapter(cmdselect, con)
    '    cmd = New SqlCommand(cmdselect, con)
    'End Sub

    Public Sub query5()
        cmdselect = "select id from userss"
        sqlda = New MySqlDataAdapter(cmdselect, con)
        dt = New DataTable
        sqlda.Fill(dt)
    End Sub

    Public Sub selectstudentfrommysubject()
        cmdselect = "select students_account.account_id, students_account.firstname, students_account.middlename, students_account.lastname, students_account.year, students_account.course, students_account.fullname from students_account inner join student_subject on students_account.account_id = student_subject.student_id where student_subject.subject_name = '" & frmmain.cbosubject.Text & "'"
        sqlda = New MySqlDataAdapter(cmdselect, con)
        dt = New DataTable
        sqlda.Fill(dt)
    End Sub

    Public Sub loadsubjectincombobox()

        openconnection()
        Dim ds As New DataSet
        Dim sql As String
        sql = "select distinct subject_name from instructor_subject where instructor_id = '" & id & "'"
        sqlda = New MySqlDataAdapter(sql, con)
        sqlda.Fill(ds, "fms")
        For Each r As DataRow In ds.Tables(0).Rows
            frmmain.cbosubject.Items.Add(r("subject_name"))
        Next
        con.Close()

    End Sub

    Public Sub getsettingsfromdatabase()

        Dim openorclose As Boolean = False
        If con.State = ConnectionState.Closed Then
            openconnection()
            openorclose = True
        End If

        cmd = New MySqlCommand("SELECT COUNT(client_initial_path) as Count FROM settings", con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        While (reader.Read())
            If reader("Count") = 0 Then

            Else
                reader.Close()
                cmd.CommandText = "select * from settings"
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    reader.Read()
                    remoteservername = reader("serverpcname").ToString()
                    clientinitialpath = reader("client_initial_path").ToString()
                    drive_location = reader("drive_location").ToString()
                    serverinitialpath = reader("server_initial_path").ToString()
                    sizenumber = reader("size").ToString()
                    unit = reader("unit").ToString()
                    allocatedspace = reader("allocated_space").ToString()
                    asinbytes = reader("asinbytes").ToString()
                    serverpcusername = reader("username").ToString()
                    Dim converter As New encryptanddecrypt
                    serverpcpassword = converter.decrypt(reader("password").ToString(), "Keys")
                End If
            End If
        End While
        reader.Close()

        If openorclose = True Then
            con.Close()
        End If

    End Sub

    Public Sub displayfilesandfolders()

        'frmexplorer.explorerlistview.View = View.Details
        frmexplorer.explorerlistview.FullRowSelect = True
        frmexplorer.explorerlistview.SmallImageList = frmexplorer.icons

        frmexplorer.explorerlistview.Columns.Clear()
        frmexplorer.explorerlistview.Columns.Add("Name", 300, HorizontalAlignment.Left)
        frmexplorer.explorerlistview.Columns.Add("Date Modified", 150, HorizontalAlignment.Left)
        frmexplorer.explorerlistview.Columns.Add("Type", 150, HorizontalAlignment.Left)
        frmexplorer.explorerlistview.Columns.Add("Size", 100, HorizontalAlignment.Left)

        For Each item As String In My.Computer.FileSystem.GetDirectories(combination2)
            'frmexplorer.icons.Images.Add(frmexplorer.GetShellIcon(item))

            frmexplorer.icons.Images.Add(frmexplorer.GetShellIcon(item))
            'frmexplorer.explorerlistview.Items.Add(My.Computer.FileSystem.GetName(item), frmexplorer.icons.Images.Count - 1)

            Dim lvi As New ListViewItem(My.Computer.FileSystem.GetName(item), frmexplorer.icons.Images.Count - 1)
            lvi.SubItems.Add(My.Computer.FileSystem.GetDirectoryInfo(item).CreationTime)
            lvi.SubItems.Add("Folder")

            'For Each itemsize As String In My.Computer.FileSystem.GetFiles(combination2, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
            '    totalsize += My.Computer.FileSystem.GetFileInfo(item).Length
            '    If (totalsize >= 0 And totalsize < kb) Then
            '        lvi.SubItems.Add(itemsize & " bytes")
            '    ElseIf (totalsize >= kb AndAlso totalsize < mb) Then
            '        lvi.SubItems.Add(Format((itemsize / 1024), "0.00") & " KB")
            '    ElseIf (totalsize >= mb AndAlso totalsize < gb) Then
            '        lvi.SubItems.Add(Format((itemsize / 1024 / 1024), "0.00") & " MB")
            '    ElseIf (totalsize >= gb) Then
            '        lvi.SubItems.Add(Format((itemsize / 1024 / 1024 / 1024), "0.00") & " GB")
            '    End If
            'Next

            frmexplorer.explorerlistview.Items.Add(lvi) 'add the new ListViewItem to the ListView
        Next

        For Each item As String In My.Computer.FileSystem.GetFiles(combination2, FileIO.SearchOption.SearchTopLevelOnly, "*.*")
            'frmexplorer.icons.Images.Add(Drawing.Icon.ExtractAssociatedIcon(item))
            'frmexplorer.explorerlistview.Items.Add(My.Computer.FileSystem.GetName(item), frmexplorer.icons.Images.Count - 1)

            frmexplorer.icons.Images.Add(Icon.ExtractAssociatedIcon(item).ToBitmap)
            Dim lvi As New ListViewItem(IO.Path.GetFileNameWithoutExtension(item), frmexplorer.icons.Images.Count - 1)
            'Dim lvi As New ListViewItem(My.Computer.FileSystem.GetFileInfo(item).Name, frmexplorer.icons.Images.Count - 1)
            lvi.SubItems.Add(My.Computer.FileSystem.GetFileInfo(item).CreationTime)
            lvi.SubItems.Add(My.Computer.FileSystem.GetFileInfo(item).Extension.ToUpper)

            Dim itemsize As Decimal = My.Computer.FileSystem.GetFileInfo(item).Length
            If (itemsize >= 0 And itemsize < kb) Then
                lvi.SubItems.Add(itemsize & " bytes")
            ElseIf (itemsize >= kb AndAlso itemsize < mb) Then
                lvi.SubItems.Add(Format((itemsize / 1024), "0") & " KB")
                'lvi.SubItems.Add((itemsize / 1024) & " KB")
            ElseIf (itemsize >= mb AndAlso itemsize < gb) Then
                lvi.SubItems.Add(Format((itemsize / 1024 / 1024), "0.00") & " MB")
            ElseIf (itemsize >= gb) Then
                lvi.SubItems.Add(Format((itemsize / 1024 / 1024 / 1024), "0.00") & " GB")
            End If

            frmexplorer.explorerlistview.Items.Add(lvi) 'add the new ListViewItem to the ListView
        Next

    End Sub

    Public Sub myspace()

        'frmexplorer.txtallocatedspace.Text = 4 * gb
        If (asinbytes >= 0 And asinbytes < kb) Then
            frmexplorer.lblallocatedspace.Text = "Allocated Space       :   " & asinbytes & " bytes"
        ElseIf (asinbytes >= kb AndAlso asinbytes < mb) Then
            frmexplorer.lblallocatedspace.Text = "Allocated Space       :   " & Format((asinbytes / 1024), "0.00") & " KB"
        ElseIf (asinbytes >= mb AndAlso asinbytes < gb) Then
            frmexplorer.lblallocatedspace.Text = "Allocated Space       :   " & Format((asinbytes / 1024 / 1024), "0.00") & " MB"
        ElseIf (asinbytes >= gb) Then
            frmexplorer.lblallocatedspace.Text = "Allocated Space       :   " & Format((asinbytes / 1024 / 1024 / 1024), "0.00") & " GB"
        End If

    End Sub

    Public Sub spaceconsumed()
        totalsize = 0
        For Each item As String In My.Computer.FileSystem.GetFiles(getstudentfoldersize, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
            totalsize += My.Computer.FileSystem.GetFileInfo(item).Length
            If (totalsize >= 0 And totalsize < kb) Then
                frmexplorer.lblusedspace.Text = "Used Space               :   " & totalsize & " bytes"
            ElseIf (totalsize >= kb AndAlso totalsize < mb) Then
                frmexplorer.lblusedspace.Text = "Used Space               :   " & Format((totalsize / 1024), "0.00") & " KB"
            ElseIf (totalsize >= mb AndAlso totalsize < gb) Then
                frmexplorer.lblusedspace.Text = "Used Space               :   " & Format((totalsize / 1024 / 1024), "0.00") & " MB"
            ElseIf (totalsize >= gb) Then
                frmexplorer.lblusedspace.Text = "Used Space               :   " & Format((totalsize / 1024 / 1024 / 1024), "0.00") & " GB"
            End If
        Next
    End Sub

    Public Sub remainingspacee()

        remainingspace = asinbytes - totalsize

        If (remainingspace >= 0 And remainingspace < kb) Then
            frmexplorer.lblremainingspace.Text = "Remaining Space :  " & Format(remainingspace, "#,##0") & " bytes"
        ElseIf (remainingspace >= kb AndAlso remainingspace < mb) Then
            frmexplorer.lblremainingspace.Text = "Remaining Space :  " & Format((remainingspace / 1024), "0.00") & " KB"
        ElseIf (remainingspace >= mb AndAlso remainingspace < gb) Then
            frmexplorer.lblremainingspace.Text = "Remaining Space :  " & Format((remainingspace / 1024 / 1024), "0.00") & " MB"
        ElseIf (remainingspace >= gb) Then
            frmexplorer.lblremainingspace.Text = "Remaining Space :  " & Format((remainingspace / 1024 / 1024 / 1024), "0.00") & " GB"
        End If

    End Sub

    Public Sub countfilesandfolders()

        Dim filenumber As Integer = 0
        Dim foldernumber As Integer = 0

        Dim files As Object = My.Computer.FileSystem.GetFiles(combination2, FileIO.SearchOption.SearchTopLevelOnly)
        Dim folders As Object = My.Computer.FileSystem.GetDirectories(combination2, FileIO.SearchOption.SearchTopLevelOnly)

        For Each filee In files
            filenumber += 1
        Next
        For Each folderr In folders
            foldernumber += 1
        Next

        frmexplorer.lblfiles.Text = filenumber & " files"
        frmexplorer.lblfolders.Text = foldernumber & " folders"
        frmexplorer.lblitems.Text = filenumber + foldernumber & " items"
        If frmexplorer.lblitems.Text = "0 items" Then
            frmexplorer.lblitems.Text = "No items found"
        End If

    End Sub

    Public Class encryptanddecrypt

        Dim DES As New TripleDESCryptoServiceProvider
        Dim MDS As New MD5CryptoServiceProvider

        Function MDShash(value As String) As Byte()

            Return MDS.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))

        End Function

        Function encrypt(stringinput As String, key As String) As String

            DES.Key = MDShash(key)
            DES.Mode = CipherMode.ECB

            Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringinput)

            Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))

        End Function

        Function decrypt(encryptedstring As String, key As String) As String

            DES.Key = MDShash(key)
            DES.Mode = CipherMode.ECB
            Dim buffer As Byte() = Convert.FromBase64String(encryptedstring)

            Return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length))

        End Function

    End Class

End Module
