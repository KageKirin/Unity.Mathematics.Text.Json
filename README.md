# ![Logo](Icon.png) Unity.Mathematics.Text.Json

This project provides JSON serialization for Unity.Mathematics types
based on [System.Text.Json](https://learn.microsoft.com/en-us/dotnet/api/system.text.json?view=net-9.0).

## ⚡ tl;dr or _I just want to fetch the correct dependency_

### dotnet CLI

```bash
dotnet add package UnityMathematics.Text.Json --version x.y.z
```

### PackageVersion in `Directory.Packages.props`

```xml
  <ItemGroup>
    <PackageVersion Include="UnityMathematics.Text.Json" Version="x.y.z" />
  </ItemGroup>
```

### PackageReference in Project `.csproj`

```xml
  <ItemGroup Label="dependencies">
    <PackageReference Include="UnityMathematics.Text.Json" />
  </ItemGroup>
```

## 🔧 JSON Serializer usage

TBD once implementation is added.

## 🤝 Collaborate with My Project

PRs are welcome.  
Please refer to [COLLABORATION.md](./COLLABORATION.md) for more details.

## 📦 Package overview

### ![Unity.Mathematics.Text.Json Logo](Icon.png) Unity.Mathematics.Text.Json itself

This is the main package, supporting both array and object notation,
at the expense of a slightly more convoluted design.

If your requirement is to only support a single notation style,
the following standalone packages might be what you want.

### ![Unity.Mathematics.Text.Json.ArrayNotation Logo](IconArrayNotation.png) Unity.Mathematics.Text.Json.ArrayNotation

The package for using _only_ JSON Array notation, as in the example below.

```json
{
  "vector": [1.43, 2.09, 43.9]
}
```

### ![Unity.Mathematics.Text.Json.ObjectNotation Logo](IconObjectNotation.png) Unity.Mathematics.Text.Json.ObjectNotation

The package for using _only_ JSON Object notation, as in the example below.

```json
{
  "vector": {
    "x": 1.43,
    "y": 2.09,
    "z": 43.9
  }
}
```
