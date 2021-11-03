using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string removeUnicode(string chuoiInput)
        {
            string stFormD = chuoiInput.Normalize(System.Text.NormalizationForm.FormD);
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

        public bool checkNumber(string chuoiInput)
        {
            foreach (Char c in chuoiInput)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
