Public Class Form1
    Dim inlogpogingen As Integer = 0
    ''Login en wachtwoord valideren adv een functie
    Private Function ValideerLogin() As Boolean
        If txt_login.Text.Contains(" ") Then
            Return True
        End If
        Return False
    End Function



    Private Function ValideerWachtwoord() As Boolean
        Dim password As String = txt_wachtwoord.Text
        If password.Length >= 8 AndAlso password.Any(Function(c) Char.IsDigit(c)) AndAlso password.Any(Function(c) Not Char.IsLetterOrDigit(c)) Then
            Return True
        End If
        Return False
    End Function



    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If Not ValideerLogin() Then
            MessageBox.Show("Ongeldige gebruikersnaam. Voer uw volledige naam in met een spatie ertussen.", "Foutmelding")
            Return
        End If

        If Not ValideerWachtwoord() Then
            MessageBox.Show("Ongeldig wachtwoord. Het wachtwoord moet 8 tekens lang zijn, een cijfer en een speciaal teken bevatten.", "Foutmelding")
            Return
        End If

        MessageBox.Show("Succesvol ingelogd!", "Succes")
    End Sub




    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_login.Clear()
        txt_wachtwoord.Clear()
    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txt_wachtwoord.PasswordChar = ""
        Else
            txt_wachtwoord.PasswordChar = "*"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_wachtwoord.PasswordChar = "*"
    End Sub
End Class
