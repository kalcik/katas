# Game of Life Kata

## Mission

This Kata helps you:
* Exercise [TDD][tdd]

## Description

The [Game of Life][game-of-life] is a [cellular automaton](https://en.wikipedia.org/wiki/Cellular_automaton) devised by the British mathematician [John Horton Conway](https://en.wikipedia.org/wiki/Cellular_automaton) in 1970.
The rules of [Game of Life][game-of-life] are simple. There is infinte two-dimensional grid of square cells. Each cell has two possible states,
alive or dead. The state of the cell depends on immediate neighbour.

* Any live cell with fewer than two live neighbours dies.
* Any live cell with two or three live neighbours stay alive.
* Any live cell with more than three live neighbours dies.
* Any dead cell with exactly three live neighbours becomes alive cell. 

## Exercise(s)

1. Implement the [Game of Life][game-of-life] using [TDD approach][tdd]. 

2. Implement new rules:

    * Any live cell with exact 0, 2, 4, 6 or 8 living neighbours died.
    * Any dead cell with exact 1, 3, 5 or 7 living neighbours becomes alive.

[game-of-life]: https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life
[tdd]: https://en.wikipedia.org/wiki/Test-driven_development