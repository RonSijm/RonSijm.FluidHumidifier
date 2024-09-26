// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterSaslFactory(Action<Humidifier.MSK.ClusterTypes.Sasl> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.Sasl>
{

    internal InnerClusterIamFactory IamFactory { get; set; }

    internal InnerClusterScramFactory ScramFactory { get; set; }

    protected override Humidifier.MSK.ClusterTypes.Sasl Create()
    {
        var saslResult = CreateSasl();
        factoryAction?.Invoke(saslResult);

        return saslResult;
    }

    private Humidifier.MSK.ClusterTypes.Sasl CreateSasl()
    {
        var saslResult = new Humidifier.MSK.ClusterTypes.Sasl();

        return saslResult;
    }
    public override void CreateChildren(Humidifier.MSK.ClusterTypes.Sasl result)
    {
        base.CreateChildren(result);

        result.Iam ??= IamFactory?.Build();
        result.Scram ??= ScramFactory?.Build();
    }

} // End Of Class

public static class InnerClusterSaslFactoryExtensions
{
    public static CombinedResult<InnerClusterSaslFactory, InnerClusterIamFactory> WithIam(this InnerClusterSaslFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.Iam> subFactoryAction = null)
    {
        parentFactory.IamFactory = new InnerClusterIamFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IamFactory);
    }

    public static CombinedResult<InnerClusterSaslFactory, InnerClusterScramFactory> WithScram(this InnerClusterSaslFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.Scram> subFactoryAction = null)
    {
        parentFactory.ScramFactory = new InnerClusterScramFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScramFactory);
    }

    public static CombinedResult<InnerClusterSaslFactory, T1, InnerClusterIamFactory> WithIam<T1>(this CombinedResult<InnerClusterSaslFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, WithIam(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterSaslFactory, InnerClusterIamFactory> WithIam<T1>(this CombinedResult<T1, InnerClusterSaslFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, WithIam(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterSaslFactory, T1, T2, InnerClusterIamFactory> WithIam<T1, T2>(this CombinedResult<InnerClusterSaslFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterSaslFactory, T2, InnerClusterIamFactory> WithIam<T1, T2>(this CombinedResult<T1, InnerClusterSaslFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterSaslFactory, InnerClusterIamFactory> WithIam<T1, T2>(this CombinedResult<T1, T2, InnerClusterSaslFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterSaslFactory, T1, T2, T3, InnerClusterIamFactory> WithIam<T1, T2, T3>(this CombinedResult<InnerClusterSaslFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterSaslFactory, T2, T3, InnerClusterIamFactory> WithIam<T1, T2, T3>(this CombinedResult<T1, InnerClusterSaslFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterSaslFactory, T3, InnerClusterIamFactory> WithIam<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterSaslFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterSaslFactory, InnerClusterIamFactory> WithIam<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterSaslFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterSaslFactory, T1, T2, T3, T4, InnerClusterIamFactory> WithIam<T1, T2, T3, T4>(this CombinedResult<InnerClusterSaslFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterSaslFactory, T2, T3, T4, InnerClusterIamFactory> WithIam<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterSaslFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterSaslFactory, T3, T4, InnerClusterIamFactory> WithIam<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterSaslFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterSaslFactory, T4, InnerClusterIamFactory> WithIam<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterSaslFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterSaslFactory, InnerClusterIamFactory> WithIam<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterSaslFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerClusterSaslFactory, T1, InnerClusterScramFactory> WithScram<T1>(this CombinedResult<InnerClusterSaslFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.Scram> subFactoryAction = null) => new (combinedResult, combinedResult, WithScram(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterSaslFactory, InnerClusterScramFactory> WithScram<T1>(this CombinedResult<T1, InnerClusterSaslFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Scram> subFactoryAction = null) => new (combinedResult, combinedResult, WithScram(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterSaslFactory, T1, T2, InnerClusterScramFactory> WithScram<T1, T2>(this CombinedResult<InnerClusterSaslFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.Scram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterSaslFactory, T2, InnerClusterScramFactory> WithScram<T1, T2>(this CombinedResult<T1, InnerClusterSaslFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.Scram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterSaslFactory, InnerClusterScramFactory> WithScram<T1, T2>(this CombinedResult<T1, T2, InnerClusterSaslFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Scram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterSaslFactory, T1, T2, T3, InnerClusterScramFactory> WithScram<T1, T2, T3>(this CombinedResult<InnerClusterSaslFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Scram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterSaslFactory, T2, T3, InnerClusterScramFactory> WithScram<T1, T2, T3>(this CombinedResult<T1, InnerClusterSaslFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Scram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterSaslFactory, T3, InnerClusterScramFactory> WithScram<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterSaslFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Scram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterSaslFactory, InnerClusterScramFactory> WithScram<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterSaslFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Scram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterSaslFactory, T1, T2, T3, T4, InnerClusterScramFactory> WithScram<T1, T2, T3, T4>(this CombinedResult<InnerClusterSaslFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Scram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterSaslFactory, T2, T3, T4, InnerClusterScramFactory> WithScram<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterSaslFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Scram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterSaslFactory, T3, T4, InnerClusterScramFactory> WithScram<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterSaslFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Scram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterSaslFactory, T4, InnerClusterScramFactory> WithScram<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterSaslFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Scram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterSaslFactory, InnerClusterScramFactory> WithScram<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterSaslFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Scram> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScram(combinedResult.T5, subFactoryAction));
}
