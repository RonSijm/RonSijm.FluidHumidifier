// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerFunctionCustomOutputConfigurationFactory(Action<Humidifier.MediaTailor.FunctionTypes.CustomOutputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.FunctionTypes.CustomOutputConfiguration>
{

    protected override Humidifier.MediaTailor.FunctionTypes.CustomOutputConfiguration Create()
    {
        var customOutputConfigurationResult = CreateCustomOutputConfiguration();
        factoryAction?.Invoke(customOutputConfigurationResult);

        return customOutputConfigurationResult;
    }

    private Humidifier.MediaTailor.FunctionTypes.CustomOutputConfiguration CreateCustomOutputConfiguration()
    {
        var customOutputConfigurationResult = new Humidifier.MediaTailor.FunctionTypes.CustomOutputConfiguration();

        return customOutputConfigurationResult;
    }

} // End Of Class

public static class InnerFunctionCustomOutputConfigurationFactoryExtensions
{
}
