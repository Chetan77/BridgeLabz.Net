#!/bin/bash
declare -A array
echo "enter the size of an array"
read size
for((i=0;i<size;i++))
do
for((j=0;j<size;j=j+1))
do
echo "enter the element"
read ele
array[$i,$j]=$ele
done
done
for((i=0;i<size;i++))
do
for((j=0;j<size;j=j+1))
do
echo -n "${array[$i,$j]}  "
done
echo ""
done

