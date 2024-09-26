// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class AppBlockFactory(string resourceName = null, Action<Humidifier.AppStream.AppBlock> factoryAction = null) : ResourceFactory<Humidifier.AppStream.AppBlock>(resourceName)
{

    internal InnerAppBlockScriptDetailsFactory SetupScriptDetailsFactory { get; set; }

    internal InnerAppBlockScriptDetailsFactory PostSetupScriptDetailsFactory { get; set; }

    internal InnerAppBlockS3LocationFactory SourceS3LocationFactory { get; set; }

    protected override Humidifier.AppStream.AppBlock Create()
    {
        var appBlockResult = CreateAppBlock();
        factoryAction?.Invoke(appBlockResult);

        return appBlockResult;
    }

    private Humidifier.AppStream.AppBlock CreateAppBlock()
    {
        var appBlockResult = new Humidifier.AppStream.AppBlock
        {
            GivenName = InputResourceName,
        };

        return appBlockResult;
    }
    public override void CreateChildren(Humidifier.AppStream.AppBlock result)
    {
        base.CreateChildren(result);

        result.SetupScriptDetails ??= SetupScriptDetailsFactory?.Build();
        result.PostSetupScriptDetails ??= PostSetupScriptDetailsFactory?.Build();
        result.SourceS3Location ??= SourceS3LocationFactory?.Build();
    }

} // End Of Class

public static class AppBlockFactoryExtensions
{
    public static CombinedResult<AppBlockFactory, InnerAppBlockScriptDetailsFactory> WithSetupScriptDetails(this AppBlockFactory parentFactory, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null)
    {
        parentFactory.SetupScriptDetailsFactory = new InnerAppBlockScriptDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SetupScriptDetailsFactory);
    }

    public static CombinedResult<AppBlockFactory, InnerAppBlockScriptDetailsFactory> WithPostSetupScriptDetails(this AppBlockFactory parentFactory, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null)
    {
        parentFactory.PostSetupScriptDetailsFactory = new InnerAppBlockScriptDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PostSetupScriptDetailsFactory);
    }

    public static CombinedResult<AppBlockFactory, InnerAppBlockS3LocationFactory> WithSourceS3Location(this AppBlockFactory parentFactory, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.SourceS3LocationFactory = new InnerAppBlockS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceS3LocationFactory);
    }

    public static CombinedResult<AppBlockFactory, T1, InnerAppBlockScriptDetailsFactory> WithSetupScriptDetails<T1>(this CombinedResult<AppBlockFactory, T1> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithSetupScriptDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppBlockFactory, InnerAppBlockScriptDetailsFactory> WithSetupScriptDetails<T1>(this CombinedResult<T1, AppBlockFactory> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithSetupScriptDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AppBlockFactory, T1, T2, InnerAppBlockScriptDetailsFactory> WithSetupScriptDetails<T1, T2>(this CombinedResult<AppBlockFactory, T1, T2> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSetupScriptDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppBlockFactory, T2, InnerAppBlockScriptDetailsFactory> WithSetupScriptDetails<T1, T2>(this CombinedResult<T1, AppBlockFactory, T2> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSetupScriptDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppBlockFactory, InnerAppBlockScriptDetailsFactory> WithSetupScriptDetails<T1, T2>(this CombinedResult<T1, T2, AppBlockFactory> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSetupScriptDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AppBlockFactory, T1, T2, T3, InnerAppBlockScriptDetailsFactory> WithSetupScriptDetails<T1, T2, T3>(this CombinedResult<AppBlockFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSetupScriptDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppBlockFactory, T2, T3, InnerAppBlockScriptDetailsFactory> WithSetupScriptDetails<T1, T2, T3>(this CombinedResult<T1, AppBlockFactory, T2, T3> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSetupScriptDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppBlockFactory, T3, InnerAppBlockScriptDetailsFactory> WithSetupScriptDetails<T1, T2, T3>(this CombinedResult<T1, T2, AppBlockFactory, T3> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSetupScriptDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppBlockFactory, InnerAppBlockScriptDetailsFactory> WithSetupScriptDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, AppBlockFactory> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSetupScriptDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AppBlockFactory, T1, T2, T3, T4, InnerAppBlockScriptDetailsFactory> WithSetupScriptDetails<T1, T2, T3, T4>(this CombinedResult<AppBlockFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSetupScriptDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppBlockFactory, T2, T3, T4, InnerAppBlockScriptDetailsFactory> WithSetupScriptDetails<T1, T2, T3, T4>(this CombinedResult<T1, AppBlockFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSetupScriptDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppBlockFactory, T3, T4, InnerAppBlockScriptDetailsFactory> WithSetupScriptDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, AppBlockFactory, T3, T4> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSetupScriptDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppBlockFactory, T4, InnerAppBlockScriptDetailsFactory> WithSetupScriptDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AppBlockFactory, T4> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSetupScriptDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AppBlockFactory, InnerAppBlockScriptDetailsFactory> WithSetupScriptDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AppBlockFactory> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSetupScriptDetails(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AppBlockFactory, T1, InnerAppBlockScriptDetailsFactory> WithPostSetupScriptDetails<T1>(this CombinedResult<AppBlockFactory, T1> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithPostSetupScriptDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppBlockFactory, InnerAppBlockScriptDetailsFactory> WithPostSetupScriptDetails<T1>(this CombinedResult<T1, AppBlockFactory> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithPostSetupScriptDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AppBlockFactory, T1, T2, InnerAppBlockScriptDetailsFactory> WithPostSetupScriptDetails<T1, T2>(this CombinedResult<AppBlockFactory, T1, T2> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPostSetupScriptDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppBlockFactory, T2, InnerAppBlockScriptDetailsFactory> WithPostSetupScriptDetails<T1, T2>(this CombinedResult<T1, AppBlockFactory, T2> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPostSetupScriptDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppBlockFactory, InnerAppBlockScriptDetailsFactory> WithPostSetupScriptDetails<T1, T2>(this CombinedResult<T1, T2, AppBlockFactory> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPostSetupScriptDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AppBlockFactory, T1, T2, T3, InnerAppBlockScriptDetailsFactory> WithPostSetupScriptDetails<T1, T2, T3>(this CombinedResult<AppBlockFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPostSetupScriptDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppBlockFactory, T2, T3, InnerAppBlockScriptDetailsFactory> WithPostSetupScriptDetails<T1, T2, T3>(this CombinedResult<T1, AppBlockFactory, T2, T3> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPostSetupScriptDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppBlockFactory, T3, InnerAppBlockScriptDetailsFactory> WithPostSetupScriptDetails<T1, T2, T3>(this CombinedResult<T1, T2, AppBlockFactory, T3> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPostSetupScriptDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppBlockFactory, InnerAppBlockScriptDetailsFactory> WithPostSetupScriptDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, AppBlockFactory> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPostSetupScriptDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AppBlockFactory, T1, T2, T3, T4, InnerAppBlockScriptDetailsFactory> WithPostSetupScriptDetails<T1, T2, T3, T4>(this CombinedResult<AppBlockFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPostSetupScriptDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppBlockFactory, T2, T3, T4, InnerAppBlockScriptDetailsFactory> WithPostSetupScriptDetails<T1, T2, T3, T4>(this CombinedResult<T1, AppBlockFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPostSetupScriptDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppBlockFactory, T3, T4, InnerAppBlockScriptDetailsFactory> WithPostSetupScriptDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, AppBlockFactory, T3, T4> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPostSetupScriptDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppBlockFactory, T4, InnerAppBlockScriptDetailsFactory> WithPostSetupScriptDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AppBlockFactory, T4> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPostSetupScriptDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AppBlockFactory, InnerAppBlockScriptDetailsFactory> WithPostSetupScriptDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AppBlockFactory> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.ScriptDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPostSetupScriptDetails(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AppBlockFactory, T1, InnerAppBlockS3LocationFactory> WithSourceS3Location<T1>(this CombinedResult<AppBlockFactory, T1> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppBlockFactory, InnerAppBlockS3LocationFactory> WithSourceS3Location<T1>(this CombinedResult<T1, AppBlockFactory> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AppBlockFactory, T1, T2, InnerAppBlockS3LocationFactory> WithSourceS3Location<T1, T2>(this CombinedResult<AppBlockFactory, T1, T2> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppBlockFactory, T2, InnerAppBlockS3LocationFactory> WithSourceS3Location<T1, T2>(this CombinedResult<T1, AppBlockFactory, T2> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppBlockFactory, InnerAppBlockS3LocationFactory> WithSourceS3Location<T1, T2>(this CombinedResult<T1, T2, AppBlockFactory> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AppBlockFactory, T1, T2, T3, InnerAppBlockS3LocationFactory> WithSourceS3Location<T1, T2, T3>(this CombinedResult<AppBlockFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppBlockFactory, T2, T3, InnerAppBlockS3LocationFactory> WithSourceS3Location<T1, T2, T3>(this CombinedResult<T1, AppBlockFactory, T2, T3> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppBlockFactory, T3, InnerAppBlockS3LocationFactory> WithSourceS3Location<T1, T2, T3>(this CombinedResult<T1, T2, AppBlockFactory, T3> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppBlockFactory, InnerAppBlockS3LocationFactory> WithSourceS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, AppBlockFactory> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AppBlockFactory, T1, T2, T3, T4, InnerAppBlockS3LocationFactory> WithSourceS3Location<T1, T2, T3, T4>(this CombinedResult<AppBlockFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppBlockFactory, T2, T3, T4, InnerAppBlockS3LocationFactory> WithSourceS3Location<T1, T2, T3, T4>(this CombinedResult<T1, AppBlockFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppBlockFactory, T3, T4, InnerAppBlockS3LocationFactory> WithSourceS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, AppBlockFactory, T3, T4> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppBlockFactory, T4, InnerAppBlockS3LocationFactory> WithSourceS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AppBlockFactory, T4> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AppBlockFactory, InnerAppBlockS3LocationFactory> WithSourceS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AppBlockFactory> combinedResult, Action<Humidifier.AppStream.AppBlockTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Location(combinedResult.T5, subFactoryAction));
}
