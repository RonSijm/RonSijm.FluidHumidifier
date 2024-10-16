// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerObjectTypeFieldMapFactory(Action<Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap>
{

    internal InnerObjectTypeObjectTypeFieldFactory ObjectTypeFieldFactory { get; set; }

    protected override Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap Create()
    {
        var fieldMapResult = CreateFieldMap();
        factoryAction?.Invoke(fieldMapResult);

        return fieldMapResult;
    }

    private Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap CreateFieldMap()
    {
        var fieldMapResult = new Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap();

        return fieldMapResult;
    }
    public override void CreateChildren(Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap result)
    {
        base.CreateChildren(result);

        result.ObjectTypeField ??= ObjectTypeFieldFactory?.Build();
    }

} // End Of Class

public static class InnerObjectTypeFieldMapFactoryExtensions
{
    public static CombinedResult<InnerObjectTypeFieldMapFactory, InnerObjectTypeObjectTypeFieldFactory> WithObjectTypeField(this InnerObjectTypeFieldMapFactory parentFactory, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField> subFactoryAction = null)
    {
        parentFactory.ObjectTypeFieldFactory = new InnerObjectTypeObjectTypeFieldFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ObjectTypeFieldFactory);
    }

    public static CombinedResult<InnerObjectTypeFieldMapFactory, T1, InnerObjectTypeObjectTypeFieldFactory> WithObjectTypeField<T1>(this CombinedResult<InnerObjectTypeFieldMapFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField> subFactoryAction = null) => new (combinedResult, combinedResult, WithObjectTypeField(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerObjectTypeFieldMapFactory, InnerObjectTypeObjectTypeFieldFactory> WithObjectTypeField<T1>(this CombinedResult<T1, InnerObjectTypeFieldMapFactory> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField> subFactoryAction = null) => new (combinedResult, combinedResult, WithObjectTypeField(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerObjectTypeFieldMapFactory, T1, T2, InnerObjectTypeObjectTypeFieldFactory> WithObjectTypeField<T1, T2>(this CombinedResult<InnerObjectTypeFieldMapFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithObjectTypeField(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerObjectTypeFieldMapFactory, T2, InnerObjectTypeObjectTypeFieldFactory> WithObjectTypeField<T1, T2>(this CombinedResult<T1, InnerObjectTypeFieldMapFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithObjectTypeField(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerObjectTypeFieldMapFactory, InnerObjectTypeObjectTypeFieldFactory> WithObjectTypeField<T1, T2>(this CombinedResult<T1, T2, InnerObjectTypeFieldMapFactory> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithObjectTypeField(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerObjectTypeFieldMapFactory, T1, T2, T3, InnerObjectTypeObjectTypeFieldFactory> WithObjectTypeField<T1, T2, T3>(this CombinedResult<InnerObjectTypeFieldMapFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObjectTypeField(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerObjectTypeFieldMapFactory, T2, T3, InnerObjectTypeObjectTypeFieldFactory> WithObjectTypeField<T1, T2, T3>(this CombinedResult<T1, InnerObjectTypeFieldMapFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObjectTypeField(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerObjectTypeFieldMapFactory, T3, InnerObjectTypeObjectTypeFieldFactory> WithObjectTypeField<T1, T2, T3>(this CombinedResult<T1, T2, InnerObjectTypeFieldMapFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObjectTypeField(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerObjectTypeFieldMapFactory, InnerObjectTypeObjectTypeFieldFactory> WithObjectTypeField<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerObjectTypeFieldMapFactory> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObjectTypeField(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerObjectTypeFieldMapFactory, T1, T2, T3, T4, InnerObjectTypeObjectTypeFieldFactory> WithObjectTypeField<T1, T2, T3, T4>(this CombinedResult<InnerObjectTypeFieldMapFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectTypeField(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerObjectTypeFieldMapFactory, T2, T3, T4, InnerObjectTypeObjectTypeFieldFactory> WithObjectTypeField<T1, T2, T3, T4>(this CombinedResult<T1, InnerObjectTypeFieldMapFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectTypeField(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerObjectTypeFieldMapFactory, T3, T4, InnerObjectTypeObjectTypeFieldFactory> WithObjectTypeField<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerObjectTypeFieldMapFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectTypeField(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerObjectTypeFieldMapFactory, T4, InnerObjectTypeObjectTypeFieldFactory> WithObjectTypeField<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerObjectTypeFieldMapFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectTypeField(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerObjectTypeFieldMapFactory, InnerObjectTypeObjectTypeFieldFactory> WithObjectTypeField<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerObjectTypeFieldMapFactory> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectTypeField(combinedResult.T5, subFactoryAction));
}
