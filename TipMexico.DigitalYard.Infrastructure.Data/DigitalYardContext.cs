using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TipMexico.DigitalYard.Domain.Entity.EntityFramework;

namespace TipMexico.DigitalYard.Infrastructure.Data
{
    public partial class DigitalYardContext : DbContext
    {
        public DigitalYardContext()
        {
        }

        public DigitalYardContext(DbContextOptions<DigitalYardContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppFailedJob> AppFailedJobs { get; set; } = null!;
        public virtual DbSet<AppJob> AppJobs { get; set; } = null!;
        public virtual DbSet<CusdyCatUnidadTipo> CusdyCatUnidadTipos { get; set; } = null!;
        public virtual DbSet<CusdyDyWoDetailT> CusdyDyWoDetailTs { get; set; } = null!;
        public virtual DbSet<CusdyDyWoHeaderT> CusdyDyWoHeaderTs { get; set; } = null!;
        public virtual DbSet<XxdyAmTheft1Report> XxdyAmTheft1Reports { get; set; } = null!;
        public virtual DbSet<XxdyAmTheftReport> XxdyAmTheftReports { get; set; } = null!;
        public virtual DbSet<XxdyAmTheftReportH> XxdyAmTheftReportHs { get; set; } = null!;
        public virtual DbSet<XxdyAmVerification> XxdyAmVerifications { get; set; } = null!;
        public virtual DbSet<XxdyAmVerifications1> XxdyAmVerifications1s { get; set; } = null!;
        public virtual DbSet<XxdyAmVerificationsH> XxdyAmVerificationsHes { get; set; } = null!;
        public virtual DbSet<XxdyAppAssignedDoc> XxdyAppAssignedDocs { get; set; } = null!;
        public virtual DbSet<XxdyAppDocument> XxdyAppDocuments { get; set; } = null!;
        public virtual DbSet<XxdyAppDocumentSet> XxdyAppDocumentSets { get; set; } = null!;
        public virtual DbSet<XxdyAppRejectedReason> XxdyAppRejectedReasons { get; set; } = null!;
        public virtual DbSet<XxdyCatCustomersV> XxdyCatCustomersVs { get; set; } = null!;
        public virtual DbSet<XxdyCatItem> XxdyCatItems { get; set; } = null!;
        public virtual DbSet<XxdyCatItemSubstitute> XxdyCatItemSubstitutes { get; set; } = null!;
        public virtual DbSet<XxdyCatItemsInt> XxdyCatItemsInts { get; set; } = null!;
        public virtual DbSet<XxdyCatLicense> XxdyCatLicenses { get; set; } = null!;
        public virtual DbSet<XxdyCatMaterial> XxdyCatMaterials { get; set; } = null!;
        public virtual DbSet<XxdyCatMaterialItem> XxdyCatMaterialItems { get; set; } = null!;
        public virtual DbSet<XxdyCatMiscItem> XxdyCatMiscItems { get; set; } = null!;
        public virtual DbSet<XxdyCatTyre> XxdyCatTyres { get; set; } = null!;
        public virtual DbSet<XxdyCatZone> XxdyCatZones { get; set; } = null!;
        public virtual DbSet<XxdyCatZoneItemsInt> XxdyCatZoneItemsInts { get; set; } = null!;
        public virtual DbSet<XxdyCatZoneItemsIntBk> XxdyCatZoneItemsIntBks { get; set; } = null!;
        public virtual DbSet<XxdyCatZoneMaterial> XxdyCatZoneMaterials { get; set; } = null!;
        public virtual DbSet<XxdyCatZoneType> XxdyCatZoneTypes { get; set; } = null!;
        public virtual DbSet<XxdyConfirmLine> XxdyConfirmLines { get; set; } = null!;
        public virtual DbSet<XxdyCustomerContractsV> XxdyCustomerContractsVs { get; set; } = null!;
        public virtual DbSet<XxdyDaAttachment> XxdyDaAttachments { get; set; } = null!;
        public virtual DbSet<XxdyDaDocument> XxdyDaDocuments { get; set; } = null!;
        public virtual DbSet<XxdyDaDocumentsV> XxdyDaDocumentsVs { get; set; } = null!;
        public virtual DbSet<XxdyDaLog> XxdyDaLogs { get; set; } = null!;
        public virtual DbSet<XxdyDaTransaction> XxdyDaTransactions { get; set; } = null!;
        public virtual DbSet<XxdyDeActivation> XxdyDeActivations { get; set; } = null!;
        public virtual DbSet<XxdyDeAttachment> XxdyDeAttachments { get; set; } = null!;
        public virtual DbSet<XxdyDeBooking> XxdyDeBookings { get; set; } = null!;
        public virtual DbSet<XxdyDeDelivery> XxdyDeDeliveries { get; set; } = null!;
        public virtual DbSet<XxdyDeHeader> XxdyDeHeaders { get; set; } = null!;
        public virtual DbSet<XxdyDeLine> XxdyDeLines { get; set; } = null!;
        public virtual DbSet<XxdyDePass> XxdyDePasses { get; set; } = null!;
        public virtual DbSet<XxdyDeReservation> XxdyDeReservations { get; set; } = null!;
        public virtual DbSet<XxdyDyAvailability> XxdyDyAvailabilities { get; set; } = null!;
        public virtual DbSet<XxdyDyDailyV> XxdyDyDailyVs { get; set; } = null!;
        public virtual DbSet<XxdyDyDelivered> XxdyDyDelivereds { get; set; } = null!;
        public virtual DbSet<XxdyDyDeliveredFlotum> XxdyDyDeliveredFlota { get; set; } = null!;
        public virtual DbSet<XxdyDyPrioritiesV> XxdyDyPrioritiesVs { get; set; } = null!;
        public virtual DbSet<XxdyDyPriority> XxdyDyPriorities { get; set; } = null!;
        public virtual DbSet<XxdyDyProductivity> XxdyDyProductivities { get; set; } = null!;
        public virtual DbSet<XxdyDyProductivityLog> XxdyDyProductivityLogs { get; set; } = null!;
        public virtual DbSet<XxdyDyTeam> XxdyDyTeams { get; set; } = null!;
        public virtual DbSet<XxdyDyTeamsMember> XxdyDyTeamsMembers { get; set; } = null!;
        public virtual DbSet<XxdyErrorLog> XxdyErrorLogs { get; set; } = null!;
        public virtual DbSet<XxdyHrDepartment> XxdyHrDepartments { get; set; } = null!;
        public virtual DbSet<XxdyHrEmployee> XxdyHrEmployees { get; set; } = null!;
        public virtual DbSet<XxdyHrJob> XxdyHrJobs { get; set; } = null!;
        public virtual DbSet<XxdyInsAttachment> XxdyInsAttachments { get; set; } = null!;
        public virtual DbSet<XxdyInsHeader> XxdyInsHeaders { get; set; } = null!;
        public virtual DbSet<XxdyInsLine> XxdyInsLines { get; set; } = null!;
        public virtual DbSet<XxdyInsLocDetail> XxdyInsLocDetails { get; set; } = null!;
        public virtual DbSet<XxdyInsLocation> XxdyInsLocations { get; set; } = null!;
        public virtual DbSet<XxdyInsLog> XxdyInsLogs { get; set; } = null!;
        public virtual DbSet<XxdyMtlOnhand> XxdyMtlOnhands { get; set; } = null!;
        public virtual DbSet<XxdyOdtAttachment> XxdyOdtAttachments { get; set; } = null!;
        public virtual DbSet<XxdyOdtDistribution> XxdyOdtDistributions { get; set; } = null!;
        public virtual DbSet<XxdyOdtHeader> XxdyOdtHeaders { get; set; } = null!;
        public virtual DbSet<XxdyOdtLine> XxdyOdtLines { get; set; } = null!;
        public virtual DbSet<XxdyOdtRcvLine> XxdyOdtRcvLines { get; set; } = null!;
        public virtual DbSet<XxdyOdtReceipt> XxdyOdtReceipts { get; set; } = null!;
        public virtual DbSet<XxdyOdtWorkLoad> XxdyOdtWorkLoads { get; set; } = null!;
        public virtual DbSet<XxdyOdtWorkLog> XxdyOdtWorkLogs { get; set; } = null!;
        public virtual DbSet<XxdyProcessDraft> XxdyProcessDrafts { get; set; } = null!;
        public virtual DbSet<XxdyRebillHeader> XxdyRebillHeaders { get; set; } = null!;
        public virtual DbSet<XxdyRebillLine> XxdyRebillLines { get; set; } = null!;
        public virtual DbSet<XxdyRebillStatus> XxdyRebillStatuses { get; set; } = null!;
        public virtual DbSet<XxdySysBranch> XxdySysBranches { get; set; } = null!;
        public virtual DbSet<XxdySysItem> XxdySysItems { get; set; } = null!;
        public virtual DbSet<XxdySysLegalEntity> XxdySysLegalEntities { get; set; } = null!;
        public virtual DbSet<XxdySysListCode> XxdySysListCodes { get; set; } = null!;
        public virtual DbSet<XxdySysListValue> XxdySysListValues { get; set; } = null!;
        public virtual DbSet<XxdySysMenu> XxdySysMenus { get; set; } = null!;
        public virtual DbSet<XxdySysMenuItem> XxdySysMenuItems { get; set; } = null!;
        public virtual DbSet<XxdySysModule> XxdySysModules { get; set; } = null!;
        public virtual DbSet<XxdySysPage> XxdySysPages { get; set; } = null!;
        public virtual DbSet<XxdySysUser> XxdySysUsers { get; set; } = null!;
        public virtual DbSet<XxdySysUserLog> XxdySysUserLogs { get; set; } = null!;
        public virtual DbSet<XxdySysUserParam> XxdySysUserParams { get; set; } = null!;
        public virtual DbSet<XxtipDyCostItemsV> XxtipDyCostItemsVs { get; set; } = null!;
        public virtual DbSet<XxtipRmaRelContractInt> XxtipRmaRelContractInts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("APPS");

            modelBuilder.Entity<AppFailedJob>(entity =>
            {
                entity.ToTable("APP_FAILED_JOBS", "YARD");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Connection)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("CONNECTION");

                entity.Property(e => e.Exception)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("EXCEPTION");

                entity.Property(e => e.FailedAt)
                    .HasColumnType("DATE")
                    .HasColumnName("FAILED_AT")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.Payload)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("PAYLOAD");

                entity.Property(e => e.Queue)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("QUEUE");
            });

            modelBuilder.Entity<AppJob>(entity =>
            {
                entity.ToTable("APP_JOBS", "YARD");

                entity.HasIndex(e => e.Queue, "APP_JOBS_IDX");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Attempts)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTEMPTS");

                entity.Property(e => e.AvailableAt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AVAILABLE_AT");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_AT");

                entity.Property(e => e.Payload)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("PAYLOAD");

                entity.Property(e => e.Queue)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("QUEUE");

                entity.Property(e => e.ReservedAt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESERVED_AT")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<CusdyCatUnidadTipo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CUSDY_CAT_UNIDAD_TIPO", "YARD");

                entity.Property(e => e.UnidadTipoCod)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("UNIDAD_TIPO_COD");

                entity.Property(e => e.UnidadTipoDsc)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("UNIDAD_TIPO_DSC");

                entity.Property(e => e.UnidadTipoId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("UNIDAD_TIPO_ID");

                entity.Property(e => e.UnidadTipoOrgId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("UNIDAD_TIPO_ORG_ID");
            });

            modelBuilder.Entity<CusdyDyWoDetailT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CUSDY_DY_WO_DETAIL_T", "YARD");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CANTIDAD");

                entity.Property(e => e.CodigoActividad)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_ACTIVIDAD");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.CusdyDyWoHId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUSDY_DY_WO_H_ID");

                entity.Property(e => e.CusdyDyWoLId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUSDY_DY_WO_L_ID");

                entity.Property(e => e.DyappLineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DYAPP_LINE_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.Observaciones)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACIONES");
            });

            modelBuilder.Entity<CusdyDyWoHeaderT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CUSDY_DY_WO_HEADER_T", "YARD");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.CusdyDyWoHId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUSDY_DY_WO_H_ID");

                entity.Property(e => e.Detail)
                    .IsUnicode(false)
                    .HasColumnName("DETAIL");

                entity.Property(e => e.DyappHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DYAPP_HEADER_ID");

                entity.Property(e => e.ItemTypeGeneric)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_TYPE_GENERIC");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.NumUnidad)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NUM_UNIDAD");

                entity.Property(e => e.OtDate)
                    .HasColumnType("DATE")
                    .HasColumnName("OT_DATE");

                entity.Property(e => e.Patio)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PATIO");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("'PENDING'");

                entity.Property(e => e.UnitGeneric)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_GENERIC");

                entity.Property(e => e.WipEntityId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("WIP_ENTITY_ID");

                entity.Property(e => e.WoNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WO_NUMBER");

                entity.Property(e => e.WoType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WO_TYPE");
            });

            modelBuilder.Entity<XxdyAmTheft1Report>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("SYS_C0015535");

                entity.ToTable("XXDY_AM_THEFT1_REPORT", "YARD");

                entity.Property(e => e.ReportId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REPORT_ID");

                entity.Property(e => e.Clase)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("CLASE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EstatusOcra)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("ESTATUS_OCRA")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EstatusPgj)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("ESTATUS_PGJ")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Fabricante)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("FABRICANTE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FechaDeActOcra)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_DE_ACT_OCRA")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FechaDeActPgj)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_DE_ACT_PGJ")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FechaDeAverOcra)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_DE_AVER_OCRA")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FechaDeAverPgj)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_DE_AVER_PGJ")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FechaDeRoboOcra)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_DE_ROBO_OCRA")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FechaDeRoboPgj)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_DE_ROBO_PGJ")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FechaRecuOcra)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_RECU_OCRA")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FechaRecuPgj)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_RECU_PGJ")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.LugarDeRoboOcra)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_DE_ROBO_OCRA")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LugarDeRoboPgj)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_DE_ROBO_PGJ")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LugarRecuOcra)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_RECU_OCRA")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LugarRecuPgj)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_RECU_PGJ")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("MODELO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Submarca)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("SUBMARCA")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ValidadorDelVin)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("VALIDADOR_DEL_VIN")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Vin)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("VIN")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyAmTheftReport>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("SYS_C0013058");

                entity.ToTable("XXDY_AM_THEFT_REPORT", "YARD");

                entity.Property(e => e.ReportId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REPORT_ID");

                entity.Property(e => e.AssetNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_NUMBER");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DocumentPath1)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENT_PATH1");

                entity.Property(e => e.DocumentPath2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENT_PATH2");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ReportPlate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REPORT_PLATE");

                entity.Property(e => e.ReportVin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REPORT_VIN");

                entity.Property(e => e.RequestDate)
                    .HasColumnType("DATE")
                    .HasColumnName("REQUEST_DATE");
            });

            modelBuilder.Entity<XxdyAmTheftReportH>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("SYS_C0013036");

                entity.ToTable("XXDY_AM_THEFT_REPORT_H", "YARD");

                entity.Property(e => e.HistoryId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HISTORY_ID");

                entity.Property(e => e.AssetNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_NUMBER");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DocumentPath1)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENT_PATH1");

                entity.Property(e => e.DocumentPath2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENT_PATH2");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ReportId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REPORT_ID");

                entity.Property(e => e.ReportPlate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REPORT_PLATE");

                entity.Property(e => e.ReportVin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REPORT_VIN");

                entity.Property(e => e.RequestDate)
                    .HasColumnType("DATE")
                    .HasColumnName("REQUEST_DATE");
            });

            modelBuilder.Entity<XxdyAmVerification>(entity =>
            {
                entity.HasKey(e => e.VerifyId)
                    .HasName("SYS_C0013440");

                entity.ToTable("XXDY_AM_VERIFICATIONS", "YARD");

                entity.Property(e => e.VerifyId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("VERIFY_ID");

                entity.Property(e => e.AssetClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_CLASS");

                entity.Property(e => e.AssetNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_NUMBER");

                entity.Property(e => e.AssetStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_STATUS");

                entity.Property(e => e.AssetType)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_TYPE");

                entity.Property(e => e.BranchId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BRANCH_ID");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BRAND_NAME");

                entity.Property(e => e.ClientNameNew)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_NAME_NEW");

                entity.Property(e => e.ClientNameOld)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_NAME_OLD");

                entity.Property(e => e.Comments)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DocumentPath)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENT_PATH");

                entity.Property(e => e.FolioTc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FOLIO_TC");

                entity.Property(e => e.HaveDictamenNew)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HAVE_DICTAMEN_NEW");

                entity.Property(e => e.HaveDictamenOld)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HAVE_DICTAMEN_OLD");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ModelYear)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_YEAR");

                entity.Property(e => e.PlateGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PLATE_GROUP");

                entity.Property(e => e.PlateNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PLATE_NUMBER");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("DATE")
                    .HasColumnName("REGISTER_DATE");

                entity.Property(e => e.ReturnDate)
                    .HasColumnType("DATE")
                    .HasColumnName("RETURN_DATE");

                entity.Property(e => e.TowingCapacity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TOWING_CAPACITY");

                entity.Property(e => e.VerifyDateNew)
                    .HasColumnType("DATE")
                    .HasColumnName("VERIFY_DATE_NEW");

                entity.Property(e => e.VerifyDateOld)
                    .HasColumnType("DATE")
                    .HasColumnName("VERIFY_DATE_OLD");

                entity.Property(e => e.VerifyEntityNew)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("VERIFY_ENTITY_NEW");

                entity.Property(e => e.VerifyEntityOld)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("VERIFY_ENTITY_OLD");

                entity.Property(e => e.VerifyFolioNew)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VERIFY_FOLIO_NEW");

                entity.Property(e => e.VerifyFolioOld)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VERIFY_FOLIO_OLD");

                entity.Property(e => e.Vin)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("VIN");
            });

            modelBuilder.Entity<XxdyAmVerifications1>(entity =>
            {
                entity.HasKey(e => e.VerifyId)
                    .HasName("SYS_C0015537");

                entity.ToTable("XXDY_AM_VERIFICATIONS1", "YARD");

                entity.Property(e => e.VerifyId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("VERIFY_ID");

                entity.Property(e => e.AssetClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_CLASS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.AssetNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.AssetStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.AssetType)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.BranchId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BRANCH_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BRAND_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ClientNameNew)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_NAME_NEW")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ClientNameOld)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_NAME_OLD")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Comments)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DocumentPath)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENT_PATH")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Expiration)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("EXPIRATION")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FechaSalida)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_SALIDA")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FolioTc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FOLIO_TC")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HaveDictamenNew)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HAVE_DICTAMEN_NEW")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HaveDictamenOld)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HAVE_DICTAMEN_OLD")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastArrivalDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_ARRIVAL_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ModelYear)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_YEAR")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PlateGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PLATE_GROUP")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PlateNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PLATE_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("DATE")
                    .HasColumnName("REGISTER_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ReturnDate)
                    .HasColumnType("DATE")
                    .HasColumnName("RETURN_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TowingCapacity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TOWING_CAPACITY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VerifyDateNew)
                    .HasColumnType("DATE")
                    .HasColumnName("VERIFY_DATE_NEW")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VerifyDateOld)
                    .HasColumnType("DATE")
                    .HasColumnName("VERIFY_DATE_OLD")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VerifyEntityNew)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("VERIFY_ENTITY_NEW")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VerifyEntityOld)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("VERIFY_ENTITY_OLD")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VerifyFolioNew)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VERIFY_FOLIO_NEW")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VerifyFolioOld)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VERIFY_FOLIO_OLD")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Vin)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("VIN")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyAmVerificationsH>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("SYS_C0013443");

                entity.ToTable("XXDY_AM_VERIFICATIONS_H", "YARD");

                entity.Property(e => e.HistoryId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HISTORY_ID");

                entity.Property(e => e.AssetClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_CLASS");

                entity.Property(e => e.AssetNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_NUMBER");

                entity.Property(e => e.AssetStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_STATUS");

                entity.Property(e => e.AssetType)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_TYPE");

                entity.Property(e => e.BranchId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BRANCH_ID");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BRAND_NAME");

                entity.Property(e => e.ClientNameNew)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_NAME_NEW");

                entity.Property(e => e.ClientNameOld)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_NAME_OLD");

                entity.Property(e => e.Comments)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DocumentPath)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENT_PATH");

                entity.Property(e => e.FolioTc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FOLIO_TC");

                entity.Property(e => e.HaveDictamenNew)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HAVE_DICTAMEN_NEW");

                entity.Property(e => e.HaveDictamenOld)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HAVE_DICTAMEN_OLD");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ModelYear)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_YEAR");

                entity.Property(e => e.PlateGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PLATE_GROUP");

                entity.Property(e => e.PlateNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PLATE_NUMBER");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("DATE")
                    .HasColumnName("REGISTER_DATE");

                entity.Property(e => e.ReturnDate)
                    .HasColumnType("DATE")
                    .HasColumnName("RETURN_DATE");

                entity.Property(e => e.TowingCapacity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TOWING_CAPACITY");

                entity.Property(e => e.VerifyDateNew)
                    .HasColumnType("DATE")
                    .HasColumnName("VERIFY_DATE_NEW");

                entity.Property(e => e.VerifyDateOld)
                    .HasColumnType("DATE")
                    .HasColumnName("VERIFY_DATE_OLD");

                entity.Property(e => e.VerifyEntityNew)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("VERIFY_ENTITY_NEW");

                entity.Property(e => e.VerifyEntityOld)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("VERIFY_ENTITY_OLD");

                entity.Property(e => e.VerifyFolioNew)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VERIFY_FOLIO_NEW");

                entity.Property(e => e.VerifyFolioOld)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VERIFY_FOLIO_OLD");

                entity.Property(e => e.VerifyId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("VERIFY_ID");

                entity.Property(e => e.Vin)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("VIN");
            });

            modelBuilder.Entity<XxdyAppAssignedDoc>(entity =>
            {
                entity.HasKey(e => e.AssignmentId)
                    .HasName("SYS_C0011187");

                entity.ToTable("XXDY_APP_ASSIGNED_DOCS", "YARD");

                entity.HasIndex(e => new { e.DocumentSetId, e.DocumentId }, "XXDY_APP_ASSIGNED_DOCS_IDX");

                entity.Property(e => e.AssignmentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ASSIGNMENT_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DisplayOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DISPLAY_ORDER");

                entity.Property(e => e.DocumentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DOCUMENT_ID");

                entity.Property(e => e.DocumentSetId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DOCUMENT_SET_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OrgId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORG_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.OriginalDoc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGINAL_DOC")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.RequiredFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REQUIRED_FLAG")
                    .HasDefaultValueSql("'Y' ");
            });

            modelBuilder.Entity<XxdyAppDocument>(entity =>
            {
                entity.HasKey(e => e.DocumentId)
                    .HasName("SYS_C0011162");

                entity.ToTable("XXDY_APP_DOCUMENTS", "YARD");

                entity.HasIndex(e => e.DocumentCode, "XXDY_APP_DOCUMENTS_IDX");

                entity.Property(e => e.DocumentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DOCUMENT_ID");

                entity.Property(e => e.ApproverId)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("APPROVER_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.AttachmentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTACHMENT_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DocumentCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENT_CODE");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENT_NAME");

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENT_TYPE");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.FileExtn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FILE_EXTN");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.NoOfCopies)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NO_OF_COPIES")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.OriginalDoc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGINAL_DOC")
                    .HasDefaultValueSql("'Y'");

                entity.Property(e => e.ViewDeptId)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("VIEW_DEPT_ID")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyAppDocumentSet>(entity =>
            {
                entity.HasKey(e => e.DocumentSetId)
                    .HasName("SYS_C0011181");

                entity.ToTable("XXDY_APP_DOCUMENT_SETS", "YARD");

                entity.Property(e => e.DocumentSetId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DOCUMENT_SET_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DefaultFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.DocumentSetName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENT_SET_NAME");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OrgId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORG_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.SetType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SET_TYPE");
            });

            modelBuilder.Entity<XxdyAppRejectedReason>(entity =>
            {
                entity.HasKey(e => e.ReasonId)
                    .HasName("SYS_C0011192");

                entity.ToTable("XXDY_APP_REJECTED_REASONS", "YARD");

                entity.HasIndex(e => new { e.DocumentId, e.ReasonCode }, "XXDY_APP_REJECTED_REASONS_IDX");

                entity.Property(e => e.ReasonId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REASON_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DisplayOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DISPLAY_ORDER");

                entity.Property(e => e.DocumentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DOCUMENT_ID");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("REASON_CODE")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyCatCustomersV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("XXDY_CAT_CUSTOMERS_V", "YARD");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NAME");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NUMBER");
            });

            modelBuilder.Entity<XxdyCatItem>(entity =>
            {
                entity.HasKey(e => e.SerialNumber)
                    .HasName("SYS_C0011342");

                entity.ToTable("XXDY_CAT_ITEMS", "YARD");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_NAME");

                entity.Property(e => e.ContractId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONTRACT_ID");

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_NUMBER");

                entity.Property(e => e.ContractOrgId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONTRACT_ORG_ID");

                entity.Property(e => e.ContractStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_STATUS");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NAME");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NUMBER");

                entity.Property(e => e.DoorType)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DOOR_TYPE");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_DESCRIPTION");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LicensePlate)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("LICENSE_PLATE");

                entity.Property(e => e.ManufacturerName)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("MANUFACTURER_NAME");

                entity.Property(e => e.ModelYear)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_YEAR");

                entity.Property(e => e.OrganizationName)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ORGANIZATION_NAME");

                entity.Property(e => e.ParentSerial)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_SERIAL");

                entity.Property(e => e.SerialStatus)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_STATUS");

                entity.Property(e => e.Vin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIN");
            });

            modelBuilder.Entity<XxdyCatItemSubstitute>(entity =>
            {
                entity.HasKey(e => e.SubstituteId)
                    .HasName("SYS_C0012954");

                entity.ToTable("XXDY_CAT_ITEM_SUBSTITUTES", "YARD");

                entity.HasIndex(e => new { e.OriginalItemId, e.SubstituteItemId }, "XXDY_CAT_ITEM_SUBSTITUTES_IDX")
                    .IsUnique();

                entity.Property(e => e.SubstituteId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUBSTITUTE_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_DESCRIPTION");

                entity.Property(e => e.ItemSubstitute)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_SUBSTITUTE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OriginalItemId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORIGINAL_ITEM_ID");

                entity.Property(e => e.SubstituteDesc)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("SUBSTITUTE_DESC");

                entity.Property(e => e.SubstituteItemId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUBSTITUTE_ITEM_ID");
            });

            modelBuilder.Entity<XxdyCatItemsInt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("XXDY_CAT_ITEMS_INT", "YARD");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_NAME");

                entity.Property(e => e.ContractId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONTRACT_ID");

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_NUMBER");

                entity.Property(e => e.ContractOrgId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONTRACT_ORG_ID");

                entity.Property(e => e.ContractStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_STATUS");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NAME");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NUMBER");

                entity.Property(e => e.DoorType)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DOOR_TYPE");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_DESCRIPTION");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE\n");

                entity.Property(e => e.LicensePlate)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("LICENSE_PLATE");

                entity.Property(e => e.ManufacturerName)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("MANUFACTURER_NAME");

                entity.Property(e => e.ModelYear)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_YEAR");

                entity.Property(e => e.OrganizationName)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ORGANIZATION_NAME");

                entity.Property(e => e.ParentSerial)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_SERIAL");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER");

                entity.Property(e => e.SerialStatus)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_STATUS");

                entity.Property(e => e.Vin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIN");
            });

            modelBuilder.Entity<XxdyCatLicense>(entity =>
            {
                entity.HasKey(e => e.LicenseId)
                    .HasName("SYS_C0012858");

                entity.ToTable("XXDY_CAT_LICENSES", "YARD");

                entity.Property(e => e.LicenseId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LICENSE_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ExternalOperator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_OPERATOR")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("LAST_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LicImagePath)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("LIC_IMAGE_PATH")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LICENSE_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MIDDLE_NAME")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyCatMaterial>(entity =>
            {
                entity.HasKey(e => e.AssemblyItemId)
                    .HasName("SYS_C0012741");

                entity.ToTable("XXDY_CAT_MATERIALS", "YARD");

                entity.Property(e => e.AssemblyItemId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ASSEMBLY_ITEM_ID");

                entity.Property(e => e.Amount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_DESCRIPTION");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.Miscellaneous)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("MISCELLANEOUS");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.UomCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("UOM_CODE");

                entity.Property(e => e.Workforce)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("WORKFORCE");
            });

            modelBuilder.Entity<XxdyCatMaterialItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("XXDY_CAT_MATERIAL_ITEMS", "YARD");

                entity.HasIndex(e => e.AssemblyItemId, "XXDY_CAT_MATERIAL_ITEMS_IDX");

                entity.Property(e => e.ActivityDescription)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVITY_DESCRIPTION");

                entity.Property(e => e.ActivityName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVITY_NAME");

                entity.Property(e => e.AssemblyItemId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ASSEMBLY_ITEM_ID");

                entity.Property(e => e.ComponentQuantity)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COMPONENT_QUANTITY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.ItemComponent)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_COMPONENT");

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_DESCRIPTION");

                entity.Property(e => e.ItemSequence)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ITEM_SEQUENCE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE\n");

                entity.Property(e => e.OperationSeqNum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OPERATION_SEQ_NUM");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.PrimaryUomCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PRIMARY_UOM_CODE");
            });

            modelBuilder.Entity<XxdyCatMiscItem>(entity =>
            {
                entity.HasKey(e => e.MiscellaneousId)
                    .HasName("SYS_C0012957");

                entity.ToTable("XXDY_CAT_MISC_ITEMS", "YARD");

                entity.HasIndex(e => e.ItemId, "XXDY_CAT_MISC_ITEMS_IDX")
                    .IsUnique();

                entity.HasIndex(e => e.ItemCode, "XXDY_CAT_MISC_ITEMS_IDX1")
                    .IsUnique();

                entity.Property(e => e.MiscellaneousId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MISCELLANEOUS_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_DESCRIPTION");

                entity.Property(e => e.ItemId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ITEM_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<XxdyCatTyre>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("SYS_C0013271");

                entity.ToTable("XXDY_CAT_TYRES", "YARD");

                entity.Property(e => e.LineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Condicion)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CONDICION")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Dot)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DOT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Eco)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ECO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Marca)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("MARCA")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Medidas)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("MEDIDAS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("MODELO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Renovados)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("RENOVADOS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TIPO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Val1321)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("VAL_1_32_1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Val1322)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("VAL_1_32_2")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyCatZone>(entity =>
            {
                entity.HasKey(e => e.ZoneId)
                    .HasName("SYS_C0012681");

                entity.ToTable("XXDY_CAT_ZONES", "YARD");

                entity.Property(e => e.ZoneId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ZONE_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ZoneArea)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ZONE_AREA");

                entity.Property(e => e.ZoneImage)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ZONE_IMAGE");

                entity.Property(e => e.ZoneName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ZONE_NAME");

                entity.Property(e => e.ZoneSubtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ZONE_SUBTYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ZoneType)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ZONE_TYPE");
            });

            modelBuilder.Entity<XxdyCatZoneItemsInt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("XXDY_CAT_ZONE_ITEMS_INT", "YARD");

                entity.Property(e => e.Activity)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVITY");

                entity.Property(e => e.ActivityCode)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVITY_CODE");

                entity.Property(e => e.AssemblyItemId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ASSEMBLY_ITEM_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_DESCRIPTION");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE\n");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Zona)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ZONA");

                entity.Property(e => e.ZoneArea)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ZONE_AREA");

                entity.Property(e => e.ZoneId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ZONE_ID");

                entity.Property(e => e.ZoneType)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ZONE_TYPE");

                entity.Property(e => e.ZoneTypeSection)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ZONE_TYPE_SECTION");
            });

            modelBuilder.Entity<XxdyCatZoneItemsIntBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("XXDY_CAT_ZONE_ITEMS_INT_BK", "YARD");

                entity.Property(e => e.Activity)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVITY");

                entity.Property(e => e.ActivityCode)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVITY_CODE");

                entity.Property(e => e.AssemblyItemId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ASSEMBLY_ITEM_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_DESCRIPTION");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.Zona)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ZONA");

                entity.Property(e => e.ZoneArea)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ZONE_AREA");

                entity.Property(e => e.ZoneId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ZONE_ID");

                entity.Property(e => e.ZoneType)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ZONE_TYPE");

                entity.Property(e => e.ZoneTypeSection)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ZONE_TYPE_SECTION");
            });

            modelBuilder.Entity<XxdyCatZoneMaterial>(entity =>
            {
                entity.HasKey(e => e.DetailId)
                    .HasName("SYS_C0012680");

                entity.ToTable("XXDY_CAT_ZONE_MATERIALS", "YARD");

                entity.Property(e => e.DetailId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DETAIL_ID");

                entity.Property(e => e.AssemblyItemId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ASSEMBLY_ITEM_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ZoneId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ZONE_ID");
            });

            modelBuilder.Entity<XxdyCatZoneType>(entity =>
            {
                entity.HasKey(e => e.ZoneType)
                    .HasName("SYS_C0013201");

                entity.ToTable("XXDY_CAT_ZONE_TYPES", "YARD");

                entity.Property(e => e.ZoneType)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ZONE_TYPE");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<XxdyConfirmLine>(entity =>
            {
                entity.HasKey(e => e.DeLineId)
                    .HasName("SYS_C0014043");

                entity.ToTable("XXDY_CONFIRM_LINES", "YARD");

                entity.Property(e => e.DeLineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DE_LINE_ID");

                entity.Property(e => e.ApiErrorLoc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("API_ERROR_LOC");

                entity.Property(e => e.ApiMensage)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("API_MENSAGE");

                entity.Property(e => e.ApiStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("API_STATUS");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.ParentSerial)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_SERIAL");

                entity.Property(e => e.ProcessDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PROCESS_DATE");

                entity.Property(e => e.ProcessFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROCESS_FLAG");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER");
            });

            modelBuilder.Entity<XxdyCustomerContractsV>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("XXDY_CUSTOMER_CONTRACTS_V", "YARD");

                entity.Property(e => e.ContractId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONTRACT_ID");

                entity.Property(e => e.ContractKnownas)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_KNOWNAS");

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_NUMBER");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NAME");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NUMBER");
            });

            modelBuilder.Entity<XxdyDaAttachment>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("SYS_C0011243");

                entity.ToTable("XXDY_DA_ATTACHMENTS", "YARD");

                entity.Property(e => e.FileId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FILE_ID");

                entity.Property(e => e.AbsoluteName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ABSOLUTE_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ApprovalStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_STATUS")
                    .HasDefaultValueSql("'NEW'");

                entity.Property(e => e.ApprovedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("APPROVED_BY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FileExt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FILE_EXT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FILE_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE\n");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OrgId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORG_ID");

                entity.Property(e => e.RejectMotive)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REJECT_MOTIVE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RejectReason)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REJECT_REASON")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.SourceFolder)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_FOLDER");

                entity.Property(e => e.SourceId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SOURCE_ID");

                entity.Property(e => e.SourceTable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_TABLE");

                entity.Property(e => e.ValidUntil)
                    .HasColumnType("DATE")
                    .HasColumnName("VALID_UNTIL")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyDaDocument>(entity =>
            {
                entity.HasKey(e => e.DaDocumentId)
                    .HasName("SYS_C0011250");

                entity.ToTable("XXDY_DA_DOCUMENTS", "YARD");

                entity.Property(e => e.DaDocumentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DA_DOCUMENT_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEPARTMENT_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DocumentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DOCUMENT_ID");

                entity.Property(e => e.DocumentSetId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DOCUMENT_SET_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FileExtn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FILE_EXTN")
                    .HasDefaultValueSql("'.pdf' ");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE\n");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OrgId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORG_ID");

                entity.Property(e => e.OriginalDoc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGINAL_DOC")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.RequiredFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REQUIRED_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.SourceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_ID");

                entity.Property(e => e.SourceTable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_TABLE");

                entity.Property(e => e.TrxDate)
                    .HasColumnType("DATE")
                    .HasColumnName("TRX_DATE")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyDaDocumentsV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("XXDY_DA_DOCUMENTS_V", "YARD");

                entity.Property(e => e.ApproverId)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("APPROVER_ID");

                entity.Property(e => e.DaDocumentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DA_DOCUMENT_ID");

                entity.Property(e => e.DispFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DISP_FLAG")
                    .IsFixedLength();

                entity.Property(e => e.DocStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOC_STATUS");

                entity.Property(e => e.DocumentDesc)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENT_DESC");

                entity.Property(e => e.DocumentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DOCUMENT_ID");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENT_NAME");

                entity.Property(e => e.DocumentSetId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DOCUMENT_SET_ID");

                entity.Property(e => e.DocumentSetName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENT_SET_NAME");

                entity.Property(e => e.FileExtn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FILE_EXTN");

                entity.Property(e => e.OriginalDoc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGINAL_DOC");

                entity.Property(e => e.RequiredFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REQUIRED_FLAG");

                entity.Property(e => e.SourceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_ID");

                entity.Property(e => e.SourceTable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_TABLE");

                entity.Property(e => e.TotalFiles)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TOTAL_FILES");
            });

            modelBuilder.Entity<XxdyDaLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("SYS_C0012057");

                entity.ToTable("XXDY_DA_LOGS", "YARD");

                entity.Property(e => e.LogId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOG_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DaDocumentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DA_DOCUMENT_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEPARTMENT_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE\n");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OriginalDoc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGINAL_DOC")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER");

                entity.Property(e => e.TrxDate)
                    .HasColumnType("DATE")
                    .HasColumnName("TRX_DATE")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyDaTransaction>(entity =>
            {
                entity.HasKey(e => e.TrxId)
                    .HasName("SYS_C0011850");

                entity.ToTable("XXDY_DA_TRANSACTIONS", "YARD");

                entity.Property(e => e.TrxId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TRX_ID");

                entity.Property(e => e.ApprovalComments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ApprovalDate)
                    .HasColumnType("DATE")
                    .HasColumnName("APPROVAL_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ApprovalStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DaDocumentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DA_DOCUMENT_ID");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE\n");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Motive)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOTIVE");

                entity.Property(e => e.NoReturnFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NO_RETURN_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.OrgId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORG_ID");

                entity.Property(e => e.ReturnComments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RETURN_COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ReturnDate)
                    .HasColumnType("DATE")
                    .HasColumnName("RETURN_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TrxDate)
                    .HasColumnType("DATE")
                    .HasColumnName("TRX_DATE");

                entity.Property(e => e.TrxDays)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TRX_DAYS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TrxType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRX_TYPE");
            });

            modelBuilder.Entity<XxdyDeActivation>(entity =>
            {
                entity.HasKey(e => e.ActivationId)
                    .HasName("SYS_C0014236");

                entity.ToTable("XXDY_DE_ACTIVATIONS", "YARD");

                entity.Property(e => e.ActivationId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACTIVATION_ID");

                entity.Property(e => e.ActivateFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVATE_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.ActivationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACTIVATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.BranchId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BRANCH_ID")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_NUMBER");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NAME");

                entity.Property(e => e.DealType)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DEAL_TYPE");

                entity.Property(e => e.DeliveryId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DELIVERY_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MovementType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOVEMENT_TYPE");

                entity.Property(e => e.ProcessMessage)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PROCESS_MESSAGE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ProcessStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROCESS_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ProgramDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PROGRAM_DATE");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER");

                entity.Property(e => e.TrxType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRX_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Vin)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VIN")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyDeAttachment>(entity =>
            {
                entity.HasKey(e => e.AttachId)
                    .HasName("SYS_C0011034");

                entity.ToTable("XXDY_DE_ATTACHMENTS", "YARD");

                entity.HasIndex(e => e.HeaderId, "XXDY_DE_ATTACHMENTS_IDX");

                entity.Property(e => e.AttachId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTACH_ID");

                entity.Property(e => e.AttachType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTACH_TYPE");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("FILE_PATH");

                entity.Property(e => e.HeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HEADER_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LINE_ID");
            });

            modelBuilder.Entity<XxdyDeBooking>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("SYS_C0013143");

                entity.ToTable("XXDY_DE_BOOKING", "YARD");

                entity.HasIndex(e => e.CheckInId, "XXDY_DE_BOOKING_IDX1")
                    .IsUnique();

                entity.Property(e => e.BookingId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BOOKING_ID");

                entity.Property(e => e.AssetNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_NUMBER");

                entity.Property(e => e.BookStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BOOK_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CheckInDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CHECK_IN_DATE");

                entity.Property(e => e.CheckInId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CHECK_IN_ID");

                entity.Property(e => e.CheckOutDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CHECK_OUT_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CheckOutId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CHECK_OUT_ID")
                    .HasDefaultValueSql("NULL ");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CurrentBranchId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CURRENT_BRANCH_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DeliveryId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DELIVERY_ID")
                    .HasDefaultValueSql("NULL ");

                entity.Property(e => e.InsHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INS_HEADER_ID")
                    .HasDefaultValueSql("NULL ");

                entity.Property(e => e.IntHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INT_HEADER_ID")
                    .HasDefaultValueSql("NULL ");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OtsHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OTS_HEADER_ID")
                    .HasDefaultValueSql("NULL ");

                entity.Property(e => e.OttHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OTT_HEADER_ID")
                    .HasDefaultValueSql("NULL ");

                entity.Property(e => e.PriorityId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRIORITY_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.QasHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("QAS_HEADER_ID")
                    .HasDefaultValueSql("NULL ");

                entity.Property(e => e.QatHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("QAT_HEADER_ID")
                    .HasDefaultValueSql("NULL ");

                entity.Property(e => e.ReserveId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESERVE_ID")
                    .HasDefaultValueSql("NULL ");

                entity.Property(e => e.RtsHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RTS_HEADER_ID")
                    .HasDefaultValueSql("NULL ");

                entity.Property(e => e.RttHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RTT_HEADER_ID")
                    .HasDefaultValueSql("NULL ");

                entity.Property(e => e.StatusDate)
                    .HasColumnType("DATE")
                    .HasColumnName("STATUS_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TCheckOutDate)
                    .HasColumnType("DATE")
                    .HasColumnName("T_CHECK_OUT_DATE")
                    .HasDefaultValueSql("NULL\n");

                entity.Property(e => e.TCheckOutId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("T_CHECK_OUT_ID")
                    .HasDefaultValueSql("NULL ");
            });

            modelBuilder.Entity<XxdyDeDelivery>(entity =>
            {
                entity.HasKey(e => e.DeliveryId)
                    .HasName("SYS_C0012857");

                entity.ToTable("XXDY_DE_DELIVERIES", "YARD");

                entity.Property(e => e.DeliveryId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DELIVERY_ID");

                entity.Property(e => e.ActivationId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACTIVATION_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.BranchId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BRANCH_ID")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.CarrierDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CARRIER_DATE")
                    .HasDefaultValueSql("NULL\n");

                entity.Property(e => e.CarrierName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("CARRIER_NAME")
                    .HasDefaultValueSql("NULL\n");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_NUMBER");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("DATE")
                    .HasColumnName("DELIVERY_DATE")
                    .HasDefaultValueSql("NULL\n");

                entity.Property(e => e.DeliveryStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_STATUS")
                    .HasDefaultValueSql("'Pendiente'");

                entity.Property(e => e.HiFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HI_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.HiHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HI_HEADER_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HillFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HILL_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.HillHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HILL_HEADER_ID")
                    .HasDefaultValueSql("NULL\n");

                entity.Property(e => e.IdSlot)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_SLOT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LegalFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LEGAL_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.LicenseId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LICENSE_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.MovementType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOVEMENT_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PersonInCharge)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("PERSON_IN_CHARGE")
                    .HasDefaultValueSql("'Y'");

                entity.Property(e => e.ProgramDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PROGRAM_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.QualityFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("QUALITY_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.RiskFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RISK_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER");

                entity.Property(e => e.Vin)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VIN");
            });

            modelBuilder.Entity<XxdyDeHeader>(entity =>
            {
                entity.HasKey(e => e.HeaderId)
                    .HasName("SYS_C0011021");

                entity.ToTable("XXDY_DE_HEADERS", "YARD");

                entity.Property(e => e.HeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HEADER_ID");

                entity.Property(e => e.BranchId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BRANCH_ID")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HeaderStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HEADER_STATUS")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LicenseHolder)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LICENSE_HOLDER")
                    .HasDefaultValueSql("NULL\r\n  ");

                entity.Property(e => e.LicenseNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LICENSE_NO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TrxDate)
                    .HasColumnType("DATE")
                    .HasColumnName("TRX_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.TrxType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRX_TYPE");
            });

            modelBuilder.Entity<XxdyDeLine>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("SYS_C0011056");

                entity.ToTable("XXDY_DE_LINES", "YARD");

                entity.Property(e => e.LineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.AssetNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_NUMBER")
                    .HasDefaultValueSql("NULL\n");

                entity.Property(e => e.CancelBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CANCEL_BY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CancelDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CANCEL_DATE")
                    .HasDefaultValueSql("NULL\n  ");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL\r\n  ");

                entity.Property(e => e.ConfirmBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONFIRM_BY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ConfirmDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CONFIRM_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_NUMBER");

                entity.Property(e => e.ContractStatus)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_STATUS");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NAME");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NUMBER");

                entity.Property(e => e.DeliveryId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DELIVERY_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DoorType)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DOOR_TYPE");

                entity.Property(e => e.HeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HEADER_ID");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.ItemFound)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_FOUND")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LineBranchId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LINE_BRANCH_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LineNumber)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LINE_NUMBER");

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LINE_STATUS")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.LineType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LINE_TYPE");

                entity.Property(e => e.ManufacturerName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MANUFACTURER_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PlateNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PLATE_NUMBER");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER");

                entity.Property(e => e.VerifyStatus)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("VERIFY_STATUS");

                entity.Property(e => e.Vin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIN")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WorkshopName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("WORKSHOP_NAME")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyDePass>(entity =>
            {
                entity.HasKey(e => e.PassId)
                    .HasName("SYS_C0013188");

                entity.ToTable("XXDY_DE_PASS", "YARD");

                entity.HasIndex(e => e.CheckOutId, "XXDY_DE_PASS_IDX1")
                    .IsUnique();

                entity.Property(e => e.PassId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PASS_ID");

                entity.Property(e => e.AssetNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_NUMBER");

                entity.Property(e => e.BookingId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BOOKING_ID");

                entity.Property(e => e.CheckInId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CHECK_IN_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CheckOutId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CHECK_OUT_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<XxdyDeReservation>(entity =>
            {
                entity.HasKey(e => e.ReserveId)
                    .HasName("SYS_C0013345");

                entity.ToTable("XXDY_DE_RESERVATIONS", "YARD");

                entity.Property(e => e.ReserveId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESERVE_ID");

                entity.Property(e => e.ActContractNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ACT_CONTRACT_NUMBER");

                entity.Property(e => e.ActCustomerId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACT_CUSTOMER_ID");

                entity.Property(e => e.ActCustomerName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("ACT_CUSTOMER_NAME");

                entity.Property(e => e.BranchId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BRANCH_ID")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.CheckInId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CHECK_IN_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_NUMBER");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NAME");

                entity.Property(e => e.DealType)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DEAL_TYPE");

                entity.Property(e => e.DeliveryId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DELIVERY_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdSlot)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID_SLOT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LegalFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LEGAL_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.MovementType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOVEMENT_TYPE");

                entity.Property(e => e.ProgramDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PROGRAM_DATE");

                entity.Property(e => e.ReserveDate)
                    .HasColumnType("DATE")
                    .HasColumnName("RESERVE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.ReserveStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RESERVE_STATUS")
                    .HasDefaultValueSql("'Disponible'");

                entity.Property(e => e.RiskFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RISK_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.SalesRep)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SALES_REP")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER");

                entity.Property(e => e.TdcFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TDC_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.TheftFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("THEFT_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.VerifyFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VERIFY_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.VppFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VPP_FLAG")
                    .HasDefaultValueSql("'N' ");
            });

            modelBuilder.Entity<XxdyDyAvailability>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("SYS_C0014144");

                entity.ToTable("XXDY_DY_AVAILABILITY", "YARD");

                entity.Property(e => e.LineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.ActivationDate)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVATION_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ActivationMonth)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVATION_MONTH")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.AmountDesc)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("AMOUNT_DESC")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.AssetNumber)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.BaseAmount)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("BASE_AMOUNT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("BRAND_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CirculationCard)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CIRCULATION_CARD")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Comments)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContractName)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCY_CODE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomerEntry)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_ENTRY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DamageAmount)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("DAMAGE_AMOUNT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DealStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("DEAL_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DealType)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("DEAL_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DocStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("DOC_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DoorType)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("DOOR_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ENTRY_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FeetDesc)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("FEET_DESC")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FleetDetail)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("FLEET_DETAIL")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FlowStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("FLOW_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FullAmount)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("FULL_AMOUNT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LegacyRef)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("LEGACY_REF")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ModelName)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.MttoAmount)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("MTTO_AMOUNT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NetBookValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("NET_BOOK_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.OperationType)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("OPERATION_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PayTerm)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("PAY_TERM")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PlateNumber)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("PLATE_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PlateStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("PLATE_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PrevAssetStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("PREV_ASSET_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PrevDeal)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("PREV_DEAL")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ProgramStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.QuoteNumber)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("QUOTE_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RateType)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("RATE_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RebillAmount)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("REBILL_AMOUNT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RebillStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("REBILL_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RentActDate)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("RENT_ACT_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RentRate)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("RENT_RATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ReservedTo)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("RESERVED_TO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RowNumber)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ROW_NUMBER");

                entity.Property(e => e.SalesRep)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("SALES_REP")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StaffStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StaffStatusQ)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_STATUS_Q")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TermType)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("TERM_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VerificationStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("VERIFICATION_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VerifyPeriod)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("VERIFY_PERIOD")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Vin)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("VIN")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Vpp)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("VPP")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VppRate)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("VPP_RATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.YardName)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("YARD_NAME")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyDyDailyV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("XXDY_DY_DAILY_V", "YARD");

                entity.Property(e => e.ClienteE)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE_E");

                entity.Property(e => e.ClienteS)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE_S");

                entity.Property(e => e.ComentarioPrioridad)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COMENTARIO_PRIORIDAD");

                entity.Property(e => e.ContratoE)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CONTRATO_E");

                entity.Property(e => e.ContratoS)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CONTRATO_S");

                entity.Property(e => e.Economico)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ECONOMICO");

                entity.Property(e => e.EstatusActual)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ESTATUS_ACTUAL");

                entity.Property(e => e.EstatusCalidad)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ESTATUS_CALIDAD");

                entity.Property(e => e.EstatusContratoE)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ESTATUS_CONTRATO_E");

                entity.Property(e => e.EstatusContratoS)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ESTATUS_CONTRATO_S");

                entity.Property(e => e.EstatusInspeccion)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ESTATUS_INSPECCION");

                entity.Property(e => e.EstatusOt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ESTATUS_OT");

                entity.Property(e => e.EstatusRt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ESTATUS_RT");

                entity.Property(e => e.Fabricante)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("FABRICANTE");

                entity.Property(e => e.FechaMovimentoE)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_MOVIMENTO_E");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_REGISTRO");

                entity.Property(e => e.FechaSalida)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_SALIDA");

                entity.Property(e => e.FolioE1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FOLIO_E_1");

                entity.Property(e => e.FolioE2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FOLIO_E_2");

                entity.Property(e => e.FolioE3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FOLIO_E_3");

                entity.Property(e => e.FolioS1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FOLIO_S_1")
                    .IsFixedLength();

                entity.Property(e => e.FolioS2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FOLIO_S_2");

                entity.Property(e => e.FolioS3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FOLIO_S_3");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("MODELO");

                entity.Property(e => e.NumeroClienteE)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_CLIENTE_E");

                entity.Property(e => e.NumeroClienteS)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_CLIENTE_S");

                entity.Property(e => e.Patio)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("PATIO");

                entity.Property(e => e.Placa)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PLACA");

                entity.Property(e => e.Prioridad)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRIORIDAD");

                entity.Property(e => e.TipoOperacionE)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_OPERACION_E");

                entity.Property(e => e.TipoOperacionS)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_OPERACION_S");

                entity.Property(e => e.TipoPuerta)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PUERTA");

                entity.Property(e => e.TipoPuertaS)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PUERTA_S");

                entity.Property(e => e.TipoUnidad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_UNIDAD");

                entity.Property(e => e.Vin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIN");
            });

            modelBuilder.Entity<XxdyDyDelivered>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("SYS_C0014138");

                entity.ToTable("XXDY_DY_DELIVERED", "YARD");

                entity.Property(e => e.LineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.ActivationDate)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVATION_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ActivationMonth)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVATION_MONTH")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.AmountDesc)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("AMOUNT_DESC")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.AssetNumber)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.BaseAmount)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("BASE_AMOUNT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("BRAND_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CirculationCard)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CIRCULATION_CARD")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Comments)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ConfirmFlag)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONFIRM_FLAG")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContractName)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCY_CODE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomerEntry)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_ENTRY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DealStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("DEAL_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DealType)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("DEAL_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DocStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("DOC_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DoorType)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("DOOR_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ENTRY_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FeetDesc)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("FEET_DESC")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FleetDetail)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("FLEET_DETAIL")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FlowStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("FLOW_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FullAmount)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("FULL_AMOUNT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LegacyRef)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("LEGACY_REF")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ModelName)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.MttoAmount)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("MTTO_AMOUNT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NetBookValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("NET_BOOK_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.OperationType)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("OPERATION_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PayTerm)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("PAY_TERM")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PlateNumber)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("PLATE_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PlateStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("PLATE_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PrevAssetStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("PREV_ASSET_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PrevDeal)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("PREV_DEAL")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ProgramFlag)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_FLAG")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ProgramStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.QuoteNumber)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("QUOTE_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RateType)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("RATE_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RebillStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("REBILL_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RentActDate)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("RENT_ACT_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RentRate)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("RENT_RATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ReservedTo)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("RESERVED_TO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RowNumber)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ROW_NUMBER");

                entity.Property(e => e.SalesRep)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("SALES_REP")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StaffStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StaffStatusQ)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("STAFF_STATUS_Q")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TermType)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("TERM_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VerificationStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("VERIFICATION_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VerifyPeriod)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("VERIFY_PERIOD")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Vin)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("VIN")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Vpp)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("VPP")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VppRate)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("VPP_RATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.YardName)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("YARD_NAME")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyDyDeliveredFlotum>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("SYS_C0016567");

                entity.ToTable("XXDY_DY_DELIVERED_FLOTA", "YARD");

                entity.Property(e => e.LineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.ArriveDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ARRIVE_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.AssetReturnStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_RETURN_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.AssetStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Calidad)
                    .HasColumnType("DATE")
                    .HasColumnName("CALIDAD")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("COMENTARIO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Customer)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("DATE")
                    .HasColumnName("DELIVERY_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DeliveryTo)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_TO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EcoAnterior)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ECO_ANTERIOR")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EcoPadre)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ECO_PADRE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EcoSistema)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ECO_SISTEMA")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EstatusPatio)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ESTATUS_PATIO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EstatusUnidadPatio)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ESTATUS_UNIDAD_PATIO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FechaVerificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_VERIFICACION")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Flota)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("FLOTA")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE\n");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LINE_STATUS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Marca)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("MARCA")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("MODELO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Period)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("PERIOD")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Placa)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("PLACA")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Puerta)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("PUERTA")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Quality)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("QUALITY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Serie)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("SERIE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("TIPO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VerificationDetail)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("VERIFICATION_DETAIL")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Yard)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("YARD")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyDyPrioritiesV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("XXDY_DY_PRIORITIES_V", "YARD");

                entity.Property(e => e.Amount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NAME");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS");

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_NUMBER");

                entity.Property(e => e.ContractStatus)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_STATUS");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NAME");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NUMBER");

                entity.Property(e => e.DeHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DE_HEADER_ID");

                entity.Property(e => e.DeLineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DE_LINE_ID");

                entity.Property(e => e.InsHeaderIdS)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INS_HEADER_ID_S");

                entity.Property(e => e.InsHeaderIdT)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INS_HEADER_ID_T");

                entity.Property(e => e.InsStatusS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("INS_STATUS_S");

                entity.Property(e => e.InsStatusT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("INS_STATUS_T");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.ItemManufacturerName)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_MANUFACTURER_NAME");

                entity.Property(e => e.LineType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LINE_TYPE");

                entity.Property(e => e.ManufacturerName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MANUFACTURER_NAME");

                entity.Property(e => e.ModelYear)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_YEAR");

                entity.Property(e => e.OdtFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ODT_FLAG");

                entity.Property(e => e.OdtHeaderIdS)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ODT_HEADER_ID_S");

                entity.Property(e => e.OdtHeaderIdT)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ODT_HEADER_ID_T");

                entity.Property(e => e.OdtStatusS)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ODT_STATUS_S");

                entity.Property(e => e.OdtStatusT)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ODT_STATUS_T");

                entity.Property(e => e.OdtTeamIdS)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ODT_TEAM_ID_S");

                entity.Property(e => e.OdtTeamIdT)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ODT_TEAM_ID_T");

                entity.Property(e => e.PlannedHours)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PLANNED_HOURS");

                entity.Property(e => e.PlateNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PLATE_NUMBER");

                entity.Property(e => e.PriorityCode)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRIORITY_CODE");

                entity.Property(e => e.PriorityId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRIORITY_ID");

                entity.Property(e => e.RebillFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REBILL_FLAG");

                entity.Property(e => e.ReserveContract)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("RESERVE_CONTRACT");

                entity.Property(e => e.ReserveCustomer)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("RESERVE_CUSTOMER");

                entity.Property(e => e.ReserveStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RESERVE_STATUS");

                entity.Property(e => e.SalesRep)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SALES_REP");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER");

                entity.Property(e => e.TrxType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRX_TYPE");

                entity.Property(e => e.Vin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIN");

                entity.Property(e => e.WorkshopName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("WORKSHOP_NAME");
            });

            modelBuilder.Entity<XxdyDyPriority>(entity =>
            {
                entity.HasKey(e => e.PriorityId)
                    .HasName("SYS_C0011619");

                entity.ToTable("XXDY_DY_PRIORITIES", "YARD");

                entity.HasIndex(e => e.DeLineId, "XXDY_DY_PRIORITIES_IDX");

                entity.Property(e => e.PriorityId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRIORITY_ID");

                entity.Property(e => e.BranchId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BRANCH_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_NUMBER");

                entity.Property(e => e.ContractStatus)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_STATUS");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NAME");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NUMBER");

                entity.Property(e => e.DeHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DE_HEADER_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DeLineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DE_LINE_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.ItemFound)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_FOUND")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LineBranchId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LINE_BRANCH_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LineType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LINE_TYPE");

                entity.Property(e => e.ManufacturerName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MANUFACTURER_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.OdtFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ODT_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.PlateNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PLATE_NUMBER");

                entity.Property(e => e.PriorityCode)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRIORITY_CODE")
                    .HasDefaultValueSql("99 ");

                entity.Property(e => e.RebillFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REBILL_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER");

                entity.Property(e => e.TrxType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRX_TYPE");

                entity.Property(e => e.Vin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIN")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WorkshopName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("WORKSHOP_NAME")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyDyProductivity>(entity =>
            {
                entity.HasKey(e => e.ProductivityId)
                    .HasName("SYS_C0011866");

                entity.ToTable("XXDY_DY_PRODUCTIVITY", "YARD");

                entity.Property(e => e.ProductivityId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRODUCTIVITY_ID");

                entity.Property(e => e.AusenciaComment)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("AUSENCIA_COMMENT")
                    .HasDefaultValueSql("NULL\n");

                entity.Property(e => e.BranchId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BRANCH_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DLaborados)
                    .HasColumnType("NUMBER")
                    .HasColumnName("D_LABORADOS")
                    .HasDefaultValueSql("5");

                entity.Property(e => e.DNomina)
                    .HasColumnType("NUMBER")
                    .HasColumnName("D_NOMINA")
                    .HasDefaultValueSql("5");

                entity.Property(e => e.DaysComment)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("DAYS_COMMENT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ExtraComment)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("EXTRA_COMMENT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IncapacidadComment)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("INCAPACIDAD_COMMENT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IndirectoComment)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("INDIRECTO_COMMENT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ODays)
                    .HasColumnType("NUMBER")
                    .HasColumnName("O_DAYS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdtyPercent)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PDTY_PERCENT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PeriodId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PERIOD_ID");

                entity.Property(e => e.PersonId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PERSON_ID");

                entity.Property(e => e.TAusencia)
                    .HasColumnType("NUMBER")
                    .HasColumnName("T_AUSENCIA")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TExtra)
                    .HasColumnType("NUMBER")
                    .HasColumnName("T_EXTRA")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TIncapacidad)
                    .HasColumnType("NUMBER")
                    .HasColumnName("T_INCAPACIDAD")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TIndirecto)
                    .HasColumnType("NUMBER")
                    .HasColumnName("T_INDIRECTO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TOdt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("T_ODT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TVacaciones)
                    .HasColumnType("NUMBER")
                    .HasColumnName("T_VACACIONES")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TeamHeadId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TEAM_HEAD_ID");

                entity.Property(e => e.TeamId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TEAM_ID");

                entity.Property(e => e.VacacionesComment)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("VACACIONES_COMMENT")
                    .HasDefaultValueSql("NULL\n");

                entity.Property(e => e.WByPeriod)
                    .HasColumnType("NUMBER")
                    .HasColumnName("W_BY_PERIOD")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WEndDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("W_END_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WStartDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("W_START_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WeekNumber)
                    .HasColumnType("NUMBER")
                    .HasColumnName("WEEK_NUMBER");

                entity.Property(e => e.WeekStatus)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("WEEK_STATUS")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyDyProductivityLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("SYS_C0012395");

                entity.ToTable("XXDY_DY_PRODUCTIVITY_LOGS", "YARD");

                entity.Property(e => e.LogId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOG_ID");

                entity.Property(e => e.BranchId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BRANCH_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Email)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MessageContent)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE_CONTENT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PeriodId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PERIOD_ID");

                entity.Property(e => e.Subject)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("SUBJECT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WeekNumber)
                    .HasColumnType("NUMBER")
                    .HasColumnName("WEEK_NUMBER")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyDyTeam>(entity =>
            {
                entity.HasKey(e => e.TeamId)
                    .HasName("SYS_C0011825");

                entity.ToTable("XXDY_DY_TEAMS", "YARD");

                entity.HasIndex(e => e.TeamName, "SYS_C0011826")
                    .IsUnique();

                entity.Property(e => e.TeamId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TEAM_ID");

                entity.Property(e => e.BranchId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BRANCH_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TeamDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("TEAM_DESCRIPTION")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TeamHead)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TEAM_HEAD");

                entity.Property(e => e.TeamName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TEAM_NAME");

                entity.Property(e => e.TeamType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TEAM_TYPE");
            });

            modelBuilder.Entity<XxdyDyTeamsMember>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("SYS_C0011827");

                entity.ToTable("XXDY_DY_TEAMS_MEMBERS", "YARD");

                entity.HasIndex(e => e.PersonId, "SYS_C0011828")
                    .IsUnique();

                entity.Property(e => e.LineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DLaborados)
                    .HasColumnType("NUMBER")
                    .HasColumnName("D_LABORADOS")
                    .HasDefaultValueSql("5");

                entity.Property(e => e.DNomina)
                    .HasColumnType("NUMBER")
                    .HasColumnName("D_NOMINA")
                    .HasDefaultValueSql("5");

                entity.Property(e => e.HNomina)
                    .HasColumnType("NUMBER")
                    .HasColumnName("H_NOMINA")
                    .HasDefaultValueSql("45");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PersonId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PERSON_ID");

                entity.Property(e => e.TeamId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TEAM_ID")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyErrorLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("XXDY_ERROR_LOG", "YARD");

                entity.Property(e => e.LogDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LOG_DATE")
                    .HasDefaultValueSql("sysdate\n");

                entity.Property(e => e.LogMessage)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOG_MESSAGE");
            });

            modelBuilder.Entity<XxdyHrDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("SYS_C0011143");

                entity.ToTable("XXDY_HR_DEPARTMENTS", "YARD");

                entity.HasIndex(e => new { e.DepartmentCode, e.OrgId }, "XXDY_HR_DEPARTMENTS_IDX1");

                entity.HasIndex(e => new { e.DepartmentName, e.OrgId }, "XXDY_HR_DEPARTMENTS_IDX2");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT_CODE");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DepartmentType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG")
                    .HasDefaultValueSql("'Y'");

                entity.Property(e => e.EndDateActive)
                    .HasColumnType("DATE")
                    .HasColumnName("END_DATE_ACTIVE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OrgId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORG_ID")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.ParentDeptId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PARENT_DEPT_ID")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyHrEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("SYS_C0011153");

                entity.ToTable("XXDY_HR_EMPLOYEES", "YARD");

                entity.HasIndex(e => new { e.EmployeeNumber, e.OrgId }, "XXDY_HR_EMPLOYEES_IDX1");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EmployeeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMPLOYEE_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EmployeeType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMPLOYEE_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.EndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("END_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FullName)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("FULL_NAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENDER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("HOME_PHONE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ImageFile)
                    .HasColumnType("BLOB")
                    .HasColumnName("IMAGE_FILE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.JobId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("JOB_ID");

                entity.Property(e => e.LastName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("LAST_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("MIDDLE_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MOBILE_PHONE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NationalIdentifier)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NATIONAL_IDENTIFIER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.OrgId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORG_ID")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.StartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("START_DATE")
                    .HasDefaultValueSql("TRUNC(SYSDATE)");

                entity.Property(e => e.TaxIdentifier)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TAX_IDENTIFIER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WORK_PHONE")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyHrJob>(entity =>
            {
                entity.HasKey(e => e.JobId)
                    .HasName("SYS_C0011147");

                entity.ToTable("XXDY_HR_JOBS", "YARD");

                entity.HasIndex(e => new { e.JobCode, e.OrgId }, "XXDY_HR_JOBS_IDX1");

                entity.HasIndex(e => new { e.JobName, e.OrgId }, "XXDY_HR_JOBS_IDX2");

                entity.Property(e => e.JobId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("JOB_ID");

                entity.Property(e => e.BranchId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BRANCH_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG")
                    .HasDefaultValueSql("'Y'");

                entity.Property(e => e.EndDateActive)
                    .HasColumnType("DATE")
                    .HasColumnName("END_DATE_ACTIVE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.JobCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("JOB_CODE");

                entity.Property(e => e.JobName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("JOB_NAME");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OrgId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORG_ID")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.ParentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PARENT_ID")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyInsAttachment>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("SYS_C0012020");

                entity.ToTable("XXDY_INS_ATTACHMENTS", "YARD");

                entity.Property(e => e.FileId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FILE_ID");

                entity.Property(e => e.AbsoluteName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ABSOLUTE_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ApprovalStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_STATUS")
                    .HasDefaultValueSql("'NEW'");

                entity.Property(e => e.ApprovedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("APPROVED_BY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DanoOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DANO_ORDER")
                    .HasDefaultValueSql("NULL ");

                entity.Property(e => e.DanoType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DANO_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DetailId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DETAIL_ID")
                    .HasDefaultValueSql("NULL\r\n  ");

                entity.Property(e => e.FileExt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FILE_EXT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FILE_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HEADER_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE\n");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.OrgId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORG_ID");

                entity.Property(e => e.RejectMotive)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REJECT_MOTIVE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RejectReason)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REJECT_REASON")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.SourceFolder)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_FOLDER");

                entity.Property(e => e.SourceTable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_TABLE");

                entity.Property(e => e.ValidUntil)
                    .HasColumnType("DATE")
                    .HasColumnName("VALID_UNTIL")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ZoneType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ZONE_TYPE")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyInsHeader>(entity =>
            {
                entity.HasKey(e => e.HeaderId)
                    .HasName("SYS_C0011938");

                entity.ToTable("XXDY_INS_HEADERS", "YARD");

                entity.Property(e => e.HeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HEADER_ID");

                entity.Property(e => e.ActualInspector)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACTUAL_INSPECTOR")
                    .HasDefaultValueSql("NULL ");

                entity.Property(e => e.BranchId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BRANCH_ID")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_NUMBER");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NAME");

                entity.Property(e => e.DeHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DE_HEADER_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DeLineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DE_LINE_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ENTRY_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.HiddenNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HIDDEN_NUMBER")
                    .HasDefaultValueSql("NULL\r\n  ");

                entity.Property(e => e.InsType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("INS_TYPE");

                entity.Property(e => e.InspectStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("INSPECT_STATUS")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.InspectionDate)
                    .HasColumnType("DATE")
                    .HasColumnName("INSPECTION_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.InspectionFolio)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INSPECTION_FOLIO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MovementType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOVEMENT_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NumeroOcultos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_OCULTOS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.OperationType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OPERATION_TYPE")
                    .HasDefaultValueSql("NULL\n");

                entity.Property(e => e.PlacaDeVin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PLACA_DE_VIN")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.PlacaDeVinZoneType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PLACA_DE_VIN_ZONE_TYPE")
                    .HasDefaultValueSql("NULL\r\n");

                entity.Property(e => e.PlateNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PLATE_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RearType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REAR_TYPE");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER");

                entity.Property(e => e.TerminationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("TERMINATION_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TrxType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRX_TYPE");

                entity.Property(e => e.Vin)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VIN");

                entity.Property(e => e.ZoneType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ZONE_TYPE");
            });

            modelBuilder.Entity<XxdyInsLine>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("SYS_C0011460");

                entity.ToTable("XXDY_INS_LINES", "YARD");

                entity.Property(e => e.LineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.CdNumeroOcultos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CD_NUMERO_OCULTOS")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.CdObservacions)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("CD_OBSERVACIONS")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.CiComments)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("CI_COMMENTS")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.CiManivela)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CI_MANIVELA")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.CiNumeroOcultos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CI_NUMERO_OCULTOS")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.CiPortllantas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CI_PORTLLANTAS")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DanoDetailsJson)
                    .IsUnicode(false)
                    .HasColumnName("DANO_DETAILS_JSON")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DocConexiones)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOC_CONEXIONES");

                entity.Property(e => e.DocDefensa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOC_DEFENSA");

                entity.Property(e => e.DocDictamenDeVerificacion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOC_DICTAMEN_DE_VERIFICACION")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.DocHologrameDeVerificacion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOC_HOLOGRAME_DE_VERIFICACION")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.DocLlantas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOC_LLANTAS");

                entity.Property(e => e.DocLuces)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOC_LUCES");

                entity.Property(e => e.DocMarco)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOC_MARCO");

                entity.Property(e => e.DocPatines)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOC_PATINES");

                entity.Property(e => e.DocPedimientoDeImportacion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOC_PEDIMIENTO_DE_IMPORTACION")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.DocPlacaVin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOC_PLACA_VIN")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.DocRines)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOC_RINES");

                entity.Property(e => e.DocSistemaDeAire)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOC_SISTEMA_DE_AIRE");

                entity.Property(e => e.DocSuspension)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOC_SUSPENSION");

                entity.Property(e => e.DocTarjetaDeCirculacion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOC_TARJETA_DE_CIRCULACION")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.DocVin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOC_VIN")
                    .HasDefaultValueSql("NULL\n");

                entity.Property(e => e.FreComments)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("FRE_COMMENTS")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.FreKmAbs)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FRE_KM_ABS")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.FreNumeroOcultos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FRE_NUMERO_OCULTOS")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.FrePlacaDeVin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FRE_PLACA_DE_VIN")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.HeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HEADER_ID");

                entity.Property(e => e.InfComments)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("INF_COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.InfEje1)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("INF_EJE1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.InfEje2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("INF_EJE2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.InfEspiga)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("INF_ESPIGA")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.InfNumeroOcultos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("INF_NUMERO_OCULTOS")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.InfPatines)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("INF_PATINES")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.InsComments)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("INS_COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.InsCondicion)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("INS_CONDICION")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.InsDot)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("INS_DOT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.InsEco)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("INS_ECO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.InsMarca)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("INS_MARCA")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.InsMedidas)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("INS_MEDIDAS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.InsModelo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("INS_MODELO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.InsRenovados)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("INS_RENOVADOS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.InsTipo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("INS_TIPO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IntNumeroOcultos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("INT_NUMERO_OCULTOS")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.IntObservacions)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("INT_OBSERVACIONS")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.LlantaDelCliente)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LLANTA_DEL_CLIENTE")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.LlantaSinCliente)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LLANTA_SIN_CLIENTE")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.PiNumeroOcultos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PI_NUMERO_OCULTOS")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.PiObservacions)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("PI_OBSERVACIONS");

                entity.Property(e => e.TolNumeroOcultos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TOL_NUMERO_OCULTOS")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.TolObservacions)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("TOL_OBSERVACIONS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TraComments)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("TRA_COMMENTS")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.TraNumeroOcultos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRA_NUMERO_OCULTOS")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.TraPlaca)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TRA_PLACA")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TraPlacaCirculacion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRA_PLACA_CIRCULACION")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.TraPlacaDeVin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRA_PLACA_DE_VIN");

                entity.Property(e => e.TraRearType)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("TRA_REAR_TYPE")
                    .HasDefaultValueSql("NULL\r\n");

                entity.Property(e => e.Val1321)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("VAL_1_32_1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Val1322)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("VAL_1_32_2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ZoneType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ZONE_TYPE");
            });

            modelBuilder.Entity<XxdyInsLocDetail>(entity =>
            {
                entity.HasKey(e => e.DetailId)
                    .HasName("SYS_C0011474");

                entity.ToTable("XXDY_INS_LOC_DETAILS", "YARD");

                entity.HasIndex(e => e.HeaderId, "XXDY_INS_LOC_DETAILS_IDX");

                entity.Property(e => e.DetailId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DETAIL_ID");

                entity.Property(e => e.Actividad)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVIDAD")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Cant)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CANT")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Category)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DanoOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DANO_ORDER");

                entity.Property(e => e.DanoType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DANO_TYPE");

                entity.Property(e => e.Falla)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("FALLA")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HEADER_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.LineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.LineNumber)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LINE_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PlannedHours)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PLANNED_HOURS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ZoneId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ZONE_ID");

                entity.Property(e => e.ZoneType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ZONE_TYPE");
            });

            modelBuilder.Entity<XxdyInsLocation>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("SYS_C0011467");

                entity.ToTable("XXDY_INS_LOCATIONS", "YARD");

                entity.Property(e => e.LocationId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DanoOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DANO_ORDER");

                entity.Property(e => e.DanoType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DANO_TYPE");

                entity.Property(e => e.HeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HEADER_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.LineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.TotalImages)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TOTAL_IMAGES")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ZoneType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ZONE_TYPE");
            });

            modelBuilder.Entity<XxdyInsLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("SYS_C0011963");

                entity.ToTable("XXDY_INS_LOGS", "YARD");

                entity.Property(e => e.LogId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOG_ID");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.InspectionId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INSPECTION_ID");

                entity.Property(e => e.InspectorId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INSPECTOR_ID");
            });

            modelBuilder.Entity<XxdyMtlOnhand>(entity =>
            {
                entity.HasKey(e => new { e.InventoryItemId, e.OrganizationId, e.SubinventoryCode })
                    .HasName("SYS_C0012881");

                entity.ToTable("XXDY_MTL_ONHAND", "YARD");

                entity.Property(e => e.InventoryItemId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INVENTORY_ITEM_ID");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.SubinventoryCode)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("SUBINVENTORY_CODE");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_DESCRIPTION");

                entity.Property(e => e.OnHand)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ON_HAND");

                entity.Property(e => e.OrganizationCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ORGANIZATION_CODE");
            });

            modelBuilder.Entity<XxdyOdtAttachment>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("SYS_C0012304");

                entity.ToTable("XXDY_ODT_ATTACHMENTS", "YARD");

                entity.Property(e => e.FileId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FILE_ID");

                entity.Property(e => e.AbsoluteName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ABSOLUTE_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ApprovalStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_STATUS")
                    .HasDefaultValueSql("'NEW'");

                entity.Property(e => e.ApprovedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("APPROVED_BY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FileExt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FILE_EXT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FILE_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HEADER_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.OrgId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORG_ID");

                entity.Property(e => e.RejectMotive)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REJECT_MOTIVE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RejectReason)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REJECT_REASON")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.SourceFolder)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_FOLDER");

                entity.Property(e => e.SourceTable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_TABLE");

                entity.Property(e => e.ValidUntil)
                    .HasColumnType("DATE")
                    .HasColumnName("VALID_UNTIL")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyOdtDistribution>(entity =>
            {
                entity.HasKey(e => e.DistributionId)
                    .HasName("SYS_C0012767");

                entity.ToTable("XXDY_ODT_DISTRIBUTIONS", "YARD");

                entity.Property(e => e.DistributionId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DISTRIBUTION_ID");

                entity.Property(e => e.AssemblyItemId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ASSEMBLY_ITEM_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ComponentQuantity)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COMPONENT_QUANTITY");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DeliveredQuantity)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DELIVERED_QUANTITY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HEADER_ID");

                entity.Property(e => e.ItemComponent)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_COMPONENT");

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_DESCRIPTION");

                entity.Property(e => e.ItemSequence)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ITEM_SEQUENCE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.OnHandQuantity)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ON_HAND_QUANTITY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.OperationSeqNum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OPERATION_SEQ_NUM");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.ParentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PARENT_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PrimaryUomCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PRIMARY_UOM_CODE");

                entity.Property(e => e.RequestedQuantity)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REQUESTED_QUANTITY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.SwapQuantity)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SWAP_QUANTITY")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<XxdyOdtHeader>(entity =>
            {
                entity.HasKey(e => e.HeaderId)
                    .HasName("SYS_C0012291");

                entity.ToTable("XXDY_ODT_HEADERS", "YARD");

                entity.Property(e => e.HeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HEADER_ID");

                entity.Property(e => e.BranchId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BRANCH_ID")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_NUMBER");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CurrentReceiptId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CURRENT_RECEIPT_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CusdyDyWoHId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUSDY_DY_WO_H_ID")
                    .HasDefaultValueSql("NULL\n");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NAME");

                entity.Property(e => e.DeHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DE_HEADER_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DeLineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DE_LINE_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.InsHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INS_HEADER_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LockFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LOCK_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.MaterialStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MATERIAL_STATUS")
                    .HasDefaultValueSql("'Y'");

                entity.Property(e => e.MovementType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOVEMENT_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.OdtDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ODT_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.OdtFolio)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ODT_FOLIO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.OdtGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ODT_GROUP")
                    .HasDefaultValueSql("'OT' ");

                entity.Property(e => e.OdtStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ODT_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.OdtType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ODT_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ParentId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PARENT_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PlannedHours)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PLANNED_HOURS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PlateNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PLATE_NUMBER");

                entity.Property(e => e.PriorityCode)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRIORITY_CODE")
                    .HasDefaultValueSql("99 ");

                entity.Property(e => e.RearType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REAR_TYPE");

                entity.Property(e => e.RebillFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REBILL_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.RebillStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("REBILL_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER");

                entity.Property(e => e.TeamId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TEAM_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TerminationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("TERMINATION_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Vin)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VIN");

                entity.Property(e => e.WorkHours)
                    .HasColumnType("NUMBER")
                    .HasColumnName("WORK_HOURS")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyOdtLine>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("SYS_C0012688");

                entity.ToTable("XXDY_ODT_LINES", "YARD");

                entity.Property(e => e.LineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.ApprovalDate)
                    .HasColumnType("DATE")
                    .HasColumnName("APPROVAL_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ApprovedQuantity)
                    .HasColumnType("NUMBER")
                    .HasColumnName("APPROVED_QUANTITY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ApproverId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("APPROVER_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ApprvComments)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("APPRV_COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ApprvMotive)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("APPRV_MOTIVE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Category)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DeleteFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETE_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.DeletedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DELETED_BY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DeletedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETED_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FaultType)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("FAULT_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HEADER_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LINE_STATUS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LockFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LOCK_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.MaterialId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("MATERIAL_ID");

                entity.Property(e => e.MaterialStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MATERIAL_STATUS")
                    .HasDefaultValueSql("'Y'");

                entity.Property(e => e.OnhandStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONHAND_STATUS")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.PlannedHours)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PLANNED_HOURS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Quantity)
                    .HasColumnType("NUMBER")
                    .HasColumnName("QUANTITY");

                entity.Property(e => e.TeamId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TEAM_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WorkHours)
                    .HasColumnType("NUMBER")
                    .HasColumnName("WORK_HOURS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ZoneId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ZONE_ID");
            });

            modelBuilder.Entity<XxdyOdtRcvLine>(entity =>
            {
                entity.HasKey(e => e.RcvLineId)
                    .HasName("SYS_C0013492");

                entity.ToTable("XXDY_ODT_RCV_LINES", "YARD");

                entity.Property(e => e.RcvLineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RCV_LINE_ID");

                entity.Property(e => e.ApprovedQuantity)
                    .HasColumnType("NUMBER")
                    .HasColumnName("APPROVED_QUANTITY")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DeliveredQuantity)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DELIVERED_QUANTITY")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DistributionId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DISTRIBUTION_ID");

                entity.Property(e => e.ItemComponent)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_COMPONENT");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.RcvHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RCV_HEADER_ID");

                entity.Property(e => e.ReceivedQuantity)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RECEIVED_QUANTITY")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequestedQuantity)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REQUESTED_QUANTITY")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<XxdyOdtReceipt>(entity =>
            {
                entity.HasKey(e => e.RcvHeaderId)
                    .HasName("SYS_C0012838");

                entity.ToTable("XXDY_ODT_RECEIPTS", "YARD");

                entity.Property(e => e.RcvHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RCV_HEADER_ID");

                entity.Property(e => e.ApprovalDate)
                    .HasColumnType("DATE")
                    .HasColumnName("APPROVAL_DATE");

                entity.Property(e => e.ApproverId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("APPROVER_ID");

                entity.Property(e => e.BranchId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BRANCH_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Comments)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DispatchBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DISPATCH_BY");

                entity.Property(e => e.DispatchDate)
                    .HasColumnType("DATE")
                    .HasColumnName("DISPATCH_DATE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OdtHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ODT_HEADER_ID");

                entity.Property(e => e.RcvDate)
                    .HasColumnType("DATE")
                    .HasColumnName("RCV_DATE")
                    .HasDefaultValueSql("TRUNC(SYSDATE)");

                entity.Property(e => e.ReceiptStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RECEIPT_STATUS")
                    .HasDefaultValueSql("'Nuevo'");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TeamId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TEAM_ID")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdyOdtWorkLoad>(entity =>
            {
                entity.HasKey(e => e.WorkloadId)
                    .HasName("SYS_C0013418");

                entity.ToTable("XXDY_ODT_WORK_LOAD", "YARD");

                entity.HasIndex(e => new { e.PersonId, e.PeriodYear, e.WeekNumber }, "XXDY_ODT_WORK_LOAD_IDX");

                entity.Property(e => e.WorkloadId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("WORKLOAD_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.OdtHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ODT_HEADER_ID");

                entity.Property(e => e.PeriodId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PERIOD_ID");

                entity.Property(e => e.PeriodYear)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PERIOD_YEAR");

                entity.Property(e => e.PersonId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PERSON_ID");

                entity.Property(e => e.TeamId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TEAM_ID");

                entity.Property(e => e.TerminationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("TERMINATION_DATE");

                entity.Property(e => e.WeekNumber)
                    .HasColumnType("NUMBER")
                    .HasColumnName("WEEK_NUMBER");

                entity.Property(e => e.WorkHours)
                    .HasColumnType("NUMBER")
                    .HasColumnName("WORK_HOURS");
            });

            modelBuilder.Entity<XxdyOdtWorkLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("SYS_C0012643");

                entity.ToTable("XXDY_ODT_WORK_LOGS", "YARD");

                entity.Property(e => e.LogId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOG_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("END_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HEADER_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LogType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LOG_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("START_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WorkHours)
                    .HasColumnType("NUMBER")
                    .HasColumnName("WORK_HOURS")
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<XxdyProcessDraft>(entity =>
            {
                entity.HasKey(e => e.InterfaceId)
                    .HasName("SYS_C0015517");

                entity.ToTable("XXDY_PROCESS_DRAFT", "YARD");

                entity.Property(e => e.InterfaceId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTERFACE_ID");

                entity.Property(e => e.ActivationId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ACTIVATION_ID");

                entity.Property(e => e.ApiErrorLoc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("API_ERROR_LOC");

                entity.Property(e => e.ApiMensage)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("API_MENSAGE");

                entity.Property(e => e.ApiStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("API_STATUS");

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_NUMBER");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.DeLineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DE_LINE_ID");

                entity.Property(e => e.DeliveryId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DELIVERY_ID");

                entity.Property(e => e.ProcessDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PROCESS_DATE");

                entity.Property(e => e.ProcessFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROCESS_FLAG");

                entity.Property(e => e.ProgramDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PROGRAM_DATE");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER");
            });

            modelBuilder.Entity<XxdyRebillHeader>(entity =>
            {
                entity.HasKey(e => e.InterfaceId)
                    .HasName("SYS_C0013750");

                entity.ToTable("XXDY_REBILL_HEADERS", "YARD");

                entity.Property(e => e.InterfaceId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTERFACE_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_NUMBER");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NUMBER");

                entity.Property(e => e.DoorType)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DOOR_TYPE");

                entity.Property(e => e.Eje1EspesorBalata)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EJE1_ESPESOR_BALATA");

                entity.Property(e => e.Eje2EspesorBalata)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EJE2_ESPESOR_BALATA");

                entity.Property(e => e.InsHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INS_HEADER_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LineType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LINE_TYPE");

                entity.Property(e => e.Manivela)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MANIVELA");

                entity.Property(e => e.OrgName)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ORG_NAME");

                entity.Property(e => e.Patio)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("PATIO");

                entity.Property(e => e.PlacaVin)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PLACA_VIN");

                entity.Property(e => e.RbHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RB_HEADER_ID");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER");

                entity.Property(e => e.Status)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("'PENDING'");

                entity.Property(e => e.TipoEspiga)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_ESPIGA");

                entity.Property(e => e.TipoPatines)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PATINES");
            });

            modelBuilder.Entity<XxdyRebillLine>(entity =>
            {
                entity.HasKey(e => e.InterfaceLineId)
                    .HasName("SYS_C0013753");

                entity.ToTable("XXDY_REBILL_LINES", "YARD");

                entity.Property(e => e.InterfaceLineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTERFACE_LINE_ID");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CANTIDAD");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_NUMBER");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NUMBER");

                entity.Property(e => e.DoorType)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DOOR_TYPE");

                entity.Property(e => e.Falla)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("FALLA");

                entity.Property(e => e.InsDetailId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INS_DETAIL_ID");

                entity.Property(e => e.InsHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INS_HEADER_ID");

                entity.Property(e => e.InsType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("INS_TYPE");

                entity.Property(e => e.InterfaceId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INTERFACE_ID");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LineType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LINE_TYPE");

                entity.Property(e => e.OrgName)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ORG_NAME");

                entity.Property(e => e.Patio)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("PATIO");

                entity.Property(e => e.RbHeaderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RB_HEADER_ID");

                entity.Property(e => e.RbLineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RB_LINE_ID");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER");

                entity.Property(e => e.Status)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("'PENDING'");

                entity.Property(e => e.ZoneType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ZONE_TYPE");
            });

            modelBuilder.Entity<XxdyRebillStatus>(entity =>
            {
                entity.HasKey(e => e.DetailId)
                    .HasName("SYS_C0013964");

                entity.ToTable("XXDY_REBILL_STATUS", "YARD");

                entity.Property(e => e.DetailId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DETAIL_ID");

                entity.Property(e => e.Amount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NAME");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NAME");

                entity.Property(e => e.DeleteFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETE_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETED_AT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DoorType)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DOOR_TYPE");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ManufacturerName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MANUFACTURER_NAME");

                entity.Property(e => e.ModelYear)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_YEAR");

                entity.Property(e => e.PlateNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PLATE_NUMBER");

                entity.Property(e => e.RebillGroupId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REBILL_GROUP_ID");

                entity.Property(e => e.ReturnDate)
                    .HasColumnType("DATE")
                    .HasColumnName("RETURN_DATE");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER");

                entity.Property(e => e.Vin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIN");
            });

            modelBuilder.Entity<XxdySysBranch>(entity =>
            {
                entity.HasKey(e => e.BranchId)
                    .HasName("SYS_C0010953");

                entity.ToTable("XXDY_SYS_BRANCHES", "YARD");

                entity.HasIndex(e => new { e.EntityId, e.BranchNumber, e.ShortName }, "SYS_C0010954")
                    .IsUnique();

                entity.Property(e => e.BranchId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BRANCH_ID");

                entity.Property(e => e.ActiveFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE_FLAG")
                    .HasDefaultValueSql("'Y'                   ");

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_LINE1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_LINE2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NAME");

                entity.Property(e => e.BranchNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NUMBER");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CITY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Colony)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COLONY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DoorNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DOOR_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EntityId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ENTITY_ID");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAX")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE\n");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PHONE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Province)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PROVINCE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SHORT_NAME");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StreetNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STREET_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ZIP_CODE")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdySysItem>(entity =>
            {
                entity.HasKey(e => e.InventoryItemId)
                    .HasName("SYS_C0012950");

                entity.ToTable("XXDY_SYS_ITEMS", "YARD");

                entity.Property(e => e.InventoryItemId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INVENTORY_ITEM_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CODE");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_TYPE");

                entity.Property(e => e.PrimaryUomCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PRIMARY_UOM_CODE");
            });

            modelBuilder.Entity<XxdySysLegalEntity>(entity =>
            {
                entity.HasKey(e => e.EntityId)
                    .HasName("SYS_C0010545");

                entity.ToTable("XXDY_SYS_LEGAL_ENTITIES", "YARD");

                entity.HasIndex(e => e.EntityName, "SYS_C0010546")
                    .IsUnique();

                entity.Property(e => e.EntityId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ENTITY_ID");

                entity.Property(e => e.ActiveFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_LINE1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_LINE2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CITY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CODE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Colony)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COLONY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DoorNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DOOR_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EntityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENTITY_NAME");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAX")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PHONE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Province)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PROVINCE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SHORT_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StreetNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STREET_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TaxIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TAX_IDENTIFIER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WebAddress)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("WEB_ADDRESS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ZIP_CODE")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdySysListCode>(entity =>
            {
                entity.HasKey(e => e.ListCodeId)
                    .HasName("SYS_C0010528");

                entity.ToTable("XXDY_SYS_LIST_CODES", "YARD");

                entity.HasIndex(e => new { e.ListCode, e.OrgId }, "SYS_C0010529")
                    .IsUnique();

                entity.Property(e => e.ListCodeId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LIST_CODE_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LANGUAGE_CODE")
                    .HasDefaultValueSql("'ES' ");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ListCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LIST_CODE");

                entity.Property(e => e.Meaning)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("MEANING");

                entity.Property(e => e.OrgId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORG_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.SecurityLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SECURITY_LEVEL")
                    .HasDefaultValueSql("'U' ");
            });

            modelBuilder.Entity<XxdySysListValue>(entity =>
            {
                entity.HasKey(e => e.ListValueId)
                    .HasName("SYS_C0010536");

                entity.ToTable("XXDY_SYS_LIST_VALUES", "YARD");

                entity.HasIndex(e => new { e.ListCode, e.OrgId, e.ListValue }, "SYS_C0010537")
                    .IsUnique();

                entity.Property(e => e.ListValueId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LIST_VALUE_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Description)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LANGUAGE_CODE")
                    .HasDefaultValueSql("'ES' ");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ListCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LIST_CODE");

                entity.Property(e => e.ListCodeId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LIST_CODE_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ListOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LIST_ORDER")
                    .HasDefaultValueSql("'10' ");

                entity.Property(e => e.ListValue)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LIST_VALUE");

                entity.Property(e => e.Meaning)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("MEANING");

                entity.Property(e => e.OrgId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORG_ID")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdySysMenu>(entity =>
            {
                entity.HasKey(e => e.MenuId)
                    .HasName("SYS_C0010481");

                entity.ToTable("XXDY_SYS_MENUS", "YARD");

                entity.Property(e => e.MenuId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MENU_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DefaultPageId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEFAULT_PAGE_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Description)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.ExternalFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MenuName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MENU_NAME");

                entity.Property(e => e.SecurityLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SECURITY_LEVEL")
                    .HasDefaultValueSql("'U' ");
            });

            modelBuilder.Entity<XxdySysMenuItem>(entity =>
            {
                entity.HasKey(e => e.MenuItemId)
                    .HasName("SYS_C0010511");

                entity.ToTable("XXDY_SYS_MENU_ITEMS", "YARD");

                entity.Property(e => e.MenuItemId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MENU_ITEM_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DeleteAllowed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DELETE_ALLOWED");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG");

                entity.Property(e => e.InsertAllowed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("INSERT_ALLOWED");

                entity.Property(e => e.ItemOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ITEM_ORDER");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MenuId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MENU_ID");

                entity.Property(e => e.ModuleId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.PageId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PAGE_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.UpdateAllowed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_ALLOWED");
            });

            modelBuilder.Entity<XxdySysModule>(entity =>
            {
                entity.HasKey(e => e.ModuleId)
                    .HasName("SYS_C0010466");

                entity.ToTable("XXDY_SYS_MODULES", "YARD");

                entity.Property(e => e.ModuleId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ModuleCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_CODE");

                entity.Property(e => e.ModuleIcon)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MODULE_ICON")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_NAME");
            });

            modelBuilder.Entity<XxdySysPage>(entity =>
            {
                entity.HasKey(e => e.PageId)
                    .HasName("SYS_C0010475");

                entity.ToTable("XXDY_SYS_PAGES", "YARD");

                entity.HasIndex(e => e.PageCode, "XXDY_SYS_PAGES_IDX1")
                    .IsUnique();

                entity.Property(e => e.PageId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PAGE_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("FILE_PATH");

                entity.Property(e => e.IsHeader)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IS_HEADER")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ModuleId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.PageCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PAGE_CODE");

                entity.Property(e => e.PageName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PAGE_NAME");

                entity.Property(e => e.PageOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PAGE_ORDER");

                entity.Property(e => e.ParamText)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PARAM_TEXT")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.SecurityLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SECURITY_LEVEL")
                    .HasDefaultValueSql("'U' ");
            });

            modelBuilder.Entity<XxdySysUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("SYS_C0010517");

                entity.ToTable("XXDY_SYS_USER", "YARD");

                entity.HasIndex(e => e.EmailAddress, "SYS_C0010518")
                    .IsUnique();

                entity.Property(e => e.UserId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USER_ID");

                entity.Property(e => e.AdminFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ADMIN_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.BranchId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BRANCH_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUSTOMER_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomerIds)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_IDS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_ADDRESS");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EMPLOYEE_ID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.EncryptedUserPassword)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ENCRYPTED_USER_PASSWORD");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FullName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("FULL_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.InactiveDate)
                    .HasColumnType("DATE")
                    .HasColumnName("INACTIVE_DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LAST_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MIDDLE_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PHONE_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RmaMenuId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RMA_MENU_ID")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxdySysUserLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("SYS_C0010541");

                entity.ToTable("XXDY_SYS_USER_LOGS", "YARD");

                entity.Property(e => e.LogId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOG_ID");

                entity.Property(e => e.AppVersion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("APP_VERSION")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastLoginDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_LOGIN_DATE");

                entity.Property(e => e.UserId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USER_ID");
            });

            modelBuilder.Entity<XxdySysUserParam>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("SYS_C0010522");

                entity.ToTable("XXDY_SYS_USER_PARAMS", "YARD");

                entity.Property(e => e.UserId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USER_ID");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomField1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CustomField5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_FIELD5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LANGUAGE_CODE")
                    .HasDefaultValueSql("'US' ");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PasswordAttempts)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PASSWORD_ATTEMPTS");

                entity.Property(e => e.PasswordReset)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD_RESET")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.SessionValue)
                    .IsUnicode(false)
                    .HasColumnName("SESSION_VALUE")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XxtipDyCostItemsV>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("XXTIP_DY_COST_ITEMS_V", "YARD");

                entity.Property(e => e.Description)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_NAME");

                entity.Property(e => e.ListLineId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LIST_LINE_ID");

                entity.Property(e => e.Operand)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OPERAND");

                entity.Property(e => e.ProductAttrValue)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT_ATTR_VALUE");
            });

            modelBuilder.Entity<XxtipRmaRelContractInt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("XXTIP_RMA_REL_CONTRACT_INT", "YARD");

                entity.Property(e => e.AccreditedFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACCREDITED_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_LINE1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_LINE2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.AddressType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_TYPE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Attribute1)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE1")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Attribute10)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE10")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Attribute11)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE11")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Attribute12)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE12")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Attribute13)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE13")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Attribute14)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE14")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Attribute15)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE15")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Attribute2)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE2")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Attribute3)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE3")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Attribute4)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE4")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Attribute5)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE5")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Attribute6)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE6")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Attribute7)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE7")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Attribute8)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE8")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Attribute9)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE9")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.AttributeCategory)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_CATEGORY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.BaileeFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BAILEE_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CITY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Colony)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COLONY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ContractFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.ContractKnownas)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_KNOWNAS");

                entity.Property(e => e.ContractMarco)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_MARCO");

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CREATED_BY")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NUMBER");

                entity.Property(e => e.DateContractMarco)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_CONTRACT_MARCO");

                entity.Property(e => e.DlCustomerId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DL_CUSTOMER_ID");

                entity.Property(e => e.DoorNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DOOR_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_ADDRESS")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.FolioDl)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FOLIO_DL");

                entity.Property(e => e.GuaranteeFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GUARANTEE_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("HOME_PHONE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.JointHolderFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("JOINT_HOLDER_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.LastName)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasDefaultValueSql("-1\n");

                entity.Property(e => e.LegalFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LEGAL_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("MIDDLE_NAME");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MOBILE_PHONE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.OwnerFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OWNER_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.ParticipantId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PARTICIPANT_ID");

                entity.Property(e => e.Province)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PROVINCE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RelConstitutiveActDate)
                    .HasColumnType("DATE")
                    .HasColumnName("REL_CONSTITUTIVE_ACT_DATE");

                entity.Property(e => e.RelConstitutiveActNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REL_CONSTITUTIVE_ACT_NUMBER");

                entity.Property(e => e.RelCustomerRegion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REL_CUSTOMER_REGION");

                entity.Property(e => e.RelNotaryName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REL_NOTARY_NAME");

                entity.Property(e => e.RelNotaryNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REL_NOTARY_NUMBER");

                entity.Property(e => e.RelNotaryOffice)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REL_NOTARY_OFFICE");

                entity.Property(e => e.RelPlaceOfRegistration)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REL_PLACE_OF_REGISTRATION");

                entity.Property(e => e.RelRegistrationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("REL_REGISTRATION_DATE");

                entity.Property(e => e.RelRegistrationInformation)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REL_REGISTRATION_INFORMATION");

                entity.Property(e => e.RelationContractId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RELATION_CONTRACT_ID");

                entity.Property(e => e.ResourceOwner)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RESOURCE_OWNER")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.RfcContact)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("RFC_CONTACT");

                entity.Property(e => e.RolId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ROL_ID");

                entity.Property(e => e.ShareholderFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SHAREHOLDER_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.StateName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STATE_NAME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("'PENDING'");

                entity.Property(e => e.StreetNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STREET_NUMBER")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ToPayFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TO_PAY_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WORK_PHONE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ZIP_CODE")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.HasSequence("APP_FAILED_JOBS_S", "YARD");

            modelBuilder.HasSequence("APP_JOBS_S", "YARD");

            modelBuilder.HasSequence("CUSDY_DY_WO_H_SEQ", "YARD");

            modelBuilder.HasSequence("CUSDY_DY_WO_L_SEQ", "YARD");

            modelBuilder.HasSequence("HEADER_ID_AUTO", "YARD");

            modelBuilder.HasSequence("XXDY_AM_THEFT_REPORT_HS", "YARD");

            modelBuilder.HasSequence("XXDY_AM_THEFT_REPORT_S", "YARD");

            modelBuilder.HasSequence("XXDY_AM_THEFT1_REPORT_S", "YARD");

            modelBuilder.HasSequence("XXDY_AM_VERIFICATIONS_HS", "YARD");

            modelBuilder.HasSequence("XXDY_AM_VERIFICATIONS_S", "YARD");

            modelBuilder.HasSequence("XXDY_AM_VERIFICATIONS1_S", "YARD");

            modelBuilder.HasSequence("XXDY_APP_ASSIGNED_DOCS_S", "YARD");

            modelBuilder.HasSequence("XXDY_APP_DOCUMENT_SETS_S", "YARD");

            modelBuilder.HasSequence("XXDY_APP_DOCUMENTS_S", "YARD");

            modelBuilder.HasSequence("XXDY_APP_REJECTED_REASONS_S", "YARD");

            modelBuilder.HasSequence("XXDY_CAT_ITEM_SUBSTITUTES_S", "YARD");

            modelBuilder.HasSequence("XXDY_CAT_LICENSES_S", "YARD");

            modelBuilder.HasSequence("XXDY_CAT_MISC_ITEMS_S", "YARD");

            modelBuilder.HasSequence("XXDY_CAT_TYRES_S", "YARD");

            modelBuilder.HasSequence("XXDY_CAT_ZONE_MATERIALS_S", "YARD");

            modelBuilder.HasSequence("XXDY_CAT_ZONES_S", "YARD");

            modelBuilder.HasSequence("XXDY_DA_ATTACHMENTS_S", "YARD");

            modelBuilder.HasSequence("XXDY_DA_DOCUMENTS_S", "YARD");

            modelBuilder.HasSequence("XXDY_DA_LOGS_S", "YARD");

            modelBuilder.HasSequence("XXDY_DA_TRANSACTIONS_S", "YARD");

            modelBuilder.HasSequence("XXDY_DE_ACTIVATIONS_S", "YARD");

            modelBuilder.HasSequence("XXDY_DE_ATTACHMENTS_S", "YARD");

            modelBuilder.HasSequence("XXDY_DE_BOOKING_S", "YARD");

            modelBuilder.HasSequence("XXDY_DE_DELIVERIES_S", "YARD");

            modelBuilder.HasSequence("XXDY_DE_HEADERS_S", "YARD");

            modelBuilder.HasSequence("XXDY_DE_LINES_S", "YARD");

            modelBuilder.HasSequence("XXDY_DE_PASS_S", "YARD");

            modelBuilder.HasSequence("XXDY_DE_RESERVATIONS_S", "YARD");

            modelBuilder.HasSequence("XXDY_DY_AVAILABILITY_S", "YARD");

            modelBuilder.HasSequence("XXDY_DY_DELIVERED_FLOTA_S", "YARD");

            modelBuilder.HasSequence("XXDY_DY_DELIVERED_S", "YARD");

            modelBuilder.HasSequence("XXDY_DY_PRIORITIES_S", "YARD");

            modelBuilder.HasSequence("XXDY_DY_PRODUCTIVITY_LOGS_S", "YARD");

            modelBuilder.HasSequence("XXDY_DY_PRODUCTIVITY_S", "YARD");

            modelBuilder.HasSequence("XXDY_DY_TEAMS_MEMBERS_S", "YARD");

            modelBuilder.HasSequence("XXDY_DY_TEAMS_S", "YARD");

            modelBuilder.HasSequence("XXDY_HR_DEPARTMENTS_S", "YARD");

            modelBuilder.HasSequence("XXDY_HR_EMPLOYEES_S", "YARD");

            modelBuilder.HasSequence("XXDY_HR_JOBS_S", "YARD");

            modelBuilder.HasSequence("XXDY_INS_ATTACHMENTS_S", "YARD");

            modelBuilder.HasSequence("XXDY_INS_FOLIO_S", "YARD");

            modelBuilder.HasSequence("XXDY_INS_HEADERS_S", "YARD");

            modelBuilder.HasSequence("XXDY_INS_LINES_S", "YARD");

            modelBuilder.HasSequence("XXDY_INS_LOC_DETAILS_S", "YARD");

            modelBuilder.HasSequence("XXDY_INS_LOCATIONS_S", "YARD");

            modelBuilder.HasSequence("XXDY_INS_LOGS_S", "YARD");

            modelBuilder.HasSequence("XXDY_ODT_ATTACHMENTS_S", "YARD");

            modelBuilder.HasSequence("XXDY_ODT_DISTRIBUTIONS_S", "YARD");

            modelBuilder.HasSequence("XXDY_ODT_FOLIO_S", "YARD");

            modelBuilder.HasSequence("XXDY_ODT_HEADERS_S", "YARD");

            modelBuilder.HasSequence("XXDY_ODT_LINES_S", "YARD");

            modelBuilder.HasSequence("XXDY_ODT_RCV_LINES_S", "YARD");

            modelBuilder.HasSequence("XXDY_ODT_RECEIPTS_S", "YARD");

            modelBuilder.HasSequence("XXDY_ODT_WORK_LOAD_S", "YARD");

            modelBuilder.HasSequence("XXDY_ODT_WORK_LOGS_S", "YARD");

            modelBuilder.HasSequence("XXDY_PROCESS_DRAFT_S", "YARD");

            modelBuilder.HasSequence("XXDY_REBILL_HEADERS_S", "YARD");

            modelBuilder.HasSequence("XXDY_REBILL_LINES_S", "YARD");

            modelBuilder.HasSequence("XXDY_REBILL_STATUS_S", "YARD");

            modelBuilder.HasSequence("XXDY_SYS_BRANCHES_S", "YARD");

            modelBuilder.HasSequence("XXDY_SYS_LEGAL_ENTITIES_S", "YARD");

            modelBuilder.HasSequence("XXDY_SYS_LIST_CODES_S", "YARD");

            modelBuilder.HasSequence("XXDY_SYS_LIST_VALUES_S", "YARD");

            modelBuilder.HasSequence("XXDY_SYS_MENU_ITEMS_S", "YARD");

            modelBuilder.HasSequence("XXDY_SYS_MENUS_S", "YARD");

            modelBuilder.HasSequence("XXDY_SYS_MODULES_S", "YARD");

            modelBuilder.HasSequence("XXDY_SYS_PAGES_S", "YARD");

            modelBuilder.HasSequence("XXDY_SYS_USER_LOGS_S", "YARD");

            modelBuilder.HasSequence("XXDY_SYS_USER_PARAMS_S", "YARD");

            modelBuilder.HasSequence("XXDY_SYS_USER_S", "YARD");

            modelBuilder.HasSequence("XXTIP_RMA_REL_CONTRACT_INT_S", "YARD");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
