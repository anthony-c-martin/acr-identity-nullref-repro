using Azure.Containers.ContainerRegistry;

var client = new ContainerRegistryContentClient(
    new Uri("https://mcr.microsoft.com/"),
    "bicep/ai/cognitiveservices");

await client.DownloadBlobContentAsync(
    "sha256:ee1bd6b3e57679e1a3677fabdb9fe3fb3cbc1851b9ba121d2034573ce449507d",
    CancellationToken.None);

Console.WriteLine("Success!");