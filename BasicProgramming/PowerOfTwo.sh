#!/bin/bash
echo "enter the value to find the power of two"
read n
val=1
num=$((2**$n))
#echo $num
echo "power of two are"
for((i=1;i<=$num;i++))
do
val=$(($val*2))
echo $val
done
