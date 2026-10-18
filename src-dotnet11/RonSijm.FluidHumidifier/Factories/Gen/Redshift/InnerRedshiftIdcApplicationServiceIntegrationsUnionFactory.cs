// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class InnerRedshiftIdcApplicationServiceIntegrationsUnionFactory(Action<Humidifier.Redshift.RedshiftIdcApplicationTypes.ServiceIntegrationsUnion> factoryAction = null) : SubResourceFactory<Humidifier.Redshift.RedshiftIdcApplicationTypes.ServiceIntegrationsUnion>
{

    protected override Humidifier.Redshift.RedshiftIdcApplicationTypes.ServiceIntegrationsUnion Create()
    {
        var serviceIntegrationsUnionResult = CreateServiceIntegrationsUnion();
        factoryAction?.Invoke(serviceIntegrationsUnionResult);

        return serviceIntegrationsUnionResult;
    }

    private Humidifier.Redshift.RedshiftIdcApplicationTypes.ServiceIntegrationsUnion CreateServiceIntegrationsUnion()
    {
        var serviceIntegrationsUnionResult = new Humidifier.Redshift.RedshiftIdcApplicationTypes.ServiceIntegrationsUnion();

        return serviceIntegrationsUnionResult;
    }

} // End Of Class

public static class InnerRedshiftIdcApplicationServiceIntegrationsUnionFactoryExtensions
{
}
