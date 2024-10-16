// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerFunctionDeadLetterConfigFactory(Action<Humidifier.Lambda.FunctionTypes.DeadLetterConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.FunctionTypes.DeadLetterConfig>
{

    protected override Humidifier.Lambda.FunctionTypes.DeadLetterConfig Create()
    {
        var deadLetterConfigResult = CreateDeadLetterConfig();
        factoryAction?.Invoke(deadLetterConfigResult);

        return deadLetterConfigResult;
    }

    private Humidifier.Lambda.FunctionTypes.DeadLetterConfig CreateDeadLetterConfig()
    {
        var deadLetterConfigResult = new Humidifier.Lambda.FunctionTypes.DeadLetterConfig();

        return deadLetterConfigResult;
    }

} // End Of Class

public static class InnerFunctionDeadLetterConfigFactoryExtensions
{
}
