// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerOriginEndpointMssPackageFactory(Action<Humidifier.MediaPackage.OriginEndpointTypes.MssPackage> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.OriginEndpointTypes.MssPackage>
{

    internal InnerOriginEndpointStreamSelectionFactory StreamSelectionFactory { get; set; }

    internal InnerOriginEndpointMssEncryptionFactory EncryptionFactory { get; set; }

    protected override Humidifier.MediaPackage.OriginEndpointTypes.MssPackage Create()
    {
        var mssPackageResult = CreateMssPackage();
        factoryAction?.Invoke(mssPackageResult);

        return mssPackageResult;
    }

    private Humidifier.MediaPackage.OriginEndpointTypes.MssPackage CreateMssPackage()
    {
        var mssPackageResult = new Humidifier.MediaPackage.OriginEndpointTypes.MssPackage();

        return mssPackageResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.OriginEndpointTypes.MssPackage result)
    {
        base.CreateChildren(result);

        result.StreamSelection ??= StreamSelectionFactory?.Build();
        result.Encryption ??= EncryptionFactory?.Build();
    }

} // End Of Class

public static class InnerOriginEndpointMssPackageFactoryExtensions
{
    public static CombinedResult<InnerOriginEndpointMssPackageFactory, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection(this InnerOriginEndpointMssPackageFactory parentFactory, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null)
    {
        parentFactory.StreamSelectionFactory = new InnerOriginEndpointStreamSelectionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StreamSelectionFactory);
    }

    public static CombinedResult<InnerOriginEndpointMssPackageFactory, InnerOriginEndpointMssEncryptionFactory> WithEncryption(this InnerOriginEndpointMssPackageFactory parentFactory, Action<Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption> subFactoryAction = null)
    {
        parentFactory.EncryptionFactory = new InnerOriginEndpointMssEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionFactory);
    }

    public static CombinedResult<InnerOriginEndpointMssPackageFactory, T1, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1>(this CombinedResult<InnerOriginEndpointMssPackageFactory, T1> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, WithStreamSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointMssPackageFactory, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1>(this CombinedResult<T1, InnerOriginEndpointMssPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, WithStreamSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointMssPackageFactory, T1, T2, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2>(this CombinedResult<InnerOriginEndpointMssPackageFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointMssPackageFactory, T2, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2>(this CombinedResult<T1, InnerOriginEndpointMssPackageFactory, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointMssPackageFactory, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointMssPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointMssPackageFactory, T1, T2, T3, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3>(this CombinedResult<InnerOriginEndpointMssPackageFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointMssPackageFactory, T2, T3, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointMssPackageFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointMssPackageFactory, T3, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointMssPackageFactory, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointMssPackageFactory, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointMssPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointMssPackageFactory, T1, T2, T3, T4, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointMssPackageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointMssPackageFactory, T2, T3, T4, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointMssPackageFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointMssPackageFactory, T3, T4, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointMssPackageFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointMssPackageFactory, T4, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointMssPackageFactory, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointMssPackageFactory, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointMssPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointMssPackageFactory, T1, InnerOriginEndpointMssEncryptionFactory> WithEncryption<T1>(this CombinedResult<InnerOriginEndpointMssPackageFactory, T1> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointMssPackageFactory, InnerOriginEndpointMssEncryptionFactory> WithEncryption<T1>(this CombinedResult<T1, InnerOriginEndpointMssPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointMssPackageFactory, T1, T2, InnerOriginEndpointMssEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<InnerOriginEndpointMssPackageFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointMssPackageFactory, T2, InnerOriginEndpointMssEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, InnerOriginEndpointMssPackageFactory, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointMssPackageFactory, InnerOriginEndpointMssEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointMssPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointMssPackageFactory, T1, T2, T3, InnerOriginEndpointMssEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<InnerOriginEndpointMssPackageFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointMssPackageFactory, T2, T3, InnerOriginEndpointMssEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointMssPackageFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointMssPackageFactory, T3, InnerOriginEndpointMssEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointMssPackageFactory, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointMssPackageFactory, InnerOriginEndpointMssEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointMssPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointMssPackageFactory, T1, T2, T3, T4, InnerOriginEndpointMssEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointMssPackageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointMssPackageFactory, T2, T3, T4, InnerOriginEndpointMssEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointMssPackageFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointMssPackageFactory, T3, T4, InnerOriginEndpointMssEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointMssPackageFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointMssPackageFactory, T4, InnerOriginEndpointMssEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointMssPackageFactory, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointMssPackageFactory, InnerOriginEndpointMssEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointMssPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T5, subFactoryAction));
}
