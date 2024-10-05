Public Class fmMain
    Dim ErrorInfo As wclErrorInformation = New wclErrorInformation()

    Private Sub btGetErrorInfo_Click(sender As Object, e As EventArgs) Handles btGetErrorInfo.Click
        lbInfo.Items.Clear()

        Dim Err As Int32
        Dim ErrStr As String = edErrorValue.Text
        If ErrStr.IndexOf("0x") = 0 Then
            Err = Convert.ToInt32(ErrStr, 16)
        Else
            Err = Convert.ToInt32(ErrStr, 10)
        End If

        Dim Path As String
        If cbUseLocalFile.Checked Then
            Path = "..\\..\\..\\..\\errors.xml"
        Else
            Path = "https://www.btframework.com/errors.xml"
        End If

        If ErrorInfo.Open(Path) Then
            Dim Details As wclErrorDetails = New wclErrorDetails()
            If ErrorInfo.GetDetails(Err, Details) Then
                lbInfo.Items.Add("Error code: 0x" + Err.ToString("X8"))
                lbInfo.Items.Add("  Framework: " + Details.Framework)
                lbInfo.Items.Add("  Category: " + Details.Category)
                lbInfo.Items.Add("  Constant: " + Details.Constant)
                lbInfo.Items.Add("  Description: " + Details.Description)
            Else
                lbInfo.Items.Add("Get error details failed")
            End If
            ErrorInfo.Close()
        Else
            MessageBox.Show("wclGetErrorInfo failed")
        End If
    End Sub

    Private Sub fmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Allows to access errors.xml from our site.
        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
    End Sub
End Class
