using System;
using System.Collections.Generic;
using carsang.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace carsang.Data
{
    public partial class VehiclesDbTempContext : DbContext
    {
        public VehiclesDbTempContext()
        {
        }

        public VehiclesDbTempContext(DbContextOptions<VehiclesDbTempContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Vehicle> Vehicles { get; set; } = null!;

        /*
                protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                {
                    if (!optionsBuilder.IsConfigured)
                    {
        #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                        optionsBuilder.UseSqlServer("Server=localhost;Database=VehiclesDbTemp;Trusted_Connection=True;");
                    }
                }
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.Property(e => e.CId)
                    .ValueGeneratedNever()
                    .HasColumnName("cId");

                entity.Property(e => e.CAcceleration).HasColumnName("cAcceleration");

                entity.Property(e => e.CAdGuid).HasColumnName("cAdGuid");

                entity.Property(e => e.CAddressOrigin)
                    .HasMaxLength(512)
                    .HasColumnName("cAddressOrigin");

                entity.Property(e => e.CAudio)
                    .HasMaxLength(256)
                    .HasColumnName("cAudio");

                entity.Property(e => e.CAvailability).HasColumnName("cAvailability");

                entity.Property(e => e.CAxlesСount).HasColumnName("cAxlesСount");

                entity.Property(e => e.CBodyType)
                    .HasMaxLength(256)
                    .HasColumnName("cBodyType");

                entity.Property(e => e.CBrakes)
                    .HasMaxLength(256)
                    .HasColumnName("cBrakes");

                entity.Property(e => e.CBrand).HasColumnName("cBrand");

                entity.Property(e => e.CBrandKmu)
                    .HasMaxLength(256)
                    .HasColumnName("cBrandKmu");

                entity.Property(e => e.CBrandName)
                    .HasMaxLength(256)
                    .HasColumnName("cBrandName");

                entity.Property(e => e.CBucketCapacity).HasColumnName("cBucketCapacity");

                entity.Property(e => e.CCabinHeight)
                    .HasMaxLength(256)
                    .HasColumnName("cCabinHeight");

                entity.Property(e => e.CCabinType)
                    .HasMaxLength(256)
                    .HasColumnName("cCabinType");

                entity.Property(e => e.CChassisLength)
                    .HasMaxLength(256)
                    .HasColumnName("cChassisLength");

                entity.Property(e => e.CClearanceMin).HasColumnName("cClearanceMin");

                entity.Property(e => e.CClimatControl)
                    .HasMaxLength(256)
                    .HasColumnName("cClimatControl");

                entity.Property(e => e.CColorHex)
                    .HasMaxLength(64)
                    .HasColumnName("cColorHex");

                entity.Property(e => e.CColorName)
                    .HasMaxLength(256)
                    .HasColumnName("cColorName");

                entity.Property(e => e.CCondition)
                    .HasMaxLength(256)
                    .HasColumnName("cCondition");

                entity.Property(e => e.CCreatedDate)
                    .HasPrecision(2)
                    .HasColumnName("cCreatedDate");

                entity.Property(e => e.CCustomCleared).HasColumnName("cCustomCleared");

                entity.Property(e => e.CDescription).HasColumnName("cDescription");

                entity.Property(e => e.CDisks)
                    .HasMaxLength(128)
                    .HasColumnName("cDisks");

                entity.Property(e => e.CDisplacement)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cDisplacement");

                entity.Property(e => e.CDoorsCount).HasColumnName("cDoorsCount");

                entity.Property(e => e.CEcoClass)
                    .HasMaxLength(256)
                    .HasColumnName("cEcoClass");

                entity.Property(e => e.CEngineType).HasColumnName("cEngineType");

                entity.Property(e => e.CEngineTypeName)
                    .HasMaxLength(256)
                    .HasColumnName("cEngineTypeName");

                entity.Property(e => e.CExtraType)
                    .HasMaxLength(256)
                    .HasColumnName("cExtraType");

                entity.Property(e => e.CFuelRate).HasColumnName("cFuelRate");

                entity.Property(e => e.CGearType).HasColumnName("cGearType");

                entity.Property(e => e.CGearTypeName)
                    .HasMaxLength(256)
                    .HasColumnName("cGearTypeName");

                entity.Property(e => e.CHasChassi)
                    .HasMaxLength(256)
                    .HasColumnName("cHasChassi");

                entity.Property(e => e.CHasKmu)
                    .HasMaxLength(256)
                    .HasColumnName("cHasKmu");

                entity.Property(e => e.CHasTrailer)
                    .HasMaxLength(256)
                    .HasColumnName("cHasTrailer");

                entity.Property(e => e.CIdOnSource)
                    .HasMaxLength(128)
                    .HasColumnName("cIdOnSource");

                entity.Property(e => e.CIsDeleted).HasColumnName("cIsDeleted");

                entity.Property(e => e.CIsNew).HasColumnName("cIsNew");

                entity.Property(e => e.CIsRecovered).HasColumnName("cIsRecovered");

                entity.Property(e => e.CLatitude).HasColumnName("cLatitude");

                entity.Property(e => e.CLights)
                    .HasMaxLength(256)
                    .HasColumnName("cLights");

                entity.Property(e => e.CLoading)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("cLoading");

                entity.Property(e => e.CLocation).HasColumnName("cLocation");

                entity.Property(e => e.CLocationId).HasColumnName("cLocationId");

                entity.Property(e => e.CLongitude).HasColumnName("cLongitude");

                entity.Property(e => e.CMainTechParam).HasColumnName("cMainTechParam");

                entity.Property(e => e.CMaxLoading)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("cMaxLoading");

                entity.Property(e => e.CMileage).HasColumnName("cMileage");

                entity.Property(e => e.CMileageInfo)
                    .HasMaxLength(128)
                    .HasColumnName("cMileageInfo");

                entity.Property(e => e.CModel)
                    .HasMaxLength(256)
                    .HasColumnName("cModel");

                entity.Property(e => e.CModelKmu)
                    .HasMaxLength(256)
                    .HasColumnName("cModelKmu");

                entity.Property(e => e.CModification)
                    .HasMaxLength(256)
                    .HasColumnName("cModification");

                entity.Property(e => e.CMotoHours).HasColumnName("cMotoHours");

                entity.Property(e => e.cOriginDate)
                    .HasPrecision(2)
                    .HasColumnName("cOriginDate");

                entity.Property(e => e.COwnersCount).HasColumnName("cOwnersCount");

                entity.Property(e => e.CParsingDate)
                    .HasPrecision(2)
                    .HasColumnName("cParsingDate");

                entity.Property(e => e.CPower).HasColumnName("cPower");

                entity.Property(e => e.CPowerKvt).HasColumnName("cPowerKvt");

                entity.Property(e => e.CPowerWindow)
                    .HasMaxLength(256)
                    .HasColumnName("cPowerWindow");

                entity.Property(e => e.cPrice).HasColumnName("cPrice");

                entity.Property(e => e.CProductionYear).HasColumnName("cProductionYear");

                entity.Property(e => e.CPts)
                    .HasMaxLength(256)
                    .HasColumnName("cPts");

                entity.Property(e => e.CPtsOriginal).HasColumnName("cPtsOriginal");

                entity.Property(e => e.CPurchaseDate)
                    .HasPrecision(2)
                    .HasColumnName("cPurchaseDate");

                entity.Property(e => e.CRegion).HasColumnName("cRegion");

                entity.Property(e => e.CRegisteredInRussia).HasColumnName("cRegisteredInRussia");

                entity.Property(e => e.CRegisteredInRussiaString).HasColumnName("cRegisteredInRussiaString");

                entity.Property(e => e.CSalerId)
                    .HasMaxLength(256)
                    .HasColumnName("cSalerId");

                entity.Property(e => e.CSalerName)
                    .HasMaxLength(256)
                    .HasColumnName("cSalerName");

                entity.Property(e => e.CSalon)
                    .HasMaxLength(256)
                    .HasColumnName("cSalon");

                entity.Property(e => e.CSeries)
                    .HasMaxLength(256)
                    .HasColumnName("cSeries");

                entity.Property(e => e.CSource).HasColumnName("cSource");

                entity.Property(e => e.CSpeciality)
                    .HasMaxLength(256)
                    .HasColumnName("cSpeciality");

                entity.Property(e => e.CStateNotBeaten).HasColumnName("cStateNotBeaten");

                entity.Property(e => e.CSteeringPower)
                    .HasMaxLength(256)
                    .HasColumnName("cSteeringPower");

                entity.Property(e => e.CSteeringWheel).HasColumnName("cSteeringWheel");

                entity.Property(e => e.CSubType).HasColumnName("cSubType");

                entity.Property(e => e.CSubwayStations)
                    .HasMaxLength(1024)
                    .HasColumnName("cSubwayStations");

                entity.Property(e => e.CSubwayStationsDistances)
                    .HasMaxLength(1024)
                    .HasColumnName("cSubwayStationsDistances");

                entity.Property(e => e.CSuperGen)
                    .HasMaxLength(256)
                    .HasColumnName("cSuperGen");

                entity.Property(e => e.CSuspension)
                    .HasMaxLength(256)
                    .HasColumnName("cSuspension");

                entity.Property(e => e.CTitle)
                    .HasMaxLength(512)
                    .HasColumnName("cTitle");

                entity.Property(e => e.CTrailerType)
                    .HasMaxLength(256)
                    .HasColumnName("cTrailerType");

                entity.Property(e => e.CTransmissionName)
                    .HasMaxLength(256)
                    .HasColumnName("cTransmissionName");

                entity.Property(e => e.CTransmissionsType).HasColumnName("cTransmissionsType");

                entity.Property(e => e.CTrim)
                    .HasMaxLength(256)
                    .HasColumnName("cTrim");

                entity.Property(e => e.CType).HasColumnName("cType");

                entity.Property(e => e.CUpdateDate)
                    .HasPrecision(2)
                    .HasColumnName("cUpdateDate");

                entity.Property(e => e.CUrl).HasColumnName("cUrl");

                entity.Property(e => e.CVarietyType)
                    .HasMaxLength(256)
                    .HasColumnName("cVarietyType");

                entity.Property(e => e.CVendor)
                    .HasMaxLength(256)
                    .HasColumnName("cVendor");

                entity.Property(e => e.CVinResolution)
                    .HasMaxLength(256)
                    .HasColumnName("cVinResolution");

                entity.Property(e => e.CVinResolutionsType).HasColumnName("cVinResolutionsType");

                entity.Property(e => e.CWeelFormula)
                    .HasMaxLength(256)
                    .HasColumnName("cWeelFormula");

                entity.Property(e => e.CWithNds).HasColumnName("cWithNds");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
