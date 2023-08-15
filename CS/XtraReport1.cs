using System;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

public partial class XtraReport1 : XtraReport {
    public XtraReport1() {
        InitializeComponent();

        XRControlStyle myStyle = new XRControlStyle {
            Name = "MyStyle1",
            BackColor = Color.LightBlue,
            BorderColor = Color.LightGray,
            Borders = BorderSide.Top,
            BorderWidth = 2f,
            Font = new Font("Segoe Script", 16),
            ForeColor = Color.Green,
            TextAlignment = TextAlignment.TopCenter,

    };
        this.StyleSheet.Add(myStyle);
    }


    private void xrLabel1_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e) {
        ((XRLabel)sender).StyleName = "MyStyle1";

    }
    private void XrLabel2_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e) {
        ApplyAppearanceSettings((XRLabel)sender);
    }

    private void XrLabel3_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e) {
        ApplyAppearanceSettings((XRLabel)sender);
        ResetStyle((XRLabel)sender);
    }

    // Assign custom appearance settings to a control.
    private void ApplyAppearanceSettings(XRLabel label) {
        label.BackColor = Color.Orange;
        label.BorderColor = Color.DarkGray;
        label.Borders = BorderSide.All;
        label.BorderWidth = 0.5f;
        label.Font = new Font(label.Parent.Font, FontStyle.Bold);
        label.ForeColor = Color.White;
        label.TextAlignment = TextAlignment.MiddleRight;
    }

    // Reset appearance settings and use parent control's settings.
    private void ResetStyle(XRLabel label) {
        label.ResetBackColor();
        label.ResetBorderColor();
        label.ResetBorders();
        label.ResetBorderWidth();
        label.ResetFont();
        label.ResetForeColor();
        label.ResetPadding();
        label.ResetTextAlignment();
    }
}
