'#Region "#Usings"
Imports System.Drawing
Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

' ...
'#End Region  ' #Usings
Namespace ResetControlStyle

    Public Partial Class XtraReport1
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

'#Region "#Code"
        Private Sub xrLabel2_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs)
            SetCustomStyle(CType(sender, XRLabel))
        End Sub

        Private Sub xrLabel3_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs)
            SetCustomStyle(CType(sender, XRLabel))
            ResetStyle(CType(sender, XRLabel))
        End Sub

        ' Assign custom appearance settings to a control.
        Private Sub SetCustomStyle(ByVal label As XRLabel)
            label.BackColor = Color.Gray
            label.BorderColor = Color.DarkGray
            label.Borders = BorderSide.All
            label.BorderWidth = 0.5F
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
'#End Region  ' #Code
    End Class
End Namespace
