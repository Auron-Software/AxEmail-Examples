'-----------------------------------------------------------------------
' <copyright file="frmSmtpCreateMime.vb" company="Auron">
'     Copyright (c) Auron Software - www.auronsoftware.com
' </copyright>
' <author>Dennis van de Giessen</author>
'-----------------------------------------------------------------------
Imports AxEmail

Public Class frmSmtpCreateMime
    Dim objEmail As AxEmail.Message = New AxEmail.Message
    Dim objConstants As AxEmail.Constants = New AxEmail.Constants
    Public strMIMEFileName As String = String.Empty

    Private Sub frmSmtpCreateMime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strMIMEFileName = String.Empty

        cbxFormat.Items.Clear()
        cbxFormat.Items.Add("Plain Text")
        cbxFormat.Items.Add("HTML")
        cbxFormat.SelectedIndex = 0  ' Plain Text

        cbxPriority.Items.Clear()
        cbxPriority.Items.Add("Highest Priority")
        cbxPriority.Items.Add("High Priority")
        cbxPriority.Items.Add("Normal Priority")
        cbxPriority.Items.Add("Low Priority")
        cbxPriority.Items.Add("Lowest Priority")
        cbxPriority.SelectedIndex = 2 ' Normal Priority

        cbxEncoding.Items.Clear()
        cbxEncoding.Items.Add("Standard")       ' Encoding
        cbxEncoding.Items.Add("UTF8")
        cbxEncoding.SelectedIndex = 0
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim fdlg As System.Windows.Forms.OpenFileDialog

        fdlg = New OpenFileDialog()
        fdlg.Title = "Select Attachment"
        fdlg.InitialDirectory = "C:\\"
        fdlg.Filter = "All files (*.*)|*.*"
        fdlg.FilterIndex = 1
        fdlg.RestoreDirectory = True
        fdlg.Multiselect = True
        If (fdlg.ShowDialog() <> DialogResult.OK) Then
            Return
        End If

        For Each strFile As String In fdlg.FileNames

            If (txtAttachments.Text <> String.Empty) Then
                txtAttachments.Text += "|"
            End If
            txtAttachments.Text += strFile
        Next
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim fdlg As System.Windows.Forms.SaveFileDialog

        objEmail.Clear()

        ' From
        objEmail.FromName = txtFromName.Text
        objEmail.FromAddress = txtFromAddress.Text

        ' Subject
        objEmail.Subject = txtSubject.Text

        ' Priority
        objEmail.Priority = cbxPriority.SelectedIndex + 1

        ' Encoding
        If (cbxEncoding.SelectedIndex = 0) Then
            objEmail.Encoding = objConstants.EMAIL_MESSAGE_ENCODING_DEFAULT
        Else
            objEmail.Encoding = objConstants.EMAIL_MESSAGE_ENCODING_UTF8
        End If

        ' Body
        If (cbxFormat.SelectedIndex = 0) Then
            objEmail.BodyPlainText = txtBody.Text
        Else
            objEmail.BodyHtml = txtBody.Text
        End If

        ' Add TO recipient(s)
        If (txtToAddress.Text <> String.Empty) Then
            objEmail.AddTo(txtToAddress.Text, txtToAddress.Text)
        End If

        ' Add CC recipient(s)
        If (txtCcAddress.Text <> String.Empty And objEmail.LastError = 0) Then
            objEmail.AddCc(txtCcAddress.Text, txtCcAddress.Text)
        End If

        ' Add BCC recipient(s)
        If (txtBccAddress.Text <> String.Empty And objEmail.LastError = 0) Then
            objEmail.AddBcc(txtBccAddress.Text, txtBccAddress.Text)
        End If

        ' Add attachment(s)
        If (objEmail.LastError = 0 And txtAttachments.Text <> String.Empty) Then
            objEmail.AddAttachment(txtAttachments.Text)
        End If


        fdlg = New SaveFileDialog()

        If (objEmail.LastError = 0) Then
            fdlg.Title = "Save"
            fdlg.InitialDirectory = "c:\\"
            fdlg.Filter = "MIME Files (*.mim)|*.mim|All files (*.*)|*.*"
            fdlg.FilterIndex = 1
            fdlg.RestoreDirectory = True
            If (fdlg.ShowDialog() <> DialogResult.OK) Then
                Return
            End If

            objEmail.Encode()
        End If

        ' Save Mime
        If (objEmail.LastError = 0) Then
            strMIMEFileName = fdlg.FileName
            objEmail.SaveMIME(fdlg.FileName)
        End If

        If (objEmail.LastError <> 0) Then
            MessageBox.Show("SaveMIME failed, result: " + objEmail.LastError + " (" + objEmail.GetErrorDescription(objEmail.LastError) + ")")
            Return
        End If

        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub
End Class