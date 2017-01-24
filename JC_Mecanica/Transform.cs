using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JC_Mecanica {
    abstract class Transform {

        public static String packPhone(String num){
            char [] _num = num.ToCharArray();
            String output = "";
            for (int i = 0; i < _num.Length; i++) {
                if (_num [i].Equals('(') || _num [i].Equals(')') || _num [i].Equals('-') || _num [i].Equals(' ') || !Char.IsNumber(_num [i])) {
                } else {
                    output = output + _num [i];
                }

            }
            return output;
        }

        public static String unPackPhone(String num){ // (32) 3426-1980
            char [] _num = Transform.packPhone(num).ToCharArray();
            String output = "";
            for (int i = 0; i < _num.Length; i++) {
                if (i == 0)
                    output += '(';
                else
                if (i == 2)
                    output += ") ";
                else
                if (_num.Length <= 10 && i == 6)
                    output = output + '-';
                else
                if (_num.Length == 11 && i == 7)
                    output = output + '-';
                    

                output = output + _num [i];
            }
            return output;
        }
        public static String packCPF(String num) {
            char [] _num = num.ToCharArray();
            String output = "";
            for (int i = 0; i < _num.Length; i++) {
                if (_num [i].Equals('.') || _num [i].Equals('-') || !Char.IsNumber(_num[i])) {
                } else {
                    output = output + _num [i];
                }

            }
            return output;
        }

        public static String unPackCPF(String num) { // 123.456.789-00
            char [] _num = Transform.packCPF(num).ToCharArray();
            String output = "";
            for (int i = 0; i < _num.Length; i++) {
                if (i == 3 || i == 6)
                    output = output + '.';
                else
                if (i == 9)
                    output = output + '-';
                output = output + _num [i];
            }
            return output;
        }

        public static bool checkPlaca(String placa){
            char [] p = placa.ToCharArray();

            return !(!Char.IsNumber(p [0]) && !Char.IsNumber(p [1]) && !Char.IsNumber(p [2]) &&
                     Char.IsNumber(p [3]) && Char.IsNumber(p [4]) && Char.IsNumber(p [5]) && Char.IsNumber(p [6]));
            
        }

        public static String upercasePlaca(String placa) {
            char [] _placa = placa.ToCharArray();
            String output = "";
            for (int i = 0; i < _placa.Length; i++) {
                if (!Char.IsNumber(_placa [i])) {
                    //output += String.;
                } else {
                    output += _placa [i];
                }
            }
            return output;
        }

        public static void setUpperFrist(TextBox tb) {
            if (!tb.Text.Equals(tb.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tb.Text))) {
                tb.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tb.Text);
                tb.SelectionStart = tb.MaxLength - 1;
            }
        }

        public static void setUpper(TextBox tb) {
            if (!tb.Text.Equals(tb.Text.ToUpper())) {
                int pos = tb.SelectionStart;
                tb.Text = tb.Text.ToUpper();
                tb.SelectionStart = pos;
            }
        }

        public static void setCpfEdit(TextBox tb) {
            if (tb.Text.ToCharArray().Length > 14 && Transform.packCPF(tb.Text).ToCharArray().Length < 11) {
                tb.Text = "";
            } else {
                tb.Text = Transform.unPackCPF(tb.Text);
                tb.SelectionStart = tb.Text.Length;
            }
        }

        public static void setPhoneEdit(TextBox tb) {
            if (tb.Text.ToCharArray().Length > 14 && Transform.packCPF(tb.Text).ToCharArray().Length < 10) {
                tb.Text = "";
            } else {
                if (!tb.Text.Equals(Transform.unPackPhone(tb.Text))) {
                    tb.Text = Transform.unPackPhone(tb.Text);
                    tb.SelectionStart = tb.Text.Length;
                }
            }
        }

    }
}
