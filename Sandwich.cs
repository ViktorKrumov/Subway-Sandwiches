using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SubwaySandvichi
{
    public class Sandwich<T> : IComparable<Sandwich<T>>
    {
        public string Name { get; set; }
        public string Bread { get; set; }

        public List<T> Content;

        public int Count { get => Content.Count; }

        public Sandwich (string bread)
        {
            this.Bread = bread;
            Content = new List<T>(0);
            


        }


        //Dobavqme systavka kym sandvicha, koito sme napravili(obecta)
        public void Add(T sustavka)
        {
            if(Count < 10)
            {
                Content.Add(sustavka);
            }
            else
            {
                throw new ArgumentOutOfRangeException("You can not add more products");
            }
            
            

        }

        //Printim kolko sandivchi ima v menuto
        public int CountSystavki()
        {
            return Count;
        }

        //Proverqvame kolko mqsto e ostanalo v zavedenieto kato max-a moje da e kym 6 sandvicha
        public int Chek()
        {
            return 10 - Count;
        }
        
        //Dava cena
        public decimal Price()
        {
            Random rnd = new Random();
            decimal price = 0;

            for(int i =0; i < Count; i++)
            {
                decimal pri = rnd.Next(3, 15);
                price += pri;
            }
            return price;
        }

        //Dava obshtata cena koqto dyljim za 2-ta sandvicha obshto
        public decimal FinalPrice(decimal price1, decimal price2)
        {
            decimal finalprice = price1 + price2;
            return finalprice;
        }

        //Promenqme poslednata systavka
        public T ChangeLastProduct(T newProduct)
        {
            Content[Content.Count - 1] = newProduct;
            return newProduct;
        }

        //Maha vsichki dobaveni do momenta dobavki
        public void Reset()
        {
            Content.Clear();
            
        }

        //Promenq imeto (ako ne sme dovolni s pyrvonachalniqt si izbor)
        public string ChangeName(string newName)
        {
            Name = newName;
            return "The name was changed to " + newName;
        }

        // Vryshta cqlo sydyrjanie na sandvicha
        public List<T> PrintAll(List<T> content)
        {
            return content;
        }


        //Sryvnqva koi ot sandvichite ima poveche systavki
        public int CompareTo([AllowNull] Sandwich<T> other)
        {
            int isEqual = this.Count.CompareTo(other.Count);
           


            return isEqual;
        }
        

        
    }
}
