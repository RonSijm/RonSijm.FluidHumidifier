// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualNodeTlsValidationContextTrustFactory(Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextTrust> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextTrust>
{

    internal InnerVirtualNodeTlsValidationContextSdsTrustFactory SDSFactory { get; set; }

    internal InnerVirtualNodeTlsValidationContextAcmTrustFactory ACMFactory { get; set; }

    internal InnerVirtualNodeTlsValidationContextFileTrustFactory FileFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextTrust Create()
    {
        var tlsValidationContextTrustResult = CreateTlsValidationContextTrust();
        factoryAction?.Invoke(tlsValidationContextTrustResult);

        return tlsValidationContextTrustResult;
    }

    private Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextTrust CreateTlsValidationContextTrust()
    {
        var tlsValidationContextTrustResult = new Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextTrust();

        return tlsValidationContextTrustResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextTrust result)
    {
        base.CreateChildren(result);

        result.SDS ??= SDSFactory?.Build();
        result.ACM ??= ACMFactory?.Build();
        result.File ??= FileFactory?.Build();
    }

} // End Of Class

public static class InnerVirtualNodeTlsValidationContextTrustFactoryExtensions
{
    public static CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, InnerVirtualNodeTlsValidationContextSdsTrustFactory> WithSDS(this InnerVirtualNodeTlsValidationContextTrustFactory parentFactory, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust> subFactoryAction = null)
    {
        parentFactory.SDSFactory = new InnerVirtualNodeTlsValidationContextSdsTrustFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SDSFactory);
    }

    public static CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, InnerVirtualNodeTlsValidationContextAcmTrustFactory> WithACM(this InnerVirtualNodeTlsValidationContextTrustFactory parentFactory, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust> subFactoryAction = null)
    {
        parentFactory.ACMFactory = new InnerVirtualNodeTlsValidationContextAcmTrustFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ACMFactory);
    }

    public static CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, InnerVirtualNodeTlsValidationContextFileTrustFactory> WithFile(this InnerVirtualNodeTlsValidationContextTrustFactory parentFactory, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust> subFactoryAction = null)
    {
        parentFactory.FileFactory = new InnerVirtualNodeTlsValidationContextFileTrustFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FileFactory);
    }

    public static CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, InnerVirtualNodeTlsValidationContextSdsTrustFactory> WithSDS<T1>(this CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust> subFactoryAction = null) => new (combinedResult, combinedResult, WithSDS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, InnerVirtualNodeTlsValidationContextSdsTrustFactory> WithSDS<T1>(this CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust> subFactoryAction = null) => new (combinedResult, combinedResult, WithSDS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, T2, InnerVirtualNodeTlsValidationContextSdsTrustFactory> WithSDS<T1, T2>(this CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, T2, InnerVirtualNodeTlsValidationContextSdsTrustFactory> WithSDS<T1, T2>(this CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeTlsValidationContextTrustFactory, InnerVirtualNodeTlsValidationContextSdsTrustFactory> WithSDS<T1, T2>(this CombinedResult<T1, T2, InnerVirtualNodeTlsValidationContextTrustFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, T2, T3, InnerVirtualNodeTlsValidationContextSdsTrustFactory> WithSDS<T1, T2, T3>(this CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, T2, T3, InnerVirtualNodeTlsValidationContextSdsTrustFactory> WithSDS<T1, T2, T3>(this CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeTlsValidationContextTrustFactory, T3, InnerVirtualNodeTlsValidationContextSdsTrustFactory> WithSDS<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualNodeTlsValidationContextTrustFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeTlsValidationContextTrustFactory, InnerVirtualNodeTlsValidationContextSdsTrustFactory> WithSDS<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualNodeTlsValidationContextTrustFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, T2, T3, T4, InnerVirtualNodeTlsValidationContextSdsTrustFactory> WithSDS<T1, T2, T3, T4>(this CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, T2, T3, T4, InnerVirtualNodeTlsValidationContextSdsTrustFactory> WithSDS<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeTlsValidationContextTrustFactory, T3, T4, InnerVirtualNodeTlsValidationContextSdsTrustFactory> WithSDS<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualNodeTlsValidationContextTrustFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeTlsValidationContextTrustFactory, T4, InnerVirtualNodeTlsValidationContextSdsTrustFactory> WithSDS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualNodeTlsValidationContextTrustFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualNodeTlsValidationContextTrustFactory, InnerVirtualNodeTlsValidationContextSdsTrustFactory> WithSDS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualNodeTlsValidationContextTrustFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSDS(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, InnerVirtualNodeTlsValidationContextAcmTrustFactory> WithACM<T1>(this CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust> subFactoryAction = null) => new (combinedResult, combinedResult, WithACM(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, InnerVirtualNodeTlsValidationContextAcmTrustFactory> WithACM<T1>(this CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust> subFactoryAction = null) => new (combinedResult, combinedResult, WithACM(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, T2, InnerVirtualNodeTlsValidationContextAcmTrustFactory> WithACM<T1, T2>(this CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithACM(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, T2, InnerVirtualNodeTlsValidationContextAcmTrustFactory> WithACM<T1, T2>(this CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithACM(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeTlsValidationContextTrustFactory, InnerVirtualNodeTlsValidationContextAcmTrustFactory> WithACM<T1, T2>(this CombinedResult<T1, T2, InnerVirtualNodeTlsValidationContextTrustFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithACM(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, T2, T3, InnerVirtualNodeTlsValidationContextAcmTrustFactory> WithACM<T1, T2, T3>(this CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithACM(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, T2, T3, InnerVirtualNodeTlsValidationContextAcmTrustFactory> WithACM<T1, T2, T3>(this CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithACM(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeTlsValidationContextTrustFactory, T3, InnerVirtualNodeTlsValidationContextAcmTrustFactory> WithACM<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualNodeTlsValidationContextTrustFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithACM(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeTlsValidationContextTrustFactory, InnerVirtualNodeTlsValidationContextAcmTrustFactory> WithACM<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualNodeTlsValidationContextTrustFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithACM(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, T2, T3, T4, InnerVirtualNodeTlsValidationContextAcmTrustFactory> WithACM<T1, T2, T3, T4>(this CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithACM(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, T2, T3, T4, InnerVirtualNodeTlsValidationContextAcmTrustFactory> WithACM<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithACM(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeTlsValidationContextTrustFactory, T3, T4, InnerVirtualNodeTlsValidationContextAcmTrustFactory> WithACM<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualNodeTlsValidationContextTrustFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithACM(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeTlsValidationContextTrustFactory, T4, InnerVirtualNodeTlsValidationContextAcmTrustFactory> WithACM<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualNodeTlsValidationContextTrustFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithACM(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualNodeTlsValidationContextTrustFactory, InnerVirtualNodeTlsValidationContextAcmTrustFactory> WithACM<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualNodeTlsValidationContextTrustFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithACM(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, InnerVirtualNodeTlsValidationContextFileTrustFactory> WithFile<T1>(this CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust> subFactoryAction = null) => new (combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, InnerVirtualNodeTlsValidationContextFileTrustFactory> WithFile<T1>(this CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust> subFactoryAction = null) => new (combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, T2, InnerVirtualNodeTlsValidationContextFileTrustFactory> WithFile<T1, T2>(this CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, T2, InnerVirtualNodeTlsValidationContextFileTrustFactory> WithFile<T1, T2>(this CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeTlsValidationContextTrustFactory, InnerVirtualNodeTlsValidationContextFileTrustFactory> WithFile<T1, T2>(this CombinedResult<T1, T2, InnerVirtualNodeTlsValidationContextTrustFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, T2, T3, InnerVirtualNodeTlsValidationContextFileTrustFactory> WithFile<T1, T2, T3>(this CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, T2, T3, InnerVirtualNodeTlsValidationContextFileTrustFactory> WithFile<T1, T2, T3>(this CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeTlsValidationContextTrustFactory, T3, InnerVirtualNodeTlsValidationContextFileTrustFactory> WithFile<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualNodeTlsValidationContextTrustFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeTlsValidationContextTrustFactory, InnerVirtualNodeTlsValidationContextFileTrustFactory> WithFile<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualNodeTlsValidationContextTrustFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, T2, T3, T4, InnerVirtualNodeTlsValidationContextFileTrustFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<InnerVirtualNodeTlsValidationContextTrustFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, T2, T3, T4, InnerVirtualNodeTlsValidationContextFileTrustFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualNodeTlsValidationContextTrustFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeTlsValidationContextTrustFactory, T3, T4, InnerVirtualNodeTlsValidationContextFileTrustFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualNodeTlsValidationContextTrustFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeTlsValidationContextTrustFactory, T4, InnerVirtualNodeTlsValidationContextFileTrustFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualNodeTlsValidationContextTrustFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualNodeTlsValidationContextTrustFactory, InnerVirtualNodeTlsValidationContextFileTrustFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualNodeTlsValidationContextTrustFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T5, subFactoryAction));
}
