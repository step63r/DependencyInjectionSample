# DependencyInjectionSample

## Description

Sample application for Prism and dependency injection containers.

## Requirement

- .NET Framework 4.7.1
- Prism.Wpf 7.1
- Prism.Unity 7.1

## Usage

1. Install [Prism Template Pack](https://marketplace.visualstudio.com/items?itemName=BrianLagunas.PrismTemplatePack) extension to VS 2019
2. Launch VS 2019
3. Create new Solution with "Prism Blank App (WPF)"
4. Select "Unity" at container select dialog
5. If failed to build, restore NuGet package of the solution
6. Create Modules of each Region as "Prism Module (WPF)" project
7. Add processing of including to Region in ``Module.OnInitialized()``
8. Add Module project to reference of Application project
9. Override ``ConfigureModuleCatalog()`` in App.xaml.cs and add the Module class

## Notice

It is **NOT** recommended to upgrade ``Unity.Abstractions`` and ``Unity.Container`` manually.

## Contribution

1. Fork this repository
2. Create your feature branch
3. Commit your changes
4. Push to the branch
5. Create new Pull Request

## License

MIT License

## Author

[minato](https://blog.minatoproject.com/)