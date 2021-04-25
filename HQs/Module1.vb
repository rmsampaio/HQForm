Imports System.Data.OleDb

Module Module1

    Public Function NewCod(ByVal Cmds As OleDbCommand, ByVal Tabela As String)

        Cmds.CommandText = "Select Top 1 Codigo From " & Tabela & " Order By Codigo Desc"

        Dim Tabelas As OleDbDataReader = Cmds.ExecuteReader()

        Dim NewCods As String = "000001"
        While Tabelas.Read()
            NewCods = Format(Val(Tabelas.Item(0)) + 1, "000000")
        End While

        Tabelas.Close()

        Return (NewCods)

    End Function

End Module
