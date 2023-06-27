using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using DocumentFormat.OpenXml.Spreadsheet;
using SAESoft.Models.AdministracionSistema;
using System.Globalization;
using System.Text.RegularExpressions;


namespace SAESoft.Utilitarios
{
    public class Validaciones
    {
        public static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        public static Regex plate_validation()
        {
            string pattern = @"^[MP]-\d{3}[A-Z]{3}$$";
            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        public static Boolean NIT_validation(string NIT)
        {
            NIT = NIT.Replace("-", "");
            char verificador = NIT[^1];
            int suma = 0;
            int? numVerificador;
            if (verificador == 'K' || verificador == 'k')
                numVerificador = 10;
            else
                numVerificador = CharUnicodeInfo.GetDigitValue(verificador);
            string invertidos = new(NIT[..^1].Reverse().ToArray());
            for (int i = 0; i < invertidos.Length; i++)
            {
                suma += CharUnicodeInfo.GetDigitValue(invertidos, i) * (i + 2);
            }
            int modulo = suma % 11;
            int total = 11 - modulo;
            total %= 11;

            return total == numVerificador;
        }

        public static Boolean CUI_validation(string CUI)
        {
            CUI = CUI.Replace("-", "").Replace(" ", "");
            int depto = int.Parse(CUI.Substring(9, 2));
            int muni = int.Parse(CUI.Substring(11, 2));
            string numero = CUI[..8];
            int comprobar = int.Parse(CUI.Substring(8, 1));

            int[] munisxDepto = new int[] { 17, 8, 16, 16, 13, 14, 19, 8, 24, 21, 9, 30, 32, 21, 8, 17, 14, 5, 11, 11, 7, 17 };

            if (depto > munisxDepto.Length) { return false; }
            if (muni > munisxDepto[depto - 1]) { return false; }

            int total = 0;
            for (int i=0; i < numero.Length; i++)
            {
                total += CharUnicodeInfo.GetDigitValue(numero,i) * (i + 2);
            }

            int modulo = total % 11;

            return modulo == comprobar;
        }

        public static Boolean decimales(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                return true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                return true;
            }
            return false;
        }

        public static Boolean enteros(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                return true;
            }
            return false;
        }
    }
}
