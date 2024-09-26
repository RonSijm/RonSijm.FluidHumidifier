// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerFunctionDefinitionVersionRunAsFactory(Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs>
{

    protected override Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs Create()
    {
        var runAsResult = CreateRunAs();
        factoryAction?.Invoke(runAsResult);

        return runAsResult;
    }

    private Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs CreateRunAs()
    {
        var runAsResult = new Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs();

        return runAsResult;
    }

} // End Of Class

public static class InnerFunctionDefinitionVersionRunAsFactoryExtensions
{
}
