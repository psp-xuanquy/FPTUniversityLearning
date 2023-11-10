/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit5TestClass.java to edit this template
 */
package com.project.mathutil.core.test;

import com.project.mathutil.core.MathUtility;
import static com.project.mathutil.core.MathUtility.getFactorial;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.function.Executable;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.MethodSource;

/**
 *
 * @author Quy
 */
public class MathUtilityTest {
    
    //chơi DDT, tách data ra khỏi câu lệnh kiểm thử, tham số hóa data này vào tròn câu lệnh kiểm thử
    
    //chuẩn bị bộ data
    public static Object[][] initData() {
        return new Integer[][] {
                                    {1, 1},
                                    {2, 2},
                                    {5, 120},
                                    {6, 720}
                                };
    }
    
    @ParameterizedTest
    @MethodSource(value = "initData") //tên hàm cung cấp data, ngầm định thứ tự các phần tử của mảng, map vào tham số hàm
    public void verifyFactorialGivenRightArgument0ReturnsOk(int input, long expected) {
        assertEquals(expected, com.project.mathutil.core.MathUtility.getFactorial(input));
    }

    
    
//Test Case #1: Verify getFactorial (with n = 0)
//Steps-Procedure:                [Các bước run app để test]  
//        1. Given n = 2
//        2. Call/Invoke function getFactorial(0)
//Expected  Result: the function must return 1 (standing for 0! = 1)
//Status: PASSED || FAILED
    @Test
    public void verifyFactorialGivenRightArgument0ReturnsOk() {
        assertEquals(1, com.project.mathutil.core.MathUtility.getFactorial(0));
    }

//Test Case #2: Verify getFactorial (with n = 1)
//Steps-Procedure:                [Các bước run app để test]
//        1. Given n = 1
//        2. Call/Invoke function getFactorial(1)
//Expected  Result: the function must return 1 in case of 1!
//Status: PASSED || FAILED
    @Test
    public void verifyFactorialGivenRightArgument1ReturnsOk() {
        assertEquals(1, com.project.mathutil.core.MathUtility.getFactorial(1));
    }

//Test Case #3: Verify getFactorial (with n = 5)
//Steps-Procedure:                [Các bước run app để test]
//        1. Given n = 5
//        2. Call/Invoke function getFactorial(5)
//Expected  Result: the function must return 120 in case of 5!
//Status: PASSED || FAILED
    @Test
    public void verifyFactorialGivenRightArgument120ReturnsOk() {
        assertEquals(120, com.project.mathutil.core.MathUtility.getFactorial(5));
    }

    
    
//hàm F() ta thiết kế có 2 tình huống xử lí:
    //1. đưa data vào TỬ TẾ trong [0...20] --> tính được đúng n! - DONE
    //2. đưa data vào CÀ CHỚN(âm/>20); thiết kế của hàm là ném ra ngoại lệ
    //ta kì vọng NGOẠI LỆ xuất hiện khi n < 0 || n > 20
    //Nếu hàm nhận vào n < 0 || n > 20 và hàm nếm ra ngoại lệ => Hàm chạy ĐÚNG như thiết kế --> MÀU XANH xuất hiện
    //Nếu hàm nhận vào n < 0 || n > 20 và hàm KO nếm ra ngoại lệ => Hàm chạy SAI thiết kế, SAI kì vọng --> MÀU ĐỎ
    //Test Case:
    //input: -5 
    //expected: IllegalArgumentException xuất hiện
    //tình huống bất thường, ngoại lệ, ngoài dự tính là những thứ ko thể đo lường, so sánh theo kiểu value, 
    //mà chỉ có thể đo lường bằng cách chúng có xuất hiện hay ko
    //assertEquals() ko dùng để so sánh 2 ngoại lệ
    //      equals() là bằng nhau hay ko trên value!!!
    
    @Test
    public void testGetFactorialGivenWrongArgumentThrowsException() {
        //xài biểu thức Lambda
        //hàm nhận tham số thứ 2 là 1 cái object/có code implement cái functional interface tên là Executable - có 1 hàm duy nhất ko code tên là execute()

//        Executable exObject = new Executable() {
//            @Override
//            public void execute() throws Throwable {
//                MathUtility.getFactorial(-5);
//            }
//        };

//        Executable exObject = () -> getFactorial(-5);

        assertThrows(IllegalArgumentException.class, () -> getFactorial(-5));
    }    
}
