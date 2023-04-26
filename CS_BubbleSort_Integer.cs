/*********************************************************************************************************

 * Project: Sort Algorithms
 * 
 * File: Bubble Sort Integers Class
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
 * 11/19/2020               - Swap routine added, with updated code for Bubble Sort Swap Check
 * 11/19/2020               - Sort routine added
 * 
 * 
*********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT325_SortAlgorithms_GEW {
    class CS_BubbleSort_Integer {

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
        /// This function sorts an array of integer data using a bubble sort.
        /// </summary>
        /// <param name="data"></param>
        public static void Sort(int[] data) {
            for (int pass = data.GetLowerBound(0); pass < data.GetUpperBound(0); pass++) {
                // added a boolean value to track if a swap takes place
                bool swapped = false;
                for (int current = data.GetLowerBound(0); current < data.GetUpperBound(0) - pass; current++) {
                    // bubble the largest remaining item to top (right) of the array
                    if (data[current] > data[current + 1]) {
                        // wrong order, swap them
                        // swapped boolean value to verify if true
                        swapped = true;
                        Swap(data, current, current + 1);

                        //Bubble sort with Swap Check:
                        // Counts the number of swaps in the current
                        // pass.
                        // If the number of swaps at the end of the
                        // pass is zero, then the list is sorted.
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
        /// <param name="data"></param>
        /// <param name="firstIndex"></param>
        /// <param name="secondIndex"></param>
        public static void Swap(int[] data, int firstIndex, int secondIndex) {
            int temp;

            temp = data[firstIndex];
            data[firstIndex] = data[secondIndex];
            data[secondIndex] = temp;


        }
        #endregion Methods
    }
}
