#!/bin/bash -x
echo "enter the size of elements you want to add"
read size
declare -a arr
for((i=0;i<size;i++))
do
	echo "enter the element"
	read number
	arr[$i]=$number
done
echo "${arr[*]}"
for((i=0;i<$((size-2));i++))
do
	echo "in first loop"
	for((j=$((i+1));j<$((size-1));j++))
	do
		echo "in second loop"
		for((k=$((j+1));k<$size;k++))
		do
			echo "in third loop"
			if(( $(( ${arr[$i]}+${arr[$j]}+${arr[$k]} ))==0 ))
			then
				echo "${arr[$i]} , ${arr[$j]} , ${arr[$k]} are adds to zero"
			else
				echo "${arr[$i]} , ${arr[$j]} , ${arr[$k]} are not adds to zero"
			fi
		done
	done
done
