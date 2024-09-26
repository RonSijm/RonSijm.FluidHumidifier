// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class ObjectTypeFactory(string resourceName = null, Action<Humidifier.CustomerProfiles.ObjectType> factoryAction = null) : ResourceFactory<Humidifier.CustomerProfiles.ObjectType>(resourceName)
{

    internal List<InnerObjectTypeFieldMapFactory> FieldsFactories { get; set; } = [];

    internal List<InnerObjectTypeKeyMapFactory> KeysFactories { get; set; } = [];

    protected override Humidifier.CustomerProfiles.ObjectType Create()
    {
        var objectTypeResult = CreateObjectType();
        factoryAction?.Invoke(objectTypeResult);

        return objectTypeResult;
    }

    private Humidifier.CustomerProfiles.ObjectType CreateObjectType()
    {
        var objectTypeResult = new Humidifier.CustomerProfiles.ObjectType
        {
            GivenName = InputResourceName,
        };

        return objectTypeResult;
    }
    public override void CreateChildren(Humidifier.CustomerProfiles.ObjectType result)
    {
        base.CreateChildren(result);

        result.Fields = FieldsFactories.Any() ? FieldsFactories.Select(x => x.Build()).ToList() : null;
        result.Keys = KeysFactories.Any() ? KeysFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ObjectTypeFactoryExtensions
{
    public static CombinedResult<ObjectTypeFactory, InnerObjectTypeFieldMapFactory> WithFields(this ObjectTypeFactory parentFactory, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap> subFactoryAction = null)
    {
        var factory = new InnerObjectTypeFieldMapFactory(subFactoryAction);
        parentFactory.FieldsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ObjectTypeFactory, InnerObjectTypeKeyMapFactory> WithKeys(this ObjectTypeFactory parentFactory, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap> subFactoryAction = null)
    {
        var factory = new InnerObjectTypeKeyMapFactory(subFactoryAction);
        parentFactory.KeysFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ObjectTypeFactory, T1, InnerObjectTypeFieldMapFactory> WithFields<T1>(this CombinedResult<ObjectTypeFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap> subFactoryAction = null) => new (combinedResult, combinedResult, WithFields(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ObjectTypeFactory, InnerObjectTypeFieldMapFactory> WithFields<T1>(this CombinedResult<T1, ObjectTypeFactory> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap> subFactoryAction = null) => new (combinedResult, combinedResult, WithFields(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ObjectTypeFactory, T1, T2, InnerObjectTypeFieldMapFactory> WithFields<T1, T2>(this CombinedResult<ObjectTypeFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ObjectTypeFactory, T2, InnerObjectTypeFieldMapFactory> WithFields<T1, T2>(this CombinedResult<T1, ObjectTypeFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ObjectTypeFactory, InnerObjectTypeFieldMapFactory> WithFields<T1, T2>(this CombinedResult<T1, T2, ObjectTypeFactory> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ObjectTypeFactory, T1, T2, T3, InnerObjectTypeFieldMapFactory> WithFields<T1, T2, T3>(this CombinedResult<ObjectTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ObjectTypeFactory, T2, T3, InnerObjectTypeFieldMapFactory> WithFields<T1, T2, T3>(this CombinedResult<T1, ObjectTypeFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ObjectTypeFactory, T3, InnerObjectTypeFieldMapFactory> WithFields<T1, T2, T3>(this CombinedResult<T1, T2, ObjectTypeFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ObjectTypeFactory, InnerObjectTypeFieldMapFactory> WithFields<T1, T2, T3>(this CombinedResult<T1, T2, T3, ObjectTypeFactory> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ObjectTypeFactory, T1, T2, T3, T4, InnerObjectTypeFieldMapFactory> WithFields<T1, T2, T3, T4>(this CombinedResult<ObjectTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ObjectTypeFactory, T2, T3, T4, InnerObjectTypeFieldMapFactory> WithFields<T1, T2, T3, T4>(this CombinedResult<T1, ObjectTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ObjectTypeFactory, T3, T4, InnerObjectTypeFieldMapFactory> WithFields<T1, T2, T3, T4>(this CombinedResult<T1, T2, ObjectTypeFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ObjectTypeFactory, T4, InnerObjectTypeFieldMapFactory> WithFields<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ObjectTypeFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ObjectTypeFactory, InnerObjectTypeFieldMapFactory> WithFields<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ObjectTypeFactory> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ObjectTypeFactory, T1, InnerObjectTypeKeyMapFactory> WithKeys<T1>(this CombinedResult<ObjectTypeFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeys(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ObjectTypeFactory, InnerObjectTypeKeyMapFactory> WithKeys<T1>(this CombinedResult<T1, ObjectTypeFactory> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeys(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ObjectTypeFactory, T1, T2, InnerObjectTypeKeyMapFactory> WithKeys<T1, T2>(this CombinedResult<ObjectTypeFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeys(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ObjectTypeFactory, T2, InnerObjectTypeKeyMapFactory> WithKeys<T1, T2>(this CombinedResult<T1, ObjectTypeFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeys(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ObjectTypeFactory, InnerObjectTypeKeyMapFactory> WithKeys<T1, T2>(this CombinedResult<T1, T2, ObjectTypeFactory> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeys(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ObjectTypeFactory, T1, T2, T3, InnerObjectTypeKeyMapFactory> WithKeys<T1, T2, T3>(this CombinedResult<ObjectTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeys(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ObjectTypeFactory, T2, T3, InnerObjectTypeKeyMapFactory> WithKeys<T1, T2, T3>(this CombinedResult<T1, ObjectTypeFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeys(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ObjectTypeFactory, T3, InnerObjectTypeKeyMapFactory> WithKeys<T1, T2, T3>(this CombinedResult<T1, T2, ObjectTypeFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeys(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ObjectTypeFactory, InnerObjectTypeKeyMapFactory> WithKeys<T1, T2, T3>(this CombinedResult<T1, T2, T3, ObjectTypeFactory> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeys(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ObjectTypeFactory, T1, T2, T3, T4, InnerObjectTypeKeyMapFactory> WithKeys<T1, T2, T3, T4>(this CombinedResult<ObjectTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeys(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ObjectTypeFactory, T2, T3, T4, InnerObjectTypeKeyMapFactory> WithKeys<T1, T2, T3, T4>(this CombinedResult<T1, ObjectTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeys(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ObjectTypeFactory, T3, T4, InnerObjectTypeKeyMapFactory> WithKeys<T1, T2, T3, T4>(this CombinedResult<T1, T2, ObjectTypeFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeys(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ObjectTypeFactory, T4, InnerObjectTypeKeyMapFactory> WithKeys<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ObjectTypeFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeys(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ObjectTypeFactory, InnerObjectTypeKeyMapFactory> WithKeys<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ObjectTypeFactory> combinedResult, Action<Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeys(combinedResult.T5, subFactoryAction));
}
