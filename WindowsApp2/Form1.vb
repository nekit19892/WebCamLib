Imports Dynamsoft.DotNet.TWAIN.Enums
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            dynamicDotNetTwain1.SupportedDeviceType = EnumSupportedDeviceType.SDT_WEBCAM
            dynamicDotNetTwain1.SelectSource()
            dynamicDotNetTwain1.IfShowUI = True
            dynamicDotNetTwain1.SetVideoContainer(Me.PictureBox1)
            dynamicDotNetTwain1.OpenSource()
        Catch exp As Exception
            MessageBox.Show(exp.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dynamicDotNetTwain1.IfShowUI = False
        dynamicDotNetTwain1.CloseSource()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
