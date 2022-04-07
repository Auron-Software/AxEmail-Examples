VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form FormPop3 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Auron Email Component -  Visual Basic 6 POP3"
   ClientHeight    =   10770
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   8730
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   10770
   ScaleWidth      =   8730
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame1 
      Caption         =   "Mail Server"
      Height          =   2205
      Left            =   195
      TabIndex        =   28
      Top             =   135
      Width           =   8325
      Begin VB.CheckBox checkSecurePop3 
         Caption         =   "Secure Mail Server (TLS/SSL)"
         Height          =   195
         Left            =   1485
         TabIndex        =   33
         Top             =   675
         Width           =   4425
      End
      Begin VB.TextBox textPort 
         Height          =   300
         Left            =   6210
         TabIndex        =   30
         Top             =   315
         Width           =   1050
      End
      Begin VB.CommandButton buttonDisconnect 
         Caption         =   "&Disconnect"
         Height          =   315
         Left            =   3555
         TabIndex        =   7
         Top             =   1710
         Width           =   1860
      End
      Begin VB.CommandButton buttonConnect 
         Caption         =   "&Connect"
         Height          =   315
         Left            =   1485
         TabIndex        =   6
         Top             =   1710
         Width           =   1995
      End
      Begin VB.TextBox textPassword 
         Height          =   300
         IMEMode         =   3  'DISABLE
         Left            =   1470
         PasswordChar    =   "*"
         TabIndex        =   5
         Top             =   1335
         Width           =   3975
      End
      Begin VB.TextBox textAccount 
         Height          =   300
         Left            =   1470
         TabIndex        =   3
         Top             =   945
         Width           =   3975
      End
      Begin VB.TextBox textHost 
         Height          =   300
         Left            =   1470
         TabIndex        =   1
         Top             =   315
         Width           =   3975
      End
      Begin VB.Label Label11 
         Caption         =   "Port:"
         Height          =   255
         Left            =   5760
         TabIndex        =   29
         Top             =   360
         Width           =   870
      End
      Begin VB.Label Label3 
         Caption         =   "&Password:"
         Height          =   315
         Left            =   315
         TabIndex        =   4
         Top             =   1395
         Width           =   855
      End
      Begin VB.Label Label2 
         Caption         =   "&Account:"
         Height          =   255
         Left            =   315
         TabIndex        =   2
         Top             =   990
         Width           =   675
      End
      Begin VB.Label Label1 
         Caption         =   "&Host:"
         Height          =   255
         Left            =   315
         TabIndex        =   0
         Top             =   360
         Width           =   435
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "Received Messages"
      Height          =   2955
      Left            =   195
      TabIndex        =   27
      Top             =   2385
      Width           =   8325
      Begin VB.CommandButton buttonList 
         Caption         =   "&List Messages"
         Height          =   315
         Left            =   1410
         TabIndex        =   9
         Top             =   2460
         Width           =   6555
      End
      Begin MSComctlLib.ListView listMessages 
         Height          =   2055
         Left            =   1410
         TabIndex        =   8
         Top             =   300
         Width           =   6555
         _ExtentX        =   11562
         _ExtentY        =   3625
         View            =   3
         LabelEdit       =   1
         LabelWrap       =   0   'False
         HideSelection   =   -1  'True
         FullRowSelect   =   -1  'True
         GridLines       =   -1  'True
         _Version        =   393217
         ForeColor       =   -2147483640
         BackColor       =   -2147483643
         BorderStyle     =   1
         Appearance      =   1
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         NumItems        =   3
         BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Text            =   "Sender"
            Object.Width           =   3528
         EndProperty
         BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   1
            Text            =   "Time"
            Object.Width           =   3528
         EndProperty
         BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   2
            Text            =   "Subject"
            Object.Width           =   3528
         EndProperty
      End
   End
   Begin VB.Frame Frame3 
      Caption         =   "Current Message"
      Height          =   3255
      Left            =   195
      TabIndex        =   26
      Top             =   5385
      Width           =   8325
      Begin VB.TextBox textBody 
         BackColor       =   &H80000004&
         Height          =   975
         Left            =   1410
         MultiLine       =   -1  'True
         ScrollBars      =   2  'Vertical
         TabIndex        =   17
         Top             =   1380
         Width           =   6555
      End
      Begin VB.TextBox textSubject 
         BackColor       =   &H80000004&
         Height          =   300
         Left            =   1410
         TabIndex        =   15
         Top             =   1020
         Width           =   6555
      End
      Begin VB.TextBox textTo 
         BackColor       =   &H80000004&
         Height          =   300
         Left            =   1410
         TabIndex        =   13
         Top             =   660
         Width           =   6555
      End
      Begin VB.TextBox textFrom 
         BackColor       =   &H80000004&
         Height          =   300
         Left            =   1410
         TabIndex        =   11
         Top             =   300
         Width           =   6555
      End
      Begin MSComctlLib.ListView listAttachments 
         Height          =   675
         Left            =   1410
         TabIndex        =   19
         Top             =   2400
         Width           =   6555
         _ExtentX        =   11562
         _ExtentY        =   1191
         View            =   2
         LabelWrap       =   -1  'True
         HideSelection   =   -1  'True
         _Version        =   393217
         ForeColor       =   -2147483640
         BackColor       =   -2147483644
         BorderStyle     =   1
         Appearance      =   1
         Enabled         =   0   'False
         NumItems        =   0
      End
      Begin VB.Label Label8 
         Caption         =   "Attachments:"
         Height          =   315
         Left            =   315
         TabIndex        =   18
         Top             =   2400
         Width           =   975
      End
      Begin VB.Label Label7 
         Caption         =   "Body:"
         Height          =   255
         Left            =   315
         TabIndex        =   16
         Top             =   1440
         Width           =   1095
      End
      Begin VB.Label Label6 
         Caption         =   "Subject:"
         Height          =   255
         Left            =   315
         TabIndex        =   14
         Top             =   1080
         Width           =   1035
      End
      Begin VB.Label Label5 
         Caption         =   "To:"
         Height          =   255
         Left            =   315
         TabIndex        =   12
         Top             =   720
         Width           =   1095
      End
      Begin VB.Label Label4 
         Caption         =   "From:"
         Height          =   255
         Left            =   315
         TabIndex        =   10
         Top             =   360
         Width           =   1095
      End
   End
   Begin VB.Frame Frame4 
      Caption         =   "Result and Logging"
      Height          =   1845
      Left            =   195
      TabIndex        =   25
      Top             =   8730
      Width           =   8325
      Begin VB.TextBox textLastResponse 
         BackColor       =   &H80000004&
         Height          =   510
         Left            =   1410
         TabIndex        =   31
         Top             =   645
         Width           =   6540
      End
      Begin VB.CommandButton buttonView 
         Caption         =   "&View"
         Height          =   315
         Left            =   6870
         TabIndex        =   24
         Top             =   1245
         Width           =   1095
      End
      Begin VB.TextBox textLogfile 
         Height          =   300
         Left            =   1410
         TabIndex        =   23
         Top             =   1245
         Width           =   5355
      End
      Begin VB.TextBox textResult 
         BackColor       =   &H80000004&
         Height          =   300
         Left            =   1410
         TabIndex        =   21
         Top             =   300
         Width           =   6555
      End
      Begin VB.Label Label12 
         Caption         =   "Response:"
         Height          =   285
         Left            =   315
         TabIndex        =   32
         Top             =   675
         Width           =   870
      End
      Begin VB.Label Label10 
         Caption         =   "&Logfile:"
         Height          =   195
         Left            =   315
         TabIndex        =   22
         Top             =   1305
         Width           =   855
      End
      Begin VB.Label Label9 
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
         Height          =   255
         Left            =   315
         TabIndex        =   20
         Top             =   360
         Width           =   915
      End
   End
End
Attribute VB_Name = "FormPop3"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public objPop3
Public objConstants

Private Declare Function GetTempPath Lib "kernel32" Alias "GetTempPathA" (ByVal nBufferLength As Long, ByVal lpBuffer As String) As Long
Private Const MAX_PATH = 260

Private Sub buttonView_Click()
    If FileExists(textLogfile.Text) = True Then
        Shell "notepad " + textLogfile.Text, vbNormalFocus
    End If
End Sub
Public Function FileExists(sFileName As String) As Boolean
  FileExists = CBool(Len(Dir$(sFileName))) And CBool(Len(sFileName))
End Function

Private Sub Form_Load()
    
    Set objPop3 = CreateObject("AxEmail.Pop3")
    Set objConstants = CreateObject("AxEmail.Constants")
    
    LoadSettings
    SetDefaultLogFile
    EnableControls
    
End Sub

Private Sub Form_Unload(Cancel As Integer)
    SaveSettings
    Unload Me
End Sub
Private Sub buttonConnect_Click()
    MousePointer = vbHourglass

    objPop3.Clear
    objPop3.LogFile = textLogfile.Text
    
    ' Set Secure if secure communications is required
    If (checkSecurePop3.Value) Then
        objPop3.SetSecure (CInt(textPort.Text))
        textResult = "SetSecure, result: " & objPop3.LastError & " : " & objPop3.GetErrorDescription(objPop3.LastError)
    Else
        objPop3.HostPort = CInt(textPort.Text)
    End If
    
    objPop3.Connect textHost.Text, textAccount.Text, textPassword.Text
    If (GetResult() = 0) Then
        EnableControls
    End If
        
    textLastResponse = objPop3.LastPop3Response
    MousePointer = vbDefault
End Sub

Private Sub buttonDisconnect_Click()
    MousePointer = vbHourglass

    objPop3.Disconnect
    
    EnableControls
       
    MousePointer = vbDefault
End Sub

Private Sub buttonList_Click()
    Dim numMessages As Integer
    
    MousePointer = vbHourglass

    numMessages = objPop3.CountMessages
    
    For i = 1 To numMessages
    
        Dim objMessage As AxEmail.Message
        
        Set objMessage = objPop3.GetEmailHeader(i)
            
        If GetResult = 0 Then
    
          Dim lList As ListItem
     
          Set lList = listMessages.ListItems.Add(, , objMessage.FromAddress)
        
          lList.SubItems(1) = objMessage.Date
          lList.SubItems(2) = objMessage.Subject
         
        End If
    Next
    
    If (GetResult() = 0) Then
        EnableControls
    End If
        
    textLastResponse = objPop3.LastPop3Response
    
    MousePointer = vbDefault
End Sub


Private Sub checkSecurePop3_Click()
    If (checkSecurePop3.Value) Then
        textPort = "995"
    Else
        textPort = "110"
    End If
End Sub

Private Sub listMessages_ItemClick(ByVal Item As MSComctlLib.ListItem)
    Dim objMessage As AxEmail.Message
    Dim numAttachments As Integer
    
    listAttachments.ListItems.Clear
    
    MousePointer = vbHourglass
    
    Set objMessage = objPop3.GetEmailMessage(Item.Index)
            
    MousePointer = vbDefault
    
    If GetResult = 0 Then
    
       textFrom.Text = objMessage.FromAddress
       textTo.Text = objMessage.ToAddress
       textSubject.Text = objMessage.Subject
       textBody.Text = objMessage.BodyPlainText
       If (textBody.Text = "") Then
        textBody.Text = objMessage.BodyHtml
       End If
       
       
       numAttachments = objMessage.CountAttachments
       
       For i = 1 To numAttachments
          Dim lList As ListItem
     
          Set lList = listAttachments.ListItems.Add(, , objMessage.GetAttachmentName(i))
       Next
    End If
End Sub


Private Function GetResult() As Long
    
    Dim lResult As Long
    
    lResult = objPop3.LastError                                ' Get Last Error
        
    textResult.Text = objPop3.LastError & ": " & objPop3.GetErrorDescription(lResult) ' Set Result
    
    GetResult = lResult
    
End Function

Private Sub EnableControls()

    Dim bConnected As Boolean

    bConnected = objPop3.IsConnected
    
    textPassword.Enabled = Not bConnected
    textAccount.Enabled = Not bConnected
    textHost.Enabled = Not bConnected
    buttonConnect.Enabled = Not bConnected
    buttonDisconnect.Enabled = bConnected
    buttonList.Enabled = bConnected
    listMessages.Enabled = bConnected
    textTo.Enabled = bConnected
    textFrom.Enabled = bConnected
    textSubject.Enabled = bConnected
    textBody.Enabled = bConnected

End Sub


Private Sub LoadSettings()
    textHost = GetSetting("Auron Email Component", "POP3", "Host", "pop3.mydomain.com")
    textPort = GetSetting("Auron Email Component", "POP3", "Port", "110")
    If (GetSetting("Auron Email Component", "POP3", "Secure", "0") = "0") Then
        checkSecurePop3.Value = 0
    Else
        checkSecurePop3.Value = 1
    End If
    textAccount = GetSetting("Auron Email Component", "POP3", "Login", "account")
    textPassword = GetSetting("Auron Email Component", "POP3", "Password", "password")
End Sub

Private Sub SaveSettings()
    SaveSetting "Auron Email Component", "POP3", "Host", textHost.Text
    SaveSetting "Auron Email Component", "POP3", "Port", textPort.Text
    If (checkSecurePop3.Value) Then
        SaveSetting "Auron Email Component", "POP3", "Secure", "1"
    Else
        SaveSetting "Auron Email Component", "POP3", "Secure", "0"
    End If
    SaveSetting "Auron Email Component", "POP3", "Login", textAccount.Text
    SaveSetting "Auron Email Component", "POP3", "Password", textPassword.Text
End Sub

Private Function SetDefaultLogFile()

Dim Buffer As String
Buffer = Space(MAX_PATH)

If GetTempPath(MAX_PATH, Buffer) <> 0 Then
    textLogfile.Text = Left$(Buffer, InStr(Buffer, vbNullChar) - 1) & "Pop3.log"
Else
    textLogfile.Text = "C:\Pop3.log"
End If
End Function

