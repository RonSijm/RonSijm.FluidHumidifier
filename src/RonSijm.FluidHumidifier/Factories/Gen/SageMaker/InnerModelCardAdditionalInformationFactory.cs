// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelCardAdditionalInformationFactory(Action<Humidifier.SageMaker.ModelCardTypes.AdditionalInformation> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelCardTypes.AdditionalInformation>
{

    protected override Humidifier.SageMaker.ModelCardTypes.AdditionalInformation Create()
    {
        var additionalInformationResult = CreateAdditionalInformation();
        factoryAction?.Invoke(additionalInformationResult);

        return additionalInformationResult;
    }

    private Humidifier.SageMaker.ModelCardTypes.AdditionalInformation CreateAdditionalInformation()
    {
        var additionalInformationResult = new Humidifier.SageMaker.ModelCardTypes.AdditionalInformation();

        return additionalInformationResult;
    }

} // End Of Class

public static class InnerModelCardAdditionalInformationFactoryExtensions
{
}
