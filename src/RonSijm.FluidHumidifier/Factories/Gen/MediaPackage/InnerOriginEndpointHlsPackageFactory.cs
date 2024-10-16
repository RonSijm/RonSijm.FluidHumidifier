// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerOriginEndpointHlsPackageFactory(Action<Humidifier.MediaPackage.OriginEndpointTypes.HlsPackage> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.OriginEndpointTypes.HlsPackage>
{

    internal InnerOriginEndpointStreamSelectionFactory StreamSelectionFactory { get; set; }

    internal InnerOriginEndpointHlsEncryptionFactory EncryptionFactory { get; set; }

    protected override Humidifier.MediaPackage.OriginEndpointTypes.HlsPackage Create()
    {
        var hlsPackageResult = CreateHlsPackage();
        factoryAction?.Invoke(hlsPackageResult);

        return hlsPackageResult;
    }

    private Humidifier.MediaPackage.OriginEndpointTypes.HlsPackage CreateHlsPackage()
    {
        var hlsPackageResult = new Humidifier.MediaPackage.OriginEndpointTypes.HlsPackage();

        return hlsPackageResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.OriginEndpointTypes.HlsPackage result)
    {
        base.CreateChildren(result);

        result.StreamSelection ??= StreamSelectionFactory?.Build();
        result.Encryption ??= EncryptionFactory?.Build();
    }

} // End Of Class

public static class InnerOriginEndpointHlsPackageFactoryExtensions
{
    public static CombinedResult<InnerOriginEndpointHlsPackageFactory, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection(this InnerOriginEndpointHlsPackageFactory parentFactory, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null)
    {
        parentFactory.StreamSelectionFactory = new InnerOriginEndpointStreamSelectionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StreamSelectionFactory);
    }

    public static CombinedResult<InnerOriginEndpointHlsPackageFactory, InnerOriginEndpointHlsEncryptionFactory> WithEncryption(this InnerOriginEndpointHlsPackageFactory parentFactory, Action<Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption> subFactoryAction = null)
    {
        parentFactory.EncryptionFactory = new InnerOriginEndpointHlsEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionFactory);
    }

    public static CombinedResult<InnerOriginEndpointHlsPackageFactory, T1, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1>(this CombinedResult<InnerOriginEndpointHlsPackageFactory, T1> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, WithStreamSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointHlsPackageFactory, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1>(this CombinedResult<T1, InnerOriginEndpointHlsPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, WithStreamSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointHlsPackageFactory, T1, T2, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2>(this CombinedResult<InnerOriginEndpointHlsPackageFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointHlsPackageFactory, T2, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2>(this CombinedResult<T1, InnerOriginEndpointHlsPackageFactory, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointHlsPackageFactory, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointHlsPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointHlsPackageFactory, T1, T2, T3, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3>(this CombinedResult<InnerOriginEndpointHlsPackageFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointHlsPackageFactory, T2, T3, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointHlsPackageFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointHlsPackageFactory, T3, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointHlsPackageFactory, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointHlsPackageFactory, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointHlsPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointHlsPackageFactory, T1, T2, T3, T4, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointHlsPackageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointHlsPackageFactory, T2, T3, T4, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointHlsPackageFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointHlsPackageFactory, T3, T4, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointHlsPackageFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointHlsPackageFactory, T4, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointHlsPackageFactory, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointHlsPackageFactory, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointHlsPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointHlsPackageFactory, T1, InnerOriginEndpointHlsEncryptionFactory> WithEncryption<T1>(this CombinedResult<InnerOriginEndpointHlsPackageFactory, T1> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointHlsPackageFactory, InnerOriginEndpointHlsEncryptionFactory> WithEncryption<T1>(this CombinedResult<T1, InnerOriginEndpointHlsPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointHlsPackageFactory, T1, T2, InnerOriginEndpointHlsEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<InnerOriginEndpointHlsPackageFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointHlsPackageFactory, T2, InnerOriginEndpointHlsEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, InnerOriginEndpointHlsPackageFactory, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointHlsPackageFactory, InnerOriginEndpointHlsEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointHlsPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointHlsPackageFactory, T1, T2, T3, InnerOriginEndpointHlsEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<InnerOriginEndpointHlsPackageFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointHlsPackageFactory, T2, T3, InnerOriginEndpointHlsEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointHlsPackageFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointHlsPackageFactory, T3, InnerOriginEndpointHlsEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointHlsPackageFactory, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointHlsPackageFactory, InnerOriginEndpointHlsEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointHlsPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointHlsPackageFactory, T1, T2, T3, T4, InnerOriginEndpointHlsEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointHlsPackageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointHlsPackageFactory, T2, T3, T4, InnerOriginEndpointHlsEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointHlsPackageFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointHlsPackageFactory, T3, T4, InnerOriginEndpointHlsEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointHlsPackageFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointHlsPackageFactory, T4, InnerOriginEndpointHlsEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointHlsPackageFactory, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointHlsPackageFactory, InnerOriginEndpointHlsEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointHlsPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T5, subFactoryAction));
}
