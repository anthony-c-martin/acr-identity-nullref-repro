# acr-identity-nullref-repro

1. Clone repo
2. Run `dotnet run`. Output:
    ```
    Unhandled exception. System.ArgumentNullException: Value cannot be null. (Parameter 'stream')
       at System.BinaryData.FromStreamAsync(Stream stream, CancellationToken cancellationToken)
       at Azure.Containers.ContainerRegistry.ContainerRegistryContentClient.DownloadBlobContentInternalAsync(String digest, Boolean async, CancellationToken cancellationToken)
       at Azure.Containers.ContainerRegistry.ContainerRegistryContentClient.DownloadBlobContentAsync(String digest, CancellationToken cancellationToken)
       at Program.<Main>$(String[] args) in /Users/ant/Desktop/identity-repro/Program.cs:line 7
       at Program.<Main>(String[] args)
    ```
4. Edit [this line](https://github.com/anthony-c-martin/acr-identity-nullref-repro/blob/568364373a68189927dce637006e8d2b29bc074f/acr-identity-nullref-repro.csproj#L14) and change 1.33.0 to 1.32.0.
2. Run `dotnet run`. Output:
    ```
    Success!
    ```
