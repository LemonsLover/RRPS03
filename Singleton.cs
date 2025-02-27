﻿namespace RRPS03
{
    public sealed class Singleton
    {
        private Singleton() { }

        private static Singleton instance;

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
