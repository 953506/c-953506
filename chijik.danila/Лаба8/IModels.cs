using System;

    interface IModels
    {
        public void Buy(bool inStock)
        {
            try
            {
                if (inStock)
                {
                    Console.WriteLine("You successfully bought this one!");
                    inStock = false;
                }

                else
                {
                    throw new Exception("The car is out of stock!");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Restore(bool inStock)
        {
            if (!inStock)
                inStock = true;
        }

        public void ShowModels();
        bool Available { get; set; }
    }