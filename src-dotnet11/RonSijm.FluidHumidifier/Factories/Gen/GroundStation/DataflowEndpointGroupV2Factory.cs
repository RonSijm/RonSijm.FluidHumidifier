// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class DataflowEndpointGroupV2Factory(string resourceName = null, Action<Humidifier.GroundStation.DataflowEndpointGroupV2> factoryAction = null) : ResourceFactory<Humidifier.GroundStation.DataflowEndpointGroupV2>(resourceName)
{

    internal List<InnerDataflowEndpointGroupV2CreateEndpointDetailsFactory> EndpointsFactories { get; set; } = [];

    protected override Humidifier.GroundStation.DataflowEndpointGroupV2 Create()
    {
        var dataflowEndpointGroupV2Result = CreateDataflowEndpointGroupV2();
        factoryAction?.Invoke(dataflowEndpointGroupV2Result);

        return dataflowEndpointGroupV2Result;
    }

    private Humidifier.GroundStation.DataflowEndpointGroupV2 CreateDataflowEndpointGroupV2()
    {
        var dataflowEndpointGroupV2Result = new Humidifier.GroundStation.DataflowEndpointGroupV2
        {
            GivenName = InputResourceName,
        };

        return dataflowEndpointGroupV2Result;
    }
    public override void CreateChildren(Humidifier.GroundStation.DataflowEndpointGroupV2 result)
    {
        base.CreateChildren(result);

        result.Endpoints = EndpointsFactories.Any() ? EndpointsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class DataflowEndpointGroupV2FactoryExtensions
{
    public static CombinedResult<DataflowEndpointGroupV2Factory, InnerDataflowEndpointGroupV2CreateEndpointDetailsFactory> WithEndpoints(this DataflowEndpointGroupV2Factory parentFactory, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.CreateEndpointDetails> subFactoryAction = null)
    {
        var factory = new InnerDataflowEndpointGroupV2CreateEndpointDetailsFactory(subFactoryAction);
        parentFactory.EndpointsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DataflowEndpointGroupV2Factory, T1, InnerDataflowEndpointGroupV2CreateEndpointDetailsFactory> WithEndpoints<T1>(this CombinedResult<DataflowEndpointGroupV2Factory, T1> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.CreateEndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpoints(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataflowEndpointGroupV2Factory, InnerDataflowEndpointGroupV2CreateEndpointDetailsFactory> WithEndpoints<T1>(this CombinedResult<T1, DataflowEndpointGroupV2Factory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.CreateEndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpoints(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DataflowEndpointGroupV2Factory, T1, T2, InnerDataflowEndpointGroupV2CreateEndpointDetailsFactory> WithEndpoints<T1, T2>(this CombinedResult<DataflowEndpointGroupV2Factory, T1, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.CreateEndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataflowEndpointGroupV2Factory, T2, InnerDataflowEndpointGroupV2CreateEndpointDetailsFactory> WithEndpoints<T1, T2>(this CombinedResult<T1, DataflowEndpointGroupV2Factory, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.CreateEndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataflowEndpointGroupV2Factory, InnerDataflowEndpointGroupV2CreateEndpointDetailsFactory> WithEndpoints<T1, T2>(this CombinedResult<T1, T2, DataflowEndpointGroupV2Factory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.CreateEndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DataflowEndpointGroupV2Factory, T1, T2, T3, InnerDataflowEndpointGroupV2CreateEndpointDetailsFactory> WithEndpoints<T1, T2, T3>(this CombinedResult<DataflowEndpointGroupV2Factory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.CreateEndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataflowEndpointGroupV2Factory, T2, T3, InnerDataflowEndpointGroupV2CreateEndpointDetailsFactory> WithEndpoints<T1, T2, T3>(this CombinedResult<T1, DataflowEndpointGroupV2Factory, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.CreateEndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataflowEndpointGroupV2Factory, T3, InnerDataflowEndpointGroupV2CreateEndpointDetailsFactory> WithEndpoints<T1, T2, T3>(this CombinedResult<T1, T2, DataflowEndpointGroupV2Factory, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.CreateEndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DataflowEndpointGroupV2Factory, InnerDataflowEndpointGroupV2CreateEndpointDetailsFactory> WithEndpoints<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataflowEndpointGroupV2Factory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.CreateEndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DataflowEndpointGroupV2Factory, T1, T2, T3, T4, InnerDataflowEndpointGroupV2CreateEndpointDetailsFactory> WithEndpoints<T1, T2, T3, T4>(this CombinedResult<DataflowEndpointGroupV2Factory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.CreateEndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataflowEndpointGroupV2Factory, T2, T3, T4, InnerDataflowEndpointGroupV2CreateEndpointDetailsFactory> WithEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, DataflowEndpointGroupV2Factory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.CreateEndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataflowEndpointGroupV2Factory, T3, T4, InnerDataflowEndpointGroupV2CreateEndpointDetailsFactory> WithEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataflowEndpointGroupV2Factory, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.CreateEndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DataflowEndpointGroupV2Factory, T4, InnerDataflowEndpointGroupV2CreateEndpointDetailsFactory> WithEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataflowEndpointGroupV2Factory, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.CreateEndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DataflowEndpointGroupV2Factory, InnerDataflowEndpointGroupV2CreateEndpointDetailsFactory> WithEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataflowEndpointGroupV2Factory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.CreateEndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T5, subFactoryAction).T2);
}
