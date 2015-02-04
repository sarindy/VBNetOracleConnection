Imports Oracle.DataAccess.Client
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conStr As String
        conStr = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.178.192.19)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=db1)));User Id=ucb;Password=qwe;"
        Try
            Dim con As New OracleConnection(conStr)
            con.Open()
            MsgBox("Suck")

            Dim cmd As New OracleCommand()
            cmd.Connection = con
            cmd.CommandText = "select DESCRIPTION from acct_code where acct_id=268"
            cmd.CommandType = CommandType.Text
            Dim myDataTable As New DataTable
            Dim ad As New OracleDataAdapter(cmd)
            ad.Fill(myDataTable)
            If myDataTable.Rows.Count > 0 Then
                MsgBox(myDataTable.Rows(0).Item("description").ToString)
            End If
            ' Dim dr As OracleDataReader = cmd.ExecuteReader()
            'dr.Read()
            'If dr.HasRows Then
            'Do While dr.Read
            'MsgBox(dr.GetString(0))
            'Loop
            'End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class
