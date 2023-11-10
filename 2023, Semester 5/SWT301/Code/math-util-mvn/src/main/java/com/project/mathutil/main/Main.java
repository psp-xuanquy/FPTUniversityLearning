package com.project.mathutil.main;

import com.project.mathutil.core.MathUtility;

public class Main {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
//        Test Case #1
        int n = 0;
        long expected = 1; //(0! = 1)
        long actual = MathUtility.getFactorial(n); //(Execute/Call/Invoke)
        System.out.println(n + "! -- > Expected: " + expected
                + " || Actual: " + actual);

//        Test Case #2
        n = 1;
        expected = 1; //(0! = 1)
        actual = MathUtility.getFactorial(n); //(Execute/Call/Invoke)
        System.out.println(n + "! -- > Expected: " + expected
                + " || Actual: " + actual);

//        Test Case #3
        n = 5;
        expected = 120; //(0! = 1)
        System.out.println(n + "! -- > Expected: " + expected
                + " || Actual: " + MathUtility.getFactorial(n));
    }

}

//Test Case #1: Verify getFactorial (with n = 0)
//Steps-Procedure:                [Các bước run app để test]  
//        1. Given n = 2
//        2. Execute/Call/Invoke function getFactorial(0)
//Expected  Result: the function must return 1 (standing for 0! = 1)
//Status: PASSED || FAILED

//Test Case #2: Verify getFactorial (with n = 1)
//Steps-Procedure:                [Các bước run app để test]
//        1. Given n = 1
//        2. Execute/Call/Invoke function getFactorial(1)
//Expected  Result: the function must return 1 in case of 1!
//Status: PASSED || FAILED

//Test Case #3: Verify getFactorial (with n = 5)
//Steps-Procedure:                [Các bước run app để test]
//        1. Given n = 5
//        2. Execute/Call/Invoke function getFactorial(5)
//Expected  Result: the function must return 120 in case of 5!
//Status: PASSED || FAILED
