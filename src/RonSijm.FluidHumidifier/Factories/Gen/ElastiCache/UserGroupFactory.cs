// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class UserGroupFactory(string resourceName = null, Action<Humidifier.ElastiCache.UserGroup> factoryAction = null) : ResourceFactory<Humidifier.ElastiCache.UserGroup>(resourceName)
{

    protected override Humidifier.ElastiCache.UserGroup Create()
    {
        var userGroupResult = CreateUserGroup();
        factoryAction?.Invoke(userGroupResult);

        return userGroupResult;
    }

    private Humidifier.ElastiCache.UserGroup CreateUserGroup()
    {
        var userGroupResult = new Humidifier.ElastiCache.UserGroup
        {
            GivenName = InputResourceName,
        };

        return userGroupResult;
    }

} // End Of Class

public static class UserGroupFactoryExtensions
{
}
