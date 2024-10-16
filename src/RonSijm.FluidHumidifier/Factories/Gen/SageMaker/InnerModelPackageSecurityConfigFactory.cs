// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelPackageSecurityConfigFactory(Action<Humidifier.SageMaker.ModelPackageTypes.SecurityConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelPackageTypes.SecurityConfig>
{

    protected override Humidifier.SageMaker.ModelPackageTypes.SecurityConfig Create()
    {
        var securityConfigResult = CreateSecurityConfig();
        factoryAction?.Invoke(securityConfigResult);

        return securityConfigResult;
    }

    private Humidifier.SageMaker.ModelPackageTypes.SecurityConfig CreateSecurityConfig()
    {
        var securityConfigResult = new Humidifier.SageMaker.ModelPackageTypes.SecurityConfig();

        return securityConfigResult;
    }

} // End Of Class

public static class InnerModelPackageSecurityConfigFactoryExtensions
{
}
