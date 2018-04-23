Imports Microsoft.VisualBasic
Imports System
Namespace ResetControlStyle
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.BackColor = System.Drawing.Color.Silver
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3, Me.xrLabel2, Me.xrLabel1})
			Me.Detail.Font = New System.Drawing.Font("Arial", 12F)
			Me.Detail.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(64))))), (CInt(Fix((CByte(0))))), (CInt(Fix((CByte(128))))))
			Me.Detail.Height = 98
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.StylePriority.UseBackColor = False
			Me.Detail.StylePriority.UseFont = False
			Me.Detail.StylePriority.UseForeColor = False
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel3
			' 
			Me.xrLabel3.Location = New System.Drawing.Point(433, 8)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.Size = New System.Drawing.Size(208, 75)
			Me.xrLabel3.Text = "This label first uses own apperance property values, and then resets them"
'			Me.xrLabel3.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.xrLabel3_BeforePrint);
			' 
			' xrLabel2
			' 
			Me.xrLabel2.Location = New System.Drawing.Point(217, 8)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.Size = New System.Drawing.Size(208, 75)
			Me.xrLabel2.Text = "This label uses own appearance property values"
'			Me.xrLabel2.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.xrLabel2_BeforePrint);
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Location = New System.Drawing.Point(0, 8)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.Size = New System.Drawing.Size(208, 75)
			Me.xrLabel1.Text = "This label uses its parent's appearance property values"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail})
			Me.Version = "8.3"
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
