/* COPYRIGHT (C) HARRY CLARK 2024 */

/* LAMBDA EXPRESSION TEST */

/* THIS FILE PERTAINS TOWARDS THE USAGE OF WRITING A SIMPLE LAMBDA EXPRESSION IN C */
/* FOR THE PURPOSES OF DEMONSTRATING CHARACTERISTICS BETWEEN HEAP AND STACK ALLOCATION IN LANGUAGES */

import java.util.*;

public class Main
{
    public static void PRINT_ELEMENTS(int VALUE)
    {
        System.out.println(VALUE);
    }

    public static void main(String[] args)
    {
        int[] NUMS = {2, 3, 7, 14, 23};
        
        for(int NUMBER : NUMS)
        {
            PRINT_ELEMENTS(NUMBER);
        }
    }
}