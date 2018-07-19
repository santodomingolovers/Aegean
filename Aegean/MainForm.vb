
Imports Newtonsoft.Json.Linq
Imports System.Threading


Public Class Aegean
    Dim xmr_cnt As String = "180"
    Dim uuid As String
    Dim shift_dep As String
    Dim monero_amt As String
    Dim monero_add As String


    Private Sub Xmr_timer_Tick(sender As Object, e As EventArgs) Handles Xmr_timer.Tick
        Try
            If CInt(xmr_cnt) = 0 Then
                Xmr_timer.Stop()
                Label_timeout1.Visible = True
                Label_timeout2.Visible = False
                Label_timeout1.Text = "Time Out"
            Else
                xmr_cnt = xmr_cnt - 1
                Label_timeout2.Visible = True
                Label_countdown.Visible = True
                Label_countdown.Text = xmr_cnt
                Thread.Sleep(1000)
            End If

        Catch ex As Exception
            MsgBox("Error: X1")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextDestination.Text = "" Or TextAmount.Text = "" Or TextReturn.Text = "" Then
            MsgBox("Error: Incorrect Inputs")

        Else

            'XMR.TO

            Try
                Using client_order As New Net.WebClient
                    Dim order_reqp As New Specialized.NameValueCollection From {
                        {"btc_amount", CDbl(TextAmount.Text)},
                        {"btc_dest_address", TextDestination.Text}
                    }

                    shift_dep = TextAmount.Text

                    Dim order_responsebytes = client_order.UploadValues("https://xmr.to/api/v2/xmr2btc/order_create/", "POST", order_reqp)
                    Dim order_responsebody = (New Text.UTF8Encoding).GetString(order_responsebytes)

                    Dim order_jResults As JObject = JObject.Parse(order_responsebody)

                    uuid = order_jResults("uuid").ToString()

                End Using

                Thread.Sleep(3000)

                Using client_query As New Net.WebClient
                    Dim query_reqp As New Specialized.NameValueCollection From {
                        {"uuid", uuid}
                    }
                    Dim query_responsebytes = client_query.UploadValues("https://xmr.to/api/v2/xmr2btc/order_status_query/", "POST", query_reqp)
                    Dim query_responsebody = (New Text.UTF8Encoding).GetString(query_responsebytes)

                    Dim query_jResults As JObject = JObject.Parse(query_responsebody)
                    monero_amt = query_jResults("xmr_amount_total").ToString()
                    monero_add = query_jResults("xmr_receiving_integrated_address").ToString()

                End Using

            Catch ex As Exception
                MsgBox("Error: X2")
            End Try


            Thread.Sleep(2000)

            'Shapeshift

            Using client_shift As New Net.WebClient
                Dim query_reqp As New Specialized.NameValueCollection From {
                    {"amount", CDbl(monero_amt)},
                    {"pair", "btc_xmr"},
                    {"returnAddress", TextReturn.Text},
                    {"withdrawal", monero_add},
                    {"paymentId", ""}
                }
                Dim shift_responsebytes = client_shift.UploadValues("https://www.shapeshift.io/sendamount", "POST", query_reqp)
                Dim shift_responsebody = (New Text.UTF8Encoding).GetString(shift_responsebytes)

                Dim shift_jResults As JObject = JObject.Parse(shift_responsebody)

                Dim results As List(Of JToken) = shift_jResults.Children().ToList()

                For Each item As JProperty In results

                    item.CreateReader()
                    shift_dep = shift_jResults.Item("success").Item("deposit")
                    Label13.Text = shift_jResults.Item("success").Item("deposit")
                    Label15.Visible = True
                    Label13.Visible = True

                    Label14.Text = shift_jResults.Item("success").Item("depositAmount")
                    Label3.Visible = True
                    Label14.Visible = True

                Next

                Xmr_timer.Enabled = True
                Xmr_timer.Start()

            End Using
        End If

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        TextReturn.Text = ""
        TextDestination.Text = ""
        TextAmount.Text = ""
    End Sub

    Private Sub ProxyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProxyToolStripMenuItem.Click
        ProxyConfig.Show()
    End Sub


End Class



