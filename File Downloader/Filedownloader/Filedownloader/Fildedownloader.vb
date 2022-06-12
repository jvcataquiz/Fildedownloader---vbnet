
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
        AddHandler webDownloader.DownloadProgressChanged, AddressOf ProgChanged
        webDownloader.DownloadFileAsync(New Uri(TextBoxUrl.Text), TextBoxLocation.Text + "\" + TextBoxFilename.Text)
    End Sub

    Private Sub ProgChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        ProgressBarPercentageDownload.Value = e.ProgressPercentage
        LabelPercentage.Text = e.ProgressPercentage.ToString() + " %"
        String.Format("{0} MB's/ {1} MB's", (e.BytesReceived / 1024D / 1024D).ToString("0.00"), (e.TotalBytesToReceive / 1024D / 1024D).ToString("0.00"))
    End Sub

    Private Sub Fildedownloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        webDownloader = New WebClient()
    End Sub

    Private Sub updater1_Tick(sender As Object, e As EventArgs) Handles updater1.Tick
        If TextBoxFilename.Text.Length > 1 Then
            ButtonDownload.Visible = True
            ProgressBarPercentageDownload.Visible = True
        End If
    End Sub
End Class
