// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerConnectionPhysicalConnectionRequirementsFactory(Action<Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements>
{

    protected override Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements Create()
    {
        var physicalConnectionRequirementsResult = CreatePhysicalConnectionRequirements();
        factoryAction?.Invoke(physicalConnectionRequirementsResult);

        return physicalConnectionRequirementsResult;
    }

    private Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements CreatePhysicalConnectionRequirements()
    {
        var physicalConnectionRequirementsResult = new Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements();

        return physicalConnectionRequirementsResult;
    }

} // End Of Class

public static class InnerConnectionPhysicalConnectionRequirementsFactoryExtensions
{
}
