using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace QuanLyNhaSach_291021.Controller
{
    public static class InjectionSQL
    {
        public static string RemoveInjectionSQL(String sql)
        {
            sql = sql.ToUpper();
            string[] replaceables = new[] {
                "^", "[","]", "\\", "%", "/", "&","?", ";", ":", "!", "-", "+", "$", "\"" ,
                                       "--",
                                      ";--",
                                        "@@",
                                        "CHAR",
                                       "NCHAR",
                                       "VARCHAR",
                                       "NVARCHAR",
                                       "ALTER",
                                       "BEGIN",
                                       "CAST",
                                       "CREATE",
                                       "CURSOR",
                                       "DECLARE",
                                       "DELETE",
                                       "DROP",
                                       "END",
                                       "EXEC",
                                       "UTE",
                                       "FETCH",
                                        "INSERT",
                                        "KILL",
                                        "SYS",
                                        "OBJECTS",
                                        "COLUMNS",
                                        "TABLE",
                                        "UPDATE"
                      };
            string rxString = string.Join("|", replaceables.Select(s => Regex.Escape(s)));
            sql = Regex.Replace(sql, rxString, string.Empty).Trim();
            string[] conditions = { " AND ", " OR " };
            //  string value = "The handsome, energetic, young dog was playing with his smaller, more lethargic litter mate.";
            string[] words_logic = sql.Split(conditions, StringSplitOptions.None);
            String new_sql = "";
            if (words_logic.Length == 1)
            {
                return Regex.Replace(sql, "'", string.Empty);
            }
            else
            {
                string[] separators = { ">", "<", "=", "!" };
                int word_index = 0;

                foreach (var word_conditions in words_logic)
                {
                    if (word_index == 0)
                    {
                        new_sql = Regex.Replace(word_conditions, "'", string.Empty);
                        word_index++;
                    }
                    else
                    {
                        string[] words = word_conditions.Split(separators, StringSplitOptions.None);
                        String w_f = "";
                        string w_e = "";
                        string op = "";
                        if (words.Length == 2)
                        {
                            w_f = words[0].Trim();
                            w_e = words[1].Trim();
                            op = GetTextBetween(word_conditions, w_f, w_e).Trim();
                            if (
                               (op == "=" && w_f == w_e)
                                   ||
                                (op == "!=" && w_f != w_e)
                            )
                            {

                            }
                            else
                            {

                                w_f = words_logic[word_index - 1].ToString().Trim();
                                w_e = words_logic[word_index].ToString().Trim();
                                op = GetTextBetween(sql, w_f, w_e).Trim();
                                new_sql += " " + op + " ";
                                string[] miniwords = word_conditions.Split(new[] { "'" }, StringSplitOptions.RemoveEmptyEntries);
                                if (miniwords.Length <= 2)
                                    new_sql += Regex.Replace(word_conditions, "'", string.Empty).Trim();
                                else
                                {
                                    new_sql += "'" + Regex.Replace(word_conditions, "'", string.Empty).Trim() + "' ";
                                }
                            }

                        }
                        // MessageBox.Show(word.ToString().Trim());
                    }
                }
            }
            return new_sql;
        }

        public static string GetTextBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }
    }
}
