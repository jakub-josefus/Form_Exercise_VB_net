<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pg10 = New System.Windows.Forms.ProgressBar()
        Me.barva = New System.Windows.Forms.ComboBox()
        Me.chbDelsi = New System.Windows.Forms.CheckBox()
        Me.chbVyssi = New System.Windows.Forms.CheckBox()
        Me.chbHlubsi = New System.Windows.Forms.CheckBox()
        Me.lbProPosuvnik = New System.Windows.Forms.Label()
        Me.tbPosuvnik = New System.Windows.Forms.TrackBar()
        Me.tbA = New System.Windows.Forms.TextBox()
        Me.tbB = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.greenArrow = New System.Windows.Forms.Button()
        Me.ttNapoveda = New System.Windows.Forms.ToolTip(Me.components)
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btVysledek = New System.Windows.Forms.Button()
        Me.btEsc = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SouborToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtevřítToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VšechnySouboryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UložitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tCasovac = New System.Windows.Forms.Timer(Me.components)
        Me.lbProgressBar = New System.Windows.Forms.Label()
        Me.lbSoucet = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslCas = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslCesta = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tCasovac2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.popis1 = New System.Windows.Forms.Label()
        Me.popis2 = New System.Windows.Forms.Label()
        Me.rbDrevo = New System.Windows.Forms.RadioButton()
        Me.rbKov = New System.Windows.Forms.RadioButton()
        Me.rbPlast = New System.Windows.Forms.RadioButton()
        Me.rbSklo = New System.Windows.Forms.RadioButton()
        Me.gbMaterial = New System.Windows.Forms.GroupBox()
        Me.lbVysledekSelect = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.tbPosuvnik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.gbMaterial.SuspendLayout()
        Me.SuspendLayout()
        '
        'pg10
        '
        Me.pg10.Location = New System.Drawing.Point(81, 470)
        Me.pg10.Name = "pg10"
        Me.pg10.Size = New System.Drawing.Size(364, 26)
        Me.pg10.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pg10.TabIndex = 1
        '
        'barva
        '
        Me.barva.FormattingEnabled = True
        Me.barva.Items.AddRange(New Object() {"default", "hnědá", "červená", "fialová", "zelená", "modrá"})
        Me.barva.Location = New System.Drawing.Point(158, 346)
        Me.barva.Name = "barva"
        Me.barva.Size = New System.Drawing.Size(121, 21)
        Me.barva.TabIndex = 2
        Me.barva.Text = "default"
        '
        'chbDelsi
        '
        Me.chbDelsi.AutoSize = True
        Me.chbDelsi.Location = New System.Drawing.Point(330, 290)
        Me.chbDelsi.Name = "chbDelsi"
        Me.chbDelsi.Size = New System.Drawing.Size(49, 17)
        Me.chbDelsi.TabIndex = 3
        Me.chbDelsi.Tag = ""
        Me.chbDelsi.Text = "delší"
        Me.chbDelsi.UseVisualStyleBackColor = True
        '
        'chbVyssi
        '
        Me.chbVyssi.AutoSize = True
        Me.chbVyssi.Location = New System.Drawing.Point(330, 320)
        Me.chbVyssi.Name = "chbVyssi"
        Me.chbVyssi.Size = New System.Drawing.Size(51, 17)
        Me.chbVyssi.TabIndex = 4
        Me.chbVyssi.Text = "vyšší"
        Me.chbVyssi.UseVisualStyleBackColor = True
        '
        'chbHlubsi
        '
        Me.chbHlubsi.AutoSize = True
        Me.chbHlubsi.Location = New System.Drawing.Point(330, 350)
        Me.chbHlubsi.Name = "chbHlubsi"
        Me.chbHlubsi.Size = New System.Drawing.Size(55, 17)
        Me.chbHlubsi.TabIndex = 5
        Me.chbHlubsi.Text = "hlubší"
        Me.chbHlubsi.UseVisualStyleBackColor = True
        '
        'lbProPosuvnik
        '
        Me.lbProPosuvnik.AutoSize = True
        Me.lbProPosuvnik.Location = New System.Drawing.Point(140, 217)
        Me.lbProPosuvnik.Name = "lbProPosuvnik"
        Me.lbProPosuvnik.Size = New System.Drawing.Size(13, 13)
        Me.lbProPosuvnik.TabIndex = 6
        Me.lbProPosuvnik.Text = "0"
        '
        'tbPosuvnik
        '
        Me.tbPosuvnik.Location = New System.Drawing.Point(56, 169)
        Me.tbPosuvnik.Maximum = 100
        Me.tbPosuvnik.Name = "tbPosuvnik"
        Me.tbPosuvnik.Size = New System.Drawing.Size(200, 45)
        Me.tbPosuvnik.TabIndex = 7
        Me.tbPosuvnik.TickFrequency = 10
        '
        'tbA
        '
        Me.tbA.Location = New System.Drawing.Point(81, 78)
        Me.tbA.Name = "tbA"
        Me.tbA.Size = New System.Drawing.Size(34, 20)
        Me.tbA.TabIndex = 8
        Me.ttNapoveda.SetToolTip(Me.tbA, "Zadej číslo 1")
        '
        'tbB
        '
        Me.tbB.Location = New System.Drawing.Point(143, 78)
        Me.tbB.Name = "tbB"
        Me.tbB.Size = New System.Drawing.Size(34, 20)
        Me.tbB.TabIndex = 9
        Me.ttNapoveda.SetToolTip(Me.tbB, "Zadej číslo 2")
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(404, 45)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(356, 169)
        Me.TextBox3.TabIndex = 11
        Me.TextBox3.Text = "OBSAH SOUBORU:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Toto je obsah soubru načtený tlačítkem Soubor->Otevřít." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Má víc ř" &
    "ádků a lze ho pozměnit a opět uložit tlačítkem Soubor->Uložit."
        Me.ttNapoveda.SetToolTip(Me.TextBox3, "Double click otevře soubor")
        '
        'greenArrow
        '
        Me.greenArrow.BackColor = System.Drawing.Color.White
        Me.greenArrow.BackgroundImage = Global.Start.My.Resources.Resources.green_arrow_2
        Me.greenArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.greenArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.greenArrow.Location = New System.Drawing.Point(500, 405)
        Me.greenArrow.Name = "greenArrow"
        Me.greenArrow.Size = New System.Drawing.Size(228, 91)
        Me.greenArrow.TabIndex = 0
        Me.ttNapoveda.SetToolTip(Me.greenArrow, "Reset progress baru")
        Me.greenArrow.UseVisualStyleBackColor = False
        '
        'ttNapoveda
        '
        Me.ttNapoveda.BackColor = System.Drawing.Color.DarkOrange
        Me.ttNapoveda.IsBalloon = True
        Me.ttNapoveda.ToolTipTitle = "Napoveda"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(211, 79)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(45, 20)
        Me.NumericUpDown1.TabIndex = 15
        Me.ttNapoveda.SetToolTip(Me.NumericUpDown1, "Kliknutím na šipku dostanu součet")
        '
        'btVysledek
        '
        Me.btVysledek.BackColor = System.Drawing.SystemColors.Highlight
        Me.btVysledek.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btVysledek.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btVysledek.Location = New System.Drawing.Point(283, 78)
        Me.btVysledek.Name = "btVysledek"
        Me.btVysledek.Size = New System.Drawing.Size(75, 23)
        Me.btVysledek.TabIndex = 21
        Me.btVysledek.Text = "Výsledek"
        Me.ttNapoveda.SetToolTip(Me.btVysledek, "Taky vypočítá výsledek součtu")
        Me.btVysledek.UseVisualStyleBackColor = False
        '
        'btEsc
        '
        Me.btEsc.BackColor = System.Drawing.Color.Red
        Me.btEsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btEsc.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btEsc.Location = New System.Drawing.Point(668, 242)
        Me.btEsc.Name = "btEsc"
        Me.btEsc.Size = New System.Drawing.Size(60, 37)
        Me.btEsc.TabIndex = 28
        Me.btEsc.Text = "Esc"
        Me.ttNapoveda.SetToolTip(Me.btEsc, "Vypnutí programu")
        Me.btEsc.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SouborToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SouborToolStripMenuItem
        '
        Me.SouborToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OtevřítToolStripMenuItem, Me.UložitToolStripMenuItem})
        Me.SouborToolStripMenuItem.Name = "SouborToolStripMenuItem"
        Me.SouborToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SouborToolStripMenuItem.Text = "Soubor"
        '
        'OtevřítToolStripMenuItem
        '
        Me.OtevřítToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VšechnySouboryToolStripMenuItem, Me.DocToolStripMenuItem})
        Me.OtevřítToolStripMenuItem.Name = "OtevřítToolStripMenuItem"
        Me.OtevřítToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.OtevřítToolStripMenuItem.Text = "Otevřít"
        '
        'VšechnySouboryToolStripMenuItem
        '
        Me.VšechnySouboryToolStripMenuItem.Name = "VšechnySouboryToolStripMenuItem"
        Me.VšechnySouboryToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.VšechnySouboryToolStripMenuItem.Text = "Všechny soubory"
        '
        'DocToolStripMenuItem
        '
        Me.DocToolStripMenuItem.Name = "DocToolStripMenuItem"
        Me.DocToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DocToolStripMenuItem.Text = ".doc"
        '
        'UložitToolStripMenuItem
        '
        Me.UložitToolStripMenuItem.Name = "UložitToolStripMenuItem"
        Me.UložitToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.UložitToolStripMenuItem.Text = "Uložit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'tCasovac
        '
        '
        'lbProgressBar
        '
        Me.lbProgressBar.AutoSize = True
        Me.lbProgressBar.Location = New System.Drawing.Point(78, 512)
        Me.lbProgressBar.Name = "lbProgressBar"
        Me.lbProgressBar.Size = New System.Drawing.Size(65, 13)
        Me.lbProgressBar.TabIndex = 13
        Me.lbProgressBar.Text = "progress bar"
        '
        'lbSoucet
        '
        Me.lbSoucet.AutoSize = True
        Me.lbSoucet.Location = New System.Drawing.Point(133, 123)
        Me.lbSoucet.Name = "lbSoucet"
        Me.lbSoucet.Size = New System.Drawing.Size(58, 13)
        Me.lbSoucet.TabIndex = 14
        Me.lbSoucet.Text = "Součet je: "
        '
        'StatusStrip1
        '
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslCas, Me.tslCesta})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslCas
        '
        Me.tslCas.Name = "tslCas"
        Me.tslCas.Size = New System.Drawing.Size(119, 17)
        Me.tslCas.Text = "ToolStripStatusLabel1"
        '
        'tslCesta
        '
        Me.tslCesta.Name = "tslCesta"
        Me.tslCesta.Size = New System.Drawing.Size(119, 17)
        Me.tslCesta.Text = "ToolStripStatusLabel2"
        '
        'tCasovac2
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "soucet"
        '
        'popis1
        '
        Me.popis1.AutoSize = True
        Me.popis1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.popis1.Location = New System.Drawing.Point(121, 76)
        Me.popis1.Name = "popis1"
        Me.popis1.Size = New System.Drawing.Size(18, 20)
        Me.popis1.TabIndex = 19
        Me.popis1.Text = "+"
        '
        'popis2
        '
        Me.popis2.AutoSize = True
        Me.popis2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.popis2.Location = New System.Drawing.Point(187, 78)
        Me.popis2.Name = "popis2"
        Me.popis2.Size = New System.Drawing.Size(18, 20)
        Me.popis2.TabIndex = 20
        Me.popis2.Text = "="
        '
        'rbDrevo
        '
        Me.rbDrevo.AutoSize = True
        Me.rbDrevo.Location = New System.Drawing.Point(40, 21)
        Me.rbDrevo.Name = "rbDrevo"
        Me.rbDrevo.Size = New System.Drawing.Size(53, 17)
        Me.rbDrevo.TabIndex = 22
        Me.rbDrevo.TabStop = True
        Me.rbDrevo.Text = "dřevo"
        Me.rbDrevo.UseVisualStyleBackColor = True
        '
        'rbKov
        '
        Me.rbKov.AutoSize = True
        Me.rbKov.Location = New System.Drawing.Point(40, 51)
        Me.rbKov.Name = "rbKov"
        Me.rbKov.Size = New System.Drawing.Size(43, 17)
        Me.rbKov.TabIndex = 23
        Me.rbKov.TabStop = True
        Me.rbKov.Text = "kov"
        Me.rbKov.UseVisualStyleBackColor = True
        '
        'rbPlast
        '
        Me.rbPlast.AutoSize = True
        Me.rbPlast.Location = New System.Drawing.Point(40, 81)
        Me.rbPlast.Name = "rbPlast"
        Me.rbPlast.Size = New System.Drawing.Size(47, 17)
        Me.rbPlast.TabIndex = 24
        Me.rbPlast.TabStop = True
        Me.rbPlast.Text = "plast"
        Me.rbPlast.UseVisualStyleBackColor = True
        '
        'rbSklo
        '
        Me.rbSklo.AutoSize = True
        Me.rbSklo.Location = New System.Drawing.Point(40, 111)
        Me.rbSklo.Name = "rbSklo"
        Me.rbSklo.Size = New System.Drawing.Size(44, 17)
        Me.rbSklo.TabIndex = 25
        Me.rbSklo.TabStop = True
        Me.rbSklo.Text = "sklo"
        Me.rbSklo.UseVisualStyleBackColor = True
        '
        'gbMaterial
        '
        Me.gbMaterial.Controls.Add(Me.rbSklo)
        Me.gbMaterial.Controls.Add(Me.rbDrevo)
        Me.gbMaterial.Controls.Add(Me.rbKov)
        Me.gbMaterial.Controls.Add(Me.rbPlast)
        Me.gbMaterial.Location = New System.Drawing.Point(425, 239)
        Me.gbMaterial.Name = "gbMaterial"
        Me.gbMaterial.Size = New System.Drawing.Size(132, 140)
        Me.gbMaterial.TabIndex = 26
        Me.gbMaterial.TabStop = False
        Me.gbMaterial.Text = "Materiál"
        '
        'lbVysledekSelect
        '
        Me.lbVysledekSelect.AutoSize = True
        Me.lbVysledekSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbVysledekSelect.Location = New System.Drawing.Point(78, 421)
        Me.lbVysledekSelect.Name = "lbVysledekSelect"
        Me.lbVysledekSelect.Size = New System.Drawing.Size(52, 24)
        Me.lbVysledekSelect.TabIndex = 27
        Me.lbVysledekSelect.Text = "color"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Otevřít soubor"
        Me.OpenFileDialog1.Filter = "Všechno (*.*)|*.*|Texty (*.txt;*.doc)|*.txt;*.doc"
        Me.OpenFileDialog1.FilterIndex = 2
        Me.OpenFileDialog1.Title = "Zvolte soubor"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "Uložit soubor"
        Me.SaveFileDialog1.Filter = "Všechno (*.*)|*.*|Texty (*.txt;*.doc)|*.txt;*.doc"
        Me.SaveFileDialog1.FilterIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btEsc)
        Me.Controls.Add(Me.lbVysledekSelect)
        Me.Controls.Add(Me.btVysledek)
        Me.Controls.Add(Me.popis2)
        Me.Controls.Add(Me.popis1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.lbSoucet)
        Me.Controls.Add(Me.lbProgressBar)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.tbB)
        Me.Controls.Add(Me.tbA)
        Me.Controls.Add(Me.tbPosuvnik)
        Me.Controls.Add(Me.lbProPosuvnik)
        Me.Controls.Add(Me.chbHlubsi)
        Me.Controls.Add(Me.chbVyssi)
        Me.Controls.Add(Me.chbDelsi)
        Me.Controls.Add(Me.barva)
        Me.Controls.Add(Me.pg10)
        Me.Controls.Add(Me.greenArrow)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gbMaterial)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.tbPosuvnik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.gbMaterial.ResumeLayout(False)
        Me.gbMaterial.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents greenArrow As Windows.Forms.Button
    Friend WithEvents pg10 As Windows.Forms.ProgressBar
    Friend WithEvents barva As Windows.Forms.ComboBox
    Friend WithEvents chbDelsi As Windows.Forms.CheckBox
    Friend WithEvents chbVyssi As Windows.Forms.CheckBox
    Friend WithEvents chbHlubsi As Windows.Forms.CheckBox
    Friend WithEvents lbProPosuvnik As Windows.Forms.Label
    Friend WithEvents tbPosuvnik As Windows.Forms.TrackBar
    Friend WithEvents tbA As Windows.Forms.TextBox
    Friend WithEvents tbB As Windows.Forms.TextBox
    Friend WithEvents TextBox3 As Windows.Forms.TextBox
    Friend WithEvents ttNapoveda As Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents SouborToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtevřítToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents UložitToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tCasovac As Windows.Forms.Timer
    Friend WithEvents lbProgressBar As Windows.Forms.Label
    Friend WithEvents lbSoucet As Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As Windows.Forms.NumericUpDown
    Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
    Friend WithEvents tslCas As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslCesta As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tCasovac2 As Windows.Forms.Timer
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents popis1 As Windows.Forms.Label
    Friend WithEvents popis2 As Windows.Forms.Label
    Friend WithEvents btVysledek As Windows.Forms.Button
    Friend WithEvents rbDrevo As Windows.Forms.RadioButton
    Friend WithEvents rbKov As Windows.Forms.RadioButton
    Friend WithEvents rbPlast As Windows.Forms.RadioButton
    Friend WithEvents rbSklo As Windows.Forms.RadioButton
    Friend WithEvents gbMaterial As Windows.Forms.GroupBox
    Friend WithEvents lbVysledekSelect As Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As Windows.Forms.SaveFileDialog
    Friend WithEvents btEsc As Windows.Forms.Button
    Friend WithEvents VšechnySouboryToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocToolStripMenuItem As Windows.Forms.ToolStripMenuItem
End Class
