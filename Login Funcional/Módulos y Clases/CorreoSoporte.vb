Public Class CorreoSoporte
    Inherits ServiciosCorreos

    Public Sub New()
        senderMail = "asistenciaprograma@gmail.com"
        password = "oddunfssxopgtqyk"
        host = "smtp.gmail.com"
        port = 587
        ssl = True
        inicializarSmtpCliente()
    End Sub
End Class
