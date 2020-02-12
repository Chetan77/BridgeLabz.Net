#!/bin/bash
str="hi username, how are you??"
read name
find="username"
length=`expr length "$name"`
echo "length is $length"
if((length<3))
then
echo "enetr correct name"
else
res=${str/$find/$name}
echo $res
fi

