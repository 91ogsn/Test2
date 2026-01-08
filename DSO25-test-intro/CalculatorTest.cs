namespace DSO25_test_intro;

public class CalculatorTest
{
    [Fact]
    public void TestAdd()
    {
        //given
        Calculator Calc = new();

        int a = 5;
        int b = 2;
        int expectedResult = 7;

        //when
        int result = Calc.Add(a, b);
        //then
        Assert.Equal(expectedResult, result);
    }
}
