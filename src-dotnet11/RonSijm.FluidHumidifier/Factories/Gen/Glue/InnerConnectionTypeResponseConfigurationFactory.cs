// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerConnectionTypeResponseConfigurationFactory(Action<Humidifier.Glue.ConnectionTypeTypes.ResponseConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ConnectionTypeTypes.ResponseConfiguration>
{

    protected override Humidifier.Glue.ConnectionTypeTypes.ResponseConfiguration Create()
    {
        var responseConfigurationResult = CreateResponseConfiguration();
        factoryAction?.Invoke(responseConfigurationResult);

        return responseConfigurationResult;
    }

    private Humidifier.Glue.ConnectionTypeTypes.ResponseConfiguration CreateResponseConfiguration()
    {
        var responseConfigurationResult = new Humidifier.Glue.ConnectionTypeTypes.ResponseConfiguration();

        return responseConfigurationResult;
    }

} // End Of Class

public static class InnerConnectionTypeResponseConfigurationFactoryExtensions
{
}
