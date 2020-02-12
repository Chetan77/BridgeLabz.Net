#!/bin/bash
echo "enter the value to find the sum of harmonic number"
read number
sum=0
a=0
for((i=1;i<=$number;i++))
do
a=$(echo|awk -v i=$i -v n=$a '{print(n+1/i)}')
#sum=$(echo|awk -v sum=$sum -v a=$a '{print(sum+a)}')
#echo $sum
done
echo $a

