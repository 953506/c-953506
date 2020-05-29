using System;

    interface IModels
    {
        public void Buy(bool inStock)
        {
            if (inStock)
            {
                Console.WriteLine("You successfully bought this one!");
                inStock = false;
            }

            else
                Console.WriteLine("Sorry, but this one is out of stock!");
        }

        public void Restore(bool inStock)
        {
            if (!inStock)
                inStock = true;
        }

        public void ShowModels();
        bool Available { get; set; }
    }