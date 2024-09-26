// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerConfigurationRecorderExclusionByResourceTypesFactory(Action<Humidifier.Config.ConfigurationRecorderTypes.ExclusionByResourceTypes> factoryAction = null) : SubResourceFactory<Humidifier.Config.ConfigurationRecorderTypes.ExclusionByResourceTypes>
{

    protected override Humidifier.Config.ConfigurationRecorderTypes.ExclusionByResourceTypes Create()
    {
        var exclusionByResourceTypesResult = CreateExclusionByResourceTypes();
        factoryAction?.Invoke(exclusionByResourceTypesResult);

        return exclusionByResourceTypesResult;
    }

    private Humidifier.Config.ConfigurationRecorderTypes.ExclusionByResourceTypes CreateExclusionByResourceTypes()
    {
        var exclusionByResourceTypesResult = new Humidifier.Config.ConfigurationRecorderTypes.ExclusionByResourceTypes();

        return exclusionByResourceTypesResult;
    }

} // End Of Class

public static class InnerConfigurationRecorderExclusionByResourceTypesFactoryExtensions
{
}
