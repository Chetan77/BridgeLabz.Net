#!/bin/bash
echo "enter the year to check leap year"
read year
if(($year>1000))
then
if(($year%4==0))
then
if(($year%100==0))
then
if(($year%400==0))
then
echo "$year is leap year"
esle
echo "$year is not a leap year"
fi
else
echo "$year is a leap year"
fi
else
echo "$year is not a leap year"
fi
else
echo "enter a correct year"
fi
