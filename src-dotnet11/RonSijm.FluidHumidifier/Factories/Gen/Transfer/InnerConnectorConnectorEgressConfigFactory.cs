// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerConnectorConnectorEgressConfigFactory(Action<Humidifier.Transfer.ConnectorTypes.ConnectorEgressConfig> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.ConnectorTypes.ConnectorEgressConfig>
{

    internal InnerConnectorConnectorVpcLatticeEgressConfigFactory VpcLatticeFactory { get; set; }

    protected override Humidifier.Transfer.ConnectorTypes.ConnectorEgressConfig Create()
    {
        var connectorEgressConfigResult = CreateConnectorEgressConfig();
        factoryAction?.Invoke(connectorEgressConfigResult);

        return connectorEgressConfigResult;
    }

    private Humidifier.Transfer.ConnectorTypes.ConnectorEgressConfig CreateConnectorEgressConfig()
    {
        var connectorEgressConfigResult = new Humidifier.Transfer.ConnectorTypes.ConnectorEgressConfig();

        return connectorEgressConfigResult;
    }
    public override void CreateChildren(Humidifier.Transfer.ConnectorTypes.ConnectorEgressConfig result)
    {
        base.CreateChildren(result);

        result.VpcLattice ??= VpcLatticeFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorConnectorEgressConfigFactoryExtensions
{
    public static CombinedResult<InnerConnectorConnectorEgressConfigFactory, InnerConnectorConnectorVpcLatticeEgressConfigFactory> WithVpcLattice(this InnerConnectorConnectorEgressConfigFactory parentFactory, Action<Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig> subFactoryAction = null)
    {
        parentFactory.VpcLatticeFactory = new InnerConnectorConnectorVpcLatticeEgressConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcLatticeFactory);
    }

    public static CombinedResult<InnerConnectorConnectorEgressConfigFactory, T1, InnerConnectorConnectorVpcLatticeEgressConfigFactory> WithVpcLattice<T1>(this CombinedResult<InnerConnectorConnectorEgressConfigFactory, T1> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcLattice(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorConnectorEgressConfigFactory, InnerConnectorConnectorVpcLatticeEgressConfigFactory> WithVpcLattice<T1>(this CombinedResult<T1, InnerConnectorConnectorEgressConfigFactory> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcLattice(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorConnectorEgressConfigFactory, T1, T2, InnerConnectorConnectorVpcLatticeEgressConfigFactory> WithVpcLattice<T1, T2>(this CombinedResult<InnerConnectorConnectorEgressConfigFactory, T1, T2> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcLattice(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorConnectorEgressConfigFactory, T2, InnerConnectorConnectorVpcLatticeEgressConfigFactory> WithVpcLattice<T1, T2>(this CombinedResult<T1, InnerConnectorConnectorEgressConfigFactory, T2> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcLattice(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorConnectorEgressConfigFactory, InnerConnectorConnectorVpcLatticeEgressConfigFactory> WithVpcLattice<T1, T2>(this CombinedResult<T1, T2, InnerConnectorConnectorEgressConfigFactory> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcLattice(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorConnectorEgressConfigFactory, T1, T2, T3, InnerConnectorConnectorVpcLatticeEgressConfigFactory> WithVpcLattice<T1, T2, T3>(this CombinedResult<InnerConnectorConnectorEgressConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcLattice(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorConnectorEgressConfigFactory, T2, T3, InnerConnectorConnectorVpcLatticeEgressConfigFactory> WithVpcLattice<T1, T2, T3>(this CombinedResult<T1, InnerConnectorConnectorEgressConfigFactory, T2, T3> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcLattice(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorConnectorEgressConfigFactory, T3, InnerConnectorConnectorVpcLatticeEgressConfigFactory> WithVpcLattice<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorConnectorEgressConfigFactory, T3> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcLattice(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectorConnectorEgressConfigFactory, InnerConnectorConnectorVpcLatticeEgressConfigFactory> WithVpcLattice<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorConnectorEgressConfigFactory> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcLattice(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorConnectorEgressConfigFactory, T1, T2, T3, T4, InnerConnectorConnectorVpcLatticeEgressConfigFactory> WithVpcLattice<T1, T2, T3, T4>(this CombinedResult<InnerConnectorConnectorEgressConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcLattice(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorConnectorEgressConfigFactory, T2, T3, T4, InnerConnectorConnectorVpcLatticeEgressConfigFactory> WithVpcLattice<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorConnectorEgressConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcLattice(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorConnectorEgressConfigFactory, T3, T4, InnerConnectorConnectorVpcLatticeEgressConfigFactory> WithVpcLattice<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorConnectorEgressConfigFactory, T3, T4> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcLattice(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectorConnectorEgressConfigFactory, T4, InnerConnectorConnectorVpcLatticeEgressConfigFactory> WithVpcLattice<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorConnectorEgressConfigFactory, T4> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcLattice(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorConnectorEgressConfigFactory, InnerConnectorConnectorVpcLatticeEgressConfigFactory> WithVpcLattice<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorConnectorEgressConfigFactory> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorVpcLatticeEgressConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcLattice(combinedResult.T5, subFactoryAction).T2);
}
