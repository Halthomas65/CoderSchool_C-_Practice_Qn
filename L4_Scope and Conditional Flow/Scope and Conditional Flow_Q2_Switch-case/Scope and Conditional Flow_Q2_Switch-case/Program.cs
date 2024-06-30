//---------------------------------------------------------------------
// Question 1: Basic Switch Case
// Write a C# program that prompts the user to enter a number between 1 and 3. Using a switch-case statement,
// display a message based on the number entered. If the number is 1, print "One"; if the number is 2, print "Two"; if the number is 3, print "Three".
// If the number does not match any of these, display a default message.
// Hint: Use Console.ReadLine() to get user input and Convert.ToInt32() to convert the input to an integer.
Console.Write("Enter a number between 1 and 3: ");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1:
        Console.WriteLine("One");
        break;
    case 2:
        Console.WriteLine("Two");
        break;
    case 3:
        Console.WriteLine("Three");
        break;
    default:
        Console.WriteLine("Invalid number entered.");
        break;
}

//---------------------------------------------------------------------
// Question 2: Game Character Selection
// In a game, the player can select a character class using numbers 1 to 3.
// Write a C# program that prompts the player to choose a character class.
// Based on the chosen number, display a message indicating the selected class: 1 for Warrior, 2 for Mage, and 3 for Archer.
// If the number does not match any of these, display a default message.
// Hint: Utilize switch-case statements to handle different cases of character selection.
Console.Write("Choose a character class (1: Warrior, 2: Mage, 3: Archer): ");
int characterClass = Convert.ToInt32(Console.ReadLine());
switch (characterClass)
{
    case 1:
        Console.WriteLine("Warrior");
        break;
    case 2:
        Console.WriteLine("Mage");
        break;
    case 3:
        Console.WriteLine("Archer");
        break;
    default:
        Console.WriteLine("Invalid character class selected.");
        break;
}

//---------------------------------------------------------------------
// Question 3: Directional Movement
// In a game, the player can move in four cardinal directions: North, South, East, and West.
// Write a C# program that prompts the player to enter a direction using numbers 1 to 4.
// Based on the chosen number, display a message indicating the direction: 1 for North, 2 for South, 3 for East, and 4 for West.
// If the number does not match any of these, display a default message.
// Hint: Implement a switch-case statement to handle different directional inputs.
Console.Write("Enter a direction (1: North, 2: South, 3: East, 4: West): ");
int direction = Convert.ToInt32(Console.ReadLine());
switch (direction)
{
    case 1:
        Console.WriteLine("North");
        break;
    case 2:
        Console.WriteLine("South");
        break;
    case 3:
        Console.WriteLine("East");
        break;
    case 4:
        Console.WriteLine("West");
        break;
    default:
        Console.WriteLine("Invalid direction entered.");
        break;
}


//---------------------------------------------------------------------
// Question 4: Day of the Week
// Write a C# program that prompts the user to enter a number between 1 and 7 representing a day of the week.
// Use a switch-case statement to display the name of the corresponding day.
// For example, if the user enters 1, print "Monday"; if 2, print "Tuesday", and so on. If the number does not match any of these, display a default message.
// Hint: Map each number input to a specific day of the week using a switch-case statement.
Console.Write("Enter a number between 1 and 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
switch (dayNumber)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day number entered.");
        break;
}

//---------------------------------------------------------------------
// Question 5: Weapon Selection
// In a game, the player can select a weapon using numbers 1 to 4.
// Write a C# program that prompts the player to choose a weapon. Based on the chosen number, display a message indicating the selected weapon: 1 for Sword, 2 for Bow, 3 for Staff, and 4 for Axe.
// If the number does not match any of these, display a default message.
// Hint: Use switch-case statements to handle different weapon choices.
Console.Write("Choose a weapon (1: Sword, 2: Bow, 3: Staff, 4: Axe): ");
int weapon = Convert.ToInt32(Console.ReadLine());
switch (weapon)
{
    case 1:
        Console.WriteLine("Sword");
        break;
    case 2:
        Console.WriteLine("Bow");
        break;
    case 3:
        Console.WriteLine("Staff");
        break;
    case 4:
        Console.WriteLine("Axe");
        break;
    default:
        Console.WriteLine("Invalid weapon selected.");
        break;
}

//---------------------------------------------------------------------
// Question 6: Elemental Magic
// In a fantasy game, the player can cast elemental magic spells using numbers 1 to 5.
// Write a C# program that prompts the player to select a magic spell. Based on the chosen number, display a message indicating the selected spell element: 1 for Fire, 2 for Water, 3 for Earth, 4 for Air, and 5 for Lightning.
// If the number does not match any of these, display a default message.
// Hint: Implement a switch-case statement to handle different spell selections.
Console.Write("Select a magic spell (1: Fire, 2: Water, 3: Earth, 4: Air, 5: Lightning): ");
int spell = Convert.ToInt32(Console.ReadLine());
switch (spell)
{
    case 1:
        Console.WriteLine("Fire");
        break;
    case 2:
        Console.WriteLine("Water");
        break;
    case 3:
        Console.WriteLine("Earth");
        break;
    case 4:
        Console.WriteLine("Air");
        break;
    case 5:
        Console.WriteLine("Lightning");
        break;
    default:
        Console.WriteLine("Invalid spell selected.");
        break;
}

//---------------------------------------------------------------------
// Question 7: Menu Navigation
// Write a C# program that simulates a menu navigation system for a game.
// The user can enter numbers 1 to 4 to navigate through different menu options: 1 for Start Game, 2 for Options, 3 for Load Game, and 4 for Exit.
// If the number does not match any of these, display a default message.
// Hint: Utilize switch-case statements to handle user input and navigate between menu options.
Console.Write("Enter a number to navigate the menu (1: Start Game, 2: Options, 3: Load Game, 4: Exit): ");
int menuOption = Convert.ToInt32(Console.ReadLine());
switch (menuOption)
{
    case 1:
        Console.WriteLine("Start Game");
        break;
    case 2:
        Console.WriteLine("Options");
        break;
    case 3:
        Console.WriteLine("Load Game");
        break;
    case 4:
        Console.WriteLine("Exit");
        break;
    default:
        Console.WriteLine("Invalid menu option selected.");
        break;
}

//---------------------------------------------------------------------
// Question 8: NPC Interaction
// In an RPG game, the player can interact with non-player characters (NPCs) using numbers 1 to 3.
// Write a C# program that prompts the player to choose an interaction option with an NPC. Based on the chosen number, display a message indicating the selected interaction: 1 for Talk, 2 for Trade, and 3 for Quest.
// If the number does not match any of these, display a default message.
// Hint: Implement a switch-case statement to handle different interaction options with NPCs.
Console.Write("Choose an interaction option with the NPC (1: Talk, 2: Trade, 3: Quest): ");
int interactionOption = Convert.ToInt32(Console.ReadLine());
switch (interactionOption)
{
    case 1:
        Console.WriteLine("Talk");
        break;
    case 2:
        Console.WriteLine("Trade");
        break;
    case 3:
        Console.WriteLine("Quest");
        break;
    default:
        Console.WriteLine("Invalid interaction option selected.");
        break;
}

//---------------------------------------------------------------------
// Question 9: Puzzle Solutions
// In a puzzle-solving game, the player can choose from different solutions using numbers 1 to 5.
// Write a C# program that prompts the player to select a solution for a puzzle. Based on the chosen number, display a message indicating the selected solution option.
// If the number does not match any of these, display a default message.
// Hint: Use switch-case statements to handle different puzzle solution choices.
Console.Write("Select a solution for the puzzle (1 to 5): ");
int solution = Convert.ToInt32(Console.ReadLine());
switch (solution)
{
    case 1:
        Console.WriteLine("Solution 1");
        break;
    case 2:
        Console.WriteLine("Solution 2");
        break;
    case 3:
        Console.WriteLine("Solution 3");
        break;
    case 4:
        Console.WriteLine("Solution 4");
        break;
    case 5:
        Console.WriteLine("Solution 5");
        break;
    default:
        Console.WriteLine("Invalid solution selected.");
        break;
}

//---------------------------------------------------------------------
// Question 10: Dialogue Choices
// Write a C# program that simulates dialogue choices in a game. The player can select dialogue options using numbers 1 to 4.
// Based on the chosen number, display a message indicating the selected dialogue choice. If the number does not match any of these, display a default message.
// Hint: Implement switch-case statements to handle different dialogue options presented to the player.
Console.Write("What do you want to do next? (1: Attack, 2: Talk, 3: Feed, 4: Pet): ");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        Console.WriteLine("You choose to attack the target.");
        break;
    case 2:
        Console.WriteLine("You choose to engage in conversation.");
        break;
    case 3:
        Console.WriteLine("You choose to feed the target.");
        break;
    case 4:
        Console.WriteLine("You choose to pet the target.");
        break;
    default:
        Console.WriteLine("Invalid choice selected.");
        break;
}

//---------------------------------------------------------------------
// Question 11: Crafting Items
// In a crafting system, the player can select crafting recipes using numbers 1 to 3.
// Write a C# program that prompts the player to choose a crafting recipe.
// Based on the chosen number, display a message indicating the selected recipe: 1 for Potion, 2 for Weapon, and 3 for Armor. If the number does not match any of these, display a default message.
// Hint: Utilize switch-case statements to handle different crafting recipe selections.
Console.Write("Choose a crafting recipe (1: Potion, 2: Weapon, 3: Armor): ");
int recipe = Convert.ToInt32(Console.ReadLine());
switch (recipe)
{
    case 1:
        Console.WriteLine("Potion");
        break;
    case 2:
        Console.WriteLine("Weapon");
        break;
    case 3:
        Console.WriteLine("Armor");
        break;
    default:
        Console.WriteLine("Invalid recipe selected.");
 
        break;
}

//---------------------------------------------------------------------
// Question 12: Scene Selection
// Write a C# program that simulates scene selection in a game.
// The player can choose scenes using numbers 1 to 5. Based on the chosen number, display a message indicating the selected scene.
// If the number does not match any of these, display a default message.
// Hint: Implement switch-case statements to handle different scene selections.
Console.Write("Select a scene (1 to 5): ");
int scene = Convert.ToInt32(Console.ReadLine());
switch (scene)
{
    case 1:
        Console.WriteLine("Scene 1: Forest");
        break;
    case 2:
        Console.WriteLine("Scene 2: Castle");
        break;
    case 3:
        Console.WriteLine("Scene 3: Desert");
        break;
    case 4:
        Console.WriteLine("Scene 4: Mountain");
        break;
    case 5:
        Console.WriteLine("Scene 5: City");
        break;
    default:
        Console.WriteLine("Invalid scene selected.");
        break;
}


//---------------------------------------------------------------------
// Question 13: Quest Progression
// In an adventure game, the player can progress through quests using numbers 1 to 4.
// Write a C# program that prompts the player to select a quest. Based on the chosen number, display a message indicating the selected quest.
// If the number does not match any of these, display a default message.
// Hint: Use switch-case statements to handle different quest selections and progression
Console.Write("Select a quest (1 to 4): ");
int quest = Convert.ToInt32(Console.ReadLine());
switch (quest)
{
    case 1:
        Console.WriteLine("Quest 1: Retrieve the Lost Artifact");
        break;
    case 2:
        Console.WriteLine("Quest 2: Defeat the Dragon");
        break;
    case 3:
        Console.WriteLine("Quest 3: Explore the Ancient Ruins");
        break;
    case 4:
        Console.WriteLine("Quest 4: Rescue the Captive Princess");
        break;
    default:
        Console.WriteLine("Invalid quest selected.");
        break;
}


//---------------------------------------------------------------------
// Question 14: Potion Brewing
// In an alchemy system, the player can brew potions using numbers 1 to 3.
// Write a C# program that prompts the player to choose a potion to brew. Based on the chosen number, display a message indicating the selected potion: 1 for Health Potion, 2 for Mana Potion, and 3 for Stamina Potion.
// If the number does not match any of these, display a default message.
// Hint: Implement switch-case statements to handle different potion brewing choices.
Console.Write("Choose a potion to brew (1: Health Potion, 2: Mana Potion, 3: Stamina Potion): ");
int potion = Convert.ToInt32(Console.ReadLine());
switch (potion)
{
    case 1:
        Console.WriteLine("Health Potion");
        break;
    case 2:
        Console.WriteLine("Mana Potion");
        break;
    case 3:
        Console.WriteLine("Stamina Potion");
        break;
    default:
        Console.WriteLine("Invalid potion selected.");
        break;
}

//---------------------------------------------------------------------
// Question 15: Platform Movement
// In a platformer game, the player can move the character using numbers 1 to 4 for directional controls.
// Write a C# program that prompts the player to enter a movement direction. Based on the chosen number, display a message indicating the movement direction: 1 for Left, 2 for Right, 3 for Jump, and 4 for Crouch.
// If the number does not match any of these, display a default message.
// Hint: Utilize switch-case statements to handle different movement directions, including a default case.
Console.Write("Enter a movement direction (1: Left, 2: Right, 3: Jump, 4: Crouch): ");
int movement = Convert.ToInt32(Console.ReadLine());
switch (movement)
{
    case 1:
        Console.WriteLine("Move Left");
        break;
    case 2:
        Console.WriteLine("Move Right");
        break;
    case 3:
        Console.WriteLine("Jump");
        break;
    case 4:
        Console.WriteLine("Crouch");
        break;
    default:
        Console.WriteLine("Invalid movement direction entered.");
        break;
}


//////////////////////Break Statements//////////////////////

//---------------------------------------------------------------------
// Question 16: Weapon Upgrades
// In a game, the player can upgrade their weapon using different materials.
// Write a C# program that prompts the player to choose a material for weapon upgrade.
// Based on the chosen number, display a message indicating the selected material. Use a switch-case statement to handle the different material choices: 1 for Iron, 2 for Steel, 3 for Gold, and 4 for Diamond.
// After displaying the selected material, include a break statement to terminate the switch-case block.
// Hint: Implement switch-case statements to handle different material choices and use break statements to exit the switch-case block.
Console.Write("Choose a material for weapon upgrade (1: Iron, 2: Steel, 3: Gold, 4: Diamond): ");
int material = Convert.ToInt32(Console.ReadLine());
switch (material)
{
    case 1:
        Console.WriteLine("Iron");
        break;
    case 2:
        Console.WriteLine("Steel");
        break;
    case 3:
        Console.WriteLine("Gold");
        break;
    case 4:
        Console.WriteLine("Diamond");
        break;
    default:
        Console.WriteLine("Invalid material selected.");
        break;
}


//---------------------------------------------------------------------
// Question 17: Spell Casting
// In a fantasy game, the player can cast spells using different magic elements.
// Write a C# program that prompts the player to select a spell element. Based on the chosen number, display a message indicating the selected spell element: 1 for Fire, 2 for Water, 3 for Earth, and 4 for Air.
// After displaying the selected element, include a break statement to terminate the switch-case block.
// Hint: Utilize switch-case statements to handle different spell elements and use break statements to exit the switch-case block.
Console.Write("Select a spell element (1: Fire, 2: Water, 3: Earth, 4: Air): ");
int spellElement = Convert.ToInt32(Console.ReadLine());
switch (spellElement)
{
    case 1:
        Console.WriteLine("Fire");
        break;
    case 2:
        Console.WriteLine("Water");
        break;
    case 3:
        Console.WriteLine("Earth");
        break;
    case 4:
        Console.WriteLine("Air");
        break;
    default:
        Console.WriteLine("Invalid spell element selected.");
        break;
}

//---------------------------------------------------------------------
// Question 18: Skill Selection
// In a role-playing game (RPG), the player can choose skills to improve their character's abilities.
// Write a C# program that prompts the player to select a skill for enhancement. Based on the chosen number, display a message indicating the selected skill: 1 for Strength, 2 for Agility, 3 for Intelligence, and 4 for Vitality.
// After displaying the selected skill, include a break statement to terminate the switch-case block.
// Hint: Implement switch-case statements to handle different skill selections and use break statements to exit the switch-case block.
Console.Write("Select a skill for enhancement (1: Strength, 2: Agility, 3: Intelligence, 4: Vitality): ");
int skill = Convert.ToInt32(Console.ReadLine());
switch (skill)
{
    case 1:
        Console.WriteLine("Strength");
        break;
    case 2:
        Console.WriteLine("Agility");
        break;
    case 3:
        Console.WriteLine("Intelligence");
        break;
    case 4:
        Console.WriteLine("Vitality");
        break;
    default:
        Console.WriteLine("Invalid skill selected.");
        break;
}

//---------------------------------------------------------------------
// Question 19: Puzzle Solutions
// In a puzzle-solving game, the player can choose from different solutions to progress through the game.
// Write a C# program that prompts the player to select a solution for a puzzle. Based on the chosen number, display a message indicating the selected solution option.
// After displaying the selected solution, include a break statement to terminate the switch-case block.
// Hint: Use switch-case statements to handle different puzzle solution choices and use break statements to exit the switch-case block.
Console.Write("Select a solution for the puzzle (1 to 5): ");
solution = Convert.ToInt32(Console.ReadLine());
switch (solution)
{
    case 1:
        Console.WriteLine("Solution 1");
        break;
    case 2:
        Console.WriteLine("Solution 2");
        break;
    case 3:
        Console.WriteLine("Solution 3");
        break;
    case 4:
        Console.WriteLine("Solution 4");
        break;
    case 5:
        Console.WriteLine("Solution 5");
        break;
    default:
        Console.WriteLine("Invalid solution selected.");
        break;
}

//---------------------------------------------------------------------
// Question 20: Potion Brewing
// In an alchemy system, the player can brew potions using different ingredients.
// Write a C# program that prompts the player to choose an ingredient for potion brewing. Based on the chosen number, display a message indicating the selected ingredient: 1 for Herb, 2 for Mushroom, 3 for Flower, and 4 for Crystal.
// After displaying the selected ingredient, include a break statement to terminate the switch-case block.
// Hint: Implement switch-case statements to handle different ingredient choices and use break statements to exit the switch-case block.
Console.Write("Choose an ingredient for potion brewing (1: Herb, 2: Mushroom, 3: Flower, 4: Crystal): ");
int ingredient = Convert.ToInt32(Console.ReadLine());
switch (ingredient)
{
    case 1:
        Console.WriteLine("Herb");
        break;
    case 2:
        Console.WriteLine("Mushroom");
        break;
    case 3:
        Console.WriteLine("Flower");
        break;
    case 4:
        Console.WriteLine("Crystal");
        break;
    default:
        Console.WriteLine("Invalid ingredient selected.");
        break;
}

//---------------------------------------------------------------------
// Question 21: NPC Interactions
// In a game world, the player can interact with non-player characters (NPCs) in various ways.
// Write a C# program that simulates NPC interactions based on player input. Prompt the player to choose an interaction option with an NPC using numbers 1 to 3: 1 for Talk, 2 for Trade, and 3 for Quest.
// After displaying the selected interaction, include a break statement to terminate the switch-case block.
// Hint: Utilize switch-case statements to handle different NPC interaction options and use break statements to exit the switch-case block.
Console.Write("Choose an interaction option with the NPC (1: Talk, 2: Trade, 3: Quest): ");
interactionOption = Convert.ToInt32(Console.ReadLine());
switch (interactionOption)
{
    case 1:
        Console.WriteLine("Talk");
        break;
    case 2:
        Console.WriteLine("Trade");
        break;
    case 3:
        Console.WriteLine("Quest");
        break;
    default:
        Console.WriteLine("Invalid interaction option selected.");
        break;
}


//---------------------------------------------------------------------
// Question 22: Scene Navigation
// Write a C# program that simulates scene navigation in a game.
// The player can choose scenes using numbers 1 to 5 to navigate through different game environments.
// After displaying the selected scene, include a break statement to terminate the switch-case block.
// Hint: Implement switch-case statements to handle different scene selections and use break statements to exit the switch-case block.
Console.Write("Select a scene (1 to 5): ");
scene = Convert.ToInt32(Console.ReadLine());
switch (scene)
{
    case 1:
        Console.WriteLine("Scene 1: Forest");
        break;
    case 2:
        Console.WriteLine("Scene 2: Castle");
        break;
    case 3:
        Console.WriteLine("Scene 3: Desert");
        break;
    case 4:
        Console.WriteLine("Scene 4: Mountain");
        break;
    case 5:
        Console.WriteLine("Scene 5: City");
        break;
    default:
        Console.WriteLine("Invalid scene selected.");
        break;
}

//---------------------------------------------------------------------
// Question 23: Quest Progression
// In an adventure game, the player can progress through quests using different options.
// Write a C# program that prompts the player to select a quest option. After displaying the selected quest option, include a break statement to terminate the switch-case block.
// Hint: Use switch-case statements to handle different quest options and use break statements to exit the switch-case block.
Console.Write("Select a quest option (1 to 4): ");
int questOption = Convert.ToInt32(Console.ReadLine());
switch (questOption)
{
    case 1:
        Console.WriteLine("Quest Option 1");
        break;
    case 2:
        Console.WriteLine("Quest Option 2");
        break;
    case 3:
        Console.WriteLine("Quest Option 3");
        break;
    case 4:
        Console.WriteLine("Quest Option 4");
        break;
    default:
        Console.WriteLine("Invalid quest option selected.");
        break;
}

//---------------------------------------------------------------------
// Question 24: Menu Navigation
// Write a C# program that simulates menu navigation in a game.
// The player can navigate through menu options using numbers 1 to 4: 1 for Start, 2 for Options, 3 for Load Game, and 4 for Exit.
// After displaying the selected menu option, include a break statement to terminate the switch-case block.
// Hint: Utilize switch-case statements to handle different menu options and use break statements to exit the switch-case block.
Console.Write("Enter a number to navigate the menu (1: Start, 2: Options, 3: Load Game, 4: Exit): ");
menuOption = Convert.ToInt32(Console.ReadLine());
switch (menuOption)
{
    case 1:
        Console.WriteLine("Start");
        break;
    case 2:
        Console.WriteLine("Options");
        break;
    case 3:
        Console.WriteLine("Load Game");
        break;
    case 4:
        Console.WriteLine("Exit");
        break;
    default:
        Console.WriteLine("Invalid menu option selected.");
        break;
}