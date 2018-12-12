
C# Static Code Analysis Tool Resources
====

Commercial Solutions
* [SoarC#](https://www.sonarsource.com/products/codeanalyzers/sonarcsharp.html)
  * "SonarSource delivers what is probably the best static code analyzer you can find on the market for C#. Based on Microsoft Roslyn compiler front-end, it uses the most advanced techniques (pattern matching, dataflow analysis) to analyze code and find code smells, bugs and security vulnerabilities. As for any product we develop at SonarSource, it was built on the following principles: depth, accuracy and speed."
    * Standards:
      * CWE
      * SANS Top 25
      * OWASP
      * MISRA
      * CERT 
  * [Pricing](https://www.sonarsource.com/plans-and-pricing/)
  * [docs.sonarqube.org > Pages > Plugin Library > SonarSource Plugins > SonarC#](https://docs.sonarqube.org/pages/viewpage.action?pageId=1441900)
  * [Community Edition](https://www.sonarsource.com/plans-and-pricing/community/)
    * https://github.com/SonarSource/sonar-dotnet
    * Extensible with 60+ plugins
    * DevOps integration
    * Support of 14 languages
    * Support of 5 IDEs
    * 350+ C# rules and 100+ VB.​NET rules
    * Metrics (complexity, number of lines etc.)
    * Import of unit test results from VSTest, MSTest, NUnit and xUnit
    * Import of test coverage reports from Visual Studio Code Coverage, dotCover, OpenCover and NCover 3.
    * Support for custom rules
* [SonarLint](https://www.sonarlint.org/visualstudio/)
  * https://marketplace.visualstudio.com/items?itemName=SonarSource.SonarLintforVisualStudio2017
  * "Roslyn based static code analysis: Find and instantly fix nasty bugs and code smells in C#, VB.Net, C, C++ and JS."
  * 5 languages supported: C#, VB .Net, C, C++ and Javascript.
  * Open source, Roslyn based code analyzers.
  * Deep code analysis algorithms using pattern matching and dataflow analysis
  * Hundreds of rules, and growing.
  * Comes with explanations to resolve detected issues.










### Github Resources
* Awesome List: Static analysis tools for all programming languages
  * https://matthias-endler.de/awesome-static-analysis/
  * https://github.com/mre/awesome-static-analysis
    * .NET Analyzers
      * "An organization for the development of analyzers (diagnostics and code fixes) using the .NET Compiler Platform."
    * Code Analysis Rule Collection
      * "Contains a set of diagnostics, code fixes and refactorings built on the Microsoft .NET Compiler Platform 'Roslyn'."
    * code-cracker
      * "An analyzer library for C# and VB that uses Roslyn to produce refactorings, code analysis, and other niceties."
    * CodeRush ©️
      * "Code creation, debugging, navigation, refactoring, analysis and visualization tools that use the Roslyn engine in Visual Studio 2015 and up."
    * CSharpEssentials - 
      * "C# Essentials is a collection of Roslyn diagnostic analyzers, code fixes and refactorings that make it easy to work with C# 6 language features."
    * [Designite ©️](http://www.designite-tools.com/)
      * "Designite is a software design quality assessment tool. It supports detection of implementation and design smells, computation of various code quality metrics, and trend analysis."
      * "Designite is a software design quality assessment tool. It analyzes C# code and identifies software quality issues. Specifically, it detects a comprehensive set of architecture, design, and implementation smells and provides mechanisms such as detailed metrics analysis, Dependency Structure Matrix, trend analysis, and smell distribution maps. Designite helps you reduce technical debt and improve maintainability of your software."
    * [Gendarme](https://www.mono-project.com/docs/tools+libraries/tools/gendarme/)
      * "Gendarme inspects programs and libraries that contain code in ECMA CIL format (Mono and .NET)."
      * "Gendarme is a extensible rule-based tool to find problems in .NET applications and libraries. Gendarme inspects programs and libraries that contain code in ECMA CIL format (Mono and .NET) and looks for common problems with the code, problems that compiler do not typically check or have not historically checked."
      * "Gendarme uses the Cecil library to introspect code."
    * NDepend ©️
      * "Measure, query and visualize your code and avoid unexpected issues, technical debt and complexity."
    * Puma Scan
      * "Puma Scan provides real time secure code analysis for common vulnerabilities (XSS, SQLi, CSRF, LDAPi, crypto, deserialization, etc.) as development teams write code in Visual Studio."
    * Refactoring Essentials
      * "The free Visual Studio 2015 extension for C# and VB.NET refactorings, including code best practice analyzers."
    * ReSharper ©️
      "Extends Visual Studio with on-the-fly code inspections for C#, VB.NET, ASP.NET, JavaScript, TypeScript and other technologies."
    * Roslyn Security Guard
      * "Project that focuses on the identification of potential vulnerabilities such as SQL injection, cross-site scripting (XSS), CSRF, cryptography weaknesses, hardcoded passwords and many more."
    * Roslynator
      * "A collection of 190+ analyzers and 190+ refactorings for C#, powered by Roslyn."
    * Security Code Scan
      * "Security code analyzer for C# and VB.NET. Detects various security vulnerability patterns: SQLi, XSS, CSRF, XXE, Open Redirect, etc."
    * SonarLint for Visual Studio
      * "SonarLint is an extension for Visual Studio 2015 and 2017 that provides on-the-fly feedback to developers on new bugs and quality issues injected into .NET code."
    * VSDiagnostics
      * "A collection of static analyzers based on Roslyn that integrates with VS."
    * Wintellect.Analyzers
      * ".NET Compiler Platform ("Roslyn") diagnostic analyzers and code fixes."



### Articles
* 2018
  * [16 New Code Analysis, Testing and Debugging Tools For Visual Studio 2017](https://visualstudiomagazine.com/articles/2018/05/01/vs-analysis-tools.aspx)
    * [Gcop](https://github.com/Geeksltd/GCop)
    * [Gcop Exra](https://marketplace.visualstudio.com/items?itemName=Paymon.GCop-Extra)
    * [Multi Linter](https://marketplace.visualstudio.com/items?itemName=glat.MultiLinter)
    * [XamRight](https://marketplace.visualstudio.com/items?itemName=glat.MultiLinter)
    * [NDepend](https://www.ndepend.com/)
    * [Asynch Method Name Fixer](https://marketplace.visualstudio.com/items?itemName=PRIYANSHUAGRAWAL92.AsyncMethodNameFixer)
    * [AxoCover](https://marketplace.visualstudio.com/items?itemName=axodox1.AxoCover)
      * "Nice and free .Net code coverage support for Visual Studio with OpenCover."
      * https://github.com/axodox/AxoCover
      * [OpenCover](https://github.com/OpenCover/opencover)
        * "OpenCover is a code coverage tool for .NET 2 and above (Windows OSs only - no MONO), with support for 32 and 64 processes and covers both branch and sequence points. OpenCover was started after attempts to make PartCover support 64-bit processes got just a little too complicated."
    * [SmartTests.Extension](https://marketplace.visualstudio.com/items?itemName=LudovicDubois.SmartTests)
      * [Pretty Objects](http://www.prettyobjects.com/)
    * [TestLeft, by SmartBear](https://smartbear.com/product/testleft/overview/)
      * "Build, test, and deploy in one integrated development environment so you can focus on what matters: Code. TestLeft is a developer automated testing tool that can be added to your integrated development environment (IDE) so you can immediately test the UI of new features right after they are built. TestLeft allows you to test at the unit and UI level so you can fix defects earlier in the product lifecycle to save time to let you code more. Without having to manually program descriptions for every object, you can start running functional tests sooner to accelerate your shift left efforts. "
    * [VisualSOS.Extension](https://marketplace.visualstudio.com/items?itemName=AngelHernandezMatos.VisualSO-Extension-1-0#overview)
      * [Microsft: SOS.dll (SOS debugging extension)](https://docs.microsoft.com/en-us/dotnet/framework/tools/sos-dll-sos-debugging-extension)
      * [Visual SOS – Visual Studio extension to debug managed applications through SOS](http://www.angelhernandezm.com/visual-sos-visual-studio-extension-to-debug-managed-applications-through-sos/)
    * [LINQBridgeVs - Debugger Visualizers](https://marketplace.visualstudio.com/items?itemName=codingadventures.linqbridgevs)
      * "Bridge between a Visual Studio debugging session and LINQPad. It creates a Debugger Visualizer making the magnifier glass available for all of the public classes and structs of every project in a solution."






