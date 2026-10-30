// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerConfiguredTableDatabricksTableReferenceFactory(Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksTableReference> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksTableReference>
{

    internal InnerConfiguredTableDatabricksConnectionTypeFactory ConnectionTypeFactory { get; set; }

    protected override Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksTableReference Create()
    {
        var databricksTableReferenceResult = CreateDatabricksTableReference();
        factoryAction?.Invoke(databricksTableReferenceResult);

        return databricksTableReferenceResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksTableReference CreateDatabricksTableReference()
    {
        var databricksTableReferenceResult = new Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksTableReference();

        return databricksTableReferenceResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksTableReference result)
    {
        base.CreateChildren(result);

        result.ConnectionType ??= ConnectionTypeFactory?.Build();
    }

} // End Of Class

public static class InnerConfiguredTableDatabricksTableReferenceFactoryExtensions
{
    public static CombinedResult<InnerConfiguredTableDatabricksTableReferenceFactory, InnerConfiguredTableDatabricksConnectionTypeFactory> WithConnectionType(this InnerConfiguredTableDatabricksTableReferenceFactory parentFactory, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType> subFactoryAction = null)
    {
        parentFactory.ConnectionTypeFactory = new InnerConfiguredTableDatabricksConnectionTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConnectionTypeFactory);
    }

    public static CombinedResult<InnerConfiguredTableDatabricksTableReferenceFactory, T1, InnerConfiguredTableDatabricksConnectionTypeFactory> WithConnectionType<T1>(this CombinedResult<InnerConfiguredTableDatabricksTableReferenceFactory, T1> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectionType(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfiguredTableDatabricksTableReferenceFactory, InnerConfiguredTableDatabricksConnectionTypeFactory> WithConnectionType<T1>(this CombinedResult<T1, InnerConfiguredTableDatabricksTableReferenceFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectionType(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConfiguredTableDatabricksTableReferenceFactory, T1, T2, InnerConfiguredTableDatabricksConnectionTypeFactory> WithConnectionType<T1, T2>(this CombinedResult<InnerConfiguredTableDatabricksTableReferenceFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionType(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfiguredTableDatabricksTableReferenceFactory, T2, InnerConfiguredTableDatabricksConnectionTypeFactory> WithConnectionType<T1, T2>(this CombinedResult<T1, InnerConfiguredTableDatabricksTableReferenceFactory, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionType(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfiguredTableDatabricksTableReferenceFactory, InnerConfiguredTableDatabricksConnectionTypeFactory> WithConnectionType<T1, T2>(this CombinedResult<T1, T2, InnerConfiguredTableDatabricksTableReferenceFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionType(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConfiguredTableDatabricksTableReferenceFactory, T1, T2, T3, InnerConfiguredTableDatabricksConnectionTypeFactory> WithConnectionType<T1, T2, T3>(this CombinedResult<InnerConfiguredTableDatabricksTableReferenceFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionType(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfiguredTableDatabricksTableReferenceFactory, T2, T3, InnerConfiguredTableDatabricksConnectionTypeFactory> WithConnectionType<T1, T2, T3>(this CombinedResult<T1, InnerConfiguredTableDatabricksTableReferenceFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionType(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfiguredTableDatabricksTableReferenceFactory, T3, InnerConfiguredTableDatabricksConnectionTypeFactory> WithConnectionType<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfiguredTableDatabricksTableReferenceFactory, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionType(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConfiguredTableDatabricksTableReferenceFactory, InnerConfiguredTableDatabricksConnectionTypeFactory> WithConnectionType<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfiguredTableDatabricksTableReferenceFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionType(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConfiguredTableDatabricksTableReferenceFactory, T1, T2, T3, T4, InnerConfiguredTableDatabricksConnectionTypeFactory> WithConnectionType<T1, T2, T3, T4>(this CombinedResult<InnerConfiguredTableDatabricksTableReferenceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionType(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfiguredTableDatabricksTableReferenceFactory, T2, T3, T4, InnerConfiguredTableDatabricksConnectionTypeFactory> WithConnectionType<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfiguredTableDatabricksTableReferenceFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionType(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfiguredTableDatabricksTableReferenceFactory, T3, T4, InnerConfiguredTableDatabricksConnectionTypeFactory> WithConnectionType<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfiguredTableDatabricksTableReferenceFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionType(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConfiguredTableDatabricksTableReferenceFactory, T4, InnerConfiguredTableDatabricksConnectionTypeFactory> WithConnectionType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfiguredTableDatabricksTableReferenceFactory, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionType(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConfiguredTableDatabricksTableReferenceFactory, InnerConfiguredTableDatabricksConnectionTypeFactory> WithConnectionType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfiguredTableDatabricksTableReferenceFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksConnectionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionType(combinedResult.T5, subFactoryAction).T2);
}
