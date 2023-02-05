Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.IO.Ports
Imports System.Text.RegularExpressions

Imports MySql.Data.MySqlClient      'Librerias importadas para la correcta ejecucion del programa

Public Class Form1      'Form1 es el programa ejecutable, es nuestro clase principal la cual se dividira en subclases para poder programar las diferentes funciones.
    Dim Connection As New MySqlConnection("server=localhost; user=root; password=Luminisoft01; database=user_info") 'Nos conectamos a la base de sator por medio del servidor local de Xampp
    Dim MySQLCMD As New MySqlCommand
    Dim MySQLDA As New MySqlDataAdapter
    Dim DT As New DataTable     'Declaramos los objetos necesarios para poder cominucarnos con la base de datos 
    Dim Table_Name As String = "rfids" 'Nombre de la tabla
    Dim Data As Integer

    Dim LoadImagesStr As Boolean = False
    Dim IDRam As String
    Dim IMG_FileNameInput As String
    Dim StatusInput As String = "Save"
    Dim SqlCmdSearchstr As String

    Public Shared StrSerialIn As String
    Dim GetID As Boolean = False
    Dim ViewUserData As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load    'Clase prida que va a inicialixar la pantalla de inicio del programa como se indica al principio solo esta visible el panel de conexion
        Me.CenterToScreen()
        PanelUserRegistration.Visible = False
        PanelUserData.Visible = False
        PanelConnection.Visible = True
        ComboBoxBaudRate.SelectedIndex = 3  'Se indica que seleccionara el baudaje en la opcion tres de forma automatica corresponde a 9600 que es la conexion con el monitor serial para el arduino
    End Sub

    Private Sub ShowData()  'Clase que nos mostrara los datos de nuestra base de datos
        Try         'La sentencia try es un bloque seguido de n clausulas catch. Cuando se ejecuta un try se busca una instruccion catch que controla la excepcion
            Connection.Open() ' si la instruccion en esta funcion falla la excepcion seria pasar al catch
        Catch ex As Exception
            MessageBox.Show("Conexión fallida !!!" & vbCrLf & "Por favor asegurese de que el servidor esta en linea  !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return      ' De esta forma mandamos un mensaje de error si nuestra primer bloque produce una excepcion
        End Try

        Try 'sentiencia try
            If LoadImagesStr = False Then
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "SELECT Nombre, ID, Carrera,  Hora FROM " & Table_Name & " ORDER BY Nombre"
                MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
                DT = New DataTable
                Data = MySQLDA.Fill(DT)
                If Data > 0 Then
                    DataGridView1.DataSource = Nothing
                    DataGridView1.DataSource = DT
                    DataGridView1.Columns(2).DefaultCellStyle.Format = "c"
                    DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                    DataGridView1.ClearSelection()

                Else
                    DataGridView1.DataSource = DT
                End If      'Formato para mostrar nuestra base de datos 
            Else
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "SELECT Imagen FROM " & Table_Name & " WHERE ID LIKE '" & IDRam & "'"
                MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
                DT = New DataTable
                Data = MySQLDA.Fill(DT)
                If Data > 0 Then
                    Dim ImgArray() As Byte = DT.Rows(0).Item("Imagen")
                    Dim lmgStr As New System.IO.MemoryStream(ImgArray)
                    PictureBoxImagePreview.Image = Image.FromStream(lmgStr)
                    PictureBoxImagePreview.SizeMode = PictureBoxSizeMode.Zoom
                    lmgStr.Close()      'Mostramos la imagen que se subio a la base de datos 
                End If
                LoadImagesStr = False
            End If
        Catch ex As Exception 'si llegan a fallar alguno de los pasos pasamoa a la excepcion catch
            MsgBox("Fallo al cargar la base de datos  !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
            Return
        End Try

        DT = Nothing    'Si no hay nada en la base de datos no muestra nada  
        Connection.Close()
    End Sub

    Private Sub ShowDataUser()      'Clase con la cual mostraremos la informacion de usuario
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Conexión fallida !!!" & vbCrLf & "Por favor asegurese de que el servido esta en linea  !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            MySQLCMD.CommandType = CommandType.Text
            MySQLCMD = New MySqlCommand
            With MySQLCMD
                .CommandText = "UPDATE " & Table_Name & " SET Hora = CURRENT_TIMESTAMP() WHERE ID LIKE '" & LabelID.Text.Substring(5, LabelID.Text.Length - 5) & "'"
                .Connection = Connection
                .ExecuteNonQuery()
            End With
            MySQLCMD.CommandText = "SELECT * FROM " & Table_Name & " WHERE ID LIKE '" & LabelID.Text.Substring(5, LabelID.Text.Length - 5) & "'"
            MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then

                Dim ImgArray() As Byte = DT.Rows(0).Item("Imagen")
                Dim lmgStr As New System.IO.MemoryStream(ImgArray)
                PictureBoxUserImage.Image = Image.FromStream(lmgStr)
                lmgStr.Close()

                LabelID2.Text = "ID : " & DT.Rows(0).Item("ID")
                LabelNombre.Text = DT.Rows(0).Item("Nombre")
                LabelCarrera.Text = DT.Rows(0).Item("Carrera")

                LabelHora.Text = DT.Rows(0).Item("Hora")
                'Si nuestro sentencia try es exitosa entonces en el panel de informacdion de usuario mostrara la informacion correcta 
                SerialPort1.Write("s")
            Else
                MsgBox("ID no encontrado !!!" & vbCr & "Por favor registre el ID.", MsgBoxStyle.Information, "Information Message")
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la base de datos !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()
    End Sub

    Private Sub ClearInputUpdateData()  'Programamos al boton de borrar 	
        TextBoxNombre.Text = ""
        Labelplaceid.Text = "________"
        TextBoxCarrera.Text = ""

        PictureBoxImageInput.Image = My.Resources.browser_icon 'Inicializamos con una imagen desde nuestros recursos
    End Sub

    Private Sub ButtonConexion_Click(sender As Object, e As EventArgs) Handles ButtonConexion.Click 'Programamos a los diferentes botones del panel 
        PictureBoxselect.Top = ButtonConexion.Top
        PanelUserRegistration.Visible = False
        PanelUserData.Visible = False
        PanelConnection.Visible = True
    End Sub

    Private Sub ButtonUser_data_Click(sender As Object, e As EventArgs) Handles ButtonUser_data.Click
        If TimerSerialIn.Enabled = False Then
            MsgBox("Error al abrir la inofrmación de usuario !!!" & vbCr & "Da click al menu de conexión despues en conectar.", MsgBoxStyle.Information, "Information")
            Return
        Else
            StrSerialIn = ""
            ViewUserData = True
            PictureBoxselect.Top = ButtonUser_data.Top
            PanelUserRegistration.Visible = False
            PanelConnection.Visible = False
            PanelUserData.Visible = True
        End If
    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        StrSerialIn = ""
        ViewUserData = False
        PictureBoxselect.Top = ButtonRegister.Top
        PanelConnection.Visible = False
        PanelUserData.Visible = False
        PanelUserRegistration.Visible = True
        ShowData()
    End Sub
    Private Sub PanelConnection_Paint(sender As Object, e As PaintEventArgs) Handles PanelConnection.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), PanelConnection.ClientRectangle)
    End Sub

    Private Sub PanelConnection_Resize(sender As Object, e As EventArgs) Handles PanelConnection.Resize
        PanelConnection.Invalidate()
    End Sub
    Private Sub PanelUserData_Paint(sender As Object, e As PaintEventArgs) Handles PanelUserData.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), PanelConnection.ClientRectangle)
    End Sub

    Private Sub PanelUserData_Resize(sender As Object, e As EventArgs) Handles PanelUserData.Resize
        PanelUserData.Invalidate()
    End Sub

    Private Sub PanelUserRegistration_Paint(sender As Object, e As PaintEventArgs) Handles PanelUserRegistration.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), PanelConnection.ClientRectangle)
    End Sub

    Private Sub PanelUserRegistration_Resize(sender As Object, e As EventArgs) Handles PanelUserRegistration.Resize
        PanelUserRegistration.Invalidate()
    End Sub 'subs para darle formato a las ventanas

    Private Sub ButtonScanPort_Click(sender As Object, e As EventArgs) Handles ButtonScanPort.Click 'buscamos los puertos seriales de nuestra maquina
        ComboBoxPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(myPort)
        i = ComboBoxPort.Items.Count
        i = i - i
        Try
            ComboBoxPort.SelectedIndex = i
        Catch ex As Exception
            MsgBox("Puerto Com no detectado", MsgBoxStyle.Critical, "Error Message")
            ComboBoxPort.Text = ""
            ComboBoxPort.Items.Clear()
            Return
        End Try
        ComboBoxPort.DroppedDown = True
    End Sub

    Private Sub ButtonScanPort_MouseHover(sender As Object, e As EventArgs) Handles ButtonScanPort.MouseHover
        ButtonScanPort.ForeColor = Color.White
    End Sub

    Private Sub ButtonScanPort_MouseLeave(sender As Object, e As EventArgs) Handles ButtonScanPort.MouseLeave
        ButtonScanPort.ForeColor = Color.FromArgb(6, 71, 165)
    End Sub
    ' Aplicamos formato al pasar el mouse por encima de los botones
    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        If ButtonConnect.Text = "Conectar" Then
            SerialPort1.BaudRate = ComboBoxBaudRate.SelectedItem
            SerialPort1.PortName = ComboBoxPort.SelectedItem
            Try
                SerialPort1.Open()
                TimerSerialIn.Start()
                ButtonConnect.Text = "Desconectar"
                PictureBoxStatus.Image = My.Resources.Connected
            Catch ex As Exception
                MsgBox("Fallo al conectar !!!" & vbCr & "El Arduino no esta conectado.", MsgBoxStyle.Critical, "Error Message")
                PictureBoxStatus.Image = My.Resources.Disconnect
            End Try
        ElseIf ButtonConnect.Text = "Desconectar" Then
            PictureBoxStatus.Image = My.Resources.Disconnect
            ButtonConnect.Text = "Conectar"
            LabelStatus.Text = "Estatus de Conexión: Desconectado"
            TimerSerialIn.Stop()
            SerialPort1.Close()
        End If
    End Sub     'Nos conectamos con nuestro monitor serial y con el puerto
    Private Sub ButtonConnect_MouseHover(sender As Object, e As EventArgs) Handles ButtonConnect.MouseHover
        ButtonConnect.ForeColor = Color.White
    End Sub

    Private Sub ButtonConnect_MouseLeave(sender As Object, e As EventArgs) Handles ButtonConnect.MouseLeave
        ButtonConnect.ForeColor = Color.FromArgb(6, 71, 165)
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click   'Limpiamos información que no queramos ver 
        LabelID2.Text = "Esperando..."
        LabelNombre.Text = "Esperando..."
        LabelCarrera.Text = "Esperando..."
        LabelHora.Text = "Esperando..."
        LabelHora.Text = "Esperando..."
        PictureBoxUserImage.Image = Nothing
    End Sub
    Private Sub ButtonClear_MouseHover(sender As Object, e As EventArgs) Handles ButtonClear.MouseHover
        ButtonClear.ForeColor = Color.White
    End Sub

    Private Sub ButtonClear_MouseLeave(sender As Object, e As EventArgs) Handles ButtonClear.MouseLeave
        ButtonClear.ForeColor = Color.FromArgb(6, 71, 165)
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click     'Guardamos informacion de usuario en nuestra base de datos
        Dim mstream As New System.IO.MemoryStream()
        Dim arrImage() As Byte

        If TextBoxNombre.Text = "" Then
            MessageBox.Show("El nombre no puede estar vacio !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxCarrera.Text = "" Then
            MessageBox.Show(" La carrera no puede estar vacio !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        'Como indicamos en nuestra base de datos todolos los campos deben ser obligatorios En esta parte del codigo indicamos al Usuario eso.


        If StatusInput = "Save" Then
            If IMG_FileNameInput <> "" Then
                PictureBoxImageInput.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()  'Seleccionamos la imagen que se guardara en el registro
            Else
                MessageBox.Show("La imagen no ha sido seleccionada !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error) 'La imagen tambien es un campo obligatorio
                Return
            End If
            Try
                Connection.Open()
            Catch ex As Exception
                MessageBox.Show("Connection failed !!!" & vbCrLf & "Por favor asegurese de que el servidor esta en linea !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try

            Try
                MySQLCMD = New MySqlCommand
                With MySQLCMD
                    .CommandText = "INSERT INTO " & Table_Name & " (Nombre, ID, Carrera,  Imagen) VALUES (@nombre, @ID, @carrera,  @imagen)"
                    .Connection = Connection
                    .Parameters.AddWithValue("@nombre", TextBoxNombre.Text)
                    .Parameters.AddWithValue("@id", Labelplaceid.Text)
                    .Parameters.AddWithValue("@carrera", TextBoxCarrera.Text)
                    .Parameters.AddWithValue("@imagen", arrImage)
                    .ExecuteNonQuery()
                End With
                MsgBox("Datos guardados de manera exitosa", MsgBoxStyle.Information, "Information")
                IMG_FileNameInput = ""
                ClearInputUpdateData()
            Catch ex As Exception
                MsgBox("Error Datos no guardados !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
                Connection.Close()
                Return
            End Try
            Connection.Close()
        Else

            If IMG_FileNameInput <> "" Then
                PictureBoxImageInput.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()

                Try
                    Connection.Open()
                Catch ex As Exception
                    MessageBox.Show("Coneccion fallida !!!" & vbCrLf & "Por favor asegurese de que el servidor esta online !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try

                Try
                    MySQLCMD = New MySqlCommand
                    With MySQLCMD
                        .CommandText = "UPDATE " & Table_Name & " SET  Nombre=@nombre,ID=@id,Carrera=@carrera,Imagen=@imagen WHERE ID=@id "
                        .Connection = Connection
                        .Parameters.AddWithValue("@nombre", TextBoxNombre.Text)
                        .Parameters.AddWithValue("@id", Labelplaceid.Text)
                        .Parameters.AddWithValue("@carrera", TextBoxCarrera.Text)
                        .Parameters.AddWithValue("@imagen", arrImage)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Datos actualizado", MsgBoxStyle.Information, "Information")
                    IMG_FileNameInput = ""
                    ButtonSave.Text = "Save"
                    ClearInputUpdateData()
                Catch ex As Exception
                    MsgBox("Fallo al actualizar datos !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
                    Connection.Close()
                    Return
                End Try
                Connection.Close()
            Else
                Try
                    Connection.Open()
                Catch ex As Exception
                    MessageBox.Show("Conexión Fallida!!!" & vbCrLf & "Por favor asegurese de que la base de datos esta en linea !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try

                Try
                    MySQLCMD = New MySqlCommand
                    With MySQLCMD
                        .CommandText = "UPDATE " & Table_Name & " SET  Nombre=@nombre,ID=@id,Carrera=@carrera WHERE ID=@id "
                        .Connection = Connection
                        .Parameters.AddWithValue("@nombre", TextBoxNombre.Text)
                        .Parameters.AddWithValue("@id", Labelplaceid.Text)
                        .Parameters.AddWithValue("@carrera", TextBoxCarrera.Text)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Datos actualizados correctamente", MsgBoxStyle.Information, "Information")
                    ButtonSave.Text = "Save"
                    ClearInputUpdateData()
                Catch ex As Exception
                    MsgBox("Fallo al actualizar !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
                    Connection.Close()
                    Return
                End Try
                Connection.Close()
            End If
            StatusInput = "Save"
        End If
        PictureBoxImagePreview.Image = Nothing
        ShowData()
    End Sub

    Private Sub ButtonSave_MouseHover(sender As Object, e As EventArgs) Handles ButtonSave.MouseHover
        ButtonSave.ForeColor = Color.White
    End Sub

    Private Sub ButtonSave_MouseLeave(sender As Object, e As EventArgs) Handles ButtonSave.MouseLeave
        ButtonSave.ForeColor = Color.FromArgb(6, 71, 165)
    End Sub

    Private Sub ButtonClearForm_Click(sender As Object, e As EventArgs) Handles ButtonClearForm.Click
        ClearInputUpdateData()
    End Sub
    Private Sub ButtonClearForm_MouseHover(sender As Object, e As EventArgs) Handles ButtonClearForm.MouseHover
        ButtonClearForm.ForeColor = Color.White
    End Sub

    Private Sub ButtonClearForm_MouseLeave(sender As Object, e As EventArgs) Handles ButtonClearForm.MouseLeave
        ButtonClearForm.ForeColor = Color.FromArgb(6, 71, 165)
    End Sub

    Private Sub ButtonScannID_Click(sender As Object, e As EventArgs) Handles ButtonScannID.Click
        If TimerSerialIn.Enabled = True Then
            PanelReadingTagProces.Visible = True 'Hacemos visible nuestro proceseso para leer la tarjeta 
            GetID = True
            ButtonScannID.Enabled = False
        Else
            MsgBox("Error al Abrir la informacdion de Usuario!!!" & vbCr & "Ve al menu de conexion Depues oprime el boton de concetar.", MsgBoxStyle.Critical, "Error Message")
        End If
    End Sub
    Private Sub ButtonScanID_MouseHover(sender As Object, e As EventArgs) Handles ButtonScannID.MouseHover
        ButtonScannID.ForeColor = Color.White
    End Sub

    Private Sub ButtonScanID_MouseLeave(sender As Object, e As EventArgs) Handles ButtonScannID.MouseLeave
        ButtonScannID.ForeColor = Color.FromArgb(6, 71, 165)
    End Sub

    Private Sub PictureBoxImageInput_Click(sender As Object, e As EventArgs) Handles PictureBoxImageInput.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPEG (*.jpeg;*.jpg)|*.jpeg;*.jpg"

        If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            IMG_FileNameInput = OpenFileDialog1.FileName
            PictureBoxImageInput.ImageLocation = IMG_FileNameInput
        End If
    End Sub

    Private Sub CheckBoxByName_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxByName.CheckedChanged
        If CheckBoxByName.Checked = True Then
            CheckBoxByID.Checked = False
        End If
        If CheckBoxByName.Checked = False Then
            CheckBoxByID.Checked = True
        End If
    End Sub

    Private Sub CheckBoxByID_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxByID.CheckedChanged
        If CheckBoxByID.Checked = True Then
            CheckBoxByName.Checked = False
        End If
        If CheckBoxByID.Checked = False Then
            CheckBoxByName.Checked = True
        End If
    End Sub

    Private Sub TextBoxBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBusqueda.TextChanged
        If CheckBoxByID.Checked = True Then
            If TextBoxBusqueda.Text = Nothing Then
                SqlCmdSearchstr = "SELECT Nombre, ID, Carrera,  Hora FROM " & Table_Name & " ORDER BY Nombre"
            Else
                SqlCmdSearchstr = "SELECT Nombre, ID, Carrera,  Hora FROM " & Table_Name & " WHERE ID LIKE'" & TextBoxBusqueda.Text & "%'"
            End If
        End If
        If CheckBoxByName.Checked = True Then
            If TextBoxBusqueda.Text = Nothing Then
                SqlCmdSearchstr = "SELECT Nombre, ID, Carrera,  Hora FROM " & Table_Name & " ORDER BY Nombre"
            Else
                SqlCmdSearchstr = "SELECT Nombre, ID, Carrera,  Hora FROM " & Table_Name & " WHERE Nombre LIKE'" & TextBoxBusqueda.Text & "%'"
            End If
        End If

        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Conexión Fallida !!!" & vbCrLf & "Por favor asegurese de que el servidor esta en linea !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            MySQLDA = New MySqlDataAdapter(SqlCmdSearchstr, Connection)
            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                DataGridView1.DataSource = Nothing
                DataGridView1.DataSource = DT
                DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                DataGridView1.ClearSelection()
            Else
                DataGridView1.DataSource = DT
            End If
        Catch ex As Exception
            MsgBox("No se pudo Buscar" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        Try
            If AllCellsSelected(DataGridView1) = False Then
                If e.Button = MouseButtons.Left Then
                    DataGridView1.CurrentCell = DataGridView1(e.ColumnIndex, e.RowIndex)
                    Dim i As Integer
                    With DataGridView1
                        If e.RowIndex >= 0 Then
                            i = .CurrentRow.Index
                            LoadImagesStr = True
                            IDRam = .Rows(i).Cells("ID").Value.ToString
                            ShowData()
                        End If
                    End With
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Function AllCellsSelected(dgv As DataGridView) As Boolean
        AllCellsSelected = (DataGridView1.SelectedCells.Count = (DataGridView1.RowCount * DataGridView1.Columns.GetColumnCount(DataGridViewElementStates.Visible)))
    End Function

    Private Sub TimerTimeDate_Tick(sender As Object, e As EventArgs) Handles TimerTimeDate.Tick
        LabelDateTime.Text = "Time " & DateTime.Now.ToString("HH:mm:ss") & "  Date " & DateTime.Now.ToString("dd MMM, yyyy")
    End Sub

    Private Sub BorrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem.Click
        If DataGridView1.RowCount = 0 Then
            MsgBox("No se puede borrar, Los datos en la tabla son vacios", MsgBoxStyle.Critical, "Error Message")
            Return
        End If

        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("No se puede borrar, seleccione el registro a borrar", MsgBoxStyle.Critical, "Error Message")
            Return
        End If

        If MsgBox("Borra Registro?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Conexion Fallida !!!" & vbCrLf & "Por favor asegurese de que el servidor esta en liena !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            If AllCellsSelected(DataGridView1) = True Then
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "DELETE FROM " & Table_Name
                MySQLCMD.Connection = Connection
                MySQLCMD.ExecuteNonQuery()
            End If

            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                If row.Selected = True Then
                    MySQLCMD.CommandType = CommandType.Text
                    MySQLCMD.CommandText = "DELETE FROM " & Table_Name & " WHERE ID='" & row.DataBoundItem(1).ToString & "'"
                    MySQLCMD.Connection = Connection
                    MySQLCMD.ExecuteNonQuery()
                End If
            Next
        Catch ex As Exception
            MsgBox("Fallo al borrar" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
        End Try
        PictureBoxImagePreview.Image = Nothing
        Connection.Close()
        ShowData()
    End Sub

    Private Sub SeleccionarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarTodoToolStripMenuItem.Click
        DataGridView1.SelectAll()
    End Sub

    Private Sub BorraSeleccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorraSeleccionToolStripMenuItem.Click
        DataGridView1.ClearSelection()
        PictureBoxImagePreview.Image = Nothing
    End Sub

    Private Sub RefrescarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RefrescarToolStripMenuItem1.Click
        ShowData()
    End Sub

    Private Sub TimerSerialIn_Tick(sender As Object, e As EventArgs) Handles TimerSerialIn.Tick
        Try
            StrSerialIn = SerialPort1.ReadExisting
            LabelStatus.Text = "Estatus de Conexión : Conectado"
            If StrSerialIn <> "" Then
                If GetID = True Then
                    Labelplaceid.Text = StrSerialIn
                    GetID = False
                    If Labelplaceid.Text <> "________" Then
                        PanelReadingTagProces.Visible = False
                        IDCheck()
                    End If
                End If
                If ViewUserData = True Then
                    ViewData()
                End If
            End If
        Catch ex As Exception
            TimerSerialIn.Stop()
            SerialPort1.Close()
            LabelStatus.Text = "Estatus de Conexión : Desconectado"
            PictureBoxStatus.Image = My.Resources.Disconnect
            MsgBox("Error al conectar !!!" & vbCr & "No se detecto Arduino.", MsgBoxStyle.Critical, "Error Message")
            ButtonConnect_Click(sender, e)
            Return
        End Try

        If PictureBoxStatus.Visible = True Then
            PictureBoxStatus.Visible = False
        ElseIf PictureBoxStatus.Visible = False Then
            PictureBoxStatus.Visible = True
        End If
    End Sub
    Private Sub IDCheck()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Conexión Fallida !!!" & vbCrLf & "Por favor asegurese de que el servidor esta online !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            MySQLCMD.CommandType = CommandType.Text
            MySQLCMD.CommandText = "SELECT * FROM " & Table_Name & " WHERE ID LIKE '" & Labelplaceid.Text & "'"
            MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                If MsgBox("ID registrado !" & vbCr & "Quiere editar los datos ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then
                    DT = Nothing
                    Connection.Close()
                    ButtonScannID.Enabled = True
                    GetID = False
                    Labelplaceid.Text = "________"
                    Return
                Else
                    Dim ImgArray() As Byte = DT.Rows(0).Item("Imagen")
                    Dim lmgStr As New System.IO.MemoryStream(ImgArray)
                    PictureBoxImageInput.Image = Image.FromStream(lmgStr)
                    PictureBoxImageInput.SizeMode = PictureBoxSizeMode.Zoom

                    TextBoxNombre.Text = DT.Rows(0).Item("Nombre")
                    TextBoxCarrera.Text = DT.Rows(0).Item("Carrera")
                    StatusInput = "Update"
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la base de datos !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()

        ButtonScannID.Enabled = True
        GetID = False
    End Sub

    Private Sub ViewData()
        LabelID.Text = "ID : " & StrSerialIn
        If LabelID.Text = "ID : ________" Then
            ViewData()
        Else
            ShowDataUser()
        End If
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        GroupBoxImage.Location = New Point((PanelUserData.Width / 2) - (GroupBoxImage.Width / 2), GroupBoxImage.Top)
        PanelReadingTagProces.Location = New Point((PanelUserRegistration.Width / 2) - (PanelReadingTagProces.Width / 2), 106)
    End Sub

    Private Sub ButtonCloseReadingTag_Click(sender As Object, e As EventArgs) Handles ButtonCloseReadingTag.Click
        PanelReadingTagProces.Visible = False
        ButtonScannID.Enabled = True
    End Sub

End Class