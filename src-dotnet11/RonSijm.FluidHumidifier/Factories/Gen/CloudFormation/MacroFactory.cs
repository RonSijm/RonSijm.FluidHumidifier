// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class MacroFactory(string resourceName = null, Action<Humidifier.CloudFormation.Macro> factoryAction = null) : ResourceFactory<Humidifier.CloudFormation.Macro>(resourceName)
{

    protected override Humidifier.CloudFormation.Macro Create()
    {
        var macroResult = CreateMacro();
        factoryAction?.Invoke(macroResult);

        return macroResult;
    }

    private Humidifier.CloudFormation.Macro CreateMacro()
    {
        var macroResult = new Humidifier.CloudFormation.Macro
        {
            GivenName = InputResourceName,
        };

        return macroResult;
    }

} // End Of Class

public static class MacroFactoryExtensions
{
}
