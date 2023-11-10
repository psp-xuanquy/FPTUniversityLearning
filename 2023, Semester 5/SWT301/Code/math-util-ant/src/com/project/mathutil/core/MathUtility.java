package com.project.mathutil.core;

public class MathUtility {

    public static final double PI = 3.14;

    public static long getFactorial(int n) {
        if (n < 0 || n > 20) {
            throw new IllegalArgumentException("Invalid! n must be [0; 20]");
        }

        if (n == 0 || n == 1) {
            return 1;
        }

        long result = 1;
        
        for (int i = 2; i <= n; i++) {
            result *= i;
        }
        return result;
    }
}
