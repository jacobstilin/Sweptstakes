using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}


// when using an interface it must use the functions of the interface
// data structure store information. binary search is a way of storing data. and it's fast
// dictionaries have key value pairs. sorted list have key value pairs and are sorted by keys
// elements can be accessed by key and index. it's like two arrays side by side
// dictionaries have better performance (faster) so use sorted list when you want collection sorted by key
// dictionary: O(1), sorted list O(log n)
// observable collection: dynamic data collection that notifies when items are added, removed or list is refreshed
// hashset: unordered collection with unique elements. can add, remove. can not be iterated over- must renumerate over list. used when a fast lookup
//     is needed. 
// stack and queue: abstract data types that contain elements in linear order
// stack: LIFO, last in first out. where have we seen this before? can only insert (push) or delete (pop) at top, end, of stack
// overflow: add to full stack. underflow: delete from empty stack. apparently a stack of papers stack of papers is an example. but it isn't
// who codes a stack of papers. it's a real world comparison and it needs to end.
// queue: FIFO, first in first out. insertion (enqueue) performed on rear of queue while deletion (dequeue) performed on front
// works like a queue, also known as a line. add to back of line, delete from front
// 
// next pppt
// observer pattern: one to many dependency between objects. one thing is changed, many things change depending on it. for example, someone wins
//     sweepstakes, so many other things must be updated
// ususally done via notifications from provider to one or more observers
// facade pattern (french)
// hides the complex parts of a large system by providing a simpler interface
// instead of calling a bunch of methods, call one method that takes care of everthing behind the FACADE
// we don't know or care what's happening behind the mask. we care about expected return when calling a method on the facade class
// composite pattern: composes objects in a tree structure to show entire hierarchy
// group of objects treated as single obj
// dependency injection: super important. I gotta know this in this field. 
// when a class is created, it should have its dependant classes injected into it rather than created by it-low coupling, high cohesion
// needed dependency, any other object the current object needs to hold a ref to) passed to the constructor
// simplifies managing dependencies between objects, easier to test code
// 

