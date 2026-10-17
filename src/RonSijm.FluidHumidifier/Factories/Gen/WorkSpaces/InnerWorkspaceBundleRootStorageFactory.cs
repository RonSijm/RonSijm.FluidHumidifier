// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class InnerWorkspaceBundleRootStorageFactory(Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage>
{

    protected override Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage Create()
    {
        var rootStorageResult = CreateRootStorage();
        factoryAction?.Invoke(rootStorageResult);

        return rootStorageResult;
    }

    private Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage CreateRootStorage()
    {
        var rootStorageResult = new Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage();

        return rootStorageResult;
    }

} // End Of Class

public static class InnerWorkspaceBundleRootStorageFactoryExtensions
{
}
