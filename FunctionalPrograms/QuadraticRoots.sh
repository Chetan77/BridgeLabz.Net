#!/bin/bash
echo "enter values of a,b and c to find the roots"
read a
read b
read c
delta=$(($(($b*$b))-$((4*$a*$c))))
echo $delta
sqrtdelta=$(echo |awk -v delta=$delta '{print sqrt(delta)}')
echo $sqrtdelta
root1=$(echo | awk -v sqrtdelta=$sqrtdelta -v a=$a -v b=$b  '{print -b + sqrtdelta/(2*a)}')
root2=$(echo | awk -v sqrtdelta=$sqrtdelta -v a=$a -v b=$b  '{print -b - sqrtdelta/(2*a)}')
echo "root1 is = $root1"
echo "root2 is = $root2"
