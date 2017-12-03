using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture13Lab
{
    class Handicapper
    {
        private int[] arr = new int[10];
        private int numScores;

        public Handicapper()
        {
            numScores = 0;
        }

        // Define the indexer to allow client code to use [] notation.
        public int this[int i]
        {
            get {
                
                return arr[(numScores-(i+1)) % 10];
            }            
        }

        public void AddScore(int score)
        {
            arr[numScores%10] = score;
            numScores++;
        }
    }
}
