Public Class Form
    'Variables
    Dim risk As Integer = 0                 'difficulty
    Dim healthmulti As Integer = 1          'health multiplier
    Dim cshealthmulti As Decimal = 0        'crimespree health multiplier
    Dim hsmulti As Integer = 2              'headshot damage multiplier
    Dim hsclkmulti As Integer = 6           'cloaker headshot damage multiplier
    Dim hsdzrmulti As Integer = 5           'bulldozer headshot damage multiplier
    Dim helmetpopping As Boolean = False    'Helmet Popping skill toggle
    Dim helmetmulti As Decimal = 1          'Helmet Popping damage multiplier
    Dim gundamage As Double                 'Base Weapon Damage
    Dim bemulti As Decimal = 1.0            'Body Expertise Multiplier

    'Difficulty Panel

    Private Sub rbtnNormal_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnNormal.CheckedChanged
        gboxRisk.Text = "Difficulty: Normal"
        risk = 0
        numudCrimespree.Enabled = False
        Call difficultydeclaration(sender, e)
    End Sub

    Private Sub rbtnHard_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnHard.CheckedChanged
        gboxRisk.Text = "Difficulty: 💀"
        risk = 1
        numudCrimespree.Enabled = False
        Call difficultydeclaration(sender, e)
    End Sub

    Private Sub rbtnVeryhard_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnVeryhard.CheckedChanged
        gboxRisk.Text = "Difficulty: 💀💀"
        risk = 2
        numudCrimespree.Enabled = False
        Call difficultydeclaration(sender, e)
    End Sub

    Private Sub rbtnOverkill_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnOverkill.CheckedChanged
        gboxRisk.Text = "Difficulty: 💀💀💀"
        risk = 3
        numudCrimespree.Enabled = False
        Call difficultydeclaration(sender, e)
    End Sub

    Private Sub rbtnMayhem_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMayhem.CheckedChanged
        gboxRisk.Text = "Difficulty: 💀💀💀💀"
        risk = 4
        numudCrimespree.Enabled = False
        Call difficultydeclaration(sender, e)
    End Sub

    Private Sub rbtnDeathwish_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnDeathwish.CheckedChanged
        gboxRisk.Text = "Difficulty: 💀💀💀💀💀"
        risk = 5
        numudCrimespree.Enabled = False
        Call difficultydeclaration(sender, e)
    End Sub

    Private Sub rbtnSponge_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnSponge.CheckedChanged
        gboxRisk.Text = "Difficulty: 💀💀💀💀💀💀"
        risk = 6
        numudCrimespree.Enabled = False
        Call difficultydeclaration(sender, e)
    End Sub

    Private Sub rbtnTickets_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnTickets.CheckedChanged
        gboxRisk.Text = "Crime Spree Lvl: " + CStr(numudCrimespree.Value)
        risk = 7
        numudCrimespree.Enabled = True
        Call difficultydeclaration(sender, e)
    End Sub

    Sub difficultydeclaration(sender As Object, e As EventArgs)
        Select Case risk
            Case 0, 1 'normal, hard
                healthmulti = 1
                hsmulti = 2
                hsclkmulti = 6
                hsdzrmulti = 5
            Case 2 'very hard
                healthmulti = 2
                hsmulti = 4
                hsclkmulti = 12
                hsdzrmulti = 5
            Case 3 'overkill
                healthmulti = 3
                hsmulti = 6
                hsclkmulti = 18
                hsdzrmulti = 10
            Case 4, 5 'mayhem, deathwish
                healthmulti = 6
                hsmulti = 3
                hsclkmulti = 9
                hsdzrmulti = 7.5
            Case 6 'one DOWN
                healthmulti = 9
                hsmulti = 3
                hsclkmulti = 9
                hsdzrmulti = 7.5
            Case 7 'Crime Spree (Uses Overkill stats as a base)
                healthmulti = 3 + (3 * cshealthmulti)
                hsmulti = 6
                hsclkmulti = 18
                hsdzrmulti = 10
        End Select
        Call tboxDamage_TextChanged(sender, e)
    End Sub

    Private Sub numudCrimespree_ValueChanged(sender As Object, e As EventArgs) Handles numudCrimespree.ValueChanged
        cshealthmulti = (Math.Floor(CInt(numudCrimespree.Value) / 50) / 5)
        gboxRisk.Text = "Crime Spree Lvl: " + CStr(numudCrimespree.Value)
        Call difficultydeclaration(sender, e)
    End Sub

    Private Sub tboxDamage_TextChanged(sender As Object, e As EventArgs) Handles tboxDamage.TextChanged
        If tboxDamage.Text = "" Then
            gundamage = 0
        End If
        Try
            If tboxDamage.Text = "" Then
                gundamage = 0
            Else
                gundamage = CSng(tboxDamage.Text) 'If theres an exception here, the try will catch it here and go to the catch block
            End If
            If gundamage > 0 Then
                tboxDamage.BackColor = System.Drawing.SystemColors.Window 'If theres no exception, hide any error messages
                lblGundmgexception.Visible = False
            Else
                tboxDamage.BackColor = Color.Yellow
                lblGundmgexception.Text = "You gun is harmless to enemies!"
                lblGundmgexception.Visible = True
            End If
            lblTrueDmg.Text = CStr(gundamage * bemulti)                                                     'True gun damage labels
            lblTrueHs.Text = CStr(gundamage * helmetmulti * hsmulti)
            tboxLB.Text = CStr(Math.Ceiling((80 * healthmulti) / (gundamage * bemulti)))                    'Light enemies
            tboxLH.Text = CStr(Math.Ceiling((80 * healthmulti) / ((gundamage * hsmulti) * helmetmulti)))
            tboxHB.Text = CStr(Math.Ceiling((160 * healthmulti) / (gundamage * bemulti)))                   'Heavy enemies
            tboxHH.Text = CStr(Math.Ceiling((160 * healthmulti) / ((gundamage * hsmulti) * helmetmulti)))
            tboxTB.Text = CStr(Math.Ceiling((300 * healthmulti) / (gundamage * bemulti)))                   'Tasers/Medics
            tboxTH.Text = CStr(Math.Ceiling((300 * healthmulti) / ((gundamage * hsmulti) * helmetmulti)))
            tboxCB.Text = CStr(Math.Ceiling((600 * healthmulti) / (gundamage * bemulti)))                   'Cloakers
            tboxCH.Text = CStr(Math.Ceiling((600 * healthmulti) / ((gundamage * hsclkmulti) * helmetmulti)))
            tboxBB.Text = CStr(Math.Ceiling((2000 * healthmulti) / gundamage))                              'Bulldozers
            tboxBH.Text = CStr(Math.Ceiling((2000 * healthmulti) / ((gundamage * hsdzrmulti) * helmetmulti)))
        Catch ex As OverflowException 'Too big of a number
            tboxDamage.BackColor = Color.Red
            lblGundmgexception.Text = "Fuck off your gun can't do that much damage"
            lblGundmgexception.Visible = True
        Catch ex As InvalidCastException 'Not a number/invalid cast
            tboxDamage.BackColor = Color.Red
            lblGundmgexception.Text = "Field must contain only a valid number"
            lblGundmgexception.Visible = True
        Catch ex As DivideByZeroException
            tboxDamage.BackColor = Color.Yellow
            lblGundmgexception.Text = "You gun is harmless to enemies!"
            lblGundmgexception.Visible = True
        Catch ex As Exception 'Something else
            tboxDamage.BackColor = Color.Red
            lblGundmgexception.Text = "idk what but you fucked up somehow (" + ex.ToString + ")"
            lblGundmgexception.Visible = True
        End Try
    End Sub

    Private Sub chkboxHelmet_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxHelmet.CheckedChanged
        helmetpopping = chkboxHelmet.Checked
        If helmetpopping = True Then
            helmetmulti = 1.25
        Else
            helmetmulti = 1
        End If
        Call tboxDamage_TextChanged(sender, e)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    'Body Expertise Menu
    Private Sub rbtnBEoff_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBEoff.CheckedChanged
        bemulti = 1
        Call tboxDamage_TextChanged(sender, e)
    End Sub

    Private Sub rbtnBEbasic_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBEbasic.CheckedChanged
        bemulti = 1.3
        Call tboxDamage_TextChanged(sender, e)
    End Sub

    Private Sub rbtnBEace_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBEace.CheckedChanged
        bemulti = 1.9
        Call tboxDamage_TextChanged(sender, e)
    End Sub
End Class