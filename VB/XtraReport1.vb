Imports System
Imports System.Drawing
Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Partial Public Class XtraReport1
	Inherits XtraReport

	Public Sub New()
		InitializeComponent()

		Dim myStyle As XRControlStyle = New XRControlStyle With {
			.Name = "MyStyle1",
			.BackColor = Color.LightBlue,
			.BorderColor = Color.LightGray,
			.Borders = BorderSide.Top,
			.BorderWidth = 2.0F,
			.Font = New Font("Segoe Script", 16),
			.ForeColor = Color.Green,
			.TextAlignment = TextAlignment.TopCenter
		}
		Me.StyleSheet.Add(myStyle)
	End Sub

	Private Sub XrLabel1_BeforePrint(sender As Object, e As ComponentModel.CancelEventArgs) Handles xrLabel1.BeforePrint
		DirectCast(sender, XRLabel).StyleName = "MyStyle1"

	End Sub
	Private Sub XrLabel2_BeforePrint(sender As Object, e As ComponentModel.CancelEventArgs) Handles xrLabel2.BeforePrint
		ApplyAppearanceSettings(DirectCast(sender, XRLabel))
	End Sub

	Private Sub XrLabel4_BeforePrint(sender As Object, e As ComponentModel.CancelEventArgs) Handles xrLabel3.BeforePrint
		ApplyAppearanceSettings(DirectCast(sender, XRLabel))
		ResetStyle(DirectCast(sender, XRLabel))
	End Sub

	' Assign custom appearance settings to a control.
	Private Sub ApplyAppearanceSettings(ByVal label As XRLabel)
		label.BackColor = Color.Orange
		label.BorderColor = Color.DarkGray
		label.Borders = BorderSide.All
		label.BorderWidth = 0.5F
		label.Font = New Font(label.Parent.Font, FontStyle.Bold)
		label.ForeColor = Color.White
		label.TextAlignment = TextAlignment.MiddleRight
	End Sub

	' Reset appearance settings and use the parent control's settings.
	Private Sub ResetStyle(ByVal label As XRLabel)
		label.ResetBackColor()
		label.ResetBorderColor()
		label.ResetBorders()
		label.ResetBorderWidth()
		label.ResetFont()
		label.ResetForeColor()
		label.ResetPadding()
		label.ResetTextAlignment()
	End Sub
End Class
