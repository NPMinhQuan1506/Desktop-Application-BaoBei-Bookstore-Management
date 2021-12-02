﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach_291021.Controller
{
    class Common
    {
        public string DateTimeToString(DateTime dt)
        {
            return Convert.ToDateTime(dt).ToString("yyyy-MM-dd HH:mm:ss");
        }

        public DateTime StringToDateTime(string s)
        {
            if (s == null || s == "") return DateTime.MinValue;
            return Convert.ToDateTime(s);
        }

        public double DurationBetween2TimeDe(DateTime dtFrom, DateTime dtTo)
        {
            if (dtTo == null || dtFrom == null || dtFrom == DateTime.MinValue || dtTo == DateTime.MinValue) return 0;
            DateTime dt1 = new DateTime(dtFrom.Year, dtFrom.Month, dtFrom.Day, dtFrom.Hour, dtFrom.Minute, 0);
            DateTime dt2 = new DateTime(dtTo.Year, dtTo.Month, dtTo.Day, dtTo.Hour, dtTo.Minute, 0);
            TimeSpan Time = dt2 - dt1;
            return Time.TotalMinutes;
        }

        public string removeUnicode(string strInput)
        {
            string stFormD = strInput.Normalize(System.Text.NormalizationForm.FormD);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string str = "";
            for (int i = 0; i <= stFormD.Length - 1; i++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(stFormD[i]);
                if (uc == UnicodeCategory.NonSpacingMark == false)
                {
                    if (stFormD[i] == 'đ')
                        str = "d";
                    else if (stFormD[i] == 'Đ')
                        str = "D";
                    else
                        str = stFormD[i].ToString();
                    sb.Append(str);
                }
            }
            return sb.ToString();
        }

        public bool checkNumber(string strInput)
        {
            foreach (Char c in strInput)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public byte[] imgToByteConverter(PictureBox pePic)
        {
            MemoryStream stream = new MemoryStream();
            //through the instruction below, we save the
            //image to byte in the object "stream".
            pePic.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);

            //Below is the most important part, actually you are
            //transferring the bytes of the array
            //to the pic which is also of kind byte[]
            byte[] pic = stream.ToArray();
            return pic;
        }

        #region //Code create placeholder Control
        public void createPlaceHolderControl(Control control, string placeholder)
        {
            control.Enter += (sender, e) => control_Enter(sender, e, placeholder);
            control.Leave += (sender, e) => control_Leave(sender, e, placeholder);
        }

        private void control_Enter(object sender, EventArgs e, string placeholder)
        {
            Control controlTemp = (Control)sender;
            controlTemp.ForeColor = Color.FromArgb(0, 0, 20);
        }

        private void control_Leave(object sender, EventArgs e, string placeholder)
        {
            Control controlTemp = (Control)sender;

            if (controlTemp.Text == "" || controlTemp.Text == placeholder)
            {
                controlTemp.ForeColor = Color.FromArgb(144, 142, 144);
            }
        }
        #endregion
    }
}
