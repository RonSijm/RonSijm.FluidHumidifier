// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerFunctionDefinitionRunAsFactory(Action<Humidifier.Greengrass.FunctionDefinitionTypes.RunAs> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.FunctionDefinitionTypes.RunAs>
{

    protected override Humidifier.Greengrass.FunctionDefinitionTypes.RunAs Create()
    {
        var runAsResult = CreateRunAs();
        factoryAction?.Invoke(runAsResult);

        return runAsResult;
    }

    private Humidifier.Greengrass.FunctionDefinitionTypes.RunAs CreateRunAs()
    {
        var runAsResult = new Humidifier.Greengrass.FunctionDefinitionTypes.RunAs();

        return runAsResult;
    }

} // End Of Class

public static class InnerFunctionDefinitionRunAsFactoryExtensions
{
}
