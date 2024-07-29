OxyPlot is a cross-platform plotting library for .NET.

This repository contains the SharpDX/WPF implementation. 

![Plot](http://oxyplot.org/public/images/normal-distributions.png)

#### Getting started

1. Use the NuGet package manager to add a reference to `OxyPlot.SharpDX.WPF` (see details below if you want to use pre-release packages)
2. Add a `PlotView` to your user interface
3. Create a `PlotModel` in your code
4. Bind the `PlotModel` to the `Model` property of your `PlotView`

#### Examples

You can find examples in the `/Source/Examples` folder in the code repository.

#### NuGet packages

The latest pre-release packages are pushed to [myget.org](https://www.myget.org/)
To install these packages, set the myget.org package source `https://www.myget.org/F/oxyplot` and remember the "-pre" flag. 

The stable release packages are pushed to [nuget.org](https://www.nuget.org/packages?q=oxyplot).
