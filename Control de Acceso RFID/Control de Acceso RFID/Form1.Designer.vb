<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PictureBoxselect = New System.Windows.Forms.PictureBox()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.ButtonUser_data = New System.Windows.Forms.Button()
        Me.ButtonConexion = New System.Windows.Forms.Button()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.PanelConnection = New System.Windows.Forms.Panel()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.LabelBaudRate = New System.Windows.Forms.Label()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.ButtonScanPort = New System.Windows.Forms.Button()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.PictureBoxStatus = New System.Windows.Forms.PictureBox()
        Me.LabelDateTime = New System.Windows.Forms.Label()
        Me.PanelTopHeader = New System.Windows.Forms.Panel()
        Me.PanelUserData = New System.Windows.Forms.Panel()
        Me.GroupBoxDatailData = New System.Windows.Forms.GroupBox()
        Me.LabelHora = New System.Windows.Forms.Label()
        Me.LabelCarrera = New System.Windows.Forms.Label()
        Me.LabelID2 = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.GroupBoxImage = New System.Windows.Forms.GroupBox()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.PictureBoxUserImage = New System.Windows.Forms.PictureBox()
        Me.PanelUserRegistration = New System.Windows.Forms.Panel()
        Me.PanelReadingTagProces = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ButtonCloseReadingTag = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBoxRegistro = New System.Windows.Forms.GroupBox()
        Me.PictureBoxImagePreview = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeleccionarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorraSeleccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefrescarToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.RefrescarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBoxByID = New System.Windows.Forms.CheckBox()
        Me.CheckBoxByName = New System.Windows.Forms.CheckBox()
        Me.TextBoxBusqueda = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBoxImagen = New System.Windows.Forms.GroupBox()
        Me.PictureBoxImageInput = New System.Windows.Forms.PictureBox()
        Me.GroupBoxID = New System.Windows.Forms.GroupBox()
        Me.Labelplaceid = New System.Windows.Forms.Label()
        Me.LabelGETID = New System.Windows.Forms.Label()
        Me.ButtonScannID = New System.Windows.Forms.Button()
        Me.ButtonClearForm = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.TextBoxCarrera = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TimerTimeDate = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSerialIn = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBoxselect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelConnection.SuspendLayout()
        CType(Me.PictureBoxStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUserData.SuspendLayout()
        Me.GroupBoxDatailData.SuspendLayout()
        Me.GroupBoxImage.SuspendLayout()
        CType(Me.PictureBoxUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUserRegistration.SuspendLayout()
        Me.PanelReadingTagProces.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxRegistro.SuspendLayout()
        CType(Me.PictureBoxImagePreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBoxImagen.SuspendLayout()
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxID.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.PictureBoxselect)
        Me.PanelMenu.Controls.Add(Me.ButtonRegister)
        Me.PanelMenu.Controls.Add(Me.ButtonUser_data)
        Me.PanelMenu.Controls.Add(Me.ButtonConexion)
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(324, 720)
        Me.PanelMenu.TabIndex = 0
        '
        'PictureBoxselect
        '
        Me.PictureBoxselect.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBoxselect.Image = Global.Control_de_Acceso_RFID.My.Resources.Resources.Select_icon
        Me.PictureBoxselect.Location = New System.Drawing.Point(-19, 194)
        Me.PictureBoxselect.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBoxselect.Name = "PictureBoxselect"
        Me.PictureBoxselect.Size = New System.Drawing.Size(49, 60)
        Me.PictureBoxselect.TabIndex = 2
        Me.PictureBoxselect.TabStop = False
        '
        'ButtonRegister
        '
        Me.ButtonRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegister.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegister.ForeColor = System.Drawing.Color.White
        Me.ButtonRegister.Image = Global.Control_de_Acceso_RFID.My.Resources.Resources.Edit_user_icon
        Me.ButtonRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRegister.Location = New System.Drawing.Point(35, 459)
        Me.ButtonRegister.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(300, 89)
        Me.ButtonRegister.TabIndex = 4
        Me.ButtonRegister.Text = "Registro de Usuarios"
        Me.ButtonRegister.UseVisualStyleBackColor = False
        '
        'ButtonUser_data
        '
        Me.ButtonUser_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonUser_data.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonUser_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUser_data.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUser_data.ForeColor = System.Drawing.Color.White
        Me.ButtonUser_data.Image = Global.Control_de_Acceso_RFID.My.Resources.Resources.Profile_user_icon
        Me.ButtonUser_data.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonUser_data.Location = New System.Drawing.Point(35, 318)
        Me.ButtonUser_data.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonUser_data.Name = "ButtonUser_data"
        Me.ButtonUser_data.Size = New System.Drawing.Size(300, 89)
        Me.ButtonUser_data.TabIndex = 3
        Me.ButtonUser_data.Text = "Información de Usuario"
        Me.ButtonUser_data.UseVisualStyleBackColor = False
        '
        'ButtonConexion
        '
        Me.ButtonConexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonConexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConexion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConexion.ForeColor = System.Drawing.Color.White
        Me.ButtonConexion.Image = Global.Control_de_Acceso_RFID.My.Resources.Resources.Conexion_icon
        Me.ButtonConexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonConexion.Location = New System.Drawing.Point(35, 178)
        Me.ButtonConexion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonConexion.Name = "ButtonConexion"
        Me.ButtonConexion.Size = New System.Drawing.Size(300, 89)
        Me.ButtonConexion.TabIndex = 2
        Me.ButtonConexion.Text = "Conexión"
        Me.ButtonConexion.UseVisualStyleBackColor = False
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBoxLogo.Image = Global.Control_de_Acceso_RFID.My.Resources.Resources.luminisoft_LOGO
        Me.PictureBoxLogo.Location = New System.Drawing.Point(35, 10)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(229, 162)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 1
        Me.PictureBoxLogo.TabStop = False
        '
        'PanelConnection
        '
        Me.PanelConnection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelConnection.BackColor = System.Drawing.Color.White
        Me.PanelConnection.Controls.Add(Me.ButtonConnect)
        Me.PanelConnection.Controls.Add(Me.ComboBoxBaudRate)
        Me.PanelConnection.Controls.Add(Me.LabelBaudRate)
        Me.PanelConnection.Controls.Add(Me.ComboBoxPort)
        Me.PanelConnection.Controls.Add(Me.ButtonScanPort)
        Me.PanelConnection.Location = New System.Drawing.Point(332, 42)
        Me.PanelConnection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelConnection.Name = "PanelConnection"
        Me.PanelConnection.Size = New System.Drawing.Size(899, 657)
        Me.PanelConnection.TabIndex = 5
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonConnect.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConnect.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConnect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonConnect.Location = New System.Drawing.Point(13, 65)
        Me.ButtonConnect.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(868, 30)
        Me.ButtonConnect.TabIndex = 4
        Me.ButtonConnect.Text = "Conectar"
        Me.ButtonConnect.UseVisualStyleBackColor = False
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBaudRate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBaudRate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"1200", "1400", "4800" & Global.Microsoft.VisualBasic.ChrW(9), "9600", "14400", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(792, 20)
        Me.ComboBoxBaudRate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(89, 24)
        Me.ComboBoxBaudRate.TabIndex = 3
        '
        'LabelBaudRate
        '
        Me.LabelBaudRate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelBaudRate.AutoSize = True
        Me.LabelBaudRate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelBaudRate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBaudRate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.LabelBaudRate.Location = New System.Drawing.Point(717, 25)
        Me.LabelBaudRate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelBaudRate.Name = "LabelBaudRate"
        Me.LabelBaudRate.Size = New System.Drawing.Size(62, 16)
        Me.LabelBaudRate.TabIndex = 2
        Me.LabelBaudRate.Text = "Baudaje"
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxPort.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPort.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(133, 20)
        Me.ComboBoxPort.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(577, 24)
        Me.ComboBoxPort.TabIndex = 1
        '
        'ButtonScanPort
        '
        Me.ButtonScanPort.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonScanPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScanPort.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanPort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonScanPort.Location = New System.Drawing.Point(13, 20)
        Me.ButtonScanPort.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonScanPort.Name = "ButtonScanPort"
        Me.ButtonScanPort.Size = New System.Drawing.Size(113, 31)
        Me.ButtonScanPort.TabIndex = 0
        Me.ButtonScanPort.Text = "Puerto"
        Me.ButtonScanPort.UseVisualStyleBackColor = False
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.Location = New System.Drawing.Point(331, 2)
        Me.LabelStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(248, 16)
        Me.LabelStatus.TabIndex = 0
        Me.LabelStatus.Text = "Estatus de Conexión: Desconectado"
        '
        'PictureBoxStatus
        '
        Me.PictureBoxStatus.Image = Global.Control_de_Acceso_RFID.My.Resources.Resources.Disconnect
        Me.PictureBoxStatus.Location = New System.Drawing.Point(601, 2)
        Me.PictureBoxStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBoxStatus.Name = "PictureBoxStatus"
        Me.PictureBoxStatus.Size = New System.Drawing.Size(20, 18)
        Me.PictureBoxStatus.TabIndex = 6
        Me.PictureBoxStatus.TabStop = False
        '
        'LabelDateTime
        '
        Me.LabelDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDateTime.AutoSize = True
        Me.LabelDateTime.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDateTime.Location = New System.Drawing.Point(968, 2)
        Me.LabelDateTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDateTime.Name = "LabelDateTime"
        Me.LabelDateTime.Size = New System.Drawing.Size(247, 16)
        Me.LabelDateTime.TabIndex = 7
        Me.LabelDateTime.Text = "Time 00:00:00     Date 00  mm,  0000"
        '
        'PanelTopHeader
        '
        Me.PanelTopHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTopHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.PanelTopHeader.Location = New System.Drawing.Point(332, 25)
        Me.PanelTopHeader.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelTopHeader.Name = "PanelTopHeader"
        Me.PanelTopHeader.Size = New System.Drawing.Size(899, 11)
        Me.PanelTopHeader.TabIndex = 8
        '
        'PanelUserData
        '
        Me.PanelUserData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelUserData.BackColor = System.Drawing.Color.White
        Me.PanelUserData.Controls.Add(Me.GroupBoxDatailData)
        Me.PanelUserData.Controls.Add(Me.GroupBoxImage)
        Me.PanelUserData.Location = New System.Drawing.Point(332, 42)
        Me.PanelUserData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelUserData.Name = "PanelUserData"
        Me.PanelUserData.Size = New System.Drawing.Size(899, 657)
        Me.PanelUserData.TabIndex = 5
        '
        'GroupBoxDatailData
        '
        Me.GroupBoxDatailData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxDatailData.Controls.Add(Me.LabelHora)
        Me.GroupBoxDatailData.Controls.Add(Me.LabelCarrera)
        Me.GroupBoxDatailData.Controls.Add(Me.LabelID2)
        Me.GroupBoxDatailData.Controls.Add(Me.LabelNombre)
        Me.GroupBoxDatailData.Controls.Add(Me.Label8)
        Me.GroupBoxDatailData.Controls.Add(Me.Label7)
        Me.GroupBoxDatailData.Controls.Add(Me.Label6)
        Me.GroupBoxDatailData.Controls.Add(Me.Label5)
        Me.GroupBoxDatailData.Controls.Add(Me.Label4)
        Me.GroupBoxDatailData.Controls.Add(Me.Label3)
        Me.GroupBoxDatailData.Controls.Add(Me.Label2)
        Me.GroupBoxDatailData.Controls.Add(Me.Label1)
        Me.GroupBoxDatailData.Controls.Add(Me.ButtonClear)
        Me.GroupBoxDatailData.Location = New System.Drawing.Point(13, 256)
        Me.GroupBoxDatailData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxDatailData.Name = "GroupBoxDatailData"
        Me.GroupBoxDatailData.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxDatailData.Size = New System.Drawing.Size(868, 390)
        Me.GroupBoxDatailData.TabIndex = 1
        Me.GroupBoxDatailData.TabStop = False
        Me.GroupBoxDatailData.Text = "Datos Detallados"
        '
        'LabelHora
        '
        Me.LabelHora.AutoSize = True
        Me.LabelHora.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHora.Location = New System.Drawing.Point(268, 192)
        Me.LabelHora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelHora.Name = "LabelHora"
        Me.LabelHora.Size = New System.Drawing.Size(135, 23)
        Me.LabelHora.TabIndex = 14
        Me.LabelHora.Text = "Esperando..."
        '
        'LabelCarrera
        '
        Me.LabelCarrera.AutoSize = True
        Me.LabelCarrera.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCarrera.Location = New System.Drawing.Point(268, 144)
        Me.LabelCarrera.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCarrera.Name = "LabelCarrera"
        Me.LabelCarrera.Size = New System.Drawing.Size(135, 23)
        Me.LabelCarrera.TabIndex = 13
        Me.LabelCarrera.Text = "Esperando..."
        '
        'LabelID2
        '
        Me.LabelID2.AutoSize = True
        Me.LabelID2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID2.Location = New System.Drawing.Point(268, 50)
        Me.LabelID2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelID2.Name = "LabelID2"
        Me.LabelID2.Size = New System.Drawing.Size(135, 23)
        Me.LabelID2.TabIndex = 12
        Me.LabelID2.Text = "Esperando..."
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(268, 97)
        Me.LabelNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(135, 23)
        Me.LabelNombre.TabIndex = 11
        Me.LabelNombre.Text = "Esperando..."
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(213, 97)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 23)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(213, 144)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 23)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(213, 192)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(213, 49)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = ":"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 97)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Carrera"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 192)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha y hora "
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID"
        '
        'ButtonClear
        '
        Me.ButtonClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonClear.Location = New System.Drawing.Point(779, 353)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(84, 30)
        Me.ButtonClear.TabIndex = 0
        Me.ButtonClear.Text = "Limpiar"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'GroupBoxImage
        '
        Me.GroupBoxImage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBoxImage.Controls.Add(Me.LabelID)
        Me.GroupBoxImage.Controls.Add(Me.PictureBoxUserImage)
        Me.GroupBoxImage.Location = New System.Drawing.Point(363, 2)
        Me.GroupBoxImage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxImage.Name = "GroupBoxImage"
        Me.GroupBoxImage.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxImage.Size = New System.Drawing.Size(208, 246)
        Me.GroupBoxImage.TabIndex = 0
        Me.GroupBoxImage.TabStop = False
        Me.GroupBoxImage.Text = "Imagen y ID"
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID.Location = New System.Drawing.Point(25, 201)
        Me.LabelID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(112, 23)
        Me.LabelID.TabIndex = 1
        Me.LabelID.Text = "ID:   ______"
        '
        'PictureBoxUserImage
        '
        Me.PictureBoxUserImage.Location = New System.Drawing.Point(19, 25)
        Me.PictureBoxUserImage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBoxUserImage.Name = "PictureBoxUserImage"
        Me.PictureBoxUserImage.Size = New System.Drawing.Size(175, 175)
        Me.PictureBoxUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxUserImage.TabIndex = 0
        Me.PictureBoxUserImage.TabStop = False
        '
        'PanelUserRegistration
        '
        Me.PanelUserRegistration.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelUserRegistration.BackColor = System.Drawing.Color.White
        Me.PanelUserRegistration.Controls.Add(Me.PanelReadingTagProces)
        Me.PanelUserRegistration.Controls.Add(Me.GroupBoxRegistro)
        Me.PanelUserRegistration.Controls.Add(Me.GroupBoxImagen)
        Me.PanelUserRegistration.Controls.Add(Me.GroupBoxID)
        Me.PanelUserRegistration.Controls.Add(Me.ButtonClearForm)
        Me.PanelUserRegistration.Controls.Add(Me.ButtonSave)
        Me.PanelUserRegistration.Controls.Add(Me.TextBoxCarrera)
        Me.PanelUserRegistration.Controls.Add(Me.TextBoxNombre)
        Me.PanelUserRegistration.Controls.Add(Me.Label10)
        Me.PanelUserRegistration.Controls.Add(Me.Label9)
        Me.PanelUserRegistration.Location = New System.Drawing.Point(332, 42)
        Me.PanelUserRegistration.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelUserRegistration.Name = "PanelUserRegistration"
        Me.PanelUserRegistration.Size = New System.Drawing.Size(899, 657)
        Me.PanelUserRegistration.TabIndex = 2
        '
        'PanelReadingTagProces
        '
        Me.PanelReadingTagProces.Controls.Add(Me.PictureBox2)
        Me.PanelReadingTagProces.Controls.Add(Me.ButtonCloseReadingTag)
        Me.PanelReadingTagProces.Controls.Add(Me.Label13)
        Me.PanelReadingTagProces.Location = New System.Drawing.Point(0, 0)
        Me.PanelReadingTagProces.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelReadingTagProces.Name = "PanelReadingTagProces"
        Me.PanelReadingTagProces.Size = New System.Drawing.Size(303, 181)
        Me.PanelReadingTagProces.TabIndex = 12
        Me.PanelReadingTagProces.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Control_de_Acceso_RFID.My.Resources.Resources.Loading_gif
        Me.PictureBox2.Location = New System.Drawing.Point(124, 52)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'ButtonCloseReadingTag
        '
        Me.ButtonCloseReadingTag.Image = Global.Control_de_Acceso_RFID.My.Resources.Resources.Close_icon
        Me.ButtonCloseReadingTag.Location = New System.Drawing.Point(275, 2)
        Me.ButtonCloseReadingTag.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonCloseReadingTag.Name = "ButtonCloseReadingTag"
        Me.ButtonCloseReadingTag.Size = New System.Drawing.Size(25, 23)
        Me.ButtonCloseReadingTag.TabIndex = 1
        Me.ButtonCloseReadingTag.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 5)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Leyendo etiqueta ..."
        '
        'GroupBoxRegistro
        '
        Me.GroupBoxRegistro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxRegistro.Controls.Add(Me.PictureBoxImagePreview)
        Me.GroupBoxRegistro.Controls.Add(Me.DataGridView1)
        Me.GroupBoxRegistro.Controls.Add(Me.CheckBoxByID)
        Me.GroupBoxRegistro.Controls.Add(Me.CheckBoxByName)
        Me.GroupBoxRegistro.Controls.Add(Me.TextBoxBusqueda)
        Me.GroupBoxRegistro.Controls.Add(Me.Label12)
        Me.GroupBoxRegistro.Location = New System.Drawing.Point(3, 290)
        Me.GroupBoxRegistro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxRegistro.Name = "GroupBoxRegistro"
        Me.GroupBoxRegistro.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxRegistro.Size = New System.Drawing.Size(887, 354)
        Me.GroupBoxRegistro.TabIndex = 11
        Me.GroupBoxRegistro.TabStop = False
        Me.GroupBoxRegistro.Text = "Vista de Registro"
        '
        'PictureBoxImagePreview
        '
        Me.PictureBoxImagePreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxImagePreview.Location = New System.Drawing.Point(723, 81)
        Me.PictureBoxImagePreview.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBoxImagePreview.Name = "PictureBoxImagePreview"
        Me.PictureBoxImagePreview.Size = New System.Drawing.Size(150, 132)
        Me.PictureBoxImagePreview.TabIndex = 5
        Me.PictureBoxImagePreview.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Location = New System.Drawing.Point(5, 44)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(701, 305)
        Me.DataGridView1.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrarToolStripMenuItem, Me.SeleccionarTodoToolStripMenuItem, Me.BorraSeleccionToolStripMenuItem, Me.RefrescarToolStripMenuItem, Me.RefrescarToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(195, 114)
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Image = Global.Control_de_Acceso_RFID.My.Resources.Resources.Clean_icon
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'SeleccionarTodoToolStripMenuItem
        '
        Me.SeleccionarTodoToolStripMenuItem.Image = Global.Control_de_Acceso_RFID.My.Resources.Resources.select_all_icon
        Me.SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        Me.SeleccionarTodoToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.SeleccionarTodoToolStripMenuItem.Text = "Seleccionar todo"
        '
        'BorraSeleccionToolStripMenuItem
        '
        Me.BorraSeleccionToolStripMenuItem.Image = Global.Control_de_Acceso_RFID.My.Resources.Resources.Clear_select_icon
        Me.BorraSeleccionToolStripMenuItem.Name = "BorraSeleccionToolStripMenuItem"
        Me.BorraSeleccionToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.BorraSeleccionToolStripMenuItem.Text = "Borra seleccion"
        '
        'RefrescarToolStripMenuItem
        '
        Me.RefrescarToolStripMenuItem.Name = "RefrescarToolStripMenuItem"
        Me.RefrescarToolStripMenuItem.Size = New System.Drawing.Size(191, 6)
        '
        'RefrescarToolStripMenuItem1
        '
        Me.RefrescarToolStripMenuItem1.Image = Global.Control_de_Acceso_RFID.My.Resources.Resources.Refresh_icon
        Me.RefrescarToolStripMenuItem1.Name = "RefrescarToolStripMenuItem1"
        Me.RefrescarToolStripMenuItem1.Size = New System.Drawing.Size(194, 26)
        Me.RefrescarToolStripMenuItem1.Text = "Refrescar"
        '
        'CheckBoxByID
        '
        Me.CheckBoxByID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxByID.AutoSize = True
        Me.CheckBoxByID.Location = New System.Drawing.Point(718, 43)
        Me.CheckBoxByID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxByID.Name = "CheckBoxByID"
        Me.CheckBoxByID.Size = New System.Drawing.Size(130, 20)
        Me.CheckBoxByID.TabIndex = 3
        Me.CheckBoxByID.Text = "Busqueda por ID"
        Me.CheckBoxByID.UseVisualStyleBackColor = True
        '
        'CheckBoxByName
        '
        Me.CheckBoxByName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxByName.AutoSize = True
        Me.CheckBoxByName.Checked = True
        Me.CheckBoxByName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxByName.Location = New System.Drawing.Point(717, 15)
        Me.CheckBoxByName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxByName.Name = "CheckBoxByName"
        Me.CheckBoxByName.Size = New System.Drawing.Size(163, 20)
        Me.CheckBoxByName.TabIndex = 2
        Me.CheckBoxByName.Text = "Busqueda por nombre"
        Me.CheckBoxByName.UseVisualStyleBackColor = True
        '
        'TextBoxBusqueda
        '
        Me.TextBoxBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxBusqueda.Location = New System.Drawing.Point(163, 18)
        Me.TextBoxBusqueda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxBusqueda.Name = "TextBoxBusqueda"
        Me.TextBoxBusqueda.Size = New System.Drawing.Size(507, 22)
        Me.TextBoxBusqueda.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 18)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 23)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Busque aquí:"
        '
        'GroupBoxImagen
        '
        Me.GroupBoxImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxImagen.Controls.Add(Me.PictureBoxImageInput)
        Me.GroupBoxImagen.Location = New System.Drawing.Point(736, 164)
        Me.GroupBoxImagen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxImagen.Name = "GroupBoxImagen"
        Me.GroupBoxImagen.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxImagen.Size = New System.Drawing.Size(123, 121)
        Me.GroupBoxImagen.TabIndex = 10
        Me.GroupBoxImagen.TabStop = False
        Me.GroupBoxImagen.Text = "Imagen"
        '
        'PictureBoxImageInput
        '
        Me.PictureBoxImageInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxImageInput.Image = Global.Control_de_Acceso_RFID.My.Resources.Resources.browser_icon
        Me.PictureBoxImageInput.Location = New System.Drawing.Point(5, 21)
        Me.PictureBoxImageInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBoxImageInput.Name = "PictureBoxImageInput"
        Me.PictureBoxImageInput.Size = New System.Drawing.Size(110, 94)
        Me.PictureBoxImageInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxImageInput.TabIndex = 11
        Me.PictureBoxImageInput.TabStop = False
        '
        'GroupBoxID
        '
        Me.GroupBoxID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxID.Controls.Add(Me.Labelplaceid)
        Me.GroupBoxID.Controls.Add(Me.LabelGETID)
        Me.GroupBoxID.Controls.Add(Me.ButtonScannID)
        Me.GroupBoxID.Location = New System.Drawing.Point(576, 164)
        Me.GroupBoxID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxID.Name = "GroupBoxID"
        Me.GroupBoxID.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxID.Size = New System.Drawing.Size(155, 121)
        Me.GroupBoxID.TabIndex = 6
        Me.GroupBoxID.TabStop = False
        Me.GroupBoxID.Text = "Lectura ID"
        '
        'Labelplaceid
        '
        Me.Labelplaceid.AutoSize = True
        Me.Labelplaceid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelplaceid.Location = New System.Drawing.Point(35, 89)
        Me.Labelplaceid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelplaceid.Name = "Labelplaceid"
        Me.Labelplaceid.Size = New System.Drawing.Size(56, 16)
        Me.Labelplaceid.TabIndex = 9
        Me.Labelplaceid.Text = "_______"
        '
        'LabelGETID
        '
        Me.LabelGETID.AutoSize = True
        Me.LabelGETID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGETID.Location = New System.Drawing.Point(5, 89)
        Me.LabelGETID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelGETID.Name = "LabelGETID"
        Me.LabelGETID.Size = New System.Drawing.Size(21, 16)
        Me.LabelGETID.TabIndex = 8
        Me.LabelGETID.Text = "ID"
        '
        'ButtonScannID
        '
        Me.ButtonScannID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonScannID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScannID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScannID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonScannID.Location = New System.Drawing.Point(8, 23)
        Me.ButtonScannID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonScannID.Name = "ButtonScannID"
        Me.ButtonScannID.Size = New System.Drawing.Size(139, 49)
        Me.ButtonScannID.TabIndex = 7
        Me.ButtonScannID.Text = "Escanear ID"
        Me.ButtonScannID.UseVisualStyleBackColor = False
        '
        'ButtonClearForm
        '
        Me.ButtonClearForm.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClearForm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonClearForm.Location = New System.Drawing.Point(148, 231)
        Me.ButtonClearForm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonClearForm.Name = "ButtonClearForm"
        Me.ButtonClearForm.Size = New System.Drawing.Size(113, 49)
        Me.ButtonClearForm.TabIndex = 5
        Me.ButtonClearForm.Text = "Borrar Formulario"
        Me.ButtonClearForm.UseVisualStyleBackColor = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonSave.Location = New System.Drawing.Point(9, 231)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(113, 49)
        Me.ButtonSave.TabIndex = 4
        Me.ButtonSave.Text = "Guardar"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'TextBoxCarrera
        '
        Me.TextBoxCarrera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxCarrera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxCarrera.Location = New System.Drawing.Point(108, 71)
        Me.TextBoxCarrera.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxCarrera.Name = "TextBoxCarrera"
        Me.TextBoxCarrera.Size = New System.Drawing.Size(785, 22)
        Me.TextBoxCarrera.TabIndex = 3
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxNombre.Location = New System.Drawing.Point(108, 27)
        Me.TextBoxNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(785, 22)
        Me.TextBoxNombre.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 71)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 23)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Carrera"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 26)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 23)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Nombre"
        '
        'TimerTimeDate
        '
        Me.TimerTimeDate.Enabled = True
        '
        'TimerSerialIn
        '
        Me.TimerSerialIn.Interval = 1000
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 711)
        Me.Controls.Add(Me.PanelTopHeader)
        Me.Controls.Add(Me.LabelDateTime)
        Me.Controls.Add(Me.PictureBoxStatus)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelUserRegistration)
        Me.Controls.Add(Me.PanelUserData)
        Me.Controls.Add(Me.PanelConnection)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Control de Acceso"
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.PictureBoxselect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelConnection.ResumeLayout(False)
        Me.PanelConnection.PerformLayout()
        CType(Me.PictureBoxStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUserData.ResumeLayout(False)
        Me.GroupBoxDatailData.ResumeLayout(False)
        Me.GroupBoxDatailData.PerformLayout()
        Me.GroupBoxImage.ResumeLayout(False)
        Me.GroupBoxImage.PerformLayout()
        CType(Me.PictureBoxUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUserRegistration.ResumeLayout(False)
        Me.PanelUserRegistration.PerformLayout()
        Me.PanelReadingTagProces.ResumeLayout(False)
        Me.PanelReadingTagProces.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxRegistro.ResumeLayout(False)
        Me.GroupBoxRegistro.PerformLayout()
        CType(Me.PictureBoxImagePreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBoxImagen.ResumeLayout(False)
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxID.ResumeLayout(False)
        Me.GroupBoxID.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents ButtonUser_data As Button
    Friend WithEvents ButtonConexion As Button
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents PictureBoxselect As PictureBox
    Friend WithEvents PanelConnection As Panel
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents LabelBaudRate As Label
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents ButtonScanPort As Button
    Friend WithEvents LabelStatus As Label
    Friend WithEvents PictureBoxStatus As PictureBox
    Friend WithEvents LabelDateTime As Label
    Friend WithEvents PanelTopHeader As Panel
    Friend WithEvents PanelUserData As Panel
    Friend WithEvents GroupBoxDatailData As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonClear As Button
    Friend WithEvents GroupBoxImage As GroupBox
    Friend WithEvents LabelID As Label
    Friend WithEvents PictureBoxUserImage As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelHora As Label
    Friend WithEvents LabelCarrera As Label
    Friend WithEvents LabelID2 As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents PanelUserRegistration As Panel
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBoxImageInput As PictureBox
    Friend WithEvents GroupBoxImagen As GroupBox
    Friend WithEvents GroupBoxID As GroupBox
    Friend WithEvents Labelplaceid As Label
    Friend WithEvents LabelGETID As Label
    Friend WithEvents ButtonScannID As Button
    Friend WithEvents ButtonClearForm As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents TextBoxCarrera As TextBox
    Friend WithEvents PanelReadingTagProces As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ButtonCloseReadingTag As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBoxRegistro As GroupBox
    Friend WithEvents PictureBoxImagePreview As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CheckBoxByID As CheckBox
    Friend WithEvents CheckBoxByName As CheckBox
    Friend WithEvents TextBoxBusqueda As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TimerTimeDate As Timer
    Friend WithEvents TimerSerialIn As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents BorrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorraSeleccionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefrescarToolStripMenuItem As ToolStripSeparator
    Friend WithEvents RefrescarToolStripMenuItem1 As ToolStripMenuItem
End Class
