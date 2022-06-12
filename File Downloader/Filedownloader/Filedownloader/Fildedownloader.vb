
Imports System.Net
Public Class Fildedownloader
    Dim webDownloader As WebClient
    Private Sub ButtonDownload_Click(sender As Object, e As EventArgs) Handles ButtonDownload.Click
        webDownloader = New WebClient()
    End Sub
End Class
