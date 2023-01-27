using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonePattern
{
        public sealed class Singleton
        {
        /// <summary>
        /// sealed which ensures that the class cannot be inherited and object instantiation is restricted in the derived class.
        /// private constructor which will ensure that the class is not going to be instantiated from outside the class.
        ///  we declared the instance variable as private and also initialized it with the null value which ensures that only one instance of the class is created based on the null condition.
        /// The public property GetInstance is used to return only one instance of the class by checking the value of the private variable instance.
        /// The public method PrintDetails can be invoked from outside the class through the singleton instance.
        /// USE -
        /// Proxies,caching,logs,data sharing,facades
        /// SEALED -
        /// sealed keyword will prevent the class inheritances.
        /// ref-Why Singleton Class Sealed in C# - Dot Net Tutorials
        /// </summary>

        private static int counter = 0;
            private static Singleton instance = null;
            public static Singleton GetInstance
            {
                get
                {
                    if (instance == null)
                        instance = new Singleton();
                    return instance;
                }
            }

            private Singleton()
            {
                counter++;
                Console.WriteLine("Counter Value " + counter.ToString());
            }
            public void PrintDetails(string message)
            {
                Console.WriteLine(message);
            }
        }
}
