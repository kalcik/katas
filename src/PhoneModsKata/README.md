# Phone Modes Kata

## Mission

This simple Kata helps you:
* Understand and exercise [Decorator Pattern](https://en.wikipedia.org/wiki/Decorator_pattern).
* Understand and exercise [Adapter Pattern][adapter-pattern].
* Exercise [TDD](https://en.wikipedia.org/wiki/Test-driven_development).

## Description

This phone maker wants create a new product phone line. In the future should specific product line support _Mods_. _Mods_ are phone extensions.      

## Exercise(s)

1. Implement possibility to support phone _Mods_.

2. Implement following _Mods_:

    * BatteryPack Mod enhance the battery.
    * PowerPack enhance the processor.
    * CameraPack enhance the camera.

3. Implement _Mods_ which adds external fucntionality:

    * Sound Mod add extenal speaker to the phone.
    * Projector add extenal projector to the phone.

4. One third party manufacturer created _SuperChargeBattery_ with capacity of 10000 mAh. Enable to use this battery with the help of [Adapter Pattern][adapter-pattern]. _SuperChargeBattery_ is implemented in the [_SuperChargeBattery.dll_](_ExternalAssemblies/SuperChargeBattery.dll).