// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelCardSecurityConfigFactory(Action<Humidifier.SageMaker.ModelCardTypes.SecurityConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelCardTypes.SecurityConfig>
{

    protected override Humidifier.SageMaker.ModelCardTypes.SecurityConfig Create()
    {
        var securityConfigResult = CreateSecurityConfig();
        factoryAction?.Invoke(securityConfigResult);

        return securityConfigResult;
    }

    private Humidifier.SageMaker.ModelCardTypes.SecurityConfig CreateSecurityConfig()
    {
        var securityConfigResult = new Humidifier.SageMaker.ModelCardTypes.SecurityConfig();

        return securityConfigResult;
    }

} // End Of Class

public static class InnerModelCardSecurityConfigFactoryExtensions
{
}
