using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssignment
{
    // Condiments/CondimentDecorator.cs
    public abstract class Condiment: Beverage
    {
        protected Beverage _beverage;

        public Condiment(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription();
        }

        public override decimal Cost()
        {
            return _beverage.Cost();
        }
    }

    // Condiments/MilkDecorator.cs
    public class Milk : Condiment
    {
        public Milk(Beverage beverage) : base(beverage)
        {
            description = "Milk";
        }

        public override decimal Cost()
        {
            return _beverage.Cost() + 0.2m;
        }
    }

    // Condiments/MochaDecorator.cs
    public class Mocha : Condiment
    {
        public Mocha(Beverage beverage) : base(beverage)
        {
            description = "Mocha";
        }

        public override decimal Cost()
        {
            return _beverage.Cost() + 0.2m;
        }
    }

    // Condiments/SoyDecorator.cs
    public class Soy : Condiment
    {
        public Soy(Beverage beverage) : base(beverage)
        {
            description = "Soy";
        }

        public override decimal Cost()
        {
            return _beverage.Cost() + 0.15m;
        }
    }

    // Condiments/WhipDecorator.cs
    public class Whip : Condiment
    {
        public Whip(Beverage beverage) : base(beverage)
        {
            description = "Whip";
        }

        public override decimal Cost()
        {
            return _beverage.Cost() + 0.10m;
        }
    }

}
