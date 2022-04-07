VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form FormImap 
   Caption         =   "Auron Email Component - Visual Basic 6 IMAP"
   ClientHeight    =   10695
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8670
   LinkTopic       =   "Form1"
   ScaleHeight     =   10695
   ScaleWidth      =   8670
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame4 
      Caption         =   "Result and Logging"
      Height          =   1845
      Left            =   120
      TabIndex        =   26
      Top             =   8715
      Width           =   8325
      Begin VB.TextBox textResult 
         BackColor       =   &H80000004&
         Height          =   300
         Left            =   1410
         TabIndex        =   30
         Top             =   300
         Width           =   6555
      End
      Begin VB.TextBox textLogfile 
         Height          =   300
         Left            =   1410
         TabIndex        =   29
         Top             =   1245
         Width           =   5355
      End
      Begin VB.CommandButton buttonView 
         Caption         =   "&View"
         Height          =   315
         Left            =   6870
         TabIndex        =   28
         Top             =   1245
         Width           =   1095
      End
      Begin VB.TextBox textLastResponse 
         BackColor       =   &H80000004&
         Height          =   510
         Left            =   1410
         TabIndex        =   27
         Top             =   645
         Width           =   6540
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
         TabIndex        =   33
         Top             =   360
         Width           =   915
      End
      Begin VB.Label Label10 
         Caption         =   "&Logfile:"
         Height          =   195
         Left            =   315
         TabIndex        =   32
         Top             =   1305
         Width           =   855
      End
      Begin VB.Label Label12 
         Caption         =   "Response:"
         Height          =   285
         Left            =   315
         TabIndex        =   31
         Top             =   675
         Width           =   870
      End
   End
   Begin VB.Frame Frame3 
      Caption         =   "Current Message"
      Height          =   3255
      Left            =   120
      TabIndex        =   15
      Top             =   5370
      Width           =   8325
      Begin VB.TextBox textFrom 
         BackColor       =   &H80000004&
         Height          =   300
         Left            =   1410
         TabIndex        =   19
         Top             =   300
         Width           =   6555
      End
      Begin VB.TextBox textTo 
         BackColor       =   &H80000004&
         Height          =   300
         Left            =   1410
         TabIndex        =   18
         Top             =   660
         Width           =   6555
      End
      Begin VB.TextBox textSubject 
         BackColor       =   &H80000004&
         Height          =   300
         Left            =   1410
         TabIndex        =   17
         Top             =   1020
         Width           =   6555
      End
      Begin VB.TextBox textBody 
         BackColor       =   &H80000004&
         Height          =   975
         Left            =   1410
         MultiLine       =   -1  'True
         ScrollBars      =   2  'Vertical
         TabIndex        =   16
         Top             =   1380
         Width           =   6555
      End
      Begin MSComctlLib.ListView listAttachments 
         Height          =   675
         Left            =   1410
         TabIndex        =   20
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
      Begin VB.Label Label4 
         Caption         =   "From:"
         Height          =   255
         Left            =   315
         TabIndex        =   25
         Top             =   360
         Width           =   1095
      End
      Begin VB.Label Label5 
         Caption         =   "To:"
         Height          =   255
         Left            =   315
         TabIndex        =   24
         Top             =   720
         Width           =   1095
      End
      Begin VB.Label Label6 
         Caption         =   "Subject:"
         Height          =   255
         Left            =   315
         TabIndex        =   23
         Top             =   1080
         Width           =   1035
      End
      Begin VB.Label Label7 
         Caption         =   "Body:"
         Height          =   255
         Left            =   315
         TabIndex        =   22
         Top             =   1440
         Width           =   1095
      End
      Begin VB.Label Label8 
         Caption         =   "Attachments:"
         Height          =   315
         Left            =   315
         TabIndex        =   21
         Top             =   2400
         Width           =   975
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "Received Messages"
      Height          =   2955
      Left            =   120
      TabIndex        =   12
      Top             =   2370
      Width           =   8325
      Begin MSComDlg.CommonDialog CommonDialog1 
         Left            =   240
         Top             =   1800
         _ExtentX        =   847
         _ExtentY        =   847
         _Version        =   393216
      End
      Begin VB.CommandButton buttonSave 
         Caption         =   "&Save Message..."
         Height          =   315
         Left            =   5655
         TabIndex        =   37
         Top             =   2469
         Width           =   1995
      End
      Begin VB.CommandButton buttonDelete 
         Caption         =   "&Delete Message"
         Height          =   315
         Left            =   3577
         TabIndex        =   36
         Top             =   2469
         Width           =   1995
      End
      Begin VB.ComboBox cmbMailbox 
         Height          =   315
         Left            =   1410
         TabIndex        =   34
         Top             =   270
         Width           =   4095
      End
      Begin VB.CommandButton buttonList 
         Caption         =   "&List Messages"
         Height          =   315
         Left            =   1410
         TabIndex        =   13
         Top             =   2469
         Width           =   2085
      End
      Begin MSComctlLib.ListView listMessages 
         Height          =   1695
         Left            =   1410
         TabIndex        =   14
         Top             =   660
         Width           =   6555
         _ExtentX        =   11562
         _ExtentY        =   2990
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
      Begin VB.Label Label13 
         Caption         =   "Mailbox:"
         Height          =   255
         Left            =   315
         TabIndex        =   35
         Top             =   360
         Width           =   735
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Mail Server"
      Height          =   2205
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   8325
      Begin VB.TextBox textHost 
         Height          =   300
         Left            =   1470
         TabIndex        =   7
         Top             =   315
         Width           =   3975
      End
      Begin VB.TextBox textAccount 
         Height          =   300
         Left            =   1470
         TabIndex        =   6
         Top             =   945
         Width           =   3975
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
      Begin VB.CommandButton buttonConnect 
         Caption         =   "&Connect"
         Height          =   315
         Left            =   1485
         TabIndex        =   4
         Top             =   1710
         Width           =   1995
      End
      Begin VB.CommandButton buttonDisconnect 
         Caption         =   "&Disconnect"
         Height          =   315
         Left            =   3555
         TabIndex        =   3
         Top             =   1710
         Width           =   1860
      End
      Begin VB.TextBox textPort 
         Height          =   300
         Left            =   6210
         TabIndex        =   2
         Top             =   315
         Width           =   1050
      End
      Begin VB.CheckBox checkSecure 
         Caption         =   "Secure Mail Server (TLS/SSL)"
         Height          =   195
         Left            =   1485
         TabIndex        =   1
         Top             =   675
         Width           =   4425
      End
      Begin VB.Label Label1 
         Caption         =   "&Host:"
         Height          =   255
         Left            =   315
         TabIndex        =   11
         Top             =   360
         Width           =   435
      End
      Begin VB.Label Label2 
         Caption         =   "&Account:"
         Height          =   255
         Left            =   315
         TabIndex        =   10
         Top             =   990
         Width           =   675
      End
      Begin VB.Label Label3 
         Caption         =   "&Password:"
         Height          =   315
         Left            =   315
         TabIndex        =   9
         Top             =   1395
         Width           =   855
      End
      Begin VB.Label Label11 
         Caption         =   "Port:"
         Height          =   255
         Left            =   5760
         TabIndex        =   8
         Top             =   360
         Width           =   870
      End
   End
End
Attribute VB_Name = "FormImap"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public objImap
Public objConstants

Private Declare Function GetTempPath Lib "kernel32" Alias "GetTempPathA" (ByVal nBufferLength As Long, ByVal lpBuffer As String) As Long
Private Const MAX_PATH = 260

Private Sub buttonDelete_Click()
    
    If listMessages.SelectedItem Is Nothing Then Return
       
    nUid = listMessages.SelectedItem.Tag
    
    objImap.Store nUid, objConstants.IMAP_MAIL_FLAG_DELETED, objConstants.IMAP_STO_ADD
    If GetResult() = 0 Then
        objImap.Expunge
        buttonList_Click
    End If
    
End Sub

Private Sub buttonList_Click()
    
    MousePointer = vbHourglass
    
    listMessages.ListItems.Clear
    
    objImap.Select cmbMailbox.Text
    If GetResult() <> 0 Then Return
    
    Set objMessage = objImap.FetchFirstEmailHeader(objConstants.IMAP_SK_ALL)
    While objImap.LastError = 0
    
        Set lList = listMessages.ListItems.Add(, , objMessage.FromAddress)
        lList.Tag = objMessage.ImapUID
        
        lList.SubItems(1) = objMessage.Date
        lList.SubItems(2) = objMessage.Subject
    
        Set objMessage = objImap.FetchNextEmailHeader
    Wend
       
    MousePointer = vbDefault
    
    GetResult
    EnableControls
    
End Sub


Private Sub buttonSave_Click()
  
    If listMessages.SelectedItem Is Nothing Then Return
    
    nUid = listMessages.SelectedItem.Tag
    sSearch = objConstants.IMAP_SK_UID & " " & nUid
    
    Set objMessage = objImap.FetchFirstEmail(sSearch)
    If GetResult() <> 0 Then Return

    CommonDialog1.CancelError = True
    CommonDialog1.InitDir = "C:\"
    CommonDialog1.FileName = objMessage.Subject & ".mime"
    
    On Error GoTo lblCancel
    CommonDialog1.ShowSave
        
    sFileName = CommonDialog1.FileName
    objMessage.SaveMIME sFileName
    
lblCancel:
  
End Sub

Private Sub buttonView_Click()
    If FileExists(textLogfile.Text) = True Then
        Shell "notepad " + textLogfile.Text, vbNormalFocus
    End If
End Sub

Public Function FileExists(sFileName As String) As Boolean
  FileExists = CBool(Len(Dir$(sFileName))) And CBool(Len(sFileName))
End Function

Private Sub Form_Load()
    
    Set objImap = CreateObject("AxEmail.Imap")
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

    objImap.Clear
    objImap.LogFile = textLogfile.Text
    
    ' Set Secure if secure communications is required
    objImap.Secure = checkSecure.Value
    objImap.HostPort = CInt(textPort.Text)
    
    objImap.Connect textHost.Text, textAccount.Text, textPassword.Text
    If (GetResult() = 0) Then
        EnableControls
        AddMailboxes "", 0, 5
        If cmbMailbox.ListCount > 0 Then
            cmbMailbox.ListIndex = 0
        End If
    End If
            
    MousePointer = vbDefault
End Sub

Private Sub AddMailboxes(sReference As String, nDepth As Integer, nMaxDepth As Integer)
    nDepth = nDepth + 1
    
    objImap.List sReference, "%"
    If objImap.LastError <> 0 Then
        GetResult
        Return
    End If
     
    Set dctListItems = New Dictionary
    nCnt = objImap.ListCount()
    For i = 0 To nCnt - 1
      dctListItems.Add objImap.ListName(i), objImap.ListAttributes(i)
    Next i
    
    sSep = objImap.HierarchySeparator
    For Each sKey In dctListItems.Keys
        sReference = sKey + sSep
        sAttributes = dctListItems(sKey)
        cmbMailbox.AddItem sKey
        If nDepth < nMaxDepth And InStr(1, sAttributes, objConstants.IMAP_MBX_FLAG_HASNOCHILDREN) = 0 Then
            AddMailboxes sReference, nDepth, nMaxDepth
        End If
    Next
End Sub

Private Sub checkSecure_Click()
    If (checkSecure.Value) Then
        textPort = "993"
    Else
        textPort = "143"
    End If
End Sub

Private Sub buttonDisconnect_Click()
    MousePointer = vbHourglass

    objImap.Disconnect
    
    EnableControls
       
    MousePointer = vbDefault
End Sub

Private Sub listMessages_ItemClick(ByVal Item As MSComctlLib.ListItem)
    listAttachments.ListItems.Clear
    
    MousePointer = vbHourglass
    
    nUid = listMessages.SelectedItem.Tag
    sSearch = objConstants.IMAP_SK_UID & " " & nUid
    
    Set objMessage = objImap.FetchFirstEmail(sSearch)
    MousePointer = vbDefault
    
    If GetResult() <> 0 Then Return
                   
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
    
    GetResult
    
End Sub

Private Function GetResult() As Long
    
    Dim lResult As Long
    
    lResult = objImap.LastError                                ' Get Last Error
        
    textResult.Text = objImap.LastError & ": " & objImap.GetErrorDescription(lResult) ' Set Result
    textLastResponse = objImap.LastImapResponse
    
    GetResult = lResult
    
End Function


Private Sub EnableControls()

    Dim bConnected As Boolean

    bConnected = objImap.IsConnected
    
    textPassword.Enabled = Not bConnected
    textAccount.Enabled = Not bConnected
    textHost.Enabled = Not bConnected
    buttonConnect.Enabled = Not bConnected
    buttonDisconnect.Enabled = bConnected
    buttonList.Enabled = bConnected
    buttonDelete.Enabled = bConnected
    buttonSave.Enabled = bConnected
    listMessages.Enabled = bConnected
    textTo.Enabled = bConnected
    textFrom.Enabled = bConnected
    textSubject.Enabled = bConnected
    textBody.Enabled = bConnected
    cmbMailbox.Enabled = bConnected

End Sub


Private Sub LoadSettings()
    textHost = GetSetting("Auron Email Component", "IMAP", "Host", "imap.gmail.com")
    If (GetSetting("Auron Email Component", "IMAP", "Secure", "0") = "0") Then
        checkSecure.Value = 0
    Else
        checkSecure.Value = 1
    End If
    textPort = GetSetting("Auron Email Component", "IMAP", "Port", "993")
    textAccount = GetSetting("Auron Email Component", "IMAP", "Login", "account")
    textPassword = GetSetting("Auron Email Component", "IMAP", "Password", "password")
    
    cmbMailbox.Text = ""
End Sub

Private Sub SaveSettings()
    SaveSetting "Auron Email Component", "IMAP", "Host", textHost.Text
    SaveSetting "Auron Email Component", "IMAP", "Port", textPort.Text
    If (checkSecure.Value) Then
        SaveSetting "Auron Email Component", "IMAP", "Secure", "1"
    Else
        SaveSetting "Auron Email Component", "IMAP", "Secure", "0"
    End If
    SaveSetting "Auron Email Component", "IMAP", "Login", textAccount.Text
    SaveSetting "Auron Email Component", "IMAP", "Password", textPassword.Text
End Sub

Private Function SetDefaultLogFile()

Dim Buffer As String
Buffer = Space(MAX_PATH)

If GetTempPath(MAX_PATH, Buffer) <> 0 Then
    textLogfile.Text = Left$(Buffer, InStr(Buffer, vbNullChar) - 1) & "Imap.log"
Else
    textLogfile.Text = "C:\Imap.log"
End If
End Function
