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
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2, Me.xrLabel1, Me.xrLabel3})
        Me.Detail.Font = New DevExpress.Drawing.DXFont("Segoe UI", 12.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.Detail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Detail.HeightF = 270.9167!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100.0!)
        Me.Detail.StylePriority.UseBackColor = False
        Me.Detail.StylePriority.UseFont = False
        Me.Detail.StylePriority.UseForeColor = False
        Me.Detail.StylePriority.UsePadding = False
        Me.Detail.StylePriority.UseTextAlignment = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrLabel2
        '
        Me.xrLabel2.BackColor = System.Drawing.Color.Empty
        Me.xrLabel2.BorderColor = System.Drawing.Color.Empty
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 99.66666!)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(630.0!, 75.0!)
        Me.xrLabel2.StylePriority.UseBackColor = False
        Me.xrLabel2.StylePriority.UseBorderColor = False
        Me.xrLabel2.StylePriority.UseBorderDashStyle = False
        Me.xrLabel2.StylePriority.UseBorders = False
        Me.xrLabel2.StylePriority.UseBorderWidth = False
        Me.xrLabel2.StylePriority.UseFont = False
        Me.xrLabel2.StylePriority.UseForeColor = False
        Me.xrLabel2.StylePriority.UsePadding = False
        Me.xrLabel2.StylePriority.UseTextAlignment = False
        Me.xrLabel2.Text = "This label has its appearance settings assigned in code."
        '
        'xrLabel1
        '
        Me.xrLabel1.BackColor = System.Drawing.Color.Empty
        Me.xrLabel1.BorderColor = System.Drawing.Color.Black
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 7.999992!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(629.9999!, 75.0!)
        Me.xrLabel1.StylePriority.UseBackColor = False
        Me.xrLabel1.StylePriority.UseBorderColor = False
        Me.xrLabel1.StylePriority.UseBorderDashStyle = False
        Me.xrLabel1.StylePriority.UseBorders = False
        Me.xrLabel1.StylePriority.UseBorderWidth = False
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.StylePriority.UseForeColor = False
        Me.xrLabel1.StylePriority.UsePadding = False
        Me.xrLabel1.StylePriority.UseTextAlignment = False
        Me.xrLabel1.Text = "This label receives its appearance settings from the MyStyle1 style."
        '
        'xrLabel3
        '
        Me.xrLabel3.BackColor = System.Drawing.Color.Empty
        Me.xrLabel3.BorderColor = System.Drawing.Color.Empty
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 195.9167!)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(629.9998!, 75.0!)
        Me.xrLabel3.Text = "The appearance settings of this label are reset to the parent control (DetailBand" &
    ") settings."
        '
        'topMarginBand1
        '
        Me.topMarginBand1.Name = "topMarginBand1"
        '
        'bottomMarginBand1
        '
        Me.bottomMarginBand1.Name = "bottomMarginBand1"
        '
        'XtraReport1
        '
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.topMarginBand1, Me.bottomMarginBand1})
        Me.Version = "23.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    '#End Region
    Private Detail As DevExpress.XtraReports.UI.DetailBand

    Friend WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel

    Friend WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel

    Friend WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel

    Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

    Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
End Class
