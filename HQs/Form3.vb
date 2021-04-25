Imports System.Data.OleDb

Public Class Form3

    Dim CnnSearch As New OleDbConnection()
    Dim Cmd As OleDbCommand = CnnSearch.CreateCommand

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MdiParent = Form1

        CnnSearch.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\HQs\HQs.mdb"

        Dim SQLString As String = "SELECT Nome,Codigo FROM Editora Order By Nome"

        Dim DataSearch As New DataSet()
        Dim OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter(SQLString, CnnSearch)
        CnnSearch.Open()

        OleDbDataAdapter1.Fill(DataSearch, "Editora")
        DataGridView1.DataSource = DataSearch.Tables("Editora")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Cmd.CommandText = "Select * From Editora Where Codigo = '" & DataGridView1.CurrentRow.Cells(1).Value & "'"

        Dim Editoras As OleDbDataReader = Cmd.ExecuteReader()

        While Editoras.Read()
            Form2.TextBox1.Text = Editoras.Item(0)
            Form2.TextBox2.Text = Editoras.Item(1)
        End While

        Editoras.Close()

        Me.Hide()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class