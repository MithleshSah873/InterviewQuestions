﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseWordsInASentence
{
    class Program
    {
        static void Main(string[] args)
        {
            var nOfTests = Console.ReadLine();
            var numberOfTests = 0;
            var listOfSentences = new List<string>();
            int.TryParse(nOfTests, out numberOfTests);
            while (numberOfTests > 0)
            {
                var inputSentence = Console.ReadLine();
                //listOfSentences.Add(inputSentence);
                Console.WriteLine(ReverseWordsInASentence(inputSentence));
                numberOfTests--;
            }
            //var listOfReversedStrings = ReverseAllStrings(listOfSentences);
            //foreach (var reversed in listOfReversedStrings)
            //{
            //    Console.WriteLine(reversed);
            //}
        }

        //public static List<string> ReverseAllStrings(List<string> listOfSentences)
        //{
        //    var listOfReversed = new List<string>();
        //    foreach(var sentence in listOfSentences)
        //    {
        //        listOfReversed.Add(ReverseWordsInASentence(sentence));
        //    }
        //    return listOfReversed;
        //}

        public static string ReverseWordsInASentence(string sentence)
        {
            var words = sentence.Split('.').Reverse().ToArray();
            return string.Join(".", words);
        }
    }
}
