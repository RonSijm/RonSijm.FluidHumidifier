// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerAppBlockScriptDetailsFactory(Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.AppBlockTypes.ScriptDetails>
{

    internal InnerAppBlockS3LocationFactory ScriptS3LocationFactory { get; set; }

    protected override Humidifier.AppStream.AppBlockTypes.ScriptDetails Create()
    {
        var scriptDetailsResult = CreateScriptDetails();
        factoryAction?.Invoke(scriptDetailsResult);

        return scriptDetailsResult;
    }

    private Humidifier.AppStream.AppBlockTypes.ScriptDetails CreateScriptDetails()
    {
        var scriptDetailsResult = new Humidifier.AppStream.AppBlockTypes.ScriptDetails();

        return scriptDetailsResult;
    }
    public override void CreateChildren(Humidifier.AppStream.AppBlockTypes.ScriptDetails result)
    {
        base.CreateChildren(result);

        result.ScriptS3Location ??= ScriptS3LocationFactory?.Build();
    }

} // End Of Class

public static class InnerAppBlockScriptDetailsFactoryExtensions
{
    public static CombinedResult<InnerAppBlockScriptDetailsFactory, InnerAppBlockS3LocationFactory> WithScriptS3Location(this InnerAppBlockScriptDetailsFactory parentFactory, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.ScriptS3LocationFactory = new InnerAppBlockS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScriptS3LocationFactory);
    }

    public static CombinedResult<InnerAppBlockScriptDetailsFactory, T1, InnerAppBlockS3LocationFactory> WithScriptS3Location<T1>(this CombinedResult<InnerAppBlockScriptDetailsFactory, T1> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithScriptS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppBlockScriptDetailsFactory, InnerAppBlockS3LocationFactory> WithScriptS3Location<T1>(this CombinedResult<T1, InnerAppBlockScriptDetailsFactory> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithScriptS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAppBlockScriptDetailsFactory, T1, T2, InnerAppBlockS3LocationFactory> WithScriptS3Location<T1, T2>(this CombinedResult<InnerAppBlockScriptDetailsFactory, T1, T2> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScriptS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppBlockScriptDetailsFactory, T2, InnerAppBlockS3LocationFactory> WithScriptS3Location<T1, T2>(this CombinedResult<T1, InnerAppBlockScriptDetailsFactory, T2> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScriptS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAppBlockScriptDetailsFactory, InnerAppBlockS3LocationFactory> WithScriptS3Location<T1, T2>(this CombinedResult<T1, T2, InnerAppBlockScriptDetailsFactory> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScriptS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAppBlockScriptDetailsFactory, T1, T2, T3, InnerAppBlockS3LocationFactory> WithScriptS3Location<T1, T2, T3>(this CombinedResult<InnerAppBlockScriptDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScriptS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppBlockScriptDetailsFactory, T2, T3, InnerAppBlockS3LocationFactory> WithScriptS3Location<T1, T2, T3>(this CombinedResult<T1, InnerAppBlockScriptDetailsFactory, T2, T3> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScriptS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAppBlockScriptDetailsFactory, T3, InnerAppBlockS3LocationFactory> WithScriptS3Location<T1, T2, T3>(this CombinedResult<T1, T2, InnerAppBlockScriptDetailsFactory, T3> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScriptS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAppBlockScriptDetailsFactory, InnerAppBlockS3LocationFactory> WithScriptS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAppBlockScriptDetailsFactory> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScriptS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAppBlockScriptDetailsFactory, T1, T2, T3, T4, InnerAppBlockS3LocationFactory> WithScriptS3Location<T1, T2, T3, T4>(this CombinedResult<InnerAppBlockScriptDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScriptS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppBlockScriptDetailsFactory, T2, T3, T4, InnerAppBlockS3LocationFactory> WithScriptS3Location<T1, T2, T3, T4>(this CombinedResult<T1, InnerAppBlockScriptDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScriptS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAppBlockScriptDetailsFactory, T3, T4, InnerAppBlockS3LocationFactory> WithScriptS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAppBlockScriptDetailsFactory, T3, T4> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScriptS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAppBlockScriptDetailsFactory, T4, InnerAppBlockS3LocationFactory> WithScriptS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAppBlockScriptDetailsFactory, T4> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScriptS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAppBlockScriptDetailsFactory, InnerAppBlockS3LocationFactory> WithScriptS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAppBlockScriptDetailsFactory> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScriptS3Location(combinedResult.T5, subFactoryAction));
}
