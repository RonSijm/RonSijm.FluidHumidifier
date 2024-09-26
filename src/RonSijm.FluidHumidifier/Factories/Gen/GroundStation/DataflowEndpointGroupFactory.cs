// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class DataflowEndpointGroupFactory(string resourceName = null, Action<Humidifier.GroundStation.DataflowEndpointGroup> factoryAction = null) : ResourceFactory<Humidifier.GroundStation.DataflowEndpointGroup>(resourceName)
{

    internal List<InnerDataflowEndpointGroupEndpointDetailsFactory> EndpointDetailsFactories { get; set; } = [];

    protected override Humidifier.GroundStation.DataflowEndpointGroup Create()
    {
        var dataflowEndpointGroupResult = CreateDataflowEndpointGroup();
        factoryAction?.Invoke(dataflowEndpointGroupResult);

        return dataflowEndpointGroupResult;
    }

    private Humidifier.GroundStation.DataflowEndpointGroup CreateDataflowEndpointGroup()
    {
        var dataflowEndpointGroupResult = new Humidifier.GroundStation.DataflowEndpointGroup
        {
            GivenName = InputResourceName,
        };

        return dataflowEndpointGroupResult;
    }
    public override void CreateChildren(Humidifier.GroundStation.DataflowEndpointGroup result)
    {
        base.CreateChildren(result);

        result.EndpointDetails = EndpointDetailsFactories.Any() ? EndpointDetailsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class DataflowEndpointGroupFactoryExtensions
{
    public static CombinedResult<DataflowEndpointGroupFactory, InnerDataflowEndpointGroupEndpointDetailsFactory> WithEndpointDetails(this DataflowEndpointGroupFactory parentFactory, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.EndpointDetails> subFactoryAction = null)
    {
        var factory = new InnerDataflowEndpointGroupEndpointDetailsFactory(subFactoryAction);
        parentFactory.EndpointDetailsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DataflowEndpointGroupFactory, T1, InnerDataflowEndpointGroupEndpointDetailsFactory> WithEndpointDetails<T1>(this CombinedResult<DataflowEndpointGroupFactory, T1> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.EndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpointDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataflowEndpointGroupFactory, InnerDataflowEndpointGroupEndpointDetailsFactory> WithEndpointDetails<T1>(this CombinedResult<T1, DataflowEndpointGroupFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.EndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpointDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DataflowEndpointGroupFactory, T1, T2, InnerDataflowEndpointGroupEndpointDetailsFactory> WithEndpointDetails<T1, T2>(this CombinedResult<DataflowEndpointGroupFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.EndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpointDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataflowEndpointGroupFactory, T2, InnerDataflowEndpointGroupEndpointDetailsFactory> WithEndpointDetails<T1, T2>(this CombinedResult<T1, DataflowEndpointGroupFactory, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.EndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpointDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataflowEndpointGroupFactory, InnerDataflowEndpointGroupEndpointDetailsFactory> WithEndpointDetails<T1, T2>(this CombinedResult<T1, T2, DataflowEndpointGroupFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.EndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpointDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DataflowEndpointGroupFactory, T1, T2, T3, InnerDataflowEndpointGroupEndpointDetailsFactory> WithEndpointDetails<T1, T2, T3>(this CombinedResult<DataflowEndpointGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.EndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataflowEndpointGroupFactory, T2, T3, InnerDataflowEndpointGroupEndpointDetailsFactory> WithEndpointDetails<T1, T2, T3>(this CombinedResult<T1, DataflowEndpointGroupFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.EndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataflowEndpointGroupFactory, T3, InnerDataflowEndpointGroupEndpointDetailsFactory> WithEndpointDetails<T1, T2, T3>(this CombinedResult<T1, T2, DataflowEndpointGroupFactory, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.EndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataflowEndpointGroupFactory, InnerDataflowEndpointGroupEndpointDetailsFactory> WithEndpointDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataflowEndpointGroupFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.EndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DataflowEndpointGroupFactory, T1, T2, T3, T4, InnerDataflowEndpointGroupEndpointDetailsFactory> WithEndpointDetails<T1, T2, T3, T4>(this CombinedResult<DataflowEndpointGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.EndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataflowEndpointGroupFactory, T2, T3, T4, InnerDataflowEndpointGroupEndpointDetailsFactory> WithEndpointDetails<T1, T2, T3, T4>(this CombinedResult<T1, DataflowEndpointGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.EndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataflowEndpointGroupFactory, T3, T4, InnerDataflowEndpointGroupEndpointDetailsFactory> WithEndpointDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataflowEndpointGroupFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.EndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataflowEndpointGroupFactory, T4, InnerDataflowEndpointGroupEndpointDetailsFactory> WithEndpointDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataflowEndpointGroupFactory, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.EndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DataflowEndpointGroupFactory, InnerDataflowEndpointGroupEndpointDetailsFactory> WithEndpointDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataflowEndpointGroupFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.EndpointDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointDetails(combinedResult.T5, subFactoryAction));
}
