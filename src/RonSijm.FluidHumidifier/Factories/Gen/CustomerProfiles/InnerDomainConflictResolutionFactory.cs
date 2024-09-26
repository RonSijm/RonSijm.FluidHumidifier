// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerDomainConflictResolutionFactory(Action<Humidifier.CustomerProfiles.DomainTypes.ConflictResolution> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.DomainTypes.ConflictResolution>
{

    protected override Humidifier.CustomerProfiles.DomainTypes.ConflictResolution Create()
    {
        var conflictResolutionResult = CreateConflictResolution();
        factoryAction?.Invoke(conflictResolutionResult);

        return conflictResolutionResult;
    }

    private Humidifier.CustomerProfiles.DomainTypes.ConflictResolution CreateConflictResolution()
    {
        var conflictResolutionResult = new Humidifier.CustomerProfiles.DomainTypes.ConflictResolution();

        return conflictResolutionResult;
    }

} // End Of Class

public static class InnerDomainConflictResolutionFactoryExtensions
{
}
