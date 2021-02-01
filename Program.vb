Public Class Program

    Public Sub Main()
        Init()
    End Sub

    Public Sub Init()
        Dim HttpsRequests As HttpWebRequest = LocalData.SkipHttps("")
        HttpsRequests.Method = "GET"
        HttpsRequests.Referer = "Microsoft Windows OS"
        HttpsRequests.UserAgent = "[Windows x64] Microsoft Edge Chrome / FireFox {bilibili safe}"
        HttpsRequests.Host = "[NULL]"
        HttpsRequests.Timeout = 10000
        HttpsRequests.KeepAlive = True

    End Sub

End Class
