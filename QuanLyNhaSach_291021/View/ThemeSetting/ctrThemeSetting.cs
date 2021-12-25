using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyNhaSach_291021.View.Notification;
using System.IO;
using System.Text.RegularExpressions;

namespace QuanLyNhaSach_291021.View.ThemeSetting
{
    public partial class ctrThemeSetting : DevExpress.XtraEditors.XtraUserControl
    {
        #region //Define Class and Variable

        //defind class
        Model.Database conn = new Model.Database();
        Controller.Common func = new Controller.Common();

        //defind variable search and filter

        //defind generate instance   

        private static ctrThemeSetting _instance;

        public static ctrThemeSetting instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ctrThemeSetting();
                }
                return _instance;
            }
        }
        #endregion

        #region //Contructor

        public ctrThemeSetting()
        {
            InitializeComponent();
        }

        #endregion

        private void tgThemeMode_Toggled(object sender, EventArgs e)
        {
            if (tgThemeMode.IsOn == true)
            {
                WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle("Office 2019 Black");
            }
            else
            {
                WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle("Office 2019 White");
            }
        }
    }
}
