﻿using System;

namespace objectorianted
{
    class Program
    {
        const string INVENTORY_JSON = @"V:\BridgeLabz\ObjectOrientedProgramming\ObjectOrientedProgram\InventoryManagement\Inventory.json";
        static void Main(string[] args)
        {
            InventoryMain main = new InventoryMain();
            main.DisplayData(INVENTORY_JSON);
        }
    }
