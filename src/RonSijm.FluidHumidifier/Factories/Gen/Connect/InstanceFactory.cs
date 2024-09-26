// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InstanceFactory(string resourceName = null, Action<Humidifier.Connect.Instance> factoryAction = null) : ResourceFactory<Humidifier.Connect.Instance>(resourceName)
{

    internal InnerInstanceAttributesFactory Attributes_Factory { get; set; }

    protected override Humidifier.Connect.Instance Create()
    {
        var instanceResult = CreateInstance();
        factoryAction?.Invoke(instanceResult);

        return instanceResult;
    }

    private Humidifier.Connect.Instance CreateInstance()
    {
        var instanceResult = new Humidifier.Connect.Instance
        {
            GivenName = InputResourceName,
        };

        return instanceResult;
    }
    public override void CreateChildren(Humidifier.Connect.Instance result)
    {
        base.CreateChildren(result);

        result.Attributes_ ??= Attributes_Factory?.Build();
    }

} // End Of Class

public static class InstanceFactoryExtensions
{
    public static CombinedResult<InstanceFactory, InnerInstanceAttributesFactory> WithAttributes_(this InstanceFactory parentFactory, Action<Humidifier.Connect.InstanceTypes.Attributes> subFactoryAction = null)
    {
        parentFactory.Attributes_Factory = new InnerInstanceAttributesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.Attributes_Factory);
    }

    public static CombinedResult<InstanceFactory, T1, InnerInstanceAttributesFactory> WithAttributes_<T1>(this CombinedResult<InstanceFactory, T1> combinedResult, Action<Humidifier.Connect.InstanceTypes.Attributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttributes_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, InnerInstanceAttributesFactory> WithAttributes_<T1>(this CombinedResult<T1, InstanceFactory> combinedResult, Action<Humidifier.Connect.InstanceTypes.Attributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttributes_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, InnerInstanceAttributesFactory> WithAttributes_<T1, T2>(this CombinedResult<InstanceFactory, T1, T2> combinedResult, Action<Humidifier.Connect.InstanceTypes.Attributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, InnerInstanceAttributesFactory> WithAttributes_<T1, T2>(this CombinedResult<T1, InstanceFactory, T2> combinedResult, Action<Humidifier.Connect.InstanceTypes.Attributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, InnerInstanceAttributesFactory> WithAttributes_<T1, T2>(this CombinedResult<T1, T2, InstanceFactory> combinedResult, Action<Humidifier.Connect.InstanceTypes.Attributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, T3, InnerInstanceAttributesFactory> WithAttributes_<T1, T2, T3>(this CombinedResult<InstanceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.InstanceTypes.Attributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, T3, InnerInstanceAttributesFactory> WithAttributes_<T1, T2, T3>(this CombinedResult<T1, InstanceFactory, T2, T3> combinedResult, Action<Humidifier.Connect.InstanceTypes.Attributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, T3, InnerInstanceAttributesFactory> WithAttributes_<T1, T2, T3>(this CombinedResult<T1, T2, InstanceFactory, T3> combinedResult, Action<Humidifier.Connect.InstanceTypes.Attributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceFactory, InnerInstanceAttributesFactory> WithAttributes_<T1, T2, T3>(this CombinedResult<T1, T2, T3, InstanceFactory> combinedResult, Action<Humidifier.Connect.InstanceTypes.Attributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, T3, T4, InnerInstanceAttributesFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<InstanceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.InstanceTypes.Attributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, T3, T4, InnerInstanceAttributesFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<T1, InstanceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.InstanceTypes.Attributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, T3, T4, InnerInstanceAttributesFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<T1, T2, InstanceFactory, T3, T4> combinedResult, Action<Humidifier.Connect.InstanceTypes.Attributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceFactory, T4, InnerInstanceAttributesFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InstanceFactory, T4> combinedResult, Action<Humidifier.Connect.InstanceTypes.Attributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InstanceFactory, InnerInstanceAttributesFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InstanceFactory> combinedResult, Action<Humidifier.Connect.InstanceTypes.Attributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T5, subFactoryAction));
}
