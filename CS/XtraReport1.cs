#region #Usings
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
// ...
#endregion #Usings

namespace ResetControlStyle {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

#region #Code
private void xrLabel2_BeforePrint(object sender, PrintEventArgs e) {
    SetCustomStyle((XRLabel)sender);
}

private void xrLabel3_BeforePrint(object sender, PrintEventArgs e) {
    SetCustomStyle((XRLabel)sender);
    ResetStyle((XRLabel)sender);
}

// Assign custom appearance settings to a control.
private void SetCustomStyle(XRLabel label) {
    label.BackColor = Color.Gray;
    label.BorderColor = Color.DarkGray;
    label.Borders = BorderSide.All;
    label.BorderWidth = 0.5f;

    label.Font = new Font(label.Parent.Font, FontStyle.Bold);
    label.ForeColor = Color.White;
    label.TextAlignment = TextAlignment.MiddleRight;
}

// Restore the appearance settings to their default values.
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
#endregion #Code
    }
}
