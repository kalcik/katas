# Car Engine Driving Modes Kata

## Mission

This simple Kata helps you:
* Understand and exercise [Strategy Pattern](https://en.wikipedia.org/wiki/Strategy_pattern).
* Exercise [TDD](https://en.wikipedia.org/wiki/Test-driven_development).

## Description

Car engine in [this solution](src/CarEngineDrivingModesKata.sln) can have different driving modes. _Normal_ ist the default driving mode.
See [Main Diagramm](src/Engine/MainClassDiagram.cd) can you help understand the current solution.  

## Exercise

1. [Unit Test's](src/Engine.Tests/Engine.Tests.csproj) assertions are failing, because of missing implementation.
Complete the code and implement _Normal_ Driving Mode.
2. Implement _Economy_ and _Speed_ drivin modes:

    * On _Economy_ mode is maximum ```CurrentThrust``` 60%.
    * On _Speed_ mode is maximum ```CurrentThrust``` 100%.

