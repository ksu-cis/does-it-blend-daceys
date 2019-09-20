using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// A base class representing fruit
    /// </summary>
    public abstract class Fruit : IBlendable//, ICloneable //IComparable
    {
        public abstract string Blend();
            //return "Some kind of mush, I guess?";


    }
}
