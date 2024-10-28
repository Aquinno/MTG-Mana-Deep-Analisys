# MTG-Mana-Deep-Analisys
This program analyzes the mana generation possibilities on the battlefield for a two-color deck. It evaluates the available mana sources, considering the types of lands and other mana-generating cards, to calculate the potential mana output during the game. The tool helps optimize the deck's mana curve by identifying strengths and weaknesses in mana generation, ensuring smooth gameplay across different turns.

It's a good tool when a player have multiple spells to cast at the next turn and want to optimize the decisions. 

In Magic The Gathering, at the Late Game, color distribution to cast spells ad pay abilities costs is one of the things that you have to analisys for few minutes to take a decision. This tool saves time and patience in moments like this.

## ❇️How to Use

- Insert the name of the two colors your deck has. (2 Inputs; String)
- Insert the amount of monocolored mana sources on the battlefield (2 inputs; Integer)

Lands, Mana Dorks, Mana Rocks etc...
- Insert amount of multicolored mana sources (1 input; Integer)

## ❇️How do it works

- Registering the name of the colors
- Registering the amount of monocolored mana.
- Registering the amount of multicolored mana. (This integer will be used on a for loop to create the possibilites)

## ❇️Observations

- This tool doesn't counts the amount of colorless mana (V 1.0.0). [FIXED]
