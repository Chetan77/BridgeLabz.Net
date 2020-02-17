function NameValidation(){
	name=$1
	if [[ $name =~ ^[A-Za-z]+$ ]]; then 
		echo "name is valid"
	else
		echo "name is not valid, enter again"
		return 1
	fi
}
function LastNameValidation(){
	name=$1
	if [[ $name =~ ^[A-Za-z]+$ ]]; then 
		echo "last name is valid"
	else
		echo "last name is not valid, enter again"
		return 1
	fi
}
function EmailValidation(){
	name=$1
	if [[ $name =~ ^[A-Za-z0-9._%]+@[A-Za-z]+\.[A-Za-z]+$ ]]; then 
		echo "email is valid"
	else
		echo "email is not valid, enter again"
		return 1
	fi
}
function NumberValidation(){
	num=$1
	if [[ $num =~ ^[0-9]{10}$ ]]; then
		Printf "number is valid "
		else
			Printf "number is not valid enter again"
			return 1
	fi
}
function PasswordValidation(){
	pass=$1
	len=$2
	echo $len
	if [[ $len -ge 8 ]]; then
		if [[ ${#pass} -ge 6 && "$pass" == *[A-Z]* && "$pass" == *[a-z]* && "$pass" == *[0-9]* && "$pass" == *[@%.]*  ]]; then
		printf "password is valid"
		else
			printf "password is invalid enter again"
			return 1
	fi
	fi
}


echo "This is user Registration page"
echo "enter first name"
read firstName
NameValidation $firstName
fail=$?
while [[ $fail -eq 1 ]]; do
	read firstName
	NameValidation $firstName
	fail=$?
done
echo "Enter last name"
read lastName
LastNameValidation $lastName
last=$?
while [[ $last -eq 1 ]]; do
	read lastName
	LastNameValidation $lastName
	last=$?
done
echo "enter email id"
read email
EmailValidation $email
e=$?
while [[ $e -eq 1 ]]; do
	read email
	EmailValidation $email
	e=$?
done
echo "Enter phone number "
read phNumber
NumberValidation $phNumber
n=$?
while [[ $n -eq 1 ]]; do
	read phNumber
	NumberValidation $phNumber
	n=$?
done
echo "enter password"
read password
len=${#password}
PasswordValidation $password $len
p=$?
while [[ $p -eq 1 ]]; do
	read password
	len=${#password}
	PasswordValidation $password $len
	p=$?
done
