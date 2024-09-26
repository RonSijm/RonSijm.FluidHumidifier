// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class UserPoolUserFactory(string resourceName = null, Action<Humidifier.Cognito.UserPoolUser> factoryAction = null) : ResourceFactory<Humidifier.Cognito.UserPoolUser>(resourceName)
{

    internal List<InnerUserPoolUserAttributeTypeFactory> ValidationDataFactories { get; set; } = [];

    internal List<InnerUserPoolUserAttributeTypeFactory> UserAttributesFactories { get; set; } = [];

    protected override Humidifier.Cognito.UserPoolUser Create()
    {
        var userPoolUserResult = CreateUserPoolUser();
        factoryAction?.Invoke(userPoolUserResult);

        return userPoolUserResult;
    }

    private Humidifier.Cognito.UserPoolUser CreateUserPoolUser()
    {
        var userPoolUserResult = new Humidifier.Cognito.UserPoolUser
        {
            GivenName = InputResourceName,
        };

        return userPoolUserResult;
    }
    public override void CreateChildren(Humidifier.Cognito.UserPoolUser result)
    {
        base.CreateChildren(result);

        result.ValidationData = ValidationDataFactories.Any() ? ValidationDataFactories.Select(x => x.Build()).ToList() : null;
        result.UserAttributes = UserAttributesFactories.Any() ? UserAttributesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class UserPoolUserFactoryExtensions
{
    public static CombinedResult<UserPoolUserFactory, InnerUserPoolUserAttributeTypeFactory> WithValidationData(this UserPoolUserFactory parentFactory, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null)
    {
        var factory = new InnerUserPoolUserAttributeTypeFactory(subFactoryAction);
        parentFactory.ValidationDataFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<UserPoolUserFactory, InnerUserPoolUserAttributeTypeFactory> WithUserAttributes(this UserPoolUserFactory parentFactory, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null)
    {
        var factory = new InnerUserPoolUserAttributeTypeFactory(subFactoryAction);
        parentFactory.UserAttributesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<UserPoolUserFactory, T1, InnerUserPoolUserAttributeTypeFactory> WithValidationData<T1>(this CombinedResult<UserPoolUserFactory, T1> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidationData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolUserFactory, InnerUserPoolUserAttributeTypeFactory> WithValidationData<T1>(this CombinedResult<T1, UserPoolUserFactory> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidationData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UserPoolUserFactory, T1, T2, InnerUserPoolUserAttributeTypeFactory> WithValidationData<T1, T2>(this CombinedResult<UserPoolUserFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidationData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolUserFactory, T2, InnerUserPoolUserAttributeTypeFactory> WithValidationData<T1, T2>(this CombinedResult<T1, UserPoolUserFactory, T2> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidationData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolUserFactory, InnerUserPoolUserAttributeTypeFactory> WithValidationData<T1, T2>(this CombinedResult<T1, T2, UserPoolUserFactory> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidationData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UserPoolUserFactory, T1, T2, T3, InnerUserPoolUserAttributeTypeFactory> WithValidationData<T1, T2, T3>(this CombinedResult<UserPoolUserFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidationData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolUserFactory, T2, T3, InnerUserPoolUserAttributeTypeFactory> WithValidationData<T1, T2, T3>(this CombinedResult<T1, UserPoolUserFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidationData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolUserFactory, T3, InnerUserPoolUserAttributeTypeFactory> WithValidationData<T1, T2, T3>(this CombinedResult<T1, T2, UserPoolUserFactory, T3> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidationData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserPoolUserFactory, InnerUserPoolUserAttributeTypeFactory> WithValidationData<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserPoolUserFactory> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidationData(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UserPoolUserFactory, T1, T2, T3, T4, InnerUserPoolUserAttributeTypeFactory> WithValidationData<T1, T2, T3, T4>(this CombinedResult<UserPoolUserFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidationData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolUserFactory, T2, T3, T4, InnerUserPoolUserAttributeTypeFactory> WithValidationData<T1, T2, T3, T4>(this CombinedResult<T1, UserPoolUserFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidationData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolUserFactory, T3, T4, InnerUserPoolUserAttributeTypeFactory> WithValidationData<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserPoolUserFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidationData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserPoolUserFactory, T4, InnerUserPoolUserAttributeTypeFactory> WithValidationData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserPoolUserFactory, T4> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidationData(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UserPoolUserFactory, InnerUserPoolUserAttributeTypeFactory> WithValidationData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserPoolUserFactory> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidationData(combinedResult.T5, subFactoryAction));
    public static CombinedResult<UserPoolUserFactory, T1, InnerUserPoolUserAttributeTypeFactory> WithUserAttributes<T1>(this CombinedResult<UserPoolUserFactory, T1> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolUserFactory, InnerUserPoolUserAttributeTypeFactory> WithUserAttributes<T1>(this CombinedResult<T1, UserPoolUserFactory> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UserPoolUserFactory, T1, T2, InnerUserPoolUserAttributeTypeFactory> WithUserAttributes<T1, T2>(this CombinedResult<UserPoolUserFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolUserFactory, T2, InnerUserPoolUserAttributeTypeFactory> WithUserAttributes<T1, T2>(this CombinedResult<T1, UserPoolUserFactory, T2> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolUserFactory, InnerUserPoolUserAttributeTypeFactory> WithUserAttributes<T1, T2>(this CombinedResult<T1, T2, UserPoolUserFactory> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UserPoolUserFactory, T1, T2, T3, InnerUserPoolUserAttributeTypeFactory> WithUserAttributes<T1, T2, T3>(this CombinedResult<UserPoolUserFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolUserFactory, T2, T3, InnerUserPoolUserAttributeTypeFactory> WithUserAttributes<T1, T2, T3>(this CombinedResult<T1, UserPoolUserFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolUserFactory, T3, InnerUserPoolUserAttributeTypeFactory> WithUserAttributes<T1, T2, T3>(this CombinedResult<T1, T2, UserPoolUserFactory, T3> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserPoolUserFactory, InnerUserPoolUserAttributeTypeFactory> WithUserAttributes<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserPoolUserFactory> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserAttributes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UserPoolUserFactory, T1, T2, T3, T4, InnerUserPoolUserAttributeTypeFactory> WithUserAttributes<T1, T2, T3, T4>(this CombinedResult<UserPoolUserFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolUserFactory, T2, T3, T4, InnerUserPoolUserAttributeTypeFactory> WithUserAttributes<T1, T2, T3, T4>(this CombinedResult<T1, UserPoolUserFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolUserFactory, T3, T4, InnerUserPoolUserAttributeTypeFactory> WithUserAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserPoolUserFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserPoolUserFactory, T4, InnerUserPoolUserAttributeTypeFactory> WithUserAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserPoolUserFactory, T4> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserAttributes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UserPoolUserFactory, InnerUserPoolUserAttributeTypeFactory> WithUserAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserPoolUserFactory> combinedResult, Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserAttributes(combinedResult.T5, subFactoryAction));
}
