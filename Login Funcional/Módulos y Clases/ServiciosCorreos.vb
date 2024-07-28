Imports System.Net
Imports System.Net.Mail
Public MustInherit Class ServiciosCorreos
    Private clientesmtp As SmtpClient
    Protected senderMail As String
    Protected password As String
    Protected host As String
    Protected port As String
    Protected ssl As Boolean

    Protected Sub inicializarSmtpCliente()
        clientesmtp = New SmtpClient
        clientesmtp.Credentials = New NetworkCredential(senderMail, password)
        clientesmtp.Host = host
        clientesmtp.Port = port
        clientesmtp.EnableSsl = ssl
    End Sub

    Public Sub enviarMail(asunto As String, cuerpo As String, receptor As List(Of String))
        Dim mailMessage As New MailMessage()
        Try
            mailMessage.From = New MailAddress(senderMail)

            For Each recipientMail As String In receptor
                mailMessage.To.Add(recipientMail)
            Next

            mailMessage.Subject = asunto
            mailMessage.Body = cuerpo
            mailMessage.Priority = MailPriority.Normal

            clientesmtp.Send(mailMessage)

        Catch ex As Exception
        Finally
            mailMessage.Dispose()
            clientesmtp.Dispose()

        End Try
    End Sub
End Class
