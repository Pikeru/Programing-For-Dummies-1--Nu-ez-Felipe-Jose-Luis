using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ananido_1
{
    class Word
    {
        private string word1;
        private string word2;
        public string Word1 { get; set; }
        public string Word2 { get; set; }
        public int counter1, counter2;
        public bool TF;

        public void Iniciar()
        {
            Word1 = Console.ReadLine();
            int Length1 = Word1.Length;
            
            Word2 = Console.ReadLine();
            int Length2 = Word2.Length;
            

            if (Length1==Length2)
            {
                for (int i = 0; i < Length1; i++)
                {
                    counter1 = 0;
                    counter2 = 0;
                    for (int k = 0; k < Length2; k++)
                    {
                        if (Word1[i] == Word2[k])
                        {
                            counter1++;
                        }
                        if (Word1[i] == Word1[k])
                        {
                            counter2++;
                        }
                        
                    }
                    if (Word1 != Word2)
                    {
                        TF=false;
                    }
                    
                }
                TF = true;
            }
            else
            {
                TF = false;
            }
            if(TF==false)
            {
                Console.WriteLine("False anagram");
            }
            else
            {
                Console.WriteLine("True anagram \n Sanbika-Eir Aoi ");
            }
        }
    }
}
