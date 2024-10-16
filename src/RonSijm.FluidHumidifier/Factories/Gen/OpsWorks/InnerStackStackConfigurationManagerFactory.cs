// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class InnerStackStackConfigurationManagerFactory(Action<Humidifier.OpsWorks.StackTypes.StackConfigurationManager> factoryAction = null) : SubResourceFactory<Humidifier.OpsWorks.StackTypes.StackConfigurationManager>
{

    protected override Humidifier.OpsWorks.StackTypes.StackConfigurationManager Create()
    {
        var stackConfigurationManagerResult = CreateStackConfigurationManager();
        factoryAction?.Invoke(stackConfigurationManagerResult);

        return stackConfigurationManagerResult;
    }

    private Humidifier.OpsWorks.StackTypes.StackConfigurationManager CreateStackConfigurationManager()
    {
        var stackConfigurationManagerResult = new Humidifier.OpsWorks.StackTypes.StackConfigurationManager();

        return stackConfigurationManagerResult;
    }

} // End Of Class

public static class InnerStackStackConfigurationManagerFactoryExtensions
{
}
