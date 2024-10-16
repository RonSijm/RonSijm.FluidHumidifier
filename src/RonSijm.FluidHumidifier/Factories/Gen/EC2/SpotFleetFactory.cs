// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class SpotFleetFactory(string resourceName = null, Action<Humidifier.EC2.SpotFleet> factoryAction = null) : ResourceFactory<Humidifier.EC2.SpotFleet>(resourceName)
{

    internal InnerSpotFleetSpotFleetRequestConfigDataFactory SpotFleetRequestConfigDataFactory { get; set; }

    protected override Humidifier.EC2.SpotFleet Create()
    {
        var spotFleetResult = CreateSpotFleet();
        factoryAction?.Invoke(spotFleetResult);

        return spotFleetResult;
    }

    private Humidifier.EC2.SpotFleet CreateSpotFleet()
    {
        var spotFleetResult = new Humidifier.EC2.SpotFleet
        {
            GivenName = InputResourceName,
        };

        return spotFleetResult;
    }
    public override void CreateChildren(Humidifier.EC2.SpotFleet result)
    {
        base.CreateChildren(result);

        result.SpotFleetRequestConfigData ??= SpotFleetRequestConfigDataFactory?.Build();
    }

} // End Of Class

public static class SpotFleetFactoryExtensions
{
    public static CombinedResult<SpotFleetFactory, InnerSpotFleetSpotFleetRequestConfigDataFactory> WithSpotFleetRequestConfigData(this SpotFleetFactory parentFactory, Action<Humidifier.EC2.SpotFleetTypes.SpotFleetRequestConfigData> subFactoryAction = null)
    {
        parentFactory.SpotFleetRequestConfigDataFactory = new InnerSpotFleetSpotFleetRequestConfigDataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpotFleetRequestConfigDataFactory);
    }

    public static CombinedResult<SpotFleetFactory, T1, InnerSpotFleetSpotFleetRequestConfigDataFactory> WithSpotFleetRequestConfigData<T1>(this CombinedResult<SpotFleetFactory, T1> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotFleetRequestConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpotFleetRequestConfigData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SpotFleetFactory, InnerSpotFleetSpotFleetRequestConfigDataFactory> WithSpotFleetRequestConfigData<T1>(this CombinedResult<T1, SpotFleetFactory> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotFleetRequestConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpotFleetRequestConfigData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SpotFleetFactory, T1, T2, InnerSpotFleetSpotFleetRequestConfigDataFactory> WithSpotFleetRequestConfigData<T1, T2>(this CombinedResult<SpotFleetFactory, T1, T2> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotFleetRequestConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpotFleetRequestConfigData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SpotFleetFactory, T2, InnerSpotFleetSpotFleetRequestConfigDataFactory> WithSpotFleetRequestConfigData<T1, T2>(this CombinedResult<T1, SpotFleetFactory, T2> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotFleetRequestConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpotFleetRequestConfigData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SpotFleetFactory, InnerSpotFleetSpotFleetRequestConfigDataFactory> WithSpotFleetRequestConfigData<T1, T2>(this CombinedResult<T1, T2, SpotFleetFactory> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotFleetRequestConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpotFleetRequestConfigData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SpotFleetFactory, T1, T2, T3, InnerSpotFleetSpotFleetRequestConfigDataFactory> WithSpotFleetRequestConfigData<T1, T2, T3>(this CombinedResult<SpotFleetFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotFleetRequestConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpotFleetRequestConfigData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SpotFleetFactory, T2, T3, InnerSpotFleetSpotFleetRequestConfigDataFactory> WithSpotFleetRequestConfigData<T1, T2, T3>(this CombinedResult<T1, SpotFleetFactory, T2, T3> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotFleetRequestConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpotFleetRequestConfigData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SpotFleetFactory, T3, InnerSpotFleetSpotFleetRequestConfigDataFactory> WithSpotFleetRequestConfigData<T1, T2, T3>(this CombinedResult<T1, T2, SpotFleetFactory, T3> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotFleetRequestConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpotFleetRequestConfigData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SpotFleetFactory, InnerSpotFleetSpotFleetRequestConfigDataFactory> WithSpotFleetRequestConfigData<T1, T2, T3>(this CombinedResult<T1, T2, T3, SpotFleetFactory> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotFleetRequestConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpotFleetRequestConfigData(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SpotFleetFactory, T1, T2, T3, T4, InnerSpotFleetSpotFleetRequestConfigDataFactory> WithSpotFleetRequestConfigData<T1, T2, T3, T4>(this CombinedResult<SpotFleetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotFleetRequestConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpotFleetRequestConfigData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SpotFleetFactory, T2, T3, T4, InnerSpotFleetSpotFleetRequestConfigDataFactory> WithSpotFleetRequestConfigData<T1, T2, T3, T4>(this CombinedResult<T1, SpotFleetFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotFleetRequestConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpotFleetRequestConfigData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SpotFleetFactory, T3, T4, InnerSpotFleetSpotFleetRequestConfigDataFactory> WithSpotFleetRequestConfigData<T1, T2, T3, T4>(this CombinedResult<T1, T2, SpotFleetFactory, T3, T4> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotFleetRequestConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpotFleetRequestConfigData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SpotFleetFactory, T4, InnerSpotFleetSpotFleetRequestConfigDataFactory> WithSpotFleetRequestConfigData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SpotFleetFactory, T4> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotFleetRequestConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpotFleetRequestConfigData(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SpotFleetFactory, InnerSpotFleetSpotFleetRequestConfigDataFactory> WithSpotFleetRequestConfigData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SpotFleetFactory> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotFleetRequestConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpotFleetRequestConfigData(combinedResult.T5, subFactoryAction));
}
