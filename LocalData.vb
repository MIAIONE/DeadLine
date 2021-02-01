

Public Class LocalData

    Public Shared Function SkipHttps(url As String) As HttpWebRequest
        Dim request As HttpWebRequest
        If url.StartsWith("https://", StringComparison.CurrentCultureIgnoreCase) Then
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13 Or SecurityProtocolType.Tls12 Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls Or SecurityProtocolType.Ssl3
            ServicePointManager.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(AddressOf CheckValidationResult)
            request = WebRequest.Create(url)
            request.ProtocolVersion = HttpVersion.Version11
        Else
            request = WebRequest.Create(url)
        End If
        Return request
    End Function
    Private Shared Function CheckValidationResult(sender As Object, certificate As X509Certificate, chain As X509Chain, errors As SslPolicyErrors) As Boolean
        Return True
    End Function
End Class
