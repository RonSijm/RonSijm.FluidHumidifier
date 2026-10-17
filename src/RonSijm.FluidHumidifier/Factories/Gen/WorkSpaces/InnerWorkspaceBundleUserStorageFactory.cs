// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class InnerWorkspaceBundleUserStorageFactory(Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage>
{

    protected override Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage Create()
    {
        var userStorageResult = CreateUserStorage();
        factoryAction?.Invoke(userStorageResult);

        return userStorageResult;
    }

    private Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage CreateUserStorage()
    {
        var userStorageResult = new Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage();

        return userStorageResult;
    }

} // End Of Class

public static class InnerWorkspaceBundleUserStorageFactoryExtensions
{
}
