// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class VirtualGatewayFactory(string resourceName = null, Action<Humidifier.AppMesh.VirtualGateway> factoryAction = null) : ResourceFactory<Humidifier.AppMesh.VirtualGateway>(resourceName)
{

    internal InnerVirtualGatewayVirtualGatewaySpecFactory SpecFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualGateway Create()
    {
        var virtualGatewayResult = CreateVirtualGateway();
        factoryAction?.Invoke(virtualGatewayResult);

        return virtualGatewayResult;
    }

    private Humidifier.AppMesh.VirtualGateway CreateVirtualGateway()
    {
        var virtualGatewayResult = new Humidifier.AppMesh.VirtualGateway
        {
            GivenName = InputResourceName,
        };

        return virtualGatewayResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualGateway result)
    {
        base.CreateChildren(result);

        result.Spec ??= SpecFactory?.Build();
    }

} // End Of Class

public static class VirtualGatewayFactoryExtensions
{
    public static CombinedResult<VirtualGatewayFactory, InnerVirtualGatewayVirtualGatewaySpecFactory> WithSpec(this VirtualGatewayFactory parentFactory, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewaySpec> subFactoryAction = null)
    {
        parentFactory.SpecFactory = new InnerVirtualGatewayVirtualGatewaySpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpecFactory);
    }

    public static CombinedResult<VirtualGatewayFactory, T1, InnerVirtualGatewayVirtualGatewaySpecFactory> WithSpec<T1>(this CombinedResult<VirtualGatewayFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewaySpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VirtualGatewayFactory, InnerVirtualGatewayVirtualGatewaySpecFactory> WithSpec<T1>(this CombinedResult<T1, VirtualGatewayFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewaySpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<VirtualGatewayFactory, T1, T2, InnerVirtualGatewayVirtualGatewaySpecFactory> WithSpec<T1, T2>(this CombinedResult<VirtualGatewayFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewaySpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VirtualGatewayFactory, T2, InnerVirtualGatewayVirtualGatewaySpecFactory> WithSpec<T1, T2>(this CombinedResult<T1, VirtualGatewayFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewaySpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VirtualGatewayFactory, InnerVirtualGatewayVirtualGatewaySpecFactory> WithSpec<T1, T2>(this CombinedResult<T1, T2, VirtualGatewayFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewaySpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<VirtualGatewayFactory, T1, T2, T3, InnerVirtualGatewayVirtualGatewaySpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<VirtualGatewayFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewaySpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VirtualGatewayFactory, T2, T3, InnerVirtualGatewayVirtualGatewaySpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, VirtualGatewayFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewaySpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VirtualGatewayFactory, T3, InnerVirtualGatewayVirtualGatewaySpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, T2, VirtualGatewayFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewaySpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VirtualGatewayFactory, InnerVirtualGatewayVirtualGatewaySpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, VirtualGatewayFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewaySpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<VirtualGatewayFactory, T1, T2, T3, T4, InnerVirtualGatewayVirtualGatewaySpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<VirtualGatewayFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewaySpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VirtualGatewayFactory, T2, T3, T4, InnerVirtualGatewayVirtualGatewaySpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, VirtualGatewayFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewaySpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VirtualGatewayFactory, T3, T4, InnerVirtualGatewayVirtualGatewaySpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, VirtualGatewayFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewaySpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VirtualGatewayFactory, T4, InnerVirtualGatewayVirtualGatewaySpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VirtualGatewayFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewaySpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, VirtualGatewayFactory, InnerVirtualGatewayVirtualGatewaySpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VirtualGatewayFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewaySpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T5, subFactoryAction));
}
