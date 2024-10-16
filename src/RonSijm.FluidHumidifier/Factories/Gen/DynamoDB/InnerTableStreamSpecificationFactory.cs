// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerTableStreamSpecificationFactory(Action<Humidifier.DynamoDB.TableTypes.StreamSpecification> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.TableTypes.StreamSpecification>
{

    internal InnerTableResourcePolicyFactory ResourcePolicyFactory { get; set; }

    protected override Humidifier.DynamoDB.TableTypes.StreamSpecification Create()
    {
        var streamSpecificationResult = CreateStreamSpecification();
        factoryAction?.Invoke(streamSpecificationResult);

        return streamSpecificationResult;
    }

    private Humidifier.DynamoDB.TableTypes.StreamSpecification CreateStreamSpecification()
    {
        var streamSpecificationResult = new Humidifier.DynamoDB.TableTypes.StreamSpecification();

        return streamSpecificationResult;
    }
    public override void CreateChildren(Humidifier.DynamoDB.TableTypes.StreamSpecification result)
    {
        base.CreateChildren(result);

        result.ResourcePolicy ??= ResourcePolicyFactory?.Build();
    }

} // End Of Class

public static class InnerTableStreamSpecificationFactoryExtensions
{
    public static CombinedResult<InnerTableStreamSpecificationFactory, InnerTableResourcePolicyFactory> WithResourcePolicy(this InnerTableStreamSpecificationFactory parentFactory, Action<Humidifier.DynamoDB.TableTypes.ResourcePolicy> subFactoryAction = null)
    {
        parentFactory.ResourcePolicyFactory = new InnerTableResourcePolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourcePolicyFactory);
    }

    public static CombinedResult<InnerTableStreamSpecificationFactory, T1, InnerTableResourcePolicyFactory> WithResourcePolicy<T1>(this CombinedResult<InnerTableStreamSpecificationFactory, T1> combinedResult, Action<Humidifier.DynamoDB.TableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourcePolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableStreamSpecificationFactory, InnerTableResourcePolicyFactory> WithResourcePolicy<T1>(this CombinedResult<T1, InnerTableStreamSpecificationFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourcePolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableStreamSpecificationFactory, T1, T2, InnerTableResourcePolicyFactory> WithResourcePolicy<T1, T2>(this CombinedResult<InnerTableStreamSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.DynamoDB.TableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableStreamSpecificationFactory, T2, InnerTableResourcePolicyFactory> WithResourcePolicy<T1, T2>(this CombinedResult<T1, InnerTableStreamSpecificationFactory, T2> combinedResult, Action<Humidifier.DynamoDB.TableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableStreamSpecificationFactory, InnerTableResourcePolicyFactory> WithResourcePolicy<T1, T2>(this CombinedResult<T1, T2, InnerTableStreamSpecificationFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableStreamSpecificationFactory, T1, T2, T3, InnerTableResourcePolicyFactory> WithResourcePolicy<T1, T2, T3>(this CombinedResult<InnerTableStreamSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableStreamSpecificationFactory, T2, T3, InnerTableResourcePolicyFactory> WithResourcePolicy<T1, T2, T3>(this CombinedResult<T1, InnerTableStreamSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableStreamSpecificationFactory, T3, InnerTableResourcePolicyFactory> WithResourcePolicy<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableStreamSpecificationFactory, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableStreamSpecificationFactory, InnerTableResourcePolicyFactory> WithResourcePolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableStreamSpecificationFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableStreamSpecificationFactory, T1, T2, T3, T4, InnerTableResourcePolicyFactory> WithResourcePolicy<T1, T2, T3, T4>(this CombinedResult<InnerTableStreamSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableStreamSpecificationFactory, T2, T3, T4, InnerTableResourcePolicyFactory> WithResourcePolicy<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableStreamSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableStreamSpecificationFactory, T3, T4, InnerTableResourcePolicyFactory> WithResourcePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableStreamSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableStreamSpecificationFactory, T4, InnerTableResourcePolicyFactory> WithResourcePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableStreamSpecificationFactory, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableStreamSpecificationFactory, InnerTableResourcePolicyFactory> WithResourcePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableStreamSpecificationFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T5, subFactoryAction));
}
