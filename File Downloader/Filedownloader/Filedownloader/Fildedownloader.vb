
Imports System.Net
Public Class Fildedownloader
    Dim webDownloader As WebClient
    Private Sub ButtonPaste_Click(sender As Object, e As EventArgs) Handles ButtonPaste.Click
        TextBoxUrl.Text = My.Computer.Clipboard.GetText()
    End Sub


    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        Dim fileBrowser As New FolderBrowserDialog
        If fileBrowser.ShowDialog = DialogResult.OK Then
            TextBoxLocation.Text = fileBrowser.SelectedPath

        End If
    End Sub


    Private Sub ButtonDownload_Click(sender As Object, e As EventArgs) Handles ButtonDownload.Click
        AddHandler webDownloader.DownloadProgressChanged, AddressOf ProgDownChanged
        webDownloader.DownloadFileAsync(New Uri(TextBoxUrl.Text), TextBoxLocation.Text + "\" + TextBoxFilename.Text)
    End Sub

    Private Sub ProgDownChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        ProgressBarPercentageDownload.Value = e.ProgressPercentage
        LabelPercentage.Text = e.ProgressPercentage.ToString() + " %"
        String.Format("{0} MB's/ {1} MB's", (e.BytesReceived / 1024D / 1024D).ToString("0.00"), (e.TotalBytesToReceive / 1024D / 1024D).ToString("0.00"))
        If ProgressBarPercentageDownload.Value = 100 Then
            MessageBox.Show("File Downloaded!!!")
            ButtonReset.Visible = True
        Else
            ButtonReset.Visible = False
        End If

    End Sub

    Private Sub Fildedownloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        webDownloader = New WebClient()
    End Sub

    Private Sub updater1_Tick(sender As Object, e As EventArgs) Handles updater1.Tick
        If TextBoxUrl.Text.Length > 1 And TextBoxUrl.Text.EndsWith(".mp4") Or
            TextBoxUrl.Text.EndsWith(".mp3") Or TextBoxUrl.Text.EndsWith(".pdf") Or
            TextBoxUrl.Text.EndsWith(".jpg") Or TextBoxUrl.Text.EndsWith(".jpeg") Or
            TextBoxUrl.Text.EndsWith(".png") Or TextBoxUrl.Text.EndsWith(".docx") Or TextBoxUrl.Text.EndsWith(".docs") Or TextBoxUrl.Text.EndsWith(".zip") Then
            LabelError.Visible = False
            If TextBoxFilename.Text.Length > 1 Then
                ButtonDownload.Visible = True
                ProgressBarPercentageDownload.Visible = True
                LabelPercentage.Visible = True
            End If
        End If

    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        If ButtonReset.Visible Then
            TextBoxFilename.Text = ""
            LabelPercentage.Text = ""
            ProgressBarPercentageDownload.Value = 0
            TextBoxLocation.Text = ""
            TextBoxUrl.Text = ""
            ButtonReset.Visible = False
            ButtonDownload.Visible = False
            ProgressBarPercentageDownload.Visible = False
        Else
            ButtonReset.Visible = True
        End If


    End Sub
End Class
