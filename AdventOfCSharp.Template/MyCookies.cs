using AdventOfCSharp;

namespace AdventOfCode;

// You may also optionally include a secret cookies class
// specifying your current session cookies to automatically
// download your inputs and outputs
// If you want to opt out of this feature, simply delete this class
// The framework can also flawlessly work without it
// You will, however, need to manually store your inputs and outputs

// DO NOT FORGET TO ADD THIS FILE TO .gitignore
// NEVER PUBLISH SECRETS
[SecretsContainer]
internal sealed class MyCookies : Cookies
{
    // Replace the strings below with your actual cookies, if you'd like
    // Dummy strings' lengths match (at least my) actual cookie content lengths
    public override string GA => "GA1.2.0123456789.0123456789";
    public override string Session => "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff";
}
