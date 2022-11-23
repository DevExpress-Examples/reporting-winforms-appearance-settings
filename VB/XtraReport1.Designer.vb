Namespace ResetControlStyle

    Partial Class XtraReport1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2, Me.xrLabel1, Me.xrLabel3})
            Me.Detail.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.Detail.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((127)))))), (CInt(((CByte((127)))))), (CInt(((CByte((127)))))))
            Me.Detail.HeightF = 270.9167F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
            Me.Detail.StylePriority.UseBackColor = False
            Me.Detail.StylePriority.UseFont = False
            Me.Detail.StylePriority.UseForeColor = False
            Me.Detail.StylePriority.UsePadding = False
            Me.Detail.StylePriority.UseTextAlignment = False
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.BackColor = System.Drawing.Color.Empty
            Me.xrLabel3.BorderColor = System.Drawing.Color.Empty
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 195.9167F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(629.9998F, 75F)
            Me.xrLabel3.Text = "The appearance settings of this label are restored to their default values."
            AddHandler Me.xrLabel3.BeforePrint, New System.Drawing.Printing.PrintEventHandler(AddressOf Me.xrLabel3_BeforePrint)
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.BackColor = System.Drawing.Color.Empty
            Me.xrLabel2.BorderColor = System.Drawing.Color.Empty
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 99.66666F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(630F, 75F)
            Me.xrLabel2.StylePriority.UseBackColor = False
            Me.xrLabel2.StylePriority.UseBorderColor = False
            Me.xrLabel2.StylePriority.UseBorderDashStyle = False
            Me.xrLabel2.StylePriority.UseBorders = False
            Me.xrLabel2.StylePriority.UseBorderWidth = False
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UseForeColor = False
            Me.xrLabel2.StylePriority.UsePadding = False
            Me.xrLabel2.StylePriority.UseTextAlignment = False
            Me.xrLabel2.Text = "This label carries its personal appearance settings that are assigned in code."
            AddHandler Me.xrLabel2.BeforePrint, New System.Drawing.Printing.PrintEventHandler(AddressOf Me.xrLabel2_BeforePrint)
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.BackColor = System.Drawing.Color.Empty
            Me.xrLabel1.BorderColor = System.Drawing.Color.Black
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 7.999992F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(629.9999F, 75F)
            Me.xrLabel1.StylePriority.UseBackColor = False
            Me.xrLabel1.StylePriority.UseBorderColor = False
            Me.xrLabel1.StylePriority.UseBorderDashStyle = False
            Me.xrLabel1.StylePriority.UseBorders = False
            Me.xrLabel1.StylePriority.UseBorderWidth = False
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.StylePriority.UsePadding = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "This label receives its appearance settings from its parent (the Detail band)."
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' XtraReport1
            ' 
            Me.BackColor = System.Drawing.Color.Gainsboro
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.topMarginBand1, Me.bottomMarginBand1})
            Me.Version = "13.2"
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

'#End Region
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    End Class
End Namespace
