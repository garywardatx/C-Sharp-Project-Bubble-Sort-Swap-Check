/*********************************************************************************************************

 * Project: Sort Algorithms
 * 
 * File: Bubble Sort Generic Class
 * 
 * Langauge: VS C#
 * 
 *
 *
 * Description: This file will utilize the sorting functionality found in the bubble sort method.
 *
 *
 * College: Husson University
 * 
 * Course:  IT 325
 * 
 * Author: Gary Edward Ward
 * 
 * 
 * 
 * Change Log:
 * 
 * Date                         Description of Change
 * 
 * ---------------           ----------------------------------------------------------------------------
 * 
 * 11/19/2020               - Initial writing
 * 11/19/2020               - Added regions
 * 11/19/2020               - Added the Sort, Swap, and IsSorted methods to the program
 * 11/19/2020               - Added the Bubble Sort Swap Check to the Swap method.
 * 
 * 
 * 
*********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT325_SortAlgorithms_GEW {
    class CS_BubbleShort_Generic {

        #region Constants
        #endregion Constants

        #region Data Members
        #endregion Data Members

        #region Properties
        #endregion Properties

        #region Events
        #endregion Events

        #region Methods

        /// <summary>
        /// This function determines if an array of type T
        /// is already in sort order
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool IsSorted<T>(T[] data) where T : IComparable {
            bool arrayIsSorted = true;      // assume the array is sorted
            int index = data.GetLowerBound(0);

            // check each element to see if in sort order
            while ((index < data.GetUpperBound(0)) && (arrayIsSorted)) { 
                if (data[index].CompareTo(data[index +1]) > 0) {
                    arrayIsSorted = false;
                } else {
                    index++;
                }
            }

            // return the result
            return arrayIsSorted;
        }
        /// <summary>
        /// Bubble sort with swap check.
        /// Counts the number of swaps in the current
        /// pass.
        /// If the number of swaps at the end of the
        /// pass is zero, then the list is sorted.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        public static void Sort<T>(T[] data) where T : IComparable {
            for (int pass = data.GetLowerBound(0); pass < data.GetUpperBound(0); pass++) {
                // added a boolean value to track if a swap takes place
                bool swapped = false;
                for (int current = data.GetLowerBound(0); current < data.GetUpperBound(0) - pass; current++) {
                    // bubble the largest remaining item to top (right) of the array
                    if (data[current].CompareTo(data[current + 1]) > 0) {
                        // wrong order, swap them
                        // swapped boolean value to verify if true
                        swapped = true;
                        Swap(data, current, current + 1);

                    }
                }
                // if no swaps take place, break the loop.
                if (!swapped) {
                    break;
                }
            }
        }
        /// <summary>
        /// This routine will swap two values whose index are specified by firstIndex
        /// and secondIndex inside the passed in array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="firstIndex"></param>
        /// <param name="secondIndex"></param>
        private static void Swap<T>(T[] data, int firstIndex, int secondIndex) {
            T temp;

            temp = data[firstIndex];
            data[firstIndex] = data[secondIndex];
            data[secondIndex] = temp;

        }
        #endregion Methods
    }
}
