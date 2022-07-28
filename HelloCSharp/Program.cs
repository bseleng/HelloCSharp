Random coinFlip = new Random();
int coinSide = coinFlip.Next(0, 2);

Console.WriteLine($"{((coinSide == 0) ? "tails" : "heads")}\r\nrandom value:{coinSide}");

