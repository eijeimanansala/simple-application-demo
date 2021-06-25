Imports System.Data.SqlClient
Public Class Connection
    Public constring As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Desktop\Desktop\demo-project\Application\Application\Database1.mdf;Integrated Security=True"
    Public con As New SqlConnection(constring)
End Class
