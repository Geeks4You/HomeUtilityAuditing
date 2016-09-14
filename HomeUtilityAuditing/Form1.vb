Public Class Form1



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Validate the data before continuing
        If ValidateInput() = True Then

            Dim LVItem As New ListViewItem
            lstAppliance.Items.Add(LVItem)
            LVItem.Text = cbappliance.Text
            LVItem.SubItems.Add(txthours.Text)
            ' Call the function that calculate the cost for operating an appliance
            LVItem.SubItems.Add(Calculate())

            lblCost.Text = lblCost.Text + Calculate()
            lblCost.Text = FormatNumber(lblCost.Text, 2)
        End If
    End Sub
    Private Function ValidateInput() As Boolean
        ValidateInput = False

        If cbappliance.Text = "Laundry Washer" Then
            If Not IsNumeric(txtcost.Text) Then
                MessageBox.Show("Please enter a valid numeric value for cost per kW-hour.")
            ElseIf cbappliance.Text = "" Then
                MessageBox.Show("Please select Appliance.")
            ElseIf Not IsNumeric(txtpower.Text) Then
                MessageBox.Show("Please enter a valid numeric value for Power Needed (kW).")
            ElseIf Not IsNumeric(txthours.Text) Then
                MessageBox.Show("Please enter a valid numeric value for No of Hours per Day.")
            ElseIf Not IsNumeric(txtNoGallon.Text) Then
                MessageBox.Show("Please enter a valid numeric value for No of Gallon per Hour.")
            ElseIf Not IsNumeric(txtGallonCost.Text) Then
                MessageBox.Show("Please enter a valid numeric value for Cost per Gallon.")
            Else
                ValidateInput = True
            End If
        Else
            If Not IsNumeric(txtcost.Text) Then
                MessageBox.Show("Please enter a valid numeric value for cost per kW-hour.")
            ElseIf cbappliance.Text = "" Then
                MessageBox.Show("Please select Appliance.")
            ElseIf Not IsNumeric(txtpower.Text) Then
                MessageBox.Show("Please enter a valid numeric value for Power Needed (kW).")
            ElseIf Not IsNumeric(txthours.Text) Then
                MessageBox.Show("Please enter a valid numeric value for No of Hours per Day.")
            Else
                ValidateInput = True
            End If
        End If


    End Function
    Private Function Calculate() As Double
        Dim temp As Double
        Dim temp2 As Double
        'compute the cost, the result will divided to 100 to convert it to dollor

        If cbappliance.Text = "Laundry Washer" Then
            temp = (txtpower.Text * txtcost.Text * txthours.Text) / 100
            temp2 = (txthours.Text * txtNoGallon.Text * txtGallonCost.Text)
            temp = temp + temp2
        Else
            temp = (txtpower.Text * txtcost.Text * txthours.Text) / 100
        End If

        Calculate = temp
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub cbappliance_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbappliance.SelectedIndexChanged
        If Not cbappliance.Text = "Laundry Washer" Then
            Label8.Text = "N/A:"
            Label7.Text = "N/A:"
            txtNoGallon.Enabled = False
            txtGallonCost.Enabled = False
        Else
            Label8.Text = "Cost per Gallon:"
            Label7.Text = "No of Gallon per Hour:"
            txtNoGallon.Enabled = True
            txtGallonCost.Enabled = True
        End If
    End Sub

    Private Sub txthours_TextChanged(sender As Object, e As EventArgs) Handles txthours.TextChanged

        ' Determines if input is number, or if it is a correct value 1 - 24
        If Not IsNumeric(txthours.Text) Or Val(txthours.Text) < 1 Or Val(txthours.Text) > 24 Then
            MessageBox.Show("Please enter a valid numeric value for No of Hours per Day", "Input Error")

            'Selects the whole string as highlighted for deletion when next input is given
            txthours.SelectionStart = 1
            txthours.SelectionLength = txthours.Text.Length

        End If
    End Sub
End Class
