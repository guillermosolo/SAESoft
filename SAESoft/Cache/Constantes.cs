
namespace SAESoft.Cache
{
    public struct Constantes
    {
        //CONSTANTES DEL MODULO DE IMPORTACIONES

        public const int DigitadorImportaciones = 2;

        public const int EntregaDigitadorMaritimo = 2;
        public const int ElaborarPolizaMaritimo = 3;
        public const int StatusFinalMaritimo = 10;

        public const int SalidaPuertoMaritimo = 5;
        public const int LlegadaFabricaMaritimo = 8;
        public const int SalidaFabricaMaritimo = 9;
        

        public const int EntregaDigitadorAereo = 12;
        public const int ElaborarPolizaAereo = 13;
        public const int StatusFinalAereo = 16;

        public const int EntregaDigitadorTerrestre = 18;
        public const int ElaborarPolizaTerrestre = 19;
        public const int StatusFinalTerrestre = 23;

        public const int CambioETA = 24;
        public const int CambioDestino = 25;
        public const int IngresoMontos = 26;
        public const int Comentario = 27;

        public const string PATH_Import = @"\\192.168.50.37\SAESoft\Import\Soporte";

        public const int SelectivoRojo = 5;

        //FIN CONSTANTES MODULO DE IMPORTACIONES
    }
}
