// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class IdNamespaceAssociationFactory(string resourceName = null, Action<Humidifier.CleanRooms.IdNamespaceAssociation> factoryAction = null) : ResourceFactory<Humidifier.CleanRooms.IdNamespaceAssociation>(resourceName)
{

    internal InnerIdNamespaceAssociationIdMappingConfigFactory IdMappingConfigFactory { get; set; }

    internal InnerIdNamespaceAssociationIdNamespaceAssociationInputReferenceConfigFactory InputReferenceConfigFactory { get; set; }

    protected override Humidifier.CleanRooms.IdNamespaceAssociation Create()
    {
        var idNamespaceAssociationResult = CreateIdNamespaceAssociation();
        factoryAction?.Invoke(idNamespaceAssociationResult);

        return idNamespaceAssociationResult;
    }

    private Humidifier.CleanRooms.IdNamespaceAssociation CreateIdNamespaceAssociation()
    {
        var idNamespaceAssociationResult = new Humidifier.CleanRooms.IdNamespaceAssociation
        {
            GivenName = InputResourceName,
        };

        return idNamespaceAssociationResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.IdNamespaceAssociation result)
    {
        base.CreateChildren(result);

        result.IdMappingConfig ??= IdMappingConfigFactory?.Build();
        result.InputReferenceConfig ??= InputReferenceConfigFactory?.Build();
    }

} // End Of Class

public static class IdNamespaceAssociationFactoryExtensions
{
    public static CombinedResult<IdNamespaceAssociationFactory, InnerIdNamespaceAssociationIdMappingConfigFactory> WithIdMappingConfig(this IdNamespaceAssociationFactory parentFactory, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig> subFactoryAction = null)
    {
        parentFactory.IdMappingConfigFactory = new InnerIdNamespaceAssociationIdMappingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdMappingConfigFactory);
    }

    public static CombinedResult<IdNamespaceAssociationFactory, InnerIdNamespaceAssociationIdNamespaceAssociationInputReferenceConfigFactory> WithInputReferenceConfig(this IdNamespaceAssociationFactory parentFactory, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig> subFactoryAction = null)
    {
        parentFactory.InputReferenceConfigFactory = new InnerIdNamespaceAssociationIdNamespaceAssociationInputReferenceConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputReferenceConfigFactory);
    }

    public static CombinedResult<IdNamespaceAssociationFactory, T1, InnerIdNamespaceAssociationIdMappingConfigFactory> WithIdMappingConfig<T1>(this CombinedResult<IdNamespaceAssociationFactory, T1> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdMappingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdNamespaceAssociationFactory, InnerIdNamespaceAssociationIdMappingConfigFactory> WithIdMappingConfig<T1>(this CombinedResult<T1, IdNamespaceAssociationFactory> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdMappingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IdNamespaceAssociationFactory, T1, T2, InnerIdNamespaceAssociationIdMappingConfigFactory> WithIdMappingConfig<T1, T2>(this CombinedResult<IdNamespaceAssociationFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdMappingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdNamespaceAssociationFactory, T2, InnerIdNamespaceAssociationIdMappingConfigFactory> WithIdMappingConfig<T1, T2>(this CombinedResult<T1, IdNamespaceAssociationFactory, T2> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdMappingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdNamespaceAssociationFactory, InnerIdNamespaceAssociationIdMappingConfigFactory> WithIdMappingConfig<T1, T2>(this CombinedResult<T1, T2, IdNamespaceAssociationFactory> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdMappingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IdNamespaceAssociationFactory, T1, T2, T3, InnerIdNamespaceAssociationIdMappingConfigFactory> WithIdMappingConfig<T1, T2, T3>(this CombinedResult<IdNamespaceAssociationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdNamespaceAssociationFactory, T2, T3, InnerIdNamespaceAssociationIdMappingConfigFactory> WithIdMappingConfig<T1, T2, T3>(this CombinedResult<T1, IdNamespaceAssociationFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdNamespaceAssociationFactory, T3, InnerIdNamespaceAssociationIdMappingConfigFactory> WithIdMappingConfig<T1, T2, T3>(this CombinedResult<T1, T2, IdNamespaceAssociationFactory, T3> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdNamespaceAssociationFactory, InnerIdNamespaceAssociationIdMappingConfigFactory> WithIdMappingConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, IdNamespaceAssociationFactory> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IdNamespaceAssociationFactory, T1, T2, T3, T4, InnerIdNamespaceAssociationIdMappingConfigFactory> WithIdMappingConfig<T1, T2, T3, T4>(this CombinedResult<IdNamespaceAssociationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdNamespaceAssociationFactory, T2, T3, T4, InnerIdNamespaceAssociationIdMappingConfigFactory> WithIdMappingConfig<T1, T2, T3, T4>(this CombinedResult<T1, IdNamespaceAssociationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdNamespaceAssociationFactory, T3, T4, InnerIdNamespaceAssociationIdMappingConfigFactory> WithIdMappingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, IdNamespaceAssociationFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdNamespaceAssociationFactory, T4, InnerIdNamespaceAssociationIdMappingConfigFactory> WithIdMappingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IdNamespaceAssociationFactory, T4> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IdNamespaceAssociationFactory, InnerIdNamespaceAssociationIdMappingConfigFactory> WithIdMappingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IdNamespaceAssociationFactory> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<IdNamespaceAssociationFactory, T1, InnerIdNamespaceAssociationIdNamespaceAssociationInputReferenceConfigFactory> WithInputReferenceConfig<T1>(this CombinedResult<IdNamespaceAssociationFactory, T1> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdNamespaceAssociationFactory, InnerIdNamespaceAssociationIdNamespaceAssociationInputReferenceConfigFactory> WithInputReferenceConfig<T1>(this CombinedResult<T1, IdNamespaceAssociationFactory> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IdNamespaceAssociationFactory, T1, T2, InnerIdNamespaceAssociationIdNamespaceAssociationInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2>(this CombinedResult<IdNamespaceAssociationFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdNamespaceAssociationFactory, T2, InnerIdNamespaceAssociationIdNamespaceAssociationInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2>(this CombinedResult<T1, IdNamespaceAssociationFactory, T2> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdNamespaceAssociationFactory, InnerIdNamespaceAssociationIdNamespaceAssociationInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2>(this CombinedResult<T1, T2, IdNamespaceAssociationFactory> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IdNamespaceAssociationFactory, T1, T2, T3, InnerIdNamespaceAssociationIdNamespaceAssociationInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2, T3>(this CombinedResult<IdNamespaceAssociationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdNamespaceAssociationFactory, T2, T3, InnerIdNamespaceAssociationIdNamespaceAssociationInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2, T3>(this CombinedResult<T1, IdNamespaceAssociationFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdNamespaceAssociationFactory, T3, InnerIdNamespaceAssociationIdNamespaceAssociationInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2, T3>(this CombinedResult<T1, T2, IdNamespaceAssociationFactory, T3> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdNamespaceAssociationFactory, InnerIdNamespaceAssociationIdNamespaceAssociationInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, IdNamespaceAssociationFactory> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IdNamespaceAssociationFactory, T1, T2, T3, T4, InnerIdNamespaceAssociationIdNamespaceAssociationInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2, T3, T4>(this CombinedResult<IdNamespaceAssociationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdNamespaceAssociationFactory, T2, T3, T4, InnerIdNamespaceAssociationIdNamespaceAssociationInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2, T3, T4>(this CombinedResult<T1, IdNamespaceAssociationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdNamespaceAssociationFactory, T3, T4, InnerIdNamespaceAssociationIdNamespaceAssociationInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, IdNamespaceAssociationFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdNamespaceAssociationFactory, T4, InnerIdNamespaceAssociationIdNamespaceAssociationInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IdNamespaceAssociationFactory, T4> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IdNamespaceAssociationFactory, InnerIdNamespaceAssociationIdNamespaceAssociationInputReferenceConfigFactory> WithInputReferenceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IdNamespaceAssociationFactory> combinedResult, Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputReferenceConfig(combinedResult.T5, subFactoryAction));
}
