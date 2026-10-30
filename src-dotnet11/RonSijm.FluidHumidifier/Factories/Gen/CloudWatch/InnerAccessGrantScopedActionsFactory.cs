// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAccessGrantScopedActionsFactory(Action<Humidifier.CloudWatch.AccessGrantTypes.ScopedActions> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AccessGrantTypes.ScopedActions>
{

    protected override Humidifier.CloudWatch.AccessGrantTypes.ScopedActions Create()
    {
        var scopedActionsResult = CreateScopedActions();
        factoryAction?.Invoke(scopedActionsResult);

        return scopedActionsResult;
    }

    private Humidifier.CloudWatch.AccessGrantTypes.ScopedActions CreateScopedActions()
    {
        var scopedActionsResult = new Humidifier.CloudWatch.AccessGrantTypes.ScopedActions();

        return scopedActionsResult;
    }

} // End Of Class

public static class InnerAccessGrantScopedActionsFactoryExtensions
{
}
