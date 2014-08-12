Imports System.IO
Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents recursivelisting As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents writefullpath As System.Windows.Forms.CheckBox
    Friend WithEvents GenerateButton As System.Windows.Forms.Button
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents opengeneratedfile As System.Windows.Forms.CheckBox
    Friend WithEvents outputpathlabel As System.Windows.Forms.Label
    Friend WithEvents inputpathlabel As System.Windows.Forms.Label
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents insertsectionbreaks As System.Windows.Forms.CheckBox
    Friend WithEvents includefoldername As System.Windows.Forms.CheckBox
    Friend WithEvents numberfolders As System.Windows.Forms.Label
    Friend WithEvents numberfiles As System.Windows.Forms.Label
    Friend WithEvents onlylistfolders As System.Windows.Forms.CheckBox
    Friend WithEvents includesummary As System.Windows.Forms.CheckBox
    Friend WithEvents usewallpaper As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.numberfiles = New System.Windows.Forms.Label
        Me.numberfolders = New System.Windows.Forms.Label
        Me.outputpathlabel = New System.Windows.Forms.Label
        Me.RefreshButton = New System.Windows.Forms.Button
        Me.inputpathlabel = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.onlylistfolders = New System.Windows.Forms.CheckBox
        Me.insertsectionbreaks = New System.Windows.Forms.CheckBox
        Me.includefoldername = New System.Windows.Forms.CheckBox
        Me.writefullpath = New System.Windows.Forms.CheckBox
        Me.includesummary = New System.Windows.Forms.CheckBox
        Me.usewallpaper = New System.Windows.Forms.CheckBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.recursivelisting = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GenerateButton = New System.Windows.Forms.Button
        Me.opengeneratedfile = New System.Windows.Forms.CheckBox
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem3, Me.MenuItem4})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem6, Me.MenuItem2})
        Me.MenuItem1.Text = "Actions"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Text = "Generate Listing"
        '
        'MenuItem6
        '
        Me.MenuItem6.Enabled = False
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "Refresh Listing"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Text = "Exit"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "Help"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "About"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.numberfiles)
        Me.GroupBox1.Controls.Add(Me.numberfolders)
        Me.GroupBox1.Controls.Add(Me.outputpathlabel)
        Me.GroupBox1.Controls.Add(Me.RefreshButton)
        Me.GroupBox1.Controls.Add(Me.inputpathlabel)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.recursivelisting)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GenerateButton)
        Me.GroupBox1.Controls.Add(Me.opengeneratedfile)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 197)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'numberfiles
        '
        Me.numberfiles.ForeColor = System.Drawing.Color.DimGray
        Me.numberfiles.Location = New System.Drawing.Point(160, 152)
        Me.numberfiles.Name = "numberfiles"
        Me.numberfiles.Size = New System.Drawing.Size(80, 16)
        Me.numberfiles.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.numberfiles, "The number of files scanned in the listing process.")
        '
        'numberfolders
        '
        Me.numberfolders.ForeColor = System.Drawing.Color.DimGray
        Me.numberfolders.Location = New System.Drawing.Point(160, 136)
        Me.numberfolders.Name = "numberfolders"
        Me.numberfolders.Size = New System.Drawing.Size(80, 16)
        Me.numberfolders.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.numberfolders, "The number of folders scanned in the listing process.")
        '
        'outputpathlabel
        '
        Me.outputpathlabel.Location = New System.Drawing.Point(280, 136)
        Me.outputpathlabel.Name = "outputpathlabel"
        Me.outputpathlabel.Size = New System.Drawing.Size(40, 23)
        Me.outputpathlabel.TabIndex = 16
        Me.outputpathlabel.Visible = False
        '
        'RefreshButton
        '
        Me.RefreshButton.BackColor = System.Drawing.SystemColors.Control
        Me.RefreshButton.Enabled = False
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshButton.Location = New System.Drawing.Point(88, 16)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(72, 24)
        Me.RefreshButton.TabIndex = 15
        Me.RefreshButton.Text = "Refresh"
        Me.ToolTip1.SetToolTip(Me.RefreshButton, "Regenerate the last listing done.")
        '
        'inputpathlabel
        '
        Me.inputpathlabel.ForeColor = System.Drawing.Color.DimGray
        Me.inputpathlabel.Location = New System.Drawing.Point(16, 72)
        Me.inputpathlabel.Name = "inputpathlabel"
        Me.inputpathlabel.Size = New System.Drawing.Size(312, 56)
        Me.inputpathlabel.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.inputpathlabel, "The root folder from which the listing is being generated from.")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.onlylistfolders)
        Me.GroupBox2.Controls.Add(Me.insertsectionbreaks)
        Me.GroupBox2.Controls.Add(Me.includefoldername)
        Me.GroupBox2.Controls.Add(Me.writefullpath)
        Me.GroupBox2.Controls.Add(Me.includesummary)
        Me.GroupBox2.Controls.Add(Me.usewallpaper)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(336, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 181)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listing Options"
        '
        'onlylistfolders
        '
        Me.onlylistfolders.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.onlylistfolders.Location = New System.Drawing.Point(40, 56)
        Me.onlylistfolders.Name = "onlylistfolders"
        Me.onlylistfolders.Size = New System.Drawing.Size(120, 16)
        Me.onlylistfolders.TabIndex = 19
        Me.onlylistfolders.Text = "Only List Folders"
        Me.ToolTip1.SetToolTip(Me.onlylistfolders, "If selected, only folder names will be included in the listing")
        '
        'insertsectionbreaks
        '
        Me.insertsectionbreaks.Checked = True
        Me.insertsectionbreaks.CheckState = System.Windows.Forms.CheckState.Checked
        Me.insertsectionbreaks.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertsectionbreaks.Location = New System.Drawing.Point(40, 120)
        Me.insertsectionbreaks.Name = "insertsectionbreaks"
        Me.insertsectionbreaks.Size = New System.Drawing.Size(120, 16)
        Me.insertsectionbreaks.TabIndex = 18
        Me.insertsectionbreaks.Text = "Insert Section Breaks"
        Me.ToolTip1.SetToolTip(Me.insertsectionbreaks, "If selected, linebreaks will be inserted to indicate different folder levels.")
        '
        'includefoldername
        '
        Me.includefoldername.Checked = True
        Me.includefoldername.CheckState = System.Windows.Forms.CheckState.Checked
        Me.includefoldername.Location = New System.Drawing.Point(16, 40)
        Me.includefoldername.Name = "includefoldername"
        Me.includefoldername.Size = New System.Drawing.Size(136, 16)
        Me.includefoldername.TabIndex = 17
        Me.includefoldername.Text = "Include Folder Name"
        Me.ToolTip1.SetToolTip(Me.includefoldername, "Selecting this will mean that folder names are included in the listing.")
        '
        'writefullpath
        '
        Me.writefullpath.Checked = True
        Me.writefullpath.CheckState = System.Windows.Forms.CheckState.Checked
        Me.writefullpath.Location = New System.Drawing.Point(16, 72)
        Me.writefullpath.Name = "writefullpath"
        Me.writefullpath.Size = New System.Drawing.Size(136, 16)
        Me.writefullpath.TabIndex = 16
        Me.writefullpath.Text = "Write Full Path"
        Me.ToolTip1.SetToolTip(Me.writefullpath, "Selecting this will mean that full paths will be recorded in the listing")
        '
        'includesummary
        '
        Me.includesummary.Checked = True
        Me.includesummary.CheckState = System.Windows.Forms.CheckState.Checked
        Me.includesummary.Location = New System.Drawing.Point(16, 24)
        Me.includesummary.Name = "includesummary"
        Me.includesummary.Size = New System.Drawing.Size(136, 16)
        Me.includesummary.TabIndex = 15
        Me.includesummary.Text = "Include Summary Text"
        Me.ToolTip1.SetToolTip(Me.includesummary, "Selecting this option will mean that headings and summary text will be included i" & _
        "n the generated file.")
        '
        'usewallpaper
        '
        Me.usewallpaper.Checked = True
        Me.usewallpaper.CheckState = System.Windows.Forms.CheckState.Checked
        Me.usewallpaper.Enabled = False
        Me.usewallpaper.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usewallpaper.Location = New System.Drawing.Point(40, 160)
        Me.usewallpaper.Name = "usewallpaper"
        Me.usewallpaper.Size = New System.Drawing.Size(88, 16)
        Me.usewallpaper.TabIndex = 13
        Me.usewallpaper.Text = "Use Wallpaper"
        Me.ToolTip1.SetToolTip(Me.usewallpaper, "If selected, the generated web page will have a background image.")
        '
        'RadioButton2
        '
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(16, 104)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(104, 16)
        Me.RadioButton2.TabIndex = 12
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Text File"
        Me.ToolTip1.SetToolTip(Me.RadioButton2, "This option generates a Unicode text file.")
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(16, 144)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(112, 16)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.Text = "HTML Document"
        Me.ToolTip1.SetToolTip(Me.RadioButton1, "This option generates an HTML webpage.")
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Number of Files Located:"
        Me.ToolTip1.SetToolTip(Me.Label3, "The number of files scanned in the listing process.")
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Number of Folders Scanned:"
        Me.ToolTip1.SetToolTip(Me.Label2, "The number of folders scanned in the listing process.")
        '
        'recursivelisting
        '
        Me.recursivelisting.Checked = True
        Me.recursivelisting.CheckState = System.Windows.Forms.CheckState.Checked
        Me.recursivelisting.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recursivelisting.Location = New System.Drawing.Point(176, 16)
        Me.recursivelisting.Name = "recursivelisting"
        Me.recursivelisting.Size = New System.Drawing.Size(112, 24)
        Me.recursivelisting.TabIndex = 5
        Me.recursivelisting.Text = "Recursive Listing"
        Me.ToolTip1.SetToolTip(Me.recursivelisting, "Selecting this option will mean that all subfolders will be scanned as well.")
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Source Folder:"
        Me.ToolTip1.SetToolTip(Me.Label1, "The root folder from which the listing is being generated from.")
        '
        'GenerateButton
        '
        Me.GenerateButton.BackColor = System.Drawing.SystemColors.Control
        Me.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenerateButton.Location = New System.Drawing.Point(8, 16)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(72, 24)
        Me.GenerateButton.TabIndex = 0
        Me.GenerateButton.Text = "Generate"
        Me.ToolTip1.SetToolTip(Me.GenerateButton, "Generate a folder listing.")
        '
        'opengeneratedfile
        '
        Me.opengeneratedfile.Checked = True
        Me.opengeneratedfile.CheckState = System.Windows.Forms.CheckState.Checked
        Me.opengeneratedfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opengeneratedfile.Location = New System.Drawing.Point(176, 40)
        Me.opengeneratedfile.Name = "opengeneratedfile"
        Me.opengeneratedfile.Size = New System.Drawing.Size(120, 16)
        Me.opengeneratedfile.TabIndex = 14
        Me.opengeneratedfile.Text = "Open Generated File"
        Me.ToolTip1.SetToolTip(Me.opengeneratedfile, "Selecting this option will mean that once the listing has been generated, the fil" & _
        "e will be opened using Window's default file handler.")
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Location = New System.Drawing.Point(0, 221)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(528, 19)
        Me.StatusBar1.SizingGrip = False
        Me.StatusBar1.TabIndex = 5
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel1.Width = 528
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.Filter = "All files|*.*"
        Me.SaveFileDialog1.Title = "Folder Listing Generator 1.0"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(528, 240)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(534, 272)
        Me.Menu = Me.MainMenu1
        Me.MinimumSize = New System.Drawing.Size(534, 272)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Folder Listing Generator 1.0"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Try
            Me.Close()
            Me.Dispose()
        Catch et As Exception
            StatusBar1.Panels.Item(0).Text = "Action Failed.    "
            MsgBox(et.Message, MsgBoxStyle.Exclamation, "Folder Listing Generator 1.0")
        End Try
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Try
            Dim aboutscreen As New About
            Dim result As DialogResult
            result = aboutscreen.ShowDialog()
            aboutscreen.Dispose()
        Catch et As Exception
            StatusBar1.Panels.Item(0).Text = "Action Failed.    "
            MsgBox(et.Message, MsgBoxStyle.Exclamation, "Folder Listing Generator 1.0")
        End Try
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Try
            Dim helpscreen As New Help
            'Dim result As DialogResult
            'result = helpscreen.ShowDialog()
            helpscreen.Show()
            'helpscreen.Dispose()
        Catch et As Exception
            StatusBar1.Panels.Item(0).Text = "Action Failed.    "
            MsgBox(et.Message, MsgBoxStyle.Exclamation, "Folder Listing Generator 1.0")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateButton.Click
        Generate_List()
    End Sub

    Public Sub Generate_List()
        Try
            FolderBrowserDialog1.Description = "Select the folder from which the File Listing is to be generated from."
            Dim result As DialogResult
            result = FolderBrowserDialog1.ShowDialog()
            If result = DialogResult.OK Then
                Dim result2 As DialogResult
                If RadioButton1.Checked = True Then
                    SaveFileDialog1.DefaultExt = "htm"
                    SaveFileDialog1.Filter = "HTML files|*.htm|All files|*.*"
                Else
                    SaveFileDialog1.DefaultExt = "txt"
                    SaveFileDialog1.Filter = "Text files|*.txt|All files|*.*"
                End If
                result2 = SaveFileDialog1.ShowDialog
                Dim inputtedpath As String
                inputtedpath = FolderBrowserDialog1.SelectedPath
                FolderBrowserDialog1.Dispose()
                If result2 = DialogResult.OK Then
                    Dim outputtedpath As String = SaveFileDialog1.FileName
                    SaveFileDialog1.Dispose()

                    inputpathlabel.Text = inputtedpath
                    outputpathlabel.Text = outputtedpath
                    Dim filemanipulator2 = New System.IO.FileInfo(outputtedpath)
                    If filemanipulator2.Exists = True Then
                        filemanipulator2.Delete()
                    End If
                    Me.Refresh()
                    ProcessPath(inputtedpath, outputtedpath)
                Else
                    SaveFileDialog1.Dispose()
                End If
            Else
                FolderBrowserDialog1.Dispose()
            End If

        Catch et As Exception
            StatusBar1.Panels.Item(0).Text = "Action Failed.    "
            MsgBox(et.Message, MsgBoxStyle.Exclamation, "Folder Listing Generator 1.0")
        End Try
    End Sub

    Public Sub ProcessPath(ByVal inputpath As String, ByVal outputpath As String)
        RefreshButton.Enabled = False
        MenuItem5.Enabled = False
        MenuItem6.Enabled = False
        GenerateButton.Enabled = False
        StatusBar1.Panels.Item(0).Text = ""
        numberfiles.Text = ""
        numberfolders.Text = ""
        Me.Refresh()
        Dim path As String
        path = inputpath
        If Directory.Exists(path) Then
            numberfiles.Text = "0"
            numberfolders.Text = "0"
            If includesummary.Checked = True Then
                Write_Head()
            Else
                If RadioButton1.Checked = True Then
                    Write_Short_HTM_Head()
                End If
            End If
            ProcessDirectory(path, outputpath)
            If includesummary.Checked = True Then
                Write_Tail()
            Else
                If RadioButton1.Checked = True Then
                    Write_Short_HTM_Tail()
                End If
            End If
        Else
            StatusBar1.Panels.Item(0).Text = "Action Failed.    "
            MsgBox(path & " is not a valid file or directory.", MsgBoxStyle.Exclamation, "Folder Listing Generator 1.0")
        End If

        StatusBar1.Panels.Item(0).Text = "Folder List Successfully Generated.    "

        If opengeneratedfile.Checked = True Then
            System.Diagnostics.Process.Start(outputpathlabel.Text)
        End If

        RefreshButton.Enabled = True
        MenuItem5.Enabled = True
        MenuItem6.Enabled = True
        GenerateButton.Enabled = True
    End Sub


    Public Sub ProcessDirectory(ByVal targetDirectory As String, ByVal outputpath As String)
        Try
            Dim fileEntries As String() = Directory.GetFiles(targetDirectory)

            Dim filemanipulator2 = New System.IO.FileInfo(outputpath)
            Dim objStreamWriter = New System.IO.StreamWriter(outputpath, True, System.Text.Encoding.Unicode)


            Dim fileName As String

            numberfolders.Text = (CInt(numberfolders.Text) + 1).ToString()
            If includefoldername.Checked = True Then
                Dim DInfo As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(targetDirectory)

                If writefullpath.Checked = True Then
                    If RadioButton2.Checked = True Then
                        objStreamWriter.WriteLine(DInfo.FullName)
                    Else
                        If includesummary.Checked = True Then
                            objStreamWriter.WriteLine("<li><b>" & DInfo.FullName & "</b></li>")
                        Else
                            objStreamWriter.WriteLine("<b>" & DInfo.FullName & "</b><br>")
                        End If

                    End If
                Else
                    If RadioButton2.Checked = True Then
                        objStreamWriter.WriteLine(DInfo.Name)
                    Else
                        If includesummary.Checked = True Then
                            objStreamWriter.WriteLine("<li><b>" & DInfo.Name & "</b></li>")
                        Else
                            objStreamWriter.WriteLine(DInfo.Name & "<br>")
                        End If
                    End If
                End If
            End If

            If fileEntries.Length() <> 0 And includefoldername.Checked = True Then
                If insertsectionbreaks.Checked = True And RadioButton2.Checked = True Then
                    objStreamWriter.WriteLine("")
                End If
            End If

            If Not onlylistfolders.Checked = True Then
                For Each fileName In fileEntries
                    numberfiles.Text = (CInt(numberfiles.Text) + 1).ToString()
                    Dim FInfo As System.IO.FileInfo = New System.IO.FileInfo(fileName)

                    If writefullpath.Checked = True Then
                        If RadioButton2.Checked = True Then
                            objStreamWriter.WriteLine(FInfo.FullName)
                        Else
                            If includesummary.Checked = True Then
                                objStreamWriter.WriteLine("<li>" & FInfo.FullName & "</li>")
                            Else
                                objStreamWriter.WriteLine(FInfo.FullName & "<br>")
                            End If
                        End If
                    Else
                        If RadioButton2.Checked = True Then
                            objStreamWriter.WriteLine(FInfo.Name)
                        Else
                            If includesummary.Checked = True Then
                                objStreamWriter.WriteLine("<li>" & FInfo.Name & "</li>")
                            Else
                                objStreamWriter.WriteLine(FInfo.Name & "<br>")
                            End If
                        End If
                    End If

                Next fileName
            End If
            If insertsectionbreaks.Checked = True And RadioButton2.Checked = True Then
                objStreamWriter.WriteLine("")
            End If
            objStreamWriter.Close()

            If recursivelisting.Checked = True Then
                Dim subdirectoryEntries As String() = Directory.GetDirectories(targetDirectory)

                Dim subdirectory As String
                For Each subdirectory In subdirectoryEntries
                    ProcessDirectory(subdirectory, outputpath)
                Next subdirectory
            End If

        Catch et As Exception
            StatusBar1.Panels.Item(0).Text = "Action Failed.    "
            MsgBox(et.Message, MsgBoxStyle.Exclamation, "Folder Listing Generator 1.0")
        End Try

    End Sub 'ProcessDirectory

    Private Sub Refresh_List()
        Try
            Dim inputtedpath, outputtedpath As String
            inputtedpath = inputpathlabel.Text
            outputtedpath = outputpathlabel.Text

            If (RadioButton2.Checked = True And outputtedpath.EndsWith(".htm")) Or (RadioButton1.Checked = True And outputtedpath.EndsWith(".txt")) Then
                Dim result2 As DialogResult
                If RadioButton1.Checked = True Then
                    SaveFileDialog1.DefaultExt = "htm"
                    SaveFileDialog1.Filter = "HTML files|*.htm|All files|*.*"
                Else
                    SaveFileDialog1.DefaultExt = "txt"
                    SaveFileDialog1.Filter = "Text files|*.txt|All files|*.*"
                End If
                SaveFileDialog1.FileName = ""
                result2 = SaveFileDialog1.ShowDialog
                If result2 = DialogResult.OK Then
                    outputtedpath = SaveFileDialog1.FileName
                    outputpathlabel.Text = outputtedpath
                    Dim filemanipulator2 = New System.IO.FileInfo(outputtedpath)
                    If filemanipulator2.Exists = True Then
                        filemanipulator2.Delete()
                    End If
                    SaveFileDialog1.Dispose()
                    Me.Refresh()
                    ProcessPath(inputtedpath, outputtedpath)
                Else
                    SaveFileDialog1.Dispose()
                End If

            Else
                Dim filemanipulator2 = New System.IO.FileInfo(outputtedpath)
                If filemanipulator2.Exists = True Then
                    filemanipulator2.Delete()
                End If
                Me.Refresh()
                ProcessPath(inputtedpath, outputtedpath)

            End If

        Catch et As Exception
            StatusBar1.Panels.Item(0).Text = "Action Failed.    "
            MsgBox(et.Message, MsgBoxStyle.Exclamation, "Folder Listing Generator 1.0")
        End Try
    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        Refresh_List()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Generate_List()
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Refresh_List()
    End Sub

    Private Sub Write_Head()
        Try
            Dim outputpath As String = outputpathlabel.Text
            Dim inputpath As String = inputpathlabel.Text
            Dim filemanipulator2 = New System.IO.FileInfo(outputpath)
            Dim objStreamWriter = New System.IO.StreamWriter(outputpath, True, System.Text.Encoding.Unicode)
            If RadioButton2.Checked = True Then
                objStreamWriter.WriteLine("Folder Listing Generator 1.0")
            objStreamWriter.WriteLine("")
            objStreamWriter.WriteLine("File generated at: " & Now())
            objStreamWriter.WriteLine("Source Folder: " & inputpath)
            objStreamWriter.WriteLine("Generate File: " & outputpath)
            objStreamWriter.WriteLine("")
            objStreamWriter.WriteLine("<Begin Listing>")
            objStreamWriter.WriteLine("----------------------------")
                objStreamWriter.WriteLine("")
            Else
                objStreamWriter.WriteLine("<html><head><Title>Folder Listing Generator 1.0 - Generated Folder Listing</Title></head>")
                If usewallpaper.Checked = True Then
                    Dim f As FileInfo
                    f = New FileInfo(Application.ExecutablePath())
                    objStreamWriter.WriteLine("<body bgproperties=""fixed"" background=""" & f.DirectoryName() & "\Images\Background_Image_Log_File.jpg"">")
                Else
                    objStreamWriter.WriteLine("<body>")
                End If
                objStreamWriter.WriteLine("<h1>Folder Listing Generator 1.0</h1>")
                objStreamWriter.WriteLine("<p>")
                objStreamWriter.WriteLine("<b>File generated at: </b>" & Now() & "<br>")
                objStreamWriter.WriteLine("<b>Source Folder: </b>" & inputpath & "<br>")
                objStreamWriter.WriteLine("<b>Generate File: </b>" & outputpath & "</p>")
                objStreamWriter.WriteLine("<p>&lt;Begin Listing&gt;</p>")
                objStreamWriter.WriteLine("<ul>")

            End If
            objStreamWriter.Close()
        Catch et As Exception
            StatusBar1.Panels.Item(0).Text = "Action Failed.    "
            MsgBox(et.Message, MsgBoxStyle.Exclamation, "Folder Listing Generator 1.0")
        End Try
    End Sub

    Private Sub Write_Tail()
        Try
            Dim outputpath As String = outputpathlabel.Text
            Dim filemanipulator2 = New System.IO.FileInfo(outputpath)
            Dim objStreamWriter = New System.IO.StreamWriter(outputpath, True, System.Text.Encoding.Unicode)
            If RadioButton2.Checked = True Then
                objStreamWriter.WriteLine("")
                objStreamWriter.WriteLine("----------------------------")
                objStreamWriter.WriteLine("<End Listing>")
                objStreamWriter.WriteLine("")
                objStreamWriter.WriteLine("Number of Folders Scanned: " & numberfolders.Text)
                objStreamWriter.WriteLine("Number of Files Scanned: " & numberfiles.Text)
            Else
                objStreamWriter.WriteLine("</ul>")
                objStreamWriter.WriteLine("<p>&lt;End Listing&gt;</p>")
                objStreamWriter.WriteLine("<p>")
                objStreamWriter.WriteLine("<b>Number of Folders Scanned: </b>" & numberfolders.Text & "<br>")
                objStreamWriter.WriteLine("<b>Number of Files Scanned: </b>" & numberfiles.Text & "</p></body></html>")
            End If
            objStreamWriter.Close()
        Catch et As Exception
            StatusBar1.Panels.Item(0).Text = "Action Failed.    "
            MsgBox(et.Message, MsgBoxStyle.Exclamation, "Folder Listing Generator 1.0")
        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            insertsectionbreaks.Enabled = True
            usewallpaper.Enabled = False
        Else
            insertsectionbreaks.Enabled = False
            usewallpaper.Enabled = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            insertsectionbreaks.Enabled = False
            usewallpaper.Enabled = True
        Else
            insertsectionbreaks.Enabled = True
            usewallpaper.Enabled = False
        End If
    End Sub

    Private Sub includefoldername_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles includefoldername.CheckedChanged
        If includefoldername.Checked = True Then
            onlylistfolders.Enabled = True
        Else
            onlylistfolders.Checked = False
            onlylistfolders.Enabled = False

        End If
    End Sub

    Private Sub Write_Short_HTM_Tail()
        Try
            Dim outputpath As String = outputpathlabel.Text
            Dim filemanipulator2 = New System.IO.FileInfo(outputpath)
            Dim objStreamWriter = New System.IO.StreamWriter(outputpath, True, System.Text.Encoding.Unicode)
            objStreamWriter.WriteLine("</p></body></html>")
            objStreamWriter.Close()
        Catch et As Exception
            StatusBar1.Panels.Item(0).Text = "Action Failed.    "
            MsgBox(et.Message, MsgBoxStyle.Exclamation, "Folder Listing Generator 1.0")
        End Try
    End Sub

    Private Sub Write_Short_HTM_Head()
        Try
            Dim outputpath As String = outputpathlabel.Text
            Dim inputpath As String = inputpathlabel.Text
            Dim filemanipulator2 = New System.IO.FileInfo(outputpath)
            Dim objStreamWriter = New System.IO.StreamWriter(outputpath, True, System.Text.Encoding.Unicode)
            
                objStreamWriter.WriteLine("<html><head><Title>Folder Listing Generator 1.0 - Generated Folder Listing</Title></head>")
                If usewallpaper.Checked = True Then
                    Dim f As FileInfo
                    f = New FileInfo(Application.ExecutablePath())
                    objStreamWriter.WriteLine("<body bgproperties=""fixed"" background=""" & f.DirectoryName() & "\Images\Background_Image_Log_File.jpg"">")
                Else
                    objStreamWriter.WriteLine("<body>")
                End If

                objStreamWriter.WriteLine("<p>")
            objStreamWriter.Close()
        Catch et As Exception
            StatusBar1.Panels.Item(0).Text = "Action Failed.    "
            MsgBox(et.Message, MsgBoxStyle.Exclamation, "Folder Listing Generator 1.0")
        End Try
    End Sub
End Class