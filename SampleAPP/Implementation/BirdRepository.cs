using System;
using System.Collections.Generic;
using System.Text;

namespace SampleAPP
{
    /// <summary>
    /// Bird Repository Custom Implementation
    /// </summary>
    public interface IBirdRepository
    {
        /// <summary>
        /// Act to fly
        /// </summary>
        void TryFlying();
    }

    public class BirdRepository : AnimalRepository<Bird> , IBirdRepository
    {
        public override void Add(Bird animal)
        {
            Animals.Add(animal);
        }

        public void TryFlying()
        {
            Console.WriteLine("Whoosh!");
        }
    }
}
