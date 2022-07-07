using DateTimeDifference;

Date_n d1 = new(8, 8, 2008);
Date_n d2 = new(16, 3, 2099);

int difference = Date_n.GetDifference(d1, d2);

Console.WriteLine(difference);