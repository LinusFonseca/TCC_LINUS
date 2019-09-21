<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supervisorio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supervisorio))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBox_AvailableSerialPorts = New System.Windows.Forms.ComboBox()
        Me.Button_Disconnect = New System.Windows.Forms.Button()
        Me.Button_Connect = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.temp3 = New System.Windows.Forms.TextBox()
        Me.Valv1r = New System.Windows.Forms.PictureBox()
        Me.Panela3cheia = New System.Windows.Forms.PictureBox()
        Me.Panela3vazia = New System.Windows.Forms.PictureBox()
        Me.Valv1g = New System.Windows.Forms.PictureBox()
        Me.Panela1meia = New System.Windows.Forms.PictureBox()
        Me.Panela1vazia = New System.Windows.Forms.PictureBox()
        Me.bomba1P = New System.Windows.Forms.PictureBox()
        Me.bomba1M = New System.Windows.Forms.PictureBox()
        Me.Valv2r = New System.Windows.Forms.PictureBox()
        Me.Valv2g = New System.Windows.Forms.PictureBox()
        Me.Valv3r = New System.Windows.Forms.PictureBox()
        Me.Valv3g = New System.Windows.Forms.PictureBox()
        Me.bomba2P = New System.Windows.Forms.PictureBox()
        Me.bomba2M = New System.Windows.Forms.PictureBox()
        Me.Panela1cheia = New System.Windows.Forms.PictureBox()
        Me.Panela2Malte = New System.Windows.Forms.PictureBox()
        Me.Panela2cheia = New System.Windows.Forms.PictureBox()
        Me.Fogo2 = New System.Windows.Forms.PictureBox()
        Me.Fogo3 = New System.Windows.Forms.PictureBox()
        Me.Etapabox = New System.Windows.Forms.TextBox()
        Me.Fogo1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.temp1 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Referencia2TextBox = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.temp2 = New System.Windows.Forms.TextBox()
        Me.estadoTextBox = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ResfriamentoTextBox = New System.Windows.Forms.TextBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FervuraTextBox = New System.Windows.Forms.TextBox()
        Me.Lupulo1TextBox = New System.Windows.Forms.TextBox()
        Me.Lupulo3TextBox = New System.Windows.Forms.TextBox()
        Me.Lupulo2TextBox = New System.Windows.Forms.TextBox()
        Me.Rampa1TextBox = New System.Windows.Forms.TextBox()
        Me.Rampa3TextBox = New System.Windows.Forms.TextBox()
        Me.Rampa2TextBox = New System.Windows.Forms.TextBox()
        Me.EnviarButton = New System.Windows.Forms.Button()
        Me.MinRampa1TextBox = New System.Windows.Forms.TextBox()
        Me.MinRampa3TextBox = New System.Windows.Forms.TextBox()
        Me.MinRampa2TextBox = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Referencia1Textbox = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Valv1r, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panela3cheia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panela3vazia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Valv1g, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panela1meia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panela1vazia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bomba1P, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bomba1M, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Valv2r, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Valv2g, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Valv3r, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Valv3g, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bomba2P, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bomba2M, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panela1cheia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panela2Malte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panela2cheia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fogo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fogo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ComboBox_AvailableSerialPorts
        '
        Me.ComboBox_AvailableSerialPorts.FormattingEnabled = True
        Me.ComboBox_AvailableSerialPorts.Location = New System.Drawing.Point(147, 72)
        Me.ComboBox_AvailableSerialPorts.Name = "ComboBox_AvailableSerialPorts"
        Me.ComboBox_AvailableSerialPorts.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox_AvailableSerialPorts.TabIndex = 80
        '
        'Button_Disconnect
        '
        Me.Button_Disconnect.Location = New System.Drawing.Point(307, 72)
        Me.Button_Disconnect.Name = "Button_Disconnect"
        Me.Button_Disconnect.Size = New System.Drawing.Size(86, 23)
        Me.Button_Disconnect.TabIndex = 81
        Me.Button_Disconnect.Text = "Disconnect"
        Me.Button_Disconnect.UseVisualStyleBackColor = True
        '
        'Button_Connect
        '
        Me.Button_Connect.Location = New System.Drawing.Point(307, 72)
        Me.Button_Connect.Name = "Button_Connect"
        Me.Button_Connect.Size = New System.Drawing.Size(86, 23)
        Me.Button_Connect.TabIndex = 82
        Me.Button_Connect.Text = "Connect"
        Me.Button_Connect.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(130, 18)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(36, 22)
        Me.TextBox3.TabIndex = 91
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(130, 62)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(36, 22)
        Me.TextBox4.TabIndex = 92
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(130, 103)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(36, 22)
        Me.TextBox5.TabIndex = 93
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(130, 148)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(36, 22)
        Me.TextBox6.TabIndex = 94
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(130, 189)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(36, 22)
        Me.TextBox7.TabIndex = 95
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(130, 232)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(36, 22)
        Me.TextBox8.TabIndex = 96
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(15, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(89, 20)
        Me.Label24.TabIndex = 97
        Me.Label24.Text = "Chama 1:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(31, 148)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(73, 20)
        Me.Label28.TabIndex = 100
        Me.Label28.Text = "Nível 1:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(31, 191)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(73, 20)
        Me.Label29.TabIndex = 101
        Me.Label29.Text = "Nível 2:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(31, 234)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(73, 20)
        Me.Label30.TabIndex = 102
        Me.Label30.Text = "Nível 3:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(15, 62)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(89, 20)
        Me.Label26.TabIndex = 103
        Me.Label26.Text = "Chama 2:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(15, 103)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(89, 20)
        Me.Label27.TabIndex = 104
        Me.Label27.Text = "Chama 3:"
        '
        'Timer3
        '
        Me.Timer3.Interval = 10000
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.Controls.Add(Me.TextBox7)
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Location = New System.Drawing.Point(1342, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(181, 278)
        Me.GroupBox3.TabIndex = 108
        Me.GroupBox3.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(765, 95)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(156, 20)
        Me.Label20.TabIndex = 113
        Me.Label20.Text = "Temperatura(°C):"
        '
        'temp3
        '
        Me.temp3.Location = New System.Drawing.Point(954, 96)
        Me.temp3.Name = "temp3"
        Me.temp3.Size = New System.Drawing.Size(59, 22)
        Me.temp3.TabIndex = 112
        '
        'Valv1r
        '
        Me.Valv1r.Image = Global.WindowsApplication1.My.Resources.Resources.SolenoideRED
        Me.Valv1r.Location = New System.Drawing.Point(1273, 519)
        Me.Valv1r.Name = "Valv1r"
        Me.Valv1r.Size = New System.Drawing.Size(49, 43)
        Me.Valv1r.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Valv1r.TabIndex = 60
        Me.Valv1r.TabStop = False
        '
        'Panela3cheia
        '
        Me.Panela3cheia.ErrorImage = Nothing
        Me.Panela3cheia.Image = CType(resources.GetObject("Panela3cheia.Image"), System.Drawing.Image)
        Me.Panela3cheia.InitialImage = Nothing
        Me.Panela3cheia.Location = New System.Drawing.Point(1049, 30)
        Me.Panela3cheia.Name = "Panela3cheia"
        Me.Panela3cheia.Size = New System.Drawing.Size(161, 169)
        Me.Panela3cheia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Panela3cheia.TabIndex = 34
        Me.Panela3cheia.TabStop = False
        '
        'Panela3vazia
        '
        Me.Panela3vazia.ErrorImage = Nothing
        Me.Panela3vazia.Image = CType(resources.GetObject("Panela3vazia.Image"), System.Drawing.Image)
        Me.Panela3vazia.InitialImage = Nothing
        Me.Panela3vazia.Location = New System.Drawing.Point(1049, 30)
        Me.Panela3vazia.Name = "Panela3vazia"
        Me.Panela3vazia.Size = New System.Drawing.Size(161, 169)
        Me.Panela3vazia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Panela3vazia.TabIndex = 35
        Me.Panela3vazia.TabStop = False
        Me.Panela3vazia.Visible = False
        '
        'Valv1g
        '
        Me.Valv1g.Image = Global.WindowsApplication1.My.Resources.Resources.SolenoideVerde
        Me.Valv1g.Location = New System.Drawing.Point(1273, 519)
        Me.Valv1g.Name = "Valv1g"
        Me.Valv1g.Size = New System.Drawing.Size(49, 43)
        Me.Valv1g.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Valv1g.TabIndex = 59
        Me.Valv1g.TabStop = False
        Me.Valv1g.Visible = False
        '
        'Panela1meia
        '
        Me.Panela1meia.ErrorImage = Nothing
        Me.Panela1meia.Image = CType(resources.GetObject("Panela1meia.Image"), System.Drawing.Image)
        Me.Panela1meia.InitialImage = Nothing
        Me.Panela1meia.Location = New System.Drawing.Point(1072, 474)
        Me.Panela1meia.Name = "Panela1meia"
        Me.Panela1meia.Size = New System.Drawing.Size(134, 134)
        Me.Panela1meia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Panela1meia.TabIndex = 37
        Me.Panela1meia.TabStop = False
        '
        'Panela1vazia
        '
        Me.Panela1vazia.ErrorImage = Nothing
        Me.Panela1vazia.Image = CType(resources.GetObject("Panela1vazia.Image"), System.Drawing.Image)
        Me.Panela1vazia.InitialImage = Nothing
        Me.Panela1vazia.Location = New System.Drawing.Point(1072, 474)
        Me.Panela1vazia.Name = "Panela1vazia"
        Me.Panela1vazia.Size = New System.Drawing.Size(134, 134)
        Me.Panela1vazia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Panela1vazia.TabIndex = 38
        Me.Panela1vazia.TabStop = False
        Me.Panela1vazia.Visible = False
        '
        'bomba1P
        '
        Me.bomba1P.Image = CType(resources.GetObject("bomba1P.Image"), System.Drawing.Image)
        Me.bomba1P.Location = New System.Drawing.Point(1273, 316)
        Me.bomba1P.Name = "bomba1P"
        Me.bomba1P.Size = New System.Drawing.Size(49, 50)
        Me.bomba1P.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bomba1P.TabIndex = 42
        Me.bomba1P.TabStop = False
        '
        'bomba1M
        '
        Me.bomba1M.Image = CType(resources.GetObject("bomba1M.Image"), System.Drawing.Image)
        Me.bomba1M.Location = New System.Drawing.Point(1273, 316)
        Me.bomba1M.Name = "bomba1M"
        Me.bomba1M.Size = New System.Drawing.Size(49, 50)
        Me.bomba1M.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bomba1M.TabIndex = 43
        Me.bomba1M.TabStop = False
        Me.bomba1M.Visible = False
        '
        'Valv2r
        '
        Me.Valv2r.Image = Global.WindowsApplication1.My.Resources.Resources.SolenoideRED___Copy
        Me.Valv2r.Location = New System.Drawing.Point(1273, 412)
        Me.Valv2r.Name = "Valv2r"
        Me.Valv2r.Size = New System.Drawing.Size(49, 45)
        Me.Valv2r.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Valv2r.TabIndex = 61
        Me.Valv2r.TabStop = False
        '
        'Valv2g
        '
        Me.Valv2g.Image = Global.WindowsApplication1.My.Resources.Resources.SolenoideVerde___Copy
        Me.Valv2g.Location = New System.Drawing.Point(1273, 412)
        Me.Valv2g.Name = "Valv2g"
        Me.Valv2g.Size = New System.Drawing.Size(49, 45)
        Me.Valv2g.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Valv2g.TabIndex = 62
        Me.Valv2g.TabStop = False
        Me.Valv2g.Visible = False
        '
        'Valv3r
        '
        Me.Valv3r.Image = Global.WindowsApplication1.My.Resources.Resources.SolenoideRED___Copy
        Me.Valv3r.Location = New System.Drawing.Point(1273, 199)
        Me.Valv3r.Name = "Valv3r"
        Me.Valv3r.Size = New System.Drawing.Size(49, 45)
        Me.Valv3r.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Valv3r.TabIndex = 63
        Me.Valv3r.TabStop = False
        '
        'Valv3g
        '
        Me.Valv3g.Image = Global.WindowsApplication1.My.Resources.Resources.SolenoideVerde___Copy
        Me.Valv3g.Location = New System.Drawing.Point(1273, 200)
        Me.Valv3g.Name = "Valv3g"
        Me.Valv3g.Size = New System.Drawing.Size(49, 45)
        Me.Valv3g.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Valv3g.TabIndex = 64
        Me.Valv3g.TabStop = False
        Me.Valv3g.Visible = False
        '
        'bomba2P
        '
        Me.bomba2P.Image = CType(resources.GetObject("bomba2P.Image"), System.Drawing.Image)
        Me.bomba2P.Location = New System.Drawing.Point(1273, 74)
        Me.bomba2P.Name = "bomba2P"
        Me.bomba2P.Size = New System.Drawing.Size(49, 50)
        Me.bomba2P.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bomba2P.TabIndex = 70
        Me.bomba2P.TabStop = False
        '
        'bomba2M
        '
        Me.bomba2M.Image = CType(resources.GetObject("bomba2M.Image"), System.Drawing.Image)
        Me.bomba2M.Location = New System.Drawing.Point(1273, 74)
        Me.bomba2M.Name = "bomba2M"
        Me.bomba2M.Size = New System.Drawing.Size(49, 50)
        Me.bomba2M.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bomba2M.TabIndex = 71
        Me.bomba2M.TabStop = False
        Me.bomba2M.Visible = False
        '
        'Panela1cheia
        '
        Me.Panela1cheia.ErrorImage = Nothing
        Me.Panela1cheia.Image = CType(resources.GetObject("Panela1cheia.Image"), System.Drawing.Image)
        Me.Panela1cheia.InitialImage = Nothing
        Me.Panela1cheia.Location = New System.Drawing.Point(1072, 473)
        Me.Panela1cheia.Name = "Panela1cheia"
        Me.Panela1cheia.Size = New System.Drawing.Size(134, 134)
        Me.Panela1cheia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Panela1cheia.TabIndex = 73
        Me.Panela1cheia.TabStop = False
        '
        'Panela2Malte
        '
        Me.Panela2Malte.ErrorImage = Nothing
        Me.Panela2Malte.Image = CType(resources.GetObject("Panela2Malte.Image"), System.Drawing.Image)
        Me.Panela2Malte.InitialImage = Nothing
        Me.Panela2Malte.Location = New System.Drawing.Point(1060, 250)
        Me.Panela2Malte.Name = "Panela2Malte"
        Me.Panela2Malte.Size = New System.Drawing.Size(150, 151)
        Me.Panela2Malte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Panela2Malte.TabIndex = 74
        Me.Panela2Malte.TabStop = False
        '
        'Panela2cheia
        '
        Me.Panela2cheia.ErrorImage = Nothing
        Me.Panela2cheia.Image = CType(resources.GetObject("Panela2cheia.Image"), System.Drawing.Image)
        Me.Panela2cheia.InitialImage = Nothing
        Me.Panela2cheia.Location = New System.Drawing.Point(1060, 250)
        Me.Panela2cheia.Name = "Panela2cheia"
        Me.Panela2cheia.Size = New System.Drawing.Size(150, 151)
        Me.Panela2cheia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Panela2cheia.TabIndex = 76
        Me.Panela2cheia.TabStop = False
        '
        'Fogo2
        '
        Me.Fogo2.Image = CType(resources.GetObject("Fogo2.Image"), System.Drawing.Image)
        Me.Fogo2.Location = New System.Drawing.Point(1083, 407)
        Me.Fogo2.Name = "Fogo2"
        Me.Fogo2.Size = New System.Drawing.Size(127, 39)
        Me.Fogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Fogo2.TabIndex = 77
        Me.Fogo2.TabStop = False
        '
        'Fogo3
        '
        Me.Fogo3.Image = CType(resources.GetObject("Fogo3.Image"), System.Drawing.Image)
        Me.Fogo3.Location = New System.Drawing.Point(1072, 205)
        Me.Fogo3.Name = "Fogo3"
        Me.Fogo3.Size = New System.Drawing.Size(127, 39)
        Me.Fogo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Fogo3.TabIndex = 79
        Me.Fogo3.TabStop = False
        '
        'Etapabox
        '
        Me.Etapabox.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etapabox.ForeColor = System.Drawing.Color.Black
        Me.Etapabox.Location = New System.Drawing.Point(1049, 673)
        Me.Etapabox.Multiline = True
        Me.Etapabox.Name = "Etapabox"
        Me.Etapabox.Size = New System.Drawing.Size(257, 54)
        Me.Etapabox.TabIndex = 16
        '
        'Fogo1
        '
        Me.Fogo1.Image = CType(resources.GetObject("Fogo1.Image"), System.Drawing.Image)
        Me.Fogo1.Location = New System.Drawing.Point(1083, 614)
        Me.Fogo1.Name = "Fogo1"
        Me.Fogo1.Size = New System.Drawing.Size(127, 39)
        Me.Fogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Fogo1.TabIndex = 78
        Me.Fogo1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox2.Location = New System.Drawing.Point(1019, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(6, 5)
        Me.GroupBox2.TabIndex = 107
        Me.GroupBox2.TabStop = False
        '
        'temp1
        '
        Me.temp1.Location = New System.Drawing.Point(967, 531)
        Me.temp1.Name = "temp1"
        Me.temp1.Size = New System.Drawing.Size(59, 22)
        Me.temp1.TabIndex = 154
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(914, 688)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 20)
        Me.Label18.TabIndex = 148
        Me.Label18.Text = "Etapa Atual:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(778, 531)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(156, 20)
        Me.Label19.TabIndex = 153
        Me.Label19.Text = "Temperatura(°C):"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(778, 237)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(147, 20)
        Me.Label25.TabIndex = 158
        Me.Label25.Text = "Referência (°C):"
        '
        'Referencia2TextBox
        '
        Me.Referencia2TextBox.Location = New System.Drawing.Point(967, 237)
        Me.Referencia2TextBox.Name = "Referencia2TextBox"
        Me.Referencia2TextBox.Size = New System.Drawing.Size(59, 22)
        Me.Referencia2TextBox.TabIndex = 157
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(778, 296)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(156, 20)
        Me.Label21.TabIndex = 156
        Me.Label21.Text = "Temperatura(°C):"
        '
        'temp2
        '
        Me.temp2.Location = New System.Drawing.Point(967, 296)
        Me.temp2.Name = "temp2"
        Me.temp2.Size = New System.Drawing.Size(59, 22)
        Me.temp2.TabIndex = 155
        '
        'estadoTextBox
        '
        Me.estadoTextBox.Location = New System.Drawing.Point(926, 654)
        Me.estadoTextBox.Name = "estadoTextBox"
        Me.estadoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.estadoTextBox.TabIndex = 152
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(532, 121)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(196, 32)
        Me.Label22.TabIndex = 151
        Me.Label22.Text = "Resfriamento"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(569, 204)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(119, 17)
        Me.Label23.TabIndex = 150
        Me.Label23.Text = "Temperatura (°C)"
        '
        'ResfriamentoTextBox
        '
        Me.ResfriamentoTextBox.Location = New System.Drawing.Point(572, 227)
        Me.ResfriamentoTextBox.Name = "ResfriamentoTextBox"
        Me.ResfriamentoTextBox.Size = New System.Drawing.Size(116, 22)
        Me.ResfriamentoTextBox.TabIndex = 125
        '
        'ResetButton
        '
        Me.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ResetButton.BackColor = System.Drawing.Color.Red
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.Black
        Me.ResetButton.Location = New System.Drawing.Point(572, 536)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(138, 90)
        Me.ResetButton.TabIndex = 149
        Me.ResetButton.Text = "RESET"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(31, 384)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(182, 25)
        Me.Label17.TabIndex = 147
        Me.Label17.Text = "Tempo de fervura"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(71, 416)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 17)
        Me.Label16.TabIndex = 146
        Me.Label16.Text = "Tempo (min)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(208, 118)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(130, 36)
        Me.Label15.TabIndex = 145
        Me.Label15.Text = "Mostura"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(208, 334)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 32)
        Me.Label14.TabIndex = 144
        Me.Label14.Text = "Fervura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(354, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Rampa 3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(222, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 25)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "Rampa 2"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(329, 384)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(191, 25)
        Me.Label13.TabIndex = 141
        Me.Label13.Text = "Adições de Lúpulo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(492, 416)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 17)
        Me.Label12.TabIndex = 140
        Me.Label12.Text = "Tempo (min)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(371, 416)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 17)
        Me.Label11.TabIndex = 139
        Me.Label11.Text = "Tempo (min)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(258, 416)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 17)
        Me.Label10.TabIndex = 138
        Me.Label10.Text = "Tempo (min)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(363, 268)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 17)
        Me.Label9.TabIndex = 137
        Me.Label9.Text = "Tempo (min)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(224, 268)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 17)
        Me.Label8.TabIndex = 136
        Me.Label8.Text = "Tempo (min)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(81, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 17)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "Tempo (min)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(343, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 17)
        Me.Label6.TabIndex = 134
        Me.Label6.Text = "Temperatura (°C)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 17)
        Me.Label5.TabIndex = 133
        Me.Label5.Text = "Temperatura (°C)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 17)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "Temperatura (°C)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 25)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "Rampa 1"
        '
        'FervuraTextBox
        '
        Me.FervuraTextBox.Location = New System.Drawing.Point(63, 439)
        Me.FervuraTextBox.Name = "FervuraTextBox"
        Me.FervuraTextBox.Size = New System.Drawing.Size(100, 22)
        Me.FervuraTextBox.TabIndex = 126
        '
        'Lupulo1TextBox
        '
        Me.Lupulo1TextBox.Location = New System.Drawing.Point(254, 436)
        Me.Lupulo1TextBox.Name = "Lupulo1TextBox"
        Me.Lupulo1TextBox.Size = New System.Drawing.Size(92, 22)
        Me.Lupulo1TextBox.TabIndex = 127
        '
        'Lupulo3TextBox
        '
        Me.Lupulo3TextBox.Location = New System.Drawing.Point(488, 436)
        Me.Lupulo3TextBox.Name = "Lupulo3TextBox"
        Me.Lupulo3TextBox.Size = New System.Drawing.Size(92, 22)
        Me.Lupulo3TextBox.TabIndex = 129
        '
        'Lupulo2TextBox
        '
        Me.Lupulo2TextBox.Location = New System.Drawing.Point(374, 436)
        Me.Lupulo2TextBox.Name = "Lupulo2TextBox"
        Me.Lupulo2TextBox.Size = New System.Drawing.Size(92, 22)
        Me.Lupulo2TextBox.TabIndex = 128
        '
        'Rampa1TextBox
        '
        Me.Rampa1TextBox.Location = New System.Drawing.Point(77, 227)
        Me.Rampa1TextBox.Name = "Rampa1TextBox"
        Me.Rampa1TextBox.Size = New System.Drawing.Size(92, 22)
        Me.Rampa1TextBox.TabIndex = 119
        '
        'Rampa3TextBox
        '
        Me.Rampa3TextBox.Location = New System.Drawing.Point(359, 227)
        Me.Rampa3TextBox.Name = "Rampa3TextBox"
        Me.Rampa3TextBox.Size = New System.Drawing.Size(92, 22)
        Me.Rampa3TextBox.TabIndex = 123
        '
        'Rampa2TextBox
        '
        Me.Rampa2TextBox.Location = New System.Drawing.Point(220, 227)
        Me.Rampa2TextBox.Name = "Rampa2TextBox"
        Me.Rampa2TextBox.Size = New System.Drawing.Size(92, 22)
        Me.Rampa2TextBox.TabIndex = 121
        '
        'EnviarButton
        '
        Me.EnviarButton.Location = New System.Drawing.Point(194, 511)
        Me.EnviarButton.Name = "EnviarButton"
        Me.EnviarButton.Size = New System.Drawing.Size(152, 75)
        Me.EnviarButton.TabIndex = 130
        Me.EnviarButton.Text = "Enviar"
        Me.EnviarButton.UseVisualStyleBackColor = True
        '
        'MinRampa1TextBox
        '
        Me.MinRampa1TextBox.Location = New System.Drawing.Point(77, 288)
        Me.MinRampa1TextBox.Name = "MinRampa1TextBox"
        Me.MinRampa1TextBox.Size = New System.Drawing.Size(92, 22)
        Me.MinRampa1TextBox.TabIndex = 120
        '
        'MinRampa3TextBox
        '
        Me.MinRampa3TextBox.Location = New System.Drawing.Point(359, 288)
        Me.MinRampa3TextBox.Name = "MinRampa3TextBox"
        Me.MinRampa3TextBox.Size = New System.Drawing.Size(92, 22)
        Me.MinRampa3TextBox.TabIndex = 124
        '
        'MinRampa2TextBox
        '
        Me.MinRampa2TextBox.Location = New System.Drawing.Point(220, 288)
        Me.MinRampa2TextBox.Name = "MinRampa2TextBox"
        Me.MinRampa2TextBox.Size = New System.Drawing.Size(92, 22)
        Me.MinRampa2TextBox.TabIndex = 122
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(174, 9)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(207, 36)
        Me.Label31.TabIndex = 159
        Me.Label31.Text = "Comunicação"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(778, 489)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(147, 20)
        Me.Label32.TabIndex = 162
        Me.Label32.Text = "Referência (°C):"
        '
        'Referencia1Textbox
        '
        Me.Referencia1Textbox.Location = New System.Drawing.Point(967, 489)
        Me.Referencia1Textbox.Name = "Referencia1Textbox"
        Me.Referencia1Textbox.Size = New System.Drawing.Size(59, 22)
        Me.Referencia1Textbox.TabIndex = 161
        '
        'Supervisorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1695, 755)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Referencia1Textbox)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Button_Connect)
        Me.Controls.Add(Me.temp1)
        Me.Controls.Add(Me.Button_Disconnect)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.ComboBox_AvailableSerialPorts)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Referencia2TextBox)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.temp2)
        Me.Controls.Add(Me.estadoTextBox)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.ResfriamentoTextBox)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FervuraTextBox)
        Me.Controls.Add(Me.Lupulo1TextBox)
        Me.Controls.Add(Me.Lupulo3TextBox)
        Me.Controls.Add(Me.Lupulo2TextBox)
        Me.Controls.Add(Me.Rampa1TextBox)
        Me.Controls.Add(Me.Rampa3TextBox)
        Me.Controls.Add(Me.Rampa2TextBox)
        Me.Controls.Add(Me.EnviarButton)
        Me.Controls.Add(Me.MinRampa1TextBox)
        Me.Controls.Add(Me.MinRampa3TextBox)
        Me.Controls.Add(Me.MinRampa2TextBox)
        Me.Controls.Add(Me.Etapabox)
        Me.Controls.Add(Me.Fogo3)
        Me.Controls.Add(Me.Fogo1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Fogo2)
        Me.Controls.Add(Me.Panela2cheia)
        Me.Controls.Add(Me.Panela2Malte)
        Me.Controls.Add(Me.Panela1cheia)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.bomba2M)
        Me.Controls.Add(Me.temp3)
        Me.Controls.Add(Me.bomba2P)
        Me.Controls.Add(Me.Valv3g)
        Me.Controls.Add(Me.Valv1r)
        Me.Controls.Add(Me.Valv3r)
        Me.Controls.Add(Me.Panela3cheia)
        Me.Controls.Add(Me.Valv2g)
        Me.Controls.Add(Me.Valv1g)
        Me.Controls.Add(Me.Valv2r)
        Me.Controls.Add(Me.Panela1meia)
        Me.Controls.Add(Me.bomba1M)
        Me.Controls.Add(Me.Panela1vazia)
        Me.Controls.Add(Me.bomba1P)
        Me.Controls.Add(Me.Panela3vazia)
        Me.Name = "Supervisorio"
        Me.Text = "Form1"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Valv1r, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panela3cheia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panela3vazia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Valv1g, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panela1meia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panela1vazia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bomba1P, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bomba1M, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Valv2r, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Valv2g, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Valv3r, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Valv3g, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bomba2P, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bomba2M, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panela1cheia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panela2Malte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panela2cheia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fogo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fogo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fogo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ComboBox_AvailableSerialPorts As System.Windows.Forms.ComboBox
    Friend WithEvents Button_Disconnect As System.Windows.Forms.Button
    Friend WithEvents Button_Connect As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents temp3 As System.Windows.Forms.TextBox
    Friend WithEvents Valv1r As System.Windows.Forms.PictureBox
    Friend WithEvents Panela3cheia As System.Windows.Forms.PictureBox
    Friend WithEvents Panela3vazia As System.Windows.Forms.PictureBox
    Friend WithEvents Valv1g As System.Windows.Forms.PictureBox
    Friend WithEvents Panela1meia As System.Windows.Forms.PictureBox
    Friend WithEvents Panela1vazia As System.Windows.Forms.PictureBox
    Friend WithEvents bomba1P As System.Windows.Forms.PictureBox
    Friend WithEvents bomba1M As System.Windows.Forms.PictureBox
    Friend WithEvents Valv2r As System.Windows.Forms.PictureBox
    Friend WithEvents Valv2g As System.Windows.Forms.PictureBox
    Friend WithEvents Valv3r As System.Windows.Forms.PictureBox
    Friend WithEvents Valv3g As System.Windows.Forms.PictureBox
    Friend WithEvents bomba2P As System.Windows.Forms.PictureBox
    Friend WithEvents bomba2M As System.Windows.Forms.PictureBox
    Friend WithEvents Panela1cheia As System.Windows.Forms.PictureBox
    Friend WithEvents Panela2Malte As System.Windows.Forms.PictureBox
    Friend WithEvents Panela2cheia As System.Windows.Forms.PictureBox
    Friend WithEvents Fogo2 As System.Windows.Forms.PictureBox
    Friend WithEvents Fogo3 As System.Windows.Forms.PictureBox
    Friend WithEvents Etapabox As System.Windows.Forms.TextBox
    Friend WithEvents Fogo1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents temp1 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Referencia2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents temp2 As System.Windows.Forms.TextBox
    Friend WithEvents estadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents ResfriamentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FervuraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lupulo1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lupulo3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lupulo2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rampa1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rampa3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rampa2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnviarButton As System.Windows.Forms.Button
    Friend WithEvents MinRampa1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents MinRampa3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents MinRampa2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Referencia1Textbox As System.Windows.Forms.TextBox

End Class
