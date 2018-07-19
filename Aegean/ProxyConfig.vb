Public Class ProxyConfig



    Private Structure Struct_INTERNET_PROXY_INFO
        Public dwAccessType As Integer
        Public proxy As IntPtr
        Public proxyBypass As IntPtr
    End Structure


    Private Declare Auto Function InternetSetOption Lib "wininet.dll" _
    (ByVal hInternet As IntPtr, ByVal dwOption As Integer, ByVal lpBuffer As IntPtr,
     ByVal lpdwBufferLength As Integer) As Boolean


    Friend Sub RefreshIESettings(ByVal strProxy As String)
        Const INTERNET_OPTION_PROXY As Integer = 38
        Const INTERNET_OPEN_TYPE_PROXY As Integer = 3
        Dim struct_IPI As Struct_INTERNET_PROXY_INFO


        struct_IPI.dwAccessType = INTERNET_OPEN_TYPE_PROXY
        struct_IPI.proxy = System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi(strProxy)
        struct_IPI.proxyBypass = System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi("local")


        Dim intptrStruct As IntPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(System.Runtime.InteropServices.Marshal.SizeOf(struct_IPI))


        System.Runtime.InteropServices.Marshal.StructureToPtr(struct_IPI, intptrStruct, True)
        Dim iReturn As Boolean = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_PROXY, intptrStruct, System.Runtime.InteropServices.Marshal.SizeOf(struct_IPI))
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
                MsgBox("Proxy settings entered incorrectly")
            End If

            If CheckBox1.Checked = True Then
                RefreshIESettings(":")
            End If

        Catch ex As Exception

            RefreshIESettings(TextBox1.Text + "." + TextBox3.Text + "." + TextBox2.Text + "." + TextBox4.Text + ":" + TextBox5.Text)
        End Try

        Me.Hide()


    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False


        Else
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
        End If
    End Sub

    Private Sub ProxyConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "127"
        TextBox3.Text = "0"
        TextBox2.Text = "0"
        TextBox4.Text = "1"
        TextBox5.Text = "9150"

        CheckBox1.Checked = True
    End Sub
End Class