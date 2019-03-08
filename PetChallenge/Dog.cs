using System;

namespace PetChallenge
{
    class Dog : Pet
    {
        public Dog(string name, string owner, double weight) : base("dog", name, owner, weight) { }

        public string bark(int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += "bark!";
            }
            return result;
        }
    }
}