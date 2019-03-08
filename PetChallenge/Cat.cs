using System;

namespace PetChallenge
{
    class Cat : Pet
    {
        public Cat(string name, string owner, double weight) : base("cat", name, owner, weight) { }

        public string meow(int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += "meow.";
            }
            return result;
        }
    }
}