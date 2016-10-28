Public Class FORMUTAMA

    Public Shared Sub BukaFormChild(form As Form)
        With form
            .MdiParent = FORMUTAMA
            .Show()
        End With
    End Sub

    Private Sub RadMenuItem7_Click(sender As Object, e As EventArgs) Handles RadMenuItemKeluar.Click
        Application.Exit()
    End Sub

    Private Sub RadMenuItemKavling_Click(sender As Object, e As EventArgs) Handles RadMenuItemKavling.Click
        Dim daftarkavling As New FORMDATAKAVLING
        BukaFormChild(daftarkavling)
    End Sub

    Private Sub RadMenuItemRegKavling_Click(sender As Object, e As EventArgs) Handles RadMenuItemRegKavling.Click
        Dim registerkavling As New FORMKAVLING
        BukaFormChild(registerkavling)
    End Sub

    Private Sub RadMenuItemMYSQLDB_Click(sender As Object, e As EventArgs) Handles RadMenuItemMYSQLDB.Click
        Dim inisialdb As New FORMINISIALSQLDB
        inisialdb.ShowDialog()
    End Sub
End Class
