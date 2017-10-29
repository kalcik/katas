# Car Engine Driving Modes Kata

## Mission

This simple Kata helps you:
* Understand and exercise [Strategy Pattern](https://en.wikipedia.org/wiki/Strategy_pattern)
* Exercise [TDD](https://en.wikipedia.org/wiki/Test-driven_development)

## Description

Car engine in [this solution](CarEngineDrivingModesKata.sln) has different driving modes. _Normal_ ist the default driving mode.
[Main Diagram](Engine/MainClassDiagram.cd) can you help understand the current solution.

## Exercise(s)

1. [Unit Test's](Engine.Tests/Engine.Tests.csproj) assertions are failing, because of missing implementation.
Complete the code and implement _Normal_ Driving Mode.

2. Implement _Economy_ and _Speed_ driving modes:

    * ```CurrentThrust``` is on _Economy_ mode maximum 60%.
    * ```CurrentThrust``` is on _Speed_ mode maximum 100%.