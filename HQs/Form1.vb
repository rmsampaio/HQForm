Public Class Form1

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        End
    End Sub

    Private Sub EditoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditoraToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub TituloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TituloToolStripMenuItem.Click
        '        Form4.Show()
    End Sub

    Private Sub SagaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SagaToolStripMenuItem.Click
        '        Form6.Show()
    End Sub

    Private Sub TipoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoToolStripMenuItem.Click
        '        Form8.Show()
    End Sub

    Private Sub EdiçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EdiçãoToolStripMenuItem.Click
        '       Form10.Show()
    End Sub
End Class
