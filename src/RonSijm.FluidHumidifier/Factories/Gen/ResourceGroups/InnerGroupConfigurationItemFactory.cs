// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResourceGroups;

public class InnerGroupConfigurationItemFactory(Action<Humidifier.ResourceGroups.GroupTypes.ConfigurationItem> factoryAction = null) : SubResourceFactory<Humidifier.ResourceGroups.GroupTypes.ConfigurationItem>
{

    protected override Humidifier.ResourceGroups.GroupTypes.ConfigurationItem Create()
    {
        var configurationItemResult = CreateConfigurationItem();
        factoryAction?.Invoke(configurationItemResult);

        return configurationItemResult;
    }

    private Humidifier.ResourceGroups.GroupTypes.ConfigurationItem CreateConfigurationItem()
    {
        var configurationItemResult = new Humidifier.ResourceGroups.GroupTypes.ConfigurationItem();

        return configurationItemResult;
    }

} // End Of Class

public static class InnerGroupConfigurationItemFactoryExtensions
{
}
