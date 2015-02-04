Imports Oracle.DataAccess.Client
Public Class MainFrm

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connStr As String

        connStr = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.178.192.19)(PORT=1521)))" _
                + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=DB1)));User Id=ucb;Password=qwe;"

        Try
            Dim con As New OracleConnection(connStr)
            con.Open()
            MsgBox("Suck")
            Dim sql As String
            Sql = "select description from acct_code"
            Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, con)
            cmd.CommandType = CommandType.Text

            Dim dr As Oracle.DataAccess.Client.OracleDataReader
            dr = cmd.ExecuteReader
            dr.Read()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class
