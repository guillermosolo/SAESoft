using iText.Kernel.Colors;
using iText.Layout.Borders;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Geom;
using TextAlignment = iText.Layout.Properties.TextAlignment;
using SAESoft.Models.Administracion;
using Border = iText.Layout.Borders.Border;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Utilitarios.ReportUtils;

namespace SAESoft.Administracion
{
    public static class FichaPersonal
    {
        private static int calculaEdad(DateTime fecha)
        {
            int edad = DateTime.Now.Year - fecha.Year; // Calcula la diferencia en años

            // Verifica si aún no se ha cumplido el aniversario de nacimiento este año
            if (fecha.Date > DateTime.Now.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }

        public static String Imprime(Empleado actual, int Id)
        {
            String pathFicha = System.IO.Path.GetTempPath() + "Ficha" + Id.ToString() + ".pdf";
            String? texto, texto2;
            DateTime? fecha;

            if (IsFileOpen(pathFicha))
            {
                throw new Exception("El archivo está abierto. Cierre el archivo y vuelva a intentarlo.");
            }

            PdfWriter writer = new(pathFicha);
            PdfDocument pdfDoc = new(writer);
            Document doc = new(pdfDoc, PageSize.LETTER);

            Table table = new Table(4).UseAllAvailableWidth();

            table.AddCell(celda("Información General", 20, TextAlignment.CENTER, Border.NO_BORDER, 1, 4));

            table.AddCell(celda("Nombres y Apellidos:", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1));
            table.AddCell(celda(actual.Nombres + " " + actual.Apellidos, 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));
            table.AddCell(celda("Nombre Español:", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1));
            table.AddCell(celda(actual.Alias, 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));

            table.AddCell(celda("Nombre Coreano:", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1));
            table.AddCell(celdaCoreana(actual.NombreCoreano, 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));
            table.AddCell(celda("Género:", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1));
            table.AddCell(celda(actual.Genero == "M" ? "MASCULINO" : "FEMENINO", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));

            table.AddCell(celda("Fecha de Nacimiento:", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1));
            table.AddCell(celda(actual.FechaNac.ToShortDateString() + " (" + calculaEdad(actual.FechaNac).ToString() + " AÑOS)", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));
            table.AddCell(celda("Estado Civil:", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1));
            if (actual.Genero == "M")
                table.AddCell(celda(actual.EstadoCivil == "S" ? "SOLTERO" : "CASADO", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));
            else
                table.AddCell(celda(actual.EstadoCivil == "S" ? "SOLTERA" : "CASADA", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));

            table.AddCell(celda("Empresa:", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1));
            table.AddCell(celda(actual.Departamento.Empresa.Descripcion, 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));
            table.AddCell(celda("Departamento:", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1));
            table.AddCell(celda(actual.Departamento.Nombre, 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));

            table.AddCell(celda("Puesto:", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1));
            table.AddCell(celda(actual.Puesto.Descripcion, 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));
            table.AddCell(celda("Fecha de Ingreso:", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1));
            table.AddCell(celda(actual.FechaIngreso.ToShortDateString(), 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));

            table.AddCell(celda("Boleto de Ornato:", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1));
            table.AddCell(celda(actual.BoletoOrnato?"ACTIVO":"VENCIDO", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));
            if (actual.Residencia != null && actual.Residencia.Tipo.Descripcion == "PERMANENTE")
            {
                table.AddCell(celda("Cuota Anual de Extranjería:", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1));
                table.AddCell(celda(actual.CuotaAnual ? "ACTIVA" : "VENCIDA", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));
            }

            doc.Add(table);

            Style encabezado = new Style().SetBackgroundColor(ColorConstants.LIGHT_GRAY).SetTextAlignment(TextAlignment.CENTER).SetBold();

            Table importante = new Table(3).UseAllAvailableWidth();

            importante.AddCell(celda("Documentos Importantes", 20, TextAlignment.CENTER, Border.NO_BORDER, 1, 3));

            importante.AddCell(celda("Documento", 12, TextAlignment.CENTER, new SolidBorder(1), 1, 1).AddStyle(encabezado));
            importante.AddCell(celda("Número", 12, TextAlignment.CENTER, new SolidBorder(1), 1, 1).AddStyle(encabezado));
            importante.AddCell(celda("Vencimiento", 12, TextAlignment.CENTER, new SolidBorder(1), 1, 1).AddStyle(encabezado));

            texto2 = "DPI";
            texto = actual.Documentos?.Where(d => d.IdTipo == 1)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero;
            fecha = actual.Documentos?.Where(d => d.IdTipo == 1)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Vencimiento;
            importante.AddCell(celda(texto2, 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
            importante.AddCell(celda(texto ?? "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
            importante.AddCell(celda(fecha.HasValue ? fecha.Value.ToShortDateString() : "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));

            texto2 = "PASAPORTE";
            texto = actual.Documentos?.Where(d => d.IdTipo == 2)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero;
            fecha = actual.Documentos?.Where(d => d.IdTipo == 2)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Vencimiento;
            importante.AddCell(celda(texto2, 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
            importante.AddCell(celda(texto ?? "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
            importante.AddCell(celda(fecha.HasValue ? fecha.Value.ToShortDateString() : "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));

            texto2 = "IGSS";
            texto = actual.Documentos?.Where(d => d.IdTipo == 3)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero;
            importante.AddCell(celda(texto2, 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
            importante.AddCell(celda(texto ?? "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
            importante.AddCell(celda("NO VENCE", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));

            texto2 = "NIT";
            texto = actual.Documentos?.Where(d => d.IdTipo == 11)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero;
            importante.AddCell(celda(texto2, 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
            importante.AddCell(celda(texto ?? "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
            importante.AddCell(celda("NO VENCE", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));

            doc.Add(importante);

            if (actual.Familiares.Count > 0)
            {
                Table docs = new Table(7).UseAllAvailableWidth();

                docs.AddCell(celda("Pasaporte / DPI Familiares", 20, TextAlignment.CENTER, Border.NO_BORDER, 1, 7));

                docs.AddCell(celda("Nombre", 12, TextAlignment.CENTER, new SolidBorder(1), 2, 1).AddStyle(encabezado));
                docs.AddCell(celda("Parentesco", 12, TextAlignment.CENTER, new SolidBorder(1), 2, 1).AddStyle(encabezado));
                docs.AddCell(celda("Edad", 12, TextAlignment.CENTER, new SolidBorder(1), 2, 1).AddStyle(encabezado));
                docs.AddCell(celda("Pasaporte", 12, TextAlignment.CENTER, new SolidBorder(1), 1, 2).AddStyle(encabezado));
                docs.AddCell(celda("DPI", 12, TextAlignment.CENTER, new SolidBorder(1), 1, 2).AddStyle(encabezado));

                docs.AddCell(celda("Número", 12, TextAlignment.CENTER, new SolidBorder(1), 1, 1).AddStyle(encabezado));
                docs.AddCell(celda("Vencimiento", 12, TextAlignment.CENTER, new SolidBorder(1), 1, 1).AddStyle(encabezado));
                docs.AddCell(celda("Número", 12, TextAlignment.CENTER, new SolidBorder(1), 1, 1).AddStyle(encabezado));
                docs.AddCell(celda("Vencimiento", 12, TextAlignment.CENTER, new SolidBorder(1), 1, 1).AddStyle(encabezado));

                foreach (var familiar in actual.Familiares)
                {
                    docs.AddCell(celda(familiar.Nombres + " " + familiar.Apellidos, 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
                    if (familiar.Parentesco.Descripcion == "HIJO / HIJA")
                        if (familiar.Genero == "M")
                            texto2 = "HIJO";
                        else
                            texto2 = "HIJA";
                    else
                        texto2 = familiar.Parentesco.Descripcion;
                    docs.AddCell(celda(texto2, 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
                    int edad = calculaEdad(familiar.FechaNac);
                    docs.AddCell(celda(edad.ToString(), 10, TextAlignment.RIGHT, new SolidBorder(1), 1, 1));
                    texto = familiar.Documentos?.Where(d => d.IdTipo == 2)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero;
                    fecha = familiar.Documentos?.Where(d => d.IdTipo == 2)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Vencimiento;
                    docs.AddCell(celda(texto ?? "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
                    docs.AddCell(celda(fecha.HasValue ? fecha.Value.ToShortDateString() : "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
                    texto = familiar.Documentos?.Where(d => d.IdTipo == 1)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero;
                    fecha = familiar.Documentos?.Where(d => d.IdTipo == 1)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Vencimiento;
                    docs.AddCell(celda(texto ?? "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
                    docs.AddCell(celda(fecha.HasValue ? fecha.Value.ToShortDateString() : "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
                }

                doc.Add(docs);
            }

            Table res = new Table(6).UseAllAvailableWidth();

            res.AddCell(celda("Residencias y Estatus Migratorio", 20, TextAlignment.CENTER, Border.NO_BORDER, 1, 6));

            res.AddCell(celda("Nombre", 12, TextAlignment.CENTER, new SolidBorder(1), 2, 1).AddStyle(encabezado));
            res.AddCell(celda("Residencia", 12, TextAlignment.CENTER, new SolidBorder(1), 1, 3).AddStyle(encabezado));
            res.AddCell(celda("Estatus Migratorio", 12, TextAlignment.CENTER, new SolidBorder(1), 1, 2).AddStyle(encabezado));

            res.AddCell(celda("Tipo", 12, TextAlignment.CENTER, new SolidBorder(1), 1, 1).AddStyle(encabezado));
            res.AddCell(celda("Resolución", 12, TextAlignment.CENTER, new SolidBorder(1), 1, 1).AddStyle(encabezado));
            res.AddCell(celda("Vencimiento", 12, TextAlignment.CENTER, new SolidBorder(1), 1, 1).AddStyle(encabezado));
            res.AddCell(celda("Número", 12, TextAlignment.CENTER, new SolidBorder(1), 1, 1).AddStyle(encabezado));
            res.AddCell(celda("Vencimiento", 12, TextAlignment.CENTER, new SolidBorder(1), 1, 1).AddStyle(encabezado));

            res.AddCell(celda(actual.Alias, 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
            texto = actual.Residencia?.Tipo.Descripcion;
            texto2 = actual.Residencia?.Resolucion;
            if (texto != "PERMANENTE")
            {
                fecha = actual.Residencia?.Vencimiento;
            }
            else
            {
                fecha = null;
            }
            res.AddCell(celda(texto ?? "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
            res.AddCell(celda(texto2 ?? "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
            res.AddCell(celda(fecha.HasValue ? fecha.Value.ToShortDateString() : "", 12, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
            texto = actual.Documentos?.Where(d => d.IdTipo == 5)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero;
            fecha = actual.Documentos?.Where(d => d.IdTipo == 5)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Vencimiento;
            res.AddCell(celda(texto ?? "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
            res.AddCell(celda(fecha.HasValue ? fecha.Value.ToShortDateString() : "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));

            foreach (var familiar in actual.Familiares)
            {
                res.AddCell(celda(familiar.Nombres + " " + familiar.Apellidos, 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
                texto = familiar.Residencia?.Tipo.Descripcion;
                texto2 = familiar.Residencia?.Resolucion;
                if (texto != "PERMANENTE")
                {
                    fecha = familiar.Residencia?.Vencimiento;
                }
                else
                {
                    fecha = null;
                }
                res.AddCell(celda(texto ?? "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
                res.AddCell(celda(texto2 ?? "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
                res.AddCell(celda(fecha.HasValue ? fecha.Value.ToShortDateString() : "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
                texto = familiar.Documentos?.Where(d => d.IdTipo == 5)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero;
                fecha = familiar.Documentos?.Where(d => d.IdTipo == 5)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Vencimiento;
                res.AddCell(celda(texto ?? "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
                res.AddCell(celda(fecha.HasValue ? fecha.Value.ToShortDateString() : "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
            }

            res.SetKeepTogether(true);
            doc.Add(res);

            Table med = new Table(3).UseAllAvailableWidth();
            med.AddCell(celda("Seguro Médico", 20, TextAlignment.CENTER, Border.NO_BORDER, 1, 3));

            med.AddCell(celda("Nombre", 12, TextAlignment.CENTER, new SolidBorder(1), 1, 1).AddStyle(encabezado));
            med.AddCell(celda("Certificado", 12, TextAlignment.CENTER, new SolidBorder(1), 1, 1).AddStyle(encabezado));
            med.AddCell(celda("Carnet", 12, TextAlignment.CENTER, new SolidBorder(1), 1, 1).AddStyle(encabezado));

            med.AddCell(celda(actual.Alias, 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
            med.AddCell(celda(actual.SeguroMedico?.Certificado ?? "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
            med.AddCell(celda(actual.SeguroMedico?.Carnet ?? "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));

            foreach (var familiar in actual.Familiares)
            {
                med.AddCell(celda(familiar.Nombres + " " + familiar.Apellidos, 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
                med.AddCell(celda(familiar.SeguroMedico?.Certificado ?? "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));
                med.AddCell(celda(familiar.SeguroMedico?.Carnet ?? "", 10, TextAlignment.LEFT, new SolidBorder(1), 1, 1));

            }
            med.SetKeepTogether(true);
            doc.Add(med);

            if (actual.SeguroVehiculo != null)
            {
                Table veh = new Table(4).UseAllAvailableWidth();
                veh.AddCell(celda("Seguro de Vehículo", 20, TextAlignment.CENTER, Border.NO_BORDER, 1, 4));

                veh.AddCell(celda("Descripción:", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1));
                veh.AddCell(celda(actual.SeguroVehiculo.Marca + " " + actual.SeguroVehiculo.Color, 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));
                veh.AddCell(celda("Placas:", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1));
                veh.AddCell(celda(actual.SeguroVehiculo.Placa, 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));

                veh.AddCell(celda("Aseguradora:", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1));
                veh.AddCell(celda(actual.SeguroVehiculo.Aseguradora.Descripcion, 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));
                veh.AddCell(celda("Póliza:", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1));
                veh.AddCell(celda(actual.SeguroVehiculo.Poliza, 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));

                veh.AddCell(celda("Inicio:", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1));
                veh.AddCell(celda(actual.SeguroVehiculo.Inicio.ToShortDateString(), 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));
                veh.AddCell(celda("Vencimiento:", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1));
                veh.AddCell(celda(actual.SeguroVehiculo.Vencimiento.ToShortDateString(), 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));

                veh.AddCell(celda("Total Prima:", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1));
                veh.AddCell(celda(actual.SeguroVehiculo.Prima.ToString("C"), 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));
                veh.AddCell(celda("Deducible:", 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1));
                veh.AddCell(celda(actual.SeguroVehiculo.Deducible.ToString("C"), 12, TextAlignment.LEFT, Border.NO_BORDER, 1, 1, true));

                veh.SetKeepTogether(true);
                doc.Add(veh);
            }
            doc.Close();
            return pathFicha;
        }
    }
}
