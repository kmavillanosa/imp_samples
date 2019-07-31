using System;
using System.Collections.Generic;
using System.Text;

namespace SampleAPP
{
    /// <summary>
    /// concrete Implementation of a cat
    /// </summary>
    public class CatRepository : AnimalRepository<Cat>
    {
        public override void Add(Cat animal)
        {
            Animals.Add(animal);
        }
    }
}
