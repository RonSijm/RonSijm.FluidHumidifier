// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class InnerCloudFormationProductConnectionParametersFactory(Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters> factoryAction = null) : SubResourceFactory<Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters>
{

    internal InnerCloudFormationProductCodeStarParametersFactory CodeStarFactory { get; set; }

    protected override Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters Create()
    {
        var connectionParametersResult = CreateConnectionParameters();
        factoryAction?.Invoke(connectionParametersResult);

        return connectionParametersResult;
    }

    private Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters CreateConnectionParameters()
    {
        var connectionParametersResult = new Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters();

        return connectionParametersResult;
    }
    public override void CreateChildren(Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters result)
    {
        base.CreateChildren(result);

        result.CodeStar ??= CodeStarFactory?.Build();
    }

} // End Of Class

public static class InnerCloudFormationProductConnectionParametersFactoryExtensions
{
    public static CombinedResult<InnerCloudFormationProductConnectionParametersFactory, InnerCloudFormationProductCodeStarParametersFactory> WithCodeStar(this InnerCloudFormationProductConnectionParametersFactory parentFactory, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters> subFactoryAction = null)
    {
        parentFactory.CodeStarFactory = new InnerCloudFormationProductCodeStarParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CodeStarFactory);
    }

    public static CombinedResult<InnerCloudFormationProductConnectionParametersFactory, T1, InnerCloudFormationProductCodeStarParametersFactory> WithCodeStar<T1>(this CombinedResult<InnerCloudFormationProductConnectionParametersFactory, T1> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeStar(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCloudFormationProductConnectionParametersFactory, InnerCloudFormationProductCodeStarParametersFactory> WithCodeStar<T1>(this CombinedResult<T1, InnerCloudFormationProductConnectionParametersFactory> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeStar(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCloudFormationProductConnectionParametersFactory, T1, T2, InnerCloudFormationProductCodeStarParametersFactory> WithCodeStar<T1, T2>(this CombinedResult<InnerCloudFormationProductConnectionParametersFactory, T1, T2> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeStar(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCloudFormationProductConnectionParametersFactory, T2, InnerCloudFormationProductCodeStarParametersFactory> WithCodeStar<T1, T2>(this CombinedResult<T1, InnerCloudFormationProductConnectionParametersFactory, T2> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeStar(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCloudFormationProductConnectionParametersFactory, InnerCloudFormationProductCodeStarParametersFactory> WithCodeStar<T1, T2>(this CombinedResult<T1, T2, InnerCloudFormationProductConnectionParametersFactory> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeStar(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCloudFormationProductConnectionParametersFactory, T1, T2, T3, InnerCloudFormationProductCodeStarParametersFactory> WithCodeStar<T1, T2, T3>(this CombinedResult<InnerCloudFormationProductConnectionParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeStar(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCloudFormationProductConnectionParametersFactory, T2, T3, InnerCloudFormationProductCodeStarParametersFactory> WithCodeStar<T1, T2, T3>(this CombinedResult<T1, InnerCloudFormationProductConnectionParametersFactory, T2, T3> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeStar(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCloudFormationProductConnectionParametersFactory, T3, InnerCloudFormationProductCodeStarParametersFactory> WithCodeStar<T1, T2, T3>(this CombinedResult<T1, T2, InnerCloudFormationProductConnectionParametersFactory, T3> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeStar(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCloudFormationProductConnectionParametersFactory, InnerCloudFormationProductCodeStarParametersFactory> WithCodeStar<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCloudFormationProductConnectionParametersFactory> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeStar(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCloudFormationProductConnectionParametersFactory, T1, T2, T3, T4, InnerCloudFormationProductCodeStarParametersFactory> WithCodeStar<T1, T2, T3, T4>(this CombinedResult<InnerCloudFormationProductConnectionParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeStar(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCloudFormationProductConnectionParametersFactory, T2, T3, T4, InnerCloudFormationProductCodeStarParametersFactory> WithCodeStar<T1, T2, T3, T4>(this CombinedResult<T1, InnerCloudFormationProductConnectionParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeStar(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCloudFormationProductConnectionParametersFactory, T3, T4, InnerCloudFormationProductCodeStarParametersFactory> WithCodeStar<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCloudFormationProductConnectionParametersFactory, T3, T4> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeStar(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCloudFormationProductConnectionParametersFactory, T4, InnerCloudFormationProductCodeStarParametersFactory> WithCodeStar<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCloudFormationProductConnectionParametersFactory, T4> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeStar(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCloudFormationProductConnectionParametersFactory, InnerCloudFormationProductCodeStarParametersFactory> WithCodeStar<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCloudFormationProductConnectionParametersFactory> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeStar(combinedResult.T5, subFactoryAction));
}
