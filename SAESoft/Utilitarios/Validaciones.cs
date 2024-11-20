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

            //en este arreglo estan los municipios por departamento, si se creara un municipio más, hay que agregarlo aquí para validar.
            int[] munisxDepto = [17, 8, 16, 16, 13, 14, 19, 8, 24, 21, 9, 30, 32, 21, 8, 17, 14, 5, 11, 11, 7, 17];

            //comprueba primeros digitos del departamento que sean validos (<22)
            if (depto > munisxDepto.Length) { return false; }

            //comprueba digitos de municipio que sean validos según matriz.
            if (muni > munisxDepto[depto - 1]) { return false; }

            int total = 0;
            for (int i=0; i < numero.Length; i++)
            {
                total += CharUnicodeInfo.GetDigitValue(numero,i) * (i + 2);
            }

            int modulo = total % 11;

            return modulo == comprobar;
        }

        public static Boolean decimales(char tecla, string textoActual)
        {
            char decimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            // Permitir los números del 0 al 9, el punto decimal y algunas teclas de control
            if (!char.IsControl(tecla) && !char.IsDigit(tecla) && tecla != decimalSeparator)
            {
                return true; // La entrada no es válida
            }

            // Permitir solo un punto decimal
            if (tecla == decimalSeparator && textoActual.Contains(decimalSeparator))
            {
                return true; // La entrada no es válida
            }

            return false; // La entrada es válida
        }
    

        public static Boolean enteros(char tecla)
        {
            if (!char.IsControl(tecla) && !char.IsDigit(tecla))
            {
                return true;
            }
            return false;
        }

        public static Boolean numerosGuion(char tecla)
        {
            if (!char.IsControl(tecla) && !char.IsDigit(tecla) && tecla != '-')
            {
                return true;
            }
            return false;
        }
    }
}
