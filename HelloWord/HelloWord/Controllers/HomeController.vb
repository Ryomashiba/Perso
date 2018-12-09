Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller
        ' GET: Home
        Function Index(id As String)
            Return "hello " + id 'affiche hello + le paramettre indiquer de l'URL si celui ci est un string
        End Function
    End Class
End Namespace