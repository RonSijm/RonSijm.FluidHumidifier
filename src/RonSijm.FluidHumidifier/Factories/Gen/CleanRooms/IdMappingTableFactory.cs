// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class IdMappingTableFactory(string resourceName = null, Action<Humidifier.CleanRooms.IdMappingTable> factoryAction = null) : ResourceFactory<Humidifier.CleanRooms.IdMappingTable>(resourceName)
{

    internal InnerIdMappingTableIdMappingTableInputReferenceConfigFactory InputReferenceConfigFactory { get; set; }

    protected override Humidifier.CleanRooms.IdMappingTable Create()
    {
        var idMappingTableResult = CreateIdMappingTable();
        factoryAction?.Invoke(idMappingTableResult);

        return idMappingTableResult;
    }

    private Humidifier.CleanRooms.IdMappingTable CreateIdMappingTable()
    {
        var idMappingTableResult = new Humidifier.CleanRooms.IdMappingTable
        {
            GivenName = InputResourceName,
        };

        return idMappingTableResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.IdMappingTable result)
    {
        base.CreateChildren(result);

        result.InputReferenceConfig ??= InputReferenceConfigFactory?.Build();
    }

} // End Of Class

public static class IdMappingTableFactoryExtensions
{
    public static CombinedResult<IdMappingTableFactory, InnerIdMappingTableIdMappingTableInputReferenceConfigFactory> WithInputReferenceConfig(this IdMappingTableFactory parentFactory, Action<Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig> subFactoryAction = null)
    {
        parentFactory.InputReferenceConfigFactory = new InnerIdMappingTableIdMappingTableInputReferenceConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputReferenceConfigFactory);
    }

    public static CombinedResult<IdMappingTableFactory, T1, InnerIdMappingTableIdMappingTableInputReferenceConfigFactory> WithInputReferenceConfig<T1>(this CombinedResult<IdMappingTableFactory, T1> combinedResult, Action<Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdMappingTableFactory, InnerIdMappingTableIdMappingTableInputReferenceConfigFactory> WithInputReferenceConfig<T1>(this CombinedResult<T1, IdMappingTableFactory> combinedResult, Action<Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IdMappingTableFactory, T1, T2, InnerIdMappingTableIdMappingTableInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2>(this CombinedResult<IdMappingTableFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdMappingTableFactory, T2, InnerIdMappingTableIdMappingTableInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2>(this CombinedResult<T1, IdMappingTableFactory, T2> combinedResult, Action<Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdMappingTableFactory, InnerIdMappingTableIdMappingTableInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2>(this CombinedResult<T1, T2, IdMappingTableFactory> combinedResult, Action<Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IdMappingTableFactory, T1, T2, T3, InnerIdMappingTableIdMappingTableInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2, T3>(this CombinedResult<IdMappingTableFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdMappingTableFactory, T2, T3, InnerIdMappingTableIdMappingTableInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2, T3>(this CombinedResult<T1, IdMappingTableFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdMappingTableFactory, T3, InnerIdMappingTableIdMappingTableInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2, T3>(this CombinedResult<T1, T2, IdMappingTableFactory, T3> combinedResult, Action<Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdMappingTableFactory, InnerIdMappingTableIdMappingTableInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, IdMappingTableFactory> combinedResult, Action<Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IdMappingTableFactory, T1, T2, T3, T4, InnerIdMappingTableIdMappingTableInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2, T3, T4>(this CombinedResult<IdMappingTableFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdMappingTableFactory, T2, T3, T4, InnerIdMappingTableIdMappingTableInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2, T3, T4>(this CombinedResult<T1, IdMappingTableFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdMappingTableFactory, T3, T4, InnerIdMappingTableIdMappingTableInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, IdMappingTableFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdMappingTableFactory, T4, InnerIdMappingTableIdMappingTableInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IdMappingTableFactory, T4> combinedResult, Action<Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IdMappingTableFactory, InnerIdMappingTableIdMappingTableInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IdMappingTableFactory> combinedResult, Action<Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T5, subFactoryAction));
}
