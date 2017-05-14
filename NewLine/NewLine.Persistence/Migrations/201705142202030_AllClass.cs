namespace NewLine.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdministradorEquipoes",
                c => new
                    {
                        AdministradorEquipoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.AdministradorEquipoId);
            
            CreateTable(
                "dbo.AdministradorLineas",
                c => new
                    {
                        AdministradorLineaId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.AdministradorLineaId);
            
            CreateTable(
                "dbo.CentroAtencions",
                c => new
                    {
                        CentroAtencionId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CentroAtencionId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Contratoes",
                c => new
                    {
                        ContratoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ContratoId);
            
            CreateTable(
                "dbo.Departamentoes",
                c => new
                    {
                        DepartamentoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.DepartamentoId);
            
            CreateTable(
                "dbo.Direccions",
                c => new
                    {
                        DireccionId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.DireccionId);
            
            CreateTable(
                "dbo.Distritoes",
                c => new
                    {
                        DistritoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.DistritoId);
            
            CreateTable(
                "dbo.EquipoCelulars",
                c => new
                    {
                        EquipoCelularId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.EquipoCelularId);
            
            CreateTable(
                "dbo.EstadoEvaluacions",
                c => new
                    {
                        EstadoEvaluacionId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.EstadoEvaluacionId);
            
            CreateTable(
                "dbo.LineaTelefonicas",
                c => new
                    {
                        LineaTelefonicaId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.LineaTelefonicaId);
            
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        PlanId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.PlanId);
            
            CreateTable(
                "dbo.Provincias",
                c => new
                    {
                        ProvinciaId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ProvinciaId);
            
            CreateTable(
                "dbo.TipoEvaluacions",
                c => new
                    {
                        TipoEvaluacionId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoEvaluacionId);
            
            CreateTable(
                "dbo.TipoLineas",
                c => new
                    {
                        TipoLineaId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoLineaId);
            
            CreateTable(
                "dbo.TipoPagoes",
                c => new
                    {
                        TipoPagoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoPagoId);
            
            CreateTable(
                "dbo.TipoPlans",
                c => new
                    {
                        TipoPlanId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoPlanId);
            
            CreateTable(
                "dbo.TipoTrabajadors",
                c => new
                    {
                        TipoTrabajadorId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoTrabajadorId);
            
            CreateTable(
                "dbo.Trabajadors",
                c => new
                    {
                        TrabajadorId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TrabajadorId);
            
            CreateTable(
                "dbo.Ubigeos",
                c => new
                    {
                        UbigeoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.UbigeoId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        VentaId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.VentaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ventas");
            DropTable("dbo.Ubigeos");
            DropTable("dbo.Trabajadors");
            DropTable("dbo.TipoTrabajadors");
            DropTable("dbo.TipoPlans");
            DropTable("dbo.TipoPagoes");
            DropTable("dbo.TipoLineas");
            DropTable("dbo.TipoEvaluacions");
            DropTable("dbo.Provincias");
            DropTable("dbo.Plans");
            DropTable("dbo.LineaTelefonicas");
            DropTable("dbo.EstadoEvaluacions");
            DropTable("dbo.EquipoCelulars");
            DropTable("dbo.Distritoes");
            DropTable("dbo.Direccions");
            DropTable("dbo.Departamentoes");
            DropTable("dbo.Contratoes");
            DropTable("dbo.Clientes");
            DropTable("dbo.CentroAtencions");
            DropTable("dbo.AdministradorLineas");
            DropTable("dbo.AdministradorEquipoes");
        }
    }
}
