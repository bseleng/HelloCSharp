string[] fakeOrderIds = {
"B123",
"C234",
"A345",
"C15",
"B177",
"G3003",
"C235",
"B179",
};

foreach (string fakeOrderId in fakeOrderIds)
{
    if (fakeOrderId.StartsWith("B"))
    {
        Console.WriteLine(fakeOrderId);
    }
}