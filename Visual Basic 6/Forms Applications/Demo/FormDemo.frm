VERSION 5.00
Begin VB.Form FormDemo 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Auron Email Component - Visual Basic 6 Demo "
   ClientHeight    =   3855
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   7395
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3855
   ScaleWidth      =   7395
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton CommandImap 
      Caption         =   "&IMAP Recieve..."
      Height          =   315
      Left            =   150
      TabIndex        =   6
      Top             =   2640
      Width           =   6930
   End
   Begin VB.CommandButton CommandPop3 
      Caption         =   "&POP3 Receive..."
      Height          =   315
      Left            =   150
      TabIndex        =   3
      Top             =   2175
      Width           =   6930
   End
   Begin VB.CommandButton CommandSmtp 
      Caption         =   "&SMTP Send..."
      Height          =   315
      Left            =   150
      TabIndex        =   2
      Top             =   1680
      Width           =   6930
   End
   Begin VB.Label textVersion 
      Caption         =   "<version>"
      Height          =   255
      Left            =   2385
      TabIndex        =   5
      Top             =   3465
      Width           =   4785
   End
   Begin VB.Label Label4 
      Caption         =   "Auron Email Component"
      Height          =   240
      Left            =   180
      TabIndex        =   4
      Top             =   3465
      Width           =   2175
   End
   Begin VB.Line Line4 
      BorderColor     =   &H80000003&
      X1              =   180
      X2              =   7185
      Y1              =   3180
      Y2              =   3180
   End
   Begin VB.Line Line3 
      BorderColor     =   &H80000003&
      X1              =   0
      X2              =   6975
      Y1              =   0
      Y2              =   0
   End
   Begin VB.Line Line2 
      BorderColor     =   &H80000003&
      X1              =   0
      X2              =   6975
      Y1              =   0
      Y2              =   0
   End
   Begin VB.Line Line1 
      BorderColor     =   &H80000003&
      X1              =   150
      X2              =   7125
      Y1              =   1425
      Y2              =   1425
   End
   Begin VB.Label Label2 
      Caption         =   $"FormDemo.frx":0000
      Height          =   660
      Left            =   135
      TabIndex        =   1
      Top             =   615
      Width           =   6885
   End
   Begin VB.Label Label1 
      Caption         =   "Auron Email Component provides an easy-to-use programming interface to SMTP- IMAP- and POP3 e-mail messaging."
      Height          =   435
      Left            =   150
      TabIndex        =   0
      Top             =   120
      Width           =   7065
   End
End
Attribute VB_Name = "FormDemo"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub CommandImap_Click()
    FormImap.Show
End Sub

Private Sub CommandPop3_Click()
    FormPop3.Show
End Sub

Private Sub CommandSmtp_Click()
    FormSmtp.Show
End Sub

Private Sub Form_Load()
Dim o

Set o = CreateObject("AxEmail.Smtp")
textVersion = o.Version & "; Build " & o.Build & "; Module " & o.Module
End Sub
