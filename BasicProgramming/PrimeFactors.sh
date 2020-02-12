echo "enter the number to find the prime factors"
read number
while((($number %2) ==0))
do
echo "2 "
number=$(($number/2))
done
sqr=$(echo | awk -v number=$number '{print(sqrt(number))}')
for((i=3;$i<=$sqr;i==$(i+2)))
do
while(($number % $i==0))
do
echo "$i "
number=$(($number/$i))
done
done
if(($number >2))
then
echo $number
fi
