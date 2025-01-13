# Repository-wide Variables to set up

In order to be DRY-compliant, the following variables must be set.
Each variable is a **JSON**-representation of the regular YAML arrays/dicts
and must be converted back using the intrinsic `fromJson()` method.

## Variables used by build actions/macros

These are the variables to set up to be passed to build actions/macros, i.e.

- `build-branch`
- `build-pr`
- `build-tag`
- `build-ci`
- `build-cron`

```yaml
CONFIGURATIONS: ["Debug", "Release"]
FRAMEWORKS: ["net9.0", "netstandard2.1"]
BUILD_MATRIX: |-
  [
    {
      "framework": "net9.0",
      "projects": "KHUtils.Schemas.net9.0.slnf"
    },
    {
      "framework": "netstandard2.1",
      "projects": "KHUtils.Schemas.netstandard2.1.slnf"
    }
  ]
```

## Variables used by unittest actions/macros

These are the variables to set up to be passed to unit test actions/macros, i.e.

- `build-branch`
- `build-pr`
- `build-tag`
- `build-ci`
- `build-cron`

```yaml
TEST_FRAMEWORKS: ["net9.0"]
TEST_MATRIX: |-
  [
    {
      "framework": "net9.0",
      "projects": "KHUtils.Schemas.net9.0.Tests.slnf"
    }
  ]
```

## Variables used by nuget-pack and nuget-publish actions/macros

These are the variables to set up to be passed to nuget-pack and nuget-publish actions/macros, i.e.

- `build-branch`
- `build-pr`
- `build-tag`
- `build-ci`
- `build-cron`
- `publish-nuget`

```yaml
DEPLOY_PROJECTS: ["KHUtils.Schemas.sln"]
DEPLOY_CONFIGURATIONS: ["Release"]
DEPLOY_FRAMEWORKS: [""] ## yes, left empty
```

## Variables used by nuget-publish actions/macros

These are the variables to set up to be passed to nuget-publish actions/macros, i.e.

- `publish-nuget`

```yaml
DEPLOY_SOURCES: ["github", "nuget"]
DEPLOY_MATRIX: |-
  [
    {
      "source": "github",
      "registry": "https://nuget.pkg.github.com/$GITHUB_REPOSITORY_OWNER/index.json",
      "username": "$GITHUB_REPOSITORY_OWNER",
      "token": "GH_PACKAGE_TOKEN"
    },
    {
      "source": "nuget",
      "registry": "https://api.nuget.org/v3/index.json",
      "username": "$GITHUB_REPOSITORY_OWNER",
      "token": "NUGET_ORG_TOKEN"
    }
  ]
```

## Variables used by upm-publish actions/macros

These are the variables to set up to be passed to upm-publish actions/macros, i.e.

- `publish-upm`

```yaml
UPM_AMALGAMATE: ["false", "true"]
UPM_TARGETS: ["github", "npmjs", "gcp-my-upm"]
UPM_MATRIX: |-
  [
    {
      "target": "github",
      "registry": "https://npm.pkg.github.com/@$GITHUB_REPOSITORY_OWNER",
      "token": "GH_PACKAGE_TOKEN"
    },
    {
      "target": "npmjs",
      "registry": "https://registry.npmjs.org",
      "token": "NPMJS_ORG_TOKEN"
    },
    {
      "target": "gcp-my-upm",
      "registry": "https://region-npm.pkg.dev/my/upm/",
      "token": "GITHUB_TOKEN",
      "credentials-json": "GCP_CREDENTIALS_JSON"
    }
  ]
```
