<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.gboxRisk = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numudCrimespree = New System.Windows.Forms.NumericUpDown()
        Me.rbtnTickets = New System.Windows.Forms.RadioButton()
        Me.rbtnSponge = New System.Windows.Forms.RadioButton()
        Me.rbtnDeathwish = New System.Windows.Forms.RadioButton()
        Me.rbtnMayhem = New System.Windows.Forms.RadioButton()
        Me.rbtnOverkill = New System.Windows.Forms.RadioButton()
        Me.rbtnVeryhard = New System.Windows.Forms.RadioButton()
        Me.rbtnHard = New System.Windows.Forms.RadioButton()
        Me.rbtnNormal = New System.Windows.Forms.RadioButton()
        Me.tboxDamage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gboxSkills = New System.Windows.Forms.GroupBox()
        Me.chkboxHelmet = New System.Windows.Forms.CheckBox()
        Me.gboxBE = New System.Windows.Forms.GroupBox()
        Me.rbtnBEace = New System.Windows.Forms.RadioButton()
        Me.rbtnBEoff = New System.Windows.Forms.RadioButton()
        Me.rbtnBEbasic = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tboxLB = New System.Windows.Forms.TextBox()
        Me.tboxLH = New System.Windows.Forms.TextBox()
        Me.tboxHH = New System.Windows.Forms.TextBox()
        Me.tboxHB = New System.Windows.Forms.TextBox()
        Me.tboxTH = New System.Windows.Forms.TextBox()
        Me.tboxTB = New System.Windows.Forms.TextBox()
        Me.tboxCH = New System.Windows.Forms.TextBox()
        Me.tboxCB = New System.Windows.Forms.TextBox()
        Me.tboxBH = New System.Windows.Forms.TextBox()
        Me.tboxBB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblGundmgexception = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTrueDmg = New System.Windows.Forms.Label()
        Me.lblTrueHs = New System.Windows.Forms.Label()
        Me.tipEnemyInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gboxRisk.SuspendLayout()
        CType(Me.numudCrimespree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxSkills.SuspendLayout()
        Me.gboxBE.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboxRisk
        '
        Me.gboxRisk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gboxRisk.Controls.Add(Me.Label1)
        Me.gboxRisk.Controls.Add(Me.numudCrimespree)
        Me.gboxRisk.Controls.Add(Me.rbtnTickets)
        Me.gboxRisk.Controls.Add(Me.rbtnSponge)
        Me.gboxRisk.Controls.Add(Me.rbtnDeathwish)
        Me.gboxRisk.Controls.Add(Me.rbtnMayhem)
        Me.gboxRisk.Controls.Add(Me.rbtnOverkill)
        Me.gboxRisk.Controls.Add(Me.rbtnVeryhard)
        Me.gboxRisk.Controls.Add(Me.rbtnHard)
        Me.gboxRisk.Controls.Add(Me.rbtnNormal)
        Me.gboxRisk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gboxRisk.Location = New System.Drawing.Point(479, 31)
        Me.gboxRisk.Name = "gboxRisk"
        Me.gboxRisk.Size = New System.Drawing.Size(133, 231)
        Me.gboxRisk.TabIndex = 1
        Me.gboxRisk.TabStop = False
        Me.gboxRisk.Text = "Difficulty: Normal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "CS Level:"
        '
        'numudCrimespree
        '
        Me.numudCrimespree.Enabled = False
        Me.numudCrimespree.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numudCrimespree.Location = New System.Drawing.Point(65, 203)
        Me.numudCrimespree.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numudCrimespree.Name = "numudCrimespree"
        Me.numudCrimespree.Size = New System.Drawing.Size(62, 20)
        Me.numudCrimespree.TabIndex = 24
        '
        'rbtnTickets
        '
        Me.rbtnTickets.AutoSize = True
        Me.rbtnTickets.Location = New System.Drawing.Point(6, 180)
        Me.rbtnTickets.Name = "rbtnTickets"
        Me.rbtnTickets.Size = New System.Drawing.Size(82, 17)
        Me.rbtnTickets.TabIndex = 7
        Me.rbtnTickets.Text = "Crime Spree"
        Me.tipEnemyInfo.SetToolTip(Me.rbtnTickets, resources.GetString("rbtnTickets.ToolTip"))
        Me.rbtnTickets.UseVisualStyleBackColor = True
        '
        'rbtnSponge
        '
        Me.rbtnSponge.AutoSize = True
        Me.rbtnSponge.Location = New System.Drawing.Point(6, 157)
        Me.rbtnSponge.Name = "rbtnSponge"
        Me.rbtnSponge.Size = New System.Drawing.Size(76, 17)
        Me.rbtnSponge.TabIndex = 6
        Me.rbtnSponge.Text = "One Down"
        Me.tipEnemyInfo.SetToolTip(Me.rbtnSponge, "Tremendously Increased XP and Cash" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9 x health multiplier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3 x headshot multiplie" &
        "r" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Spawns:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ZEAL SWAT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shields" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tasers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Medics" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cloakers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bulldozers")
        Me.rbtnSponge.UseVisualStyleBackColor = True
        '
        'rbtnDeathwish
        '
        Me.rbtnDeathwish.AutoSize = True
        Me.rbtnDeathwish.Location = New System.Drawing.Point(6, 134)
        Me.rbtnDeathwish.Name = "rbtnDeathwish"
        Me.rbtnDeathwish.Size = New System.Drawing.Size(75, 17)
        Me.rbtnDeathwish.TabIndex = 5
        Me.rbtnDeathwish.Text = "Deathwish"
        Me.tipEnemyInfo.SetToolTip(Me.rbtnDeathwish, "Tremendously Increased XP and Cash" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6 x health multiplier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3 x headshot multiplie" &
        "r" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Spawns:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GenSec SWAT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shields" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tasers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Medics" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cloakers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bulldozers")
        Me.rbtnDeathwish.UseVisualStyleBackColor = True
        '
        'rbtnMayhem
        '
        Me.rbtnMayhem.AutoSize = True
        Me.rbtnMayhem.Location = New System.Drawing.Point(6, 111)
        Me.rbtnMayhem.Name = "rbtnMayhem"
        Me.rbtnMayhem.Size = New System.Drawing.Size(65, 17)
        Me.rbtnMayhem.TabIndex = 4
        Me.rbtnMayhem.Text = "Mayhem"
        Me.tipEnemyInfo.SetToolTip(Me.rbtnMayhem, "Tremendously Increased XP and Cash" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6 x health multiplier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3 x headshot multiplie" &
        "r" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Spawns:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GenSec SWAT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shields" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tasers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Medics" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cloakers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bulldozers")
        Me.rbtnMayhem.UseVisualStyleBackColor = True
        '
        'rbtnOverkill
        '
        Me.rbtnOverkill.AutoSize = True
        Me.rbtnOverkill.Location = New System.Drawing.Point(6, 88)
        Me.rbtnOverkill.Name = "rbtnOverkill"
        Me.rbtnOverkill.Size = New System.Drawing.Size(60, 17)
        Me.rbtnOverkill.TabIndex = 3
        Me.rbtnOverkill.Text = "Overkill"
        Me.tipEnemyInfo.SetToolTip(Me.rbtnOverkill, "Massively Increased XP and Cash" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3 x health multiplier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6 x headshot multiplier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
        "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Spawns:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FBI SWAT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shields" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tasers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Medics" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cloakers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bulldozers")
        Me.rbtnOverkill.UseVisualStyleBackColor = True
        '
        'rbtnVeryhard
        '
        Me.rbtnVeryhard.AutoSize = True
        Me.rbtnVeryhard.Location = New System.Drawing.Point(6, 65)
        Me.rbtnVeryhard.Name = "rbtnVeryhard"
        Me.rbtnVeryhard.Size = New System.Drawing.Size(72, 17)
        Me.rbtnVeryhard.TabIndex = 2
        Me.rbtnVeryhard.Text = "Very Hard"
        Me.tipEnemyInfo.SetToolTip(Me.rbtnVeryhard, "Greatly Increased XP and Cash" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2 x health multiplier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4 x headshot multiplier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
        "Spawns:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FBI SWAT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shields" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tasers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cloakers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bulldozers")
        Me.rbtnVeryhard.UseVisualStyleBackColor = True
        '
        'rbtnHard
        '
        Me.rbtnHard.AutoSize = True
        Me.rbtnHard.Location = New System.Drawing.Point(6, 42)
        Me.rbtnHard.Name = "rbtnHard"
        Me.rbtnHard.Size = New System.Drawing.Size(48, 17)
        Me.rbtnHard.TabIndex = 1
        Me.rbtnHard.Text = "Hard"
        Me.tipEnemyInfo.SetToolTip(Me.rbtnHard, "Increased XP and Cash" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No health multiplier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2 x headshot multiplier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Spawns:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
        "Metropolitian SWAT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shields" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tasers")
        Me.rbtnHard.UseVisualStyleBackColor = True
        '
        'rbtnNormal
        '
        Me.rbtnNormal.AutoSize = True
        Me.rbtnNormal.Checked = True
        Me.rbtnNormal.Location = New System.Drawing.Point(6, 19)
        Me.rbtnNormal.Name = "rbtnNormal"
        Me.rbtnNormal.Size = New System.Drawing.Size(58, 17)
        Me.rbtnNormal.TabIndex = 0
        Me.rbtnNormal.TabStop = True
        Me.rbtnNormal.Text = "Normal"
        Me.tipEnemyInfo.SetToolTip(Me.rbtnNormal, "No risk reward" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No health multiplier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2 x headshot multiplier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Spawns:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Metropo" &
        "litian SWAT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shields")
        Me.rbtnNormal.UseVisualStyleBackColor = True
        '
        'tboxDamage
        '
        Me.tboxDamage.BackColor = System.Drawing.SystemColors.Window
        Me.tboxDamage.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tboxDamage.Location = New System.Drawing.Point(91, 31)
        Me.tboxDamage.Name = "tboxDamage"
        Me.tboxDamage.Size = New System.Drawing.Size(100, 20)
        Me.tboxDamage.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Gun Damage:"
        '
        'gboxSkills
        '
        Me.gboxSkills.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gboxSkills.Controls.Add(Me.chkboxHelmet)
        Me.gboxSkills.Controls.Add(Me.gboxBE)
        Me.gboxSkills.Location = New System.Drawing.Point(362, 31)
        Me.gboxSkills.Name = "gboxSkills"
        Me.gboxSkills.Size = New System.Drawing.Size(111, 133)
        Me.gboxSkills.TabIndex = 4
        Me.gboxSkills.TabStop = False
        Me.gboxSkills.Text = "Skills"
        '
        'chkboxHelmet
        '
        Me.chkboxHelmet.AutoSize = True
        Me.chkboxHelmet.Location = New System.Drawing.Point(6, 113)
        Me.chkboxHelmet.Name = "chkboxHelmet"
        Me.chkboxHelmet.Size = New System.Drawing.Size(101, 17)
        Me.chkboxHelmet.TabIndex = 1
        Me.chkboxHelmet.Text = "Helmet Popping"
        Me.tipEnemyInfo.SetToolTip(Me.chkboxHelmet, "Increases your headshot damage by 25%")
        Me.chkboxHelmet.UseVisualStyleBackColor = True
        '
        'gboxBE
        '
        Me.gboxBE.Controls.Add(Me.rbtnBEace)
        Me.gboxBE.Controls.Add(Me.rbtnBEoff)
        Me.gboxBE.Controls.Add(Me.rbtnBEbasic)
        Me.gboxBE.Location = New System.Drawing.Point(7, 20)
        Me.gboxBE.Name = "gboxBE"
        Me.gboxBE.Size = New System.Drawing.Size(91, 87)
        Me.gboxBE.TabIndex = 0
        Me.gboxBE.TabStop = False
        Me.gboxBE.Text = "Body Expertise"
        '
        'rbtnBEace
        '
        Me.rbtnBEace.AutoSize = True
        Me.rbtnBEace.Location = New System.Drawing.Point(6, 65)
        Me.rbtnBEace.Name = "rbtnBEace"
        Me.rbtnBEace.Size = New System.Drawing.Size(50, 17)
        Me.rbtnBEace.TabIndex = 2
        Me.rbtnBEace.Text = "Aced"
        Me.tipEnemyInfo.SetToolTip(Me.rbtnBEace, "90% from the bonus headshot damage is" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "permanently applied to hitting enemies" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on" &
        " the body.")
        Me.rbtnBEace.UseVisualStyleBackColor = True
        '
        'rbtnBEoff
        '
        Me.rbtnBEoff.AutoSize = True
        Me.rbtnBEoff.Checked = True
        Me.rbtnBEoff.Location = New System.Drawing.Point(6, 19)
        Me.rbtnBEoff.Name = "rbtnBEoff"
        Me.rbtnBEoff.Size = New System.Drawing.Size(51, 17)
        Me.rbtnBEoff.TabIndex = 0
        Me.rbtnBEoff.TabStop = True
        Me.rbtnBEoff.Text = "None"
        Me.tipEnemyInfo.SetToolTip(Me.rbtnBEoff, "0% from the bonus headshot damage is" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "permanently applied to hitting enemies" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on " &
        "the body." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.rbtnBEoff.UseVisualStyleBackColor = True
        '
        'rbtnBEbasic
        '
        Me.rbtnBEbasic.AutoSize = True
        Me.rbtnBEbasic.Location = New System.Drawing.Point(6, 42)
        Me.rbtnBEbasic.Name = "rbtnBEbasic"
        Me.rbtnBEbasic.Size = New System.Drawing.Size(51, 17)
        Me.rbtnBEbasic.TabIndex = 1
        Me.rbtnBEbasic.Text = "Basic"
        Me.tipEnemyInfo.SetToolTip(Me.rbtnBEbasic, "30% from the bonus headshot damage is" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "permanently applied to hitting enemies" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on" &
        " the body.")
        Me.rbtnBEbasic.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Bodyshots:"
        Me.tipEnemyInfo.SetToolTip(Me.Label3, "Center mass for fucks sake!")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(154, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Headshots:"
        Me.tipEnemyInfo.SetToolTip(Me.Label4, "Keep those helmets flying!")
        '
        'tboxLB
        '
        Me.tboxLB.Location = New System.Drawing.Point(91, 96)
        Me.tboxLB.Name = "tboxLB"
        Me.tboxLB.Size = New System.Drawing.Size(60, 20)
        Me.tboxLB.TabIndex = 7
        Me.tboxLB.Text = "0"
        '
        'tboxLH
        '
        Me.tboxLH.Location = New System.Drawing.Point(157, 96)
        Me.tboxLH.Name = "tboxLH"
        Me.tboxLH.Size = New System.Drawing.Size(60, 20)
        Me.tboxLH.TabIndex = 8
        Me.tboxLH.Text = "0"
        '
        'tboxHH
        '
        Me.tboxHH.Location = New System.Drawing.Point(157, 122)
        Me.tboxHH.Name = "tboxHH"
        Me.tboxHH.Size = New System.Drawing.Size(60, 20)
        Me.tboxHH.TabIndex = 10
        Me.tboxHH.Text = "0"
        '
        'tboxHB
        '
        Me.tboxHB.Location = New System.Drawing.Point(91, 122)
        Me.tboxHB.Name = "tboxHB"
        Me.tboxHB.Size = New System.Drawing.Size(60, 20)
        Me.tboxHB.TabIndex = 9
        Me.tboxHB.Text = "0"
        '
        'tboxTH
        '
        Me.tboxTH.Location = New System.Drawing.Point(157, 148)
        Me.tboxTH.Name = "tboxTH"
        Me.tboxTH.Size = New System.Drawing.Size(60, 20)
        Me.tboxTH.TabIndex = 12
        Me.tboxTH.Text = "0"
        '
        'tboxTB
        '
        Me.tboxTB.Location = New System.Drawing.Point(91, 148)
        Me.tboxTB.Name = "tboxTB"
        Me.tboxTB.Size = New System.Drawing.Size(60, 20)
        Me.tboxTB.TabIndex = 11
        Me.tboxTB.Text = "0"
        '
        'tboxCH
        '
        Me.tboxCH.Location = New System.Drawing.Point(157, 174)
        Me.tboxCH.Name = "tboxCH"
        Me.tboxCH.Size = New System.Drawing.Size(60, 20)
        Me.tboxCH.TabIndex = 14
        Me.tboxCH.Text = "0"
        '
        'tboxCB
        '
        Me.tboxCB.Location = New System.Drawing.Point(91, 174)
        Me.tboxCB.Name = "tboxCB"
        Me.tboxCB.Size = New System.Drawing.Size(60, 20)
        Me.tboxCB.TabIndex = 13
        Me.tboxCB.Text = "0"
        '
        'tboxBH
        '
        Me.tboxBH.Location = New System.Drawing.Point(157, 200)
        Me.tboxBH.Name = "tboxBH"
        Me.tboxBH.Size = New System.Drawing.Size(60, 20)
        Me.tboxBH.TabIndex = 16
        Me.tboxBH.Text = "0"
        '
        'tboxBB
        '
        Me.tboxBB.Location = New System.Drawing.Point(91, 200)
        Me.tboxBB.Name = "tboxBB"
        Me.tboxBB.Size = New System.Drawing.Size(60, 20)
        Me.tboxBB.TabIndex = 15
        Me.tboxBB.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Light Enemy:"
        Me.tipEnemyInfo.SetToolTip(Me.Label5, resources.GetString("Label5.ToolTip"))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Heavy Enemy:"
        Me.tipEnemyInfo.SetToolTip(Me.Label6, "Heavy SWAT/Yellow SWAT (Normal - Hard)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Maximum Force Responders/Tan SWAT (Very H" &
        "ard - Overkill)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GenSec MFR/Grey Tan SWAT (Mayhem - Death Wish)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ZEAL Heavy SWAT" &
        "/ZEAL Tan SWAT (One Down)")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Taser/Medic:"
        Me.tipEnemyInfo.SetToolTip(Me.Label7, "Tasers do not appear normally on Normal difficulty" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Medics do not appear normally" &
        " on Very Hard or below")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Cloaker:"
        Me.tipEnemyInfo.SetToolTip(Me.Label8, "Cloakers do not appear normally on Hard or below")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Bulldozer:"
        Me.tipEnemyInfo.SetToolTip(Me.Label9, "Bulldozers do not appear normally on Hard or below" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Warning!!! This calculator " &
        "does NOT account for the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "bulldozer's faceplate! The actual shots-to-kill may" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "b" &
        "e higher than shown!")
        '
        'lblGundmgexception
        '
        Me.lblGundmgexception.AutoSize = True
        Me.lblGundmgexception.ForeColor = System.Drawing.Color.Red
        Me.lblGundmgexception.Location = New System.Drawing.Point(12, 54)
        Me.lblGundmgexception.Name = "lblGundmgexception"
        Me.lblGundmgexception.Size = New System.Drawing.Size(146, 13)
        Me.lblGundmgexception.TabIndex = 22
        Me.lblGundmgexception.Text = "This should not be visible yet!"
        Me.lblGundmgexception.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(220, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "True Gun damage:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(223, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "True Headshot damage:"
        '
        'lblTrueDmg
        '
        Me.lblTrueDmg.AutoSize = True
        Me.lblTrueDmg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTrueDmg.Location = New System.Drawing.Point(223, 99)
        Me.lblTrueDmg.Name = "lblTrueDmg"
        Me.lblTrueDmg.Size = New System.Drawing.Size(15, 15)
        Me.lblTrueDmg.TabIndex = 27
        Me.lblTrueDmg.Text = "0"
        '
        'lblTrueHs
        '
        Me.lblTrueHs.AutoSize = True
        Me.lblTrueHs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTrueHs.Location = New System.Drawing.Point(223, 151)
        Me.lblTrueHs.Name = "lblTrueHs"
        Me.lblTrueHs.Size = New System.Drawing.Size(15, 15)
        Me.lblTrueHs.TabIndex = 28
        Me.lblTrueHs.Text = "0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(624, 24)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 273)
        Me.Controls.Add(Me.lblTrueHs)
        Me.Controls.Add(Me.lblTrueDmg)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblGundmgexception)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tboxBH)
        Me.Controls.Add(Me.tboxBB)
        Me.Controls.Add(Me.tboxCH)
        Me.Controls.Add(Me.tboxCB)
        Me.Controls.Add(Me.tboxTH)
        Me.Controls.Add(Me.tboxTB)
        Me.Controls.Add(Me.tboxHH)
        Me.Controls.Add(Me.tboxHB)
        Me.Controls.Add(Me.tboxLH)
        Me.Controls.Add(Me.tboxLB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gboxSkills)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tboxDamage)
        Me.Controls.Add(Me.gboxRisk)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MinimumSize = New System.Drawing.Size(640, 312)
        Me.Name = "Form"
        Me.Text = "PAYDAY 2 Breakpoints Calculator"
        Me.gboxRisk.ResumeLayout(False)
        Me.gboxRisk.PerformLayout()
        CType(Me.numudCrimespree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxSkills.ResumeLayout(False)
        Me.gboxSkills.PerformLayout()
        Me.gboxBE.ResumeLayout(False)
        Me.gboxBE.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gboxRisk As GroupBox
    Friend WithEvents rbtnSponge As RadioButton
    Friend WithEvents rbtnDeathwish As RadioButton
    Friend WithEvents rbtnMayhem As RadioButton
    Friend WithEvents rbtnOverkill As RadioButton
    Friend WithEvents rbtnVeryhard As RadioButton
    Friend WithEvents rbtnHard As RadioButton
    Friend WithEvents rbtnNormal As RadioButton
    Friend WithEvents tboxDamage As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gboxSkills As GroupBox
    Friend WithEvents gboxBE As GroupBox
    Friend WithEvents rbtnBEace As RadioButton
    Friend WithEvents rbtnBEoff As RadioButton
    Friend WithEvents rbtnBEbasic As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tboxLB As TextBox
    Friend WithEvents tboxLH As TextBox
    Friend WithEvents tboxHH As TextBox
    Friend WithEvents tboxHB As TextBox
    Friend WithEvents tboxTH As TextBox
    Friend WithEvents tboxTB As TextBox
    Friend WithEvents tboxCH As TextBox
    Friend WithEvents tboxCB As TextBox
    Friend WithEvents tboxBH As TextBox
    Friend WithEvents tboxBB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblGundmgexception As Label
    Friend WithEvents chkboxHelmet As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents numudCrimespree As NumericUpDown
    Friend WithEvents rbtnTickets As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblTrueDmg As Label
    Friend WithEvents lblTrueHs As Label
    Friend WithEvents tipEnemyInfo As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
