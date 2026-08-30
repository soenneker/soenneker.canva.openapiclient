[![](https://img.shields.io/nuget/v/soenneker.canva.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.canva.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.canva.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.canva.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.canva.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.canva.openapiclient/actions/workflows/codeql.yml)
[![](https://img.shields.io/nuget/dt/soenneker.canva.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.canva.openapiclient/)

# Soenneker.Canva.OpenApiClient

A Kiota-generated .NET client for Canva's Connect API.

## Installation

```bash
dotnet add package Soenneker.Canva.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Canva.OpenApiClient;
using Soenneker.Canva.OpenApiClient.Models;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "your-oauth-access-token");

var adapter = new HttpClientRequestAdapter(new AnonymousAuthenticationProvider(), httpClient: httpClient);
var client = new CanvaOpenApiClient(adapter);

UsersMeResponse? response = await client.V1.Users.Me.GetAsync();
```

Keep the `HttpClient` long-lived. For dependency injection, configuration-based authentication, and managed client reuse, use `Soenneker.Canva.OpenApiClientUtil`.

This package is generated from Canva's OpenAPI document. Request-builder and model names can change when that document changes, so review package upgrades when your code depends on generated shapes.
