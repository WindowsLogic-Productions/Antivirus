<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.files = New System.Windows.Forms.Label()
        Me.detected = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.labellastreal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.realtime = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.lblstat = New System.Windows.Forms.Label()
        Me.lblpercent = New System.Windows.Forms.Label()
        Me.lblspd = New System.Windows.Forms.Label()
        Me.lblsize = New System.Windows.Forms.Label()
        Me.lblsave = New System.Windows.Forms.Label()
        Me.lbldownloading = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.loc = New System.Windows.Forms.TextBox()
        Me.txtfilename = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.brws = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_download = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(625, 23)
        Me.Panel1.TabIndex = 0
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(590, 0)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(35, 23)
        Me.Button9.TabIndex = 0
        Me.Button9.Text = "X"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.SelectedPath = "C:\"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.IncludeSubdirectories = True
        Me.FileSystemWatcher1.Path = "C:\"
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(1, 119)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(625, 238)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(617, 212)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Antivirus Centre"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(34, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 127)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(200, 6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(411, 199)
        Me.ListBox1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(187, 59)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scan Types"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Full"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(99, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 26)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Custom"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.ProgressBar1)
        Me.TabPage2.Controls.Add(Me.files)
        Me.TabPage2.Controls.Add(Me.detected)
        Me.TabPage2.Controls.Add(Me.total)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(617, 212)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Process "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.TextBox1.Location = New System.Drawing.Point(10, 124)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(600, 84)
        Me.TextBox1.TabIndex = 7
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 102)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(600, 18)
        Me.ProgressBar1.TabIndex = 6
        '
        'files
        '
        Me.files.AutoSize = True
        Me.files.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.files.Location = New System.Drawing.Point(205, 41)
        Me.files.Name = "files"
        Me.files.Size = New System.Drawing.Size(18, 19)
        Me.files.TabIndex = 5
        Me.files.Text = "0"
        '
        'detected
        '
        Me.detected.AutoSize = True
        Me.detected.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detected.Location = New System.Drawing.Point(205, 72)
        Me.detected.Name = "detected"
        Me.detected.Size = New System.Drawing.Size(18, 19)
        Me.detected.TabIndex = 4
        Me.detected.Text = "0"
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Location = New System.Drawing.Point(205, 12)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(18, 19)
        Me.total.TabIndex = 3
        Me.total.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Infected/Detected Files :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Files Scanned :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total Files In Destination :"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TabPage3.Controls.Add(Me.labellastreal)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.realtime)
        Me.TabPage3.Controls.Add(Me.ListBox3)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(617, 212)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Controller"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'labellastreal
        '
        Me.labellastreal.AutoSize = True
        Me.labellastreal.Location = New System.Drawing.Point(121, 188)
        Me.labellastreal.Name = "labellastreal"
        Me.labellastreal.Size = New System.Drawing.Size(120, 13)
        Me.labellastreal.TabIndex = 7
        Me.labellastreal.Text = "No Files Were Scanned"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Last File Scanned :"
        '
        'realtime
        '
        Me.realtime.AutoSize = True
        Me.realtime.Location = New System.Drawing.Point(14, 97)
        Me.realtime.Name = "realtime"
        Me.realtime.Size = New System.Drawing.Size(93, 13)
        Me.realtime.TabIndex = 5
        Me.realtime.Text = "Real-time Enabled"
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(124, 4)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(486, 173)
        Me.ListBox3.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(111, 78)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Real-Time "
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(51, 29)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(36, 23)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Off"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(20, 29)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(47, 23)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "On "
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TabPage4.Controls.Add(Me.Button4)
        Me.TabPage4.Controls.Add(Me.Button3)
        Me.TabPage4.Controls.Add(Me.ListBox2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(617, 212)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Results"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(408, 180)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 28)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(512, 180)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 28)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Delete All"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(3, 3)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(607, 173)
        Me.ListBox2.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.lblstat)
        Me.TabPage5.Controls.Add(Me.lblpercent)
        Me.TabPage5.Controls.Add(Me.lblspd)
        Me.TabPage5.Controls.Add(Me.lblsize)
        Me.TabPage5.Controls.Add(Me.lblsave)
        Me.TabPage5.Controls.Add(Me.lbldownloading)
        Me.TabPage5.Controls.Add(Me.lblname)
        Me.TabPage5.Controls.Add(Me.ProgressBar2)
        Me.TabPage5.Controls.Add(Me.loc)
        Me.TabPage5.Controls.Add(Me.txtfilename)
        Me.TabPage5.Controls.Add(Me.Label8)
        Me.TabPage5.Controls.Add(Me.Label7)
        Me.TabPage5.Controls.Add(Me.brws)
        Me.TabPage5.Controls.Add(Me.btn_cancel)
        Me.TabPage5.Controls.Add(Me.btn_download)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(617, 212)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Safe Downloader"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'lblstat
        '
        Me.lblstat.AutoSize = True
        Me.lblstat.Location = New System.Drawing.Point(11, 148)
        Me.lblstat.Name = "lblstat"
        Me.lblstat.Size = New System.Drawing.Size(43, 13)
        Me.lblstat.TabIndex = 14
        Me.lblstat.Text = "Status :"
        '
        'lblpercent
        '
        Me.lblpercent.AutoSize = True
        Me.lblpercent.Location = New System.Drawing.Point(586, 150)
        Me.lblpercent.Name = "lblpercent"
        Me.lblpercent.Size = New System.Drawing.Size(21, 13)
        Me.lblpercent.TabIndex = 13
        Me.lblpercent.Text = "0%"
        '
        'lblspd
        '
        Me.lblspd.AutoSize = True
        Me.lblspd.Location = New System.Drawing.Point(11, 134)
        Me.lblspd.Name = "lblspd"
        Me.lblspd.Size = New System.Drawing.Size(44, 13)
        Me.lblspd.TabIndex = 12
        Me.lblspd.Text = "Speed :"
        '
        'lblsize
        '
        Me.lblsize.AutoSize = True
        Me.lblsize.Location = New System.Drawing.Point(11, 119)
        Me.lblsize.Name = "lblsize"
        Me.lblsize.Size = New System.Drawing.Size(31, 13)
        Me.lblsize.TabIndex = 11
        Me.lblsize.Text = "size :"
        '
        'lblsave
        '
        Me.lblsave.AutoSize = True
        Me.lblsave.Location = New System.Drawing.Point(11, 104)
        Me.lblsave.Name = "lblsave"
        Me.lblsave.Size = New System.Drawing.Size(53, 13)
        Me.lblsave.TabIndex = 10
        Me.lblsave.Text = "Save As :"
        '
        'lbldownloading
        '
        Me.lbldownloading.AutoSize = True
        Me.lbldownloading.Location = New System.Drawing.Point(11, 90)
        Me.lbldownloading.Name = "lbldownloading"
        Me.lbldownloading.Size = New System.Drawing.Size(75, 13)
        Me.lbldownloading.TabIndex = 9
        Me.lbldownloading.Text = "Downloading :"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(11, 75)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(41, 13)
        Me.lblname.TabIndex = 8
        Me.lblname.Text = "Name :"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(14, 166)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(596, 16)
        Me.ProgressBar2.TabIndex = 7
        '
        'loc
        '
        Me.loc.Location = New System.Drawing.Point(101, 36)
        Me.loc.Name = "loc"
        Me.loc.Size = New System.Drawing.Size(475, 20)
        Me.loc.TabIndex = 6
        '
        'txtfilename
        '
        Me.txtfilename.Location = New System.Drawing.Point(50, 9)
        Me.txtfilename.Name = "txtfilename"
        Me.txtfilename.Size = New System.Drawing.Size(530, 20)
        Me.txtfilename.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Where To Save :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "URL :"
        '
        'brws
        '
        Me.brws.Location = New System.Drawing.Point(579, 35)
        Me.brws.Name = "brws"
        Me.brws.Size = New System.Drawing.Size(27, 23)
        Me.brws.TabIndex = 2
        Me.brws.Text = "..."
        Me.brws.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(404, 183)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(100, 23)
        Me.btn_cancel.TabIndex = 1
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_download
        '
        Me.btn_download.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btn_download.Location = New System.Drawing.Point(510, 183)
        Me.btn_download.Name = "btn_download"
        Me.btn_download.Size = New System.Drawing.Size(100, 23)
        Me.btn_download.TabIndex = 0
        Me.btn_download.Text = "Download"
        Me.btn_download.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog2
        '
        Me.FolderBrowserDialog2.SelectedPath = "D:\"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(515, 73)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(36, 23)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "Off"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(484, 73)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(35, 23)
        Me.Button8.TabIndex = 3
        Me.Button8.Text = "On "
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label5.Location = New System.Drawing.Point(439, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Auto-Pilot Mode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label6.Location = New System.Drawing.Point(13, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(230, 33)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Seren Antivirus "
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(627, 359)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seren Antivirus Plus 2012"
        Me.Panel1.ResumeLayout(False)
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents labellastreal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents realtime As System.Windows.Forms.Label
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents files As System.Windows.Forms.Label
    Friend WithEvents detected As System.Windows.Forms.Label
    Friend WithEvents total As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog2 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_download As System.Windows.Forms.Button
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents loc As System.Windows.Forms.TextBox
    Friend WithEvents txtfilename As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents brws As System.Windows.Forms.Button
    Friend WithEvents lblpercent As System.Windows.Forms.Label
    Friend WithEvents lblspd As System.Windows.Forms.Label
    Friend WithEvents lblsize As System.Windows.Forms.Label
    Friend WithEvents lblsave As System.Windows.Forms.Label
    Friend WithEvents lbldownloading As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblstat As System.Windows.Forms.Label

End Class
