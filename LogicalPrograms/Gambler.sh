#!/bin/bash -x
echo "enter the satke"
read stake
echo "enter the goal"
read goal
echo "enter number of times you want to play"
read times
bet=0
win=0
for (( i = 0; i < times; i++ )); do
	cash=$stake
	while [[ $cash>0 && $cash<$goal ]]; do
		bet=$(($bet+1))
		ra=$((${RANDOM}%2))
#echo $ra
	if [[ $ra -eq 1 ]]; then
		cash=$(($cash+1))
		#echo $cash
	else
		cash=$(($cash-1))
		#echo $cash
	fi
	done
	if [[ $cash -eq $goal ]]; then
		win=$(($win+1))
	fi
done
wper=$(echo | awk -v win=$win -v times=$times '{print (win*100)/times}')
echo "number of wins are $win"
echo "win percent is $wper"
echo "bets are $bet"