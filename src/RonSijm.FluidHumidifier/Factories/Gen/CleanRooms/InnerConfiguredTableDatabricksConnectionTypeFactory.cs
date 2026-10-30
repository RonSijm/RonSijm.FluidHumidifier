// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerConfiguredTableDatabricksConnectionTypeFactory(Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType>
{

    internal InnerConfiguredTableDatabricksDeltaSharingConnectionFactory DeltaSharingFactory { get; set; }

    protected override Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType Create()
    {
        var databricksConnectionTypeResult = CreateDatabricksConnectionType();
        factoryAction?.Invoke(databricksConnectionTypeResult);

        return databricksConnectionTypeResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType CreateDatabricksConnectionType()
    {
        var databricksConnectionTypeResult = new Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType();

        return databricksConnectionTypeResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType result)
    {
        base.CreateChildren(result);

        result.DeltaSharing ??= DeltaSharingFactory?.Build();
    }

} // End Of Class

public static class InnerConfiguredTableDatabricksConnectionTypeFactoryExtensions
{
    public static CombinedResult<InnerConfiguredTableDatabricksConnectionTypeFactory, InnerConfiguredTableDatabricksDeltaSharingConnectionFactory> WithDeltaSharing(this InnerConfiguredTableDatabricksConnectionTypeFactory parentFactory, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksDeltaSharingConnection> subFactoryAction = null)
    {
        parentFactory.DeltaSharingFactory = new InnerConfiguredTableDatabricksDeltaSharingConnectionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeltaSharingFactory);
    }

    public static CombinedResult<InnerConfiguredTableDatabricksConnectionTypeFactory, T1, InnerConfiguredTableDatabricksDeltaSharingConnectionFactory> WithDeltaSharing<T1>(this CombinedResult<InnerConfiguredTableDatabricksConnectionTypeFactory, T1> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksDeltaSharingConnection> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeltaSharing(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfiguredTableDatabricksConnectionTypeFactory, InnerConfiguredTableDatabricksDeltaSharingConnectionFactory> WithDeltaSharing<T1>(this CombinedResult<T1, InnerConfiguredTableDatabricksConnectionTypeFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksDeltaSharingConnection> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeltaSharing(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConfiguredTableDatabricksConnectionTypeFactory, T1, T2, InnerConfiguredTableDatabricksDeltaSharingConnectionFactory> WithDeltaSharing<T1, T2>(this CombinedResult<InnerConfiguredTableDatabricksConnectionTypeFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksDeltaSharingConnection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeltaSharing(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfiguredTableDatabricksConnectionTypeFactory, T2, InnerConfiguredTableDatabricksDeltaSharingConnectionFactory> WithDeltaSharing<T1, T2>(this CombinedResult<T1, InnerConfiguredTableDatabricksConnectionTypeFactory, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksDeltaSharingConnection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeltaSharing(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfiguredTableDatabricksConnectionTypeFactory, InnerConfiguredTableDatabricksDeltaSharingConnectionFactory> WithDeltaSharing<T1, T2>(this CombinedResult<T1, T2, InnerConfiguredTableDatabricksConnectionTypeFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksDeltaSharingConnection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeltaSharing(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConfiguredTableDatabricksConnectionTypeFactory, T1, T2, T3, InnerConfiguredTableDatabricksDeltaSharingConnectionFactory> WithDeltaSharing<T1, T2, T3>(this CombinedResult<InnerConfiguredTableDatabricksConnectionTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksDeltaSharingConnection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaSharing(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfiguredTableDatabricksConnectionTypeFactory, T2, T3, InnerConfiguredTableDatabricksDeltaSharingConnectionFactory> WithDeltaSharing<T1, T2, T3>(this CombinedResult<T1, InnerConfiguredTableDatabricksConnectionTypeFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksDeltaSharingConnection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaSharing(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfiguredTableDatabricksConnectionTypeFactory, T3, InnerConfiguredTableDatabricksDeltaSharingConnectionFactory> WithDeltaSharing<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfiguredTableDatabricksConnectionTypeFactory, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksDeltaSharingConnection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaSharing(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConfiguredTableDatabricksConnectionTypeFactory, InnerConfiguredTableDatabricksDeltaSharingConnectionFactory> WithDeltaSharing<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfiguredTableDatabricksConnectionTypeFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksDeltaSharingConnection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaSharing(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConfiguredTableDatabricksConnectionTypeFactory, T1, T2, T3, T4, InnerConfiguredTableDatabricksDeltaSharingConnectionFactory> WithDeltaSharing<T1, T2, T3, T4>(this CombinedResult<InnerConfiguredTableDatabricksConnectionTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksDeltaSharingConnection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaSharing(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfiguredTableDatabricksConnectionTypeFactory, T2, T3, T4, InnerConfiguredTableDatabricksDeltaSharingConnectionFactory> WithDeltaSharing<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfiguredTableDatabricksConnectionTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksDeltaSharingConnection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaSharing(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfiguredTableDatabricksConnectionTypeFactory, T3, T4, InnerConfiguredTableDatabricksDeltaSharingConnectionFactory> WithDeltaSharing<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfiguredTableDatabricksConnectionTypeFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksDeltaSharingConnection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaSharing(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConfiguredTableDatabricksConnectionTypeFactory, T4, InnerConfiguredTableDatabricksDeltaSharingConnectionFactory> WithDeltaSharing<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfiguredTableDatabricksConnectionTypeFactory, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksDeltaSharingConnection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaSharing(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConfiguredTableDatabricksConnectionTypeFactory, InnerConfiguredTableDatabricksDeltaSharingConnectionFactory> WithDeltaSharing<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfiguredTableDatabricksConnectionTypeFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksDeltaSharingConnection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaSharing(combinedResult.T5, subFactoryAction).T2);
}
