player=1
declare -A arr
function BoardInitialization(){
for (( i = 0; i < 3; i++ )); do
	for (( j = 0; j < 3; j++ )); do
		arr[$i,$j]=1
		echo 1
	done
done
echo "initia"
}
function Winner(){
	win=$$
	echo "inside Winner"
 #echo $(($((arr[0,0]))+$((arr[0,1]))+$((arr[0,2])))) -eq $(($player * 3))

	if [[ $(($((arr[0,0]))+$((arr[0,1]))+$((arr[0,2])))) == $((player*3))||
	$(($((arr[1,0]))+$((arr[1,1]))+$((arr[1,2])))) == $((player*3)) ]]; then
		 win=11
		 echo $win
		else

			win=00
			echo $win
	fi
	return $win
}
BoardInitialization
val=$(Winner)
echo "mmmmmm"
if [[ $(($val)) -eq 11 ]]
then
	echo $val
fi
