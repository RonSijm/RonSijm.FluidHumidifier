// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionTenantParameterFactory(Action<Humidifier.CloudFront.DistributionTenantTypes.Parameter> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTenantTypes.Parameter>
{

    protected override Humidifier.CloudFront.DistributionTenantTypes.Parameter Create()
    {
        var parameterResult = CreateParameter();
        factoryAction?.Invoke(parameterResult);

        return parameterResult;
    }

    private Humidifier.CloudFront.DistributionTenantTypes.Parameter CreateParameter()
    {
        var parameterResult = new Humidifier.CloudFront.DistributionTenantTypes.Parameter();

        return parameterResult;
    }

} // End Of Class

public static class InnerDistributionTenantParameterFactoryExtensions
{
}
