Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.XtraReports.UI

Namespace ResetControlStyle
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrLabel2_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrLabel2.BeforePrint
			SetCustomStyle(CType(sender, XRLabel))
		End Sub

		Private Sub xrLabel3_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrLabel3.BeforePrint
			SetCustomStyle(CType(sender, XRLabel))
			ResetStyle(CType(sender, XRLabel))
		End Sub

		Private Sub SetCustomStyle(ByVal label As XRLabel)
			label.BackColor = Color.Red
			label.BorderColor = Color.Blue
			label.Borders = DevExpress.XtraPrinting.BorderSide.All
			label.BorderWidth = 5
			label.Font = New Font(label.Font, FontStyle.Bold)
			label.ForeColor = Color.White
			label.Padding = 10
			label.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		End Sub

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
End Namespace
