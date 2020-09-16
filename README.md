# XamarinSingleProjectConcept

This repo contains a working area for refining the concept of a single project in Xamarin for .NET 6.0.

As the name implies, a single project assumes only one project (.csproj) file which uses multitargeting is used to target `net6.0-ios`, `net6.0-android`, etc platforms.

Single projects would have some default patterns enabled for including files such as these:

```xml
<!-- Shared -->
<ItemGroup>
  <Image Include="Shared/Resources/*.svg" />
  <Image Include="Shared/Resources/*.png" />
  
  <Font Include="Shared/Resources/*.ttf" />
  <Font Include="Shared/Resources/*.otf" />
  
  <Compile Include="Shared/**/*.cs" />
</ItemGroup>

<!-- iOS -->
<ItemGroup Condition=" '$(TargetPlatformIdentifier)' == 'ios' " />
  <Compile Include="iOS/**/*.cs" />
  
  <BundleResource Include="iOS/Resources/*" />
</ItemGroup>

<!-- Android -->
<ItemGroup Condition=" '$(TargetPlatformIdentifier)' == 'android' " />
  <Compile Include="Android/**/*.cs" />
  
  <LibraryResourceDirectories Include="Android/Resources" Condition=" Exists('Android/Resources') " />
  
  <AndroidManifests Include="Android/AndroidManifest.xml" Condition=" Exists('Android/AndroidManifest.xml') " />
</ItemGroup>
```

These patterns assume some conventions:

 - Platform specific code goes either in Platform specific folders (eg: `Android`), or inside `#ifdef` blocks
 - The `Shared` folder contains code and resources which are multitargeted
 - Resources specific to a platform go in the platform folders

NuGet needs some work so that the UI can target packages to a specific platform when multitargeting if necessary.  For now, developers will need to add conditions around their package references where necessary:

```xml
<ItemGroup Condition=" '$(TargetPlatformIdentifier)' == 'ios' ">
		<PackageReference Include="Xamarin.Facebook.iOS" Version="7.1.1" />
</ItemGroup>
```
