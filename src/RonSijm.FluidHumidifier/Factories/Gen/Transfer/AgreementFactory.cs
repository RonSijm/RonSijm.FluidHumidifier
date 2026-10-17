// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class AgreementFactory(string resourceName = null, Action<Humidifier.Transfer.Agreement> factoryAction = null) : ResourceFactory<Humidifier.Transfer.Agreement>(resourceName)
{

    internal InnerAgreementCustomDirectoriesFactory CustomDirectoriesFactory { get; set; }

    protected override Humidifier.Transfer.Agreement Create()
    {
        var agreementResult = CreateAgreement();
        factoryAction?.Invoke(agreementResult);

        return agreementResult;
    }

    private Humidifier.Transfer.Agreement CreateAgreement()
    {
        var agreementResult = new Humidifier.Transfer.Agreement
        {
            GivenName = InputResourceName,
        };

        return agreementResult;
    }
    public override void CreateChildren(Humidifier.Transfer.Agreement result)
    {
        base.CreateChildren(result);

        result.CustomDirectories ??= CustomDirectoriesFactory?.Build();
    }

} // End Of Class

public static class AgreementFactoryExtensions
{
    public static CombinedResult<AgreementFactory, InnerAgreementCustomDirectoriesFactory> WithCustomDirectories(this AgreementFactory parentFactory, Action<Humidifier.Transfer.AgreementTypes.CustomDirectories> subFactoryAction = null)
    {
        parentFactory.CustomDirectoriesFactory = new InnerAgreementCustomDirectoriesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomDirectoriesFactory);
    }

    public static CombinedResult<AgreementFactory, T1, InnerAgreementCustomDirectoriesFactory> WithCustomDirectories<T1>(this CombinedResult<AgreementFactory, T1> combinedResult, Action<Humidifier.Transfer.AgreementTypes.CustomDirectories> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomDirectories(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgreementFactory, InnerAgreementCustomDirectoriesFactory> WithCustomDirectories<T1>(this CombinedResult<T1, AgreementFactory> combinedResult, Action<Humidifier.Transfer.AgreementTypes.CustomDirectories> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomDirectories(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AgreementFactory, T1, T2, InnerAgreementCustomDirectoriesFactory> WithCustomDirectories<T1, T2>(this CombinedResult<AgreementFactory, T1, T2> combinedResult, Action<Humidifier.Transfer.AgreementTypes.CustomDirectories> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomDirectories(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgreementFactory, T2, InnerAgreementCustomDirectoriesFactory> WithCustomDirectories<T1, T2>(this CombinedResult<T1, AgreementFactory, T2> combinedResult, Action<Humidifier.Transfer.AgreementTypes.CustomDirectories> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomDirectories(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgreementFactory, InnerAgreementCustomDirectoriesFactory> WithCustomDirectories<T1, T2>(this CombinedResult<T1, T2, AgreementFactory> combinedResult, Action<Humidifier.Transfer.AgreementTypes.CustomDirectories> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomDirectories(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AgreementFactory, T1, T2, T3, InnerAgreementCustomDirectoriesFactory> WithCustomDirectories<T1, T2, T3>(this CombinedResult<AgreementFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transfer.AgreementTypes.CustomDirectories> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDirectories(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgreementFactory, T2, T3, InnerAgreementCustomDirectoriesFactory> WithCustomDirectories<T1, T2, T3>(this CombinedResult<T1, AgreementFactory, T2, T3> combinedResult, Action<Humidifier.Transfer.AgreementTypes.CustomDirectories> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDirectories(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgreementFactory, T3, InnerAgreementCustomDirectoriesFactory> WithCustomDirectories<T1, T2, T3>(this CombinedResult<T1, T2, AgreementFactory, T3> combinedResult, Action<Humidifier.Transfer.AgreementTypes.CustomDirectories> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDirectories(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AgreementFactory, InnerAgreementCustomDirectoriesFactory> WithCustomDirectories<T1, T2, T3>(this CombinedResult<T1, T2, T3, AgreementFactory> combinedResult, Action<Humidifier.Transfer.AgreementTypes.CustomDirectories> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDirectories(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AgreementFactory, T1, T2, T3, T4, InnerAgreementCustomDirectoriesFactory> WithCustomDirectories<T1, T2, T3, T4>(this CombinedResult<AgreementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.AgreementTypes.CustomDirectories> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDirectories(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgreementFactory, T2, T3, T4, InnerAgreementCustomDirectoriesFactory> WithCustomDirectories<T1, T2, T3, T4>(this CombinedResult<T1, AgreementFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.AgreementTypes.CustomDirectories> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDirectories(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgreementFactory, T3, T4, InnerAgreementCustomDirectoriesFactory> WithCustomDirectories<T1, T2, T3, T4>(this CombinedResult<T1, T2, AgreementFactory, T3, T4> combinedResult, Action<Humidifier.Transfer.AgreementTypes.CustomDirectories> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDirectories(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AgreementFactory, T4, InnerAgreementCustomDirectoriesFactory> WithCustomDirectories<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AgreementFactory, T4> combinedResult, Action<Humidifier.Transfer.AgreementTypes.CustomDirectories> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDirectories(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AgreementFactory, InnerAgreementCustomDirectoriesFactory> WithCustomDirectories<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AgreementFactory> combinedResult, Action<Humidifier.Transfer.AgreementTypes.CustomDirectories> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDirectories(combinedResult.T5, subFactoryAction).T2);
}
