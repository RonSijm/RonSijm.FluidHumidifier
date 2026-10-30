// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerOTAUpdateCodeSigningFactory(Action<Humidifier.IoT.OTAUpdateTypes.CodeSigning> factoryAction = null) : SubResourceFactory<Humidifier.IoT.OTAUpdateTypes.CodeSigning>
{

    internal InnerOTAUpdateStartSigningJobParameterFactory StartSigningJobParameterFactory { get; set; }

    internal InnerOTAUpdateCustomCodeSigningFactory CustomCodeSigningFactory { get; set; }

    protected override Humidifier.IoT.OTAUpdateTypes.CodeSigning Create()
    {
        var codeSigningResult = CreateCodeSigning();
        factoryAction?.Invoke(codeSigningResult);

        return codeSigningResult;
    }

    private Humidifier.IoT.OTAUpdateTypes.CodeSigning CreateCodeSigning()
    {
        var codeSigningResult = new Humidifier.IoT.OTAUpdateTypes.CodeSigning();

        return codeSigningResult;
    }
    public override void CreateChildren(Humidifier.IoT.OTAUpdateTypes.CodeSigning result)
    {
        base.CreateChildren(result);

        result.StartSigningJobParameter ??= StartSigningJobParameterFactory?.Build();
        result.CustomCodeSigning ??= CustomCodeSigningFactory?.Build();
    }

} // End Of Class

public static class InnerOTAUpdateCodeSigningFactoryExtensions
{
    public static CombinedResult<InnerOTAUpdateCodeSigningFactory, InnerOTAUpdateStartSigningJobParameterFactory> WithStartSigningJobParameter(this InnerOTAUpdateCodeSigningFactory parentFactory, Action<Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter> subFactoryAction = null)
    {
        parentFactory.StartSigningJobParameterFactory = new InnerOTAUpdateStartSigningJobParameterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StartSigningJobParameterFactory);
    }

    public static CombinedResult<InnerOTAUpdateCodeSigningFactory, InnerOTAUpdateCustomCodeSigningFactory> WithCustomCodeSigning(this InnerOTAUpdateCodeSigningFactory parentFactory, Action<Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning> subFactoryAction = null)
    {
        parentFactory.CustomCodeSigningFactory = new InnerOTAUpdateCustomCodeSigningFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomCodeSigningFactory);
    }

    public static CombinedResult<InnerOTAUpdateCodeSigningFactory, T1, InnerOTAUpdateStartSigningJobParameterFactory> WithStartSigningJobParameter<T1>(this CombinedResult<InnerOTAUpdateCodeSigningFactory, T1> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithStartSigningJobParameter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateCodeSigningFactory, InnerOTAUpdateStartSigningJobParameterFactory> WithStartSigningJobParameter<T1>(this CombinedResult<T1, InnerOTAUpdateCodeSigningFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithStartSigningJobParameter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateCodeSigningFactory, T1, T2, InnerOTAUpdateStartSigningJobParameterFactory> WithStartSigningJobParameter<T1, T2>(this CombinedResult<InnerOTAUpdateCodeSigningFactory, T1, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStartSigningJobParameter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateCodeSigningFactory, T2, InnerOTAUpdateStartSigningJobParameterFactory> WithStartSigningJobParameter<T1, T2>(this CombinedResult<T1, InnerOTAUpdateCodeSigningFactory, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStartSigningJobParameter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateCodeSigningFactory, InnerOTAUpdateStartSigningJobParameterFactory> WithStartSigningJobParameter<T1, T2>(this CombinedResult<T1, T2, InnerOTAUpdateCodeSigningFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStartSigningJobParameter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateCodeSigningFactory, T1, T2, T3, InnerOTAUpdateStartSigningJobParameterFactory> WithStartSigningJobParameter<T1, T2, T3>(this CombinedResult<InnerOTAUpdateCodeSigningFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartSigningJobParameter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateCodeSigningFactory, T2, T3, InnerOTAUpdateStartSigningJobParameterFactory> WithStartSigningJobParameter<T1, T2, T3>(this CombinedResult<T1, InnerOTAUpdateCodeSigningFactory, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartSigningJobParameter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateCodeSigningFactory, T3, InnerOTAUpdateStartSigningJobParameterFactory> WithStartSigningJobParameter<T1, T2, T3>(this CombinedResult<T1, T2, InnerOTAUpdateCodeSigningFactory, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartSigningJobParameter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateCodeSigningFactory, InnerOTAUpdateStartSigningJobParameterFactory> WithStartSigningJobParameter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOTAUpdateCodeSigningFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartSigningJobParameter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateCodeSigningFactory, T1, T2, T3, T4, InnerOTAUpdateStartSigningJobParameterFactory> WithStartSigningJobParameter<T1, T2, T3, T4>(this CombinedResult<InnerOTAUpdateCodeSigningFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartSigningJobParameter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateCodeSigningFactory, T2, T3, T4, InnerOTAUpdateStartSigningJobParameterFactory> WithStartSigningJobParameter<T1, T2, T3, T4>(this CombinedResult<T1, InnerOTAUpdateCodeSigningFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartSigningJobParameter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateCodeSigningFactory, T3, T4, InnerOTAUpdateStartSigningJobParameterFactory> WithStartSigningJobParameter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOTAUpdateCodeSigningFactory, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartSigningJobParameter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateCodeSigningFactory, T4, InnerOTAUpdateStartSigningJobParameterFactory> WithStartSigningJobParameter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOTAUpdateCodeSigningFactory, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartSigningJobParameter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOTAUpdateCodeSigningFactory, InnerOTAUpdateStartSigningJobParameterFactory> WithStartSigningJobParameter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOTAUpdateCodeSigningFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartSigningJobParameter(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateCodeSigningFactory, T1, InnerOTAUpdateCustomCodeSigningFactory> WithCustomCodeSigning<T1>(this CombinedResult<InnerOTAUpdateCodeSigningFactory, T1> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomCodeSigning(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateCodeSigningFactory, InnerOTAUpdateCustomCodeSigningFactory> WithCustomCodeSigning<T1>(this CombinedResult<T1, InnerOTAUpdateCodeSigningFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomCodeSigning(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateCodeSigningFactory, T1, T2, InnerOTAUpdateCustomCodeSigningFactory> WithCustomCodeSigning<T1, T2>(this CombinedResult<InnerOTAUpdateCodeSigningFactory, T1, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomCodeSigning(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateCodeSigningFactory, T2, InnerOTAUpdateCustomCodeSigningFactory> WithCustomCodeSigning<T1, T2>(this CombinedResult<T1, InnerOTAUpdateCodeSigningFactory, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomCodeSigning(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateCodeSigningFactory, InnerOTAUpdateCustomCodeSigningFactory> WithCustomCodeSigning<T1, T2>(this CombinedResult<T1, T2, InnerOTAUpdateCodeSigningFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomCodeSigning(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateCodeSigningFactory, T1, T2, T3, InnerOTAUpdateCustomCodeSigningFactory> WithCustomCodeSigning<T1, T2, T3>(this CombinedResult<InnerOTAUpdateCodeSigningFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomCodeSigning(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateCodeSigningFactory, T2, T3, InnerOTAUpdateCustomCodeSigningFactory> WithCustomCodeSigning<T1, T2, T3>(this CombinedResult<T1, InnerOTAUpdateCodeSigningFactory, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomCodeSigning(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateCodeSigningFactory, T3, InnerOTAUpdateCustomCodeSigningFactory> WithCustomCodeSigning<T1, T2, T3>(this CombinedResult<T1, T2, InnerOTAUpdateCodeSigningFactory, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomCodeSigning(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateCodeSigningFactory, InnerOTAUpdateCustomCodeSigningFactory> WithCustomCodeSigning<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOTAUpdateCodeSigningFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomCodeSigning(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateCodeSigningFactory, T1, T2, T3, T4, InnerOTAUpdateCustomCodeSigningFactory> WithCustomCodeSigning<T1, T2, T3, T4>(this CombinedResult<InnerOTAUpdateCodeSigningFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomCodeSigning(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateCodeSigningFactory, T2, T3, T4, InnerOTAUpdateCustomCodeSigningFactory> WithCustomCodeSigning<T1, T2, T3, T4>(this CombinedResult<T1, InnerOTAUpdateCodeSigningFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomCodeSigning(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateCodeSigningFactory, T3, T4, InnerOTAUpdateCustomCodeSigningFactory> WithCustomCodeSigning<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOTAUpdateCodeSigningFactory, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomCodeSigning(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateCodeSigningFactory, T4, InnerOTAUpdateCustomCodeSigningFactory> WithCustomCodeSigning<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOTAUpdateCodeSigningFactory, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomCodeSigning(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOTAUpdateCodeSigningFactory, InnerOTAUpdateCustomCodeSigningFactory> WithCustomCodeSigning<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOTAUpdateCodeSigningFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomCodeSigning(combinedResult.T5, subFactoryAction).T2);
}
