using Autofac;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore;
using TipMexico.DigitalYard.Infrastructure.Data;
using TipMexico.DigitalYard.Transversal.Common.SeedWork;
using TipMexico.DigitalYard.Application.Interface;
using TipMexico.DigitalYard.Application.Main;
using TipMexico.DigitalYard.Infrastructure.Interface;
using TipMexico.DigitalYard.Infrastructure.Repository;
using TipMexico.DigitalYard.Transversal.Common;

namespace TipMexico.DigitalYard.WebAPI.Extensions.AutofacModules
{
    public class DataAccessModule: Module
    {
        private readonly string _digitalYardConnectionString;

        public DataAccessModule(string digitalYardConnectionString)
        {
            _digitalYardConnectionString = digitalYardConnectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            #region Repositorys 
            builder.RegisterType<InspectionProcessRepository>().As<IInspectionProcessRepository>().InstancePerLifetimeScope();
            #endregion

            #region Database
            builder.RegisterType<ConnectionFactory>().As<IConnectionFactory>().InstancePerLifetimeScope();

            builder
            .Register(c =>
            {
                var dbContextOptionsBuilder = new DbContextOptionsBuilder<DigitalYardContext>();
                dbContextOptionsBuilder.UseOracle(_digitalYardConnectionString,b=> b.UseOracleSQLCompatibility("11"));
                dbContextOptionsBuilder
                    .ReplaceService<IValueConverterSelector, StronglyTypedIdValueConverterSelector>();

                return new DigitalYardContext(dbContextOptionsBuilder.Options);
            })
                .AsSelf()
                .As<DbContext>()
                .InstancePerDependency();

            #endregion
        }
    }
}
