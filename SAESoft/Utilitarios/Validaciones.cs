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
            string pattern = @"^(C|M|P|RE|TC|TCA|TCI|TRB|TRA)-\d{3}[A-Z]{0,3}|\bTC-\d{2}[A-Z]{3}\b$";
            return new Regex(pattern, RegexOptions.IgnoreCase);
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

        public static Boolean enteros (Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                return true;
            }
            return false;
        }
    }
}
