// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerOTAUpdateOTAUpdateFileFactory(Action<Humidifier.IoT.OTAUpdateTypes.OTAUpdateFile> factoryAction = null) : SubResourceFactory<Humidifier.IoT.OTAUpdateTypes.OTAUpdateFile>
{

    internal InnerOTAUpdateFileLocationFactory FileLocationFactory { get; set; }

    internal InnerOTAUpdateCodeSigningFactory CodeSigningFactory { get; set; }

    protected override Humidifier.IoT.OTAUpdateTypes.OTAUpdateFile Create()
    {
        var oTAUpdateFileResult = CreateOTAUpdateFile();
        factoryAction?.Invoke(oTAUpdateFileResult);

        return oTAUpdateFileResult;
    }

    private Humidifier.IoT.OTAUpdateTypes.OTAUpdateFile CreateOTAUpdateFile()
    {
        var oTAUpdateFileResult = new Humidifier.IoT.OTAUpdateTypes.OTAUpdateFile();

        return oTAUpdateFileResult;
    }
    public override void CreateChildren(Humidifier.IoT.OTAUpdateTypes.OTAUpdateFile result)
    {
        base.CreateChildren(result);

        result.FileLocation ??= FileLocationFactory?.Build();
        result.CodeSigning ??= CodeSigningFactory?.Build();
    }

} // End Of Class

public static class InnerOTAUpdateOTAUpdateFileFactoryExtensions
{
    public static CombinedResult<InnerOTAUpdateOTAUpdateFileFactory, InnerOTAUpdateFileLocationFactory> WithFileLocation(this InnerOTAUpdateOTAUpdateFileFactory parentFactory, Action<Humidifier.IoT.OTAUpdateTypes.FileLocation> subFactoryAction = null)
    {
        parentFactory.FileLocationFactory = new InnerOTAUpdateFileLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FileLocationFactory);
    }

    public static CombinedResult<InnerOTAUpdateOTAUpdateFileFactory, InnerOTAUpdateCodeSigningFactory> WithCodeSigning(this InnerOTAUpdateOTAUpdateFileFactory parentFactory, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigning> subFactoryAction = null)
    {
        parentFactory.CodeSigningFactory = new InnerOTAUpdateCodeSigningFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CodeSigningFactory);
    }

    public static CombinedResult<InnerOTAUpdateOTAUpdateFileFactory, T1, InnerOTAUpdateFileLocationFactory> WithFileLocation<T1>(this CombinedResult<InnerOTAUpdateOTAUpdateFileFactory, T1> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithFileLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateOTAUpdateFileFactory, InnerOTAUpdateFileLocationFactory> WithFileLocation<T1>(this CombinedResult<T1, InnerOTAUpdateOTAUpdateFileFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithFileLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateOTAUpdateFileFactory, T1, T2, InnerOTAUpdateFileLocationFactory> WithFileLocation<T1, T2>(this CombinedResult<InnerOTAUpdateOTAUpdateFileFactory, T1, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateOTAUpdateFileFactory, T2, InnerOTAUpdateFileLocationFactory> WithFileLocation<T1, T2>(this CombinedResult<T1, InnerOTAUpdateOTAUpdateFileFactory, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateOTAUpdateFileFactory, InnerOTAUpdateFileLocationFactory> WithFileLocation<T1, T2>(this CombinedResult<T1, T2, InnerOTAUpdateOTAUpdateFileFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateOTAUpdateFileFactory, T1, T2, T3, InnerOTAUpdateFileLocationFactory> WithFileLocation<T1, T2, T3>(this CombinedResult<InnerOTAUpdateOTAUpdateFileFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateOTAUpdateFileFactory, T2, T3, InnerOTAUpdateFileLocationFactory> WithFileLocation<T1, T2, T3>(this CombinedResult<T1, InnerOTAUpdateOTAUpdateFileFactory, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateOTAUpdateFileFactory, T3, InnerOTAUpdateFileLocationFactory> WithFileLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerOTAUpdateOTAUpdateFileFactory, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateOTAUpdateFileFactory, InnerOTAUpdateFileLocationFactory> WithFileLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOTAUpdateOTAUpdateFileFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateOTAUpdateFileFactory, T1, T2, T3, T4, InnerOTAUpdateFileLocationFactory> WithFileLocation<T1, T2, T3, T4>(this CombinedResult<InnerOTAUpdateOTAUpdateFileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateOTAUpdateFileFactory, T2, T3, T4, InnerOTAUpdateFileLocationFactory> WithFileLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerOTAUpdateOTAUpdateFileFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateOTAUpdateFileFactory, T3, T4, InnerOTAUpdateFileLocationFactory> WithFileLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOTAUpdateOTAUpdateFileFactory, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateOTAUpdateFileFactory, T4, InnerOTAUpdateFileLocationFactory> WithFileLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOTAUpdateOTAUpdateFileFactory, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOTAUpdateOTAUpdateFileFactory, InnerOTAUpdateFileLocationFactory> WithFileLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOTAUpdateOTAUpdateFileFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileLocation(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateOTAUpdateFileFactory, T1, InnerOTAUpdateCodeSigningFactory> WithCodeSigning<T1>(this CombinedResult<InnerOTAUpdateOTAUpdateFileFactory, T1> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeSigning(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateOTAUpdateFileFactory, InnerOTAUpdateCodeSigningFactory> WithCodeSigning<T1>(this CombinedResult<T1, InnerOTAUpdateOTAUpdateFileFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeSigning(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateOTAUpdateFileFactory, T1, T2, InnerOTAUpdateCodeSigningFactory> WithCodeSigning<T1, T2>(this CombinedResult<InnerOTAUpdateOTAUpdateFileFactory, T1, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeSigning(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateOTAUpdateFileFactory, T2, InnerOTAUpdateCodeSigningFactory> WithCodeSigning<T1, T2>(this CombinedResult<T1, InnerOTAUpdateOTAUpdateFileFactory, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeSigning(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateOTAUpdateFileFactory, InnerOTAUpdateCodeSigningFactory> WithCodeSigning<T1, T2>(this CombinedResult<T1, T2, InnerOTAUpdateOTAUpdateFileFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeSigning(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateOTAUpdateFileFactory, T1, T2, T3, InnerOTAUpdateCodeSigningFactory> WithCodeSigning<T1, T2, T3>(this CombinedResult<InnerOTAUpdateOTAUpdateFileFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeSigning(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateOTAUpdateFileFactory, T2, T3, InnerOTAUpdateCodeSigningFactory> WithCodeSigning<T1, T2, T3>(this CombinedResult<T1, InnerOTAUpdateOTAUpdateFileFactory, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeSigning(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateOTAUpdateFileFactory, T3, InnerOTAUpdateCodeSigningFactory> WithCodeSigning<T1, T2, T3>(this CombinedResult<T1, T2, InnerOTAUpdateOTAUpdateFileFactory, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeSigning(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateOTAUpdateFileFactory, InnerOTAUpdateCodeSigningFactory> WithCodeSigning<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOTAUpdateOTAUpdateFileFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeSigning(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateOTAUpdateFileFactory, T1, T2, T3, T4, InnerOTAUpdateCodeSigningFactory> WithCodeSigning<T1, T2, T3, T4>(this CombinedResult<InnerOTAUpdateOTAUpdateFileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeSigning(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateOTAUpdateFileFactory, T2, T3, T4, InnerOTAUpdateCodeSigningFactory> WithCodeSigning<T1, T2, T3, T4>(this CombinedResult<T1, InnerOTAUpdateOTAUpdateFileFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeSigning(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateOTAUpdateFileFactory, T3, T4, InnerOTAUpdateCodeSigningFactory> WithCodeSigning<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOTAUpdateOTAUpdateFileFactory, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeSigning(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateOTAUpdateFileFactory, T4, InnerOTAUpdateCodeSigningFactory> WithCodeSigning<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOTAUpdateOTAUpdateFileFactory, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeSigning(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOTAUpdateOTAUpdateFileFactory, InnerOTAUpdateCodeSigningFactory> WithCodeSigning<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOTAUpdateOTAUpdateFileFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeSigning(combinedResult.T5, subFactoryAction).T2);
}
