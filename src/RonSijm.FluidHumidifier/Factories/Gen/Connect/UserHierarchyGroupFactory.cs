// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class UserHierarchyGroupFactory(string resourceName = null, Action<Humidifier.Connect.UserHierarchyGroup> factoryAction = null) : ResourceFactory<Humidifier.Connect.UserHierarchyGroup>(resourceName)
{

    protected override Humidifier.Connect.UserHierarchyGroup Create()
    {
        var userHierarchyGroupResult = CreateUserHierarchyGroup();
        factoryAction?.Invoke(userHierarchyGroupResult);

        return userHierarchyGroupResult;
    }

    private Humidifier.Connect.UserHierarchyGroup CreateUserHierarchyGroup()
    {
        var userHierarchyGroupResult = new Humidifier.Connect.UserHierarchyGroup
        {
            GivenName = InputResourceName,
        };

        return userHierarchyGroupResult;
    }

} // End Of Class

public static class UserHierarchyGroupFactoryExtensions
{
}
