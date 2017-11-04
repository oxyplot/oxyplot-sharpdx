OxyPlot is a cross-platform plotting library for .NET.

This repository contains the SharpDX/WPF implementation. 

- [Web page](http://oxyplot.org)  
- [Documentation](http://docs.oxyplot.org/)
- [Announcements](http://oxyplot.org/announcements) / [atom](http://oxyplot.org/atom.xml)
- [Discussion forum](http://discussion.oxyplot.org)
- [Source repository](http://github.com/oxyplot/oxyplot)
- [Issue tracker](http://github.com/oxyplot/oxyplot/issues)
- [NuGet packages](http://www.nuget.org/packages?q=oxyplot)
- [Stack Overflow](http://stackoverflow.com/questions/tagged/oxyplot)
- [Twitter](https://twitter.com/hashtag/oxyplot)
- [Gitter](https://gitter.im/oxyplot/oxyplot) (chat)

![License](https://img.shields.io/badge/license-MIT-red.svg)
[![Build status](https://ci.appveyor.com/api/projects/status/txt1u9ceqtbsoxhs?svg=true)](https://ci.appveyor.com/project/objorke/oxyplot-sharpdx)

![Plot](http://oxyplot.org/public/images/normal-distributions.png)

#### Getting started

1. Use the NuGet package manager to add a reference to `OxyPlot.SharpDX.WPF` (see details below if you want to use pre-release packages)
2. Add a `PlotView` to your user interface
3. Create a `PlotModel` in your code
4. Bind the `PlotModel` to the `Model` property of your `PlotView`

#### Examples

You can find examples in the `/Source/Examples` folder in the code repository.

#### NuGet packages

The latest pre-release packages are pushed by AppVeyor CI to [myget.org](https://www.myget.org/)
To install these packages, set the myget.org package source `https://www.myget.org/F/oxyplot` and remember the "-pre" flag. 

The stable release packages are pushed to [nuget.org](https://www.nuget.org/packages?q=oxyplot).
