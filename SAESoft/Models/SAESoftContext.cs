using Microsoft.EntityFrameworkCore;
using SAESoft.Models.Administracion;
using SAESoft.Models.AdministracionSistema;
using SAESoft.Models.Comunes;
using SAESoft.Models.Exportaciones;
using SAESoft.Models.Importaciones;
using SAESoft.Models.Incentivos;
using System.Configuration;

namespace SAESoft.Models
{
    public class SAESoftContext : DbContext
    {
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MSSQL_Test"].ConnectionString);
            //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            //optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Nombre> Nombres { get; set; }
        public DbSet<Moneda> Monedas { get; set; }

        //aqui inician los de IMport
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Aduana> Aduanas { get; set; }
        public DbSet<Terminal> Terminales { get; set; }
        public DbSet<Revision> Revisiones { get; set; }
        public DbSet<Importacion> Importaciones { get; set; }
        public DbSet<Poliza> Polizas { get; set; } 
        public DbSet<BL> BL { get; set; }
        public DbSet<Contenedor> Contenedores { get; set; }
        public DbSet<ImportStatus> ImportStatus { get; set; }
        public DbSet<ImportHistorial> ImportHistorial { get; set; }
        public DbSet<Agente> Agentes { get; set; }
        public DbSet<Pago> Pagos { get; set; }  

        // aqui inician los de Admin
        public DbSet <TipoDocumento> TiposDocumento { get; set; }
        public DbSet <PermisoTrabajo> PermisosTrabajo { get; set; }
        public DbSet <SeguroVehiculo> SegurosVehiculos { get; set; }
        public DbSet <SeguroMedico> SegurosMedicos { get; set; }
        public DbSet <Residencia> Residencias { get; set; }
        public DbSet <Contrato> Contratos { get; set; }
        public DbSet <DepartamentoInterno> DepartamentosInternos { get; set; }
        public DbSet <Empleado> Empleados { get; set; }
        public DbSet<Familiar> Familiares { get; set; }
        public DbSet<AdminStatus> AdminStatuses { get; set; }
        public DbSet<Reclamo> Reclamos { get; set; }
        public DbSet<Tramite> Tramites { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Nombramiento> Nombramientos { get; set; }
        public DbSet<HistorialReclamo> HistorialReclamos { get; set; }
        public DbSet<HistorialTramite> HistorialTramites { get; set; }  

        //Exportaciones

        public DbSet<Licencia> Licencias { get; set; }
        public DbSet<Duca> Ducas { get; set; }
        public DbSet<FacturaExport> FacturasExport { get; set; }
        public DbSet<Descargo> Descargos { get; set; }
        public DbSet<FacturaLocal> FacturasLocal { get; set; }
        public DbSet<ComentFacExport> ComentFacsExport { get; set; }

        //Incentivos
        public DbSet<EvaluacionAsistencia> EvaluacionAsistencia { get; set; }
        public DbSet<PorcentajeEvaluacion> PorcentajeEvaluacion { get; set; }
        public DbSet<PuntajeAsistencia> PuntajeAsistencia { get; set; }
        public DbSet<GrupoDeptoIncentivo> GrupoDeptoIncentivo { get; set; }
        public DbSet<DeptoIncentivo> DeptoIncentivo { get; set; }
        public DbSet<EmpIncentivos> EmpIncentivos { get; set; }
        public DbSet<Asistencia> Asistencia { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }
        public DbSet<EvaluacionDetalle> EvaluacionesDetalle { get; set; }
        public DbSet<Suspension> Suspensiones { get; set; }
        public DbSet<HistIncentivos> HistorialIncentivos { get; set; }  
        public DbSet<Firma> Firmas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddRemoveOneToManyCascadeConvention();

            modelBuilder.ApplyConventions();
        }

    }
}
