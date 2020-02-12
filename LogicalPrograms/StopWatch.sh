#start=$SECONDS
start=$(date +%s.%N)
echo "enter a number after your time over"
read number

end=$(date +%s.%N)
elapsed=$(echo | awk -v start=$start -v end=$end '{print end-start}')
echo "elapsed time between $start and $end is $elapsed"