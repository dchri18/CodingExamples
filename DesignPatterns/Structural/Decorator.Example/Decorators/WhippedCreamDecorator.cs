﻿using Decorator.Example.Interfaces;

namespace Decorator.Example.Decorators
{
    public class WhippedCreamDecorator : CoffeeDecorator
    {
        public WhippedCreamDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Whipped Cream";
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.75;
        }
    }
}
