using System;
using System.Collections;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            game.CheckForWin();
        }
        
    }
   public class Block
    {
       public int weight {get; private set;}
    }
    public class Tower
    {
       public Stack<Block> blocks = new Stack<Block>();

    }
    public class Game
    {
        // Console.WriteLine("Which one?");
       public Dictionary<string, Tower> towers = new Dictionary<string, Tower>();

        public Game()
        {
            towers.Add("A", new Tower());
            towers.Add("B", new Tower());
            towers.Add("C", new Tower());

            Block block1 = new Block(10);
            Block block2 = new Block(20);
            Block block3 = new Block(30);
            
            

            towers["A"].blocks.Push(block3);
            towers["A"].blocks.Push(block2);
            towers["A"].blocks.Push(block1);

            Console.WriteLine("How many blocks would you like?");
            Console.ReadLine();
           int NumbOfblocks = Console.ReadLine();
           Console.WriteLine("What tower do you pick?");
           Console.ReadLine();

        
            foreach(int block in NumbOfblocks)
            {
                count++;

            }
        }
        
        public string print()
        {
            foreach (var towerKey in towers.Keys)
            {
                foreach (Block block in towers[towerKey].blocks)
                {
                    Console.WriteLine(" Tower :" + towerKey + " Weight: " + block.weight);
                }
            }
        }
        public string MovePiece(string popOff, string pushOn)
        {
            Block block = towers[popOff].blocks.Pop();
            towers[pushOn].blocks.Push(block);
            print();

        }
        public bool isLegal(string popOff, string pushOn)
        {
            if (towers[popOff].blocks.Count == 0)
            {
                return false;
            }
            if (towers[pushOn].blocks.Count == 0)
            {
                return true;
            }
            Block popOffBlock = towers[popOff].blocks.Peek();
            Block pushOnBlock = towers[pushOn].blocks.Peek();

            if (popOffBlock.weight > pushOnBlock.weight)
            {
                return false;

            }
            else
            {
                return true;
            }
        }
        public bool CheckForWin()
        {
            if (towers["B"].blocks.Count || towers["C"].blocks.Count == 4)
            {
                Console.WriteLine("You Won!");
                return true;

            }
            else
            {
                return false;
            }
        }

    }

}
