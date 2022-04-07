Public Class frmOAuth2Settings

  Public Const IDX_AUTHFLOW As Integer = 0
  Public Const IDX_DEVICEFLOW As Integer = 1

  Private Sub frmOAuth2Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    cbxFlow.Items.Add("Authorization Code Flow")
    cbxFlow.Items.Add("Device Code Flow")
    cbxFlow.SelectedIndex = IDX_AUTHFLOW

    txtRedirectUrl.Text = "http://localhost:7999/oauth2test/"
    txtScope.Text = "https://mail.google.com/"
    txtAuthCodeUrl.Text = "https://accounts.google.com/o/oauth2/v2/auth"
    txtDeviceCodeUrl.Text = "https://oauth2.googleapis.com/device/code"
    txtTokenExchangeUrl.Text = "https://oauth2.googleapis.com/token"

    UpdateControls()
  End Sub

  Public Sub UpdateControls()
    Dim nFlow As Integer = cbxFlow.SelectedIndex
    txtRedirectUrl.Enabled = nFlow = IDX_AUTHFLOW
    txtDeviceCodeUrl.Enabled = nFlow = IDX_DEVICEFLOW
    txtAuthCodeUrl.Enabled = nFlow = IDX_AUTHFLOW
  End Sub

  Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
    Close()
  End Sub

  Private Sub cbxFlow_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxFlow.SelectedIndexChanged
    UpdateControls()
  End Sub
End Class