// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerServiceLevelObjectiveDependencyConfigFactory(Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.DependencyConfig> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.DependencyConfig>
{

    protected override Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.DependencyConfig Create()
    {
        var dependencyConfigResult = CreateDependencyConfig();
        factoryAction?.Invoke(dependencyConfigResult);

        return dependencyConfigResult;
    }

    private Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.DependencyConfig CreateDependencyConfig()
    {
        var dependencyConfigResult = new Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.DependencyConfig();

        return dependencyConfigResult;
    }

} // End Of Class

public static class InnerServiceLevelObjectiveDependencyConfigFactoryExtensions
{
}
