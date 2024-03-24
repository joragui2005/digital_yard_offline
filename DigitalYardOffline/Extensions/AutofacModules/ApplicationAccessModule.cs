using Autofac; 
using TipMexico.DigitalYard.Application.Interface;
using TipMexico.DigitalYard.Application.Main;
using TipMexico.DigitalYard.Infrastructure.Data;

namespace TipMexico.DigitalYard.WebAPI.Extensions.AutofacModules
{
    public class ApplicationAccessModule: Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<InspectionProcessApplication>().As<IInspectionProcessApplication>().InstancePerLifetimeScope();
        }
    }
}
