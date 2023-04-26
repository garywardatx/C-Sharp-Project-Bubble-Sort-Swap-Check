/*********************************************************************************************************

 * Project: Sort Algorithms
 * 
 * File: Form Class
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
 * 11/19/2020               - Added events for InLine, Function, Integer and Generic
 * 11/19/2020               - Added methods to display data in the listbox both in intergers and doubles
 * 11/19/2020               - Added the Bubble sort function with updated code for the Bubble Sort Swap Check
 * 11/19/2020               - Added swap method
 * 11/19/2020               - Added Bubble Sort Swap Check
 * 
 * 
 * 
*********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT325_SortAlgorithms_GEW {
    public partial class FormSortAlgorithms : Form {

        #region Constants
        #endregion Constants

        #region Data Members
        private int[] valueArray = { 57, 63, 40, 13, 74, 99, 21, 8 };
        private double[] gradeArray = { 57.2, 63.6, 40.8, 13.1, 74.5, 99.9, 21.2, 8.0 };

        #endregion Data Members

        #region Constructors
        public FormSortAlgorithms() {
            InitializeComponent();
        }

        #endregion Constructors

        #region Events
        private void buttonFunction_Click(object sender, EventArgs e) {
            // display the raw (unsorted) data
            DisplayDataInListBox(listBoxBeforeSort, valueArray);

            /*
            listBoxBeforeSort.Items.Clear();
            for (int index = valueArray.GetLowerBound(0); index <= valueArray.GetUpperBound(0); index++) {
                listBoxBeforeSort.Items.Add(valueArray[index].ToString());
            } */

            // sort using the bubble sort function
            BubbleSortFunction(valueArray);

            // display the sorted data
            DisplayDataInListBox(listBoxAfterSort, valueArray, true);
            

            /*
            listBoxAfterSort.Items.Clear();
            for (int index = valueArray.GetLowerBound(0); index <= valueArray.GetUpperBound(0); index++) {
                listBoxAfterSort.Items.Add(valueArray[index].ToString());
            }*/

        }

        private void buttonBubbleSortClass_Click(object sender, EventArgs e) {
            // display the raw (unsorted) data
            DisplayDataInListBox(listBoxBeforeSort, valueArray);

            /*
            listBoxBeforeSort.Items.Clear();
            for (int index = valueArray.GetLowerBound(0); index <= valueArray.GetUpperBound(0); index++) {
                listBoxBeforeSort.Items.Add(valueArray[index].ToString());
            } */

            // sort using the bubble sort class
            CS_BubbleSort_Integer.Sort(valueArray);

            // display the sorted data
            DisplayDataInListBox(listBoxAfterSort, valueArray, true);


            /*
            listBoxAfterSort.Items.Clear();
            for (int index = valueArray.GetLowerBound(0); index <= valueArray.GetUpperBound(0); index++) {
                listBoxAfterSort.Items.Add(valueArray[index].ToString());
            }*/
        }

        private void buttonBubbleSortGeneric_Click(object sender, EventArgs e) {
            // display the raw (unsorted) data
            DisplayDataInListBox(listBoxBeforeSort, gradeArray);
            listBoxBeforeSort.Items.Add(CS_BubbleShort_Generic.IsSorted(gradeArray).ToString());

            // sort using the bubble sort generic class
            CS_BubbleShort_Generic.Sort(gradeArray);

            // display the sorted data
            DisplayDataInListBox(listBoxAfterSort, gradeArray, true);
            listBoxAfterSort.Items.Add(CS_BubbleShort_Generic.IsSorted(gradeArray).ToString());
        }

        /// <summary>
        /// Bubble sort with swap check.
        /// Counts the number of swaps in the current
        /// pass.
        /// If the number of swaps at the end of the
        /// pass is zero, then the list is sorted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBubbleInline_Click(object sender, EventArgs e) {
            // This routine does not follow the three design principles.
            // 1. It does not have a single purpose
            // 2. intermix of output and processing
            // 3. not portable, not maintainable

            // display the raw (unsorted) data
            listBoxBeforeSort.Items.Clear();
            for (int index = valueArray.GetLowerBound(0); index <= valueArray.GetUpperBound(0); index++) {
                listBoxBeforeSort.Items.Add(valueArray[index].ToString());
            }

            // sort the data
            // make n-1 passes over the array
            int temp;           // temp memory location for swapping values

            for (int pass = valueArray.GetLowerBound(0); pass < valueArray.GetUpperBound(0); pass++) {
                // added a boolean value to track if a swap takes place
                bool swapped = false;
                for (int current = valueArray.GetLowerBound(0); current < valueArray.GetUpperBound(0) - pass; current++) {
                    // bubble the largest remaining item to the top (right) of the array
                    if (valueArray[current] > valueArray[current + 1]) {
                        // wrong order, swap 
                        // swapped boolean value to verify if true
                        swapped = true;
                        temp = valueArray[current];
                        valueArray[current] = valueArray[current + 1];
                        valueArray[current + 1] = temp;
                    }
                }
                // if no swaps take place, break the loop.
                if (!swapped) {
                    break;
                }
            }


            // display the sorted data
            listBoxAfterSort.Items.Clear();
            for (int index = valueArray.GetLowerBound(0); index <= valueArray.GetUpperBound(0); index++) {
                listBoxAfterSort.Items.Add(valueArray[index].ToString());
            }
        }
        #endregion Events

        #region Properties
        #endregion Properties

        #region Methods

        /// <summary>
        /// Thsi routine will display the data in the listBox
        /// </summary>
        /// <param name="theListBox"></param>
        /// <param name="data"></param>
        private void DisplayDataInListBox(ListBox theListBox, int[] data, bool shouldClear = true) {
            if (shouldClear) {
                theListBox.Items.Clear();
            }
            theListBox.Items.Clear();
            for (int index = data.GetLowerBound(0); index <= data.GetUpperBound(0); index++) {
                theListBox.Items.Add(data[index].ToString());
            }
        }

        private void DisplayDataInListBox(ListBox theListBox, double[] data, bool shouldClear = true) {
            if (shouldClear) {
                theListBox.Items.Clear();
            }
            theListBox.Items.Clear();
            for (int index = data.GetLowerBound(0); index <= data.GetUpperBound(0); index++) {
                theListBox.Items.Add(data[index].ToString());
            }
        }


        /// <summary>
        /// This function sorts an array of integer data using a bubble sort.
        /// </summary>
        /// <param name="data"></param>
        private void BubbleSortFunction(int[] data) {

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
        private void Swap(int[] data, int firstIndex, int secondIndex) {
            int temp;

            temp = data[firstIndex];
            data[firstIndex] = data[secondIndex];
            data[secondIndex] = temp;
        }


        #endregion Methods

       
    }
}
