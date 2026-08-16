using Soenneker.Tests.HostedUnit;

namespace Soenneker.Canva.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CanvaOpenApiClientTests : HostedUnitTest
{
    public CanvaOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
