// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerFunctionDurableConfigFactory(Action<Humidifier.Lambda.FunctionTypes.DurableConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.FunctionTypes.DurableConfig>
{

    protected override Humidifier.Lambda.FunctionTypes.DurableConfig Create()
    {
        var durableConfigResult = CreateDurableConfig();
        factoryAction?.Invoke(durableConfigResult);

        return durableConfigResult;
    }

    private Humidifier.Lambda.FunctionTypes.DurableConfig CreateDurableConfig()
    {
        var durableConfigResult = new Humidifier.Lambda.FunctionTypes.DurableConfig();

        return durableConfigResult;
    }

} // End Of Class

public static class InnerFunctionDurableConfigFactoryExtensions
{
}
