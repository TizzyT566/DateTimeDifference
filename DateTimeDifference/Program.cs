using DateTimeDifference;

Date_n d1 = new(12, 7, 2016);
Date_n d2 = new(9, 7, 2022);

int difference = Date_n.GetDifference(d1, d2);

Console.WriteLine(difference);