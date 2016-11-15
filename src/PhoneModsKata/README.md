# Phone Modes Kata

## Mission

This simple Kata helps you:
* Understand and exercise [Decorator Pattern](decorator-pattern).
* Understand and exercise [Adapter Pattern][adapter-pattern].
* Exercise [TDD](https://en.wikipedia.org/wiki/Test-driven_development).

## Description

Phone maker is creating a new product phone line. Until yet, his product [```MotoPower```](Phone/MotoPower.cs) supports only one extension over 
propietary connector: [```external battery```](Phone/Components/Battery3000.cs). 
In the future should specific product line support _Mods_. _Mods_ can be various phone extensions.      

## Exercise(s)

1. Implement possibility to support _different_ phone _Mods_ with [Decorator Pattern's](decorator-pattern) help. 

2. Implement different _Mods_: 

    *  _BatteryPack Mod_ enhance battery power with 4000 mAh.
    *  _Camera Mod_ extend build in camera with 10x zoom.

4. One third party manufacturer created _SuperChargeBattery_ with capacity of 10000 mAh. Enable to use this battery with the help of [Adapter Pattern][adapter-pattern]. _SuperChargeBattery_ is implemented in the [_SuperChargeBattery.dll_](_ExternalAssemblies/SuperChargeBattery.dll).

[decorator-pattern]:https://en.wikipedia.org/wiki/Decorator_pattern