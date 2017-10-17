using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7Pizza
{
    enum Size { SMALL= 10, MEDIUM =12, LARGE=14 };
    

    class Pizza
    {
        const double TOPPING_COST = 2.0;
        private Size size;
        private int numberOfCheese;
        private int numberOfHam;
        private int numberOfPepperoni;

        public Pizza()
        {
            size = Size.SMALL;
            numberOfCheese = 1;
            numberOfHam = 0;
            numberOfPepperoni = 0;
        }

        public Pizza(Size size, int cheese, int ham, int pepperoni)
        {
            this.size = size;
            SetNumberOfCheese(cheese);
            SetNumberOfHam(ham);
            SetNumberOfPepperoni(pepperoni);
        }

        public Size GetSize()
        {
            return size;
        }

        public int GetNumberOfCheese()
        {
            return numberOfCheese;
        }

        public int GetNumberOfPepperoni()
        {
            return numberOfPepperoni;
        }

        public int GetNumberOfHam()
        {
            return numberOfHam;
        }

        public void SetSize(Size size)
        {
            this.size = size;
        }

        public void SetNumberOfCheese(int cheese)
        {
            if (cheese < 0)
            {
                cheese = 0;
            }
            numberOfCheese = cheese;
        }

        public void SetNumberOfHam(int ham)
        {
            if (ham < 0)
            {
                ham = 0;
            }
            numberOfHam = ham;
        }

        public void SetNumberOfPepperoni(int pepperoni)
        {
            if(pepperoni < 0)
            {
                pepperoni = 0;
            }
            numberOfPepperoni = pepperoni;
        }

        public double CalculateCost()
        {
            return (double)size + 
                (numberOfPepperoni * TOPPING_COST) + 
                (numberOfHam * TOPPING_COST) + 
                (numberOfCheese * TOPPING_COST);
        }

        public override string ToString()
        {
            return String.Format("Size: {0}, # of cheese = {1}, # of ham = {2}, # of pepperoni = {3}, and cost of pizza is {4:C}.",
                size.ToString(), numberOfCheese, numberOfHam, numberOfPepperoni, CalculateCost());        }
    }
}
