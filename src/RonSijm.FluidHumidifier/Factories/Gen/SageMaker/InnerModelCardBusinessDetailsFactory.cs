// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelCardBusinessDetailsFactory(Action<Humidifier.SageMaker.ModelCardTypes.BusinessDetails> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelCardTypes.BusinessDetails>
{

    protected override Humidifier.SageMaker.ModelCardTypes.BusinessDetails Create()
    {
        var businessDetailsResult = CreateBusinessDetails();
        factoryAction?.Invoke(businessDetailsResult);

        return businessDetailsResult;
    }

    private Humidifier.SageMaker.ModelCardTypes.BusinessDetails CreateBusinessDetails()
    {
        var businessDetailsResult = new Humidifier.SageMaker.ModelCardTypes.BusinessDetails();

        return businessDetailsResult;
    }

} // End Of Class

public static class InnerModelCardBusinessDetailsFactoryExtensions
{
}
