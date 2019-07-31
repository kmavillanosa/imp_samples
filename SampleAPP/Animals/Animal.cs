using System;
using System.Collections.Generic;
using System.Text;

namespace SampleAPP
{
    /// <summary>
    /// Base Implementation of animal
    /// </summary>
    public interface IAnimal { }

    /// <summary>
    /// Abstract class means it cannot be initialized but can be inherited
    /// basic traits of an animal
    /// </summary>
    public abstract class Animal : IAnimal
    {
        public string ScientificName { get; set; }
        public string Kingdom { get; set; }
    }

    /// <summary>
    /// Base implementation of an animal repository
    /// </summary>
    /// <typeparam name="TAnimal"></typeparam>
    public interface IAnimalRepository<TAnimal>
         where TAnimal : IAnimal
    {
        /// <summary>
        /// Gets animals on List
        /// </summary>
        /// <returns></returns>
        List<TAnimal> GetAnimals();
        /// <summary>
        /// Adds Some Animal on List
        /// </summary>
        /// <param name="animal"></param>
        void Add(TAnimal animal);
        /// <summary>
        /// Remove animal on list
        /// </summary>
        /// <param name="animal"></param>
        void Remove(TAnimal animal);
    }

    /// <summary>
    /// Base Animal repository
    /// </summary>
    /// <typeparam name="TAnimal">Model implements IAnimal</typeparam>
    public abstract class AnimalRepository<TAnimal> : IAnimalRepository<TAnimal>
        where TAnimal : IAnimal
    {
        /// <summary>
        /// Can be modified within Animal repository but outside access [ReadOnly]
        /// </summary>
        public List<TAnimal> Animals { get; private set; }
        
        /// <summary>
        /// has [ABSTRACT] modifier Custom Implementation for this method
        /// </summary>
        /// <param name="animal"></param>
        public abstract void Add(TAnimal animal);

        public List<TAnimal> GetAnimals()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Accessible method in 
        /// </summary>
        /// <param name="animal"></param>
        public void Remove(TAnimal animal)
        {
            Animals.Remove(animal);
        }
    }

   

}
