/* COPYRIGHT (C) HARRY CLARK 2024 */

/* LAMBDA EXPRESSION TEST */

/* THIS FILE PERTAINS TOWARDS THE USAGE OF WRITING A SIMPLE LAMBDA EXPRESSION IN C */
/* FOR THE PURPOSES OF DEMONSTRATING CHARACTERISTICS BETWEEN HEAP AND STACK ALLOCATION IN LANGUAGES */

using System;
using System.Collections.Generic; 

public static class Main
{
    // DELEGATE TYPES IN C# ENCOMPASS THE MEANS OF BEING ABLE TO 
    // TAKE INTO ACCOUNT MULTIPLE ITERATIONS OF THE SAME METHOD

    // SUCH ISTHE CASE OF ITERATING THROUGH AN ARRAY, IT WILL
    // ENSURE THE METHOD IN QUESTION IS TYPE SAFE 

    public static delegate void PRINT_DELEGATE(int VALUE);

    public static void PRINT_ELEMENTS(int VALUE)
    {
        Console.WriteLine(VALUE);
    }

    static void Main(string[] args)
    [STAThread]
    {
        int[] NUMS = {2, 3, 7, 14, 23};

        PRINT_DELEGATE PRINT_ARG = PRINT_ELEMENTS;

        foreach (int NUMBER in NUMS)
        {
            PRINT_ARG(NUMBER);
        }
    }
}