echo "enter the temperature in farenheat"
read temperature
echo "enter the velocity in miles per hour"
read speed
vel=$(echo | awk -v speed=$speed '{print speed**0.16}')
#echo $vel
w=$(echo | awk -v t=$temperature -v v=$vel '{print 35.74+0.6215*t+(0.4275*t-35.75)*v}')
echo "wind chill is $w"
