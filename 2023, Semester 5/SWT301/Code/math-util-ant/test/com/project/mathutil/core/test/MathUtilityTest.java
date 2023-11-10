package com.project.mathutil.core.test;

import com.project.mathutil.core.MathUtility;
import org.junit.Test;
import static org.junit.Assert.*;

public class MathUtilityTest {

    @Test
    public void verifyFactorialGivenRightArgument5ReturnOk() {
        assertEquals(120, MathUtility.getFactorial(5));
    }
    
    @Test
    public void verifyFactorialGivenRightArgument0ReturnOk() {
        assertEquals(1, MathUtility.getFactorial(0));
    }
}
