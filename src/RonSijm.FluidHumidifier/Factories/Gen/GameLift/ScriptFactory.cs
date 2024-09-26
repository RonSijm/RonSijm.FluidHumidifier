// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class ScriptFactory(string resourceName = null, Action<Humidifier.GameLift.Script> factoryAction = null) : ResourceFactory<Humidifier.GameLift.Script>(resourceName)
{

    internal InnerScriptS3LocationFactory StorageLocationFactory { get; set; }

    protected override Humidifier.GameLift.Script Create()
    {
        var scriptResult = CreateScript();
        factoryAction?.Invoke(scriptResult);

        return scriptResult;
    }

    private Humidifier.GameLift.Script CreateScript()
    {
        var scriptResult = new Humidifier.GameLift.Script
        {
            GivenName = InputResourceName,
        };

        return scriptResult;
    }
    public override void CreateChildren(Humidifier.GameLift.Script result)
    {
        base.CreateChildren(result);

        result.StorageLocation ??= StorageLocationFactory?.Build();
    }

} // End Of Class

public static class ScriptFactoryExtensions
{
    public static CombinedResult<ScriptFactory, InnerScriptS3LocationFactory> WithStorageLocation(this ScriptFactory parentFactory, Action<Humidifier.GameLift.ScriptTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.StorageLocationFactory = new InnerScriptS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StorageLocationFactory);
    }

    public static CombinedResult<ScriptFactory, T1, InnerScriptS3LocationFactory> WithStorageLocation<T1>(this CombinedResult<ScriptFactory, T1> combinedResult, Action<Humidifier.GameLift.ScriptTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScriptFactory, InnerScriptS3LocationFactory> WithStorageLocation<T1>(this CombinedResult<T1, ScriptFactory> combinedResult, Action<Humidifier.GameLift.ScriptTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ScriptFactory, T1, T2, InnerScriptS3LocationFactory> WithStorageLocation<T1, T2>(this CombinedResult<ScriptFactory, T1, T2> combinedResult, Action<Humidifier.GameLift.ScriptTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScriptFactory, T2, InnerScriptS3LocationFactory> WithStorageLocation<T1, T2>(this CombinedResult<T1, ScriptFactory, T2> combinedResult, Action<Humidifier.GameLift.ScriptTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScriptFactory, InnerScriptS3LocationFactory> WithStorageLocation<T1, T2>(this CombinedResult<T1, T2, ScriptFactory> combinedResult, Action<Humidifier.GameLift.ScriptTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ScriptFactory, T1, T2, T3, InnerScriptS3LocationFactory> WithStorageLocation<T1, T2, T3>(this CombinedResult<ScriptFactory, T1, T2, T3> combinedResult, Action<Humidifier.GameLift.ScriptTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScriptFactory, T2, T3, InnerScriptS3LocationFactory> WithStorageLocation<T1, T2, T3>(this CombinedResult<T1, ScriptFactory, T2, T3> combinedResult, Action<Humidifier.GameLift.ScriptTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScriptFactory, T3, InnerScriptS3LocationFactory> WithStorageLocation<T1, T2, T3>(this CombinedResult<T1, T2, ScriptFactory, T3> combinedResult, Action<Humidifier.GameLift.ScriptTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScriptFactory, InnerScriptS3LocationFactory> WithStorageLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, ScriptFactory> combinedResult, Action<Humidifier.GameLift.ScriptTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ScriptFactory, T1, T2, T3, T4, InnerScriptS3LocationFactory> WithStorageLocation<T1, T2, T3, T4>(this CombinedResult<ScriptFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.ScriptTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScriptFactory, T2, T3, T4, InnerScriptS3LocationFactory> WithStorageLocation<T1, T2, T3, T4>(this CombinedResult<T1, ScriptFactory, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.ScriptTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScriptFactory, T3, T4, InnerScriptS3LocationFactory> WithStorageLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, ScriptFactory, T3, T4> combinedResult, Action<Humidifier.GameLift.ScriptTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScriptFactory, T4, InnerScriptS3LocationFactory> WithStorageLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ScriptFactory, T4> combinedResult, Action<Humidifier.GameLift.ScriptTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ScriptFactory, InnerScriptS3LocationFactory> WithStorageLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ScriptFactory> combinedResult, Action<Humidifier.GameLift.ScriptTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T5, subFactoryAction));
}
