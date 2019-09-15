class MainClass
{
    public static char endOfSessionSwitch;
    public static double salesAmount;
    public static double taxAmount;

    public static void Main(string[] args)
    {
        calculateSalesTax();
    }

    //a method that will call the calculateOneSalesTax() method until the user inputs 0
    private static void calculateSalesTax()
    {
        do
        {
            calculateOneSalesTax();
        } while (endOfSessionSwitch != 'Y');
    }

    //prompt the user to enter the Sales Amount to calculate the Sales Tax or enter 0 to end the program
    private static void calculateOneSalesTax()
    {
        Console.Write("__________________________________________________\n");
        Console.Write("TO END PROGRAM, ENTER 0.\n");
        Console.Write("TO CALCULATE SALES TAX, ENTER THE SALES AMOUNT.\n");
        salesAmount = Convert.ToDouble(Console.ReadLine()); //the number that the user inputs will be stored in the salesAmount variable

         
        if(salesAmount <= 0)
        {
            endOfSessionSwitch = 'Y'; //if salesAmount enter is less than or equal to 0 then end the program
        }
        else
        {
            //if salesAmount is greater than 0 then calculate the taxAmount and print the sales tax
            taxAmount = salesAmount * 0.0785;
            Console.Write("The Sales Tax = " + taxAmount + "\n");
        }
    }
}
