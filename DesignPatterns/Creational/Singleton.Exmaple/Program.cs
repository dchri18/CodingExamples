namespace Singleton.Exmaple
{
    /// <summary>
    /// Sealed Class: The SingletonClass is marked as sealed to prevent it from being inherited, which could 
    ///     lead to multiple instances.
    /// Private constructor: The constructor is declared as private to prevent direct instantiation from outside the class.
    /// Static instance field: The instance field is declared as private static volatile to ensure thread-safety.
    /// Thread-safe instantiation: The Instance property uses a thread-safe, lazy initialization with double-check 
    ///     locking to ensure that only one instance is created, even in a multi-threaded environment.
    /// Synchronisation root: A separate syncRoot object is used for locking instead of locking on the type itself. 
    ///     This avoids potential deadlocks caused by the type constructor trying to acquire the lock on itself.
    /// Lazy instantiation: The instance is created only when the Instance property is accessed for the first time, 
    ///     ensuring that the instance is not created until it's actually needed.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            var singletonOne = SingletonClass.Instance;
            Console.WriteLine("Acquired instance first time");
          
            singletonOne.TestValue = 5;
            Console.WriteLine($"Set test value of {singletonOne.TestValue} to firstly acquired instance");

            var singletonTwo = SingletonClass.Instance;
            Console.WriteLine("Acquired instance second time");

            Console.WriteLine("Without setting, test value is: " + singletonOne.TestValue);
        }
    }
}
