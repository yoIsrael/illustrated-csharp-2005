using System;

namespace NestedClassVisibility
{
   class SomeClass                                            // Enclosing class
   {
      int Field1  = 15;                                        // Field of enclosing class
      int Field2  = 20;                                        // Field of enclosing class
      MyNested mn = null;                                     // Reference to nested class

      public void PrintMyMembers()
      {
         mn.PrintOuterMembers();                              // Call method in nested class.
      }

      public SomeClass()                                      // Constructor
      {
         mn = new MyNested(this);                             // Create instance of nested class.
      }

      class MyNested                                          // Nested class declaration
      {
         SomeClass sc = null;                                 // Reference to enclosing class
         public MyNested(SomeClass SC)                        // Construct or nested class
         {
            sc = SC;                                          // Store reference to enclosing class.
         }

         public void PrintOuterMembers()
         {
            Console.WriteLine("Field1: {0}", sc.Field1);      // Enclosing field.
            Console.WriteLine("Field2: {0}", sc.Field2);      // Enclosing field.
         }
      }                                                       // End of nested class
   }

   class Program
   {
      static void Main()
      {
         SomeClass MySC = new SomeClass();
         MySC.PrintMyMembers();
      }
   }
}
