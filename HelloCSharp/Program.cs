Random random = new Random();
int daysUntilExpiration = random.Next(12);
//  int daysUntilExpiration = 1;
int discountPercentage = 0;

string GetDiscountMessage()
{
    return $"Renew now and save  {discountPercentage}%!";
}

// Your code goes here
if (daysUntilExpiration <= 10)
{
    if (daysUntilExpiration < 1)
    {
        Console.Write("Your subscription has expired.");
    }
    else if (daysUntilExpiration == 1)
    {
        discountPercentage = 20;
        Console.Write($"Your subscription expires within a day!\n{GetDiscountMessage()}");
    }
    else if (daysUntilExpiration <= 5)
    {
        discountPercentage = 10;
        Console.Write($"Your subscription expires in {daysUntilExpiration} days!\n{GetDiscountMessage()}");
    }
    else
    {
        Console.Write("Your subscription will expire soon. Renew now!");

    }
}