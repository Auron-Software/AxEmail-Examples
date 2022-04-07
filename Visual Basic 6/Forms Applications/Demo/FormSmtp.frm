VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form FormSmtp 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Auron Email Component -  Visual Basic 6 SMTP"
   ClientHeight    =   8730
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   8715
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   8730
   ScaleWidth      =   8715
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame4 
      Caption         =   "Result and Logging"
      Height          =   1590
      Left            =   135
      TabIndex        =   37
      Top             =   6975
      Width           =   8415
      Begin VB.TextBox textLastResponse 
         BackColor       =   &H80000004&
         Height          =   480
         Left            =   1620
         MultiLine       =   -1  'True
         TabIndex        =   44
         Top             =   630
         Width           =   6585
      End
      Begin VB.CommandButton buttonView 
         Caption         =   "&View"
         Height          =   315
         Left            =   6870
         TabIndex        =   40
         Top             =   1170
         Width           =   1335
      End
      Begin VB.TextBox textLogfile 
         Height          =   315
         Left            =   1620
         TabIndex        =   39
         Top             =   1170
         Width           =   5205
      End
      Begin VB.TextBox textResult 
         BackColor       =   &H80000004&
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   1620
         TabIndex        =   38
         Top             =   270
         Width           =   6585
      End
      Begin VB.Label Label18 
         Caption         =   "Response:"
         Height          =   240
         Left            =   390
         TabIndex        =   43
         Top             =   675
         Width           =   1005
      End
      Begin VB.Label Label15 
         Caption         =   "&Log File:"
         Height          =   285
         Left            =   390
         TabIndex        =   42
         Top             =   1215
         Width           =   645
      End
      Begin VB.Label Label14 
         Caption         =   "Res&ult:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   390
         TabIndex        =   41
         Top             =   315
         Width           =   1065
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "Message"
      Height          =   4080
      Left            =   135
      TabIndex        =   15
      Top             =   2790
      Width           =   8415
      Begin VB.CommandButton buttonSend 
         Caption         =   "S&end Message"
         Height          =   315
         Left            =   1590
         TabIndex        =   26
         Top             =   3495
         Width           =   6615
      End
      Begin VB.ComboBox comboPriority 
         Height          =   315
         Left            =   6720
         TabIndex        =   25
         Top             =   3060
         Width           =   1485
      End
      Begin VB.ComboBox comboCharset 
         Height          =   315
         Left            =   4290
         TabIndex        =   24
         Top             =   3060
         Width           =   1485
      End
      Begin VB.ComboBox comboFormat 
         Height          =   315
         ItemData        =   "FormSmtp.frx":0000
         Left            =   1590
         List            =   "FormSmtp.frx":0002
         TabIndex        =   23
         Top             =   3060
         Width           =   1485
      End
      Begin VB.CommandButton buttonBrowse 
         Caption         =   "&Browse..."
         Height          =   315
         Left            =   6840
         TabIndex        =   22
         Top             =   2670
         Width           =   1335
      End
      Begin VB.TextBox textAttachment 
         Height          =   315
         Left            =   1590
         TabIndex        =   21
         Top             =   2670
         Width           =   5175
      End
      Begin VB.TextBox textBody 
         Height          =   1215
         Left            =   1590
         TabIndex        =   20
         Top             =   1410
         Width           =   6585
      End
      Begin VB.TextBox textSubject 
         Height          =   315
         Left            =   1590
         TabIndex        =   19
         Top             =   1035
         Width           =   6585
      End
      Begin VB.TextBox textTO 
         Height          =   315
         Left            =   1605
         TabIndex        =   18
         Top             =   270
         Width           =   3165
      End
      Begin VB.TextBox textCC 
         Height          =   315
         Left            =   1590
         TabIndex        =   17
         Top             =   660
         Width           =   3180
      End
      Begin VB.TextBox textBCC 
         Height          =   315
         Left            =   5715
         TabIndex        =   16
         Top             =   675
         Width           =   2445
      End
      Begin MSComDlg.CommonDialog CommonDialog1 
         Left            =   270
         Top             =   1920
         _ExtentX        =   847
         _ExtentY        =   847
         _Version        =   393216
      End
      Begin VB.Label Label13 
         Caption         =   "P&riority:"
         Height          =   255
         Left            =   6090
         TabIndex        =   36
         Top             =   3135
         Width           =   915
      End
      Begin VB.Label Label12 
         Caption         =   "&Characterset:"
         Height          =   285
         Left            =   3270
         TabIndex        =   35
         Top             =   3135
         Width           =   1065
      End
      Begin VB.Label Label11 
         Caption         =   "&Format:"
         Height          =   285
         Left            =   360
         TabIndex        =   34
         Top             =   3135
         Width           =   1035
      End
      Begin VB.Label Label10 
         Caption         =   "Attachment:"
         Height          =   285
         Left            =   360
         TabIndex        =   33
         Top             =   2715
         Width           =   1005
      End
      Begin VB.Label Label9 
         Caption         =   "&Body:"
         Height          =   255
         Left            =   330
         TabIndex        =   32
         Top             =   1455
         Width           =   675
      End
      Begin VB.Label Label8 
         Caption         =   "&Subject:"
         Height          =   225
         Left            =   330
         TabIndex        =   31
         Top             =   1095
         Width           =   1095
      End
      Begin VB.Label Label5 
         Caption         =   "&To:"
         Height          =   285
         Left            =   360
         TabIndex        =   30
         Top             =   330
         Width           =   1185
      End
      Begin VB.Label Label7 
         Caption         =   "&CC:"
         Height          =   285
         Left            =   360
         TabIndex        =   29
         Top             =   690
         Width           =   675
      End
      Begin VB.Label Label16 
         Caption         =   "&BCC:"
         Height          =   255
         Left            =   4950
         TabIndex        =   28
         Top             =   720
         Width           =   420
      End
      Begin VB.Label Label17 
         Caption         =   "(use  ';' separator to specify multiple recipients)"
         Height          =   285
         Left            =   4905
         TabIndex        =   27
         Top             =   315
         Width           =   3375
      End
   End
   Begin VB.Frame Frame3 
      Caption         =   "Mail Server"
      Height          =   2580
      Left            =   135
      TabIndex        =   9
      Top             =   90
      Width           =   8415
      Begin VB.TextBox textPort 
         Height          =   300
         Left            =   5715
         TabIndex        =   10
         Top             =   270
         Width           =   690
      End
      Begin VB.TextBox textHost 
         Height          =   300
         Left            =   1620
         TabIndex        =   11
         Top             =   270
         Width           =   3105
      End
      Begin VB.CheckBox checkSecure 
         Caption         =   "Secure Mail Server (TLS/SSL)"
         Height          =   195
         Left            =   1620
         TabIndex        =   12
         Top             =   660
         Width           =   3075
      End
      Begin VB.TextBox textSenderName 
         Height          =   300
         Left            =   1620
         TabIndex        =   8
         Top             =   2070
         Width           =   3105
      End
      Begin VB.TextBox textSenderMail 
         Height          =   300
         Left            =   1620
         TabIndex        =   6
         Top             =   1725
         Width           =   3105
      End
      Begin VB.CheckBox checkAuthentication 
         Caption         =   "Server requires authentication"
         Height          =   255
         Left            =   1620
         TabIndex        =   0
         Top             =   900
         Width           =   2775
      End
      Begin VB.TextBox textAccount 
         Height          =   300
         Left            =   2610
         TabIndex        =   2
         Top             =   1230
         Width           =   2115
      End
      Begin VB.TextBox textPassword 
         Height          =   300
         IMEMode         =   3  'DISABLE
         Left            =   5715
         PasswordChar    =   "*"
         TabIndex        =   4
         Top             =   1215
         Width           =   2400
      End
      Begin VB.Label Label1 
         Caption         =   "&Host:"
         Height          =   300
         Left            =   360
         TabIndex        =   13
         Top             =   315
         Width           =   510
      End
      Begin VB.Label Label19 
         Caption         =   "Port:"
         Height          =   300
         Left            =   4905
         TabIndex        =   14
         Top             =   315
         Width           =   465
      End
      Begin VB.Label Label6 
         Caption         =   "Sender &Name:"
         Height          =   210
         Left            =   360
         TabIndex        =   7
         Top             =   2115
         Width           =   1185
      End
      Begin VB.Label Label4 
         Caption         =   "&Sender Email:"
         Height          =   300
         Left            =   360
         TabIndex        =   5
         Top             =   1785
         Width           =   1245
      End
      Begin VB.Label Label2 
         Caption         =   "&Account:"
         Height          =   300
         Left            =   1890
         TabIndex        =   1
         Top             =   1260
         Width           =   765
      End
      Begin VB.Label Label3 
         Caption         =   "&Password:"
         Height          =   300
         Left            =   4860
         TabIndex        =   3
         Top             =   1260
         Width           =   795
      End
   End
End
Attribute VB_Name = "FormSmtp"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public objMail
Public objSmtpServer

Public objConstants
Private Declare Function GetTempPath Lib "kernel32" Alias "GetTempPathA" (ByVal nBufferLength As Long, ByVal lpBuffer As String) As Long
Private Const MAX_PATH = 260


Private Sub Form_Load()
    Set objMail = CreateObject("AxEmail.Message")
    Set objConstants = CreateObject("AxEmail.Constants")
    Set objSmtpServer = CreateObject("AxEmail.Smtp")
    
    textPort = "25"
      
    comboFormat.AddItem "Plain"
    comboFormat.AddItem "HTML"
    comboFormat.ListIndex = 0
  
    comboPriority.AddItem "Highest"
    comboPriority.AddItem "High"
    comboPriority.AddItem "Normal"
    comboPriority.AddItem "Low"
    comboPriority.AddItem "Lowest"
    comboPriority.ListIndex = 2
    
    comboCharset.AddItem "Standard"
    comboCharset.AddItem "UTF8"
    comboCharset.ListIndex = 0
    
    SetDefaultLogFile
End Sub

Private Sub Form_Unload(Cancel As Integer)
    Unload Me
End Sub

Private Sub buttonSend_Click()
    
    MousePointer = vbHourglass

    objMail.Clear
    
    objMail.FromAddress = textSenderMail
    objMail.FromName = textSenderName
    
    objMail.Subject = textSubject
    If (comboFormat.ListIndex = 0) Then
        objMail.BodyPlainText = textBody
    Else
        objMail.BodyHtml = textBody
    End If
    objMail.Priority = comboPriority.ListIndex + 1
    
    If (comboCharset.ListIndex = 0) Then
       objMail.Encoding = objConstants.EMAIL_MESSAGE_ENCODING_DEFAULT
    Else
       objMail.Encoding = objConstants.EMAIL_MESSAGE_ENCODING_UTF8
    End If
    
    If (objMail.LastError = 0 And textTo <> "") Then
        objMail.AddTo textTo, ""
    End If
        
    If (objMail.LastError = 0 And textCC <> "") Then
        objMail.AddCc textCC, ""
    End If
    
    If (objMail.LastError = 0 And textBCC <> "") Then
        objMail.AddBcc textBCC, ""
    End If

    If (objMail.LastError = 0 And textAttachment.Text <> "") Then
        objMail.AddAttachment textAttachment.Text
    End If

    If (objMail.LastError <> 0) Then
        textResult = objMail.LastError & ": " & objMail.GetErrorDescription(objMail.LastError)
        textLastResponse = ""
        Exit Sub
    End If
    
    
    objSmtpServer.Clear
    
    objSmtpServer.LogFile = textLogfile
    
    ' Set Secure if secure communications is required
    If (checkSecure.Value) Then
        objSmtpServer.SetSecure (CInt(textPort.Text))
        textResult = "SetSecure, result: " & objSmtpServer.LastError & " : " & objSmtpServer.GetErrorDescription(objSmtpServer.LastError)
    Else
        objSmtpServer.HostPort = CInt(textPort.Text)
    End If
    
    If (objSmtpServer.LastError = 0) Then
        If (checkAuthentication.Value = 1) Then
            objSmtpServer.Connect textHost, textAccount, textPassword
        Else
            objSmtpServer.Connect textHost
        End If
        textResult = "Connect, result: " & objSmtpServer.LastError & " : " & objSmtpServer.GetErrorDescription(objSmtpServer.LastError)
    End If
    
    objSmtpServer.Send objMail
       
    textResult = objSmtpServer.LastError & ": " & objSmtpServer.GetErrorDescription(objSmtpServer.LastError)
    textLastResponse = objSmtpServer.LastSmtpResponse
    
    objSmtpServer.Disconnect
    
    MousePointer = vbDefault
End Sub

Private Sub buttonBrowse_Click()
    CommonDialog1.DefaultExt = "*.*"
    CommonDialog1.DialogTitle = "Select Attachment"
    CommonDialog1.Filter = "All Files (*.*)|*.*"
    CommonDialog1.ShowOpen
    
    textAttachment = CommonDialog1.FileName
End Sub

Private Sub buttonView_Click()
    If FileExists(textLogfile.Text) = True Then
        Shell "notepad " + textLogfile.Text, vbNormalFocus
    End If
End Sub

Private Sub checkSecure_Click()
    If (checkSecure.Value) Then
        textPort = "465"
    Else
        textPort = "25"
    End If
End Sub

Private Sub checkAuthentication_Click()
    UpdateControls
End Sub

Private Sub UpdateControls()
    textAccount.Enabled = checkAuthentication.Value
    textPassword.Enabled = checkAuthentication.Value
End Sub


Private Function SetDefaultLogFile()

Dim Buffer As String

Buffer = Space(MAX_PATH)

If GetTempPath(MAX_PATH, Buffer) <> 0 Then
    textLogfile.Text = Left$(Buffer, InStr(Buffer, vbNullChar) - 1) & "Smtp.log"
Else
    textLogfile.Text = "C:\SmtpLog.txt"
End If
End Function

Public Function FileExists(sFileName As String) As Boolean
  FileExists = CBool(Len(Dir$(sFileName))) And CBool(Len(sFileName))
End Function


