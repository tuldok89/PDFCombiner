Imports PdfSharp

Public Class frmMain
    Dim outputPdf As Pdf.PdfDocument
    Dim lstListView As List(Of ListViewItem)

    Private Sub btnHelp_Click(sender As System.Object, e As System.EventArgs) Handles btnHelp.Click
        cmsHelp.Show(btnHelp, New Point(0, btnHelp.Height))
    End Sub

    Sub AddFile(path As String)
        Dim location = My.Computer.FileSystem.GetParentPath(path)
        Dim filename = IO.Path.GetFileName(path)
        Dim filesize = GetFileSize(path)

        lvFiles.Items.Add(filename, 0)

        Dim currentItem = lvFiles.Items.Count - 1

        lvFiles.Items(currentItem).SubItems.Add(location)
        lvFiles.Items(currentItem).SubItems.Add("0")
        lvFiles.Items(currentItem).SubItems.Add(filesize)
    End Sub

    Function GetFileSize(path As String) As String
        Dim tmpStream As New IO.FileStream(path, IO.FileMode.Open, IO.FileAccess.Read)
        Dim startSize As Double = tmpStream.Length
        Dim strBuilder As New System.Text.StringBuilder
        tmpStream.Dispose()

        If startSize > 1024 * 1024 * 1024 Then 'greater than 1KB
            Dim result = startSize / 1024 / 1024 / 1024
            strBuilder.Append(result.ToString("0.00")).Append(" GB")
            Return strBuilder.ToString()
        ElseIf startSize > 1024 * 1024 Then 'greater than 1MB
            Dim result = startSize / 1024 / 1024
            strBuilder.Append(result.ToString("0.00")).Append(" MB")
            Return strBuilder.ToString()
        ElseIf startSize > 1024 Then 'greater than 1GB
            Dim result = startSize \ 1024
            strBuilder.Append(result.ToString("0")).Append(" kB")
            Return strBuilder.ToString()
        Else 'less than 1kB
            strBuilder.Append(startSize).Append(" B")
            Return strBuilder.ToString()
        End If

    End Function

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnAddFiles_Click(sender As System.Object, e As System.EventArgs) Handles btnAddFiles.Click
        Dim dlgResult = ofdAdd.ShowDialog()

        If dlgResult = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        For Each file In ofdAdd.FileNames
            AddFile(file)
        Next
    End Sub

    Private Sub btnCombine_Click(sender As System.Object, e As System.EventArgs) Handles btnCombine.Click
        lstListView = New List(Of ListViewItem)
        For Each item In lvFiles.Items
            lstListView.Add(item)
        Next
        bwCombine.RunWorkerAsync()
    End Sub

    Private Sub bwCombine_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwCombine.DoWork
        outputPdf = New Pdf.PdfDocument()

        For fileidx As Integer = 0 To lstListView.Count - 1
            Dim fullPath = My.Computer.FileSystem.CombinePath(lstListView(fileidx).SubItems(1).Text, lstListView(fileidx).Text)
            Dim inputDocument = Pdf.IO.PdfReader.Open(fullPath, Pdf.IO.PdfDocumentOpenMode.Import)
            Dim count = inputDocument.PageCount

            For pageidx As Integer = 0 To count - 1
                Dim page = inputDocument.Pages(pageidx)
                page.Rotate = Integer.Parse(lstListView(fileidx).SubItems(2).Text)
                outputPdf.AddPage(page)
            Next

            bwCombine.ReportProgress(fileidx)
        Next

    End Sub

    Private Sub bwCombine_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwCombine.ProgressChanged
        lvFiles.Items(e.ProgressPercentage).SubItems(4).Text = "Done"
    End Sub

    Private Sub bwCombine_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwCombine.RunWorkerCompleted
        Dim dlgResult = sfdOutput.ShowDialog

        If dlgResult = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        outputPdf.Save(sfdOutput.FileName)
    End Sub
End Class
