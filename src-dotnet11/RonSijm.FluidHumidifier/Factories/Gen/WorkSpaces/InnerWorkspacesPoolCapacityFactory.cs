// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class InnerWorkspacesPoolCapacityFactory(Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity>
{

    protected override Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity Create()
    {
        var capacityResult = CreateCapacity();
        factoryAction?.Invoke(capacityResult);

        return capacityResult;
    }

    private Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity CreateCapacity()
    {
        var capacityResult = new Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity();

        return capacityResult;
    }

} // End Of Class

public static class InnerWorkspacesPoolCapacityFactoryExtensions
{
}
