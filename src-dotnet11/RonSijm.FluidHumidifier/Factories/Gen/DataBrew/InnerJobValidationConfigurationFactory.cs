// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerJobValidationConfigurationFactory(Action<Humidifier.DataBrew.JobTypes.ValidationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.JobTypes.ValidationConfiguration>
{

    protected override Humidifier.DataBrew.JobTypes.ValidationConfiguration Create()
    {
        var validationConfigurationResult = CreateValidationConfiguration();
        factoryAction?.Invoke(validationConfigurationResult);

        return validationConfigurationResult;
    }

    private Humidifier.DataBrew.JobTypes.ValidationConfiguration CreateValidationConfiguration()
    {
        var validationConfigurationResult = new Humidifier.DataBrew.JobTypes.ValidationConfiguration();

        return validationConfigurationResult;
    }

} // End Of Class

public static class InnerJobValidationConfigurationFactoryExtensions
{
}
