using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercises
{
    public class Exercise003
    {
        public string[] IceCreamFlavours = { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };

        public SortedList<string, int> iceCreamFlavourAndCode = new SortedList<string, int>();
        public void AddIceCreamCodeToFlavour()
        {            
            int iceCreamCode = 0;

            //Encode Ice cream flavours starting from 0
            foreach (var flavourName in IceCreamFlavours)
            {
                iceCreamFlavourAndCode.Add(flavourName, iceCreamCode);
                iceCreamCode++;
            }
        }
        public int IceCreamCode(string iceCreamFlavour)
        {
            //Method to encode Ice cream flavours
            AddIceCreamCodeToFlavour();

            if (!string.IsNullOrEmpty(iceCreamFlavour))
            {
                //Return Ice cream code for the given input flavour
                for (int i = 0; i < iceCreamFlavourAndCode.Count; i++)
                {
                    if (iceCreamFlavourAndCode.ContainsKey(iceCreamFlavour))
                    {
                        return iceCreamFlavourAndCode[iceCreamFlavour];
                    }
                }

                return -1;
            }

            throw new ArgumentException("Please enter a valid flavour name.");
        }
    }
}
