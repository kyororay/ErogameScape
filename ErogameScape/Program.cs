using System;
using System.Windows.Forms;

namespace ByteSwapper
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                if (Clipboard.ContainsText())
                {
                    var text = Clipboard.GetText();
                    if (!string.IsNullOrEmpty(text))
                    {
                        //日付
                        text = text.Replace("(月)", "");
                        text = text.Replace("(火)", "");
                        text = text.Replace("(水)", "");
                        text = text.Replace("(木)", "");
                        text = text.Replace("(金)", "");
                        text = text.Replace("(土)", "");
                        text = text.Replace("(日)", "");

                        //ゲーム名
                        text = text.Replace("(非18禁)", "\t非18禁");
                        text = text.Replace("(不完全版)", "\t不完全版");
                        text = text.Replace("(3DS)", "\t3DS");
                        text = text.Replace("(NDS)", "\tNDS");
                        text = text.Replace("(NS)", "\tNS");
                        text = text.Replace("(NS2)", "\tNS2");
                        text = text.Replace("(PS2)", "\tPS2");
                        text = text.Replace("(PS3)", "\tPS3");
                        text = text.Replace("(PS4)", "\tPS4");
                        text = text.Replace("(PS5)", "\tPS5");
                        text = text.Replace("(XSX)", "\tXSX");
                        text = text.Replace("(XB360)", "\tXB360");
                        text = text.Replace("(XBO)", "\tXBO");
                        text = text.Replace("(PSP)", "\tPSP");
                        text = text.Replace("(PSV)", "\tPSV");
                        text = text.Replace("(Wii)", "\tWii");
                        text = text.Replace("(Wii U)", "\tWii U");
                        text = text.Replace("(BROWSER)", "\tBROWSER");
                        text = text.Replace("(iOS)", "\tiOS");
                        text = text.Replace("(MOBILE)", "\tMOBILE");
                        text = text.Replace("(Android)", "\tAndroid");
                        text = text.Replace("(iPhone)", "\tiPhone");

                        //ブランド名
                        text = text.Replace("(解散)", "");
                        text = text.Replace("(同人)", "\t同人");

                        Clipboard.SetText(text);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("<---------- Error message ---------->");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
