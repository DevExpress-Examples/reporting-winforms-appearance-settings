using System.Drawing;
using DevExpress.XtraReports.UI;

namespace ResetControlStyle {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void xrLabel2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            SetCustomStyle((XRLabel)sender);
        }

        private void xrLabel3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            SetCustomStyle((XRLabel)sender);
            ResetStyle((XRLabel)sender);
        }

        private void SetCustomStyle(XRLabel label) {
            label.BackColor = Color.Red;
            label.BorderColor = Color.Blue;
            label.Borders = DevExpress.XtraPrinting.BorderSide.All;
            label.BorderWidth = 5;
            label.Font = new Font(label.Font, FontStyle.Bold);
            label.ForeColor = Color.White;
            label.Padding = 10;
            label.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        }

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
}
