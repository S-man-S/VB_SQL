Imports System.Data.Odbc

Module Program
    Sub Main(args As String())
        Using con As New OdbcConnection("Driver={MySQL ODBC 8.0 ANSI Driver}; Server=localhost; Database=sys; UID=root; Pwd=123456;")
            con.Open()
            Dim cmd = New OdbcCommand("Create Database if not exists zin Character Set CP1251 Collate CP1251_general_ci;", con)
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
        Using con As New OdbcConnection("Driver={MySQL ODBC 8.0 ANSI Driver}; Server=localhost; Database=zin; UID=root; Pwd=123456;")
            con.Open()
            Dim cmd = New OdbcCommand("Create Table if not exists Filial(idFilial Int, fName Char(40), fDate Date Not Null, fChief Char(40), fPhoneNum Char(11));", con)
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub
End Module
