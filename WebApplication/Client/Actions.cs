using System;

namespace WebApplication.Client
{
    public class Actions
    {
        public int GenerateRandomNumber()
        {
            Random n = new Random();
            return n.Next();
        }

        public string GetText()
        {
            return "This is TEXT";
        }


    }
}