// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class InnerGlobalReplicationGroupGlobalReplicationGroupMemberFactory(Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember> factoryAction = null) : SubResourceFactory<Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember>
{

    protected override Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember Create()
    {
        var globalReplicationGroupMemberResult = CreateGlobalReplicationGroupMember();
        factoryAction?.Invoke(globalReplicationGroupMemberResult);

        return globalReplicationGroupMemberResult;
    }

    private Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember CreateGlobalReplicationGroupMember()
    {
        var globalReplicationGroupMemberResult = new Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember();

        return globalReplicationGroupMemberResult;
    }

} // End Of Class

public static class InnerGlobalReplicationGroupGlobalReplicationGroupMemberFactoryExtensions
{
}
