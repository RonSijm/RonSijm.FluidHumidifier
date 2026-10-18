// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerFunctionTenancyConfigFactory(Action<Humidifier.Lambda.FunctionTypes.TenancyConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.FunctionTypes.TenancyConfig>
{

    protected override Humidifier.Lambda.FunctionTypes.TenancyConfig Create()
    {
        var tenancyConfigResult = CreateTenancyConfig();
        factoryAction?.Invoke(tenancyConfigResult);

        return tenancyConfigResult;
    }

    private Humidifier.Lambda.FunctionTypes.TenancyConfig CreateTenancyConfig()
    {
        var tenancyConfigResult = new Humidifier.Lambda.FunctionTypes.TenancyConfig();

        return tenancyConfigResult;
    }

} // End Of Class

public static class InnerFunctionTenancyConfigFactoryExtensions
{
}
