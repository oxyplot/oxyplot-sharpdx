# Change Log
All notable changes to this project will be documented in this file.

## [Unreleased]
### Added

### Changed
Updated SharpDX nuget packages to version 4.2.0
Updated OxyPlot nuget packages from MyGet to version 2.0.0 stable
Migrated OxyPlot.SharpDX to .NET Standard 1.1
Update project files to VS2019 format
OxyPlot.SharpDX.WPF: Dual-target .NET Framework 4.5.2 and .NET Core 3.1
SimpleDemo: Target .NET Core 3.1

### Removed

### Fixed
- Clipping
- Text rotation (#1075)
- Polygon geometry fill rendering (#6)
- Image Annotations (#7)
- MeasureText fixed in cases where string is null or empty
- Fixed render extent not being set in ArrangeOverride step on WPF (#12)
- Fixed zero dimensions crashing plot (#14)
- Zooming via MouseWheel not working (#24)