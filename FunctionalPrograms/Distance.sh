#!/bin/bash
echo "enter the x value from orign"
read x
echo "eneter trhe y value from origin"
read y
sum=$(((($x*$x))+$(($y*$y))))
echo "$sum"
distance=$(echo |awk -v sum=$sum '{print sqrt(sum)}')
echo "$distance"
