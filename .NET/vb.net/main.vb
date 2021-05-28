Public Class fmMain
    Private Sub btGetErrorInfo_Click(sender As Object, e As EventArgs) Handles btGetErrorInfo.Click
        lbInfo.Items.Clear()

        Dim Err As Int32
        Dim Res As String
        Dim Framework As String = ""
        Dim Category As String = ""
        Dim Constant As String = ""
        Dim Description As String = ""

        Dim ErrStr As String = edErrorValue.Text
        If ErrStr.IndexOf("0x") = 0 Then
            Err = Convert.ToInt32(ErrStr, 16)
        Else
            Err = Convert.ToInt32(ErrStr, 10)
        End If

        If cbUseLocalFile.Checked Then
            Res = wclHelpers.GetErrorInfo("..\..\..\..\errors.xml", Err, Framework, Category, Constant, Description)
        Else
            Res = wclHelpers.GetErrorInfo(Err, Framework, Category, Constant, Description)
        End If

        If Res Then
            lbInfo.Items.Add("Error code: 0x" + Err.ToString("X8"))
            lbInfo.Items.Add("  Framework: " + Framework)
            lbInfo.Items.Add("  Category: " + Category)
            lbInfo.Items.Add("  Constant: " + Constant)
            lbInfo.Items.Add("  Description: " + Description)
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
