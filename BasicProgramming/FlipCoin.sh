#!/bin/bash
echo "enter the numberv of times you want to play"
read n
heads=0
for(( i=0;i<=$n;i++ ))
do
if(( ${RANDOM}%2==0))
then
heads=$(($heads+1))
fi
done
echo "number of heads $heads"
echo "number of tails $(($n-$heads))"
echo "head percent is $(($heads*100/$n))"
echo "tail percent is $((($n-$heads)*100/$n))"
