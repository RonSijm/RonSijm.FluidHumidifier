// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class InnerWorkspaceBundleComputeTypeFactory(Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType>
{

    protected override Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType Create()
    {
        var computeTypeResult = CreateComputeType();
        factoryAction?.Invoke(computeTypeResult);

        return computeTypeResult;
    }

    private Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType CreateComputeType()
    {
        var computeTypeResult = new Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType();

        return computeTypeResult;
    }

} // End Of Class

public static class InnerWorkspaceBundleComputeTypeFactoryExtensions
{
}
