using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
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

        public static String moneyFormat(String value) {
            double valor = double.Parse(value);
            double _cents = ((double) valor - ((int) valor)) * 100;
            String v_cent = (_cents > 0 ? (_cents > 10 ? _cents + "" : "0" +_cents).Substring(0, 2) : "00");
            String v_real = ("" + value).Substring(0, (value.IndexOf(',') > 0 ? value.IndexOf(',') : value.Length));
            //MessageBox.Show("" + v_cent + "  -  " + value + "  -  " + valor + "  --  " + _cents);
            return v_real + "," + v_cent;
        }

        public static void setMoneyTextBox(TextBox tb, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !(char.IsDigit(e.KeyChar) && (tb.Text.Length > 0 && (tb.Text.IndexOf(',') > 0) ? ((int) tb.Text.IndexOf(',')) + 3 > tb.Text.Length : true)) && (e.KeyChar != ','))
                e.Handled = true;
            //!((sender as TextBox).Text.IndexOf(',') > 0 && ((sender as TextBox).Text.IndexOf(',') >= ((int) (sender as TextBox).Text.Length) + 2))
            // only allow one decimal point
            if ((e.KeyChar == ',') && (tb.Text.IndexOf(',') > -1))
                e.Handled = true;
        }

        public static void setUpperFrist(TextBox tb) {
            if (!tb.Text.Equals(tb.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tb.Text))) {
                tb.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tb.Text);
                tb.SelectionStart = tb.MaxLength - 1;
            }
        }

        public static void setUpperFrist(ComboBox cb) {
            if (!cb.Text.Equals(cb.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cb.Text))) {
                cb.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cb.Text);
                cb.SelectionStart = cb.Text.Length;
            }
        }

        public static void setUpperOnlyFrist(TextBox tb) {
            if (tb.Text.Length > 0)
                if (!tb.Text.Equals(tb.Text.First().ToString().ToUpper() + tb.Text.Substring(1))){
                tb.Text = tb.Text.First().ToString().ToUpper() + tb.Text.Substring(1);
                tb.SelectionStart = tb.Text.Length;
            }
        }

        public static void setUpperOnlyFrist(ComboBox cb) {
            if (cb.Text.Length > 0)
                if (!cb.Text.Equals(cb.Text.First().ToString().ToUpper() + cb.Text.Substring(1))) {
                    cb.Text = cb.Text.First().ToString().ToUpper() + cb.Text.Substring(1);
                    cb.SelectionStart = cb.Text.Length;
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

    abstract class Codes {
        public static int EMPTY_AVALIATION_DATE = -1000;

        public static bool checkValidation() {
            Properties.Settings.Default.Reload();
            return getCode().Equals(Properties.Settings.Default.ACTIVED_CODE);
        }

        public static bool checkValidation(String input) {
            return getCode(input).Equals(getCode());
        }

        public static String getCode(String input) {
            String output = "";
            char [] version = removeDot(input).ToCharArray();
            for (int i = 0; i < version.Length; i++) {
                output += ((char) (((int) version [i]) + 17));
                output += ((int) (version [i] - 48));
            }
            return output;
        }

        public static String getCode(){
            return getCode(Assembly.GetExecutingAssembly().GetName().Version.ToString());
        }

        public static String removeDot(String input) {
            char [] _input = input.ToCharArray();
            String output = "";
            for (int i = 0; i < _input.Length; i++) {
                if (!_input [i].Equals('.'))
                    output += _input [i];
            }
            return output;
        }

        public static int getAvaliableDays() {
            bool timeAvalEmpty = Properties.Settings.Default.AVALIATION_DATE.Equals("");
            DateTime timeAvaliation = (!timeAvalEmpty ? timeAvaliation = DateTime.Parse(Properties.Settings.Default.AVALIATION_DATE) : DateTime.Today), 
                today = DateTime.Today;

            return (timeAvalEmpty ? -1000 : timeAvaliation.DayOfYear - today.DayOfYear);
        }

        public static bool inAvaliationMode() {
            bool timeAvalEmpty = !Properties.Settings.Default.AVALIATION_DATE.Equals("");
            bool codeValiEmpty = !Properties.Settings.Default.ACTIVED_CODE.Equals("");

            return (getAvaliableDays() > 0 && !checkValidation());
        }

        public static bool confirm() {
            if (!checkValidation())
                MessageBox.Show("Não é possivel realizar essa ação em modo de avaliação", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return checkValidation();
        }
    }
}
