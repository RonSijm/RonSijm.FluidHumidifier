// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionPhysicalConnectionRequirementsFactory(Action<Humidifier.DataZone.ConnectionTypes.PhysicalConnectionRequirements> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.PhysicalConnectionRequirements>
{

    protected override Humidifier.DataZone.ConnectionTypes.PhysicalConnectionRequirements Create()
    {
        var physicalConnectionRequirementsResult = CreatePhysicalConnectionRequirements();
        factoryAction?.Invoke(physicalConnectionRequirementsResult);

        return physicalConnectionRequirementsResult;
    }

    private Humidifier.DataZone.ConnectionTypes.PhysicalConnectionRequirements CreatePhysicalConnectionRequirements()
    {
        var physicalConnectionRequirementsResult = new Humidifier.DataZone.ConnectionTypes.PhysicalConnectionRequirements();

        return physicalConnectionRequirementsResult;
    }

} // End Of Class

public static class InnerConnectionPhysicalConnectionRequirementsFactoryExtensions
{
}
