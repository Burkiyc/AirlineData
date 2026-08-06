using DevExpress.XtraSplashScreen;

namespace AirlineDataV2;

public partial class DXWinSplashScreenForm1 : SplashScreen {
    public DXWinSplashScreenForm1() {
        InitializeComponent();
        this.labelCopyright.Text = "Copyright © 2025-" + DateTime.Now.Year.ToString();
    }

    #region Overrides

    public override void ProcessCommand(Enum cmd, object arg) {
        base.ProcessCommand(cmd, arg);
    }

    #endregion

    public enum SplashScreenCommand {
    }
}