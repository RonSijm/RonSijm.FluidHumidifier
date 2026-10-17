// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerConnectionTypeValidationEndpointConfigurationFactory(Action<Humidifier.Glue.ConnectionTypeTypes.ValidationEndpointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ConnectionTypeTypes.ValidationEndpointConfiguration>
{

    protected override Humidifier.Glue.ConnectionTypeTypes.ValidationEndpointConfiguration Create()
    {
        var validationEndpointConfigurationResult = CreateValidationEndpointConfiguration();
        factoryAction?.Invoke(validationEndpointConfigurationResult);

        return validationEndpointConfigurationResult;
    }

    private Humidifier.Glue.ConnectionTypeTypes.ValidationEndpointConfiguration CreateValidationEndpointConfiguration()
    {
        var validationEndpointConfigurationResult = new Humidifier.Glue.ConnectionTypeTypes.ValidationEndpointConfiguration();

        return validationEndpointConfigurationResult;
    }

} // End Of Class

public static class InnerConnectionTypeValidationEndpointConfigurationFactoryExtensions
{
}
