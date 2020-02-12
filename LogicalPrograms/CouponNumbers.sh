echo "enter how meny coupons you want"
read coupons
declare -a arr
echo "coupons are"
for (( i = 0; i < $coupons; i++ )); do
	number=${RANDOM}
	#echo "inside $number"
	a=0
	count=0
	while [[ $number -ne arr[$a] && $a<$coupons ]]; do
		count=$(($count+1))
		a=$(($a+1))
		#echo "inside while $number"
	done
	if [[ $count -eq $coupons ]]; then
		arr[$i]=$number
		#echo $number
	fi
done
for (( i = 0; i < $coupons; i++ )); do
	echo $((arr[$i]))
done