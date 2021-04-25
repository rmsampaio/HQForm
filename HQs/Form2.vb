Imports System.Data.OleDb

Public Class Form2

    Dim Cnn As New OleDbConnection()
    Dim Cmd As OleDbCommand = Cnn.CreateCommand

    Dim Controle As String
    Dim OldKey As String

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        Controle = "P"
        DeActive()
        Cnn.ConnectionString = "Provider=Microsoft.JET.OleDB.4.0;Data Source=E:\HQs\HQs.Mdb"
        Cnn.Open()
        LocReg("")
    End Sub

    Private Sub DeActive()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
    End Sub

    Private Sub DeActiveButton()
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
    End Sub

    Private Sub ActiveButton()
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Controle = "P" Then
            Controle = "I"
            OldKey = TextBox1.Text
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Focus()
            DeActiveButton()
        Else
            If Controle = "I" Then
                Cmd.CommandText = "Insert Into Editora (Codigo, Nome) Values('" & TextBox1.Text & "','" & TextBox2.Text & "')"
            Else
                Cmd.CommandText = "UpDate Editora Set Nome = '" & TextBox2.Text & "' Where Codigo = '" & TextBox1.Text & "'"
            End If
            Cmd.ExecuteNonQuery()
            DeActive()
            ActiveButton()
            Controle = "P"
        End If
    End Sub

    Private Sub LocReg(ByVal Chave As String)

        If Chave = "" Then
            Cmd.CommandText = "Select Top 1 * From Editora Order By Codigo"
        Else
            Cmd.CommandText = "Select * From Editora Where Codigo = '" & Chave & "'"
        End If

        Dim Editoras As OleDbDataReader = Cmd.ExecuteReader()

        While Editoras.Read()
            TextBox1.Text = Editoras.Item(0)
            TextBox2.Text = Editoras.Item(1)
        End While

        Editoras.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Controle = "P" Then
            Controle = "A"
            OldKey = TextBox1.Text
            TextBox2.Enabled = True
            TextBox2.Focus()
            DeActiveButton()
        Else
            Controle = "P"
            LocReg(OldKey)
            DeActive()
            ActiveButton()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Cmd.CommandText = "Delete From Editora Where Codigo = '" & TextBox1.Text & "'"
        Cmd.ExecuteNonQuery()

        LocReg("")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form3.Show()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class