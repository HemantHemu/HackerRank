using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class PrimeTriplets
    {
        static List<long> primeDict = new List<long> { };
        static dynamic primesMarked;
        public static void PrimeTriplet()
        {
            int[] rows = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            
            long maxInp = Math.Max(rows[0], rows[1])+2;
            long limit = (long)Math.Ceiling(Math.Sqrt((double)(maxInp*(maxInp+1))/2));
            primeMarker(limit);
            int temp = rows[0] - 3 > 0 ? rows[0] - 3 : rows[0] - 2 > 0 ? rows[0] - 2 : 1;
            //starting and ending limits for 5 rows inclusive
            int start = (temp * (temp + 1)) / 2,
                end = ((rows[0] + 2)* (rows[0] + 3)) / 2;

            PrimeGenerator(start, end);

            long tripSum = rowCheck(rows[0], start);
            temp = rows[1] - 3 > 0 ? rows[1] - 3 : rows[1] - 2 > 0 ? rows[1] - 2 : 1;
            start = (temp * (temp + 1)) / 2;
            end = ((rows[1] + 3) * (rows[1] + 4)) / 2;
            PrimeGenerator(start, end);
            tripSum += rowCheck(rows[1], start);
            Console.WriteLine(tripSum);
            Console.ReadKey();
        }

        //dictionary of primes to generate primes from start to end : used on PrimeGenerator method
        public static void primeMarker(long limit)
        {
            long[] primeGenerator = new long[limit + 2];
            for (int i = 2; i < limit + 2; i++) {
                if (primeGenerator[i] != -1) {
                    primeGenerator[i] = 1;
                    primeDict.Add(i);
                    for (int inc = 2, y = i * inc; y < limit + 2; inc++, y = i * inc) {
                        primeGenerator[y] = -1;
                    }
                }
            }
            
        }

        public static void PrimeGenerator(long s, long e)
        {
            long[] primeGenerator = new long[e - s + 1];
            for (long i = s; i <= e; i++) {
                if (primeCheck(i)) { primeGenerator[i - s] = 1; }
            }
            primesMarked = primeGenerator.ToArray();
        }
        public static bool primeCheck(long pd)
        {
            if (pd == 1 || pd == 0 || pd%2==0) { return false; }
            if (pd == 2 || pd == 3 || pd == 5 || pd == 7 || pd == 11) { return true; }
            foreach(long primes in primeDict) {
                if (pd <= primes) { break; }
                else if (pd%primes==0) { return false; } }
            return true;
        }
        public static long rowCheck(int r,long offset)
        {
            if (r == 1) { return 0; }
            if (r == 2) { return 5; }
            if (r == 3) { return 5; }
            int start = ((r - 1) * r) / 2;
            int end = ((r) * (r + 1)) / 2;
            long tripSum = 0;
            List<long> AnswerList = new List<long> { };
            //my particular row
            for (int i = start + 1; i <= end; i++){
                if (primesMarked[i - offset] == 1 && checkForNeighbour(r, i, offset))
                {
                    tripSum += i;
                    AnswerList.Add(i);
                }
            }
            return tripSum;
         }
        

        //level 1 checking
        public static bool checkForNeighbour(int r, long i, long offset)
        {
            long PrimaryElement = i;
            List<Int64> tempNeighbour = new List<Int64> { };

            //by checking the start and end limts using n*(n+1)/2
            for (int j = -1; j <= 1; j += 2){
                int row = r + j;
                int start = ((row - 1) * row) / 2;
                int end = ((row) * (row + 1)) / 2;

                long elementToBeChecked = PrimaryElement + (j == -1 ? -r + 1 : r);
                if (elementToBeChecked - 1 > start && elementToBeChecked - 1 <= end && primesMarked[elementToBeChecked - 1 - offset] ==1) { tempNeighbour.Add(elementToBeChecked - 1); tempNeighbour.Add(row);}
                else if (elementToBeChecked > start     && elementToBeChecked <= end && primesMarked[elementToBeChecked - offset] == 1 ) { tempNeighbour.Add(elementToBeChecked ); tempNeighbour.Add(row); }
                else if (elementToBeChecked + 1 > start && elementToBeChecked + 1 <= end && primesMarked[elementToBeChecked + 1 - offset] == 1) { tempNeighbour.Add(elementToBeChecked + 1); tempNeighbour.Add(row); }

            }
            if (tempNeighbour.Count > 2) { return true; }
            else if (tempNeighbour.Count == 2 && (checkForNeighbour((int)tempNeighbour[1], tempNeighbour[0], offset, PrimaryElement))) {
                   return true; 
            }
            
                return false;
        }

        //level 2 checking
        public static bool checkForNeighbour(int r, long i, long offset, long PrimaryElement)
        {
            long level1element = i;
            for (int j = -1; j <= 1; j += 2)
            {
                int row = r + j;
                int start = ((row - 1) * row) / 2;
                int end = ((row) * (row + 1)) / 2;

                long elementToBeChecked = level1element + (j == -1 ? -r + 1 : r);
                     if (elementToBeChecked - 1 != level1element && elementToBeChecked - 1 != PrimaryElement && elementToBeChecked - 1 > start && elementToBeChecked - 1 <= end && primesMarked[elementToBeChecked - 1 - offset] == 1) { return true; }
                else if (elementToBeChecked != level1element     && elementToBeChecked != PrimaryElement     && elementToBeChecked > start     && elementToBeChecked <= end     && primesMarked[elementToBeChecked - offset] == 1) { return true; }
                else if (elementToBeChecked + 1 != level1element && elementToBeChecked + 1 != PrimaryElement && elementToBeChecked + 1 > start && elementToBeChecked + 1 <= end && primesMarked[elementToBeChecked + 1 - offset] == 1) { return true; }
                
            }

            return false;
        }
    }

}

