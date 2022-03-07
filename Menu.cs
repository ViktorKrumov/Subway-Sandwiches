using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SubwaySandvichi
{
    public class Menu<T> : IEnumerable<Sandwich<T>>
    {
        public List<Sandwich<T>> menu { get; set; }
        public int CurrentIndex { get; private set; }

        public Menu(params Sandwich<T>[] sandvichi)
        {
            menu = new List<Sandwich<T>>(sandvichi);
            CurrentIndex = 0;
        }

        //Ideqta e da izpintim vsichki sandvichi koito sa v menuto (demek tezi, koito nie napravihme)
        public IEnumerator<Sandwich<T>> GetEnumerator()
        {
            for (int i = 0; i < menu.Count; i++)
            {
                yield return menu[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Print()
        {
            if (this.menu.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(this.menu[CurrentIndex]);
            }
        }
    }
}
