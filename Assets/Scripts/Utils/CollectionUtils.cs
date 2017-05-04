using System.Collections.Generic;

namespace Utils
{
    public static class CollectionUtils
    {
         public static Stack<T> ToStack<T> (this IEnumerable<T> list)
         {
            Stack<T> stack = new Stack<T> ();
            foreach (T element in list)
                stack.Push (element);
            return stack;
         }
    }
}