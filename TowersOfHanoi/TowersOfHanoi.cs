using System;
using System.Collections;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Program
    {
        public void Main()
        {
            Game game = new Game();
            CheckForWin();
        }
        
    }
    class Block
    {
        int weight { public get; private set; }
    }
    class Tower
    {
        Stack<int> blocks = new Stack<int>();

    }
    class Game
    {
        // Console.WriteLine("Which one?");
        Dictionary<int, string> towers = new Dictionary<int, string>();

        public Game()
        {
            towers.Add("A", new Tower());
            towers.Add("B", new Tower());
            towers.Add("C", new Tower());

            Block block1 = new Block();
            Block block2 = new Block();
            Block block3 = new Block();
            block1.weight = 1;
            block2.weight = 10;
            block3.weight = 100;

            towers["A"].blocks.Push(block3);
            towers["A"].blocks.Push(block2);
            towers["A"].blocks.Push(block1);

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
            if (towers["B"].Count() || towers["C"].Count() == 4)
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
