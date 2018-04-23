Imports Microsoft.VisualBasic
#Region "#Usings"
Imports System.Drawing
Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
' ...
#End Region ' #Usings

Namespace ResetControlStyle
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

#Region "#Code"
Private Sub xrLabel2_BeforePrint(ByVal sender As Object, _ 
ByVal e As PrintEventArgs) Handles xrLabel2.BeforePrint
	SetCustomStyle(CType(sender, XRLabel))
End Sub

Private Sub xrLabel3_BeforePrint(ByVal sender As Object, _ 
ByVal e As PrintEventArgs) Handles xrLabel3.BeforePrint
	SetCustomStyle(CType(sender, XRLabel))
	ResetStyle(CType(sender, XRLabel))
End Sub

' Assign custom appearance settings to a control.
Private Sub SetCustomStyle(ByVal label As XRLabel)
	label.BackColor = Color.Gray
	label.BorderColor = Color.DarkGray
	label.Borders = BorderSide.All
	label.BorderWidth = 0.5f

	label.Font = New Font(label.Parent.Font, FontStyle.Bold)
	label.ForeColor = Color.White
	label.TextAlignment = TextAlignment.MiddleRight
End Sub

' Restore the appearance settings to their default values.
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
#End Region ' #Code
	End Class
End Namespace
