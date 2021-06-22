namespace GitHub.Services.DelegatedAuthorization
{
    public enum TokenError
    {
        None,
        GrantTypeRequired,
        AuthorizationGrantRequired,
        ClientSecretRequired,
        RedirectUriRequired,
        InvalidAuthorizationGrant,
        InvalidAuthorizationScopes,
        InvalidRefreshToken,
        AuthorizationNotFound,
        AuthorizationGrantExpired,
        AccessAlreadyIssued,
        InvalidRedirectUri,
        AccessTokenNotFound,
        InvalidAccessToken,
        AccessTokenAlreadyRefreshed,
        InvalidClientSecret,
        ClientSecretExpired,
        ServerError,
        AccessDenied,
        AccessTokenKeyRequired,
        InvalidAccessTokenKey,
        FailedToGetAccessToken,
        InvalidClientId,
        InvalidClient,
        InvalidValidTo,
        InvalidUserId,
        FailedToIssueAccessToken,
        AuthorizationGrantScopeMissing,        
        InvalidPublicAccessTokenKey,
        InvalidPublicAccessToken,
        /* Deprecated */
        PublicFeatureFlagNotEnabled,
        SSHPolicyDisabled
    }
}
