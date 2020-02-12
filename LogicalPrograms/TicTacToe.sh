echo "welcome to tic tac toe"
declare -A arr
player=0
empty=true
b=false
win==$$
BoardDisply(){
	count=0
	for (( i = 0; i <3; i++ )); do
		echo ""
		echo "-------------"
		echo -n "||"
		for (( j = 0; j < 3; j++ )); do
			if [[ $((arr[$i,$j])) -eq 0 ]]; then
					count=$(($count+1))
				echo -n " o "
			elif [[ $((arr[$i,$j])) -eq 1 ]]; then
					echo -n " x "
					count=$(($count+1))
				else
					echo -n "  "
			fi
		done
		echo -n "||"
	done
	if [[ $count -eq 9 ]]; then
		empty=false
	fi
}
function BoardInitialization(){
for (( i = 0; i < 3; i++ )); do
	for (( j = 0; j < 3; j++ )); do
		arr[$i,$j]=10
	done
done
echo "initia"
BoardDisply
}
function PuttingValue(){
	i=$$
	j=$$
	if [[ $(($player%2)) -eq 1 ]]; then
		i=$(($RANDOM%3))
		j=$(($RANDOM%3))
		else
			echo "enter the i and j indexes"
			read i
			read j
	fi
	if [[ $((arr[$i,$j])) -eq 10 ]]; then
		if [[ $(($player%2)) -eq 0 ]]; then
			arr[$i,$j]=0
			else
				arr[$i,$j]=1
				echo "computer choosen $i and $j"
		fi
		else
			PuttingValue
	fi
}
function Winner(){
	
	if [[ $(($((arr[0,0]))+$((arr[0,1]))+$((arr[0,2])))) == $(($player*3)) ||
	$(($((arr[1,0]))+$((arr[1,1]))+$((arr[1,2])))) == $(($player*3)) ||
	$(($((arr[2,0]))+$((arr[2,1]))+$((arr[2,2])))) == $(($player*3)) ||
	$(($((arr[0,0]))+$((arr[1,0]))+$((arr[2,0])))) == $(($player*3)) ||
	$(($((arr[0,1]))+$((arr[1,1]))+$((arr[2,1])))) == $(($player*3)) ||
	$(($((arr[0,2]))+$((arr[1,2]))+$((arr[2,2])))) == $(($player*3)) ||
	$(($((arr[0,0]))+$((arr[1,1]))+$((arr[2,2])))) == $(($player*3)) ||
	$(($((arr[0,2]))+$((arr[1,1]))+$((arr[2,0])))) == $(($player*3)) ]]; then
		 win=11
		else
			win=22
	fi
	return $win
}
Playing(){
	BoardInitialization
	while [[ empty ]]; do

		echo "player turn"
		PuttingValue
		BoardDisply
		Winner
		if [[ $win == 11 ]]; then
			echo "player won"
			break
		fi
		player=1
		echo "computers turn"
		PuttingValue
		BoardDisply
		Winner
		if [[ $win == 11 ]]; then
			echo "computer won"
			break
		fi
		player=0
	done
	if [[ empty ]]; then
		echo ""
		else
	echo "match draw"
	fi
}
Playing