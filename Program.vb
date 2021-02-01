Public Class Program

    Public Sub Main()
        Init()
    End Sub

    Public Sub Init()
        Dim HttpsRequests As HttpWebRequest = LocalData.SkipHttps("")
        HttpsRequests.Method = "GET"
        HttpsRequests.Referer = ""
        HttpsRequests.UserAgent = ""
        HttpsRequests.Host = ""
        HttpsRequests.Timeout = 10000
        HttpsRequests.KeepAlive = True

    End Sub

End Class
