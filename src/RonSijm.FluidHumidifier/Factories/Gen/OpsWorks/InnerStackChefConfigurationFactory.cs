// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class InnerStackChefConfigurationFactory(Action<Humidifier.OpsWorks.StackTypes.ChefConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.OpsWorks.StackTypes.ChefConfiguration>
{

    protected override Humidifier.OpsWorks.StackTypes.ChefConfiguration Create()
    {
        var chefConfigurationResult = CreateChefConfiguration();
        factoryAction?.Invoke(chefConfigurationResult);

        return chefConfigurationResult;
    }

    private Humidifier.OpsWorks.StackTypes.ChefConfiguration CreateChefConfiguration()
    {
        var chefConfigurationResult = new Humidifier.OpsWorks.StackTypes.ChefConfiguration();

        return chefConfigurationResult;
    }

} // End Of Class

public static class InnerStackChefConfigurationFactoryExtensions
{
}
