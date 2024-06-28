class Character     // Base class for characters like Player and Enemy
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int AttackPower { get; set; }
    public int Defense { get; set; }

    /* Increase HP if amount is positive, decrease if negative */
    public void UpdateHP(int amount)
    {
        HP += amount;
    }

    public void Inflictdamage(Character target)
    {
        var damage = this.AttackPower - target.Defense;
        if (damage < 0)
        {
            damage = 0;
        }
        target.UpdateHP(-damage);
    }
}

//---------------------------------------------------------------------
class Rewards
{
    public List<Item> Items { get; set; }
    public int XPValue { get; set; }

    public void DisplayRewards()
    {
        // Console.WriteLine("REWARDS:\n--------------------------------------------------");
        Console.WriteLine($"XP Value: {XPValue}");
        foreach (Item item in Items)
        {
            Console.WriteLine("--------------------------------------------------");
            item.DisplayDetails();
        }
        Console.WriteLine("--------------------------------------------------");
    }
}


//---------------------------------------------------------------------
// Question 1: Player Class
// Create a class named "Player" to represent a character in a role-playing game.
// Include attributes for the player's name, level, health points (HP), and experience points (XP).
// Implement methods to level up the player, heal the player, and gain experience points.
// Hint: Declare a class with properties for name, level, HP, and XP. Implement methods to increase level, heal HP, and gain XP.
/* Think about how players progress in a typical RPG game. Consider what actions a player can take and how they affect the player's attributes. */
class Player : Character
{
    // public string Name { get; set; }
    // public int HP { get; set; }
    // public int attackPower { get; set; }
    // public int Defense { get; set; }
    public int Level { get; set; }
    public int MP { get; set; }
    public int XP { get; set; }

    public void Heal(int amount)
    {
        this.UpdateHP(amount);
    }

    public void TakeDamage(int damage)
    {
        this.UpdateHP(-damage);
    }

    public void LevelUp()
    {
        Level++;
    }

    public void GainXP(int amount)
    {
        XP += amount;
    }

}

//---------------------------------------------------------------------
// Question 2: Enemy Class
// Develop a class called "Enemy" to represent adversaries in a video game.
// Include properties for the enemy's name, health points (HP), attack power, and defense.
// Implement methods to calculate damage inflicted by the enemy and to update their HP.
// Hint: Define a class with attributes for name, HP, attack power, and defense. Create methods to calculate damage and update HP.
/* Consider the role enemies play in games. They typically attack players and can be defeated by reducing their HP to zero. */
class Enemy : Character
{
    // public string Name { get; set; }
    // public int HP { get; set; }
    // public int AttackPower { get; set; }
    // public int Defense { get; set; }

    // Drops XP and items when defeated
    public Rewards Loots { get; set; }

    public void Drops()
    {
        // Drop XP and items when defeated
        Console.WriteLine($"Enemy defeated. You received:\n--------------------------------------------------");
        this.Loots.DisplayRewards();
    }
}

//---------------------------------------------------------------------
// Question 3: Potion Class
// Design a class named "Potion" to model health-restoring items in an adventure game.
// Include properties for the potion's name, healing power, and quantity in inventory.
// Implement a method to apply the potion to a player character and restore their health.
// Hint: Define a class with attributes for name, healing power, and quantity. Create a method to apply the potion and heal the player.
/* Think about how healing items function in games. They typically restore a portion of a player's health when consumed. */
class Potion
{
    public string Name { get; set; }
    public int HealingPower { get; set; }
    public int Quantity { get; set; }

    public void Apply(Player player)
    {
        player.Heal(HealingPower);
    }
}

//---------------------------------------------------------------------
// Question 4: Quest Class
// Create a class called "Quest" to represent tasks or missions in a quest-based game.
// Include properties for the quest's name, description, reward, and completion status.
// Implement methods to start the quest, complete the quest, and claim the reward.
// Hint: Define a class with attributes for name, description, reward, and completion status. Implement methods to manage quest progress.
/* Consider the structure of quests in games. They often involve objectives, rewards, and tracking completion status. */
class Quest
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Rewards Reward { get; set; }
    public bool IsCompleted { get; set; }

    public void Start()
    {
        // Perform any initialization or setup for the quest
        IsCompleted = false;
    }

    public void Complete()
    {
        IsCompleted = true;
    }

    public void ClaimReward(Player player)
    {
        // Apply the reward to the player
        player.GainXP(this.Reward.XPValue);
        Console.WriteLine("REWARDS:\n----------------------------------------------");
        this.Reward.DisplayRewards();

    }
}


//---------------------------------------------------------------------
// Question 5: Inventory Class
// Develop a class named "Inventory" to manage a player's items in a role-playing game.
// Include properties for the inventory's capacity, list of items, and methods to add/remove items.
// Implement functionality to check if an item exists in the inventory and display its details.
// Hint: Define a class with attributes for capacity and a list of items. Create methods to add, remove, and search for items.
/* Think about how inventories work in games. Players can store and manage various items they collect during their adventures. */
class Inventory
{
    // Capacity == -1 : infinite capacity
    // Capacity > -1 : has limit
    public int Capacity { get; set; }
    public List<Item> Items { get; set; }

    public void AddItem(Item item)
    {
        // Add the item to the inventory
        if (Items.Count < Capacity)
        {
            Items.Add(item);
        }
    }

    public void RemoveItem(Item item)
    {
        // Remove the item from the inventory
        if (Items.Contains(item))
        {
            Items.Remove(item);
        }
    }

    public bool ContainsItem(Item item)
    {
        // Check if the item is in the inventory
        return Items.Contains(item);
    }

    public void DisplayItemDetails(Item item)
    {
        // Display the details of the item
        item.DisplayDetails();
    }
}

class Item
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Value { get; set; }

    public void DisplayDetails()
    {
        // Display the item's name, description, and value
        Console.WriteLine($"Item name: {Name}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Item value: {Value}");
    }
}

//---------------------------------------------------------------------
// Question 6: Spell Class
// Design a class called "Spell" to represent magical abilities or spells in a fantasy game.
// Include properties for the spell's name, damage, mana cost, and description.
// Implement methods to cast the spell, consume mana, and display spell details.
// Hint: Define a class with attributes for name, damage, mana cost, and description. Implement methods to cast and describe the spell.
/* Consider the mechanics of spellcasting in fantasy games. Spells often have different effects, costs, and descriptions. */
class Spell
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public int ManaCost { get; set; }
    public string Description { get; set; }

    public void Cast(Player player)
    {
        // Apply the spell's effects on the player
    }

    public void ConsumeMana(Player player)
    {
        // Deduct the spell's mana cost from the player's mana pool
    }

    public void DisplayDetails()
    {
        // Display the spell's name, damage, mana cost, and description
    }
}

// main method
public class Program
{
    public static void Main()
    {
        // Implement the above classes and test their functionality here
        // Create instances of the classes and call their methods to demonstrate their behavior
        // You can create sample characters, items, spells, quests, etc., and interact with them in the program
        // Feel free to add additional features or classes to enhance the program
        Player player = new Player
        {
            Name = "Hero",
            HP = 100,
            AttackPower = 20,
            Defense = 10,
            Level = 1,
            MP = 50,
            XP = 0
        };

        Enemy enemy = new Enemy
        {
            Name = "Goblin",
            HP = 50,
            AttackPower = 15,
            Defense = 5
        };

        Potion healthPotion = new Potion
        {
            Name = "Health Potion",
            HealingPower = 30,
            Quantity = 3
        };

        Item sword = new Item
        {
            Name = "Sword",
            Description = "A basic weapon for melee combat.",
            Value = 50
        };

        Quest mainQuest = new Quest
        {
            Name = "Defeat the Dragon",
            Description = "Slay the mighty dragon terrorizing the kingdom.",
            Reward = new Rewards
            {
                XPValue = 100,
                Items = new List<Item> { sword }
            },
            IsCompleted = false
        };

        Inventory playerInventory = new Inventory
        {
            Capacity = 5,
            Items = new List<Item>()
        };

        playerInventory.AddItem(sword);

        Console.WriteLine("Player Information:");
        Console.WriteLine($"Name: {player.Name}");
        Console.WriteLine($"Level: {player.Level}");
        Console.WriteLine($"HP: {player.HP}");
        Console.WriteLine($"MP: {player.MP}");
        Console.WriteLine($"XP: {player.XP}");
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("Enemy Information:");
        Console.WriteLine($"Name: {enemy.Name}");
        Console.WriteLine($"HP: {enemy.HP}");
        Console.WriteLine($"Attack Power: {enemy.AttackPower}");
        Console.WriteLine($"Defense: {enemy.Defense}");
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("Potion Information:");
        Console.WriteLine($"Name: {healthPotion.Name}");
        Console.WriteLine($"Healing Power: {healthPotion.HealingPower}");
        Console.WriteLine($"Quantity: {healthPotion.Quantity}");
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("Item Information:");
        sword.DisplayDetails();
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("Quest Information:");
        Console.WriteLine($"Name: {mainQuest.Name}");
        Console.WriteLine($"Description: {mainQuest.Description}");
        Console.WriteLine($"Reward: {mainQuest.Reward.XPValue} XP");
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("Inventory Information:");
        Console.WriteLine($"Capacity: {playerInventory.Capacity}");
        Console.WriteLine("Items:");
        foreach (Item item in playerInventory.Items)
        {
            item.DisplayDetails();
        }
        Console.WriteLine("--------------------------------------------------");

        // Simulate player attacking the enemy
        player.Inflictdamage(enemy);

        Console.WriteLine("After Player Attacks Enemy:");
        Console.WriteLine("Player HP: " + player.HP);
        Console.WriteLine("Enemy HP: " + enemy.HP);
        Console.WriteLine("--------------------------------------------------");

        // Simulate player using a health potion
        healthPotion.Apply(player);
        Console.WriteLine("After Player Uses Health Potion:");
        Console.WriteLine("Player HP: " + player.HP);
        Console.WriteLine("--------------------------------------------------");

        // Simulate player completing a quest
        mainQuest.Complete();
        mainQuest.ClaimReward(player);
        Console.WriteLine("After Player Completes Quest:");
        Console.WriteLine("Player XP: " + player.XP);
        Console.WriteLine("--------------------------------------------------");

        // Simulate player adding an item to the inventory
        Item newSword = new Item
        {
            Name = "Great Sword",
            Description = "A powerful two-handed sword.",
            Value = 100
        };
        playerInventory.AddItem(newSword);

        Console.WriteLine("After Player Adds Item to Inventory:");
        Console.WriteLine("Inventory Items:");
        foreach (Item item in playerInventory.Items)
        {
            item.DisplayDetails();
        }
        Console.WriteLine("--------------------------------------------------");

        // Simulate player removing an item from the inventory
        playerInventory.RemoveItem(sword);

        Console.WriteLine("After Player Removes Item from Inventory:");
        Console.WriteLine("Inventory Items:");
        foreach (Item item in playerInventory.Items)
        {
            item.DisplayDetails();
        }
        Console.WriteLine("--------------------------------------------------");

        // Simulate enemy dropping rewards
        enemy.Loots = new Rewards
        {
            XPValue = 50,
            Items = new List<Item> { sword }
        };
        enemy.Drops();

        Console.WriteLine("After Enemy Drops Rewards:");
        Console.WriteLine("Player XP: " + player.XP);
        Console.WriteLine("Inventory Items:");
        foreach (Item item in playerInventory.Items)
        {
            item.DisplayDetails();
        }
        Console.WriteLine("--------------------------------------------------");
    }
}