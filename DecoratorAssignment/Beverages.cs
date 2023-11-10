using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssignment
{
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract decimal Cost();
    }

    // Beverages/Darkroste.cs
    public class Darkroste : Beverage
    {
        public Darkroste()
        {
            description = "Darkroste Coffee";
        }

        public override decimal Cost()
        {
            return 0.99m;
        }
    }

    // Beverages/Decaf.cs
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf Coffee";
        }

        public override decimal Cost()
        {
            return 1.05m;
        }
    }

    // Beverages/Espresso.cs
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso Coffee";
        }

        public override decimal Cost()
        {
            return 1.99m;
        }
    }

    // Beverages/Houseblend.cs
    public class Houseblend : Beverage
    {
        public Houseblend()
        {
            description = "Houseblend Coffee";
        }

        public override decimal Cost()
        {
            return 0.89m;
        }
    }
}
