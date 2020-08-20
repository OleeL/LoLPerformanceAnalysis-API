# LoLPerformanceAnalysis-API
API for the client. This will make requests to riot's API. This isn't endorsed by Riot Games and doesn't reflect the views or opinions of Riot Games or anyone officially involved in producing or managing Riot Games properties. Riot Games, and all associated properties are trademarks or registered trademarks of Riot Games, Inc.

## Configuration

Requires [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1)

Create two files in your root dir and put your Riot API key in them

`./appsettings.Development.json`
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "API_KEY": "<key goes here>"
}
```

`./appsettings.json`
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "API_KEY": "<key goes here>"
}
```

Run with
```
dotnet restore
dotnet run
```